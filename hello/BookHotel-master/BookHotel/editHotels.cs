using System;
using System.Drawing;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class editHotels : Form
    {
        private Room _room;
        private string _imageUrl;

        public event Action RoomUpdated;

        public editHotels(Room room)
        {
            InitializeComponent();

            _room = room;
            _imageUrl = room.RoomImageUrl;


            //if (room.RoomImageUrl != null)
            //{
            //    MessageBox.Show("Current image URL:\n" + room.RoomImageUrl);
            //}

            //if(_room == null)
            //{
            //    MessageBox.Show("Error: Room data is missing.");
            //    Close();
            //}

            this.Load += editHotels_Load;
        }

        private void editHotels_Load(object sender, EventArgs e)
        {
            RoomName.Text = _room.RoomName;
            NumberAvailable.Text = _room.RoomNumber;
            DescriptionBox.Text = _room.RoomDescription;

            txtPrice1.Text = _room.WeekdayPrice3h.ToString();
            txtPrice2.Text = _room.WeekendPrice3h.ToString();
            txtPrice3.Text = _room.WeekdayPrice12h.ToString();
            txtPrice4.Text = _room.WeekendPrice12h.ToString();

            AvailableBox.Checked =
                _room.Status?.ToLower() == "available";

            if (!string.IsNullOrWhiteSpace(_room.RoomImageUrl))
            {
                try
                {
                    RoomImage.LoadAsync(_room.RoomImageUrl);
                }
                catch
                {
                }
            }
        }

        private void RoomImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    RoomImage.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            SaveButton.Text = "Updating...";

            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(RoomName.Text))
                {
                    MessageBox.Show("Room name is required.");
                    return;
                }

                if (!decimal.TryParse(txtPrice1.Text, out decimal weekday3h) ||
                    !decimal.TryParse(txtPrice2.Text, out decimal weekend3h) ||
                    !decimal.TryParse(txtPrice3.Text, out decimal weekday12h) ||
                    !decimal.TryParse(txtPrice4.Text, out decimal weekend12h))
                {
                    MessageBox.Show("Please enter valid prices.");
                    return;
                }

                string imageUrl = _imageUrl;

                // Upload image only if user selected a new one
                if (RoomImage.Image != null &&
                    (string.IsNullOrEmpty(_imageUrl) || !RoomImage.ImageLocation?.Equals(_imageUrl) == true))
                {
                    using (var ms = new System.IO.MemoryStream())
                    using (Bitmap bmp = new Bitmap(RoomImage.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        imageUrl = await AuthService.UploadRoomImage(
                            ms.ToArray(),
                            Guid.NewGuid() + ".jpg"
                        );
                    }
                }

                var updatedRoom = new Room
                {
                    Id = _room.Id,
                    RoomNumber = NumberAvailable.Text.Trim(),
                    RoomName = RoomName.Text.Trim(),
                    RoomDescription = DescriptionBox.Text.Trim(),
                    WeekdayPrice3h = weekday3h,
                    WeekendPrice3h = weekend3h,
                    WeekdayPrice12h = weekday12h,
                    WeekendPrice12h = weekend12h,
                    Status = AvailableBox.Checked ? "available" : "occupied",
                    RoomImageUrl = imageUrl
                };

                string result = await AuthService.UpdateRoom(updatedRoom);

                if (result == "success")
                {
                    MessageBox.Show("Hotel updated successfully!");

                    RoomUpdated?.Invoke();

                    Close();
                }
                else
                {
                    MessageBox.Show("Update failed:\n" + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
            finally
            {
                SaveButton.Enabled = true;
                SaveButton.Text = "Save";
            }
        }

        private void RoomName_TextChanged(object sender, EventArgs e) { }
        private void RoomCountLabel_Click(object sender, EventArgs e) { }
        private void NumberAvailable_TextChanged(object sender, EventArgs e) { }
        private void Weekday3Label_Click(object sender, EventArgs e) { }
        private void txtPrice1_TextChanged(object sender, EventArgs e) { }
        private void Weekend3Label_Click(object sender, EventArgs e) { }
        private void RoomPanel_Paint(object sender, PaintEventArgs e) { }
        private void txtPrice2_TextChanged(object sender, EventArgs e) { }
        private void Weekday12Label_Click(object sender, EventArgs e) { }
        private void txtPrice3_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtPrice4_TextChanged(object sender, EventArgs e) { }
        private void DescriptionBox_TextChanged(object sender, EventArgs e) { }
        private void AvailableBox_CheckedChanged(object sender, EventArgs e) { }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
                    var result = MessageBox.Show(
               "Are you sure you want to delete this room?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (result != DialogResult.Yes)
                return;

            string response = await AuthService.DeleteRoom(_room.Id);

            if (response == "success")
            {
                MessageBox.Show("Room deleted successfully.");

                RoomUpdated?.Invoke();

                Close();
            }
            else
            {
                MessageBox.Show(response);
            }
        }
    }
}
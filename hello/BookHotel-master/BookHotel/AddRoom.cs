using System;
using System.Drawing;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // 1. Link all 20 buttons in your flowLayoutPanel to the click event
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is Button btn)
                    btn.Click += RoomButton_Click;
            }

            // 2. Lock the textbox so users can only pick numbers via buttons
            NumberAvailable.ReadOnly = true;
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
                NumberAvailable.Text = btn.Text;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (RoomImage.Image == null || string.IsNullOrWhiteSpace(NumberAvailable.Text))
            {
                MessageBox.Show("Please select a room number and an image.");
                return;
            }

            SaveButton.Enabled = false;
            SaveButton.Text = "Saving...";

            try
            {
                // Upload Image (Clone technique avoids GDI+ generic error)
                string imageUrl = "";
                using (var ms = new System.IO.MemoryStream())
                {
                    using (Bitmap bmp = new Bitmap(RoomImage.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    ms.Position = 0;
                    imageUrl = await AuthService.UploadRoomImage(ms.ToArray(), Guid.NewGuid().ToString() + ".jpg");
                }

                // Create Room Object
                var room = new Room
                {
                    RoomNumber = NumberAvailable.Text,
                    RoomName = RoomName.Text,
                    RoomDescription = DescriptionBox.Text,
                    WeekdayPrice3h = decimal.Parse(txtPrice1.Text),
                    WeekendPrice3h = decimal.Parse(txtPrice2.Text),
                    WeekdayPrice12h = decimal.Parse(txtPrice3.Text),
                    WeekendPrice12h = decimal.Parse(txtPrice4.Text),
                    Status = AvailableBox.Checked ? "available" : "occupied",
                    RoomImageUrl = imageUrl
                };

                // Save to Supabase
                string result = await AuthService.SaveRoom(room);

                if (result == "success")
                    MessageBox.Show("Room saved successfully!");
                else if (result.Contains("23505"))
                    MessageBox.Show("Error: Room " + NumberAvailable.Text + " already exists.");
                else
                    MessageBox.Show("Error: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application Error: " + ex.Message);
            }
            finally
            {
                SaveButton.Enabled = true;
                SaveButton.Text = "Save";
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

        // Empty handlers to prevent designer errors if they are wired up
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
        private void Room1_Click(object sender, EventArgs e) { }
        private void Room2_Click(object sender, EventArgs e) { }
        private void Room3_Click(object sender, EventArgs e) { }
        private void RoomName_TextChanged(object sender, EventArgs e) { }
    }
}
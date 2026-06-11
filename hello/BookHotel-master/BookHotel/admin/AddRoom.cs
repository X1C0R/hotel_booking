using System;
using System.Drawing;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class AddRoom : Form
    {
        public event Action RoomSaved;
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // 1. Link all 20 buttons in your flowLayoutPanel to the click event
           

            // 2. Lock the textbox so users can only pick numbers via buttons
            NumberAvailable.ReadOnly = false;


        }

       

    private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (RoomImage.Image == null || string.IsNullOrWhiteSpace(NumberAvailable.Text))
            {
                MessageBox.Show("Please select a room number and number of rooms.");
                return;
            }

            SaveButton.Enabled = false;
            SaveButton.Text = "Saving...";

            try
            {
                // Upload image once
                string imageUrl;
                using (var ms = new System.IO.MemoryStream())
                using (Bitmap bmp = new Bitmap(RoomImage.Image))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageUrl = await AuthService.UploadRoomImage(
                        ms.ToArray(),
                        Guid.NewGuid() + ".jpg"
                    );
                }

                // parse starting room number
                // how many rooms to create
                if (!int.TryParse(NumberAvailable.Text, out int roomCount))
                {
                    MessageBox.Show("Invalid number format.");
                    return;
                }

                int startingNumber = 1;

                for (int i = 0; i < roomCount; i++)
                {
                    int currentRoomNumber = startingNumber + i;

                    var room = new Room
                    {
                        // Use the current loop count to ensure unique numbers
                        RoomNumber = currentRoomNumber.ToString(),
                        RoomName = RoomName.Text + " " + currentRoomNumber,
                        RoomDescription = DescriptionBox.Text,
                        WeekdayPrice3h = decimal.Parse(txtPrice1.Text),
                        WeekendPrice3h = decimal.Parse(txtPrice2.Text),
                        WeekdayPrice12h = decimal.Parse(txtPrice3.Text),
                        WeekendPrice12h = decimal.Parse(txtPrice4.Text),
                        Status = AvailableBox.Checked ? "available" : "occupied",
                        RoomImageUrl = imageUrl
                    };

                    await AuthService.SaveRoom(room);
                }

                MessageBox.Show($"{roomCount} rooms created successfully!");

                RoomSaved?.Invoke();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void NumberAvailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomAvailableInput_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
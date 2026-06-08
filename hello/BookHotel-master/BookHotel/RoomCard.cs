using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookHotel
{
    public partial class RoomCard : UserControl
    {
        public RoomCard(BookHotel.backend.Room room)
        {
            InitializeComponent();

            lblRoomName.Text = room.RoomName;
            RoomNumber.Text = $"Room {room.RoomNumber}";
            RoomDesc.Text = room.RoomDescription;
            WeekEndPrice.Text = $"Weekend 3h: ${room.WeekendPrice3h}\nWeekend 12h: ${room.WeekendPrice12h}";
            WeekDaysPrice.Text = $"Weekday 3h: ${room.WeekdayPrice3h}\nWeekday 12h: ${room.WeekdayPrice12h}";
            Status.Text = $"Status: {room.Status}";
            // Load image async so it doesn't block the UI
            if (!string.IsNullOrEmpty(room.RoomImageUrl))
            {
                pbRoomImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbRoomImage.LoadAsync(room.RoomImageUrl);
            }
            else
            {
                pbRoomImage.BackColor = Color.FromArgb(30, 41, 59);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RoomNumber_Click(object sender, EventArgs e)
        {

        }

        private void RoomDesc_Click(object sender, EventArgs e)
        {

        }

        private void WeekDaysPrice_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }
    }
}
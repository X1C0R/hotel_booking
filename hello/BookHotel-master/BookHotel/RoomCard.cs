using System;
using System.Drawing;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class RoomCard : UserControl
    {
        private Room _room;

        public event Action RoomUpdated;

        public RoomCard(Room room)
        {
            InitializeComponent();

            _room = room;

            UiHelper.MakeRounded(this, 5);

            this.Cursor = Cursors.Hand;

            lblRoomName.Text = room.RoomName;
            RoomNumber.Text = $"Room {room.RoomNumber}";
            RoomDesc.Text = room.RoomDescription;

            WeekEndPrice.Text =
                $"Weekend 3h: ₱{room.WeekendPrice3h}\n" +
                $"Weekend 12h: ₱{room.WeekendPrice12h}";

            WeekDaysPrice.Text =
                $"Weekday 3h: ₱{room.WeekdayPrice3h}\n" +
                $"Weekday 12h: ₱{room.WeekdayPrice12h}";

            Status.Text = $"Status: {room.Status}";

            if (!string.IsNullOrEmpty(room.RoomImageUrl))
            {
                pbRoomImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbRoomImage.LoadAsync(room.RoomImageUrl);
            }
            else
            {
                pbRoomImage.BackColor = Color.FromArgb(30, 41, 59);
            }

            // Make the entire card clickable
            MakeCardClickable(this);
        }

        private void MakeCardClickable(Control control)
        {
            control.Cursor = Cursors.Hand;
            control.Click += RoomCard_Click;

            foreach (Control child in control.Controls)
            {
                MakeCardClickable(child);
            }
        }

        private void RoomCard_Click(object sender, EventArgs e)
        {
            var editForm = new editHotels(_room);

            editForm.RoomUpdated += () =>
            {
                RoomUpdated?.Invoke();
            };

            editForm.ShowDialog();
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

        private void pbRoomImage_Click(object sender, EventArgs e)
        {
        }

        private void RoomCard_Load(object sender, EventArgs e)
        {
        }
    }
}
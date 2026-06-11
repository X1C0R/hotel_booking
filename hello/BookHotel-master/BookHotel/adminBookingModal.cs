using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class adminBookingModal : Form
    {
        private BookingWithProfile _booking;

        public adminBookingModal(BookingWithProfile booking)
        {
            InitializeComponent();
            _booking = booking;
        }

        private async void adminBookingModal_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadRoomImage();
        }

        private Task LoadData()
        {
            var p = _booking.profile;

            // USER INFO
            Lbemail.Text = "Email: " + (p?.Email ?? "N/A");
            LbFirstName.Text = "First Name: " + (p?.FirstName ?? "N/A");
            LbLastName.Text = "Last Name: " + (p?.LastName ?? "N/A");
            LbPhoneNum.Text = "Phone: " + (p?.ContactNum ?? "N/A");

            // BOOKING INFO
            LbRoomName.Text = "Room: " + _booking.RoomName;

            // ⚠️ FIX: DO NOT fake RoomNumber using GUID
            // If you don’t have RoomNumber in Booking, show RoomName instead
            LbRoomNumber.Text = "Room #: " + _booking.RoomName;

            LbCreated_at.Text =
                "Booked At: " + _booking.CreatedAt.ToString("MMM dd, yyyy hh:mm tt");

            LbBookDate.Text =
                "Check-in Date: " + _booking.CheckIn.ToString("MMM dd, yyyy");

            LbTime.Text =
                "Duration: " + _booking.DurationHours + " hours";

            return Task.CompletedTask;
        }

        private async Task LoadRoomImage()
        {
            try
            {
                var supabase = await AuthService.Initialize();

                var room = await supabase
                    .From<Room>()
                    .Where(x => x.Id == _booking.RoomId)
                    .Single();

                if (room != null && !string.IsNullOrEmpty(room.RoomImageUrl))
                {
                    hotelImage.Load(room.RoomImageUrl);
                    hotelImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
                // ignore image errors
            }
        }

        // =========================
        // 🔥 FIXED BUTTON LOGIC
        // =========================

        private async void PaidBtn_Click(object sender, EventArgs e)
        {
            var result = await AuthService.ApproveBooking(_booking.Id);

            MessageBox.Show(result);

            this.Close();
        }
        private async void CancelBTN_Click(object sender, EventArgs e)
        {
            var result = await AuthService.RejectBooking(_booking.Id);

            MessageBox.Show(result);

            this.Close();
        }
    }
}
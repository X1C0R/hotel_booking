using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHotel.backend;

namespace BookHotel
{
    public partial class Profile : Form
    {
        private Guid _userId;

        public Profile(string userId)
        {
            InitializeComponent();

            Guid.TryParse(userId, out _userId);

            SetPlaceholder(FirstNameBox, "First Name");
            SetPlaceholder(MiddleNameBox, "Middle Name");
            SetPlaceholder(LastNameBox, "Last Name");
            SetPlaceholder(EmailBox, "Email Address");
            SetPlaceholder(NumberBox, "Contact Number");
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            RoundControl(HeaderPanel, 30);
            UiHelper.MakeRounded(ProfileHeaderPanel, 20);
            UiHelper.MakeRounded(ProfileBackgroundPanel, 20);
            UiHelper.MakeRounded(panel1, 20);
            UiHelper.RoundButton(SaveButton, 10);

            RecentPanel.AutoScroll = true;
            



            await LoadProfileAsync();
            await LoadRecentBookingsAsync();
        }

        // ── PROFILE DATA ─────────────────────────────
        private async Task LoadProfileAsync()
        {
            try
            {
                var profile = await AuthService.GetProfileById(_userId);

                if (profile == null)
                {
                    MessageBox.Show("Profile not found.");
                    return;
                }

                FirstNameBox.Text = string.IsNullOrWhiteSpace(profile.FirstName)
                    ? FirstNameBox.Tag.ToString()
                    : profile.FirstName;

                MiddleNameBox.Text = string.IsNullOrWhiteSpace(profile.MiddleName)
                    ? MiddleNameBox.Tag.ToString()
                    : profile.MiddleName;

                LastNameBox.Text = string.IsNullOrWhiteSpace(profile.LastName)
                    ? LastNameBox.Tag.ToString()
                    : profile.LastName;

                EmailBox.Text = string.IsNullOrWhiteSpace(profile.Email)
                    ? EmailBox.Tag.ToString()
                    : profile.Email;

                NumberBox.Text = string.IsNullOrWhiteSpace(profile.ContactNum)
                    ? NumberBox.Tag.ToString()
                    : profile.ContactNum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ── RECENT BOOKINGS (USES YOUR DESIGNER PANEL) ─────────────────
        private async Task LoadRecentBookingsAsync()
        {
            RecentPanel.Controls.Clear();

            try
            {
                var bookings = await AuthService.GetUserRecentBookings(_userId);

                if (bookings == null || bookings.Count == 0)
                {
                    RecentPanel.Controls.Add(new Label
                    {
                        Text = "No recent bookings yet.",
                        ForeColor = Color.Gray,
                        AutoSize = true,
                        Font = new Font("Tahoma", 11),
                        Padding = new Padding(10)
                    });
                    return;
                }

                RecentPanel.Controls.Clear();

                int y = 10;

                foreach (var b in bookings)
                {
                    var card = CreateBookingCard(b);

                    card.Location = new Point(10, y);
                    RecentPanel.Controls.Add(card);

                    y += card.Height + 10;
                }

                RecentPanel.AutoScroll = true;
                RecentPanel.AutoScrollMinSize = new Size(0, y + 20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ── BUILD BOOKING CARD USING YOUR DESIGN STYLE ───────────────
        private Panel CreateBookingCard(Booking b)
        {
            var panel = new Panel
            {
                Width = 540,
                Height = 67,
                BackColor = Color.White,
                Margin = new Padding(3)
            };

            panel.Controls.Add(new Label
            {
                Text = b.RoomName,
                Font = new Font("Tahoma", 12),
                Location = new Point(13, 23),
                AutoSize = true
            });

            panel.Controls.Add(new Label
            {
                Text = b.CreatedAt.ToString("MM/dd/yy"),
                Font = new Font("Tahoma", 12),
                Location = new Point(167, 23),
                AutoSize = true
            });

            panel.Controls.Add(new Label
            {
                Text = $"{b.CheckIn:hh:mm tt}",
                Font = new Font("Tahoma", 12),
                Location = new Point(248, 23),
                AutoSize = true
            });

            //var cancelBtn = new Button
            //{
            //    Text = "Cancel",
            //    Width = 67,
            //    Height = 31,
            //    Location = new Point(471, 17)
            //};

            var statusColor =
               b.Status == "approved" ? Color.Green :
               b.Status == "rejected" ? Color.Red :
               Color.Goldenrod;

            panel.Controls.Add(new Label
            {
                Text = b.Status ?? "pending",
                Font = new Font("Tahoma", 11, FontStyle.Bold),
                ForeColor = statusColor,
                Location = new Point(471, 17),
                AutoSize = true
            });

            //cancelBtn.Click += async (s, e) =>
            //{
            //    var confirm = MessageBox.Show(
            //        "Cancel this booking?",
            //        "Confirm",
            //        MessageBoxButtons.YesNo
            //    );

            //    if (confirm == DialogResult.Yes)
            //    {
            //        await AuthService.CancelBooking(b.Id);
            //        await LoadRecentBookingsAsync();
            //    }
            //};

            //panel.Controls.Add(cancelBtn);

            return panel;
        }

        // ── SAVE PROFILE ─────────────────────────────
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var updated = new UserProfile
            {
                Id = _userId,
                FirstName = FirstNameBox.Text,
                MiddleName = MiddleNameBox.Text,
                LastName = LastNameBox.Text,
                Email = EmailBox.Text,
                ContactNum = NumberBox.Text
            };

            var result = await AuthService.UpdateProfile(updated);

            MessageBox.Show(result == "success"
                ? "Profile updated!"
                : result);
        }

        // ── UI ROUNDING ─────────────────────────────
        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e) { }
        private void FirstNameBox_TextChanged(object sender, EventArgs e) { }
        private void MiddleNameBox_TextChanged(object sender, EventArgs e) { }
        private void LastNameBox_TextChanged(object sender, EventArgs e) { }
        private void EmailBox_TextChanged(object sender, EventArgs e) { }
        private void NumberBox_TextChanged(object sender, EventArgs e) { }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(_userId.ToString());
            homepage.Show();
            this.Close();
        }

        private void SetPlaceholder(TextBox box, string placeholder)
        {
            box.Tag = placeholder;
            box.Text = placeholder;
            box.ForeColor = Color.Gray;

            box.Enter += RemovePlaceholder;
            box.Leave += SetPlaceholderOnLeave;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (box.Text == box.Tag.ToString())
            {
                box.Text = "";
                box.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderOnLeave(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (string.IsNullOrWhiteSpace(box.Text))
            {
                box.Text = box.Tag.ToString();
                box.ForeColor = Color.Gray;
            }
        }

        private void ProfileHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecentLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileBackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
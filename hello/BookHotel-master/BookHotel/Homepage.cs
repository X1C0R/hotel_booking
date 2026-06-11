using BookHotel.backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHotel
{
    public partial class Homepage : Form
    {
        private List<Image> galleryImages = new List<Image>();
        private int currentImageIndex = 0;

        private string _loggedInUserId;

 
        public Homepage(string userId)
        {
            InitializeComponent();
            _loggedInUserId = userId;

            RoomListPanel.AutoScroll = true;
            RoomListPanel.FlowDirection = FlowDirection.LeftToRight;
            RoomListPanel.WrapContents = false;


            UiHelper.MakeRounded(HotelPage, 20);

        }

 

        private async void Homepage_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 1500);

            MakeCircular(LeftLabel);
            MakeCircular(RightLabel);
            RoundControl(HeaderPanel, 30);
            RoundPictureBoxCorners(PictureBoxGallery, 40);

            galleryImages.Add(Properties.Resources.regency_room_popular);
            galleryImages.Add(Properties.Resources.sakura_room_popular);
            galleryImages.Add(Properties.Resources.greece_room_popular);

            PictureBoxGallery.Image = galleryImages[0];

            await LoadRoomsAsync();
        }

        private void MakeCircular(Label lbl)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, lbl.Width, lbl.Height);
            lbl.Region = new Region(path);
        }

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

        private void RoundPictureBoxCorners(PictureBox pictureBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pictureBox.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pictureBox.Width - radius, pictureBox.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pictureBox.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            pictureBox.Region = new Region(path);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void RightLabel_Click(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= galleryImages.Count)
            {
                currentImageIndex = 0;
            }

            PictureBoxGallery.Image = galleryImages[currentImageIndex];
        }

        private void LeftLabel_Click(object sender, EventArgs e)
        {
            currentImageIndex--;

            if (currentImageIndex < 0)
            {
                currentImageIndex = galleryImages.Count - 1;
            }

            PictureBoxGallery.Image = galleryImages[currentImageIndex];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= galleryImages.Count)
            {
                currentImageIndex = 0;
            }

            PictureBoxGallery.Image = galleryImages[currentImageIndex];
        }

        private void HotelPage_Click(object sender, EventArgs e)
        {
            
            Hotels hotels = new Hotels(_loggedInUserId);
            hotels.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            new Login().Show(); 
            this.Close();
        }

        private void RoomListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task LoadRoomsAsync()
        {
            RoomListPanel.Controls.Clear();

            try
            {
                var rooms = await backend.AuthService.GetRoomsAsync();

                if (rooms == null || rooms.Count == 0)
                {
                    RoomListPanel.Controls.Add(new Label
                    {
                        Text = "No rooms available.",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 12),
                        Location = new Point(20, 20)
                    });

                    return;
                }

                foreach (var room in rooms)
                {
                    RoomListPanel.Controls.Add(MakeRoomCard(room));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Panel MakeRoomCard(backend.Room room)
        {
            var card = new Panel
            {
                Width = 260,
                Height = 360,
                Margin = new Padding(12),
                BackColor = Color.Maroon,
                ForeColor = Color.AntiqueWhite
            };

            card.Paint += (s, e) =>
                {
                    var p = s as Panel;

                    int radius = 5;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        Rectangle rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
                        int d = radius * 2;

                        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                        path.CloseFigure();

                        // border
                        using (Pen pen = new Pen(Color.WhiteSmoke, 2))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                };

            var pb = new PictureBox
            {
                Width = 250,
                Height = 160,
                Top = 10,
                Left = 5,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Maroon
            };

            pb.Paint += (s, e) =>
            {
                var box = s as PictureBox;

                int radius = 15;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, box.Width - 1, box.Height - 1);
                int d = radius * 2;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                    path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                    path.CloseFigure();

                    // clip image
                    box.Region = new Region(path);

                    // border
                    using (Pen pen = new Pen(Color.WhiteSmoke, 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };

            if (!string.IsNullOrEmpty(room.RoomImageUrl))
                pb.LoadAsync(room.RoomImageUrl);

            card.Controls.Add(pb);

            card.Controls.Add(new Label
            {
                Text = room.RoomName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Left = 10,
                Top = 170,
                Width = 230
            });

            card.Controls.Add(new Label
            {
                Text = "Room " + room.RoomNumber,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Left = 10,
                Top = 195,
                Width = 230
            });

            card.Controls.Add(new Label
            {
                Text = $"Weekday 3h: ₱{room.WeekdayPrice3h:N2}",
                Left = 10,
                Top = 225,
                Width = 230
            });

            //card.Controls.Add(new Label
            //{
            //    Text = $"Weekend 3h: ₱{room.WeekendPrice3h:N2}",
            //    Left = 10,
            //    Top = 245,
            //    Width = 230
            //});

            //card.Controls.Add(new Label
            //{
            //    Text = $"Weekday 12h: ₱{room.WeekdayPrice12h:N2}",
            //    Left = 10,
            //    Top = 265,
            //    Width = 230
            //});

            //card.Controls.Add(new Label
            //{
            //    Text = $"Weekend 12h: ₱{room.WeekendPrice12h:N2}",
            //    Left = 10,
            //    Top = 285,
            //    Width = 230
            //});

            Button bookBtn = new Button
            {
                Text = "Book Now",
                Width = 220,
                Height = 35,
                Left = 20,
                Top = 250
            };

            bookBtn.Click += async (s, e) =>
            {
                try
                {
                    var profile = await backend.AuthService.GetProfileById(
                        Guid.Parse(_loggedInUserId)
                    );

                    if (!IsProfileComplete(profile))
                    {
                        MessageBox.Show(
                            "Please complete your profile (First Name, Middle Name, Last Name, Contact Number) before booking a room.",
                            "Profile Incomplete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        // optional: send them to profile page
                        var goProfile = MessageBox.Show(
                            "Go to Profile page now?",
                            "Redirect",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (goProfile == DialogResult.Yes)
                        {
                            this.Hide();
                            Profile profileForm = new Profile(_loggedInUserId);
                            profileForm.FormClosed += (x, args) => this.Show();
                            profileForm.Show();
                        }

                        return;
                    }

                    using (var modal = new BookingModal(room, _loggedInUserId))
                    {
                        modal.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };

            card.Controls.Add(bookBtn);

            return card;
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(_loggedInUserId);
            profile.FormClosed += (s, args) => this.Show();
            profile.Show();
        }

        private bool IsProfileComplete(UserProfile profile)
        {
            return profile != null &&
                   !string.IsNullOrWhiteSpace(profile.FirstName) &&
                   !string.IsNullOrWhiteSpace(profile.MiddleName) &&
                   !string.IsNullOrWhiteSpace(profile.LastName) &&
                   !string.IsNullOrWhiteSpace(profile.ContactNum);
        }
    }
}
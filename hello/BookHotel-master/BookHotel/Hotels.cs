using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHotel
{
    public partial class Hotels : Form
    {
        // 1. Added a private variable to hold the user's ID
        private string _loggedInUserId;

        // 2. Updated the constructor to accept the user ID when this form opens
        public Hotels(string userId)
        {
            InitializeComponent();
            _loggedInUserId = userId; // Store it for later use
        }

        private async void Hotels_Load(object sender, EventArgs e)
        {
            await LoadRoomsAsync();
        }

        // ── Load rooms from Supabase and render cards ─────────────────────────
        private async Task LoadRoomsAsync()
        {
            RoomsGrid.Controls.Clear();

            var loading = new Label
            {
                Text = "Loading available rooms...",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 20),
            };
            RoomsGrid.Controls.Add(loading);

            try
            {
                var supabase = await backend.AuthService.Initialize();

                // ✅ Use raw HTTP fetch instead of ORM so id is guaranteed to populate
                var rooms = await backend.AuthService.GetRoomsAsync();

                RoomsGrid.SuspendLayout();
                RoomsGrid.Controls.Clear();

                if (rooms == null || rooms.Count == 0)
                {
                    // ... your empty label ...
                    RoomsGrid.ResumeLayout();
                    return;
                }

                foreach (var room in rooms)
                    RoomsGrid.Controls.Add(MakeRoomCard(room));

                RoomsGrid.ResumeLayout();
            }
            catch (Exception ex)
            {
                RoomsGrid.Controls.Clear();
                RoomsGrid.Controls.Add(new Label
                {
                    Text = "Error loading rooms: " + ex.Message,
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(20, 20),
                });
            }
        }

        // ── Build a single room card ──────────────────────────────────────────
        private Panel MakeRoomCard(backend.Room room)
        {
            var card = new Panel
            {
                Width = 260,
                Height = 360,
                Margin = new Padding(12),
                BackColor = Color.White,
                Cursor = Cursors.Default,
            };

            // Rounded corners
            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundRect(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 16))
                using (var bg = new SolidBrush(Color.White))
                using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1.5f))
                {
                    g.FillPath(bg, path);
                    g.DrawPath(pen, path);
                }
            };
            card.Region = RoundedRegion(card.Width, card.Height, 16);

            // ── Room image ────────────────────────────────────────────────────
            var pb = new PictureBox
            {
                Width = 260,
                Height = 160,
                Top = 0,
                Left = 0,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240),
            };
            if (!string.IsNullOrEmpty(room.RoomImageUrl))
                pb.LoadAsync(room.RoomImageUrl);

            card.Controls.Add(pb);

            // ── Room name ─────────────────────────────────────────────────────
            var nameLabel = new Label
            {
                Text = room.RoomName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                Left = 12,
                Top = 168,
                Width = 236,
                Height = 24,
                BackColor = Color.Transparent,
            };
            card.Controls.Add(nameLabel);

            // ── Room number ───────────────────────────────────────────────────
            var numLabel = new Label
            {
                Text = "Room " + room.RoomNumber,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Left = 12,
                Top = 192,
                Width = 236,
                Height = 18,
                BackColor = Color.Transparent,
            };
            card.Controls.Add(numLabel);

            // ── Price table ───────────────────────────────────────────────────
            int py = 216;
            card.Controls.Add(MakePriceRow("Weekday 3h", room.WeekdayPrice3h, 12, py)); py += 20;
            card.Controls.Add(MakePriceRow("Weekend 3h", room.WeekendPrice3h, 12, py)); py += 20;
            card.Controls.Add(MakePriceRow("Weekday 12h", room.WeekdayPrice12h, 12, py)); py += 20;
            card.Controls.Add(MakePriceRow("Weekend 12h", room.WeekendPrice12h, 12, py)); py += 24;

            // ── Book button ───────────────────────────────────────────────────
            var bookBtn = new Button
            {
                Text = "Book Now",
                Left = 12,
                Top = py,
                Width = 236,
                Height = 40,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 38, 38),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };
            bookBtn.FlatAppearance.BorderSize = 0;
            bookBtn.Click += (s, e) => OpenBookingModal(room);

            // Rounded button
            bookBtn.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundRect(new Rectangle(0, 0, bookBtn.Width - 1, bookBtn.Height - 1), 10))
                using (var bg = new SolidBrush(Color.FromArgb(220, 38, 38)))
                {
                    g.FillPath(bg, path);
                    TextRenderer.DrawText(g, bookBtn.Text, bookBtn.Font,
                        new Rectangle(0, 0, bookBtn.Width, bookBtn.Height),
                        Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            };
            bookBtn.Region = RoundedRegion(bookBtn.Width, bookBtn.Height, 10);

            card.Controls.Add(bookBtn);

            return card;
        }

        private Panel MakePriceRow(string label, decimal price, int x, int y)
        {
            var row = new Panel
            {
                Left = x,
                Top = y,
                Width = 236,
                Height = 18,
                BackColor = Color.Transparent,
            };

            row.Controls.Add(new Label
            {
                Text = label,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                Left = 0,
                Top = 0,
                Width = 110,
                Height = 18,
                BackColor = Color.Transparent,
            });

            row.Controls.Add(new Label
            {
                Text = string.Format("₱{0:N2}", price),
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.FromArgb(220, 38, 38),
                Left = 115,
                Top = 0,
                Width = 120,
                Height = 18,
                BackColor = Color.Transparent,
            });

            return row;
        }

        private void OpenBookingModal(backend.Room room)
        {
            // 3. We can now cleanly pass the real user ID variable into the modal
            using (var modal = new BookingModal(room, _loggedInUserId))
            {
                if (modal.ShowDialog(this) == DialogResult.OK)
                {
                    // Optional: Refresh your grid if needed
                }
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────
        private GraphicsPath RoundRect(Rectangle r, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(r.Right - radius * 2, r.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(r.Right - radius * 2, r.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(r.X, r.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Region RoundedRegion(int w, int h, int r)
        {
            return new Region(RoundRect(new Rectangle(0, 0, w, h), r));
        }

        private void RoomsGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage(_loggedInUserId); // Pass the user ID back to homepage
            home.Show();
            this.Close();
        }
    }
}
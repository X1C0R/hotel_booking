using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BookHotel
{
    public partial class AdminBookings : Form
    {
        public AdminBookings()
        {
            InitializeComponent();
        }

        private async void AdminBookings_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "All", "pending", "approved", "rejected" });
            cboStatus.SelectedIndex = 0;

            cboStatus.SelectedIndexChanged += async (s, ev) => await LoadBookings();
            txtSearch.TextChanged += async (s, ev) => await LoadBookings();

            await LoadBookings();
        }

        private async Task LoadBookings()
        {
            flowBookings.Controls.Clear();

            flowBookings.Controls.Add(new Label
            {
                Text = "Loading bookings...",
                AutoSize = true,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Gray,
                Margin = new Padding(20),
            });

            try
            {
                var bookings = await backend.AuthService.GetBookingsWithProfileAsync()
                               ?? new List<backend.BookingWithProfile>();

                string statusFilter = cboStatus.SelectedItem?.ToString() ?? "All";

                if (statusFilter != "All")
                {
                    bookings = bookings.FindAll(b =>
                        string.Equals(b.Status, statusFilter, StringComparison.OrdinalIgnoreCase));
                }

                string search = txtSearch.Text.Trim().ToLower();

                if (!string.IsNullOrEmpty(search))
                {
                    bookings = bookings.FindAll(b =>
                        (b.RoomName ?? "").ToLower().Contains(search) ||
                        (b.Status ?? "").ToLower().Contains(search) ||
                        (b.profile?.Email ?? "").ToLower().Contains(search));
                }

                lblStats.Text =
                    $"Total: {bookings.Count} | Pending: {bookings.FindAll(b => b.Status == "pending").Count}";

                flowBookings.Controls.Clear();

                if (bookings.Count == 0)
                {
                    flowBookings.Controls.Add(new Label
                    {
                        Text = "No bookings found.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12),
                        ForeColor = Color.Gray,
                        Margin = new Padding(20),
                    });
                    return;
                }

                foreach (var booking in bookings)
                {
                    flowBookings.Controls.Add(CreateBookingCard(booking));
                }
            }
            catch (Exception ex)
            {
                flowBookings.Controls.Clear();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ─────────────────────────────
        // BOOKING CARD UI
        // ─────────────────────────────
        private Panel CreateBookingCard(backend.BookingWithProfile booking)
        {
            var card = new Panel
            {
                Width = 340,
                Height = 300,
                BackColor = Color.White,
                Margin = new Padding(10),
                Tag = booking.Status
            };

            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Color bc = booking.Status == "approved"
                    ? Color.FromArgb(34, 197, 94)
                    : booking.Status == "rejected"
                        ? Color.FromArgb(220, 38, 38)
                        : Color.FromArgb(234, 179, 8);

                using (var path = RoundRect(new Rectangle(0, 0, card.Width - 4, card.Height - 4), 10))
                using (var bg = new SolidBrush(Color.White))
                using (var border = new Pen(Color.FromArgb(230, 230, 230), 1f))
                {
                    g.FillPath(bg, path);
                    g.DrawPath(border, path);
                }

                using (var strip = new SolidBrush(bc))
                {
                    var stripPath = RoundRect(new Rectangle(0, 0, 6, card.Height - 4), 3);
                    g.FillPath(strip, stripPath);
                }
            };

            int y = 12;

            // ROOM NAME
            card.Controls.Add(MakeLbl(
                "🏨 " + booking.RoomName,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.Black, 14, y));
            y += 25;

            // EMAIL
            card.Controls.Add(MakeLbl(
                "📧 " + (booking.profile?.Email ?? "No email"),
                new Font("Segoe UI", 9),
                Color.Gray, 14, y));
            y += 22;

            // NAME
            card.Controls.Add(MakeLbl(
                "👤 " + string.Join(" ",
                    booking.profile?.FirstName ?? "",
                    booking.profile?.LastName ?? "").Trim(),
                new Font("Segoe UI", 9),
                Color.Gray, 14, y));
            y += 22;

            // CREATED
            card.Controls.Add(MakeLbl(
                "🕒 Created: " + booking.CreatedAt.ToString("MMM dd, yyyy hh:mm tt"),
                new Font("Segoe UI", 9),
                Color.Gray, 14, y));
            y += 22;

            // CHECK-IN
            card.Controls.Add(MakeLbl(
                "⏱ Check-in: " + booking.CheckIn.ToString("MMM dd, yyyy hh:mm tt"),
                new Font("Segoe UI", 9),
                Color.Gray, 14, y));
            y += 22;

            // TOTAL
            card.Controls.Add(MakeLbl(
                "💰 ₱" + booking.TotalPrice.ToString("N2"),
                new Font("Segoe UI", 10, FontStyle.Bold),
                Color.Green, 14, y));
            y += 30;

            // ── VIEW BUTTON ──
            var viewBtn = MakeBtn("View", Color.DodgerBlue, Color.White, 14, y);

            viewBtn.Click += (s, e) =>
            {
                var modal = new adminBookingModal(booking);
                modal.ShowDialog();
            };

            card.Controls.Add(viewBtn);

            return card;
        }

        // ─────────────────────────────
        // HELPERS
        // ─────────────────────────────
        private Label MakeLbl(string text, Font font, Color color, int x, int y) =>
            new Label
            {
                Text = text,
                Font = font,
                ForeColor = color,
                Left = x,
                Top = y,
                AutoSize = true
            };

        private Button MakeBtn(string text, Color bg, Color fg, int x, int y)
        {
            return new Button
            {
                Text = text,
                Width = 100,
                Height = 30,
                Left = x,
                Top = y,
                BackColor = bg,
                ForeColor = fg,
                FlatStyle = FlatStyle.Flat
            };
        }

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
    }
}
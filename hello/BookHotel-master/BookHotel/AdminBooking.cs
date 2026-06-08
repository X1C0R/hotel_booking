using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            await LoadBookings();
        }

        private async Task LoadBookings()
        {
            flowBookings.Controls.Clear();

            try
            {
                // ✅ Load ALL bookings, not just pending
                var bookings = await backend.AuthService.GetAllBookingsAsync();

                if (bookings.Count == 0)
                {
                    flowBookings.Controls.Add(new Label
                    {
                        Text = "No bookings yet.",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 12),
                        ForeColor = Color.Gray,
                        Margin = new Padding(20),
                    });
                    return;
                }

                foreach (var booking in bookings)
                    flowBookings.Controls.Add(CreateBookingCard(booking));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Panel CreateBookingCard(backend.Booking booking)
        {
            bool isApproved = booking.Status == "approved";
            bool isRejected = booking.Status == "rejected";
            bool isPending = booking.Status == "pending";

            // Card colors based on status
            Color borderColor = isApproved
                ? Color.FromArgb(34, 197, 94)   // green
                : isRejected
                    ? Color.FromArgb(220, 38, 38) // red
                    : Color.FromArgb(200, 200, 200); // gray for pending

            var card = new Panel
            {
                Width = 360,
                Height = 230,
                BackColor = Color.White,
                Margin = new Padding(10),
            };

            // Rounded card with colored left strip
            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Background
                using (var bg = new SolidBrush(Color.White))
                using (var border = new Pen(borderColor, 1.5f))
                {
                    var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                    g.FillRectangle(bg, rect);
                    g.DrawRectangle(border, rect);
                }

                // ✅ Colored left accent strip
                using (var strip = new SolidBrush(borderColor))
                    g.FillRectangle(strip, 0, 0, 5, card.Height);
            };

            int y = 15;

            // ── Status indicator row ──────────────────────────────────────────
            var statusRow = new Panel
            {
                Left = 15,
                Top = y,
                Width = 320,
                Height = 22,
                BackColor = Color.Transparent,
            };

            // ✅ Colored dot
            var dot = new Panel
            {
                Width = 12,
                Height = 12,
                Left = 0,
                Top = 5,
                BackColor = isApproved
                    ? Color.FromArgb(34, 197, 94)
                    : isRejected
                        ? Color.FromArgb(220, 38, 38)
                        : Color.FromArgb(234, 179, 8), // yellow for pending
            };
            // Make dot circular
            dot.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var b = new SolidBrush(dot.BackColor))
                    e.Graphics.FillEllipse(b, 0, 0, dot.Width, dot.Height);
            };
            dot.Region = new Region(new RectangleF(0, 0, dot.Width, dot.Height));

            var statusLbl = new Label
            {
                Text = isApproved ? "Approved"
                     : isRejected ? "Rejected"
                     : "Pending",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = isApproved
                    ? Color.FromArgb(34, 197, 94)
                    : isRejected
                        ? Color.FromArgb(220, 38, 38)
                        : Color.FromArgb(180, 130, 0),
                Left = 18,
                Top = 0,
                AutoSize = true,
                BackColor = Color.Transparent,
            };

            statusRow.Controls.Add(dot);
            statusRow.Controls.Add(statusLbl);
            card.Controls.Add(statusRow);
            y += 28;

            // ── Booking details ───────────────────────────────────────────────
            card.Controls.Add(MakeLbl("Room: " + booking.RoomName,
                new Font("Segoe UI", 11, FontStyle.Bold),
                Color.FromArgb(30, 30, 30), 15, y)); y += 28;

            card.Controls.Add(MakeLbl(
                "Check-in: " + booking.CheckIn.ToString("MMM dd, yyyy  h:mm tt"),
                new Font("Segoe UI", 9), Color.Gray, 15, y)); y += 22;

            card.Controls.Add(MakeLbl(
                "Duration: " + booking.DurationHours + " hours",
                new Font("Segoe UI", 9), Color.Gray, 15, y)); y += 22;

            card.Controls.Add(MakeLbl(
                "Total: ₱" + booking.TotalPrice.ToString("N2"),
                new Font("Segoe UI", 10, FontStyle.Bold),
                Color.FromArgb(34, 139, 34), 15, y)); y += 30;

            // ── Buttons (only shown for pending) ──────────────────────────────
            if (isPending)
            {
                var btnApprove = MakeBtn("✔ Approve", Color.FromArgb(34, 139, 34), 15, y);
                btnApprove.Click += async (s, e) =>
                {
                    string result = await backend.AuthService.ApproveBooking(booking.Id);
                    if (result == "success")
                    {
                        // ✅ Update the dot + status label in place — no reload needed
                        dot.BackColor = Color.FromArgb(34, 197, 94);
                        statusLbl.Text = "Approved";
                        statusLbl.ForeColor = Color.FromArgb(34, 197, 94);
                        dot.Invalidate();

                        // Update card border color
                        card.Tag = "approved";
                        card.Invalidate();

                        btnApprove.Visible = false;
                        card.Controls["btnReject"].Visible = false;
                    }
                    else MessageBox.Show(result);
                };
                card.Controls.Add(btnApprove);

                var btnReject = MakeBtn("✖ Reject", Color.FromArgb(220, 38, 38), 150, y);
                btnReject.Name = "btnReject";
                btnReject.Click += async (s, e) =>
                {
                    string result = await backend.AuthService.RejectBooking(booking.Id);
                    if (result == "success")
                    {
                        dot.BackColor = Color.FromArgb(220, 38, 38);
                        statusLbl.Text = "Rejected";
                        statusLbl.ForeColor = Color.FromArgb(220, 38, 38);
                        dot.Invalidate();

                        card.Tag = "rejected";
                        card.Invalidate();

                        btnReject.Visible = false;
                        card.Controls["btnApprove"]?.Hide();
                        // hide approve too
                        foreach (Control c in card.Controls)
                            if (c is Button) c.Visible = false;
                    }
                    else MessageBox.Show(result);
                };
                card.Controls.Add(btnReject);
            }

            // Update border color on repaint based on tag
            card.Paint += (s, e) =>
            {
                string tag = card.Tag as string ?? booking.Status;
                Color bc = tag == "approved"
                    ? Color.FromArgb(34, 197, 94)
                    : tag == "rejected"
                        ? Color.FromArgb(220, 38, 38)
                        : Color.FromArgb(200, 200, 200);

                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var bg = new SolidBrush(Color.White))
                using (var border = new Pen(bc, 1.5f))
                {
                    g.FillRectangle(bg, new Rectangle(0, 0, card.Width - 1, card.Height - 1));
                    g.DrawRectangle(border, new Rectangle(0, 0, card.Width - 1, card.Height - 1));
                }
                using (var strip = new SolidBrush(bc))
                    g.FillRectangle(strip, 0, 0, 5, card.Height);
            };

            return card;
        }

        // ── Helpers ───────────────────────────────────────────────────────────
        private Label MakeLbl(string text, Font font, Color color, int x, int y) =>
            new Label
            {
                Text = text,
                Font = font,
                ForeColor = color,
                Left = x,
                Top = y,
                AutoSize = true,
                BackColor = Color.Transparent,
            };

        private Button MakeBtn(string text, Color bg, int x, int y)
        {
            var btn = new Button
            {
                Text = text,
                Width = 120,
                Height = 34,
                Left = x,
                Top = y,
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
    }
}
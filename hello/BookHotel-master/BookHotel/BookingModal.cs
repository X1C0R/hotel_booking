using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using DatabaseBackend = BookHotel.backend;

namespace BookHotel
{
    public class BookingModal : Form
    {
        private DatabaseBackend.Room _room;
        private string _userId;

        public BookingModal(DatabaseBackend.Room room, string userId)
        {
            _room = room;
            _userId = userId;
            InitUI();
        }

        private DateTimePicker _datePicker;
        private DateTimePicker _timePicker;
        private ComboBox _durationBox;
        private Label _totalLabel;

        private void InitUI()
        {
            Text = "Book Room";
            Size = new Size(460, 540);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(248, 248, 248);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            // ── Header ────────────────────────────────────────────────────────
            var header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(220, 38, 38),
            };

            var titleLbl = new Label
            {
                Text = "Book a Room",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Left = 20,
                Top = 12,
                Width = 300,
                Height = 30,
                BackColor = Color.Transparent,
            };

            var subLbl = new Label
            {
                Text = _room.RoomName,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(255, 200, 200),
                AutoSize = false,
                Left = 22,
                Top = 42,
                Width = 300,
                Height = 20,
                BackColor = Color.Transparent,
            };

            header.Controls.Add(titleLbl);
            header.Controls.Add(subLbl);

            // ── Body ──────────────────────────────────────────────────────────
            var body = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(50),
                BackColor = Color.Transparent,
            };

            int y = 16;

            // Check-in Date
            body.Controls.Add(MakeLabel("Check-in Date", y));
            _datePicker = new DateTimePicker
            {
                Left = 25,
                Top = y + 24,
                Width = 390,
                Height = 36,
                Format = DateTimePickerFormat.Short,
                Font = new Font("Segoe UI", 11),
                MinDate = DateTime.Today,
            };
            body.Controls.Add(_datePicker);
            y += 76;

            // Check-in Time
            body.Controls.Add(MakeLabel("Check-in Time", y));
            _timePicker = new DateTimePicker
            {
                Left = 25,
                Top = y + 24,
                Width = 390,
                Height = 36,
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Font = new Font("Segoe UI", 11),
            };
            body.Controls.Add(_timePicker);
            y += 76;

            // Duration
            body.Controls.Add(MakeLabel("Duration", y));
            _durationBox = new ComboBox
            {
                Left = 25,
                Top = y + 24,
                Width = 390,
                Height = 36,
                Font = new Font("Segoe UI", 11),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White,
            };
            _durationBox.Items.AddRange(new object[] { "3 Hours", "12 Hours (Overnight)" });
            _durationBox.SelectedIndex = 0;
            _durationBox.SelectedIndexChanged += (s, e) => UpdateTotal();
            body.Controls.Add(_durationBox);
            y += 76;

            // Divider
            body.Controls.Add(new Panel
            {
                Left = 0,
                Top = y,
                Width = 390,
                Height = 1,
                BackColor = Color.FromArgb(220, 220, 220),
            });
            y += 12;

            // Total label
            _totalLabel = new Label
            {
                Left = 25,
                Top = y,
                Width = 390,
                Height = 36,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(220, 38, 38),
                BackColor = Color.Transparent,
                Text = "Total: ₱0.00",
            };
            body.Controls.Add(_totalLabel);
            y += 48;

            // Confirm button
            var btnConfirm = new Button
            {
                Left = 40,
                Top = y,
                Width = 188,
                Height = 44,
                Text = "Confirm Booking",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 38, 38),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Click += BtnConfirm_Click;

            // Cancel button
            var btnCancel = new Button
            {
                Left = 240,
                Top = y,
                Width = 188,
                Height = 44,
                Text = "Cancel",
                Font = new Font("Segoe UI", 11),
                BackColor = Color.FromArgb(230, 230, 230),
                ForeColor = Color.FromArgb(80, 80, 80),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
            };

            body.Controls.Add(btnConfirm);
            body.Controls.Add(btnCancel);

            Controls.Add(body);
            Controls.Add(header);

            // Init total
            UpdateTotal();
            _datePicker.ValueChanged += (s, e) => UpdateTotal();
        }

        // ✅ X button fix — prevents closing the parent form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
                DialogResult = DialogResult.Cancel;

            base.OnFormClosing(e);
        }

        private void UpdateTotal()
        {
            bool isWeekend = _datePicker.Value.DayOfWeek == DayOfWeek.Saturday ||
                             _datePicker.Value.DayOfWeek == DayOfWeek.Sunday;
            bool is3h = _durationBox.SelectedIndex == 0;

            decimal price = is3h
                ? (isWeekend ? _room.WeekendPrice3h : _room.WeekdayPrice3h)
                : (isWeekend ? _room.WeekendPrice12h : _room.WeekdayPrice12h);

            _totalLabel.Text = string.Format("Total: ₱{0:N2}  ({1}, {2})",
                price,
                isWeekend ? "Weekend" : "Weekday",
                is3h ? "3 hours" : "12 hours");
        }

        private async void BtnConfirm_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            // Guard: catch zero GUID before trying to save
            if (_room.Id == Guid.Empty)
            {
                MessageBox.Show(
                    "Room ID is missing — the room was not loaded correctly.\nPlease go back and reopen the room.",
                    "Invalid Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btn.Enabled = false;
            btn.Text = "Booking...";

            try
            {
                bool isWeekend = _datePicker.Value.DayOfWeek == DayOfWeek.Saturday ||
                                 _datePicker.Value.DayOfWeek == DayOfWeek.Sunday;
                bool is3h = _durationBox.SelectedIndex == 0;

                decimal price = is3h
                    ? (isWeekend ? _room.WeekendPrice3h : _room.WeekdayPrice3h)
                    : (isWeekend ? _room.WeekendPrice12h : _room.WeekdayPrice12h);

                DateTime checkIn = _datePicker.Value.Date
                    .Add(_timePicker.Value.TimeOfDay);

                var booking = new DatabaseBackend.Booking
                {
                    RoomId = _room.Id,
                    RoomName = _room.RoomName,
                    UserId = _userId,
                    CheckIn = checkIn,
                    DurationHours = is3h ? 3 : 12,
                    TotalPrice = price,
                    Status = "pending",
                };

                string result = await DatabaseBackend.AuthService.SaveBooking(booking);

                if (result == "success")
                {
                    MessageBox.Show(
                        string.Format("Room \"{0}\" booked!\nCheck-in: {1}\nTotal: ₱{2:N2}",
                            _room.RoomName,
                            checkIn.ToString("MMM dd, yyyy h:mm tt"),
                            price),
                        "Booking Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Booking failed: " + result, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn.Enabled = true;
                    btn.Text = "Confirm Booking";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                btn.Enabled = true;
                btn.Text = "Confirm Booking";
            }
        }

        private Label MakeLabel(string text, int y) => new Label
        {
            Text = text,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            ForeColor = Color.FromArgb(80, 80, 80),
            Left = 0,
            Top = y,
            Width = 300,
            Height = 20,
            BackColor = Color.Transparent,
        };
    }
}
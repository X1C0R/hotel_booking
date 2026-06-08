using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHotel
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            RoundControl(HeaderPanel, 30);
            RoundPanel(SidebarPanel, 25);

            // ✅ Load rooms ONCE on startup, not inside Paint
            await LoadRoomsAsync();
        }

        // ── Load all rooms and render cards ──────────────────────────────────
        private async Task LoadRoomsAsync()
        {
            LoadRoomsAsCards.Controls.Clear();

            // Show a loading label while fetching
            var loadingLabel = new Label
            {
                Text = "Loading rooms...",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(20, 20),
            };
            LoadRoomsAsCards.Controls.Add(loadingLabel);

            try
            {

                var supabase = await BookHotel.backend.AuthService.Initialize();

                var response = await supabase
                    .From<BookHotel.backend.Room>()
                    .Get();

                // Clear the loading label now that data arrived
                LoadRoomsAsCards.Controls.Clear();

                if (response.Models == null || response.Models.Count == 0)
                {
                    LoadRoomsAsCards.Controls.Add(new Label
                    {
                        Text = "No rooms found.",
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 12),
                        AutoSize = true,
                        Location = new Point(20, 20),
                    });
                    return;
                }

                // ✅ Suspend layout while adding cards — prevents flickering
                LoadRoomsAsCards.SuspendLayout();

                foreach (var room in response.Models)
                {
                    RoomCard card = new RoomCard(room);
                    card.Margin = new Padding(8);
                    LoadRoomsAsCards.Controls.Add(card);
                }

                LoadRoomsAsCards.ResumeLayout();
            }
            catch (Exception ex)
            {
                LoadRoomsAsCards.Controls.Clear();
                LoadRoomsAsCards.Controls.Add(new Label
                {
                    Text = "Error loading rooms: " + ex.Message,
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(20, 20),
                });
            }
        }

        // ── Call this after adding/editing a room to refresh the grid ─────────
        public async Task RefreshRoomsAsync()
        {
            await LoadRoomsAsync();
        }

        // ── Rounded helpers ───────────────────────────────────────────────────
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

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            RoundPanel(SidebarPanel, 25);
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            AddRoom roomForm = new AddRoom();
            roomForm.ShowDialog();

            // ✅ Refresh cards after the add dialog closes
            await LoadRoomsAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            AdminBookings bookingsForm = new AdminBookings();
            bookingsForm.ShowDialog();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            new Login().Show(); // ✅ replace Login with your actual login form class name
            this.Close();
        }

        // ✅ REMOVED: RoomPanel_Paint and LoadRoomsAsCards_Paint
        // Never put data-loading code inside Paint events —
        // Paint fires constantly (on scroll, resize, hover, etc.)
        // and would clear + reload the grid endlessly.
    }
}
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BookHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            RoundPanel(LogInPanel, 30);
        }

        private void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.BackColor = Color.FromArgb(220, 38, 38);
            LoginButton.ForeColor = Color.White;
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string password = PasswordBox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            LoginButton.Enabled = false;
            LoginButton.Text = "Logging in...";

            try
            {
                var result = await BookHotel.backend.AuthService.SignIn(email, password);

                LoginButton.Enabled = true;
                LoginButton.Text = "Log In";

                string role = result.Role;
                string userId = result.UserId;

                if (role.StartsWith("Error:") ||
                    role == "Invalid email or password.")
                {
                    MessageBox.Show(role);
                    return;
                }

                if (role == "admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    if (string.IsNullOrEmpty(userId))
                    {
                        MessageBox.Show(
                            "Unable to retrieve user ID.",
                            "Login Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    Homepage homeForm = new Homepage(userId);
                    homeForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                LoginButton.Enabled = true;
                LoginButton.Text = "Log In";

                MessageBox.Show(
                    ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SignUp_Load(object sender, EventArgs e) { }
    }
}
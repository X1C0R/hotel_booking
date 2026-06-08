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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            RoundPanel(SignUpPanel, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void SignUp_Load(object sender, EventArgs e)
        {
            SignupButton.FlatStyle = FlatStyle.Flat;
            SignupButton.FlatAppearance.BorderSize = 0;

            SignupButton.BackColor = Color.FromArgb(220, 38, 38);
            SignupButton.ForeColor = Color.White;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private async void SignupButton_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string pass = PasswordBox.Text;
            string confirmPass = ConfirmPasswordBox.Text;

            if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Email and password cannot be empty!");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address!");
                return;
            }


            string result = await AuthService.RegisterUser(email, pass);

            if (result == "Success")
            {
                MessageBox.Show("Registration successful!");
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                // This will now tell you EXACTLY what is wrong
                MessageBox.Show("Registration failed: " + result);
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        // 1. Private variable to keep track of the current user
        private string _loggedInUserId;

        // 2. Updated constructor to receive the user's ID when Homepage opens
        public Homepage(string userId)
        {
            InitializeComponent();
            _loggedInUserId = userId; // Save it for routing to other forms
        }

        private List<Image> galleryImages = new List<Image>();
        private int currentImageIndex = 0;

        private void Homepage_Load(object sender, EventArgs e)
        {
            MakeCircular(LeftLabel);
            MakeCircular(RightLabel);
            RoundControl(HeaderPanel, 30);
            RoundPictureBoxCorners(PictureBoxGallery, 40);

            galleryImages.Add(Properties.Resources.regency_room_popular);
            galleryImages.Add(Properties.Resources.sakura_room_popular);
            galleryImages.Add(Properties.Resources.greece_room_popular);

            PictureBoxGallery.Image = galleryImages[0];
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

        private void RoundLabel(Label lbl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(lbl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(lbl.Width - radius, lbl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, lbl.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            lbl.Region = new Region(path);
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
            // 3. Fixed! Successfully passing the saved user ID down into the Hotels screen
            Hotels hotels = new Hotels(_loggedInUserId);
            hotels.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            new Login().Show(); // ✅ replace Login with your actual login form class name
            this.Close();
        }
    }
}
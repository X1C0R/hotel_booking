using System;
using System.Windows.Forms;

namespace BookHotel
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BackBTN = new System.Windows.Forms.Button();
            this.SogoLogoBox = new System.Windows.Forms.PictureBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileBackgroundPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.ProfileHeaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecentLabel = new System.Windows.Forms.Label();
            this.RecentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).BeginInit();
            this.ProfileBackgroundPanel.SuspendLayout();
            this.ProfileHeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RecentPanel.SuspendLayout();
            this.RoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Firebrick;
            this.HeaderPanel.Controls.Add(this.BackBTN);
            this.HeaderPanel.Controls.Add(this.SogoLogoBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(708, 76);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.Color.Transparent;
            this.BackBTN.BackgroundImage = global::BookHotel.Properties.Resources.CircleBackBTN;
            this.BackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBTN.FlatAppearance.BorderSize = 0;
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBTN.Location = new System.Drawing.Point(4, 24);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(48, 33);
            this.BackBTN.TabIndex = 4;
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // SogoLogoBox
            // 
            this.SogoLogoBox.Image = global::BookHotel.Properties.Resources.sogo_letter;
            this.SogoLogoBox.Location = new System.Drawing.Point(253, 24);
            this.SogoLogoBox.Name = "SogoLogoBox";
            this.SogoLogoBox.Size = new System.Drawing.Size(77, 28);
            this.SogoLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SogoLogoBox.TabIndex = 3;
            this.SogoLogoBox.TabStop = false;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.Location = new System.Drawing.Point(28, 80);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(335, 27);
            this.FirstNameBox.TabIndex = 3;
            this.FirstNameBox.Text = "First Name";
            this.FirstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileLabel.Location = new System.Drawing.Point(122, 11);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(123, 23);
            this.ProfileLabel.TabIndex = 4;
            this.ProfileLabel.Text = "Your Profile";
            this.ProfileLabel.Click += new System.EventHandler(this.ProfileLabel_Click);
            // 
            // ProfileBackgroundPanel
            // 
            this.ProfileBackgroundPanel.BackColor = System.Drawing.SystemColors.Info;
            this.ProfileBackgroundPanel.Controls.Add(this.SaveButton);
            this.ProfileBackgroundPanel.Controls.Add(this.NumberBox);
            this.ProfileBackgroundPanel.Controls.Add(this.EmailBox);
            this.ProfileBackgroundPanel.Controls.Add(this.LastNameBox);
            this.ProfileBackgroundPanel.Controls.Add(this.MiddleNameBox);
            this.ProfileBackgroundPanel.Controls.Add(this.ProfileHeaderPanel);
            this.ProfileBackgroundPanel.Controls.Add(this.FirstNameBox);
            this.ProfileBackgroundPanel.Location = new System.Drawing.Point(139, 104);
            this.ProfileBackgroundPanel.Name = "ProfileBackgroundPanel";
            this.ProfileBackgroundPanel.Size = new System.Drawing.Size(393, 405);
            this.ProfileBackgroundPanel.TabIndex = 5;
            this.ProfileBackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfileBackgroundPanel_Paint);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkGray;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(151, 354);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 31);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(28, 304);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(335, 27);
            this.NumberBox.TabIndex = 7;
            this.NumberBox.Text = "Phone Number";
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(28, 249);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(335, 27);
            this.EmailBox.TabIndex = 6;
            this.EmailBox.Text = "Email";
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.Location = new System.Drawing.Point(28, 192);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(335, 27);
            this.LastNameBox.TabIndex = 5;
            this.LastNameBox.Text = "Last Name";
            this.LastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameBox.Location = new System.Drawing.Point(28, 134);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(335, 27);
            this.MiddleNameBox.TabIndex = 4;
            this.MiddleNameBox.Text = "Middle Name";
            this.MiddleNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MiddleNameBox.TextChanged += new System.EventHandler(this.MiddleNameBox_TextChanged);
            // 
            // ProfileHeaderPanel
            // 
            this.ProfileHeaderPanel.BackColor = System.Drawing.Color.Firebrick;
            this.ProfileHeaderPanel.Controls.Add(this.ProfileLabel);
            this.ProfileHeaderPanel.Location = new System.Drawing.Point(15, 17);
            this.ProfileHeaderPanel.Name = "ProfileHeaderPanel";
            this.ProfileHeaderPanel.Size = new System.Drawing.Size(368, 44);
            this.ProfileHeaderPanel.TabIndex = 0;
            this.ProfileHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfileHeaderPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.RecentLabel);
            this.panel1.Location = new System.Drawing.Point(12, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 40);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RecentLabel
            // 
            this.RecentLabel.AutoSize = true;
            this.RecentLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecentLabel.Location = new System.Drawing.Point(31, 11);
            this.RecentLabel.Name = "RecentLabel";
            this.RecentLabel.Size = new System.Drawing.Size(74, 19);
            this.RecentLabel.TabIndex = 4;
            this.RecentLabel.Text = "Recents";
            this.RecentLabel.Click += new System.EventHandler(this.RecentLabel_Click);
            // 
            // RecentPanel
            // 
            this.RecentPanel.Controls.Add(this.RoomPanel);
            this.RecentPanel.Location = new System.Drawing.Point(46, 599);
            this.RecentPanel.Name = "RecentPanel";
            this.RecentPanel.Size = new System.Drawing.Size(561, 257);
            this.RecentPanel.TabIndex = 7;
            // 
            // RoomPanel
            // 
            this.RoomPanel.AutoScroll = true;
            this.RoomPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoomPanel.Controls.Add(this.label2);
            this.RoomPanel.Controls.Add(this.label1);
            this.RoomPanel.Controls.Add(this.RoomTypeLabel);
            this.RoomPanel.Location = new System.Drawing.Point(3, 3);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(558, 67);
            this.RoomPanel.TabIndex = 0;
            this.RoomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoomPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "1:00 P.M. - 4:00 P.M.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "06/11/26";
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeLabel.Location = new System.Drawing.Point(13, 23);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(80, 19);
            this.RoomTypeLabel.TabIndex = 0;
            this.RoomTypeLabel.Text = "Car Room";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 661);
            this.Controls.Add(this.RecentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProfileBackgroundPanel);
            this.Controls.Add(this.HeaderPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sogo Hotel";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).EndInit();
            this.ProfileBackgroundPanel.ResumeLayout(false);
            this.ProfileBackgroundPanel.PerformLayout();
            this.ProfileHeaderPanel.ResumeLayout(false);
            this.ProfileHeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RecentPanel.ResumeLayout(false);
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void RoomPanel_Paint(object sender, PaintEventArgs e)
        {
            // leave empty
        }

        private void ProfileLabel_Click(object sender, EventArgs e)
        {
            // leave empty
        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox SogoLogoBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Panel ProfileBackgroundPanel;
        private System.Windows.Forms.Panel ProfileHeaderPanel;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RecentLabel;
        private System.Windows.Forms.FlowLayoutPanel RecentPanel;
        private System.Windows.Forms.Panel RoomPanel;
        //private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoomTypeLabel;
        private Button BackBTN;
    }
}
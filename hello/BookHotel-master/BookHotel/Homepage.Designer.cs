namespace BookHotel
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.RightLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RoomListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HotelPage = new System.Windows.Forms.Button();
            this.PictureBoxGallery = new System.Windows.Forms.PictureBox();
            this.SogoLogoBox = new System.Windows.Forms.PictureBox();
            this.logOut = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Firebrick;
            this.HeaderPanel.Controls.Add(this.SogoLogoBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1065, 76);
            this.HeaderPanel.TabIndex = 1;
            // 
            // RightLabel
            // 
            this.RightLabel.AutoSize = true;
            this.RightLabel.BackColor = System.Drawing.Color.Firebrick;
            this.RightLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightLabel.Location = new System.Drawing.Point(1005, 299);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(25, 25);
            this.RightLabel.TabIndex = 3;
            this.RightLabel.Text = ">";
            this.RightLabel.Click += new System.EventHandler(this.RightLabel_Click);
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.BackColor = System.Drawing.Color.Firebrick;
            this.LeftLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftLabel.Location = new System.Drawing.Point(32, 299);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(25, 25);
            this.LeftLabel.TabIndex = 4;
            this.LeftLabel.Text = "<";
            this.LeftLabel.Click += new System.EventHandler(this.LeftLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RoomListPanel
            // 
            this.RoomListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomListPanel.Location = new System.Drawing.Point(12, 631);
            this.RoomListPanel.Name = "RoomListPanel";
            this.RoomListPanel.Size = new System.Drawing.Size(1041, 30);
            this.RoomListPanel.TabIndex = 6;
            // 
            // HotelPage
            // 
            this.HotelPage.BackColor = System.Drawing.Color.Firebrick;
            this.HotelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelPage.ForeColor = System.Drawing.Color.White;
            this.HotelPage.Location = new System.Drawing.Point(37, 582);
            this.HotelPage.Name = "HotelPage";
            this.HotelPage.Size = new System.Drawing.Size(182, 43);
            this.HotelPage.TabIndex = 7;
            this.HotelPage.Text = "Hotels";
            this.HotelPage.UseVisualStyleBackColor = false;
            this.HotelPage.Click += new System.EventHandler(this.HotelPage_Click);
            // 
            // PictureBoxGallery
            // 
            this.PictureBoxGallery.Image = global::BookHotel.Properties.Resources.sakura_room_popular;
            this.PictureBoxGallery.Location = new System.Drawing.Point(12, 82);
            this.PictureBoxGallery.Name = "PictureBoxGallery";
            this.PictureBoxGallery.Size = new System.Drawing.Size(1041, 494);
            this.PictureBoxGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxGallery.TabIndex = 2;
            this.PictureBoxGallery.TabStop = false;
            this.PictureBoxGallery.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SogoLogoBox
            // 
            this.SogoLogoBox.Image = global::BookHotel.Properties.Resources.sogo_letter;
            this.SogoLogoBox.Location = new System.Drawing.Point(495, 24);
            this.SogoLogoBox.Name = "SogoLogoBox";
            this.SogoLogoBox.Size = new System.Drawing.Size(77, 28);
            this.SogoLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SogoLogoBox.TabIndex = 3;
            this.SogoLogoBox.TabStop = false;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Firebrick;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(871, 582);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(182, 43);
            this.logOut.TabIndex = 8;
            this.logOut.Text = "Log-out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1065, 661);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.HotelPage);
            this.Controls.Add(this.RoomListPanel);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.RightLabel);
            this.Controls.Add(this.PictureBoxGallery);
            this.Controls.Add(this.HeaderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.Text = "Sogo Hotel";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox SogoLogoBox;
        private System.Windows.Forms.PictureBox PictureBoxGallery;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel RoomListPanel;
        private System.Windows.Forms.Button HotelPage;
        private System.Windows.Forms.Button logOut;
    }
}
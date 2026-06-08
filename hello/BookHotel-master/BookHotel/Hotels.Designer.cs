namespace BookHotel
{
    partial class Hotels
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HotelNameLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.RoomsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.HeaderPanel.Controls.Add(this.BackBtn);
            this.HeaderPanel.Controls.Add(this.HotelNameLabel);
            this.HeaderPanel.Controls.Add(this.SubtitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1100, 90);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HotelNameLabel
            // 
            this.HotelNameLabel.AutoSize = true;
            this.HotelNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotelNameLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.HotelNameLabel.ForeColor = System.Drawing.Color.White;
            this.HotelNameLabel.Location = new System.Drawing.Point(66, 9);
            this.HotelNameLabel.Name = "HotelNameLabel";
            this.HotelNameLabel.Size = new System.Drawing.Size(176, 41);
            this.HotelNameLabel.TabIndex = 0;
            this.HotelNameLabel.Text = "Sogo Hotel";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(69, 50);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(214, 19);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Browse and book available rooms";
            // 
            // RoomsGrid
            // 
            this.RoomsGrid.AutoScroll = true;
            this.RoomsGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RoomsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsGrid.Location = new System.Drawing.Point(0, 90);
            this.RoomsGrid.Name = "RoomsGrid";
            this.RoomsGrid.Padding = new System.Windows.Forms.Padding(12);
            this.RoomsGrid.Size = new System.Drawing.Size(1100, 610);
            this.RoomsGrid.TabIndex = 0;
            this.RoomsGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.RoomsGrid_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Image = global::BookHotel.Properties.Resources.backButton;
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.Location = new System.Drawing.Point(0, 20);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(69, 32);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.RoomsGrid);
            this.Controls.Add(this.HeaderPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Hotels";
            this.Text = "Sogo Hotel — Available Rooms";
            this.Load += new System.EventHandler(this.Hotels_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HotelNameLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.FlowLayoutPanel RoomsGrid;
        private System.Windows.Forms.Button BackBtn;
    }
}
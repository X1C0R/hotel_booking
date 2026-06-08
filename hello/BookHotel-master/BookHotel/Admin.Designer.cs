using System;
using System.Windows.Forms;

namespace BookHotel
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SogoLogoBox = new System.Windows.Forms.PictureBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomsButton = new System.Windows.Forms.Label();
            this.RoomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.LoadRoomsAsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.BookBtn = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).BeginInit();
            this.SidebarPanel.SuspendLayout();
            this.RoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.Firebrick;
            this.HeaderPanel.Controls.Add(this.SogoLogoBox);
            this.HeaderPanel.Controls.Add(this.AdminLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-3, -7);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1071, 60);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SogoLogoBox
            // 
            this.SogoLogoBox.Image = global::BookHotel.Properties.Resources.sogo_letter;
            this.SogoLogoBox.Location = new System.Drawing.Point(34, 19);
            this.SogoLogoBox.Name = "SogoLogoBox";
            this.SogoLogoBox.Size = new System.Drawing.Size(77, 28);
            this.SogoLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SogoLogoBox.TabIndex = 3;
            this.SogoLogoBox.TabStop = false;
            this.SogoLogoBox.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.AdminLabel.Location = new System.Drawing.Point(113, 27);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(84, 25);
            this.AdminLabel.TabIndex = 2;
            this.AdminLabel.Text = "ADMIN";
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.Maroon;
            this.SidebarPanel.Controls.Add(this.logoutBtn);
            this.SidebarPanel.Controls.Add(this.BookBtn);
            this.SidebarPanel.Controls.Add(this.panel1);
            this.SidebarPanel.Controls.Add(this.RoomsButton);
            this.SidebarPanel.Location = new System.Drawing.Point(-10, 44);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(209, 617);
            this.SidebarPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(195, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 48);
            this.panel1.TabIndex = 4;
            // 
            // RoomsButton
            // 
            this.RoomsButton.AutoSize = true;
            this.RoomsButton.BackColor = System.Drawing.Color.Maroon;
            this.RoomsButton.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoomsButton.Location = new System.Drawing.Point(35, 30);
            this.RoomsButton.Name = "RoomsButton";
            this.RoomsButton.Size = new System.Drawing.Size(109, 33);
            this.RoomsButton.TabIndex = 0;
            this.RoomsButton.Text = "Rooms";
            // 
            // RoomPanel
            // 
            this.RoomPanel.ColumnCount = 1;
            this.RoomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomPanel.Controls.Add(this.AddButton, 0, 0);
            this.RoomPanel.Controls.Add(this.LoadRoomsAsCards, 0, 1);
            this.RoomPanel.Location = new System.Drawing.Point(204, 59);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.RowCount = 2;
            this.RoomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.RoomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomPanel.Size = new System.Drawing.Size(864, 602);
            this.RoomPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(162, 116);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+ Add Room";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LoadRoomsAsCards
            // 
            this.LoadRoomsAsCards.AutoScroll = true;
            this.LoadRoomsAsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadRoomsAsCards.Location = new System.Drawing.Point(3, 129);
            this.LoadRoomsAsCards.Name = "LoadRoomsAsCards";
            this.LoadRoomsAsCards.Padding = new System.Windows.Forms.Padding(8);
            this.LoadRoomsAsCards.Size = new System.Drawing.Size(858, 470);
            this.LoadRoomsAsCards.TabIndex = 3;
            // 
            // BookBtn
            // 
            this.BookBtn.AutoSize = true;
            this.BookBtn.BackColor = System.Drawing.Color.Maroon;
            this.BookBtn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookBtn.Location = new System.Drawing.Point(35, 101);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(126, 33);
            this.BookBtn.TabIndex = 5;
            this.BookBtn.Text = "Booking";
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.BackColor = System.Drawing.Color.Maroon;
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(35, 560);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(125, 33);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log-Out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1065, 661);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Sogo Hotel Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SogoLogoBox)).EndInit();
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.RoomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // ✅ NO event stubs here — all handlers live in Admin.cs only

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.PictureBox SogoLogoBox;
        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoomsButton;
        private System.Windows.Forms.TableLayoutPanel RoomPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.FlowLayoutPanel LoadRoomsAsCards;
        private Label BookBtn;
        private Label logoutBtn;
    }
}
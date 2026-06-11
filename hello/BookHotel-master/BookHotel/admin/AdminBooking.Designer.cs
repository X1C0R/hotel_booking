using System;
using System.Windows.Forms;

namespace BookHotel
    {
        partial class AdminBookings
        {
            private System.ComponentModel.IContainer components = null;

            private System.Windows.Forms.Panel topPanel;
            private System.Windows.Forms.TextBox txtSearch;
            private System.Windows.Forms.ComboBox cboStatus;
            private System.Windows.Forms.Label lblStats;
            private System.Windows.Forms.Label lblSearch;
            private System.Windows.Forms.Label lblFilter;
            private System.Windows.Forms.FlowLayoutPanel flowBookings; // ✅ added

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.flowBookings = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Label();
            this.BookBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomsButton = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.lblSearch);
            this.topPanel.Controls.Add(this.txtSearch);
            this.topPanel.Controls.Add(this.lblFilter);
            this.topPanel.Controls.Add(this.cboStatus);
            this.topPanel.Controls.Add(this.lblStats);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.topPanel.Size = new System.Drawing.Size(1065, 56);
            this.topPanel.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSearch.Location = new System.Drawing.Point(15, 20);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(66, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFilter.Location = new System.Drawing.Point(270, 20);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 15);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboStatus.Location = new System.Drawing.Point(315, 18);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(114, 23);
            this.cboStatus.TabIndex = 3;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStats.Location = new System.Drawing.Point(465, 19);
            this.lblStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(142, 19);
            this.lblStats.TabIndex = 4;
            this.lblStats.Text = "Total: 0 | Pending: 0";
            // 
            // flowBookings
            // 
            this.flowBookings.AutoScroll = true;
            this.flowBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.flowBookings.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowBookings.Location = new System.Drawing.Point(211, 56);
            this.flowBookings.Margin = new System.Windows.Forms.Padding(2);
            this.flowBookings.Name = "flowBookings";
            this.flowBookings.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.flowBookings.Size = new System.Drawing.Size(854, 605);
            this.flowBookings.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.Maroon;
            this.SidebarPanel.Controls.Add(this.logoutBtn);
            this.SidebarPanel.Controls.Add(this.BookBtn);
            this.SidebarPanel.Controls.Add(this.panel1);
            this.SidebarPanel.Controls.Add(this.RoomsButton);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 56);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(209, 605);
            this.SidebarPanel.TabIndex = 2;
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
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click_1);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(193, 101);
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
            this.RoomsButton.Click += new System.EventHandler(this.RoomsButton_Click_1);
            // 
            // AdminBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1065, 661);
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.flowBookings);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Management";
            this.Load += new System.EventHandler(this.AdminBookings_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.ResumeLayout(false);

            }

        private void RoomsButton_Click_1(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Close();
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Log Out",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            new Login().Show(); 
            this.Close();
        }

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Label logoutBtn;
        private System.Windows.Forms.Label BookBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoomsButton;
    }
    }
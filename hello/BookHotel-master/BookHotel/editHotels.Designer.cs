namespace BookHotel
{
    partial class editHotels
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
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.NumberAvailable = new System.Windows.Forms.TextBox();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.txtPrice4 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.AvailableBox = new System.Windows.Forms.CheckBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Weekday12Label = new System.Windows.Forms.Label();
            this.Weekend3Label = new System.Windows.Forms.Label();
            this.Weekday3Label = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RoomCountLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RoomImage = new System.Windows.Forms.PictureBox();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomPanel
            // 
            this.RoomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RoomPanel.Controls.Add(this.DeleteBtn);
            this.RoomPanel.Controls.Add(this.NumberAvailable);
            this.RoomPanel.Controls.Add(this.RoomName);
            this.RoomPanel.Controls.Add(this.txtPrice4);
            this.RoomPanel.Controls.Add(this.txtPrice3);
            this.RoomPanel.Controls.Add(this.txtPrice2);
            this.RoomPanel.Controls.Add(this.txtPrice1);
            this.RoomPanel.Controls.Add(this.RoomImage);
            this.RoomPanel.Controls.Add(this.AvailableBox);
            this.RoomPanel.Controls.Add(this.DescriptionLabel);
            this.RoomPanel.Controls.Add(this.DescriptionBox);
            this.RoomPanel.Controls.Add(this.label4);
            this.RoomPanel.Controls.Add(this.Weekday12Label);
            this.RoomPanel.Controls.Add(this.Weekend3Label);
            this.RoomPanel.Controls.Add(this.Weekday3Label);
            this.RoomPanel.Controls.Add(this.SaveButton);
            this.RoomPanel.Controls.Add(this.RoomCountLabel);
            this.RoomPanel.Location = new System.Drawing.Point(-14, -15);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(856, 510);
            this.RoomPanel.TabIndex = 6;
            this.RoomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoomPanel_Paint);
            // 
            // NumberAvailable
            // 
            this.NumberAvailable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NumberAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberAvailable.Location = new System.Drawing.Point(711, 73);
            this.NumberAvailable.Name = "NumberAvailable";
            this.NumberAvailable.Size = new System.Drawing.Size(76, 20);
            this.NumberAvailable.TabIndex = 21;
            this.NumberAvailable.TextChanged += new System.EventHandler(this.NumberAvailable_TextChanged);
            // 
            // RoomName
            // 
            this.RoomName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName.ForeColor = System.Drawing.Color.IndianRed;
            this.RoomName.Location = new System.Drawing.Point(526, 29);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(211, 24);
            this.RoomName.TabIndex = 26;
            this.RoomName.Text = "Room Name";
            this.RoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomName.TextChanged += new System.EventHandler(this.RoomName_TextChanged);
            // 
            // txtPrice4
            // 
            this.txtPrice4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice4.Location = new System.Drawing.Point(711, 211);
            this.txtPrice4.Name = "txtPrice4";
            this.txtPrice4.Size = new System.Drawing.Size(76, 20);
            this.txtPrice4.TabIndex = 25;
            this.txtPrice4.Text = "₱";
            this.txtPrice4.TextChanged += new System.EventHandler(this.txtPrice4_TextChanged);
            // 
            // txtPrice3
            // 
            this.txtPrice3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice3.Location = new System.Drawing.Point(711, 178);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(76, 20);
            this.txtPrice3.TabIndex = 24;
            this.txtPrice3.Text = "₱";
            this.txtPrice3.TextChanged += new System.EventHandler(this.txtPrice3_TextChanged);
            // 
            // txtPrice2
            // 
            this.txtPrice2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice2.Location = new System.Drawing.Point(711, 142);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(76, 20);
            this.txtPrice2.TabIndex = 23;
            this.txtPrice2.Text = "₱";
            this.txtPrice2.TextChanged += new System.EventHandler(this.txtPrice2_TextChanged);
            // 
            // txtPrice1
            // 
            this.txtPrice1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice1.Location = new System.Drawing.Point(711, 106);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(76, 20);
            this.txtPrice1.TabIndex = 22;
            this.txtPrice1.Text = "₱";
            this.txtPrice1.TextChanged += new System.EventHandler(this.txtPrice1_TextChanged);
            // 
            // AvailableBox
            // 
            this.AvailableBox.AutoSize = true;
            this.AvailableBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBox.Location = new System.Drawing.Point(446, 253);
            this.AvailableBox.Name = "AvailableBox";
            this.AvailableBox.Size = new System.Drawing.Size(104, 23);
            this.AvailableBox.TabIndex = 19;
            this.AvailableBox.Text = "Available";
            this.AvailableBox.UseVisualStyleBackColor = true;
            this.AvailableBox.CheckedChanged += new System.EventHandler(this.AvailableBox_CheckedChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(21, 322);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(102, 14);
            this.DescriptionLabel.TabIndex = 18;
            this.DescriptionLabel.Text = "Room Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(24, 339);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(387, 85);
            this.DescriptionBox.TabIndex = 17;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Weekend Price (12 hours):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Weekday12Label
            // 
            this.Weekday12Label.AutoSize = true;
            this.Weekday12Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weekday12Label.Location = new System.Drawing.Point(442, 176);
            this.Weekday12Label.Name = "Weekday12Label";
            this.Weekday12Label.Size = new System.Drawing.Size(197, 19);
            this.Weekday12Label.TabIndex = 12;
            this.Weekday12Label.Text = "Weekday Price (12 hours):";
            this.Weekday12Label.Click += new System.EventHandler(this.Weekday12Label_Click);
            // 
            // Weekend3Label
            // 
            this.Weekend3Label.AutoSize = true;
            this.Weekend3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weekend3Label.Location = new System.Drawing.Point(442, 140);
            this.Weekend3Label.Name = "Weekend3Label";
            this.Weekend3Label.Size = new System.Drawing.Size(189, 19);
            this.Weekend3Label.TabIndex = 9;
            this.Weekend3Label.Text = "Weekend Price (3 hours):";
            this.Weekend3Label.Click += new System.EventHandler(this.Weekend3Label_Click);
            // 
            // Weekday3Label
            // 
            this.Weekday3Label.AutoSize = true;
            this.Weekday3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weekday3Label.Location = new System.Drawing.Point(442, 107);
            this.Weekday3Label.Name = "Weekday3Label";
            this.Weekday3Label.Size = new System.Drawing.Size(188, 19);
            this.Weekday3Label.TabIndex = 8;
            this.Weekday3Label.Text = "Weekday Price (3 hours):";
            this.Weekday3Label.Click += new System.EventHandler(this.Weekday3Label_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.Location = new System.Drawing.Point(642, 432);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RoomCountLabel
            // 
            this.RoomCountLabel.AutoSize = true;
            this.RoomCountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomCountLabel.Location = new System.Drawing.Point(442, 73);
            this.RoomCountLabel.Name = "RoomCountLabel";
            this.RoomCountLabel.Size = new System.Drawing.Size(214, 19);
            this.RoomCountLabel.TabIndex = 3;
            this.RoomCountLabel.Text = "Number of Rooms Available:\r\n";
            this.RoomCountLabel.Click += new System.EventHandler(this.RoomCountLabel_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Brown;
            this.DeleteBtn.Location = new System.Drawing.Point(730, 432);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(82, 30);
            this.DeleteBtn.TabIndex = 27;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RoomImage
            // 
            this.RoomImage.BackgroundImage = global::BookHotel.Properties.Resources.upload;
            this.RoomImage.Image = global::BookHotel.Properties.Resources.redbg;
            this.RoomImage.Location = new System.Drawing.Point(24, 29);
            this.RoomImage.Name = "RoomImage";
            this.RoomImage.Size = new System.Drawing.Size(381, 247);
            this.RoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomImage.TabIndex = 20;
            this.RoomImage.TabStop = false;
            this.RoomImage.Click += new System.EventHandler(this.RoomImage_Click);
            // 
            // editHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 480);
            this.Controls.Add(this.RoomPanel);
            this.Name = "editHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editHotels";
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.TextBox NumberAvailable;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.TextBox txtPrice4;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.PictureBox RoomImage;
        private System.Windows.Forms.CheckBox AvailableBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Weekday12Label;
        private System.Windows.Forms.Label Weekend3Label;
        private System.Windows.Forms.Label Weekday3Label;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label RoomCountLabel;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
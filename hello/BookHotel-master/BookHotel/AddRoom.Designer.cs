using System;

namespace BookHotel
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.txtPrice4 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.NumberAvailable = new System.Windows.Forms.TextBox();
            this.RoomImage = new System.Windows.Forms.PictureBox();
            this.AvailableBox = new System.Windows.Forms.CheckBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Weekday12Label = new System.Windows.Forms.Label();
            this.Weekend3Label = new System.Windows.Forms.Label();
            this.Weekday3Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Room1 = new System.Windows.Forms.Button();
            this.Room2 = new System.Windows.Forms.Button();
            this.Room3 = new System.Windows.Forms.Button();
            this.Room4 = new System.Windows.Forms.Button();
            this.Room5 = new System.Windows.Forms.Button();
            this.Room6 = new System.Windows.Forms.Button();
            this.Room7 = new System.Windows.Forms.Button();
            this.Room8 = new System.Windows.Forms.Button();
            this.Room9 = new System.Windows.Forms.Button();
            this.Room10 = new System.Windows.Forms.Button();
            this.Room11 = new System.Windows.Forms.Button();
            this.Room12 = new System.Windows.Forms.Button();
            this.Room13 = new System.Windows.Forms.Button();
            this.Room14 = new System.Windows.Forms.Button();
            this.Room15 = new System.Windows.Forms.Button();
            this.Room16 = new System.Windows.Forms.Button();
            this.Room17 = new System.Windows.Forms.Button();
            this.Room18 = new System.Windows.Forms.Button();
            this.Room19 = new System.Windows.Forms.Button();
            this.Room20 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RoomCountLabel = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImage)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomPanel
            // 
            this.RoomPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RoomPanel.Controls.Add(this.RoomName);
            this.RoomPanel.Controls.Add(this.txtPrice4);
            this.RoomPanel.Controls.Add(this.txtPrice3);
            this.RoomPanel.Controls.Add(this.txtPrice2);
            this.RoomPanel.Controls.Add(this.txtPrice1);
            this.RoomPanel.Controls.Add(this.NumberAvailable);
            this.RoomPanel.Controls.Add(this.RoomImage);
            this.RoomPanel.Controls.Add(this.AvailableBox);
            this.RoomPanel.Controls.Add(this.DescriptionLabel);
            this.RoomPanel.Controls.Add(this.DescriptionBox);
            this.RoomPanel.Controls.Add(this.label4);
            this.RoomPanel.Controls.Add(this.Weekday12Label);
            this.RoomPanel.Controls.Add(this.Weekend3Label);
            this.RoomPanel.Controls.Add(this.Weekday3Label);
            this.RoomPanel.Controls.Add(this.label3);
            this.RoomPanel.Controls.Add(this.flowLayoutPanel2);
            this.RoomPanel.Controls.Add(this.SaveButton);
            this.RoomPanel.Controls.Add(this.RoomCountLabel);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(828, 480);
            this.RoomPanel.TabIndex = 5;
            // 
            // txtPrice4
            // 
            this.txtPrice4.Location = new System.Drawing.Point(762, 211);
            this.txtPrice4.Name = "txtPrice4";
            this.txtPrice4.Size = new System.Drawing.Size(25, 20);
            this.txtPrice4.TabIndex = 25;
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(762, 178);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(25, 20);
            this.txtPrice3.TabIndex = 24;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(762, 142);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(25, 20);
            this.txtPrice2.TabIndex = 23;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(762, 106);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(25, 20);
            this.txtPrice1.TabIndex = 22;
            // 
            // NumberAvailable
            // 
            this.NumberAvailable.Location = new System.Drawing.Point(762, 72);
            this.NumberAvailable.Name = "NumberAvailable";
            this.NumberAvailable.Size = new System.Drawing.Size(25, 20);
            this.NumberAvailable.TabIndex = 21;
            // 
            // RoomImage
            // 
            this.RoomImage.BackgroundImage = global::BookHotel.Properties.Resources.upload;
            this.RoomImage.Image = global::BookHotel.Properties.Resources.redbg;
            this.RoomImage.Location = new System.Drawing.Point(24, 29);
            this.RoomImage.Name = "RoomImage";
            this.RoomImage.Size = new System.Drawing.Size(381, 247);
            this.RoomImage.TabIndex = 20;
            this.RoomImage.TabStop = false;
            this.RoomImage.Click += new System.EventHandler(this.RoomImage_Click);
            // 
            // AvailableBox
            // 
            this.AvailableBox.AutoSize = true;
            this.AvailableBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBox.Location = new System.Drawing.Point(616, 435);
            this.AvailableBox.Name = "AvailableBox";
            this.AvailableBox.Size = new System.Drawing.Size(104, 23);
            this.AvailableBox.TabIndex = 19;
            this.AvailableBox.Text = "Available";
            this.AvailableBox.UseVisualStyleBackColor = true;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Numbers";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Room1);
            this.flowLayoutPanel2.Controls.Add(this.Room2);
            this.flowLayoutPanel2.Controls.Add(this.Room3);
            this.flowLayoutPanel2.Controls.Add(this.Room4);
            this.flowLayoutPanel2.Controls.Add(this.Room5);
            this.flowLayoutPanel2.Controls.Add(this.Room6);
            this.flowLayoutPanel2.Controls.Add(this.Room7);
            this.flowLayoutPanel2.Controls.Add(this.Room8);
            this.flowLayoutPanel2.Controls.Add(this.Room9);
            this.flowLayoutPanel2.Controls.Add(this.Room10);
            this.flowLayoutPanel2.Controls.Add(this.Room11);
            this.flowLayoutPanel2.Controls.Add(this.Room12);
            this.flowLayoutPanel2.Controls.Add(this.Room13);
            this.flowLayoutPanel2.Controls.Add(this.Room14);
            this.flowLayoutPanel2.Controls.Add(this.Room15);
            this.flowLayoutPanel2.Controls.Add(this.Room16);
            this.flowLayoutPanel2.Controls.Add(this.Room17);
            this.flowLayoutPanel2.Controls.Add(this.Room18);
            this.flowLayoutPanel2.Controls.Add(this.Room19);
            this.flowLayoutPanel2.Controls.Add(this.Room20);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(443, 279);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 145);
            this.flowLayoutPanel2.TabIndex = 5;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // Room1
            // 
            this.Room1.Location = new System.Drawing.Point(3, 3);
            this.Room1.Name = "Room1";
            this.Room1.Size = new System.Drawing.Size(34, 42);
            this.Room1.TabIndex = 0;
            this.Room1.Text = "1";
            this.Room1.UseVisualStyleBackColor = true;
            this.Room1.Click += new System.EventHandler(this.Room1_Click);
            // 
            // Room2
            // 
            this.Room2.Location = new System.Drawing.Point(43, 3);
            this.Room2.Name = "Room2";
            this.Room2.Size = new System.Drawing.Size(34, 42);
            this.Room2.TabIndex = 1;
            this.Room2.Text = "2";
            this.Room2.UseVisualStyleBackColor = true;
            this.Room2.Click += new System.EventHandler(this.Room2_Click);
            // 
            // Room3
            // 
            this.Room3.Location = new System.Drawing.Point(83, 3);
            this.Room3.Name = "Room3";
            this.Room3.Size = new System.Drawing.Size(34, 42);
            this.Room3.TabIndex = 2;
            this.Room3.Text = "3";
            this.Room3.UseVisualStyleBackColor = true;
            this.Room3.Click += new System.EventHandler(this.Room3_Click);
            // 
            // Room4
            // 
            this.Room4.Location = new System.Drawing.Point(123, 3);
            this.Room4.Name = "Room4";
            this.Room4.Size = new System.Drawing.Size(34, 42);
            this.Room4.TabIndex = 3;
            this.Room4.Text = "4";
            this.Room4.UseVisualStyleBackColor = true;
            // 
            // Room5
            // 
            this.Room5.Location = new System.Drawing.Point(163, 3);
            this.Room5.Name = "Room5";
            this.Room5.Size = new System.Drawing.Size(34, 42);
            this.Room5.TabIndex = 4;
            this.Room5.Text = "5";
            this.Room5.UseVisualStyleBackColor = true;
            // 
            // Room6
            // 
            this.Room6.Location = new System.Drawing.Point(203, 3);
            this.Room6.Name = "Room6";
            this.Room6.Size = new System.Drawing.Size(34, 42);
            this.Room6.TabIndex = 5;
            this.Room6.Text = "6";
            this.Room6.UseVisualStyleBackColor = true;
            // 
            // Room7
            // 
            this.Room7.Location = new System.Drawing.Point(243, 3);
            this.Room7.Name = "Room7";
            this.Room7.Size = new System.Drawing.Size(34, 42);
            this.Room7.TabIndex = 6;
            this.Room7.Text = "7";
            this.Room7.UseVisualStyleBackColor = true;
            // 
            // Room8
            // 
            this.Room8.Location = new System.Drawing.Point(283, 3);
            this.Room8.Name = "Room8";
            this.Room8.Size = new System.Drawing.Size(34, 42);
            this.Room8.TabIndex = 7;
            this.Room8.Text = "8";
            this.Room8.UseVisualStyleBackColor = true;
            // 
            // Room9
            // 
            this.Room9.Location = new System.Drawing.Point(3, 51);
            this.Room9.Name = "Room9";
            this.Room9.Size = new System.Drawing.Size(34, 42);
            this.Room9.TabIndex = 8;
            this.Room9.Text = "9";
            this.Room9.UseVisualStyleBackColor = true;
            // 
            // Room10
            // 
            this.Room10.Location = new System.Drawing.Point(43, 51);
            this.Room10.Name = "Room10";
            this.Room10.Size = new System.Drawing.Size(34, 42);
            this.Room10.TabIndex = 9;
            this.Room10.Text = "10";
            this.Room10.UseVisualStyleBackColor = true;
            // 
            // Room11
            // 
            this.Room11.Location = new System.Drawing.Point(83, 51);
            this.Room11.Name = "Room11";
            this.Room11.Size = new System.Drawing.Size(34, 42);
            this.Room11.TabIndex = 10;
            this.Room11.Text = "11";
            this.Room11.UseVisualStyleBackColor = true;
            // 
            // Room12
            // 
            this.Room12.Location = new System.Drawing.Point(123, 51);
            this.Room12.Name = "Room12";
            this.Room12.Size = new System.Drawing.Size(34, 42);
            this.Room12.TabIndex = 11;
            this.Room12.Text = "12";
            this.Room12.UseVisualStyleBackColor = true;
            // 
            // Room13
            // 
            this.Room13.Location = new System.Drawing.Point(163, 51);
            this.Room13.Name = "Room13";
            this.Room13.Size = new System.Drawing.Size(34, 42);
            this.Room13.TabIndex = 12;
            this.Room13.Text = "13";
            this.Room13.UseVisualStyleBackColor = true;
            // 
            // Room14
            // 
            this.Room14.Location = new System.Drawing.Point(203, 51);
            this.Room14.Name = "Room14";
            this.Room14.Size = new System.Drawing.Size(34, 42);
            this.Room14.TabIndex = 13;
            this.Room14.Text = "14";
            this.Room14.UseVisualStyleBackColor = true;
            // 
            // Room15
            // 
            this.Room15.Location = new System.Drawing.Point(243, 51);
            this.Room15.Name = "Room15";
            this.Room15.Size = new System.Drawing.Size(34, 42);
            this.Room15.TabIndex = 14;
            this.Room15.Text = "15";
            this.Room15.UseVisualStyleBackColor = true;
            // 
            // Room16
            // 
            this.Room16.Location = new System.Drawing.Point(283, 51);
            this.Room16.Name = "Room16";
            this.Room16.Size = new System.Drawing.Size(34, 42);
            this.Room16.TabIndex = 15;
            this.Room16.Text = "16";
            this.Room16.UseVisualStyleBackColor = true;
            // 
            // Room17
            // 
            this.Room17.Location = new System.Drawing.Point(3, 99);
            this.Room17.Name = "Room17";
            this.Room17.Size = new System.Drawing.Size(34, 42);
            this.Room17.TabIndex = 16;
            this.Room17.Text = "17";
            this.Room17.UseVisualStyleBackColor = true;
            // 
            // Room18
            // 
            this.Room18.Location = new System.Drawing.Point(43, 99);
            this.Room18.Name = "Room18";
            this.Room18.Size = new System.Drawing.Size(34, 42);
            this.Room18.TabIndex = 17;
            this.Room18.Text = "18";
            this.Room18.UseVisualStyleBackColor = true;
            // 
            // Room19
            // 
            this.Room19.Location = new System.Drawing.Point(83, 99);
            this.Room19.Name = "Room19";
            this.Room19.Size = new System.Drawing.Size(34, 42);
            this.Room19.TabIndex = 18;
            this.Room19.Text = "19";
            this.Room19.UseVisualStyleBackColor = true;
            // 
            // Room20
            // 
            this.Room20.Location = new System.Drawing.Point(123, 99);
            this.Room20.Name = "Room20";
            this.Room20.Size = new System.Drawing.Size(34, 42);
            this.Room20.TabIndex = 19;
            this.Room20.Text = "20";
            this.Room20.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Brown;
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(726, 430);
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
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(828, 480);
            this.Controls.Add(this.RoomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.Text = "Sogo Hotel";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomImage)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void RoomNameLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label RoomCountLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Room1;
        private System.Windows.Forms.Button Room2;
        private System.Windows.Forms.Button Room3;
        private System.Windows.Forms.Button Room4;
        private System.Windows.Forms.Button Room5;
        private System.Windows.Forms.Button Room6;
        private System.Windows.Forms.Button Room7;
        private System.Windows.Forms.Button Room8;
        private System.Windows.Forms.Button Room9;
        private System.Windows.Forms.Button Room10;
        private System.Windows.Forms.Button Room11;
        private System.Windows.Forms.Button Room12;
        private System.Windows.Forms.Button Room13;
        private System.Windows.Forms.Button Room14;
        private System.Windows.Forms.Button Room15;
        private System.Windows.Forms.Button Room16;
        private System.Windows.Forms.Button Room17;
        private System.Windows.Forms.Button Room18;
        private System.Windows.Forms.Button Room19;
        private System.Windows.Forms.Button Room20;
        private System.Windows.Forms.Label Weekend3Label;
        private System.Windows.Forms.Label Weekday3Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Weekday12Label;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.CheckBox AvailableBox;
        private System.Windows.Forms.PictureBox RoomImage;
        private System.Windows.Forms.TextBox NumberAvailable;
        private System.Windows.Forms.TextBox txtPrice4;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox RoomName;
    }
}
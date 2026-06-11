using System;

namespace BookHotel
{
    partial class adminBookingModal
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
            this.Lbemail = new System.Windows.Forms.Label();
            this.LbFirstName = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbRoomName = new System.Windows.Forms.Label();
            this.LbRoomNumber = new System.Windows.Forms.Label();
            this.LbBookDate = new System.Windows.Forms.Label();
            this.LbTime = new System.Windows.Forms.Label();
            this.PaidBtn = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.LbCreated_at = new System.Windows.Forms.Label();
            this.LbPhoneNum = new System.Windows.Forms.Label();
            this.hotelImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbemail
            // 
            this.Lbemail.AutoSize = true;
            this.Lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbemail.Location = new System.Drawing.Point(33, 20);
            this.Lbemail.Name = "Lbemail";
            this.Lbemail.Size = new System.Drawing.Size(46, 20);
            this.Lbemail.TabIndex = 0;
            this.Lbemail.Text = "email";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFirstName.Location = new System.Drawing.Point(33, 54);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(82, 20);
            this.LbFirstName.TabIndex = 1;
            this.LbFirstName.Text = "FirstName";
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLastName.Location = new System.Drawing.Point(132, 54);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(82, 20);
            this.LbLastName.TabIndex = 2;
            this.LbLastName.Text = "LastName";
            // 
            // LbRoomName
            // 
            this.LbRoomName.AutoSize = true;
            this.LbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomName.Location = new System.Drawing.Point(33, 127);
            this.LbRoomName.Name = "LbRoomName";
            this.LbRoomName.Size = new System.Drawing.Size(117, 20);
            this.LbRoomName.TabIndex = 3;
            this.LbRoomName.Text = "Room Name: ";
            // 
            // LbRoomNumber
            // 
            this.LbRoomNumber.AutoSize = true;
            this.LbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomNumber.Location = new System.Drawing.Point(34, 172);
            this.LbRoomNumber.Name = "LbRoomNumber";
            this.LbRoomNumber.Size = new System.Drawing.Size(81, 20);
            this.LbRoomNumber.TabIndex = 4;
            this.LbRoomNumber.Text = "Room #: ";
            // 
            // LbBookDate
            // 
            this.LbBookDate.AutoSize = true;
            this.LbBookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBookDate.Location = new System.Drawing.Point(34, 244);
            this.LbBookDate.Name = "LbBookDate";
            this.LbBookDate.Size = new System.Drawing.Size(59, 20);
            this.LbBookDate.TabIndex = 5;
            this.LbBookDate.Text = "When: ";
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.Location = new System.Drawing.Point(34, 264);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(51, 20);
            this.LbTime.TabIndex = 6;
            this.LbTime.Text = "Time: ";
            // 
            // PaidBtn
            // 
            this.PaidBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PaidBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PaidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaidBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.PaidBtn.Location = new System.Drawing.Point(497, 311);
            this.PaidBtn.Name = "PaidBtn";
            this.PaidBtn.Size = new System.Drawing.Size(83, 32);
            this.PaidBtn.TabIndex = 7;
            this.PaidBtn.Text = "Paid";
            this.PaidBtn.UseVisualStyleBackColor = true;
            this.PaidBtn.Click += new System.EventHandler(this.PaidBtn_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.ForeColor = System.Drawing.Color.Gold;
            this.CancelBTN.Location = new System.Drawing.Point(586, 311);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(83, 32);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "Canceled";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DoneBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DoneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBTN.ForeColor = System.Drawing.Color.Sienna;
            this.DoneBTN.Location = new System.Drawing.Point(675, 311);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(83, 32);
            this.DoneBTN.TabIndex = 9;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // LbCreated_at
            // 
            this.LbCreated_at.AutoSize = true;
            this.LbCreated_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCreated_at.Location = new System.Drawing.Point(492, 20);
            this.LbCreated_at.Name = "LbCreated_at";
            this.LbCreated_at.Size = new System.Drawing.Size(89, 20);
            this.LbCreated_at.TabIndex = 10;
            this.LbCreated_at.Text = "Created_at";
            this.LbCreated_at.Click += new System.EventHandler(this.LbCreated_at_Click);
            // 
            // LbPhoneNum
            // 
            this.LbPhoneNum.AutoSize = true;
            this.LbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhoneNum.Location = new System.Drawing.Point(493, 54);
            this.LbPhoneNum.Name = "LbPhoneNum";
            this.LbPhoneNum.Size = new System.Drawing.Size(113, 20);
            this.LbPhoneNum.TabIndex = 11;
            this.LbPhoneNum.Text = "Phone number";
            // 
            // hotelImage
            // 
            this.hotelImage.Location = new System.Drawing.Point(569, 92);
            this.hotelImage.Name = "hotelImage";
            this.hotelImage.Size = new System.Drawing.Size(189, 157);
            this.hotelImage.TabIndex = 12;
            this.hotelImage.TabStop = false;
            this.hotelImage.Click += new System.EventHandler(this.hotelImage_Click);
            // 
            // adminBookingModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 355);
            this.Controls.Add(this.hotelImage);
            this.Controls.Add(this.LbPhoneNum);
            this.Controls.Add(this.LbCreated_at);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.PaidBtn);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.LbBookDate);
            this.Controls.Add(this.LbRoomNumber);
            this.Controls.Add(this.LbRoomName);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.LbFirstName);
            this.Controls.Add(this.Lbemail);
            this.Name = "adminBookingModal";
            this.Text = "adminBookingModal";
            this.Load += new System.EventHandler(this.adminBookingModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void hotelImage_Click(object sender, EventArgs e)
        {
            
        }

        private void LbCreated_at_Click(object sender, EventArgs e)
        {
            
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Label Lbemail;
        private System.Windows.Forms.Label LbFirstName;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbRoomName;
        private System.Windows.Forms.Label LbRoomNumber;
        private System.Windows.Forms.Label LbBookDate;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Button PaidBtn;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button DoneBTN;
        private System.Windows.Forms.Label LbCreated_at;
        private System.Windows.Forms.Label LbPhoneNum;
        private System.Windows.Forms.PictureBox hotelImage;
    }
}
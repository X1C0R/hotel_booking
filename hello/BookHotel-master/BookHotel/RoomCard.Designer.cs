namespace BookHotel
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRoomName = new System.Windows.Forms.Label();
            this.pbRoomImage = new System.Windows.Forms.PictureBox();
            this.RoomNumber = new System.Windows.Forms.Label();
            this.RoomDesc = new System.Windows.Forms.Label();
            this.WeekEndPrice = new System.Windows.Forms.Label();
            this.WeekDaysPrice = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRoomName.Location = new System.Drawing.Point(379, 19);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(117, 24);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "Room Name";
            // 
            // pbRoomImage
            // 
            this.pbRoomImage.Location = new System.Drawing.Point(3, 3);
            this.pbRoomImage.Name = "pbRoomImage";
            this.pbRoomImage.Size = new System.Drawing.Size(344, 204);
            this.pbRoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRoomImage.TabIndex = 0;
            this.pbRoomImage.TabStop = false;
            this.pbRoomImage.Click += new System.EventHandler(this.pbRoomImage_Click);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSize = true;
            this.RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber.Location = new System.Drawing.Point(380, 55);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(107, 18);
            this.RoomNumber.TabIndex = 2;
            this.RoomNumber.Text = "Room Number";
            this.RoomNumber.Click += new System.EventHandler(this.RoomNumber_Click);
            // 
            // RoomDesc
            // 
            this.RoomDesc.AutoSize = true;
            this.RoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDesc.Location = new System.Drawing.Point(379, 84);
            this.RoomDesc.Name = "RoomDesc";
            this.RoomDesc.Size = new System.Drawing.Size(136, 20);
            this.RoomDesc.TabIndex = 3;
            this.RoomDesc.Text = "Room Description";
            this.RoomDesc.Click += new System.EventHandler(this.RoomDesc_Click);
            // 
            // WeekEndPrice
            // 
            this.WeekEndPrice.AutoSize = true;
            this.WeekEndPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekEndPrice.Location = new System.Drawing.Point(383, 121);
            this.WeekEndPrice.Name = "WeekEndPrice";
            this.WeekEndPrice.Size = new System.Drawing.Size(90, 15);
            this.WeekEndPrice.TabIndex = 4;
            this.WeekEndPrice.Text = "Week endPrice";
            // 
            // WeekDaysPrice
            // 
            this.WeekDaysPrice.AutoSize = true;
            this.WeekDaysPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekDaysPrice.Location = new System.Drawing.Point(383, 153);
            this.WeekDaysPrice.Name = "WeekDaysPrice";
            this.WeekDaysPrice.Size = new System.Drawing.Size(41, 15);
            this.WeekDaysPrice.TabIndex = 6;
            this.WeekDaysPrice.Text = "label2";
            this.WeekDaysPrice.Click += new System.EventHandler(this.WeekDaysPrice_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.IndianRed;
            this.Status.Location = new System.Drawing.Point(459, 269);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 7;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // RoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.WeekDaysPrice);
            this.Controls.Add(this.WeekEndPrice);
            this.Controls.Add(this.RoomDesc);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.pbRoomImage);
            this.Name = "RoomCard";
            this.Size = new System.Drawing.Size(657, 298);
            this.Load += new System.EventHandler(this.RoomCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoomImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRoomImage;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label RoomNumber;
        private System.Windows.Forms.Label RoomDesc;
        private System.Windows.Forms.Label WeekEndPrice;
        private System.Windows.Forms.Label WeekDaysPrice;
        private System.Windows.Forms.Label Status;
    }
}

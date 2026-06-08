namespace BookHotel
{
    partial class AdminBookings
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowBookings =
                new System.Windows.Forms.FlowLayoutPanel();

            this.SuspendLayout();

            //
            // flowBookings
            //
            this.flowBookings.AutoScroll = true;
            this.flowBookings.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.flowBookings.Location =
                new System.Drawing.Point(0, 0);
            this.flowBookings.Name = "flowBookings";
            this.flowBookings.Size =
                new System.Drawing.Size(1200, 700);
            this.flowBookings.TabIndex = 0;

            //
            // AdminBookings
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 245, 245);

            this.ClientSize =
                new System.Drawing.Size(1200, 700);

            this.Controls.Add(this.flowBookings);

            this.Name = "AdminBookings";

            this.Text = "Pending Bookings";

            this.Load +=
                new System.EventHandler(
                    this.AdminBookings_Load);

            this.ResumeLayout(false);
        }
    }
}
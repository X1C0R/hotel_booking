namespace BookHotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInPanel
            // 
            this.LogInPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogInPanel.BackColor = System.Drawing.Color.Maroon;
            this.LogInPanel.Controls.Add(this.LoginButton);
            this.LogInPanel.Controls.Add(this.SignUpLabel);
            this.LogInPanel.Controls.Add(this.pictureBox1);
            this.LogInPanel.Controls.Add(this.label1);
            this.LogInPanel.Controls.Add(this.PasswordLabel);
            this.LogInPanel.Controls.Add(this.EmailLabel);
            this.LogInPanel.Controls.Add(this.PasswordBox);
            this.LogInPanel.Controls.Add(this.EmailBox);
            this.LogInPanel.Controls.Add(this.GreetingLabel);
            this.LogInPanel.Location = new System.Drawing.Point(216, 79);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(373, 335);
            this.LogInPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Firebrick;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(68, 242);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(245, 27);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUpLabel.Location = new System.Drawing.Point(208, 285);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(49, 14);
            this.SignUpLabel.TabIndex = 7;
            this.SignUpLabel.Text = "Sign Up";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "No Account? |";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Maroon;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(69, 176);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 18);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Maroon;
            this.EmailLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(69, 117);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 18);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(68, 197);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(245, 23);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(68, 140);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(245, 26);
            this.EmailBox.TabIndex = 2;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GreetingLabel.Location = new System.Drawing.Point(126, 77);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(128, 19);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "Log In to Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BookHotel.Properties.Resources.goldfan;
            this.pictureBox1.Image = global::BookHotel.Properties.Resources.ssfan;
            this.pictureBox1.Location = new System.Drawing.Point(165, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.LogInPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Sogo Hotel";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoginButton;
    }
}


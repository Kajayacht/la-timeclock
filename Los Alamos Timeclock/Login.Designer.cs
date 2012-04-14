namespace Los_Alamos_Timeclock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label userLabel;
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.dancingTaco2 = new System.Windows.Forms.PictureBox();
            this.dancingTaco1 = new System.Windows.Forms.PictureBox();
            this.dancingChile2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.clock1 = new Los_Alamos_Timeclock.Clock();
            passLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dancingTaco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancingTaco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancingChile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // passLabel
            // 
            passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            passLabel.AutoSize = true;
            passLabel.BackColor = System.Drawing.Color.Transparent;
            passLabel.Location = new System.Drawing.Point(132, 183);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(56, 13);
            passLabel.TabIndex = 9;
            passLabel.Text = "Password:";
            // 
            // userLabel
            // 
            userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            userLabel.AutoSize = true;
            userLabel.BackColor = System.Drawing.Color.Transparent;
            userLabel.Location = new System.Drawing.Point(132, 160);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(32, 13);
            userLabel.TabIndex = 8;
            userLabel.Text = "User:";
            // 
            // userTextbox
            // 
            this.userTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTextbox.Location = new System.Drawing.Point(194, 160);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(100, 20);
            this.userTextbox.TabIndex = 0;
            // 
            // passTextbox
            // 
            this.passTextbox.AcceptsReturn = true;
            this.passTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTextbox.Location = new System.Drawing.Point(194, 183);
            this.passTextbox.Multiline = true;
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '*';
            this.passTextbox.Size = new System.Drawing.Size(100, 20);
            this.passTextbox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(194, 209);
            this.loginButton.MaximumSize = new System.Drawing.Size(200, 100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 25);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.B_login_Click);
            // 
            // dancingTaco2
            // 
            this.dancingTaco2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dancingTaco2.BackColor = System.Drawing.Color.Transparent;
            this.dancingTaco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dancingTaco2.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingtaco;
            this.dancingTaco2.Location = new System.Drawing.Point(250, 150);
            this.dancingTaco2.Name = "dancingTaco2";
            this.dancingTaco2.Size = new System.Drawing.Size(250, 250);
            this.dancingTaco2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dancingTaco2.TabIndex = 12;
            this.dancingTaco2.TabStop = false;
            // 
            // dancingTaco1
            // 
            this.dancingTaco1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dancingTaco1.BackColor = System.Drawing.Color.Transparent;
            this.dancingTaco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dancingTaco1.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingtaco;
            this.dancingTaco1.Location = new System.Drawing.Point(0, 150);
            this.dancingTaco1.Name = "dancingTaco1";
            this.dancingTaco1.Size = new System.Drawing.Size(250, 250);
            this.dancingTaco1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dancingTaco1.TabIndex = 11;
            this.dancingTaco1.TabStop = false;
            // 
            // dancingChile2
            // 
            this.dancingChile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dancingChile2.BackColor = System.Drawing.Color.Transparent;
            this.dancingChile2.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingChile;
            this.dancingChile2.Location = new System.Drawing.Point(435, 335);
            this.dancingChile2.Margin = new System.Windows.Forms.Padding(0);
            this.dancingChile2.Name = "dancingChile2";
            this.dancingChile2.Size = new System.Drawing.Size(65, 65);
            this.dancingChile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dancingChile2.TabIndex = 13;
            this.dancingChile2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingChile;
            this.pictureBox1.Location = new System.Drawing.Point(251, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingChile;
            this.pictureBox2.Location = new System.Drawing.Point(0, 335);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancingChile;
            this.pictureBox3.Location = new System.Drawing.Point(186, 335);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // clock1
            // 
            this.clock1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock1.AutoSize = true;
            this.clock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clock1.BackColor = System.Drawing.Color.Transparent;
            this.clock1.Location = new System.Drawing.Point(149, 117);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(194, 37);
            this.clock1.TabIndex = 10;
            this.clock1.Load += new System.EventHandler(this.clock1_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dancingChile2);
            this.Controls.Add(this.clock1);
            this.Controls.Add(passLabel);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.dancingTaco1);
            this.Controls.Add(this.dancingTaco2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dancingTaco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancingTaco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dancingChile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.TextBox userTextbox;
        public System.Windows.Forms.TextBox passTextbox;
        private Clock clock1;
        private System.Windows.Forms.PictureBox dancingTaco2;
        private System.Windows.Forms.PictureBox dancingTaco1;
        private System.Windows.Forms.PictureBox dancingChile2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

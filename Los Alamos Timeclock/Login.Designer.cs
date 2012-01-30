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
            this.L_Pass = new System.Windows.Forms.Label();
            this.L_User = new System.Windows.Forms.Label();
            this.IN_USER = new System.Windows.Forms.TextBox();
            this.IN_PASS = new System.Windows.Forms.TextBox();
            this.B_login = new System.Windows.Forms.Button();
            this.clock1 = new Los_Alamos_Timeclock.Clock();
            this.SuspendLayout();
            // 
            // L_Pass
            // 
            this.L_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Pass.AutoSize = true;
            this.L_Pass.BackColor = System.Drawing.Color.Transparent;
            this.L_Pass.ForeColor = System.Drawing.Color.Red;
            this.L_Pass.Location = new System.Drawing.Point(132, 183);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(56, 13);
            this.L_Pass.TabIndex = 9;
            this.L_Pass.Text = "Password:";
            // 
            // L_User
            // 
            this.L_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_User.AutoSize = true;
            this.L_User.BackColor = System.Drawing.Color.Transparent;
            this.L_User.ForeColor = System.Drawing.Color.Red;
            this.L_User.Location = new System.Drawing.Point(132, 160);
            this.L_User.Name = "L_User";
            this.L_User.Size = new System.Drawing.Size(32, 13);
            this.L_User.TabIndex = 8;
            this.L_User.Text = "User:";
            // 
            // IN_USER
            // 
            this.IN_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IN_USER.Location = new System.Drawing.Point(194, 160);
            this.IN_USER.Name = "IN_USER";
            this.IN_USER.Size = new System.Drawing.Size(100, 20);
            this.IN_USER.TabIndex = 1;
            this.IN_USER.TextChanged += new System.EventHandler(this.IN_USER_TextChanged);
            // 
            // IN_PASS
            // 
            this.IN_PASS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IN_PASS.Location = new System.Drawing.Point(194, 183);
            this.IN_PASS.Name = "IN_PASS";
            this.IN_PASS.PasswordChar = '*';
            this.IN_PASS.Size = new System.Drawing.Size(100, 20);
            this.IN_PASS.TabIndex = 2;
            // 
            // B_login
            // 
            this.B_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_login.Location = new System.Drawing.Point(194, 209);
            this.B_login.MaximumSize = new System.Drawing.Size(200, 100);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(100, 25);
            this.B_login.TabIndex = 3;
            this.B_login.Text = "Login";
            this.B_login.UseVisualStyleBackColor = true;
            this.B_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // clock1
            // 
            this.clock1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock1.AutoSize = true;
            this.clock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clock1.BackColor = System.Drawing.Color.Transparent;
            this.clock1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.L_User);
            this.Controls.Add(this.IN_USER);
            this.Controls.Add(this.IN_PASS);
            this.Controls.Add(this.B_login);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.Label L_User;
        private System.Windows.Forms.Button B_login;
        public System.Windows.Forms.TextBox IN_USER;
        public System.Windows.Forms.TextBox IN_PASS;
        private Clock clock1;
    }
}

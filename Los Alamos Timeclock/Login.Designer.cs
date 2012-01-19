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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_login = new System.Windows.Forms.Button();
            this.IN_PASS = new System.Windows.Forms.TextBox();
            this.IN_USER = new System.Windows.Forms.TextBox();
            this.L_User = new System.Windows.Forms.Label();
            this.L_Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_login
            // 
            this.B_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_login.Location = new System.Drawing.Point(194, 197);
            this.B_login.MaximumSize = new System.Drawing.Size(200, 100);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(100, 25);
            this.B_login.TabIndex = 0;
            this.B_login.Text = "Login";
            this.B_login.UseVisualStyleBackColor = true;
            this.B_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // IN_PASS
            // 
            this.IN_PASS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IN_PASS.Location = new System.Drawing.Point(194, 171);
            this.IN_PASS.Name = "IN_PASS";
            this.IN_PASS.PasswordChar = '*';
            this.IN_PASS.Size = new System.Drawing.Size(100, 20);
            this.IN_PASS.TabIndex = 1;
            // 
            // IN_USER
            // 
            this.IN_USER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IN_USER.Location = new System.Drawing.Point(194, 148);
            this.IN_USER.Name = "IN_USER";
            this.IN_USER.Size = new System.Drawing.Size(100, 20);
            this.IN_USER.TabIndex = 2;
            this.IN_USER.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // L_User
            // 
            this.L_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_User.AutoSize = true;
            this.L_User.BackColor = System.Drawing.Color.Transparent;
            this.L_User.ForeColor = System.Drawing.Color.Red;
            this.L_User.Location = new System.Drawing.Point(132, 148);
            this.L_User.Name = "L_User";
            this.L_User.Size = new System.Drawing.Size(32, 13);
            this.L_User.TabIndex = 3;
            this.L_User.Text = "User:";
            this.L_User.Click += new System.EventHandler(this.label1_Click);
            // 
            // L_Pass
            // 
            this.L_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Pass.AutoSize = true;
            this.L_Pass.BackColor = System.Drawing.Color.Transparent;
            this.L_Pass.ForeColor = System.Drawing.Color.Red;
            this.L_Pass.Location = new System.Drawing.Point(132, 171);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(56, 13);
            this.L_Pass.TabIndex = 4;
            this.L_Pass.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.L_User);
            this.Controls.Add(this.IN_USER);
            this.Controls.Add(this.IN_PASS);
            this.Controls.Add(this.B_login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Alamos Timeclock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_login;
        private System.Windows.Forms.TextBox IN_PASS;
        private System.Windows.Forms.TextBox IN_USER;
        private System.Windows.Forms.Label L_User;
        private System.Windows.Forms.Label L_Pass;
    }
}


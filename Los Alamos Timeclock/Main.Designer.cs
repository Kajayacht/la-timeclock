namespace Los_Alamos_Timeclock
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu1 = new Los_Alamos_Timeclock.Menu();
            this.Login = new Los_Alamos_Timeclock.Login();
            this.Schedule = new Los_Alamos_Timeclock.Schedule();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.AutoSize = true;
            this.menu1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(0);
            this.menu1.MinimumSize = new System.Drawing.Size(70, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(70, 362);
            this.menu1.TabIndex = 1;
            this.menu1.Visible = false;
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(484, 362);
            this.Login.TabIndex = 2;
            this.Login.Load += new System.EventHandler(this.loginControl1_Load);
            // 
            // Schedule
            // 
            this.Schedule.AutoScroll = true;
            this.Schedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Schedule.Location = new System.Drawing.Point(70, 0);
            this.Schedule.Margin = new System.Windows.Forms.Padding(0);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(414, 362);
            this.Schedule.TabIndex = 3;
            this.Schedule.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.Login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Los Alamos Timeclock";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Menu menu1;
        public Login Login;
        public Schedule Schedule;





    }
}
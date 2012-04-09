namespace Los_Alamos_Timeclock
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.clockButton = new System.Windows.Forms.Button();
            this.requestsButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.contactInfoButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.Menuclock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.managerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockButton
            // 
            this.clockButton.AutoSize = true;
            this.clockButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clockButton.Location = new System.Drawing.Point(0, 0);
            this.clockButton.Margin = new System.Windows.Forms.Padding(0);
            this.clockButton.Name = "clockButton";
            this.clockButton.Size = new System.Drawing.Size(202, 46);
            this.clockButton.TabIndex = 100;
            this.clockButton.Text = "Clock in/out";
            this.clockButton.UseVisualStyleBackColor = true;
            this.clockButton.Click += new System.EventHandler(this.Clockin_Click);
            // 
            // requestsButton
            // 
            this.requestsButton.AutoSize = true;
            this.requestsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestsButton.Location = new System.Drawing.Point(0, 92);
            this.requestsButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(202, 46);
            this.requestsButton.TabIndex = 102;
            this.requestsButton.Text = "Requests";
            this.requestsButton.UseVisualStyleBackColor = true;
            this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.AutoSize = true;
            this.scheduleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleButton.Location = new System.Drawing.Point(0, 46);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(0);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(202, 46);
            this.scheduleButton.TabIndex = 101;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // contactInfoButton
            // 
            this.contactInfoButton.AutoSize = true;
            this.contactInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactInfoButton.Location = new System.Drawing.Point(0, 138);
            this.contactInfoButton.Margin = new System.Windows.Forms.Padding(0);
            this.contactInfoButton.Name = "contactInfoButton";
            this.contactInfoButton.Size = new System.Drawing.Size(202, 46);
            this.contactInfoButton.TabIndex = 103;
            this.contactInfoButton.Text = "Contact Information";
            this.contactInfoButton.UseVisualStyleBackColor = true;
            this.contactInfoButton.Click += new System.EventHandler(this.Contactinfo_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.Location = new System.Drawing.Point(0, 230);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(202, 46);
            this.logoutButton.TabIndex = 105;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Menuclock
            // 
            this.Menuclock.AutoSize = true;
            this.Menuclock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menuclock.Location = new System.Drawing.Point(0, 322);
            this.Menuclock.Name = "Menuclock";
            this.Menuclock.Size = new System.Drawing.Size(68, 13);
            this.Menuclock.TabIndex = 7;
            this.Menuclock.Text = "12:00:00 AM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // managerButton
            // 
            this.managerButton.AutoSize = true;
            this.managerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.managerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerButton.Location = new System.Drawing.Point(0, 184);
            this.managerButton.Margin = new System.Windows.Forms.Padding(0);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(202, 46);
            this.managerButton.TabIndex = 104;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.Menuclock);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.contactInfoButton);
            this.Controls.Add(this.requestsButton);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.clockButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(202, 335);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockButton;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button contactInfoButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label Menuclock;
        public System.Windows.Forms.Timer timer1;




    }
}

namespace Los_Alamos_Timeclock
{
    partial class Clockinout
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
            this.clockinButton = new System.Windows.Forms.Button();
            this.shiftinfoLabel = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.clockoutButton = new System.Windows.Forms.Button();
            this.jobImage = new System.Windows.Forms.PictureBox();
            this.statusMessagebox = new System.Windows.Forms.Label();
            this.BreakButton = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.managerOverrideButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobImage)).BeginInit();
            this.SuspendLayout();
            // 
            // clockinButton
            // 
            this.clockinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clockinButton.Location = new System.Drawing.Point(64, 291);
            this.clockinButton.Name = "clockinButton";
            this.clockinButton.Size = new System.Drawing.Size(75, 75);
            this.clockinButton.TabIndex = 0;
            this.clockinButton.Text = "Clock In";
            this.clockinButton.UseVisualStyleBackColor = true;
            this.clockinButton.Click += new System.EventHandler(this.clockin_Click);
            // 
            // shiftinfoLabel
            // 
            this.shiftinfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiftinfoLabel.AutoSize = true;
            this.shiftinfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.shiftinfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftinfoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.shiftinfoLabel.Location = new System.Drawing.Point(3, 90);
            this.shiftinfoLabel.Name = "shiftinfoLabel";
            this.shiftinfoLabel.Size = new System.Drawing.Size(77, 29);
            this.shiftinfoLabel.TabIndex = 1;
            this.shiftinfoLabel.Text = "TEST";
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(500, 37);
            this.welcome.TabIndex = 2;
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockoutButton
            // 
            this.clockoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clockoutButton.Location = new System.Drawing.Point(307, 291);
            this.clockoutButton.Name = "clockoutButton";
            this.clockoutButton.Size = new System.Drawing.Size(75, 75);
            this.clockoutButton.TabIndex = 3;
            this.clockoutButton.Text = "Clock Out";
            this.clockoutButton.UseVisualStyleBackColor = true;
            this.clockoutButton.Click += new System.EventHandler(this.Clockout_Click);
            // 
            // jobImage
            // 
            this.jobImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jobImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobImage.InitialImage = null;
            this.jobImage.Location = new System.Drawing.Point(332, 90);
            this.jobImage.Name = "jobImage";
            this.jobImage.Size = new System.Drawing.Size(150, 150);
            this.jobImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jobImage.TabIndex = 4;
            this.jobImage.TabStop = false;
            // 
            // statusMessagebox
            // 
            this.statusMessagebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusMessagebox.BackColor = System.Drawing.Color.Red;
            this.statusMessagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessagebox.Location = new System.Drawing.Point(332, 57);
            this.statusMessagebox.Name = "statusMessagebox";
            this.statusMessagebox.Size = new System.Drawing.Size(150, 30);
            this.statusMessagebox.TabIndex = 5;
            this.statusMessagebox.Text = "Clocked Out";
            this.statusMessagebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakButton
            // 
            this.BreakButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BreakButton.Location = new System.Drawing.Point(145, 291);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(75, 75);
            this.BreakButton.TabIndex = 1;
            this.BreakButton.Text = "Break In/Out";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.Click += new System.EventHandler(this.Break_Click);
            // 
            // lunchButton
            // 
            this.lunchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lunchButton.Location = new System.Drawing.Point(226, 291);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(75, 75);
            this.lunchButton.TabIndex = 2;
            this.lunchButton.Text = "Lunch In/Out";
            this.lunchButton.UseVisualStyleBackColor = true;
            this.lunchButton.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // managerOverrideButton
            // 
            this.managerOverrideButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerOverrideButton.Location = new System.Drawing.Point(388, 291);
            this.managerOverrideButton.Name = "managerOverrideButton";
            this.managerOverrideButton.Size = new System.Drawing.Size(75, 75);
            this.managerOverrideButton.TabIndex = 4;
            this.managerOverrideButton.Text = "Manager Override";
            this.managerOverrideButton.UseVisualStyleBackColor = true;
            this.managerOverrideButton.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Clockinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.managerOverrideButton);
            this.Controls.Add(this.lunchButton);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.statusMessagebox);
            this.Controls.Add(this.jobImage);
            this.Controls.Add(this.clockoutButton);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.shiftinfoLabel);
            this.Controls.Add(this.clockinButton);
            this.DoubleBuffered = true;
            this.Name = "Clockinout";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.jobImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
        }

        #endregion

        private System.Windows.Forms.Button clockinButton;
        private System.Windows.Forms.Label shiftinfoLabel;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button clockoutButton;
        private System.Windows.Forms.PictureBox jobImage;
        private System.Windows.Forms.Label statusMessagebox;
        private System.Windows.Forms.Button BreakButton;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Button managerOverrideButton;
    }
}

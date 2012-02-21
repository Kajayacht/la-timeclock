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
            this.clockin = new System.Windows.Forms.Button();
            this.shiftinfo = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.Clockout = new System.Windows.Forms.Button();
            this.jobimg = new System.Windows.Forms.PictureBox();
            this.statusmessage = new System.Windows.Forms.Label();
            this.Break = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobimg)).BeginInit();
            this.SuspendLayout();
            // 
            // clockin
            // 
            this.clockin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clockin.Location = new System.Drawing.Point(64, 291);
            this.clockin.Name = "clockin";
            this.clockin.Size = new System.Drawing.Size(75, 75);
            this.clockin.TabIndex = 0;
            this.clockin.Text = "Clock In";
            this.clockin.UseVisualStyleBackColor = true;
            this.clockin.Click += new System.EventHandler(this.clockin_Click);
            // 
            // shiftinfo
            // 
            this.shiftinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiftinfo.AutoSize = true;
            this.shiftinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shiftinfo.Location = new System.Drawing.Point(3, 90);
            this.shiftinfo.Name = "shiftinfo";
            this.shiftinfo.Size = new System.Drawing.Size(77, 29);
            this.shiftinfo.TabIndex = 1;
            this.shiftinfo.Text = "TEST";
            
            // 
            // welcome
            // 
            this.welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(500, 37);
            this.welcome.TabIndex = 2;
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // Clockout
            // 
            this.Clockout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clockout.Location = new System.Drawing.Point(307, 291);
            this.Clockout.Name = "Clockout";
            this.Clockout.Size = new System.Drawing.Size(75, 75);
            this.Clockout.TabIndex = 3;
            this.Clockout.Text = "Clock Out";
            this.Clockout.UseVisualStyleBackColor = true;
            this.Clockout.Click += new System.EventHandler(this.Clockout_Click);
            // 
            // jobimg
            // 
            this.jobimg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobimg.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources.none;
            this.jobimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobimg.InitialImage = null;
            this.jobimg.Location = new System.Drawing.Point(332, 90);
            this.jobimg.Name = "jobimg";
            this.jobimg.Size = new System.Drawing.Size(150, 150);
            this.jobimg.TabIndex = 4;
            this.jobimg.TabStop = false;
            
            // 
            // statusmessage
            // 
            this.statusmessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusmessage.BackColor = System.Drawing.Color.Red;
            this.statusmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusmessage.Location = new System.Drawing.Point(332, 57);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(150, 30);
            this.statusmessage.TabIndex = 5;
            this.statusmessage.Text = "Clocked Out";
            this.statusmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Break
            // 
            this.Break.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Break.Location = new System.Drawing.Point(145, 291);
            this.Break.Name = "Break";
            this.Break.Size = new System.Drawing.Size(75, 75);
            this.Break.TabIndex = 6;
            this.Break.Text = "Break In/Out";
            this.Break.UseVisualStyleBackColor = true;
            this.Break.Click += new System.EventHandler(this.Break_Click);
            // 
            // Lunch
            // 
            this.Lunch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lunch.Location = new System.Drawing.Point(226, 291);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(75, 75);
            this.Lunch.TabIndex = 7;
            this.Lunch.Text = "Lunch In/Out";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // Manager
            // 
            this.Manager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manager.Location = new System.Drawing.Point(388, 291);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(75, 75);
            this.Manager.TabIndex = 8;
            this.Manager.Text = "Manager Override";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // Clockinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Lunch);
            this.Controls.Add(this.Break);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.jobimg);
            this.Controls.Add(this.Clockout);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.shiftinfo);
            this.Controls.Add(this.clockin);
            this.DoubleBuffered = true;
            this.Name = "Clockinout";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.Clockinout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockin;
        private System.Windows.Forms.Label shiftinfo;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button Clockout;
        private System.Windows.Forms.PictureBox jobimg;
        private System.Windows.Forms.Label statusmessage;
        private System.Windows.Forms.Button Break;
        private System.Windows.Forms.Button Lunch;
        private System.Windows.Forms.Button Manager;
    }
}

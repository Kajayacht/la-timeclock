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
            this.button1 = new System.Windows.Forms.Button();
            this.jobimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobimg)).BeginInit();
            this.SuspendLayout();
            // 
            // clockin
            // 
            this.clockin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clockin.Location = new System.Drawing.Point(103, 273);
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
            this.shiftinfo.Click += new System.EventHandler(this.label1_Click);
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
            this.welcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(184, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clock Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // jobimg
            // 
            this.jobimg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobimg.Location = new System.Drawing.Point(332, 90);
            this.jobimg.Name = "jobimg";
            this.jobimg.Size = new System.Drawing.Size(150, 150);
            this.jobimg.TabIndex = 4;
            this.jobimg.TabStop = false;
            this.jobimg.Click += new System.EventHandler(this.jobimg_Click);
            // 
            // Clockinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.jobimg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.shiftinfo);
            this.Controls.Add(this.clockin);
            this.DoubleBuffered = true;
            this.Name = "Clockinout";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.jobimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockin;
        private System.Windows.Forms.Label shiftinfo;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox jobimg;
    }
}

namespace Los_Alamos_Timeclock
{
    partial class Clock
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
            this.Bigclock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Bigclock
            // 
            this.Bigclock.AutoSize = true;
            this.Bigclock.BackColor = System.Drawing.Color.Transparent;
            this.Bigclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bigclock.ForeColor = System.Drawing.Color.Lime;
            this.Bigclock.Location = new System.Drawing.Point(-7, 0);
            this.Bigclock.Name = "Bigclock";
            this.Bigclock.Size = new System.Drawing.Size(198, 37);
            this.Bigclock.TabIndex = 0;
            this.Bigclock.Text = "12:00:00 AM";
            this.Bigclock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bigclock.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Bigclock_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Bigclock);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(194, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bigclock;
        public System.Windows.Forms.Timer timer1;
    }
}

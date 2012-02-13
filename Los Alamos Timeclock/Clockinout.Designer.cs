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
            this.sstart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockin
            // 
            this.clockin.Location = new System.Drawing.Point(149, 253);
            this.clockin.Name = "clockin";
            this.clockin.Size = new System.Drawing.Size(75, 23);
            this.clockin.TabIndex = 0;
            this.clockin.Text = "Clock in";
            this.clockin.UseVisualStyleBackColor = true;
            this.clockin.Click += new System.EventHandler(this.clockin_Click);
            // 
            // sstart
            // 
            this.sstart.AutoSize = true;
            this.sstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sstart.Location = new System.Drawing.Point(149, 67);
            this.sstart.Name = "sstart";
            this.sstart.Size = new System.Drawing.Size(99, 37);
            this.sstart.TabIndex = 1;
            this.sstart.Text = "TEST";
            this.sstart.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clockinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.sstart);
            this.Controls.Add(this.clockin);
            this.DoubleBuffered = true;
            this.Name = "Clockinout";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clockin;
        private System.Windows.Forms.Label sstart;
    }
}

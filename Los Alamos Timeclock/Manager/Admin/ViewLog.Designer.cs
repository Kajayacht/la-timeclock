namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class viewLog
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
            this.logViewBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logViewBox
            // 
            this.logViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logViewBox.Location = new System.Drawing.Point(40, 25);
            this.logViewBox.Name = "logViewBox";
            this.logViewBox.ReadOnly = true;
            this.logViewBox.Size = new System.Drawing.Size(420, 300);
            this.logViewBox.TabIndex = 1;
            this.logViewBox.Text = "";
            // 
            // ViewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.logViewBox);
            this.DoubleBuffered = true;
            this.Name = "ViewLog";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            logViewBox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            logViewBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Main.maininstance.notIdle_event);
        }

        #endregion

        private System.Windows.Forms.RichTextBox logViewBox;
    }
}

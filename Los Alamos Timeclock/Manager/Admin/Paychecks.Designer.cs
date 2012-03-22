namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class Paychecks
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
            this.weekCalander = new System.Windows.Forms.DateTimePicker();
            this.weekLabel = new System.Windows.Forms.Label();
            this.payTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // weekCalander
            // 
            this.weekCalander.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekCalander.Location = new System.Drawing.Point(150, 3);
            this.weekCalander.Name = "weekCalander";
            this.weekCalander.Size = new System.Drawing.Size(200, 20);
            this.weekCalander.TabIndex = 0;
            this.weekCalander.ValueChanged += new System.EventHandler(this.weekCalander_ValueChanged);
            // 
            // weekLabel
            // 
            this.weekLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekLabel.AutoSize = true;
            this.weekLabel.BackColor = System.Drawing.Color.Transparent;
            this.weekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.ForeColor = System.Drawing.Color.White;
            this.weekLabel.Location = new System.Drawing.Point(102, 26);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(299, 25);
            this.weekLabel.TabIndex = 1;
            this.weekLabel.Text = "Pay for 2/27/2012-3/4/2012";
            // 
            // payTextbox
            // 
            this.payTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payTextbox.Location = new System.Drawing.Point(55, 78);
            this.payTextbox.Name = "payTextbox";
            this.payTextbox.ReadOnly = true;
            this.payTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.payTextbox.Size = new System.Drawing.Size(388, 263);
            this.payTextbox.TabIndex = 4;
            this.payTextbox.Text = "";
            // 
            // Paychecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.payTextbox);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.weekCalander);
            this.DoubleBuffered = true;
            this.Name = "Paychecks";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker weekCalander;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.RichTextBox payTextbox;
    }
}

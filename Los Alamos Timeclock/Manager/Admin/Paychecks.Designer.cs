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
            this.Week = new System.Windows.Forms.DateTimePicker();
            this.weeklabel = new System.Windows.Forms.Label();
            this.Pay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Week
            // 
            this.Week.Location = new System.Drawing.Point(150, 3);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(200, 20);
            this.Week.TabIndex = 0;
            this.Week.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // weeklabel
            // 
            this.weeklabel.AutoSize = true;
            this.weeklabel.BackColor = System.Drawing.Color.Transparent;
            this.weeklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklabel.ForeColor = System.Drawing.Color.White;
            this.weeklabel.Location = new System.Drawing.Point(102, 26);
            this.weeklabel.Name = "weeklabel";
            this.weeklabel.Size = new System.Drawing.Size(299, 25);
            this.weeklabel.TabIndex = 1;
            this.weeklabel.Text = "Pay for 2/27/2012-3/4/2012";
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(55, 78);
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Pay.Size = new System.Drawing.Size(388, 263);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "";
            // 
            // Paychecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.weeklabel);
            this.Controls.Add(this.Week);
            this.Name = "Paychecks";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Week;
        private System.Windows.Forms.Label weeklabel;
        private System.Windows.Forms.RichTextBox Pay;
    }
}

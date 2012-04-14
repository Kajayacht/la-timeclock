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
            System.Windows.Forms.Label disclaimerLabel;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            this.startCalander = new System.Windows.Forms.DateTimePicker();
            this.weekLabel = new System.Windows.Forms.Label();
            this.payTextbox = new System.Windows.Forms.RichTextBox();
            this.endCalander = new System.Windows.Forms.DateTimePicker();
            this.dashLabel = new System.Windows.Forms.Label();
            disclaimerLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // disclaimerLabel
            // 
            disclaimerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            disclaimerLabel.AutoSize = true;
            disclaimerLabel.BackColor = System.Drawing.Color.Transparent;
            disclaimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            disclaimerLabel.Location = new System.Drawing.Point(146, 369);
            disclaimerLabel.Name = "disclaimerLabel";
            disclaimerLabel.Size = new System.Drawing.Size(235, 20);
            disclaimerLabel.TabIndex = 5;
            disclaimerLabel.Text = "Pay based on current wages";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox1.Location = new System.Drawing.Point(427, 347);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 53);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox2.Location = new System.Drawing.Point(0, 347);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(73, 53);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // startCalander
            // 
            this.startCalander.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startCalander.Location = new System.Drawing.Point(36, 3);
            this.startCalander.Name = "startCalander";
            this.startCalander.Size = new System.Drawing.Size(200, 20);
            this.startCalander.TabIndex = 0;
            this.startCalander.ValueChanged += new System.EventHandler(this.startCalander_ValueChanged);
            // 
            // weekLabel
            // 
            this.weekLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekLabel.AutoSize = true;
            this.weekLabel.BackColor = System.Drawing.Color.Transparent;
            this.weekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.payTextbox.TabIndex = 2;
            this.payTextbox.Text = "";
            // 
            // endCalander
            // 
            this.endCalander.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endCalander.Location = new System.Drawing.Point(261, 3);
            this.endCalander.Name = "endCalander";
            this.endCalander.Size = new System.Drawing.Size(200, 20);
            this.endCalander.TabIndex = 1;
            this.endCalander.ValueChanged += new System.EventHandler(this.endCalander_ValueChanged);
            // 
            // dashLabel
            // 
            this.dashLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dashLabel.AutoSize = true;
            this.dashLabel.BackColor = System.Drawing.Color.Transparent;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.Location = new System.Drawing.Point(242, 3);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(15, 20);
            this.dashLabel.TabIndex = 7;
            this.dashLabel.Text = "-";
            // 
            // Paychecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.dashLabel);
            this.Controls.Add(this.endCalander);
            this.Controls.Add(disclaimerLabel);
            this.Controls.Add(this.payTextbox);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.startCalander);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Paychecks";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startCalander;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.RichTextBox payTextbox;
        private System.Windows.Forms.DateTimePicker endCalander;
        private System.Windows.Forms.Label dashLabel;
    }
}

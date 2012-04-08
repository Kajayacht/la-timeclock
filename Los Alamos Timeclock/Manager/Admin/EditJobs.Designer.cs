namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class EditJobs
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
            this.jobsBox = new System.Windows.Forms.ListBox();
            this.nlabel = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.jobnameTextbox = new System.Windows.Forms.TextBox();
            this.startingpayTextbox = new System.Windows.Forms.TextBox();
            this.updatejobButton = new System.Windows.Forms.Button();
            this.newjobButton = new System.Windows.Forms.Button();
            this.deletejobButton = new System.Windows.Forms.Button();
            this.tippedBox = new System.Windows.Forms.CheckBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.filenameTextbox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobsBox
            // 
            this.jobsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobsBox.FormattingEnabled = true;
            this.jobsBox.Location = new System.Drawing.Point(102, 127);
            this.jobsBox.Name = "jobsBox";
            this.jobsBox.Size = new System.Drawing.Size(120, 95);
            this.jobsBox.TabIndex = 0;
            this.jobsBox.SelectedIndexChanged += new System.EventHandler(this.jobsBox_SelectedIndexChanged);
            // 
            // nlabel
            // 
            this.nlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nlabel.AutoSize = true;
            this.nlabel.BackColor = System.Drawing.Color.Transparent;
            this.nlabel.ForeColor = System.Drawing.Color.White;
            this.nlabel.Location = new System.Drawing.Point(254, 130);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(58, 13);
            this.nlabel.TabIndex = 1;
            this.nlabel.Text = "Job Name:";
            // 
            // plabel
            // 
            this.plabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plabel.AutoSize = true;
            this.plabel.BackColor = System.Drawing.Color.Transparent;
            this.plabel.ForeColor = System.Drawing.Color.White;
            this.plabel.Location = new System.Drawing.Point(246, 156);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(67, 13);
            this.plabel.TabIndex = 2;
            this.plabel.Text = "Starting Pay:";
            // 
            // jobnameTextbox
            // 
            this.jobnameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobnameTextbox.Location = new System.Drawing.Point(319, 127);
            this.jobnameTextbox.Name = "jobnameTextbox";
            this.jobnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.jobnameTextbox.TabIndex = 3;
            // 
            // startingpayTextbox
            // 
            this.startingpayTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingpayTextbox.Location = new System.Drawing.Point(319, 153);
            this.startingpayTextbox.Name = "startingpayTextbox";
            this.startingpayTextbox.Size = new System.Drawing.Size(100, 20);
            this.startingpayTextbox.TabIndex = 4;
            // 
            // updatejobButton
            // 
            this.updatejobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatejobButton.Location = new System.Drawing.Point(156, 284);
            this.updatejobButton.Name = "updatejobButton";
            this.updatejobButton.Size = new System.Drawing.Size(75, 75);
            this.updatejobButton.TabIndex = 5;
            this.updatejobButton.Text = "Update";
            this.updatejobButton.UseVisualStyleBackColor = true;
            this.updatejobButton.Click += new System.EventHandler(this.updateJob_Click);
            // 
            // newjobButton
            // 
            this.newjobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newjobButton.Location = new System.Drawing.Point(237, 284);
            this.newjobButton.Name = "newjobButton";
            this.newjobButton.Size = new System.Drawing.Size(75, 75);
            this.newjobButton.TabIndex = 6;
            this.newjobButton.Text = "New";
            this.newjobButton.UseVisualStyleBackColor = true;
            this.newjobButton.Click += new System.EventHandler(this.newJob_Click);
            // 
            // deletejobButton
            // 
            this.deletejobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletejobButton.Location = new System.Drawing.Point(318, 284);
            this.deletejobButton.Name = "deletejobButton";
            this.deletejobButton.Size = new System.Drawing.Size(75, 75);
            this.deletejobButton.TabIndex = 7;
            this.deletejobButton.Text = "Delete";
            this.deletejobButton.UseVisualStyleBackColor = true;
            this.deletejobButton.Click += new System.EventHandler(this.deleteJob_Click);
            // 
            // tippedBox
            // 
            this.tippedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tippedBox.AutoSize = true;
            this.tippedBox.BackColor = System.Drawing.Color.Transparent;
            this.tippedBox.ForeColor = System.Drawing.Color.White;
            this.tippedBox.Location = new System.Drawing.Point(318, 179);
            this.tippedBox.Name = "tippedBox";
            this.tippedBox.Size = new System.Drawing.Size(79, 17);
            this.tippedBox.TabIndex = 8;
            this.tippedBox.Text = "Tipped Job";
            this.tippedBox.UseVisualStyleBackColor = false;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectImageButton.Location = new System.Drawing.Point(319, 228);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(101, 23);
            this.selectImageButton.TabIndex = 9;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // filenameTextbox
            // 
            this.filenameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenameTextbox.Location = new System.Drawing.Point(319, 202);
            this.filenameTextbox.Name = "filenameTextbox";
            this.filenameTextbox.ReadOnly = true;
            this.filenameTextbox.Size = new System.Drawing.Size(100, 20);
            this.filenameTextbox.TabIndex = 10;
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageLabel.AutoSize = true;
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.ForeColor = System.Drawing.Color.White;
            this.imageLabel.Location = new System.Drawing.Point(274, 205);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(39, 13);
            this.imageLabel.TabIndex = 11;
            this.imageLabel.Text = "Image:";
            // 
            // EditJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.filenameTextbox);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.tippedBox);
            this.Controls.Add(this.deletejobButton);
            this.Controls.Add(this.newjobButton);
            this.Controls.Add(this.updatejobButton);
            this.Controls.Add(this.startingpayTextbox);
            this.Controls.Add(this.jobnameTextbox);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.jobsBox);
            this.DoubleBuffered = true;
            this.Name = "EditJobs";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox jobsBox;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.TextBox jobnameTextbox;
        private System.Windows.Forms.TextBox startingpayTextbox;
        private System.Windows.Forms.Button updatejobButton;
        private System.Windows.Forms.Button newjobButton;
        private System.Windows.Forms.Button deletejobButton;
        private System.Windows.Forms.CheckBox tippedBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.TextBox filenameTextbox;
        private System.Windows.Forms.Label imageLabel;
    }
}

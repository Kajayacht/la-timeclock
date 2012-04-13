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
            System.Windows.Forms.Label nlabel;
            System.Windows.Forms.Label plabel;
            System.Windows.Forms.Label imageLabel;
            this.jobsBox = new System.Windows.Forms.ListBox();
            this.jobnameTextbox = new System.Windows.Forms.TextBox();
            this.startingpayTextbox = new System.Windows.Forms.TextBox();
            this.updatejobButton = new System.Windows.Forms.Button();
            this.newjobButton = new System.Windows.Forms.Button();
            this.deletejobButton = new System.Windows.Forms.Button();
            this.tippedBox = new System.Windows.Forms.CheckBox();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.filenameTextbox = new System.Windows.Forms.TextBox();
            this.jobPicturebox = new System.Windows.Forms.PictureBox();
            nlabel = new System.Windows.Forms.Label();
            plabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // nlabel
            // 
            nlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nlabel.AutoSize = true;
            nlabel.BackColor = System.Drawing.Color.Transparent;
            nlabel.ForeColor = System.Drawing.Color.White;
            nlabel.Location = new System.Drawing.Point(178, 86);
            nlabel.Name = "nlabel";
            nlabel.Size = new System.Drawing.Size(58, 13);
            nlabel.TabIndex = 1;
            nlabel.Text = "Job Name:";
            // 
            // plabel
            // 
            plabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            plabel.AutoSize = true;
            plabel.BackColor = System.Drawing.Color.Transparent;
            plabel.ForeColor = System.Drawing.Color.White;
            plabel.Location = new System.Drawing.Point(170, 112);
            plabel.Name = "plabel";
            plabel.Size = new System.Drawing.Size(67, 13);
            plabel.TabIndex = 2;
            plabel.Text = "Starting Pay:";
            // 
            // imageLabel
            // 
            imageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            imageLabel.AutoSize = true;
            imageLabel.BackColor = System.Drawing.Color.Transparent;
            imageLabel.ForeColor = System.Drawing.Color.White;
            imageLabel.Location = new System.Drawing.Point(198, 161);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 11;
            imageLabel.Text = "Image:";
            // 
            // jobsBox
            // 
            this.jobsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobsBox.FormattingEnabled = true;
            this.jobsBox.Location = new System.Drawing.Point(350, 83);
            this.jobsBox.Name = "jobsBox";
            this.jobsBox.Size = new System.Drawing.Size(136, 95);
            this.jobsBox.TabIndex = 0;
            this.jobsBox.SelectedIndexChanged += new System.EventHandler(this.jobsBox_SelectedIndexChanged);
            // 
            // jobnameTextbox
            // 
            this.jobnameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobnameTextbox.Location = new System.Drawing.Point(243, 83);
            this.jobnameTextbox.Name = "jobnameTextbox";
            this.jobnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.jobnameTextbox.TabIndex = 1;
            // 
            // startingpayTextbox
            // 
            this.startingpayTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingpayTextbox.Location = new System.Drawing.Point(243, 109);
            this.startingpayTextbox.Name = "startingpayTextbox";
            this.startingpayTextbox.Size = new System.Drawing.Size(100, 20);
            this.startingpayTextbox.TabIndex = 2;
            // 
            // updatejobButton
            // 
            this.updatejobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatejobButton.Location = new System.Drawing.Point(132, 286);
            this.updatejobButton.Name = "updatejobButton";
            this.updatejobButton.Size = new System.Drawing.Size(75, 75);
            this.updatejobButton.TabIndex = 6;
            this.updatejobButton.Text = "Update";
            this.updatejobButton.UseVisualStyleBackColor = true;
            this.updatejobButton.Click += new System.EventHandler(this.updateJob_Click);
            // 
            // newjobButton
            // 
            this.newjobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newjobButton.Location = new System.Drawing.Point(213, 286);
            this.newjobButton.Name = "newjobButton";
            this.newjobButton.Size = new System.Drawing.Size(75, 75);
            this.newjobButton.TabIndex = 7;
            this.newjobButton.Text = "New";
            this.newjobButton.UseVisualStyleBackColor = true;
            this.newjobButton.Click += new System.EventHandler(this.newJob_Click);
            // 
            // deletejobButton
            // 
            this.deletejobButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletejobButton.Location = new System.Drawing.Point(294, 286);
            this.deletejobButton.Name = "deletejobButton";
            this.deletejobButton.Size = new System.Drawing.Size(75, 75);
            this.deletejobButton.TabIndex = 8;
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
            this.tippedBox.Location = new System.Drawing.Point(242, 135);
            this.tippedBox.Name = "tippedBox";
            this.tippedBox.Size = new System.Drawing.Size(79, 17);
            this.tippedBox.TabIndex = 3;
            this.tippedBox.Text = "Tipped Job";
            this.tippedBox.UseVisualStyleBackColor = false;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectImageButton.Location = new System.Drawing.Point(243, 184);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(101, 23);
            this.selectImageButton.TabIndex = 5;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // filenameTextbox
            // 
            this.filenameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenameTextbox.Location = new System.Drawing.Point(243, 158);
            this.filenameTextbox.Name = "filenameTextbox";
            this.filenameTextbox.ReadOnly = true;
            this.filenameTextbox.Size = new System.Drawing.Size(100, 20);
            this.filenameTextbox.TabIndex = 4;
            // 
            // jobPicturebox
            // 
            this.jobPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobPicturebox.Location = new System.Drawing.Point(15, 83);
            this.jobPicturebox.Name = "jobPicturebox";
            this.jobPicturebox.Size = new System.Drawing.Size(150, 150);
            this.jobPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jobPicturebox.TabIndex = 12;
            this.jobPicturebox.TabStop = false;
            // 
            // EditJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.jobPicturebox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.filenameTextbox);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.tippedBox);
            this.Controls.Add(this.deletejobButton);
            this.Controls.Add(this.newjobButton);
            this.Controls.Add(this.updatejobButton);
            this.Controls.Add(this.startingpayTextbox);
            this.Controls.Add(this.jobnameTextbox);
            this.Controls.Add(plabel);
            this.Controls.Add(nlabel);
            this.Controls.Add(this.jobsBox);
            this.DoubleBuffered = true;
            this.Name = "EditJobs";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.jobPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox jobsBox;
        private System.Windows.Forms.TextBox jobnameTextbox;
        private System.Windows.Forms.TextBox startingpayTextbox;
        private System.Windows.Forms.Button updatejobButton;
        private System.Windows.Forms.Button newjobButton;
        private System.Windows.Forms.Button deletejobButton;
        private System.Windows.Forms.CheckBox tippedBox;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.TextBox filenameTextbox;
        private System.Windows.Forms.PictureBox jobPicturebox;
    }
}

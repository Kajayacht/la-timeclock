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
            this.jobs = new System.Windows.Forms.ListBox();
            this.nlabel = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.jname = new System.Windows.Forms.TextBox();
            this.jpay = new System.Windows.Forms.TextBox();
            this.Updatejob = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jobs
            // 
            this.jobs.FormattingEnabled = true;
            this.jobs.Location = new System.Drawing.Point(102, 127);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(120, 95);
            this.jobs.TabIndex = 0;
            this.jobs.SelectedIndexChanged += new System.EventHandler(this.jobs_SelectedIndexChanged);
            // 
            // nlabel
            // 
            this.nlabel.AutoSize = true;
            this.nlabel.BackColor = System.Drawing.Color.Transparent;
            this.nlabel.ForeColor = System.Drawing.Color.White;
            this.nlabel.Location = new System.Drawing.Point(254, 127);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(58, 13);
            this.nlabel.TabIndex = 1;
            this.nlabel.Text = "Job Name:";
            // 
            // plabel
            // 
            this.plabel.AutoSize = true;
            this.plabel.BackColor = System.Drawing.Color.Transparent;
            this.plabel.ForeColor = System.Drawing.Color.White;
            this.plabel.Location = new System.Drawing.Point(245, 153);
            this.plabel.Name = "plabel";
            this.plabel.Size = new System.Drawing.Size(67, 13);
            this.plabel.TabIndex = 2;
            this.plabel.Text = "Starting Pay:";
            // 
            // jname
            // 
            this.jname.Location = new System.Drawing.Point(319, 127);
            this.jname.Name = "jname";
            this.jname.Size = new System.Drawing.Size(100, 20);
            this.jname.TabIndex = 3;
            // 
            // jpay
            // 
            this.jpay.Location = new System.Drawing.Point(318, 150);
            this.jpay.Name = "jpay";
            this.jpay.Size = new System.Drawing.Size(100, 20);
            this.jpay.TabIndex = 4;
            // 
            // Updatejob
            // 
            this.Updatejob.Location = new System.Drawing.Point(156, 284);
            this.Updatejob.Name = "Updatejob";
            this.Updatejob.Size = new System.Drawing.Size(75, 75);
            this.Updatejob.TabIndex = 5;
            this.Updatejob.Text = "Update";
            this.Updatejob.UseVisualStyleBackColor = true;
            this.Updatejob.Click += new System.EventHandler(this.Updatejob_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(237, 284);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 75);
            this.New.TabIndex = 6;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(318, 284);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 75);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Updatejob);
            this.Controls.Add(this.jpay);
            this.Controls.Add(this.jname);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.jobs);
            this.Name = "EditJobs";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox jobs;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.TextBox jname;
        private System.Windows.Forms.TextBox jpay;
        private System.Windows.Forms.Button Updatejob;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delete;
    }
}

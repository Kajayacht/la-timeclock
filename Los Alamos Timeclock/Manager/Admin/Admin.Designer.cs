namespace Los_Alamos_Timeclock
{
    partial class Admin
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
            this.editemployees = new System.Windows.Forms.Button();
            this.Editschedule = new System.Windows.Forms.Button();
            this.viewlog = new System.Windows.Forms.Button();
            this.calculatepay = new System.Windows.Forms.Button();
            this.editjobs = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editemployees
            // 
            this.editemployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editemployees.Location = new System.Drawing.Point(117, 105);
            this.editemployees.Name = "editemployees";
            this.editemployees.Size = new System.Drawing.Size(75, 75);
            this.editemployees.TabIndex = 0;
            this.editemployees.Text = "Edit Employees";
            this.editemployees.UseVisualStyleBackColor = true;
            this.editemployees.Click += new System.EventHandler(this.editemployees_Click);
            // 
            // Editschedule
            // 
            this.Editschedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Editschedule.Location = new System.Drawing.Point(198, 105);
            this.Editschedule.Name = "Editschedule";
            this.Editschedule.Size = new System.Drawing.Size(75, 75);
            this.Editschedule.TabIndex = 1;
            this.Editschedule.Text = "Edit Schedule";
            this.Editschedule.UseVisualStyleBackColor = true;
            this.Editschedule.Click += new System.EventHandler(this.Editschedule_Click);
            // 
            // viewlog
            // 
            this.viewlog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewlog.Location = new System.Drawing.Point(198, 186);
            this.viewlog.Name = "viewlog";
            this.viewlog.Size = new System.Drawing.Size(75, 75);
            this.viewlog.TabIndex = 2;
            this.viewlog.Text = "View Log";
            this.viewlog.UseVisualStyleBackColor = true;
            // 
            // calculatepay
            // 
            this.calculatepay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatepay.Location = new System.Drawing.Point(117, 186);
            this.calculatepay.Name = "calculatepay";
            this.calculatepay.Size = new System.Drawing.Size(75, 75);
            this.calculatepay.TabIndex = 3;
            this.calculatepay.Text = "Calculate Paychecks";
            this.calculatepay.UseVisualStyleBackColor = true;
            this.calculatepay.Click += new System.EventHandler(this.button1_Click);
            // 
            // editjobs
            // 
            this.editjobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editjobs.Location = new System.Drawing.Point(279, 186);
            this.editjobs.Name = "editjobs";
            this.editjobs.Size = new System.Drawing.Size(75, 75);
            this.editjobs.TabIndex = 4;
            this.editjobs.Text = "Edit Jobs";
            this.editjobs.UseVisualStyleBackColor = true;
            this.editjobs.Click += new System.EventHandler(this.editjobs_Click);
            // 
            // config
            // 
            this.config.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.config.Location = new System.Drawing.Point(279, 105);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(75, 75);
            this.config.TabIndex = 5;
            this.config.Text = "Settings";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.config);
            this.Controls.Add(this.editjobs);
            this.Controls.Add(this.calculatepay);
            this.Controls.Add(this.viewlog);
            this.Controls.Add(this.Editschedule);
            this.Controls.Add(this.editemployees);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editemployees;
        private System.Windows.Forms.Button Editschedule;
        private System.Windows.Forms.Button viewlog;
        private System.Windows.Forms.Button calculatepay;
        private System.Windows.Forms.Button editjobs;
        private System.Windows.Forms.Button config;
    }
}

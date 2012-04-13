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
            this.editemployeesButton = new System.Windows.Forms.Button();
            this.editscheduleButton = new System.Windows.Forms.Button();
            this.viewlogButton = new System.Windows.Forms.Button();
            this.calculatepayButton = new System.Windows.Forms.Button();
            this.editjobsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.employeenotesButton = new System.Windows.Forms.Button();
            this.phonebookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editemployeesButton
            // 
            this.editemployeesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editemployeesButton.Location = new System.Drawing.Point(213, 163);
            this.editemployeesButton.Name = "editemployeesButton";
            this.editemployeesButton.Size = new System.Drawing.Size(75, 75);
            this.editemployeesButton.TabIndex = 5;
            this.editemployeesButton.Text = "Edit Employees";
            this.editemployeesButton.UseVisualStyleBackColor = true;
            this.editemployeesButton.Click += new System.EventHandler(this.editemployees_Click);
            // 
            // editscheduleButton
            // 
            this.editscheduleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editscheduleButton.Location = new System.Drawing.Point(213, 82);
            this.editscheduleButton.Name = "editscheduleButton";
            this.editscheduleButton.Size = new System.Drawing.Size(75, 75);
            this.editscheduleButton.TabIndex = 2;
            this.editscheduleButton.Text = "Edit Schedule";
            this.editscheduleButton.UseVisualStyleBackColor = true;
            this.editscheduleButton.Click += new System.EventHandler(this.editschedule_Click);
            // 
            // viewlogButton
            // 
            this.viewlogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewlogButton.Location = new System.Drawing.Point(213, 244);
            this.viewlogButton.Name = "viewlogButton";
            this.viewlogButton.Size = new System.Drawing.Size(75, 75);
            this.viewlogButton.TabIndex = 8;
            this.viewlogButton.Text = "View Log";
            this.viewlogButton.UseVisualStyleBackColor = true;
            this.viewlogButton.Click += new System.EventHandler(this.viewlog_Click);
            // 
            // calculatepayButton
            // 
            this.calculatepayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatepayButton.Location = new System.Drawing.Point(132, 244);
            this.calculatepayButton.Name = "calculatepayButton";
            this.calculatepayButton.Size = new System.Drawing.Size(75, 75);
            this.calculatepayButton.TabIndex = 7;
            this.calculatepayButton.Text = "Calculate Paychecks";
            this.calculatepayButton.UseVisualStyleBackColor = true;
            this.calculatepayButton.Click += new System.EventHandler(this.paychecks_Click);
            // 
            // editjobsButton
            // 
            this.editjobsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editjobsButton.Location = new System.Drawing.Point(294, 163);
            this.editjobsButton.Name = "editjobsButton";
            this.editjobsButton.Size = new System.Drawing.Size(75, 75);
            this.editjobsButton.TabIndex = 6;
            this.editjobsButton.Text = "Edit Jobs";
            this.editjobsButton.UseVisualStyleBackColor = true;
            this.editjobsButton.Click += new System.EventHandler(this.editjobs_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.Location = new System.Drawing.Point(294, 244);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 75);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // statusButton
            // 
            this.statusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusButton.Location = new System.Drawing.Point(132, 82);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(75, 75);
            this.statusButton.TabIndex = 1;
            this.statusButton.Text = "Status";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.status_Click);
            // 
            // employeenotesButton
            // 
            this.employeenotesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeenotesButton.Location = new System.Drawing.Point(294, 82);
            this.employeenotesButton.Name = "employeenotesButton";
            this.employeenotesButton.Size = new System.Drawing.Size(75, 75);
            this.employeenotesButton.TabIndex = 3;
            this.employeenotesButton.Text = "Employee Notes";
            this.employeenotesButton.UseVisualStyleBackColor = true;
            this.employeenotesButton.Click += new System.EventHandler(this.employeenotes_Click);
            // 
            // phonebookButton
            // 
            this.phonebookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phonebookButton.Location = new System.Drawing.Point(132, 163);
            this.phonebookButton.Name = "phonebookButton";
            this.phonebookButton.Size = new System.Drawing.Size(75, 75);
            this.phonebookButton.TabIndex = 4;
            this.phonebookButton.Text = "Phone Book";
            this.phonebookButton.UseVisualStyleBackColor = true;
            this.phonebookButton.Click += new System.EventHandler(this.phonebook_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.phonebookButton);
            this.Controls.Add(this.employeenotesButton);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.editjobsButton);
            this.Controls.Add(this.calculatepayButton);
            this.Controls.Add(this.viewlogButton);
            this.Controls.Add(this.editscheduleButton);
            this.Controls.Add(this.editemployeesButton);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editemployeesButton;
        private System.Windows.Forms.Button editscheduleButton;
        private System.Windows.Forms.Button viewlogButton;
        private System.Windows.Forms.Button calculatepayButton;
        private System.Windows.Forms.Button editjobsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button employeenotesButton;
        private System.Windows.Forms.Button phonebookButton;
    }
}

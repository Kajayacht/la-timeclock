namespace Los_Alamos_Timeclock.UI
{
    partial class Cleanup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label deleteLabel;
            System.Windows.Forms.Label beforeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleanup));
            this.employeesCheckbox = new System.Windows.Forms.CheckBox();
            this.schedulecheckBox = new System.Windows.Forms.CheckBox();
            this.hoursWorkedCheckbox = new System.Windows.Forms.CheckBox();
            this.requestsCheckbox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.beforeCalander = new System.Windows.Forms.DateTimePicker();
            deleteLabel = new System.Windows.Forms.Label();
            beforeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeesCheckbox
            // 
            this.employeesCheckbox.AutoSize = true;
            this.employeesCheckbox.Location = new System.Drawing.Point(70, 90);
            this.employeesCheckbox.Name = "employeesCheckbox";
            this.employeesCheckbox.Size = new System.Drawing.Size(77, 17);
            this.employeesCheckbox.TabIndex = 3;
            this.employeesCheckbox.Text = "Employees";
            this.employeesCheckbox.UseVisualStyleBackColor = true;
            this.employeesCheckbox.CheckedChanged += new System.EventHandler(this.employeesCheckbox_CheckedChanged);
            // 
            // schedulecheckBox
            // 
            this.schedulecheckBox.AutoSize = true;
            this.schedulecheckBox.Location = new System.Drawing.Point(70, 44);
            this.schedulecheckBox.Name = "schedulecheckBox";
            this.schedulecheckBox.Size = new System.Drawing.Size(71, 17);
            this.schedulecheckBox.TabIndex = 1;
            this.schedulecheckBox.Text = "Schedule";
            this.schedulecheckBox.UseVisualStyleBackColor = true;
            // 
            // hoursWorkedCheckbox
            // 
            this.hoursWorkedCheckbox.AutoSize = true;
            this.hoursWorkedCheckbox.Location = new System.Drawing.Point(70, 67);
            this.hoursWorkedCheckbox.Name = "hoursWorkedCheckbox";
            this.hoursWorkedCheckbox.Size = new System.Drawing.Size(95, 17);
            this.hoursWorkedCheckbox.TabIndex = 2;
            this.hoursWorkedCheckbox.Text = "Hours Worked";
            this.hoursWorkedCheckbox.UseVisualStyleBackColor = true;
            // 
            // requestsCheckbox
            // 
            this.requestsCheckbox.AutoSize = true;
            this.requestsCheckbox.Location = new System.Drawing.Point(70, 21);
            this.requestsCheckbox.Name = "requestsCheckbox";
            this.requestsCheckbox.Size = new System.Drawing.Size(71, 17);
            this.requestsCheckbox.TabIndex = 0;
            this.requestsCheckbox.Text = "Requests";
            this.requestsCheckbox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(339, 84);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(258, 84);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // deleteLabel
            // 
            deleteLabel.AutoSize = true;
            deleteLabel.Location = new System.Drawing.Point(23, 21);
            deleteLabel.Name = "deleteLabel";
            deleteLabel.Size = new System.Drawing.Size(41, 13);
            deleteLabel.TabIndex = 8;
            deleteLabel.Text = "Delete:";
            // 
            // beforeLabel
            // 
            beforeLabel.AutoSize = true;
            beforeLabel.Location = new System.Drawing.Point(167, 21);
            beforeLabel.Name = "beforeLabel";
            beforeLabel.Size = new System.Drawing.Size(41, 13);
            beforeLabel.TabIndex = 9;
            beforeLabel.Text = "Before:";
            // 
            // beforeCalander
            // 
            this.beforeCalander.Location = new System.Drawing.Point(214, 18);
            this.beforeCalander.Name = "beforeCalander";
            this.beforeCalander.Size = new System.Drawing.Size(200, 20);
            this.beforeCalander.TabIndex = 10;
            // 
            // Cleanup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 124);
            this.Controls.Add(this.beforeCalander);
            this.Controls.Add(beforeLabel);
            this.Controls.Add(deleteLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.requestsCheckbox);
            this.Controls.Add(this.hoursWorkedCheckbox);
            this.Controls.Add(this.schedulecheckBox);
            this.Controls.Add(this.employeesCheckbox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(453, 162);
            this.Name = "Cleanup";
            this.Text = "Cleanup Entries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox employeesCheckbox;
        private System.Windows.Forms.CheckBox schedulecheckBox;
        private System.Windows.Forms.CheckBox hoursWorkedCheckbox;
        private System.Windows.Forms.CheckBox requestsCheckbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker beforeCalander;


    }
}
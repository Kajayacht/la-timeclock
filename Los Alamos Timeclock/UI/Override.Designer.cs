namespace Los_Alamos_Timeclock
{
    partial class Override
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
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label label4;
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.jobsBox = new System.Windows.Forms.ListBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.passTextbox = new System.Windows.Forms.TextBox();
            jobLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(71, 102);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(152, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // jobsBox
            // 
            this.jobsBox.FormattingEnabled = true;
            this.jobsBox.Location = new System.Drawing.Point(234, 30);
            this.jobsBox.Name = "jobsBox";
            this.jobsBox.Size = new System.Drawing.Size(101, 95);
            this.jobsBox.Sorted = true;
            this.jobsBox.TabIndex = 2;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(231, 9);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(27, 13);
            jobLabel.TabIndex = 3;
            jobLabel.Text = "Job:";
            // 
            // userTextbox
            // 
            this.userTextbox.Location = new System.Drawing.Point(71, 30);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(157, 20);
            this.userTextbox.TabIndex = 0;
            // 
            // passTextbox
            // 
            this.passTextbox.Location = new System.Drawing.Point(71, 56);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '*';
            this.passTextbox.Size = new System.Drawing.Size(157, 20);
            this.passTextbox.TabIndex = 1;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(30, 30);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(35, 13);
            userLabel.TabIndex = 6;
            userLabel.Text = "User: ";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(6, 56);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(59, 13);
            passLabel.TabIndex = 7;
            passLabel.Text = "Password: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(97, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(106, 13);
            label4.TabIndex = 8;
            label4.Text = "Enter Manager Login";
            // 
            // Override
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 149);
            this.Controls.Add(label4);
            this.Controls.Add(passLabel);
            this.Controls.Add(userLabel);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.jobsBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MinimumSize = new System.Drawing.Size(364, 187);
            this.Name = "Override";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Override";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox jobsBox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.TextBox passTextbox;
    }
}
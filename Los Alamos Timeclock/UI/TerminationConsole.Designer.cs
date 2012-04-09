namespace Los_Alamos_Timeclock.UI
{
    partial class TerminationConsole
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
            this.lastDayCalander = new System.Windows.Forms.DateTimePicker();
            this.commentsTextbox = new System.Windows.Forms.RichTextBox();
            this.lastDayLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.terminateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reasonDropdownlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removePrivCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lastDayCalander
            // 
            this.lastDayCalander.Location = new System.Drawing.Point(78, 9);
            this.lastDayCalander.Name = "lastDayCalander";
            this.lastDayCalander.Size = new System.Drawing.Size(200, 20);
            this.lastDayCalander.TabIndex = 0;
            // 
            // commentsTextbox
            // 
            this.commentsTextbox.Location = new System.Drawing.Point(78, 86);
            this.commentsTextbox.Name = "commentsTextbox";
            this.commentsTextbox.Size = new System.Drawing.Size(200, 64);
            this.commentsTextbox.TabIndex = 3;
            this.commentsTextbox.Text = "";
            // 
            // lastDayLabel
            // 
            this.lastDayLabel.AutoSize = true;
            this.lastDayLabel.Location = new System.Drawing.Point(12, 9);
            this.lastDayLabel.Name = "lastDayLabel";
            this.lastDayLabel.Size = new System.Drawing.Size(52, 13);
            this.lastDayLabel.TabIndex = 2;
            this.lastDayLabel.Text = "Last Day:";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(11, 35);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(47, 13);
            this.reasonLabel.TabIndex = 3;
            this.reasonLabel.Text = "Reason:";
            // 
            // terminateButton
            // 
            this.terminateButton.Location = new System.Drawing.Point(78, 156);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(97, 23);
            this.terminateButton.TabIndex = 4;
            this.terminateButton.Text = "Terminate";
            this.terminateButton.UseVisualStyleBackColor = true;
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(181, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reasonDropdownlist
            // 
            this.reasonDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonDropdownlist.FormattingEnabled = true;
            this.reasonDropdownlist.Items.AddRange(new object[] {
            "Quit",
            "Terminated"});
            this.reasonDropdownlist.Location = new System.Drawing.Point(78, 36);
            this.reasonDropdownlist.Name = "reasonDropdownlist";
            this.reasonDropdownlist.Size = new System.Drawing.Size(200, 21);
            this.reasonDropdownlist.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comments:";
            // 
            // removePrivCheckbox
            // 
            this.removePrivCheckbox.AutoSize = true;
            this.removePrivCheckbox.Location = new System.Drawing.Point(78, 63);
            this.removePrivCheckbox.Name = "removePrivCheckbox";
            this.removePrivCheckbox.Size = new System.Drawing.Size(193, 17);
            this.removePrivCheckbox.TabIndex = 2;
            this.removePrivCheckbox.Text = "Remove Admin/Manager Privileges";
            this.removePrivCheckbox.UseVisualStyleBackColor = true;
            // 
            // TerminationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 188);
            this.Controls.Add(this.removePrivCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonDropdownlist);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.terminateButton);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.lastDayLabel);
            this.Controls.Add(this.commentsTextbox);
            this.Controls.Add(this.lastDayCalander);
            this.MinimumSize = new System.Drawing.Size(314, 226);
            this.Name = "TerminationConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminate Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker lastDayCalander;
        private System.Windows.Forms.RichTextBox commentsTextbox;
        private System.Windows.Forms.Label lastDayLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox reasonDropdownlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox removePrivCheckbox;
    }
}
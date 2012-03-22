namespace Los_Alamos_Timeclock.Manager
{
    partial class Phonebook
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
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.White;
            this.employeeLabel.Location = new System.Drawing.Point(56, 140);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(92, 20);
            this.employeeLabel.TabIndex = 7;
            this.employeeLabel.Text = "Employee:";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(154, 137);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 28);
            this.employeeDropdownlist.TabIndex = 6;
            this.employeeDropdownlist.TabStop = false;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(187, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 20);
            this.titleLabel.TabIndex = 59;
            this.titleLabel.Text = "Phonebook";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.Location = new System.Drawing.Point(83, 189);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(0, 20);
            this.phoneNumber.TabIndex = 61;
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.DoubleBuffered = true;
            this.Name = "Phonebook";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label phoneNumber;

    }
}

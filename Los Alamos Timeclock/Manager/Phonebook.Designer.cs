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
            System.Windows.Forms.Label employeeLabel;
            System.Windows.Forms.Label titleLabel;
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            employeeLabel.AutoSize = true;
            employeeLabel.BackColor = System.Drawing.Color.Transparent;
            employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeLabel.ForeColor = System.Drawing.Color.White;
            employeeLabel.Location = new System.Drawing.Point(106, 168);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(92, 20);
            employeeLabel.TabIndex = 7;
            employeeLabel.Text = "Employee:";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(201, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(99, 20);
            titleLabel.TabIndex = 59;
            titleLabel.Text = "Phonebook";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(204, 165);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 28);
            this.employeeDropdownlist.TabIndex = 0;
            this.employeeDropdownlist.TabStop = false;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.Location = new System.Drawing.Point(106, 215);
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
            this.Controls.Add(titleLabel);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.DoubleBuffered = true;
            this.Name = "Phonebook";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.Label phoneNumber;

    }
}

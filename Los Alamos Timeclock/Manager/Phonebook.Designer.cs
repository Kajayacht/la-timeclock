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
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.PictureBox pictureBox1;
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox2.Location = new System.Drawing.Point(0, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(145, 185);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox1.Location = new System.Drawing.Point(355, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(145, 185);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(titleLabel);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.DoubleBuffered = true;
            this.Name = "Phonebook";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.Label phoneNumber;

    }
}

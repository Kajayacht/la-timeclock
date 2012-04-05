namespace Los_Alamos_Timeclock
{
    partial class Contactinfo
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
            this.Al1 = new System.Windows.Forms.TextBox();
            this.line1Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.Al2 = new System.Windows.Forms.TextBox();
            this.line2Label = new System.Windows.Forms.Label();
            this.Az = new System.Windows.Forms.MaskedTextBox();
            this.As = new System.Windows.Forms.ComboBox();
            this.Ac = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Al1
            // 
            this.Al1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Al1.Location = new System.Drawing.Point(98, 93);
            this.Al1.Name = "Al1";
            this.Al1.Size = new System.Drawing.Size(361, 20);
            this.Al1.TabIndex = 5;
            // 
            // line1Label
            // 
            this.line1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1Label.AutoSize = true;
            this.line1Label.BackColor = System.Drawing.Color.Transparent;
            this.line1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Label.ForeColor = System.Drawing.Color.White;
            this.line1Label.Location = new System.Drawing.Point(24, 90);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(72, 20);
            this.line1Label.TabIndex = 4;
            this.line1Label.Text = "Address:";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(157, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(217, 25);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Contact Information";
            // 
            // Al2
            // 
            this.Al2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Al2.Location = new System.Drawing.Point(98, 128);
            this.Al2.Name = "Al2";
            this.Al2.Size = new System.Drawing.Size(361, 20);
            this.Al2.TabIndex = 7;
            // 
            // line2Label
            // 
            this.line2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line2Label.AutoSize = true;
            this.line2Label.BackColor = System.Drawing.Color.Transparent;
            this.line2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Label.ForeColor = System.Drawing.Color.White;
            this.line2Label.Location = new System.Drawing.Point(24, 116);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(68, 40);
            this.line2Label.TabIndex = 6;
            this.line2Label.Text = "Address\r\nLine 2:";
            // 
            // Az
            // 
            this.Az.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Az.Location = new System.Drawing.Point(98, 211);
            this.Az.Mask = "00000";
            this.Az.Name = "Az";
            this.Az.Size = new System.Drawing.Size(361, 20);
            this.Az.TabIndex = 40;
            // 
            // As
            // 
            this.As.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.As.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.As.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.As.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.As.FormattingEnabled = true;
            this.As.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District of Columbia",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.As.Location = new System.Drawing.Point(98, 185);
            this.As.Name = "As";
            this.As.Size = new System.Drawing.Size(361, 21);
            this.As.TabIndex = 39;
            // 
            // Ac
            // 
            this.Ac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ac.Location = new System.Drawing.Point(98, 159);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(361, 20);
            this.Ac.TabIndex = 38;
            // 
            // zipLabel
            // 
            this.zipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zipLabel.AutoSize = true;
            this.zipLabel.BackColor = System.Drawing.Color.Transparent;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.Color.White;
            this.zipLabel.Location = new System.Drawing.Point(15, 211);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(3);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(77, 20);
            this.zipLabel.TabIndex = 43;
            this.zipLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateLabel.AutoSize = true;
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.White;
            this.stateLabel.Location = new System.Drawing.Point(40, 185);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(52, 20);
            this.stateLabel.TabIndex = 42;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(53, 159);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 20);
            this.cityLabel.TabIndex = 41;
            this.cityLabel.Text = "City:";
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone.Location = new System.Drawing.Point(99, 259);
            this.Phone.Mask = "(999) 000-0000";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(360, 20);
            this.Phone.TabIndex = 67;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.Location = new System.Drawing.Point(98, 285);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(361, 20);
            this.Email.TabIndex = 68;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(40, 285);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(3);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 70;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(37, 259);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 20);
            this.phoneLabel.TabIndex = 69;
            this.phoneLabel.Text = "Phone";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Location = new System.Drawing.Point(384, 311);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 75);
            this.updateButton.TabIndex = 71;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // Contactinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.Az);
            this.Controls.Add(this.As);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.Al2);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.Al1);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Contactinfo";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Al1;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox Al2;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.MaskedTextBox Az;
        private System.Windows.Forms.ComboBox As;
        private System.Windows.Forms.TextBox Ac;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button updateButton;
    }
}

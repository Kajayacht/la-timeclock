using System.Windows.Forms;
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
            System.Windows.Forms.Label line1Label;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label line2Label;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            this.Al1 = new System.Windows.Forms.TextBox();
            this.Al2 = new System.Windows.Forms.TextBox();
            this.Az = new System.Windows.Forms.MaskedTextBox();
            this.As = new System.Windows.Forms.ComboBox();
            this.Ac = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            line1Label = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            line2Label = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Al1
            // 
            this.Al1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Al1.Location = new System.Drawing.Point(98, 93);
            this.Al1.Name = "Al1";
            this.Al1.Size = new System.Drawing.Size(361, 20);
            this.Al1.TabIndex = 0;
            // 
            // line1Label
            // 
            line1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            line1Label.AutoSize = true;
            line1Label.BackColor = System.Drawing.Color.Transparent;
            line1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            line1Label.ForeColor = System.Drawing.Color.White;
            line1Label.Location = new System.Drawing.Point(24, 90);
            line1Label.Name = "line1Label";
            line1Label.Size = new System.Drawing.Size(72, 20);
            line1Label.TabIndex = 4;
            line1Label.Text = "Address:";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(157, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(217, 25);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Contact Information";
            // 
            // Al2
            // 
            this.Al2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Al2.Location = new System.Drawing.Point(98, 128);
            this.Al2.Name = "Al2";
            this.Al2.Size = new System.Drawing.Size(361, 20);
            this.Al2.TabIndex = 1;
            // 
            // line2Label
            // 
            line2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            line2Label.AutoSize = true;
            line2Label.BackColor = System.Drawing.Color.Transparent;
            line2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            line2Label.ForeColor = System.Drawing.Color.White;
            line2Label.Location = new System.Drawing.Point(24, 116);
            line2Label.Name = "line2Label";
            line2Label.Size = new System.Drawing.Size(68, 40);
            line2Label.TabIndex = 6;
            line2Label.Text = "Address\r\nLine 2:";
            // 
            // Az
            // 
            this.Az.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Az.Location = new System.Drawing.Point(98, 211);
            this.Az.Mask = "00000";
            this.Az.Name = "Az";
            this.Az.Size = new System.Drawing.Size(361, 20);
            this.Az.TabIndex = 4;
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
            this.As.TabIndex = 3;
            // 
            // Ac
            // 
            this.Ac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ac.Location = new System.Drawing.Point(98, 159);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(361, 20);
            this.Ac.TabIndex = 2;
            // 
            // zipLabel
            // 
            zipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            zipLabel.AutoSize = true;
            zipLabel.BackColor = System.Drawing.Color.Transparent;
            zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipLabel.ForeColor = System.Drawing.Color.White;
            zipLabel.Location = new System.Drawing.Point(15, 211);
            zipLabel.Margin = new System.Windows.Forms.Padding(3);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(77, 20);
            zipLabel.TabIndex = 43;
            zipLabel.Text = "Zip Code:";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            stateLabel.AutoSize = true;
            stateLabel.BackColor = System.Drawing.Color.Transparent;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.ForeColor = System.Drawing.Color.White;
            stateLabel.Location = new System.Drawing.Point(40, 185);
            stateLabel.Margin = new System.Windows.Forms.Padding(3);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(52, 20);
            stateLabel.TabIndex = 42;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.Color.Transparent;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ForeColor = System.Drawing.Color.White;
            cityLabel.Location = new System.Drawing.Point(53, 159);
            cityLabel.Margin = new System.Windows.Forms.Padding(3);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 41;
            cityLabel.Text = "City:";
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone.Location = new System.Drawing.Point(99, 259);
            this.Phone.Mask = "(999) 000-0000";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(360, 20);
            this.Phone.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.Location = new System.Drawing.Point(98, 285);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(361, 20);
            this.Email.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(40, 285);
            emailLabel.Margin = new System.Windows.Forms.Padding(3);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 70;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Transparent;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.White;
            phoneLabel.Location = new System.Drawing.Point(37, 259);
            phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 20);
            phoneLabel.TabIndex = 69;
            phoneLabel.Text = "Phone";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.Location = new System.Drawing.Point(384, 311);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 75);
            this.updateButton.TabIndex = 7;
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
            this.Controls.Add(emailLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.Az);
            this.Controls.Add(this.As);
            this.Controls.Add(this.Ac);
            this.Controls.Add(zipLabel);
            this.Controls.Add(stateLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.Al2);
            this.Controls.Add(line2Label);
            this.Controls.Add(this.Al1);
            this.Controls.Add(line1Label);
            this.Controls.Add(titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Contactinfo";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Al1;
        private System.Windows.Forms.TextBox Al2;
        private System.Windows.Forms.MaskedTextBox Az;
        private System.Windows.Forms.ComboBox As;
        private System.Windows.Forms.TextBox Ac;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button updateButton;
    }
}

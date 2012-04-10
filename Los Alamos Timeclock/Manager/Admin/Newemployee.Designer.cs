using System.Windows.Forms;
namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class Newemployee
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label aLine2Label;
            System.Windows.Forms.Label aLine1Label;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label aStateLabel;
            System.Windows.Forms.Label aCityLabel;
            System.Windows.Forms.Label aZipLabel;
            System.Windows.Forms.Label mNameLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label pass2Label;
            System.Windows.Forms.Label pass1Label;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label contactLabel;
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.mNameTextbox = new System.Windows.Forms.TextBox();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.aCityTextbox = new System.Windows.Forms.TextBox();
            this.aLine2Textbox = new System.Windows.Forms.TextBox();
            this.aLine1Textbox = new System.Windows.Forms.TextBox();
            this.aStateDropdownlist = new System.Windows.Forms.ComboBox();
            this.pass2Textbox = new System.Windows.Forms.TextBox();
            this.pass1Textbox = new System.Windows.Forms.TextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.ssnTextbox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextbox = new System.Windows.Forms.MaskedTextBox();
            this.aZipTextbox = new System.Windows.Forms.MaskedTextBox();
            titleLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            aLine2Label = new System.Windows.Forms.Label();
            aLine1Label = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            aStateLabel = new System.Windows.Forms.Label();
            aCityLabel = new System.Windows.Forms.Label();
            aZipLabel = new System.Windows.Forms.Label();
            mNameLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            pass2Label = new System.Windows.Forms.Label();
            pass1Label = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(146, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(190, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "New Employee";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(29, 72);
            nameLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // fNameLabel
            // 
            fNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fNameLabel.AutoSize = true;
            fNameLabel.BackColor = System.Drawing.Color.Transparent;
            fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fNameLabel.ForeColor = System.Drawing.Color.White;
            fNameLabel.Location = new System.Drawing.Point(57, 103);
            fNameLabel.Margin = new System.Windows.Forms.Padding(3);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(44, 20);
            fNameLabel.TabIndex = 2;
            fNameLabel.Text = "First:";
            // 
            // lNameLabel
            // 
            lNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lNameLabel.AutoSize = true;
            lNameLabel.BackColor = System.Drawing.Color.Transparent;
            lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lNameLabel.ForeColor = System.Drawing.Color.White;
            lNameLabel.Location = new System.Drawing.Point(57, 155);
            lNameLabel.Margin = new System.Windows.Forms.Padding(3);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(44, 20);
            lNameLabel.TabIndex = 3;
            lNameLabel.Text = "Last:";
            // 
            // aLine2Label
            // 
            aLine2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aLine2Label.AutoSize = true;
            aLine2Label.BackColor = System.Drawing.Color.Transparent;
            aLine2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aLine2Label.ForeColor = System.Drawing.Color.White;
            aLine2Label.Location = new System.Drawing.Point(45, 271);
            aLine2Label.Margin = new System.Windows.Forms.Padding(3);
            aLine2Label.Name = "aLine2Label";
            aLine2Label.Size = new System.Drawing.Size(56, 20);
            aLine2Label.TabIndex = 6;
            aLine2Label.Text = "Line 2:";
            // 
            // aLine1Label
            // 
            aLine1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aLine1Label.AutoSize = true;
            aLine1Label.BackColor = System.Drawing.Color.Transparent;
            aLine1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aLine1Label.ForeColor = System.Drawing.Color.White;
            aLine1Label.Location = new System.Drawing.Point(45, 245);
            aLine1Label.Margin = new System.Windows.Forms.Padding(3);
            aLine1Label.Name = "aLine1Label";
            aLine1Label.Size = new System.Drawing.Size(56, 20);
            aLine1Label.TabIndex = 5;
            aLine1Label.Text = "Line 1:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(3, 214);
            addressLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(98, 25);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address";
            // 
            // aStateLabel
            // 
            aStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aStateLabel.AutoSize = true;
            aStateLabel.BackColor = System.Drawing.Color.Transparent;
            aStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aStateLabel.ForeColor = System.Drawing.Color.White;
            aStateLabel.Location = new System.Drawing.Point(49, 323);
            aStateLabel.Margin = new System.Windows.Forms.Padding(3);
            aStateLabel.Name = "aStateLabel";
            aStateLabel.Size = new System.Drawing.Size(52, 20);
            aStateLabel.TabIndex = 8;
            aStateLabel.Text = "State:";
            // 
            // aCityLabel
            // 
            aCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aCityLabel.AutoSize = true;
            aCityLabel.BackColor = System.Drawing.Color.Transparent;
            aCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aCityLabel.ForeColor = System.Drawing.Color.White;
            aCityLabel.Location = new System.Drawing.Point(62, 297);
            aCityLabel.Margin = new System.Windows.Forms.Padding(3);
            aCityLabel.Name = "aCityLabel";
            aCityLabel.Size = new System.Drawing.Size(39, 20);
            aCityLabel.TabIndex = 7;
            aCityLabel.Text = "City:";
            // 
            // aZipLabel
            // 
            aZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aZipLabel.AutoSize = true;
            aZipLabel.BackColor = System.Drawing.Color.Transparent;
            aZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aZipLabel.ForeColor = System.Drawing.Color.White;
            aZipLabel.Location = new System.Drawing.Point(24, 349);
            aZipLabel.Margin = new System.Windows.Forms.Padding(3);
            aZipLabel.Name = "aZipLabel";
            aZipLabel.Size = new System.Drawing.Size(77, 20);
            aZipLabel.TabIndex = 9;
            aZipLabel.Text = "Zip Code:";
            // 
            // mNameLabel
            // 
            mNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            mNameLabel.AutoSize = true;
            mNameLabel.BackColor = System.Drawing.Color.Transparent;
            mNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mNameLabel.ForeColor = System.Drawing.Color.White;
            mNameLabel.Location = new System.Drawing.Point(42, 129);
            mNameLabel.Margin = new System.Windows.Forms.Padding(3);
            mNameLabel.Name = "mNameLabel";
            mNameLabel.Size = new System.Drawing.Size(59, 20);
            mNameLabel.TabIndex = 10;
            mNameLabel.Text = "Middle:";
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fNameTextbox.Location = new System.Drawing.Point(107, 103);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.fNameTextbox.TabIndex = 0;
            // 
            // mNameTextbox
            // 
            this.mNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mNameTextbox.Location = new System.Drawing.Point(107, 129);
            this.mNameTextbox.Name = "mNameTextbox";
            this.mNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.mNameTextbox.TabIndex = 1;
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNameTextbox.Location = new System.Drawing.Point(107, 155);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.lNameTextbox.TabIndex = 2;
            // 
            // aCityTextbox
            // 
            this.aCityTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aCityTextbox.Location = new System.Drawing.Point(107, 297);
            this.aCityTextbox.Name = "aCityTextbox";
            this.aCityTextbox.Size = new System.Drawing.Size(344, 20);
            this.aCityTextbox.TabIndex = 6;
            // 
            // aLine2Textbox
            // 
            this.aLine2Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLine2Textbox.Location = new System.Drawing.Point(107, 271);
            this.aLine2Textbox.Name = "aLine2Textbox";
            this.aLine2Textbox.Size = new System.Drawing.Size(344, 20);
            this.aLine2Textbox.TabIndex = 5;
            // 
            // aLine1Textbox
            // 
            this.aLine1Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLine1Textbox.Location = new System.Drawing.Point(107, 245);
            this.aLine1Textbox.Name = "aLine1Textbox";
            this.aLine1Textbox.Size = new System.Drawing.Size(344, 20);
            this.aLine1Textbox.TabIndex = 4;
            // 
            // aStateDropdownlist
            // 
            this.aStateDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aStateDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aStateDropdownlist.FormattingEnabled = true;
            this.aStateDropdownlist.Items.AddRange(new object[] {
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
            this.aStateDropdownlist.Location = new System.Drawing.Point(107, 323);
            this.aStateDropdownlist.Name = "aStateDropdownlist";
            this.aStateDropdownlist.Size = new System.Drawing.Size(344, 21);
            this.aStateDropdownlist.TabIndex = 7;
            // 
            // ssnLabel
            // 
            ssnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ssnLabel.AutoSize = true;
            ssnLabel.BackColor = System.Drawing.Color.Transparent;
            ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ssnLabel.ForeColor = System.Drawing.Color.White;
            ssnLabel.Location = new System.Drawing.Point(55, 181);
            ssnLabel.Margin = new System.Windows.Forms.Padding(3);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(46, 20);
            ssnLabel.TabIndex = 20;
            ssnLabel.Text = "SSN:";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            loginLabel.AutoSize = true;
            loginLabel.BackColor = System.Drawing.Color.Transparent;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginLabel.ForeColor = System.Drawing.Color.White;
            loginLabel.Location = new System.Drawing.Point(31, 472);
            loginLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(70, 25);
            loginLabel.TabIndex = 22;
            loginLabel.Text = "Login";
            // 
            // pass2Textbox
            // 
            this.pass2Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass2Textbox.Location = new System.Drawing.Point(107, 555);
            this.pass2Textbox.Name = "pass2Textbox";
            this.pass2Textbox.PasswordChar = '*';
            this.pass2Textbox.Size = new System.Drawing.Size(344, 20);
            this.pass2Textbox.TabIndex = 13;
            // 
            // pass1Textbox
            // 
            this.pass1Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass1Textbox.Location = new System.Drawing.Point(107, 529);
            this.pass1Textbox.Name = "pass1Textbox";
            this.pass1Textbox.PasswordChar = '*';
            this.pass1Textbox.Size = new System.Drawing.Size(344, 20);
            this.pass1Textbox.TabIndex = 12;
            // 
            // userTextbox
            // 
            this.userTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTextbox.Location = new System.Drawing.Point(107, 503);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(344, 20);
            this.userTextbox.TabIndex = 11;
            // 
            // pass2Label
            // 
            pass2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pass2Label.BackColor = System.Drawing.Color.Transparent;
            pass2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pass2Label.ForeColor = System.Drawing.Color.White;
            pass2Label.Location = new System.Drawing.Point(18, 553);
            pass2Label.Margin = new System.Windows.Forms.Padding(3);
            pass2Label.Name = "pass2Label";
            pass2Label.Size = new System.Drawing.Size(83, 40);
            pass2Label.TabIndex = 25;
            pass2Label.Text = "Confirm Password:";
            // 
            // pass1Label
            // 
            pass1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pass1Label.AutoSize = true;
            pass1Label.BackColor = System.Drawing.Color.Transparent;
            pass1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pass1Label.ForeColor = System.Drawing.Color.White;
            pass1Label.Location = new System.Drawing.Point(19, 529);
            pass1Label.Margin = new System.Windows.Forms.Padding(3);
            pass1Label.Name = "pass1Label";
            pass1Label.Size = new System.Drawing.Size(82, 20);
            pass1Label.TabIndex = 24;
            pass1Label.Text = "Password:";
            // 
            // userLabel
            // 
            userLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userLabel.AutoSize = true;
            userLabel.BackColor = System.Drawing.Color.Transparent;
            userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLabel.ForeColor = System.Drawing.Color.White;
            userLabel.Location = new System.Drawing.Point(14, 503);
            userLabel.Margin = new System.Windows.Forms.Padding(3);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(87, 20);
            userLabel.TabIndex = 23;
            userLabel.Text = "Username:";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.Location = new System.Drawing.Point(295, 606);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 75);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelButton.Location = new System.Drawing.Point(376, 606);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 75);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextbox.Location = new System.Drawing.Point(107, 439);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(344, 20);
            this.emailTextbox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(49, 439);
            emailLabel.Margin = new System.Windows.Forms.Padding(3);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Transparent;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.White;
            phoneLabel.Location = new System.Drawing.Point(46, 413);
            phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 20);
            phoneLabel.TabIndex = 32;
            phoneLabel.Text = "Phone";
            // 
            // contactLabel
            // 
            contactLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contactLabel.AutoSize = true;
            contactLabel.BackColor = System.Drawing.Color.Transparent;
            contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLabel.ForeColor = System.Drawing.Color.White;
            contactLabel.Location = new System.Drawing.Point(8, 382);
            contactLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(93, 25);
            contactLabel.TabIndex = 31;
            contactLabel.Text = "Contact";
            // 
            // ssnTextbox
            // 
            this.ssnTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ssnTextbox.Location = new System.Drawing.Point(107, 183);
            this.ssnTextbox.Mask = "000-00-0000";
            this.ssnTextbox.Name = "ssnTextbox";
            this.ssnTextbox.Size = new System.Drawing.Size(344, 20);
            this.ssnTextbox.TabIndex = 3;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneTextbox.Location = new System.Drawing.Point(108, 413);
            this.phoneTextbox.Mask = "(999) 000-0000";
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(343, 20);
            this.phoneTextbox.TabIndex = 9;
            // 
            // aZipTextbox
            // 
            this.aZipTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aZipTextbox.Location = new System.Drawing.Point(108, 349);
            this.aZipTextbox.Mask = "00000";
            this.aZipTextbox.Name = "aZipTextbox";
            this.aZipTextbox.Size = new System.Drawing.Size(344, 20);
            this.aZipTextbox.TabIndex = 8;
            // 
            // Newemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.aZipTextbox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.ssnTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pass2Textbox);
            this.Controls.Add(this.pass1Textbox);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(pass2Label);
            this.Controls.Add(pass1Label);
            this.Controls.Add(userLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(ssnLabel);
            this.Controls.Add(this.aStateDropdownlist);
            this.Controls.Add(this.aCityTextbox);
            this.Controls.Add(this.aLine2Textbox);
            this.Controls.Add(this.aLine1Textbox);
            this.Controls.Add(this.lNameTextbox);
            this.Controls.Add(this.mNameTextbox);
            this.Controls.Add(this.fNameTextbox);
            this.Controls.Add(mNameLabel);
            this.Controls.Add(aZipLabel);
            this.Controls.Add(aStateLabel);
            this.Controls.Add(aCityLabel);
            this.Controls.Add(aLine2Label);
            this.Controls.Add(aLine1Label);
            this.Controls.Add(addressLabel);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Newemployee";
            this.Size = new System.Drawing.Size(500, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.TextBox mNameTextbox;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox aCityTextbox;
        private System.Windows.Forms.TextBox aLine2Textbox;
        private System.Windows.Forms.TextBox aLine1Textbox;
        private System.Windows.Forms.ComboBox aStateDropdownlist;
        private System.Windows.Forms.TextBox pass2Textbox;
        private System.Windows.Forms.TextBox pass1Textbox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.MaskedTextBox ssnTextbox;
        private System.Windows.Forms.MaskedTextBox phoneTextbox;
        private System.Windows.Forms.MaskedTextBox aZipTextbox;
    }
}

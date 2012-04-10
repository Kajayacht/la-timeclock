using System.Windows.Forms;
namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class Editemployees
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
            System.Windows.Forms.Label pass1Label;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label ssnLabel;
            System.Windows.Forms.Label mnameLabel;
            System.Windows.Forms.Label azipLabel;
            System.Windows.Forms.Label astateLabel;
            System.Windows.Forms.Label acityLabel;
            System.Windows.Forms.Label aline2Label;
            System.Windows.Forms.Label aline1Label;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label jobsLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label payLabel;
            System.Windows.Forms.Label pass2Label;
            System.Windows.Forms.Label privLabel;
            this.employedLabel = new System.Windows.Forms.Label();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.pass1Textbox = new System.Windows.Forms.TextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.aStateDropdownlist = new System.Windows.Forms.ComboBox();
            this.aCityTextbox = new System.Windows.Forms.TextBox();
            this.aLine2Textbox = new System.Windows.Forms.TextBox();
            this.aLine1Textbox = new System.Windows.Forms.TextBox();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.mNameTextbox = new System.Windows.Forms.TextBox();
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.saveemployeechangesButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.privDropdownlist = new System.Windows.Forms.ComboBox();
            this.changeloginButton = new System.Windows.Forms.Button();
            this.newemployeeButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.jobsBox = new System.Windows.Forms.ListBox();
            this.pass2Textbox = new System.Windows.Forms.TextBox();
            this.payTextbox = new System.Windows.Forms.TextBox();
            this.savepayButton = new System.Windows.Forms.Button();
            this.ssnTextbox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextbox = new System.Windows.Forms.MaskedTextBox();
            this.aZipTextbox = new System.Windows.Forms.MaskedTextBox();
            this.quitorfireButton = new System.Windows.Forms.Button();
            employeeLabel = new System.Windows.Forms.Label();
            pass1Label = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            mnameLabel = new System.Windows.Forms.Label();
            azipLabel = new System.Windows.Forms.Label();
            astateLabel = new System.Windows.Forms.Label();
            acityLabel = new System.Windows.Forms.Label();
            aline2Label = new System.Windows.Forms.Label();
            aline1Label = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            jobsLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            payLabel = new System.Windows.Forms.Label();
            pass2Label = new System.Windows.Forms.Label();
            privLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            employeeLabel.AutoSize = true;
            employeeLabel.BackColor = System.Drawing.Color.Transparent;
            employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeLabel.ForeColor = System.Drawing.Color.White;
            employeeLabel.Location = new System.Drawing.Point(20, 88);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(92, 20);
            employeeLabel.TabIndex = 5;
            employeeLabel.Text = "Employee:";
            // 
            // pass1Label
            // 
            pass1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pass1Label.AutoSize = true;
            pass1Label.BackColor = System.Drawing.Color.Transparent;
            pass1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pass1Label.ForeColor = System.Drawing.Color.White;
            pass1Label.Location = new System.Drawing.Point(30, 1000);
            pass1Label.Margin = new System.Windows.Forms.Padding(3);
            pass1Label.Name = "pass1Label";
            pass1Label.Size = new System.Drawing.Size(82, 20);
            pass1Label.TabIndex = 51;
            pass1Label.Text = "Password:";
            // 
            // userLabel
            // 
            userLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            userLabel.AutoSize = true;
            userLabel.BackColor = System.Drawing.Color.Transparent;
            userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLabel.ForeColor = System.Drawing.Color.White;
            userLabel.Location = new System.Drawing.Point(25, 974);
            userLabel.Margin = new System.Windows.Forms.Padding(3);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(87, 20);
            userLabel.TabIndex = 50;
            userLabel.Text = "Username:";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            loginLabel.AutoSize = true;
            loginLabel.BackColor = System.Drawing.Color.Transparent;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginLabel.ForeColor = System.Drawing.Color.White;
            loginLabel.Location = new System.Drawing.Point(42, 943);
            loginLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(70, 25);
            loginLabel.TabIndex = 49;
            loginLabel.Text = "Login";
            // 
            // ssnLabel
            // 
            ssnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ssnLabel.AutoSize = true;
            ssnLabel.BackColor = System.Drawing.Color.Transparent;
            ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ssnLabel.ForeColor = System.Drawing.Color.White;
            ssnLabel.Location = new System.Drawing.Point(66, 417);
            ssnLabel.Margin = new System.Windows.Forms.Padding(3);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(46, 20);
            ssnLabel.TabIndex = 47;
            ssnLabel.Text = "SSN:";
            // 
            // mnameLabel
            // 
            mnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            mnameLabel.AutoSize = true;
            mnameLabel.BackColor = System.Drawing.Color.Transparent;
            mnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mnameLabel.ForeColor = System.Drawing.Color.White;
            mnameLabel.Location = new System.Drawing.Point(53, 365);
            mnameLabel.Margin = new System.Windows.Forms.Padding(3);
            mnameLabel.Name = "mnameLabel";
            mnameLabel.Size = new System.Drawing.Size(59, 20);
            mnameLabel.TabIndex = 38;
            mnameLabel.Text = "Middle:";
            // 
            // azipLabel
            // 
            azipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            azipLabel.AutoSize = true;
            azipLabel.BackColor = System.Drawing.Color.Transparent;
            azipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            azipLabel.ForeColor = System.Drawing.Color.White;
            azipLabel.Location = new System.Drawing.Point(35, 585);
            azipLabel.Margin = new System.Windows.Forms.Padding(3);
            azipLabel.Name = "azipLabel";
            azipLabel.Size = new System.Drawing.Size(77, 20);
            azipLabel.TabIndex = 37;
            azipLabel.Text = "Zip Code:";
            // 
            // astateLabel
            // 
            astateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            astateLabel.AutoSize = true;
            astateLabel.BackColor = System.Drawing.Color.Transparent;
            astateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            astateLabel.ForeColor = System.Drawing.Color.White;
            astateLabel.Location = new System.Drawing.Point(60, 559);
            astateLabel.Margin = new System.Windows.Forms.Padding(3);
            astateLabel.Name = "astateLabel";
            astateLabel.Size = new System.Drawing.Size(52, 20);
            astateLabel.TabIndex = 36;
            astateLabel.Text = "State:";
            // 
            // acityLabel
            // 
            acityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            acityLabel.AutoSize = true;
            acityLabel.BackColor = System.Drawing.Color.Transparent;
            acityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            acityLabel.ForeColor = System.Drawing.Color.White;
            acityLabel.Location = new System.Drawing.Point(73, 533);
            acityLabel.Margin = new System.Windows.Forms.Padding(3);
            acityLabel.Name = "acityLabel";
            acityLabel.Size = new System.Drawing.Size(39, 20);
            acityLabel.TabIndex = 35;
            acityLabel.Text = "City:";
            // 
            // aline2Label
            // 
            aline2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aline2Label.AutoSize = true;
            aline2Label.BackColor = System.Drawing.Color.Transparent;
            aline2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aline2Label.ForeColor = System.Drawing.Color.White;
            aline2Label.Location = new System.Drawing.Point(56, 507);
            aline2Label.Margin = new System.Windows.Forms.Padding(3);
            aline2Label.Name = "aline2Label";
            aline2Label.Size = new System.Drawing.Size(56, 20);
            aline2Label.TabIndex = 34;
            aline2Label.Text = "Line 2:";
            // 
            // aline1Label
            // 
            aline1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            aline1Label.AutoSize = true;
            aline1Label.BackColor = System.Drawing.Color.Transparent;
            aline1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aline1Label.ForeColor = System.Drawing.Color.White;
            aline1Label.Location = new System.Drawing.Point(56, 481);
            aline1Label.Margin = new System.Windows.Forms.Padding(3);
            aline1Label.Name = "aline1Label";
            aline1Label.Size = new System.Drawing.Size(56, 20);
            aline1Label.TabIndex = 33;
            aline1Label.Text = "Line 1:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(14, 450);
            addressLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(98, 25);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Address";
            // 
            // lnameLabel
            // 
            lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lnameLabel.AutoSize = true;
            lnameLabel.BackColor = System.Drawing.Color.Transparent;
            lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnameLabel.ForeColor = System.Drawing.Color.White;
            lnameLabel.Location = new System.Drawing.Point(68, 391);
            lnameLabel.Margin = new System.Windows.Forms.Padding(3);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(44, 20);
            lnameLabel.TabIndex = 31;
            lnameLabel.Text = "Last:";
            // 
            // fnameLabel
            // 
            fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            fnameLabel.AutoSize = true;
            fnameLabel.BackColor = System.Drawing.Color.Transparent;
            fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.ForeColor = System.Drawing.Color.White;
            fnameLabel.Location = new System.Drawing.Point(68, 339);
            fnameLabel.Margin = new System.Windows.Forms.Padding(3);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(44, 20);
            fnameLabel.TabIndex = 30;
            fnameLabel.Text = "First:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(40, 308);
            nameLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Name";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(184, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(133, 20);
            titleLabel.TabIndex = 58;
            titleLabel.Text = "Edit Employees";
            // 
            // jobsLabel
            // 
            jobsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            jobsLabel.AutoSize = true;
            jobsLabel.BackColor = System.Drawing.Color.Transparent;
            jobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobsLabel.ForeColor = System.Drawing.Color.White;
            jobsLabel.Location = new System.Drawing.Point(50, 772);
            jobsLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            jobsLabel.Name = "jobsLabel";
            jobsLabel.Size = new System.Drawing.Size(62, 25);
            jobsLabel.TabIndex = 61;
            jobsLabel.Text = "Jobs";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(60, 675);
            emailLabel.Margin = new System.Windows.Forms.Padding(3);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 66;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Transparent;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.White;
            phoneLabel.Location = new System.Drawing.Point(57, 649);
            phoneLabel.Margin = new System.Windows.Forms.Padding(3);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 20);
            phoneLabel.TabIndex = 65;
            phoneLabel.Text = "Phone";
            // 
            // contactLabel
            // 
            contactLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            contactLabel.AutoSize = true;
            contactLabel.BackColor = System.Drawing.Color.Transparent;
            contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLabel.ForeColor = System.Drawing.Color.White;
            contactLabel.Location = new System.Drawing.Point(19, 618);
            contactLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(93, 25);
            contactLabel.TabIndex = 64;
            contactLabel.Text = "Contact";
            // 
            // payLabel
            // 
            payLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            payLabel.AutoSize = true;
            payLabel.BackColor = System.Drawing.Color.Transparent;
            payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payLabel.ForeColor = System.Drawing.Color.White;
            payLabel.Location = new System.Drawing.Point(244, 811);
            payLabel.Name = "payLabel";
            payLabel.Size = new System.Drawing.Size(39, 20);
            payLabel.TabIndex = 71;
            payLabel.Text = "Pay:";
            // 
            // pass2Label
            // 
            pass2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pass2Label.BackColor = System.Drawing.Color.Transparent;
            pass2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pass2Label.ForeColor = System.Drawing.Color.White;
            pass2Label.Location = new System.Drawing.Point(30, 1026);
            pass2Label.Margin = new System.Windows.Forms.Padding(3);
            pass2Label.Name = "pass2Label";
            pass2Label.Size = new System.Drawing.Size(82, 40);
            pass2Label.TabIndex = 72;
            pass2Label.Text = "Confirm Password:";
            // 
            // privLabel
            // 
            privLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            privLabel.AutoSize = true;
            privLabel.BackColor = System.Drawing.Color.Transparent;
            privLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            privLabel.ForeColor = System.Drawing.Color.White;
            privLabel.Location = new System.Drawing.Point(3, 248);
            privLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            privLabel.Name = "privLabel";
            privLabel.Size = new System.Drawing.Size(116, 25);
            privLabel.TabIndex = 75;
            privLabel.Text = "Privileges";
            // 
            // employedLabel
            // 
            this.employedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employedLabel.AutoSize = true;
            this.employedLabel.BackColor = System.Drawing.Color.Transparent;
            this.employedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employedLabel.ForeColor = System.Drawing.Color.White;
            this.employedLabel.Location = new System.Drawing.Point(3, 165);
            this.employedLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.employedLabel.Name = "employedLabel";
            this.employedLabel.Size = new System.Drawing.Size(129, 25);
            this.employedLabel.TabIndex = 77;
            this.employedLabel.Text = "Employed: ";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(118, 85);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 28);
            this.employeeDropdownlist.TabIndex = 1;
            this.employeeDropdownlist.TabStop = false;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // pass1Textbox
            // 
            this.pass1Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass1Textbox.Location = new System.Drawing.Point(118, 1000);
            this.pass1Textbox.Name = "pass1Textbox";
            this.pass1Textbox.PasswordChar = '*';
            this.pass1Textbox.Size = new System.Drawing.Size(344, 20);
            this.pass1Textbox.TabIndex = 21;
            // 
            // userTextbox
            // 
            this.userTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTextbox.Location = new System.Drawing.Point(118, 974);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(344, 20);
            this.userTextbox.TabIndex = 20;
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
            this.aStateDropdownlist.Location = new System.Drawing.Point(118, 559);
            this.aStateDropdownlist.Name = "aStateDropdownlist";
            this.aStateDropdownlist.Size = new System.Drawing.Size(344, 21);
            this.aStateDropdownlist.TabIndex = 12;
            // 
            // aCityTextbox
            // 
            this.aCityTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aCityTextbox.Location = new System.Drawing.Point(118, 533);
            this.aCityTextbox.Name = "aCityTextbox";
            this.aCityTextbox.Size = new System.Drawing.Size(344, 20);
            this.aCityTextbox.TabIndex = 11;
            // 
            // aLine2Textbox
            // 
            this.aLine2Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLine2Textbox.Location = new System.Drawing.Point(118, 507);
            this.aLine2Textbox.Name = "aLine2Textbox";
            this.aLine2Textbox.Size = new System.Drawing.Size(344, 20);
            this.aLine2Textbox.TabIndex = 10;
            // 
            // aLine1Textbox
            // 
            this.aLine1Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLine1Textbox.Location = new System.Drawing.Point(118, 481);
            this.aLine1Textbox.Name = "aLine1Textbox";
            this.aLine1Textbox.Size = new System.Drawing.Size(344, 20);
            this.aLine1Textbox.TabIndex = 9;
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lNameTextbox.Location = new System.Drawing.Point(118, 391);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.lNameTextbox.TabIndex = 7;
            // 
            // mNameTextbox
            // 
            this.mNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mNameTextbox.Location = new System.Drawing.Point(118, 365);
            this.mNameTextbox.Name = "mNameTextbox";
            this.mNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.mNameTextbox.TabIndex = 6;
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fNameTextbox.Location = new System.Drawing.Point(118, 339);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(344, 20);
            this.fNameTextbox.TabIndex = 5;
            // 
            // saveemployeechangesButton
            // 
            this.saveemployeechangesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveemployeechangesButton.Location = new System.Drawing.Point(387, 701);
            this.saveemployeechangesButton.Name = "saveemployeechangesButton";
            this.saveemployeechangesButton.Size = new System.Drawing.Size(75, 75);
            this.saveemployeechangesButton.TabIndex = 16;
            this.saveemployeechangesButton.Text = "Save Employee Changes";
            this.saveemployeechangesButton.UseVisualStyleBackColor = true;
            this.saveemployeechangesButton.Click += new System.EventHandler(this.Saveemployee_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.Location = new System.Drawing.Point(216, 119);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 33);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // privDropdownlist
            // 
            this.privDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.privDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privDropdownlist.FormattingEnabled = true;
            this.privDropdownlist.Items.AddRange(new object[] {
            "None",
            "Manager",
            "Admin"});
            this.privDropdownlist.Location = new System.Drawing.Point(118, 279);
            this.privDropdownlist.Name = "privDropdownlist";
            this.privDropdownlist.Size = new System.Drawing.Size(344, 23);
            this.privDropdownlist.TabIndex = 4;
            // 
            // changeloginButton
            // 
            this.changeloginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeloginButton.Location = new System.Drawing.Point(118, 1072);
            this.changeloginButton.Name = "changeloginButton";
            this.changeloginButton.Size = new System.Drawing.Size(344, 35);
            this.changeloginButton.TabIndex = 23;
            this.changeloginButton.Text = "Change Login";
            this.changeloginButton.UseVisualStyleBackColor = true;
            this.changeloginButton.Click += new System.EventHandler(this.Changelogin_Click);
            // 
            // newemployeeButton
            // 
            this.newemployeeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newemployeeButton.Location = new System.Drawing.Point(422, 3);
            this.newemployeeButton.Name = "newemployeeButton";
            this.newemployeeButton.Size = new System.Drawing.Size(75, 75);
            this.newemployeeButton.TabIndex = 0;
            this.newemployeeButton.Text = "New Employee";
            this.newemployeeButton.UseVisualStyleBackColor = true;
            this.newemployeeButton.Click += new System.EventHandler(this.Newemployee_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailTextbox.Location = new System.Drawing.Point(118, 675);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(344, 20);
            this.emailTextbox.TabIndex = 15;
            // 
            // jobsBox
            // 
            this.jobsBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jobsBox.FormattingEnabled = true;
            this.jobsBox.Items.AddRange(new object[] {
            "Bartender",
            "Cook",
            "Dishwasher",
            "Manager",
            "Security",
            "Server"});
            this.jobsBox.Location = new System.Drawing.Point(118, 811);
            this.jobsBox.Name = "jobsBox";
            this.jobsBox.Size = new System.Drawing.Size(120, 108);
            this.jobsBox.TabIndex = 17;
            this.jobsBox.SelectedIndexChanged += new System.EventHandler(this.Jobs_SelectedIndexChanged);
            // 
            // pass2Textbox
            // 
            this.pass2Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass2Textbox.Location = new System.Drawing.Point(118, 1046);
            this.pass2Textbox.Name = "pass2Textbox";
            this.pass2Textbox.PasswordChar = '*';
            this.pass2Textbox.Size = new System.Drawing.Size(344, 20);
            this.pass2Textbox.TabIndex = 22;
            // 
            // payTextbox
            // 
            this.payTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTextbox.Location = new System.Drawing.Point(289, 808);
            this.payTextbox.Name = "payTextbox";
            this.payTextbox.Size = new System.Drawing.Size(173, 26);
            this.payTextbox.TabIndex = 18;
            // 
            // savepayButton
            // 
            this.savepayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savepayButton.Location = new System.Drawing.Point(387, 844);
            this.savepayButton.Name = "savepayButton";
            this.savepayButton.Size = new System.Drawing.Size(75, 75);
            this.savepayButton.TabIndex = 19;
            this.savepayButton.Text = "Save Pay Change";
            this.savepayButton.UseVisualStyleBackColor = true;
            this.savepayButton.Click += new System.EventHandler(this.Savepay_Click);
            // 
            // ssnTextbox
            // 
            this.ssnTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ssnTextbox.Location = new System.Drawing.Point(118, 419);
            this.ssnTextbox.Mask = "000-00-0000";
            this.ssnTextbox.Name = "ssnTextbox";
            this.ssnTextbox.Size = new System.Drawing.Size(344, 20);
            this.ssnTextbox.TabIndex = 8;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneTextbox.Location = new System.Drawing.Point(119, 649);
            this.phoneTextbox.Mask = "(999) 000-0000";
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(343, 20);
            this.phoneTextbox.TabIndex = 14;
            // 
            // aZipTextbox
            // 
            this.aZipTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aZipTextbox.Location = new System.Drawing.Point(118, 585);
            this.aZipTextbox.Mask = "00000";
            this.aZipTextbox.Name = "aZipTextbox";
            this.aZipTextbox.Size = new System.Drawing.Size(344, 20);
            this.aZipTextbox.TabIndex = 13;
            // 
            // quitorfireButton
            // 
            this.quitorfireButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quitorfireButton.Location = new System.Drawing.Point(119, 119);
            this.quitorfireButton.Name = "quitorfireButton";
            this.quitorfireButton.Size = new System.Drawing.Size(92, 33);
            this.quitorfireButton.TabIndex = 2;
            this.quitorfireButton.Text = "Quit/Fire";
            this.quitorfireButton.UseVisualStyleBackColor = true;
            this.quitorfireButton.Click += new System.EventHandler(this.quitorfireButton_Click);
            // 
            // Editemployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.employedLabel);
            this.Controls.Add(this.quitorfireButton);
            this.Controls.Add(this.aZipTextbox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.ssnTextbox);
            this.Controls.Add(this.jobsBox);
            this.Controls.Add(this.savepayButton);
            this.Controls.Add(privLabel);
            this.Controls.Add(this.payTextbox);
            this.Controls.Add(this.pass2Textbox);
            this.Controls.Add(pass2Label);
            this.Controls.Add(payLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.newemployeeButton);
            this.Controls.Add(this.changeloginButton);
            this.Controls.Add(jobsLabel);
            this.Controls.Add(this.privDropdownlist);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveemployeechangesButton);
            this.Controls.Add(this.pass1Textbox);
            this.Controls.Add(this.userTextbox);
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
            this.Controls.Add(mnameLabel);
            this.Controls.Add(azipLabel);
            this.Controls.Add(astateLabel);
            this.Controls.Add(acityLabel);
            this.Controls.Add(aline2Label);
            this.Controls.Add(aline1Label);
            this.Controls.Add(addressLabel);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.DoubleBuffered = true;
            this.Name = "Editemployees";
            this.Size = new System.Drawing.Size(500, 1128);
            this.ResumeLayout(false);
            this.PerformLayout();

            MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            fNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            mNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            lNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            ssnTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aLine1Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aLine2Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aCityTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aZipTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            phoneTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            emailTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            payTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            userTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            pass1Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            pass2Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.TextBox pass1Textbox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.ComboBox aStateDropdownlist;
        private System.Windows.Forms.TextBox aCityTextbox;
        private System.Windows.Forms.TextBox aLine2Textbox;
        private System.Windows.Forms.TextBox aLine1Textbox;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox mNameTextbox;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.Button saveemployeechangesButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox privDropdownlist;
        private System.Windows.Forms.Button changeloginButton;
        private System.Windows.Forms.Button newemployeeButton;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.ListBox jobsBox;
        private System.Windows.Forms.TextBox pass2Textbox;
        private System.Windows.Forms.TextBox payTextbox;
        private System.Windows.Forms.Button savepayButton;
        private System.Windows.Forms.MaskedTextBox ssnTextbox;
        private System.Windows.Forms.MaskedTextBox phoneTextbox;
        private System.Windows.Forms.MaskedTextBox aZipTextbox;
        private System.Windows.Forms.Button quitorfireButton;
        private Label employedLabel;
    }
}

namespace Los_Alamos_Timeclock
{
    partial class Settings
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
            System.Windows.Forms.Label appSettingsLabel;
            System.Windows.Forms.Label databaseToolsLabel;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            this.ipaddressLLabel = new System.Windows.Forms.LinkLabel();
            this.portLLabel = new System.Windows.Forms.LinkLabel();
            this.userLLabel = new System.Windows.Forms.LinkLabel();
            this.passLLabel = new System.Windows.Forms.LinkLabel();
            this.ipaddressTextbox = new System.Windows.Forms.TextBox();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.databaseTextbox = new System.Windows.Forms.TextBox();
            this.databaseLLabel = new System.Windows.Forms.LinkLabel();
            this.showCurrentEmployeesCheckbox = new System.Windows.Forms.CheckBox();
            this.showPreviousEmployeesCheckbox = new System.Windows.Forms.CheckBox();
            this.saveAppSettings = new System.Windows.Forms.Button();
            this.cleanupEntriesButton = new System.Windows.Forms.Button();
            this.changeColorScheme = new System.Windows.Forms.Button();
            this.changeJobFolderButton = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            appSettingsLabel = new System.Windows.Forms.Label();
            databaseToolsLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(171, 315);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(159, 24);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Database Settings";
            // 
            // appSettingsLabel
            // 
            appSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            appSettingsLabel.AutoSize = true;
            appSettingsLabel.BackColor = System.Drawing.Color.Transparent;
            appSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appSettingsLabel.Location = new System.Drawing.Point(163, 26);
            appSettingsLabel.Name = "appSettingsLabel";
            appSettingsLabel.Size = new System.Drawing.Size(174, 24);
            appSettingsLabel.TabIndex = 12;
            appSettingsLabel.Text = "Application Settings";
            // 
            // databaseToolsLabel
            // 
            databaseToolsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            databaseToolsLabel.AutoSize = true;
            databaseToolsLabel.BackColor = System.Drawing.Color.Transparent;
            databaseToolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            databaseToolsLabel.Location = new System.Drawing.Point(180, 241);
            databaseToolsLabel.Name = "databaseToolsLabel";
            databaseToolsLabel.Size = new System.Drawing.Size(140, 24);
            databaseToolsLabel.TabIndex = 14;
            databaseToolsLabel.Text = "Database Tools";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox1.Location = new System.Drawing.Point(343, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 53);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = global::Los_Alamos_Timeclock.Properties.Resources.shakingMoraca2;
            pictureBox2.Location = new System.Drawing.Point(84, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(73, 53);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // ipaddressLLabel
            // 
            this.ipaddressLLabel.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.ipaddressLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ipaddressLLabel.AutoSize = true;
            this.ipaddressLLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipaddressLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddressLLabel.LinkColor = System.Drawing.Color.White;
            this.ipaddressLLabel.Location = new System.Drawing.Point(78, 361);
            this.ipaddressLLabel.Name = "ipaddressLLabel";
            this.ipaddressLLabel.Size = new System.Drawing.Size(91, 20);
            this.ipaddressLLabel.TabIndex = 1;
            this.ipaddressLLabel.TabStop = true;
            this.ipaddressLLabel.Text = "IP Address:";
            this.ipaddressLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ipLLabel_LinkClicked);
            // 
            // portLLabel
            // 
            this.portLLabel.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.portLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portLLabel.AutoSize = true;
            this.portLLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLLabel.LinkColor = System.Drawing.Color.White;
            this.portLLabel.Location = new System.Drawing.Point(127, 396);
            this.portLLabel.Name = "portLLabel";
            this.portLLabel.Size = new System.Drawing.Size(42, 20);
            this.portLLabel.TabIndex = 2;
            this.portLLabel.TabStop = true;
            this.portLLabel.Text = "Port:";
            this.portLLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.portLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.portLLabel_LinkClicked);
            // 
            // userLLabel
            // 
            this.userLLabel.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.userLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userLLabel.AutoSize = true;
            this.userLLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLLabel.LinkColor = System.Drawing.Color.White;
            this.userLLabel.Location = new System.Drawing.Point(120, 457);
            this.userLLabel.Name = "userLLabel";
            this.userLLabel.Size = new System.Drawing.Size(47, 20);
            this.userLLabel.TabIndex = 3;
            this.userLLabel.TabStop = true;
            this.userLLabel.Text = "User:";
            this.userLLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.userLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userLLabel_LinkClicked);
            // 
            // passLLabel
            // 
            this.passLLabel.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.passLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passLLabel.AutoSize = true;
            this.passLLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLLabel.LinkColor = System.Drawing.Color.White;
            this.passLLabel.Location = new System.Drawing.Point(85, 489);
            this.passLLabel.Name = "passLLabel";
            this.passLLabel.Size = new System.Drawing.Size(82, 20);
            this.passLLabel.TabIndex = 4;
            this.passLLabel.TabStop = true;
            this.passLLabel.Text = "Password:";
            this.passLLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.passLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passLLabel_LinkClicked);
            // 
            // ipaddressTextbox
            // 
            this.ipaddressTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ipaddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddressTextbox.Location = new System.Drawing.Point(175, 361);
            this.ipaddressTextbox.Name = "ipaddressTextbox";
            this.ipaddressTextbox.Size = new System.Drawing.Size(153, 26);
            this.ipaddressTextbox.TabIndex = 6;
            this.ipaddressTextbox.Text = "184.154.225.11";
            // 
            // portTextbox
            // 
            this.portTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextbox.Location = new System.Drawing.Point(175, 393);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(153, 26);
            this.portTextbox.TabIndex = 7;
            this.portTextbox.Text = "3306";
            // 
            // userTextbox
            // 
            this.userTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.Location = new System.Drawing.Point(173, 457);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(153, 26);
            this.userTextbox.TabIndex = 9;
            this.userTextbox.Text = "teamchro_user";
            // 
            // passTextbox
            // 
            this.passTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextbox.Location = new System.Drawing.Point(173, 489);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '*';
            this.passTextbox.Size = new System.Drawing.Size(153, 26);
            this.passTextbox.TabIndex = 10;
            this.passTextbox.Text = "chrono";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.applyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyButton.Location = new System.Drawing.Point(253, 521);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.Apply_Click);
            // 
            // databaseTextbox
            // 
            this.databaseTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.databaseTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTextbox.Location = new System.Drawing.Point(173, 425);
            this.databaseTextbox.Name = "databaseTextbox";
            this.databaseTextbox.Size = new System.Drawing.Size(153, 26);
            this.databaseTextbox.TabIndex = 8;
            this.databaseTextbox.Text = "teamchro_LATSQL";
            // 
            // databaseLLabel
            // 
            this.databaseLLabel.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.databaseLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.databaseLLabel.AutoSize = true;
            this.databaseLLabel.BackColor = System.Drawing.Color.Transparent;
            this.databaseLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLLabel.LinkColor = System.Drawing.Color.White;
            this.databaseLLabel.Location = new System.Drawing.Point(86, 425);
            this.databaseLLabel.Name = "databaseLLabel";
            this.databaseLLabel.Size = new System.Drawing.Size(83, 20);
            this.databaseLLabel.TabIndex = 10;
            this.databaseLLabel.TabStop = true;
            this.databaseLLabel.Text = "Database:";
            this.databaseLLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.databaseLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.databaseLLabel_LinkClicked);
            // 
            // showCurrentEmployeesCheckbox
            // 
            this.showCurrentEmployeesCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showCurrentEmployeesCheckbox.AutoSize = true;
            this.showCurrentEmployeesCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.showCurrentEmployeesCheckbox.Location = new System.Drawing.Point(175, 68);
            this.showCurrentEmployeesCheckbox.Name = "showCurrentEmployeesCheckbox";
            this.showCurrentEmployeesCheckbox.Size = new System.Drawing.Size(144, 17);
            this.showCurrentEmployeesCheckbox.TabIndex = 0;
            this.showCurrentEmployeesCheckbox.Text = "Show Current Employees";
            this.showCurrentEmployeesCheckbox.UseVisualStyleBackColor = false;
            // 
            // showPreviousEmployeesCheckbox
            // 
            this.showPreviousEmployeesCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showPreviousEmployeesCheckbox.AutoSize = true;
            this.showPreviousEmployeesCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.showPreviousEmployeesCheckbox.Location = new System.Drawing.Point(175, 102);
            this.showPreviousEmployeesCheckbox.Name = "showPreviousEmployeesCheckbox";
            this.showPreviousEmployeesCheckbox.Size = new System.Drawing.Size(151, 17);
            this.showPreviousEmployeesCheckbox.TabIndex = 1;
            this.showPreviousEmployeesCheckbox.Text = "Show Previous Employees";
            this.showPreviousEmployeesCheckbox.UseVisualStyleBackColor = false;
            // 
            // saveAppSettings
            // 
            this.saveAppSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveAppSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveAppSettings.Location = new System.Drawing.Point(190, 125);
            this.saveAppSettings.Name = "saveAppSettings";
            this.saveAppSettings.Size = new System.Drawing.Size(121, 23);
            this.saveAppSettings.TabIndex = 2;
            this.saveAppSettings.Text = "Save";
            this.saveAppSettings.UseVisualStyleBackColor = true;
            this.saveAppSettings.Click += new System.EventHandler(this.saveAppSettings_Click);
            // 
            // cleanupEntriesButton
            // 
            this.cleanupEntriesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cleanupEntriesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cleanupEntriesButton.Location = new System.Drawing.Point(190, 272);
            this.cleanupEntriesButton.Name = "cleanupEntriesButton";
            this.cleanupEntriesButton.Size = new System.Drawing.Size(121, 26);
            this.cleanupEntriesButton.TabIndex = 5;
            this.cleanupEntriesButton.Text = "Cleanup Entries";
            this.cleanupEntriesButton.UseVisualStyleBackColor = true;
            this.cleanupEntriesButton.Click += new System.EventHandler(this.cleanupButton_Click);
            // 
            // changeColorScheme
            // 
            this.changeColorScheme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeColorScheme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeColorScheme.Location = new System.Drawing.Point(190, 154);
            this.changeColorScheme.Name = "changeColorScheme";
            this.changeColorScheme.Size = new System.Drawing.Size(121, 26);
            this.changeColorScheme.TabIndex = 3;
            this.changeColorScheme.Text = "Change Color Scheme";
            this.changeColorScheme.UseVisualStyleBackColor = true;
            this.changeColorScheme.Click += new System.EventHandler(this.changeColorScheme_Click);
            // 
            // changeJobFolderButton
            // 
            this.changeJobFolderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeJobFolderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeJobFolderButton.Location = new System.Drawing.Point(190, 185);
            this.changeJobFolderButton.Name = "changeJobFolderButton";
            this.changeJobFolderButton.Size = new System.Drawing.Size(121, 43);
            this.changeJobFolderButton.TabIndex = 4;
            this.changeJobFolderButton.Text = "Change Job Image Folder";
            this.changeJobFolderButton.UseVisualStyleBackColor = true;
            this.changeJobFolderButton.Click += new System.EventHandler(this.changeJobFolderButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.changeJobFolderButton);
            this.Controls.Add(this.changeColorScheme);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(databaseToolsLabel);
            this.Controls.Add(this.cleanupEntriesButton);
            this.Controls.Add(this.saveAppSettings);
            this.Controls.Add(this.showPreviousEmployeesCheckbox);
            this.Controls.Add(this.showCurrentEmployeesCheckbox);
            this.Controls.Add(appSettingsLabel);
            this.Controls.Add(this.databaseTextbox);
            this.Controls.Add(this.databaseLLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.ipaddressTextbox);
            this.Controls.Add(this.passLLabel);
            this.Controls.Add(this.userLLabel);
            this.Controls.Add(this.portLLabel);
            this.Controls.Add(this.ipaddressLLabel);
            this.Controls.Add(titleLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "textColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.ForeColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.textColor;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(500, 575);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ipaddressLLabel;
        private System.Windows.Forms.LinkLabel portLLabel;
        private System.Windows.Forms.LinkLabel userLLabel;
        private System.Windows.Forms.LinkLabel passLLabel;
        private System.Windows.Forms.TextBox ipaddressTextbox;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox databaseTextbox;
        private System.Windows.Forms.LinkLabel databaseLLabel;
        private System.Windows.Forms.CheckBox showCurrentEmployeesCheckbox;
        private System.Windows.Forms.CheckBox showPreviousEmployeesCheckbox;
        private System.Windows.Forms.Button saveAppSettings;
        private System.Windows.Forms.Button cleanupEntriesButton;
        private System.Windows.Forms.Button changeColorScheme;
        private System.Windows.Forms.Button changeJobFolderButton;

    }
}

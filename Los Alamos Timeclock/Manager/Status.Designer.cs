namespace Los_Alamos_Timeclock.Manager
{
    partial class Status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Employees = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.updatescheduleButton = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.jobsDropdownlist = new System.Windows.Forms.ComboBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.startTextbox = new System.Windows.Forms.MaskedTextBox();
            this.endTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.break1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b1inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b2outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.break2Label = new System.Windows.Forms.Label();
            this.linTextbox = new System.Windows.Forms.MaskedTextBox();
            this.loutTextbox = new System.Windows.Forms.MaskedTextBox();
            this.lunchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employees.FormattingEnabled = true;
            this.Employees.Location = new System.Drawing.Point(79, 267);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(190, 21);
            this.Employees.TabIndex = 1;
            this.Employees.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.ForeColor = System.Drawing.Color.White;
            this.employeeLabel.Location = new System.Drawing.Point(20, 269);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(56, 13);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "Employee:";
            // 
            // calander
            // 
            this.calander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calander.Location = new System.Drawing.Point(275, 267);
            this.calander.Name = "calander";
            this.calander.Size = new System.Drawing.Size(200, 20);
            this.calander.TabIndex = 2;
            this.calander.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // updatescheduleButton
            // 
            this.updatescheduleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updatescheduleButton.Location = new System.Drawing.Point(378, 294);
            this.updatescheduleButton.Name = "updatescheduleButton";
            this.updatescheduleButton.Size = new System.Drawing.Size(97, 95);
            this.updatescheduleButton.TabIndex = 7;
            this.updatescheduleButton.Text = "Update";
            this.updatescheduleButton.UseVisualStyleBackColor = true;
            this.updatescheduleButton.Click += new System.EventHandler(this.Update_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.Size = new System.Drawing.Size(500, 261);
            this.dg.TabIndex = 6;
            // 
            // jobsDropdownlist
            // 
            this.jobsDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.jobsDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsDropdownlist.FormattingEnabled = true;
            this.jobsDropdownlist.Location = new System.Drawing.Point(79, 373);
            this.jobsDropdownlist.Name = "jobsDropdownlist";
            this.jobsDropdownlist.Size = new System.Drawing.Size(190, 21);
            this.jobsDropdownlist.TabIndex = 6;
            // 
            // startLabel
            // 
            this.startLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(20, 297);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(32, 13);
            this.startLabel.TabIndex = 11;
            this.startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            this.endLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(20, 324);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 12;
            this.endLabel.Text = "End:";
            // 
            // jobLabel
            // 
            this.jobLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.jobLabel.AutoSize = true;
            this.jobLabel.BackColor = System.Drawing.Color.Transparent;
            this.jobLabel.ForeColor = System.Drawing.Color.White;
            this.jobLabel.Location = new System.Drawing.Point(20, 373);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(27, 13);
            this.jobLabel.TabIndex = 13;
            this.jobLabel.Text = "Job:";
            // 
            // startTextbox
            // 
            this.startTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startTextbox.Location = new System.Drawing.Point(79, 294);
            this.startTextbox.Mask = "90:00";
            this.startTextbox.Name = "startTextbox";
            this.startTextbox.Size = new System.Drawing.Size(41, 20);
            this.startTextbox.TabIndex = 3;
            // 
            // endTextbox
            // 
            this.endTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endTextbox.Location = new System.Drawing.Point(79, 324);
            this.endTextbox.Mask = "90:00";
            this.endTextbox.Name = "endTextbox";
            this.endTextbox.Size = new System.Drawing.Size(41, 20);
            this.endTextbox.TabIndex = 15;
            // 
            // b1outTextbox
            // 
            this.b1outTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b1outTextbox.Location = new System.Drawing.Point(186, 294);
            this.b1outTextbox.Mask = "90:00";
            this.b1outTextbox.Name = "b1outTextbox";
            this.b1outTextbox.Size = new System.Drawing.Size(41, 20);
            this.b1outTextbox.TabIndex = 4;
            // 
            // break1Label
            // 
            this.break1Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break1Label.AutoSize = true;
            this.break1Label.BackColor = System.Drawing.Color.Transparent;
            this.break1Label.ForeColor = System.Drawing.Color.White;
            this.break1Label.Location = new System.Drawing.Point(127, 297);
            this.break1Label.Name = "break1Label";
            this.break1Label.Size = new System.Drawing.Size(47, 13);
            this.break1Label.TabIndex = 16;
            this.break1Label.Text = "Break 1:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(233, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "--";
            // 
            // b1inTextbox
            // 
            this.b1inTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b1inTextbox.Location = new System.Drawing.Point(252, 294);
            this.b1inTextbox.Mask = "90:00";
            this.b1inTextbox.Name = "b1inTextbox";
            this.b1inTextbox.Size = new System.Drawing.Size(41, 20);
            this.b1inTextbox.TabIndex = 5;
            // 
            // b2inTextbox
            // 
            this.b2inTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b2inTextbox.Location = new System.Drawing.Point(252, 321);
            this.b2inTextbox.Mask = "90:00";
            this.b2inTextbox.Name = "b2inTextbox";
            this.b2inTextbox.Size = new System.Drawing.Size(41, 20);
            this.b2inTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(233, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "--";
            // 
            // b2outTextbox
            // 
            this.b2outTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b2outTextbox.Location = new System.Drawing.Point(186, 321);
            this.b2outTextbox.Mask = "90:00";
            this.b2outTextbox.Name = "b2outTextbox";
            this.b2outTextbox.Size = new System.Drawing.Size(41, 20);
            this.b2outTextbox.TabIndex = 6;
            // 
            // break2Label
            // 
            this.break2Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break2Label.AutoSize = true;
            this.break2Label.BackColor = System.Drawing.Color.Transparent;
            this.break2Label.ForeColor = System.Drawing.Color.White;
            this.break2Label.Location = new System.Drawing.Point(127, 324);
            this.break2Label.Name = "break2Label";
            this.break2Label.Size = new System.Drawing.Size(47, 13);
            this.break2Label.TabIndex = 22;
            this.break2Label.Text = "Break 2:";
            // 
            // linTextbox
            // 
            this.linTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linTextbox.Location = new System.Drawing.Point(252, 347);
            this.linTextbox.Mask = "90:00";
            this.linTextbox.Name = "linTextbox";
            this.linTextbox.Size = new System.Drawing.Size(41, 20);
            this.linTextbox.TabIndex = 9;
            // 
            // loutTextbox
            // 
            this.loutTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loutTextbox.Location = new System.Drawing.Point(186, 347);
            this.loutTextbox.Mask = "90:00";
            this.loutTextbox.Name = "loutTextbox";
            this.loutTextbox.Size = new System.Drawing.Size(41, 20);
            this.loutTextbox.TabIndex = 8;
            // 
            // lunchLabel
            // 
            this.lunchLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunchLabel.AutoSize = true;
            this.lunchLabel.BackColor = System.Drawing.Color.Transparent;
            this.lunchLabel.ForeColor = System.Drawing.Color.White;
            this.lunchLabel.Location = new System.Drawing.Point(127, 350);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(40, 13);
            this.lunchLabel.TabIndex = 26;
            this.lunchLabel.Text = "Lunch:";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.linTextbox);
            this.Controls.Add(this.loutTextbox);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.b2inTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b2outTextbox);
            this.Controls.Add(this.break2Label);
            this.Controls.Add(this.b1inTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.b1outTextbox);
            this.Controls.Add(this.break1Label);
            this.Controls.Add(this.endTextbox);
            this.Controls.Add(this.startTextbox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.jobsDropdownlist);
            this.Controls.Add(this.updatescheduleButton);
            this.Controls.Add(this.calander);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.dg);
            this.DoubleBuffered = true;
            this.Name = "Status";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Employees;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button updatescheduleButton;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox jobsDropdownlist;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.MaskedTextBox startTextbox;
        private System.Windows.Forms.MaskedTextBox endTextbox;
        private System.Windows.Forms.MaskedTextBox b1outTextbox;
        private System.Windows.Forms.Label break1Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox b1inTextbox;
        private System.Windows.Forms.MaskedTextBox b2inTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox b2outTextbox;
        private System.Windows.Forms.Label break2Label;
        private System.Windows.Forms.MaskedTextBox linTextbox;
        private System.Windows.Forms.MaskedTextBox loutTextbox;
        private System.Windows.Forms.Label lunchLabel;

    }
}

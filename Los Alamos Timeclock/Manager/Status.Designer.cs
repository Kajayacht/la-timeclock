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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.updatescheduleButton = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.jobsDropdownlist = new System.Windows.Forms.ComboBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.startTextbox = new System.Windows.Forms.MaskedTextBox();
            this.endTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.break1Label = new System.Windows.Forms.Label();
            this.b1dashLabel = new System.Windows.Forms.Label();
            this.b1inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2dashLabel = new System.Windows.Forms.Label();
            this.b2outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.break2Label = new System.Windows.Forms.Label();
            this.linTextbox = new System.Windows.Forms.MaskedTextBox();
            this.loutTextbox = new System.Windows.Forms.MaskedTextBox();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.lunchdashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(79, 267);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 21);
            this.employeeDropdownlist.TabIndex = 1;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
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
            this.calander.ValueChanged += new System.EventHandler(this.calander_DateChanged);
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
            this.updatescheduleButton.Click += new System.EventHandler(this.update_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(0, 0);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.Size = new System.Drawing.Size(500, 261);
            this.datagrid.TabIndex = 6;
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
            // b1dashLabel
            // 
            this.b1dashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b1dashLabel.AutoSize = true;
            this.b1dashLabel.BackColor = System.Drawing.Color.Transparent;
            this.b1dashLabel.ForeColor = System.Drawing.Color.White;
            this.b1dashLabel.Location = new System.Drawing.Point(233, 297);
            this.b1dashLabel.Name = "b1dashLabel";
            this.b1dashLabel.Size = new System.Drawing.Size(13, 13);
            this.b1dashLabel.TabIndex = 20;
            this.b1dashLabel.Text = "--";
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
            // b2dashLabel
            // 
            this.b2dashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b2dashLabel.AutoSize = true;
            this.b2dashLabel.BackColor = System.Drawing.Color.Transparent;
            this.b2dashLabel.ForeColor = System.Drawing.Color.White;
            this.b2dashLabel.Location = new System.Drawing.Point(233, 324);
            this.b2dashLabel.Name = "b2dashLabel";
            this.b2dashLabel.Size = new System.Drawing.Size(13, 13);
            this.b2dashLabel.TabIndex = 24;
            this.b2dashLabel.Text = "--";
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
            // lunchdashLabel
            // 
            this.lunchdashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunchdashLabel.AutoSize = true;
            this.lunchdashLabel.BackColor = System.Drawing.Color.Transparent;
            this.lunchdashLabel.ForeColor = System.Drawing.Color.White;
            this.lunchdashLabel.Location = new System.Drawing.Point(233, 350);
            this.lunchdashLabel.Name = "lunchdashLabel";
            this.lunchdashLabel.Size = new System.Drawing.Size(13, 13);
            this.lunchdashLabel.TabIndex = 27;
            this.lunchdashLabel.Text = "--";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lunchdashLabel);
            this.Controls.Add(this.linTextbox);
            this.Controls.Add(this.loutTextbox);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.b2inTextbox);
            this.Controls.Add(this.b2dashLabel);
            this.Controls.Add(this.b2outTextbox);
            this.Controls.Add(this.break2Label);
            this.Controls.Add(this.b1inTextbox);
            this.Controls.Add(this.b1dashLabel);
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
            this.Controls.Add(this.employeeDropdownlist);
            this.Controls.Add(this.datagrid);
            this.DoubleBuffered = true;
            this.Name = "Status";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button updatescheduleButton;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox jobsDropdownlist;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.MaskedTextBox startTextbox;
        private System.Windows.Forms.MaskedTextBox endTextbox;
        private System.Windows.Forms.MaskedTextBox b1outTextbox;
        private System.Windows.Forms.Label break1Label;
        private System.Windows.Forms.Label b1dashLabel;
        private System.Windows.Forms.MaskedTextBox b1inTextbox;
        private System.Windows.Forms.MaskedTextBox b2inTextbox;
        private System.Windows.Forms.Label b2dashLabel;
        private System.Windows.Forms.MaskedTextBox b2outTextbox;
        private System.Windows.Forms.Label break2Label;
        private System.Windows.Forms.MaskedTextBox linTextbox;
        private System.Windows.Forms.MaskedTextBox loutTextbox;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Label lunchdashLabel;

    }
}

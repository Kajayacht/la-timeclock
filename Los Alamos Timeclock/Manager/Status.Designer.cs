using System.Windows.Forms;
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
            System.Windows.Forms.Label employeeLabel;
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label break1Label;
            System.Windows.Forms.Label break2Label;
            System.Windows.Forms.Label lunchLabel;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label b1dashLabel;
            System.Windows.Forms.Label b2dashLabel;
            System.Windows.Forms.Label lunchdashLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.updatescheduleButton = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.jobsDropdownlist = new System.Windows.Forms.ComboBox();
            this.startTextbox = new System.Windows.Forms.MaskedTextBox();
            this.endTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.linTextbox = new System.Windows.Forms.MaskedTextBox();
            this.loutTextbox = new System.Windows.Forms.MaskedTextBox();
            this.lunchintimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.lunchouttimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.break2intimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.break1intimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.break2outtimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.break1outtimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.endtimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            this.starttimePicker = new Los_Alamos_Timeclock.nullableDTpicker();
            employeeLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            break1Label = new System.Windows.Forms.Label();
            break2Label = new System.Windows.Forms.Label();
            lunchLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            b1dashLabel = new System.Windows.Forms.Label();
            b2dashLabel = new System.Windows.Forms.Label();
            lunchdashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            employeeLabel.AutoSize = true;
            employeeLabel.BackColor = System.Drawing.Color.Transparent;
            employeeLabel.Location = new System.Drawing.Point(20, 269);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(56, 13);
            employeeLabel.TabIndex = 3;
            employeeLabel.Text = "Employee:";
            // 
            // startLabel
            // 
            startLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            startLabel.AutoSize = true;
            startLabel.BackColor = System.Drawing.Color.Transparent;
            startLabel.Location = new System.Drawing.Point(20, 297);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(32, 13);
            startLabel.TabIndex = 11;
            startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            endLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            endLabel.AutoSize = true;
            endLabel.BackColor = System.Drawing.Color.Transparent;
            endLabel.Location = new System.Drawing.Point(20, 324);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(29, 13);
            endLabel.TabIndex = 12;
            endLabel.Text = "End:";
            // 
            // jobLabel
            // 
            jobLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            jobLabel.AutoSize = true;
            jobLabel.BackColor = System.Drawing.Color.Transparent;
            jobLabel.Location = new System.Drawing.Point(20, 373);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(27, 13);
            jobLabel.TabIndex = 13;
            jobLabel.Text = "Job:";
            // 
            // break1Label
            // 
            break1Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            break1Label.AutoSize = true;
            break1Label.BackColor = System.Drawing.Color.Transparent;
            break1Label.Location = new System.Drawing.Point(127, 297);
            break1Label.Name = "break1Label";
            break1Label.Size = new System.Drawing.Size(47, 13);
            break1Label.TabIndex = 16;
            break1Label.Text = "Break 1:";
            // 
            // break2Label
            // 
            break2Label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            break2Label.AutoSize = true;
            break2Label.BackColor = System.Drawing.Color.Transparent;
            break2Label.Location = new System.Drawing.Point(127, 324);
            break2Label.Name = "break2Label";
            break2Label.Size = new System.Drawing.Size(47, 13);
            break2Label.TabIndex = 22;
            break2Label.Text = "Break 2:";
            // 
            // lunchLabel
            // 
            lunchLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lunchLabel.AutoSize = true;
            lunchLabel.BackColor = System.Drawing.Color.Transparent;
            lunchLabel.Location = new System.Drawing.Point(127, 350);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new System.Drawing.Size(40, 13);
            lunchLabel.TabIndex = 26;
            lunchLabel.Text = "Lunch:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = global::Los_Alamos_Timeclock.Properties.Resources.dancing_cactus;
            pictureBox1.Location = new System.Drawing.Point(321, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 101);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // b1dashLabel
            // 
            b1dashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            b1dashLabel.AutoSize = true;
            b1dashLabel.BackColor = System.Drawing.Color.Transparent;
            b1dashLabel.Location = new System.Drawing.Point(233, 297);
            b1dashLabel.Name = "b1dashLabel";
            b1dashLabel.Size = new System.Drawing.Size(13, 13);
            b1dashLabel.TabIndex = 20;
            b1dashLabel.Text = "--";
            // 
            // b2dashLabel
            // 
            b2dashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            b2dashLabel.AutoSize = true;
            b2dashLabel.BackColor = System.Drawing.Color.Transparent;
            b2dashLabel.Location = new System.Drawing.Point(233, 324);
            b2dashLabel.Name = "b2dashLabel";
            b2dashLabel.Size = new System.Drawing.Size(13, 13);
            b2dashLabel.TabIndex = 24;
            b2dashLabel.Text = "--";
            // 
            // lunchdashLabel
            // 
            lunchdashLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lunchdashLabel.AutoSize = true;
            lunchdashLabel.BackColor = System.Drawing.Color.Transparent;
            lunchdashLabel.Location = new System.Drawing.Point(233, 350);
            lunchdashLabel.Name = "lunchdashLabel";
            lunchdashLabel.Size = new System.Drawing.Size(13, 13);
            lunchdashLabel.TabIndex = 27;
            lunchdashLabel.Text = "--";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(79, 267);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 21);
            this.employeeDropdownlist.TabIndex = 0;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // calander
            // 
            this.calander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calander.Location = new System.Drawing.Point(297, 267);
            this.calander.Name = "calander";
            this.calander.Size = new System.Drawing.Size(200, 20);
            this.calander.TabIndex = 1;
            this.calander.ValueChanged += new System.EventHandler(this.calander_DateChanged);
            // 
            // updatescheduleButton
            // 
            this.updatescheduleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updatescheduleButton.ForeColor = System.Drawing.Color.Black;
            this.updatescheduleButton.Location = new System.Drawing.Point(400, 294);
            this.updatescheduleButton.Name = "updatescheduleButton";
            this.updatescheduleButton.Size = new System.Drawing.Size(97, 100);
            this.updatescheduleButton.TabIndex = 11;
            this.updatescheduleButton.Text = "Update";
            this.updatescheduleButton.UseVisualStyleBackColor = true;
            this.updatescheduleButton.Click += new System.EventHandler(this.update_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid.BackgroundColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.tableBackgroundColor;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "tableBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.datagrid.Location = new System.Drawing.Point(0, 0);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.Size = new System.Drawing.Size(500, 261);
            this.datagrid.TabIndex = 12;
            // 
            // jobsDropdownlist
            // 
            this.jobsDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.jobsDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsDropdownlist.FormattingEnabled = true;
            this.jobsDropdownlist.Location = new System.Drawing.Point(79, 373);
            this.jobsDropdownlist.Name = "jobsDropdownlist";
            this.jobsDropdownlist.Size = new System.Drawing.Size(214, 21);
            this.jobsDropdownlist.TabIndex = 10;
            // 
            // startTextbox
            // 
            this.startTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startTextbox.Location = new System.Drawing.Point(79, 294);
            this.startTextbox.Mask = "00:00";
            this.startTextbox.Name = "startTextbox";
            this.startTextbox.Size = new System.Drawing.Size(41, 20);
            this.startTextbox.TabIndex = 2;
            this.startTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // endTextbox
            // 
            this.endTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endTextbox.Location = new System.Drawing.Point(79, 324);
            this.endTextbox.Mask = "00:00";
            this.endTextbox.Name = "endTextbox";
            this.endTextbox.Size = new System.Drawing.Size(41, 20);
            this.endTextbox.TabIndex = 9;
            this.endTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // b1outTextbox
            // 
            this.b1outTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b1outTextbox.Location = new System.Drawing.Point(186, 294);
            this.b1outTextbox.Mask = "00:00";
            this.b1outTextbox.Name = "b1outTextbox";
            this.b1outTextbox.Size = new System.Drawing.Size(41, 20);
            this.b1outTextbox.TabIndex = 3;
            this.b1outTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // b1inTextbox
            // 
            this.b1inTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b1inTextbox.Location = new System.Drawing.Point(252, 294);
            this.b1inTextbox.Mask = "00:00";
            this.b1inTextbox.Name = "b1inTextbox";
            this.b1inTextbox.Size = new System.Drawing.Size(41, 20);
            this.b1inTextbox.TabIndex = 4;
            // 
            // b2inTextbox
            // 
            this.b2inTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b2inTextbox.Location = new System.Drawing.Point(252, 321);
            this.b2inTextbox.Mask = "00:00";
            this.b2inTextbox.Name = "b2inTextbox";
            this.b2inTextbox.Size = new System.Drawing.Size(41, 20);
            this.b2inTextbox.TabIndex = 6;
            this.b2inTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // b2outTextbox
            // 
            this.b2outTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b2outTextbox.Location = new System.Drawing.Point(186, 321);
            this.b2outTextbox.Mask = "00:00";
            this.b2outTextbox.Name = "b2outTextbox";
            this.b2outTextbox.Size = new System.Drawing.Size(41, 20);
            this.b2outTextbox.TabIndex = 5;
            this.b2outTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // linTextbox
            // 
            this.linTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linTextbox.Location = new System.Drawing.Point(252, 347);
            this.linTextbox.Mask = "00:00";
            this.linTextbox.Name = "linTextbox";
            this.linTextbox.Size = new System.Drawing.Size(41, 20);
            this.linTextbox.TabIndex = 8;
            this.linTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // loutTextbox
            // 
            this.loutTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loutTextbox.Location = new System.Drawing.Point(186, 347);
            this.loutTextbox.Mask = "00:00";
            this.loutTextbox.Name = "loutTextbox";
            this.loutTextbox.Size = new System.Drawing.Size(41, 20);
            this.loutTextbox.TabIndex = 7;
            this.loutTextbox.ValidatingType = typeof(System.DateTime);
            // 
            // lunchintimePicker
            // 
            this.lunchintimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunchintimePicker.CustomFormat = "hh:mm tt";
            this.lunchintimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lunchintimePicker.Location = new System.Drawing.Point(309, 188);
            this.lunchintimePicker.Name = "lunchintimePicker";
            this.lunchintimePicker.Size = new System.Drawing.Size(67, 20);
            this.lunchintimePicker.TabIndex = 80;
            this.lunchintimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // lunchouttimePicker
            // 
            this.lunchouttimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lunchouttimePicker.CustomFormat = "hh:mm tt";
            this.lunchouttimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lunchouttimePicker.Location = new System.Drawing.Point(236, 188);
            this.lunchouttimePicker.Name = "lunchouttimePicker";
            this.lunchouttimePicker.Size = new System.Drawing.Size(67, 20);
            this.lunchouttimePicker.TabIndex = 79;
            this.lunchouttimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // break2intimePicker
            // 
            this.break2intimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break2intimePicker.CustomFormat = "hh:mm tt";
            this.break2intimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.break2intimePicker.Location = new System.Drawing.Point(309, 162);
            this.break2intimePicker.Name = "break2intimePicker";
            this.break2intimePicker.Size = new System.Drawing.Size(67, 20);
            this.break2intimePicker.TabIndex = 78;
            this.break2intimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // break1intimePicker
            // 
            this.break1intimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break1intimePicker.CustomFormat = "hh:mm tt";
            this.break1intimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.break1intimePicker.Location = new System.Drawing.Point(309, 136);
            this.break1intimePicker.Name = "break1intimePicker";
            this.break1intimePicker.Size = new System.Drawing.Size(67, 20);
            this.break1intimePicker.TabIndex = 77;
            this.break1intimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // break2outtimePicker
            // 
            this.break2outtimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break2outtimePicker.CustomFormat = "hh:mm tt";
            this.break2outtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.break2outtimePicker.Location = new System.Drawing.Point(236, 162);
            this.break2outtimePicker.Name = "break2outtimePicker";
            this.break2outtimePicker.Size = new System.Drawing.Size(67, 20);
            this.break2outtimePicker.TabIndex = 76;
            this.break2outtimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // break1outtimePicker
            // 
            this.break1outtimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.break1outtimePicker.CustomFormat = "hh:mm tt";
            this.break1outtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.break1outtimePicker.Location = new System.Drawing.Point(236, 136);
            this.break1outtimePicker.Name = "break1outtimePicker";
            this.break1outtimePicker.Size = new System.Drawing.Size(67, 20);
            this.break1outtimePicker.TabIndex = 75;
            this.break1outtimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // endtimePicker
            // 
            this.endtimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endtimePicker.CustomFormat = "hh:mm tt";
            this.endtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtimePicker.Location = new System.Drawing.Point(130, 162);
            this.endtimePicker.Name = "endtimePicker";
            this.endtimePicker.Size = new System.Drawing.Size(67, 20);
            this.endtimePicker.TabIndex = 74;
            this.endtimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // starttimePicker
            // 
            this.starttimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.starttimePicker.CustomFormat = "hh:mm tt";
            this.starttimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttimePicker.Location = new System.Drawing.Point(130, 136);
            this.starttimePicker.Name = "starttimePicker";
            this.starttimePicker.Size = new System.Drawing.Size(67, 20);
            this.starttimePicker.TabIndex = 73;
            this.starttimePicker.Value = new System.DateTime(2012, 4, 15, 17, 13, 54, 93);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lunchintimePicker);
            this.Controls.Add(this.lunchouttimePicker);
            this.Controls.Add(this.break2intimePicker);
            this.Controls.Add(this.break1intimePicker);
            this.Controls.Add(this.break2outtimePicker);
            this.Controls.Add(this.break1outtimePicker);
            this.Controls.Add(this.endtimePicker);
            this.Controls.Add(this.starttimePicker);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(lunchdashLabel);
            this.Controls.Add(this.linTextbox);
            this.Controls.Add(this.loutTextbox);
            this.Controls.Add(lunchLabel);
            this.Controls.Add(this.b2inTextbox);
            this.Controls.Add(b2dashLabel);
            this.Controls.Add(this.b2outTextbox);
            this.Controls.Add(break2Label);
            this.Controls.Add(this.b1inTextbox);
            this.Controls.Add(b1dashLabel);
            this.Controls.Add(this.b1outTextbox);
            this.Controls.Add(break1Label);
            this.Controls.Add(this.endTextbox);
            this.Controls.Add(this.startTextbox);
            this.Controls.Add(jobLabel);
            this.Controls.Add(endLabel);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.jobsDropdownlist);
            this.Controls.Add(this.updatescheduleButton);
            this.Controls.Add(this.calander);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.Controls.Add(this.datagrid);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "textColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.ForeColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.textColor;
            this.Name = "Status";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button updatescheduleButton;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox jobsDropdownlist;
        private System.Windows.Forms.MaskedTextBox startTextbox;
        private System.Windows.Forms.MaskedTextBox endTextbox;
        private System.Windows.Forms.MaskedTextBox b1outTextbox;
        private System.Windows.Forms.MaskedTextBox b1inTextbox;
        private System.Windows.Forms.MaskedTextBox b2inTextbox;
        private System.Windows.Forms.MaskedTextBox b2outTextbox;
        private System.Windows.Forms.MaskedTextBox linTextbox;
        private System.Windows.Forms.MaskedTextBox loutTextbox;
        private nullableDTpicker starttimePicker;
        private nullableDTpicker endtimePicker;
        private nullableDTpicker break2outtimePicker;
        private nullableDTpicker break1outtimePicker;
        private nullableDTpicker break2intimePicker;
        private nullableDTpicker break1intimePicker;
        private nullableDTpicker lunchintimePicker;
        private nullableDTpicker lunchouttimePicker;

    }
}

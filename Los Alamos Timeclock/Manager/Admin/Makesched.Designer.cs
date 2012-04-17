using System.Windows.Forms;
namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class Makesched
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.updatescheduleButon = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.jobsDropdownlist = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.showRequests = new System.Windows.Forms.Button();
            this.starttimePicker = new System.Windows.Forms.DateTimePicker();
            this.endtimePicker = new System.Windows.Forms.DateTimePicker();
            employeeLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            employeeLabel.AutoSize = true;
            employeeLabel.BackColor = System.Drawing.Color.Transparent;
            employeeLabel.Location = new System.Drawing.Point(23, 269);
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
            startLabel.Location = new System.Drawing.Point(23, 297);
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
            endLabel.Location = new System.Drawing.Point(23, 324);
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
            jobLabel.Location = new System.Drawing.Point(23, 368);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(27, 13);
            jobLabel.TabIndex = 13;
            jobLabel.Text = "Job:";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(82, 267);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(190, 21);
            this.employeeDropdownlist.TabIndex = 0;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // calander
            // 
            this.calander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calander.Location = new System.Drawing.Point(278, 267);
            this.calander.Name = "calander";
            this.calander.Size = new System.Drawing.Size(200, 20);
            this.calander.TabIndex = 1;
            this.calander.ValueChanged += new System.EventHandler(this.calander_DateChanged);
            // 
            // updatescheduleButon
            // 
            this.updatescheduleButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updatescheduleButon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatescheduleButon.Location = new System.Drawing.Point(278, 293);
            this.updatescheduleButon.Name = "updatescheduleButon";
            this.updatescheduleButon.Size = new System.Drawing.Size(60, 95);
            this.updatescheduleButon.TabIndex = 5;
            this.updatescheduleButon.Text = "Update";
            this.updatescheduleButon.UseVisualStyleBackColor = true;
            this.updatescheduleButon.Click += new System.EventHandler(this.update_Click);
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
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.tableBackgroundColor;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.DataBindings.Add(new System.Windows.Forms.Binding("GridColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "tableGridColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.datagrid.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "tableBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.datagrid.GridColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.tableGridColor;
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
            this.jobsDropdownlist.Location = new System.Drawing.Point(82, 368);
            this.jobsDropdownlist.Name = "jobsDropdownlist";
            this.jobsDropdownlist.Size = new System.Drawing.Size(190, 21);
            this.jobsDropdownlist.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(344, 293);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 95);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.delete_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(78, 345);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(67, 20);
            this.lengthLabel.TabIndex = 17;
            this.lengthLabel.Text = "Length: ";
            // 
            // showRequests
            // 
            this.showRequests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showRequests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showRequests.Location = new System.Drawing.Point(416, 293);
            this.showRequests.Name = "showRequests";
            this.showRequests.Size = new System.Drawing.Size(62, 95);
            this.showRequests.TabIndex = 7;
            this.showRequests.Text = "Show Overview";
            this.showRequests.UseVisualStyleBackColor = true;
            this.showRequests.Click += new System.EventHandler(this.showRequests_Click);
            // 
            // starttimePicker
            // 
            this.starttimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.starttimePicker.CustomFormat = "hh:mm tt";
            this.starttimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttimePicker.Location = new System.Drawing.Point(82, 297);
            this.starttimePicker.Name = "starttimePicker";
            this.starttimePicker.ShowUpDown = true;
            this.starttimePicker.Size = new System.Drawing.Size(78, 20);
            this.starttimePicker.TabIndex = 2;
            this.starttimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endtimePicker
            // 
            this.endtimePicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endtimePicker.CustomFormat = "hh:mm tt";
            this.endtimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtimePicker.Location = new System.Drawing.Point(82, 322);
            this.endtimePicker.Name = "endtimePicker";
            this.endtimePicker.ShowUpDown = true;
            this.endtimePicker.Size = new System.Drawing.Size(78, 20);
            this.endtimePicker.TabIndex = 3;
            this.endtimePicker.ValueChanged += new System.EventHandler(this.endtimePicker_ValueChanged);
            // 
            // Makesched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.endtimePicker);
            this.Controls.Add(this.starttimePicker);
            this.Controls.Add(this.showRequests);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(jobLabel);
            this.Controls.Add(endLabel);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.jobsDropdownlist);
            this.Controls.Add(this.updatescheduleButon);
            this.Controls.Add(this.calander);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.Controls.Add(this.datagrid);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Los_Alamos_Timeclock.Properties.Settings.Default, "textColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.ForeColor = global::Los_Alamos_Timeclock.Properties.Settings.Default.textColor;
            this.Name = "Makesched";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button updatescheduleButon;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox jobsDropdownlist;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button showRequests;
        private DateTimePicker starttimePicker;
        private DateTimePicker endtimePicker;

    }
}

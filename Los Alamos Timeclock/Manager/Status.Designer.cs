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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.updatescheduleButton = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.jobsDropdownlist = new System.Windows.Forms.ComboBox();
            this.startTextbox = new System.Windows.Forms.MaskedTextBox();
            this.endTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b1dashLabel = new System.Windows.Forms.Label();
            this.b1inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2inTextbox = new System.Windows.Forms.MaskedTextBox();
            this.b2dashLabel = new System.Windows.Forms.Label();
            this.b2outTextbox = new System.Windows.Forms.MaskedTextBox();
            this.linTextbox = new System.Windows.Forms.MaskedTextBox();
            this.loutTextbox = new System.Windows.Forms.MaskedTextBox();
            this.lunchdashLabel = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            break1Label = new System.Windows.Forms.Label();
            break2Label = new System.Windows.Forms.Label();
            lunchLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            employeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            employeeLabel.AutoSize = true;
            employeeLabel.BackColor = System.Drawing.Color.Transparent;
            employeeLabel.ForeColor = System.Drawing.Color.White;
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
            startLabel.ForeColor = System.Drawing.Color.White;
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
            endLabel.ForeColor = System.Drawing.Color.White;
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
            jobLabel.ForeColor = System.Drawing.Color.White;
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
            break1Label.ForeColor = System.Drawing.Color.White;
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
            break2Label.ForeColor = System.Drawing.Color.White;
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
            lunchLabel.ForeColor = System.Drawing.Color.White;
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
            pictureBox1.Location = new System.Drawing.Point(299, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(73, 101);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
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
            this.calander.Location = new System.Drawing.Point(275, 267);
            this.calander.Name = "calander";
            this.calander.Size = new System.Drawing.Size(200, 20);
            this.calander.TabIndex = 1;
            this.calander.ValueChanged += new System.EventHandler(this.calander_DateChanged);
            // 
            // updatescheduleButton
            // 
            this.updatescheduleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updatescheduleButton.Location = new System.Drawing.Point(378, 294);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.b1inTextbox.Mask = "00:00";
            this.b1inTextbox.Name = "b1inTextbox";
            this.b1inTextbox.Size = new System.Drawing.Size(41, 20);
            this.b1inTextbox.TabIndex = 4;
            this.b1inTextbox.ValidatingType = typeof(System.DateTime);
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
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.lunchdashLabel);
            this.Controls.Add(this.linTextbox);
            this.Controls.Add(this.loutTextbox);
            this.Controls.Add(lunchLabel);
            this.Controls.Add(this.b2inTextbox);
            this.Controls.Add(this.b2dashLabel);
            this.Controls.Add(this.b2outTextbox);
            this.Controls.Add(break2Label);
            this.Controls.Add(this.b1inTextbox);
            this.Controls.Add(this.b1dashLabel);
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
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label b1dashLabel;
        private System.Windows.Forms.MaskedTextBox b1inTextbox;
        private System.Windows.Forms.MaskedTextBox b2inTextbox;
        private System.Windows.Forms.Label b2dashLabel;
        private System.Windows.Forms.MaskedTextBox b2outTextbox;
        private System.Windows.Forms.MaskedTextBox linTextbox;
        private System.Windows.Forms.MaskedTextBox loutTextbox;
        private System.Windows.Forms.Label lunchdashLabel;

    }
}

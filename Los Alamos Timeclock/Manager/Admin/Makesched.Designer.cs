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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.Update = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Job = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.sh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.ComboBox();
            this.eh = new System.Windows.Forms.ComboBox();
            this.em = new System.Windows.Forms.ComboBox();
            this.Length = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee:";
            // 
            // calander
            // 
            this.calander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calander.Location = new System.Drawing.Point(275, 267);
            this.calander.Name = "calander";
            this.calander.Size = new System.Drawing.Size(200, 20);
            this.calander.TabIndex = 4;
            this.calander.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Update.Location = new System.Drawing.Point(275, 293);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(97, 95);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(500, 261);
            this.dg.TabIndex = 6;
            // 
            // Job
            // 
            this.Job.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Job.FormattingEnabled = true;
            this.Job.Items.AddRange(new object[] {
            "Bartender",
            "Cook",
            "Dishwasher",
            "Manager",
            "Security",
            "Server"});
            this.Job.Location = new System.Drawing.Point(79, 368);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(190, 21);
            this.Job.TabIndex = 6;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete.Location = new System.Drawing.Point(378, 293);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 95);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // sh
            // 
            this.sh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sh.FormattingEnabled = true;
            this.sh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.sh.Location = new System.Drawing.Point(79, 294);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(92, 21);
            this.sh.TabIndex = 2;
            this.sh.SelectedIndexChanged += new System.EventHandler(this.Start_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "End:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Job:";
            // 
            // sm
            // 
            this.sm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sm.FormattingEnabled = true;
            this.sm.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.sm.Location = new System.Drawing.Point(177, 294);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(92, 21);
            this.sm.TabIndex = 3;
            this.sm.SelectedIndexChanged += new System.EventHandler(this.sm_SelectedIndexChanged);
            // 
            // eh
            // 
            this.eh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.eh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.eh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.eh.FormattingEnabled = true;
            this.eh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.eh.Location = new System.Drawing.Point(79, 321);
            this.eh.Name = "eh";
            this.eh.Size = new System.Drawing.Size(92, 21);
            this.eh.TabIndex = 4;
            this.eh.SelectedIndexChanged += new System.EventHandler(this.eh_SelectedIndexChanged);
            // 
            // em
            // 
            this.em.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.em.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.em.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.em.FormattingEnabled = true;
            this.em.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.em.Location = new System.Drawing.Point(177, 321);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(92, 21);
            this.em.TabIndex = 5;
            this.em.SelectedIndexChanged += new System.EventHandler(this.em_SelectedIndexChanged);
            // 
            // Length
            // 
            this.Length.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(75, 345);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(67, 20);
            this.Length.TabIndex = 17;
            this.Length.Text = "Length: ";
            // 
            // Makesched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Length);
            this.Controls.Add(this.em);
            this.Controls.Add(this.eh);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.calander);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dg);
            this.DoubleBuffered = true;
            this.Name = "Makesched";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox Job;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox sh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sm;
        private System.Windows.Forms.ComboBox eh;
        private System.Windows.Forms.ComboBox em;
        private System.Windows.Forms.Label Length;

    }
}

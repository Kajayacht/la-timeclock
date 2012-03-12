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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calander = new System.Windows.Forms.DateTimePicker();
            this.Updateschedule = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.jobs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.MaskedTextBox();
            this.End = new System.Windows.Forms.MaskedTextBox();
            this.b1out = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b1in = new System.Windows.Forms.MaskedTextBox();
            this.b2in = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b2out = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lin = new System.Windows.Forms.MaskedTextBox();
            this.lout = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
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
            // Updateschedule
            // 
            this.Updateschedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Updateschedule.Location = new System.Drawing.Point(378, 294);
            this.Updateschedule.Name = "Updateschedule";
            this.Updateschedule.Size = new System.Drawing.Size(97, 95);
            this.Updateschedule.TabIndex = 7;
            this.Updateschedule.Text = "Update";
            this.Updateschedule.UseVisualStyleBackColor = true;
            this.Updateschedule.Click += new System.EventHandler(this.Update_Click);
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
            // jobs
            // 
            this.jobs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobs.FormattingEnabled = true;
            this.jobs.Location = new System.Drawing.Point(79, 373);
            this.jobs.Name = "jobs";
            this.jobs.Size = new System.Drawing.Size(190, 21);
            this.jobs.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Job:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(79, 294);
            this.Start.Mask = "90:00";
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(41, 20);
            this.Start.TabIndex = 14;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(79, 324);
            this.End.Mask = "90:00";
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(41, 20);
            this.End.TabIndex = 15;
            // 
            // b1out
            // 
            this.b1out.Location = new System.Drawing.Point(186, 294);
            this.b1out.Mask = "90:00";
            this.b1out.Name = "b1out";
            this.b1out.Size = new System.Drawing.Size(41, 20);
            this.b1out.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Break 1:";
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
            // b1in
            // 
            this.b1in.Location = new System.Drawing.Point(252, 294);
            this.b1in.Mask = "90:00";
            this.b1in.Name = "b1in";
            this.b1in.Size = new System.Drawing.Size(41, 20);
            this.b1in.TabIndex = 21;
            // 
            // b2in
            // 
            this.b2in.Location = new System.Drawing.Point(252, 321);
            this.b2in.Mask = "90:00";
            this.b2in.Name = "b2in";
            this.b2in.Size = new System.Drawing.Size(41, 20);
            this.b2in.TabIndex = 25;
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
            // b2out
            // 
            this.b2out.Location = new System.Drawing.Point(186, 321);
            this.b2out.Mask = "90:00";
            this.b2out.Name = "b2out";
            this.b2out.Size = new System.Drawing.Size(41, 20);
            this.b2out.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(127, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Break 2:";
            // 
            // lin
            // 
            this.lin.Location = new System.Drawing.Point(252, 347);
            this.lin.Mask = "90:00";
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(41, 20);
            this.lin.TabIndex = 28;
            // 
            // lout
            // 
            this.lout.Location = new System.Drawing.Point(186, 347);
            this.lout.Mask = "90:00";
            this.lout.Name = "lout";
            this.lout.Size = new System.Drawing.Size(41, 20);
            this.lout.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(127, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lunch:";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lin);
            this.Controls.Add(this.lout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.b2in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b2out);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b1in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.b1out);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobs);
            this.Controls.Add(this.Updateschedule);
            this.Controls.Add(this.calander);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dg);
            this.DoubleBuffered = true;
            this.Name = "Status";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calander;
        private System.Windows.Forms.Button Updateschedule;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox jobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Start;
        private System.Windows.Forms.MaskedTextBox End;
        private System.Windows.Forms.MaskedTextBox b1out;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox b1in;
        private System.Windows.Forms.MaskedTextBox b2in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox b2out;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox lin;
        private System.Windows.Forms.MaskedTextBox lout;
        private System.Windows.Forms.Label label9;

    }
}

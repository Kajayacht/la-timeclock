namespace Los_Alamos_Timeclock.Manager.Admin
{
    partial class Overview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestsDatagridview = new System.Windows.Forms.DataGridView();
            this.toCalander = new System.Windows.Forms.DateTimePicker();
            this.fromCalander = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.showwhatDropdownlist = new System.Windows.Forms.ComboBox();
            this.showLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsDatagridview
            // 
            this.requestsDatagridview.AllowUserToAddRows = false;
            this.requestsDatagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.requestsDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestsDatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDatagridview.Location = new System.Drawing.Point(12, 12);
            this.requestsDatagridview.Name = "requestsDatagridview";
            this.requestsDatagridview.ReadOnly = true;
            this.requestsDatagridview.RowHeadersVisible = false;
            this.requestsDatagridview.Size = new System.Drawing.Size(522, 304);
            this.requestsDatagridview.TabIndex = 7;
            // 
            // toCalander
            // 
            this.toCalander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toCalander.Location = new System.Drawing.Point(334, 351);
            this.toCalander.Name = "toCalander";
            this.toCalander.Size = new System.Drawing.Size(200, 20);
            this.toCalander.TabIndex = 8;
            this.toCalander.ValueChanged += new System.EventHandler(this.toCalander_ValueChanged);
            // 
            // fromCalander
            // 
            this.fromCalander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromCalander.Location = new System.Drawing.Point(334, 322);
            this.fromCalander.Name = "fromCalander";
            this.fromCalander.Size = new System.Drawing.Size(200, 20);
            this.fromCalander.TabIndex = 9;
            this.fromCalander.ValueChanged += new System.EventHandler(this.fromCalander_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(295, 328);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.Transparent;
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(305, 357);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 13;
            this.toLabel.Text = "To:";
            // 
            // showwhatDropdownlist
            // 
            this.showwhatDropdownlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showwhatDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showwhatDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showwhatDropdownlist.FormattingEnabled = true;
            this.showwhatDropdownlist.Items.AddRange(new object[] {
            "Requests",
            "Schedule",
            "Hours Worked"});
            this.showwhatDropdownlist.Location = new System.Drawing.Point(89, 325);
            this.showwhatDropdownlist.Name = "showwhatDropdownlist";
            this.showwhatDropdownlist.Size = new System.Drawing.Size(200, 33);
            this.showwhatDropdownlist.TabIndex = 14;
            this.showwhatDropdownlist.SelectedIndexChanged += new System.EventHandler(this.showwhatDropdownlist_SelectedIndexChanged);
            // 
            // showLabel
            // 
            this.showLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showLabel.AutoSize = true;
            this.showLabel.BackColor = System.Drawing.Color.Transparent;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.ForeColor = System.Drawing.Color.White;
            this.showLabel.Location = new System.Drawing.Point(12, 328);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(71, 25);
            this.showLabel.TabIndex = 15;
            this.showLabel.Text = "Show:";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.showwhatDropdownlist);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromCalander);
            this.Controls.Add(this.toCalander);
            this.Controls.Add(this.requestsDatagridview);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(562, 38);
            this.Name = "Overview";
            this.Text = "RequestsList";
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDatagridview;
        private System.Windows.Forms.DateTimePicker toCalander;
        private System.Windows.Forms.DateTimePicker fromCalander;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox showwhatDropdownlist;
        private System.Windows.Forms.Label showLabel;

    }
}
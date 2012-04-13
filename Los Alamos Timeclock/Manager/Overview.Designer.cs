using System.Windows.Forms;
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
            System.Windows.Forms.Label fromLabel;
            System.Windows.Forms.Label toLabel;
            System.Windows.Forms.Label showLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.overviewDatagridview = new System.Windows.Forms.DataGridView();
            this.toCalander = new System.Windows.Forms.DateTimePicker();
            this.fromCalander = new System.Windows.Forms.DateTimePicker();
            this.showwhatDropdownlist = new System.Windows.Forms.ComboBox();
            fromLabel = new System.Windows.Forms.Label();
            toLabel = new System.Windows.Forms.Label();
            showLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.overviewDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            fromLabel.AutoSize = true;
            fromLabel.BackColor = System.Drawing.Color.Transparent;
            fromLabel.ForeColor = System.Drawing.Color.White;
            fromLabel.Location = new System.Drawing.Point(295, 328);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new System.Drawing.Size(33, 13);
            fromLabel.TabIndex = 12;
            fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            toLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            toLabel.AutoSize = true;
            toLabel.BackColor = System.Drawing.Color.Transparent;
            toLabel.ForeColor = System.Drawing.Color.White;
            toLabel.Location = new System.Drawing.Point(305, 357);
            toLabel.Name = "toLabel";
            toLabel.Size = new System.Drawing.Size(23, 13);
            toLabel.TabIndex = 13;
            toLabel.Text = "To:";
            // 
            // showLabel
            // 
            showLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            showLabel.AutoSize = true;
            showLabel.BackColor = System.Drawing.Color.Transparent;
            showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showLabel.ForeColor = System.Drawing.Color.White;
            showLabel.Location = new System.Drawing.Point(12, 328);
            showLabel.Name = "showLabel";
            showLabel.Size = new System.Drawing.Size(71, 25);
            showLabel.TabIndex = 15;
            showLabel.Text = "Show:";
            // 
            // overviewDatagridview
            // 
            this.overviewDatagridview.AllowUserToAddRows = false;
            this.overviewDatagridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.overviewDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.overviewDatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overviewDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overviewDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewDatagridview.Location = new System.Drawing.Point(12, 12);
            this.overviewDatagridview.Name = "overviewDatagridview";
            this.overviewDatagridview.ReadOnly = true;
            this.overviewDatagridview.RowHeadersVisible = false;
            this.overviewDatagridview.Size = new System.Drawing.Size(522, 304);
            this.overviewDatagridview.TabIndex = 3;
            // 
            // toCalander
            // 
            this.toCalander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toCalander.Location = new System.Drawing.Point(334, 351);
            this.toCalander.Name = "toCalander";
            this.toCalander.Size = new System.Drawing.Size(200, 20);
            this.toCalander.TabIndex = 2;
            this.toCalander.ValueChanged += new System.EventHandler(this.toCalander_ValueChanged);
            // 
            // fromCalander
            // 
            this.fromCalander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromCalander.Location = new System.Drawing.Point(334, 322);
            this.fromCalander.Name = "fromCalander";
            this.fromCalander.Size = new System.Drawing.Size(200, 20);
            this.fromCalander.TabIndex = 1;
            this.fromCalander.ValueChanged += new System.EventHandler(this.fromCalander_ValueChanged);
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
            "Hours Worked",
            "Employee Notes"});
            this.showwhatDropdownlist.Location = new System.Drawing.Point(89, 325);
            this.showwhatDropdownlist.Name = "showwhatDropdownlist";
            this.showwhatDropdownlist.Size = new System.Drawing.Size(200, 33);
            this.showwhatDropdownlist.TabIndex = 0;
            this.showwhatDropdownlist.SelectedIndexChanged += new System.EventHandler(this.showwhatDropdownlist_SelectedIndexChanged);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(showLabel);
            this.Controls.Add(this.showwhatDropdownlist);
            this.Controls.Add(toLabel);
            this.Controls.Add(fromLabel);
            this.Controls.Add(this.fromCalander);
            this.Controls.Add(this.toCalander);
            this.Controls.Add(this.overviewDatagridview);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(562, 38);
            this.Name = "Overview";
            this.Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)(this.overviewDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView overviewDatagridview;
        private System.Windows.Forms.DateTimePicker toCalander;
        private System.Windows.Forms.DateTimePicker fromCalander;
        private System.Windows.Forms.ComboBox showwhatDropdownlist;

    }
}
using System.Windows.Forms;
namespace Los_Alamos_Timeclock
{
    partial class Schedule
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
            this.scheduleDatagrid = new System.Windows.Forms.DataGridView();
            this.weekCalander = new System.Windows.Forms.DateTimePicker();
            this.whoDropdownlist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDatagrid
            // 
            this.scheduleDatagrid.AllowUserToAddRows = false;
            this.scheduleDatagrid.AllowUserToDeleteRows = false;
            this.scheduleDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDatagrid.Location = new System.Drawing.Point(0, 28);
            this.scheduleDatagrid.Margin = new System.Windows.Forms.Padding(0);
            this.scheduleDatagrid.Name = "scheduleDatagrid";
            this.scheduleDatagrid.ReadOnly = true;
            this.scheduleDatagrid.RowHeadersVisible = false;
            this.scheduleDatagrid.RowHeadersWidth = 4;
            this.scheduleDatagrid.Size = new System.Drawing.Size(500, 372);
            this.scheduleDatagrid.TabIndex = 2;
            // 
            // weekCalander
            // 
            this.weekCalander.Location = new System.Drawing.Point(3, 3);
            this.weekCalander.Name = "weekCalander";
            this.weekCalander.Size = new System.Drawing.Size(200, 20);
            this.weekCalander.TabIndex = 0;
            this.weekCalander.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // whoDropdownlist
            // 
            this.whoDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.whoDropdownlist.FormattingEnabled = true;
            this.whoDropdownlist.Items.AddRange(new object[] {
            "Self",
            "All"});
            this.whoDropdownlist.Location = new System.Drawing.Point(210, 4);
            this.whoDropdownlist.Name = "whoDropdownlist";
            this.whoDropdownlist.Size = new System.Drawing.Size(121, 21);
            this.whoDropdownlist.TabIndex = 1;
            this.whoDropdownlist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.whoDropdownlist);
            this.Controls.Add(this.weekCalander);
            this.Controls.Add(this.scheduleDatagrid);
            this.DoubleBuffered = true;
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView scheduleDatagrid;
        private System.Windows.Forms.DateTimePicker weekCalander;
        private System.Windows.Forms.ComboBox whoDropdownlist;

    }
}

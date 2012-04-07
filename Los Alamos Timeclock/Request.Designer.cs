namespace Los_Alamos_Timeclock
{
    partial class Request
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
            this.requestsDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsDatagrid
            // 
            this.requestsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDatagrid.Location = new System.Drawing.Point(0, 0);
            this.requestsDatagrid.Name = "requestsDatagrid";
            this.requestsDatagrid.Size = new System.Drawing.Size(500, 297);
            this.requestsDatagrid.TabIndex = 0;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.requestsDatagrid);
            this.Name = "Request";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDatagrid;
    }
}

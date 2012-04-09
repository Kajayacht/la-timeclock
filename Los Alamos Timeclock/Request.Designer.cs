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
            this.startCalander = new System.Windows.Forms.DateTimePicker();
            this.endCalander = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reasonTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsDatagrid
            // 
            this.requestsDatagrid.AllowUserToAddRows = false;
            this.requestsDatagrid.AllowUserToDeleteRows = false;
            this.requestsDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestsDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.requestsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDatagrid.Location = new System.Drawing.Point(0, 0);
            this.requestsDatagrid.Name = "requestsDatagrid";
            this.requestsDatagrid.ReadOnly = true;
            this.requestsDatagrid.RowHeadersVisible = false;
            this.requestsDatagrid.Size = new System.Drawing.Size(500, 264);
            this.requestsDatagrid.TabIndex = 0;
            // 
            // startCalander
            // 
            this.startCalander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startCalander.Location = new System.Drawing.Point(56, 282);
            this.startCalander.Name = "startCalander";
            this.startCalander.Size = new System.Drawing.Size(200, 20);
            this.startCalander.TabIndex = 0;
            this.startCalander.ValueChanged += new System.EventHandler(this.startCalander_ValueChanged);
            // 
            // endCalander
            // 
            this.endCalander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.endCalander.CustomFormat = "";
            this.endCalander.Location = new System.Drawing.Point(291, 283);
            this.endCalander.Name = "endCalander";
            this.endCalander.Size = new System.Drawing.Size(200, 20);
            this.endCalander.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fromLabel.AutoSize = true;
            this.fromLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(17, 288);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.Transparent;
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(262, 288);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To:";
            // 
            // requestButton
            // 
            this.requestButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.requestButton.Location = new System.Drawing.Point(335, 318);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(75, 67);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(416, 318);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 67);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reasonTextbox
            // 
            this.reasonTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reasonTextbox.Location = new System.Drawing.Point(56, 318);
            this.reasonTextbox.Name = "reasonTextbox";
            this.reasonTextbox.Size = new System.Drawing.Size(273, 67);
            this.reasonTextbox.TabIndex = 2;
            this.reasonTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reason:";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.endCalander);
            this.Controls.Add(this.startCalander);
            this.Controls.Add(this.requestsDatagrid);
            this.DoubleBuffered = true;
            this.Name = "Request";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.requestsDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDatagrid;
        private System.Windows.Forms.DateTimePicker startCalander;
        private System.Windows.Forms.DateTimePicker endCalander;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RichTextBox reasonTextbox;
        private System.Windows.Forms.Label label1;
    }
}

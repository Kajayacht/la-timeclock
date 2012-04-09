namespace Los_Alamos_Timeclock.Manager
{
    partial class Employeenotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeDropdownlist = new System.Windows.Forms.ComboBox();
            this.notesDatagrid = new System.Windows.Forms.DataGridView();
            this.noteTextbox = new System.Windows.Forms.RichTextBox();
            this.addnoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notesDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(175, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 20);
            this.titleLabel.TabIndex = 59;
            this.titleLabel.Text = "Employee Notes";
            // 
            // employeeLabel
            // 
            this.employeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.White;
            this.employeeLabel.Location = new System.Drawing.Point(2, 316);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(92, 20);
            this.employeeLabel.TabIndex = 61;
            this.employeeLabel.Text = "Employee:";
            // 
            // employeeDropdownlist
            // 
            this.employeeDropdownlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeDropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeDropdownlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDropdownlist.FormattingEnabled = true;
            this.employeeDropdownlist.Location = new System.Drawing.Point(100, 313);
            this.employeeDropdownlist.Name = "employeeDropdownlist";
            this.employeeDropdownlist.Size = new System.Drawing.Size(153, 24);
            this.employeeDropdownlist.TabIndex = 1;
            this.employeeDropdownlist.TabStop = false;
            this.employeeDropdownlist.SelectedIndexChanged += new System.EventHandler(this.employeeDropdownlist_SelectedIndexChanged);
            // 
            // notesDatagrid
            // 
            this.notesDatagrid.AllowUserToAddRows = false;
            this.notesDatagrid.AllowUserToDeleteRows = false;
            this.notesDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notesDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notesDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.notesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesDatagrid.Location = new System.Drawing.Point(0, 32);
            this.notesDatagrid.Name = "notesDatagrid";
            this.notesDatagrid.ReadOnly = true;
            this.notesDatagrid.RowHeadersVisible = false;
            this.notesDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.notesDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDatagrid.RowTemplate.ReadOnly = true;
            this.notesDatagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDatagrid.Size = new System.Drawing.Size(500, 275);
            this.notesDatagrid.TabIndex = 0;
            // 
            // noteTextbox
            // 
            this.noteTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextbox.Location = new System.Drawing.Point(264, 313);
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(229, 84);
            this.noteTextbox.TabIndex = 2;
            this.noteTextbox.Text = "";
            // 
            // addnoteButton
            // 
            this.addnoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnoteButton.Location = new System.Drawing.Point(100, 343);
            this.addnoteButton.Name = "addnoteButton";
            this.addnoteButton.Size = new System.Drawing.Size(158, 54);
            this.addnoteButton.TabIndex = 3;
            this.addnoteButton.Text = "Add Note";
            this.addnoteButton.UseVisualStyleBackColor = true;
            this.addnoteButton.Click += new System.EventHandler(this.addnoteButton_Click);
            // 
            // Employeenotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.addnoteButton);
            this.Controls.Add(this.noteTextbox);
            this.Controls.Add(this.notesDatagrid);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.employeeDropdownlist);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Employeenotes";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.notesDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.ComboBox employeeDropdownlist;
        private System.Windows.Forms.DataGridView notesDatagrid;
        private System.Windows.Forms.RichTextBox noteTextbox;
        private System.Windows.Forms.Button addnoteButton;
    }
}

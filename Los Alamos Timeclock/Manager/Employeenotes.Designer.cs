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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empnoteslabel = new System.Windows.Forms.Label();
            this.empllabel = new System.Windows.Forms.Label();
            this.empnotelist = new System.Windows.Forms.ComboBox();
            this.Notes = new System.Windows.Forms.DataGridView();
            this.notetextbox = new System.Windows.Forms.RichTextBox();
            this.addnote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // empnoteslabel
            // 
            this.empnoteslabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empnoteslabel.AutoSize = true;
            this.empnoteslabel.BackColor = System.Drawing.Color.Transparent;
            this.empnoteslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnoteslabel.ForeColor = System.Drawing.Color.White;
            this.empnoteslabel.Location = new System.Drawing.Point(175, 9);
            this.empnoteslabel.Name = "empnoteslabel";
            this.empnoteslabel.Size = new System.Drawing.Size(139, 20);
            this.empnoteslabel.TabIndex = 59;
            this.empnoteslabel.Text = "Employee Notes";
            // 
            // empllabel
            // 
            this.empllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.empllabel.AutoSize = true;
            this.empllabel.BackColor = System.Drawing.Color.Transparent;
            this.empllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empllabel.ForeColor = System.Drawing.Color.White;
            this.empllabel.Location = new System.Drawing.Point(2, 316);
            this.empllabel.Name = "empllabel";
            this.empllabel.Size = new System.Drawing.Size(92, 20);
            this.empllabel.TabIndex = 61;
            this.empllabel.Text = "Employee:";
            // 
            // empnotelist
            // 
            this.empnotelist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.empnotelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empnotelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnotelist.FormattingEnabled = true;
            this.empnotelist.Location = new System.Drawing.Point(100, 313);
            this.empnotelist.Name = "empnotelist";
            this.empnotelist.Size = new System.Drawing.Size(153, 24);
            this.empnotelist.TabIndex = 60;
            this.empnotelist.TabStop = false;
            this.empnotelist.SelectedIndexChanged += new System.EventHandler(this.empnotelist_SelectedIndexChanged);
            // 
            // Notes
            // 
            this.Notes.AllowUserToAddRows = false;
            this.Notes.AllowUserToDeleteRows = false;
            this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Notes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes.Location = new System.Drawing.Point(0, 32);
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.RowHeadersVisible = false;
            this.Notes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Notes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.RowTemplate.ReadOnly = true;
            this.Notes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.Size = new System.Drawing.Size(500, 275);
            this.Notes.TabIndex = 62;
            // 
            // notetextbox
            // 
            this.notetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notetextbox.Location = new System.Drawing.Point(264, 313);
            this.notetextbox.Name = "notetextbox";
            this.notetextbox.Size = new System.Drawing.Size(229, 84);
            this.notetextbox.TabIndex = 63;
            this.notetextbox.Text = "";
            // 
            // addnote
            // 
            this.addnote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addnote.Location = new System.Drawing.Point(100, 343);
            this.addnote.Name = "addnote";
            this.addnote.Size = new System.Drawing.Size(158, 54);
            this.addnote.TabIndex = 64;
            this.addnote.Text = "Add Note";
            this.addnote.UseVisualStyleBackColor = true;
            this.addnote.Click += new System.EventHandler(this.addnote_Click);
            // 
            // Employeenotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.addnote);
            this.Controls.Add(this.notetextbox);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.empllabel);
            this.Controls.Add(this.empnotelist);
            this.Controls.Add(this.empnoteslabel);
            this.DoubleBuffered = true;
            this.Name = "Employeenotes";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empnoteslabel;
        private System.Windows.Forms.Label empllabel;
        private System.Windows.Forms.ComboBox empnotelist;
        private System.Windows.Forms.DataGridView Notes;
        private System.Windows.Forms.RichTextBox notetextbox;
        private System.Windows.Forms.Button addnote;
    }
}

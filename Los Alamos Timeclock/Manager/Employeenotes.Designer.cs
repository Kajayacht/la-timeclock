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
            this.empnotesbox = new System.Windows.Forms.RichTextBox();
            this.empnoteslabel = new System.Windows.Forms.Label();
            this.empllabel = new System.Windows.Forms.Label();
            this.empnotelist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // empnotesbox
            // 
            this.empnotesbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empnotesbox.Location = new System.Drawing.Point(40, 68);
            this.empnotesbox.Name = "empnotesbox";
            this.empnotesbox.Size = new System.Drawing.Size(420, 300);
            this.empnotesbox.TabIndex = 2;
            this.empnotesbox.Text = "";
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
            this.empllabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empllabel.AutoSize = true;
            this.empllabel.BackColor = System.Drawing.Color.Transparent;
            this.empllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empllabel.ForeColor = System.Drawing.Color.White;
            this.empllabel.Location = new System.Drawing.Point(55, 37);
            this.empllabel.Name = "empllabel";
            this.empllabel.Size = new System.Drawing.Size(92, 20);
            this.empllabel.TabIndex = 61;
            this.empllabel.Text = "Employee:";
            // 
            // empnotelist
            // 
            this.empnotelist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.empnotelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empnotelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnotelist.FormattingEnabled = true;
            this.empnotelist.Location = new System.Drawing.Point(153, 34);
            this.empnotelist.Name = "empnotelist";
            this.empnotelist.Size = new System.Drawing.Size(190, 28);
            this.empnotelist.TabIndex = 60;
            this.empnotelist.TabStop = false;
            this.empnotelist.SelectedIndexChanged += new System.EventHandler(this.empnotelist_SelectedIndexChanged);
            // 
            // Employeenotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.empllabel);
            this.Controls.Add(this.empnotelist);
            this.Controls.Add(this.empnoteslabel);
            this.Controls.Add(this.empnotesbox);
            this.Name = "Employeenotes";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox empnotesbox;
        private System.Windows.Forms.Label empnoteslabel;
        private System.Windows.Forms.Label empllabel;
        private System.Windows.Forms.ComboBox empnotelist;
    }
}

namespace Los_Alamos_Timeclock.Manager
{
    partial class Phonebook
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
            this.emplabel = new System.Windows.Forms.Label();
            this.emplist = new System.Windows.Forms.ComboBox();
            this.phonebooklabel = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emplabel
            // 
            this.emplabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emplabel.AutoSize = true;
            this.emplabel.BackColor = System.Drawing.Color.Transparent;
            this.emplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplabel.ForeColor = System.Drawing.Color.White;
            this.emplabel.Location = new System.Drawing.Point(56, 140);
            this.emplabel.Name = "emplabel";
            this.emplabel.Size = new System.Drawing.Size(92, 20);
            this.emplabel.TabIndex = 7;
            this.emplabel.Text = "Employee:";
            // 
            // emplist
            // 
            this.emplist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emplist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emplist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplist.FormattingEnabled = true;
            this.emplist.Location = new System.Drawing.Point(154, 137);
            this.emplist.Name = "emplist";
            this.emplist.Size = new System.Drawing.Size(190, 28);
            this.emplist.TabIndex = 6;
            this.emplist.TabStop = false;
            this.emplist.SelectedIndexChanged += new System.EventHandler(this.emplist_SelectedIndexChanged);
            // 
            // phonebooklabel
            // 
            this.phonebooklabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phonebooklabel.AutoSize = true;
            this.phonebooklabel.BackColor = System.Drawing.Color.Transparent;
            this.phonebooklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonebooklabel.ForeColor = System.Drawing.Color.White;
            this.phonebooklabel.Location = new System.Drawing.Point(187, 17);
            this.phonebooklabel.Name = "phonebooklabel";
            this.phonebooklabel.Size = new System.Drawing.Size(99, 20);
            this.phonebooklabel.TabIndex = 59;
            this.phonebooklabel.Text = "Phonebook";
            // 
            // phonenumber
            // 
            this.phonenumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phonenumber.AutoSize = true;
            this.phonenumber.BackColor = System.Drawing.Color.Transparent;
            this.phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.ForeColor = System.Drawing.Color.White;
            this.phonenumber.Location = new System.Drawing.Point(83, 189);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(0, 20);
            this.phonenumber.TabIndex = 61;
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.phonebooklabel);
            this.Controls.Add(this.emplabel);
            this.Controls.Add(this.emplist);
            this.DoubleBuffered = true;
            this.Name = "Phonebook";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emplabel;
        private System.Windows.Forms.ComboBox emplist;
        private System.Windows.Forms.Label phonebooklabel;
        private System.Windows.Forms.Label phonenumber;

    }
}

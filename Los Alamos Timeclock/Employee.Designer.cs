namespace Los_Alamos_Timeclock
{
    partial class Employee
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
            this.menu1 = new Los_Alamos_Timeclock.Menu();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.AutoSize = true;
            this.menu1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(0);
            this.menu1.MinimumSize = new System.Drawing.Size(100, 100);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(100, 362);
            this.menu1.TabIndex = 0;
            this.menu1.Load += new System.EventHandler(this.menu1_Load_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.menu1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Alamos Timeclock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Menu menu1;



    }
}
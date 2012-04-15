namespace Los_Alamos_Timeclock.UI
{
    partial class colorSchemeChooser
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button textColorButton;
            System.Windows.Forms.Button tabletextColorButton;
            System.Windows.Forms.Button tablegridColorButton;
            System.Windows.Forms.Button tablebackgroundColorButton;
            System.Windows.Forms.Button backgroundImageButton;
            System.Windows.Forms.Button backgroundColorButton;
            System.Windows.Forms.Button applyButton;
            System.Windows.Forms.Button restoreDefaultButton;
            System.Windows.Forms.Button row1colorButton;
            System.Windows.Forms.Button row2colorButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorSchemeChooser));
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            label1 = new System.Windows.Forms.Label();
            textColorButton = new System.Windows.Forms.Button();
            tabletextColorButton = new System.Windows.Forms.Button();
            tablegridColorButton = new System.Windows.Forms.Button();
            tablebackgroundColorButton = new System.Windows.Forms.Button();
            backgroundImageButton = new System.Windows.Forms.Button();
            backgroundColorButton = new System.Windows.Forms.Button();
            applyButton = new System.Windows.Forms.Button();
            restoreDefaultButton = new System.Windows.Forms.Button();
            row1colorButton = new System.Windows.Forms.Button();
            row2colorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(98, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 25);
            label1.TabIndex = 8;
            label1.Text = "Change Color Scheme";
            // 
            // textColorButton
            // 
            textColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            textColorButton.Location = new System.Drawing.Point(16, 51);
            textColorButton.Name = "textColorButton";
            textColorButton.Size = new System.Drawing.Size(127, 34);
            textColorButton.TabIndex = 9;
            textColorButton.Text = "Text Color";
            textColorButton.UseVisualStyleBackColor = true;
            textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // tabletextColorButton
            // 
            tabletextColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tabletextColorButton.Location = new System.Drawing.Point(16, 91);
            tabletextColorButton.Name = "tabletextColorButton";
            tabletextColorButton.Size = new System.Drawing.Size(127, 34);
            tabletextColorButton.TabIndex = 10;
            tabletextColorButton.Text = "Table Text Color";
            tabletextColorButton.UseVisualStyleBackColor = true;
            tabletextColorButton.Click += new System.EventHandler(this.tabletextColorButton_Click);
            // 
            // tablegridColorButton
            // 
            tablegridColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tablegridColorButton.Location = new System.Drawing.Point(16, 131);
            tablegridColorButton.Name = "tablegridColorButton";
            tablegridColorButton.Size = new System.Drawing.Size(127, 34);
            tablegridColorButton.TabIndex = 11;
            tablegridColorButton.Text = "Table Grid Color";
            tablegridColorButton.UseVisualStyleBackColor = true;
            tablegridColorButton.Click += new System.EventHandler(this.tablegridColorButton_Click);
            // 
            // tablebackgroundColorButton
            // 
            tablebackgroundColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            tablebackgroundColorButton.Location = new System.Drawing.Point(16, 251);
            tablebackgroundColorButton.Name = "tablebackgroundColorButton";
            tablebackgroundColorButton.Size = new System.Drawing.Size(127, 34);
            tablebackgroundColorButton.TabIndex = 12;
            tablebackgroundColorButton.Text = "Table Background Color";
            tablebackgroundColorButton.UseVisualStyleBackColor = true;
            tablebackgroundColorButton.Click += new System.EventHandler(this.tablebackgroundColorButton_Click);
            // 
            // backgroundImageButton
            // 
            backgroundImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            backgroundImageButton.Location = new System.Drawing.Point(16, 291);
            backgroundImageButton.Name = "backgroundImageButton";
            backgroundImageButton.Size = new System.Drawing.Size(127, 34);
            backgroundImageButton.TabIndex = 13;
            backgroundImageButton.Text = "Background Image";
            backgroundImageButton.UseVisualStyleBackColor = true;
            backgroundImageButton.Click += new System.EventHandler(this.backgroundImageButton_Click);
            // 
            // backgroundColorButton
            // 
            backgroundColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            backgroundColorButton.Location = new System.Drawing.Point(16, 331);
            backgroundColorButton.Name = "backgroundColorButton";
            backgroundColorButton.Size = new System.Drawing.Size(127, 34);
            backgroundColorButton.TabIndex = 14;
            backgroundColorButton.Text = "Background Color";
            backgroundColorButton.UseVisualStyleBackColor = true;
            backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // applyButton
            // 
            applyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            applyButton.Location = new System.Drawing.Point(285, 371);
            applyButton.Name = "applyButton";
            applyButton.Size = new System.Drawing.Size(127, 52);
            applyButton.TabIndex = 15;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // restoreDefaultButton
            // 
            restoreDefaultButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            restoreDefaultButton.Location = new System.Drawing.Point(152, 371);
            restoreDefaultButton.Name = "restoreDefaultButton";
            restoreDefaultButton.Size = new System.Drawing.Size(127, 52);
            restoreDefaultButton.TabIndex = 16;
            restoreDefaultButton.Text = "Restore to Default";
            restoreDefaultButton.UseVisualStyleBackColor = true;
            restoreDefaultButton.Click += new System.EventHandler(this.restoreDefaultButton_Click);
            // 
            // row1colorButton
            // 
            row1colorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            row1colorButton.Location = new System.Drawing.Point(16, 171);
            row1colorButton.Name = "row1colorButton";
            row1colorButton.Size = new System.Drawing.Size(127, 34);
            row1colorButton.TabIndex = 18;
            row1colorButton.Text = "Table Row 1 Color";
            row1colorButton.UseVisualStyleBackColor = true;
            row1colorButton.Click += new System.EventHandler(this.row1colorButton_Click);
            // 
            // row2colorButton
            // 
            row2colorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            row2colorButton.Location = new System.Drawing.Point(16, 211);
            row2colorButton.Name = "row2colorButton";
            row2colorButton.Size = new System.Drawing.Size(127, 34);
            row2colorButton.TabIndex = 19;
            row2colorButton.Text = "Table Row 2 Color";
            row2colorButton.UseVisualStyleBackColor = true;
            row2colorButton.Click += new System.EventHandler(this.row2colorButton_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.datagrid.Location = new System.Drawing.Point(149, 51);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.Size = new System.Drawing.Size(260, 314);
            this.datagrid.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // colorSchemeChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Los_Alamos_Timeclock.Properties.Resources._1287421014661;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 437);
            this.Controls.Add(row2colorButton);
            this.Controls.Add(row1colorButton);
            this.Controls.Add(restoreDefaultButton);
            this.Controls.Add(applyButton);
            this.Controls.Add(backgroundColorButton);
            this.Controls.Add(backgroundImageButton);
            this.Controls.Add(tablebackgroundColorButton);
            this.Controls.Add(tablegridColorButton);
            this.Controls.Add(tabletextColorButton);
            this.Controls.Add(textColorButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.datagrid);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 475);
            this.Name = "colorSchemeChooser";
            this.Text = "Change Color Scheme";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
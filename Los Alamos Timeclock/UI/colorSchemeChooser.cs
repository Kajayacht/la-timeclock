using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.UI
{
    public partial class colorSchemeChooser : Form
    {
        public Color textColor = Properties.Settings.Default.textColor;
        public Color tabletextColor = Properties.Settings.Default.tableTextColor;
        public Color tablegridColor = Properties.Settings.Default.tableGridColor;
        public Color tablebackgroundColor = Properties.Settings.Default.tableBackgroundColor;

        public Color row1Color;
        public Color row2Color;

        public colorSchemeChooser()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            this.ForeColor = Properties.Settings.Default.textColor;
            datagrid.ForeColor = Properties.Settings.Default.tableTextColor;
            datagrid.BackgroundColor = Properties.Settings.Default.tableBackgroundColor;
            datagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;

            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
            datagrid.Rows.Add("Sample Text");
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = textColor;
            colorPicker.ShowDialog();
            textColor = colorPicker.Color;
            this.ForeColor = textColor;  
        }

        private void tabletextColorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = tabletextColor;
            colorPicker.ShowDialog();
            tabletextColor = colorPicker.Color;
            datagrid.DefaultCellStyle.ForeColor = tabletextColor;
        }

        private void tablegridColorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = tablegridColor;
            colorPicker.ShowDialog();
            tablegridColor = colorPicker.Color;
            datagrid.GridColor = tablegridColor;
        }

        private void tablebackgroundColorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = tablebackgroundColor;
            colorPicker.ShowDialog();
            tablebackgroundColor = colorPicker.Color;
            datagrid.BackgroundColor = tablebackgroundColor;
        }

        private void row1colorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = row1Color;
            colorPicker.ShowDialog();
            row1Color = colorPicker.Color;
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = row1Color;
        }

        private void row2colorButton_Click(object sender, EventArgs e)
        {
            colorPicker.Color = row2Color;
            colorPicker.ShowDialog();
            row2Color = colorPicker.Color;
            datagrid.DefaultCellStyle.BackColor = row2Color;
        }

        String filename = "";
        private void backgroundImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            imageDialog.FilterIndex = 1;
            imageDialog.InitialDirectory = Application.StartupPath.ToString() + "\\Graphics\\";
            imageDialog.RestoreDirectory = false;

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                filename = System.IO.Path.GetFileName(imageDialog.FileName);
                String filepath = System.IO.Path.GetFullPath(imageDialog.FileName);
                String directory = System.IO.Path.GetDirectoryName(imageDialog.FileName);
                String graphicsDirectory = System.IO.Path.GetFullPath("Graphics");

                //checks if the file is already in the directory
                if (directory.ToLower() != graphicsDirectory.ToLower())
                {
                    try
                    {
                        System.IO.File.Copy(filepath, "Graphics\\" + filename);
                        this.BackgroundImage = Image.FromFile("Graphics\\" + filename);
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        MessageBox.Show("File not found");
                    }
                    catch (System.IO.IOException)
                    {
                        if (System.IO.File.Exists("Graphics\\" + filename))
                        {
                            MessageBox.Show("ERROR: A file by that name already exists in " + graphicsDirectory);
                        }
                        else
                        {
                            MessageBox.Show("ERROR: IO Error");
                        }
                    }
                }
                else
                {
                    this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
                }
            }


        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textColor = textColor;
            Properties.Settings.Default.tableTextColor = tabletextColor;
            Properties.Settings.Default.tableGridColor = tablegridColor;
            Properties.Settings.Default.tablerow1Color = row1Color;
            Properties.Settings.Default.tablerow2Color = row2Color;
            Properties.Settings.Default.tableBackgroundColor = tablebackgroundColor;
            Properties.Settings.Default.backgroundImage = "Graphics\\" + filename;
            Properties.Settings.Default.Save();
        }

        private void restoreDefaultButton_Click(object sender, EventArgs e)
        {
            this.ForeColor= textColor = Color.White;
            datagrid.ForeColor= tabletextColor = Color.Black;
            datagrid.GridColor= tablegridColor = Color.LightGray;
            datagrid.DefaultCellStyle.BackColor= row1Color = Color.White;
            datagrid.AlternatingRowsDefaultCellStyle.BackColor= row2Color = Color.White;
            datagrid.BackgroundColor= tablebackgroundColor = Color.DarkGray;
        }
    }
}

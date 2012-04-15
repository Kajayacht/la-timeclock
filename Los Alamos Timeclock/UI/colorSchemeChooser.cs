using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Los_Alamos_Timeclock.Properties;

namespace Los_Alamos_Timeclock.UI
{
    public partial class colorSchemeChooser : Form
    {
        public Color textColor = Properties.Settings.Default.textColor;
        public Color tabletextColor = Properties.Settings.Default.tableTextColor;
        public Color tablegridColor = Properties.Settings.Default.tableGridColor;
        public Color tablebackgroundColor = Properties.Settings.Default.tableBackgroundColor;
        public Color row1Color=Properties.Settings.Default.tablerow1Color;
        public Color row2Color = Properties.Settings.Default.tablerow1Color;
        String filename = Properties.Settings.Default.backgroundImage;

        public colorSchemeChooser()
        {
            InitializeComponent();

            this.MouseMove +=new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            datagrid.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            datagrid.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            this.ForeColor = Properties.Settings.Default.textColor;
            this.datagrid.BackgroundColor = Properties.Settings.Default.tableBackgroundColor;
            this.datagrid.GridColor = Properties.Settings.Default.tableGridColor;
            this.datagrid.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.datagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.datagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;


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
            datagrid.ForeColor = tabletextColor;
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


        private void backgroundImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            imageDialog.FilterIndex = 1;
            imageDialog.InitialDirectory = Application.StartupPath.ToString() + "\\Graphics\\";
            imageDialog.RestoreDirectory = false;

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                String filepath = System.IO.Path.GetFullPath(imageDialog.FileName);

                try
                {
                    this.BackgroundImage = Image.FromFile(imageDialog.FileName);
                    filename = filepath;
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("File not found");
                }
                catch (System.IO.IOException)
                {

                    MessageBox.Show("ERROR: IO Error");
                }
            }


        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.textColor = textColor;
            Properties.Settings.Default.tableTextColor = tabletextColor;
            Properties.Settings.Default.tableGridColor = tablegridColor;
            Properties.Settings.Default.tablerow1Color = row1Color;
            Properties.Settings.Default.tablerow2Color = row2Color;
            Properties.Settings.Default.tableBackgroundColor = tablebackgroundColor;
            Properties.Settings.Default.backgroundImage = filename;
            Properties.Settings.Default.Save();
        }

        private void restoreDefaultButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources._1287421014661;
            Properties.Settings.Default.backgroundImage = "";
            filename = "";
            Properties.Settings.Default.textColor = this.ForeColor = textColor = Color.White;
            Properties.Settings.Default.tableTextColor = datagrid.ForeColor = tabletextColor = Color.Black;
            Properties.Settings.Default.tableGridColor = datagrid.GridColor = tablegridColor = Color.LightGray;
            Properties.Settings.Default.tablerow1Color = datagrid.DefaultCellStyle.BackColor = row1Color = Color.White;
            Properties.Settings.Default.tablerow2Color = datagrid.AlternatingRowsDefaultCellStyle.BackColor = row2Color = Color.White;
            Properties.Settings.Default.tableBackgroundColor = datagrid.BackgroundColor = tablebackgroundColor = Color.DarkGray;
            Properties.Settings.Default.Save();
        }
    }
}

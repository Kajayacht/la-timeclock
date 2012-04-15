using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class EditJobs : UserControl
    {

            /*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
     */

        String filename = "";
        public EditJobs()
        {
            InitializeComponent();

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            jobnameTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobnameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            filenameTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            filenameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            startingpayTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            startingpayTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event); 

            jobsBox.DisplayMember = "getname";
            jobsBox.DataSource = Main.joblist;

            //!Decimal.TryParse(pay.Text, out a)
        }

        private void jobsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobnameTextbox.Text = jobsBox.Text;
            jobsBox.ValueMember = "getpay";
            startingpayTextbox.Text = jobsBox.SelectedValue.ToString();
            jobsBox.ValueMember = "getTipped";
            tippedBox.Checked = Boolean.Parse(jobsBox.SelectedValue.ToString());

            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT Filename FROM Jobs WHERE JID='"+jobsBox.Text+"'");
            filenameTextbox.Text=Main.reader["Filename"].ToString();
            filename = Main.reader["Filename"].ToString();
            jobPicturebox.ImageLocation = "Graphics\\" + filename;
            Main.myConnection.Close();
        }

        public Boolean validate()
        {
            Decimal a;
            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT * FROM Jobs WHERE JID='"+jobnameTextbox.Text+"'");
            Boolean hasrows = Main.reader.HasRows;
            Main.reader.Close();
            Main.myConnection.Close();

            if (hasrows && jobnameTextbox.Text != jobsBox.Text)
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
                return false;
            }
            else if (!Decimal.TryParse(startingpayTextbox.Text, out a))
            {
                MessageBox.Show("Invalid starting pay");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void refreshJobs()
        {
            Main.joblist = Main.maininstance.getJobs();
            jobsBox.DataSource = Main.joblist;
        }

        private void updateJob_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Main.maininstance.sqlCommand("UPDATE Jobs SET JID='" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "',JSPay='" + Decimal.Parse(startingpayTextbox.Text) + "',TippedJob='" + tippedBox.Checked + "', Filename='"+filename+"' WHERE JID='" + jobsBox.Text + "'");
                MessageBox.Show("Update successful");
                Log.writeLog(Main.eName + " updated job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + Decimal.Parse(startingpayTextbox.Text) + "\n Tipped Job= " + tippedBox.Checked+"\n Image= "+filename);
                refreshJobs();
            }
        }

        private void newJob_Click(object sender, EventArgs e)
        {
            if (jobsBox.Text != jobnameTextbox.Text)
            {
                if (validate())
                {
                    MessageBox.Show("Insert successful");
                    Main.maininstance.sqlCommand("INSERT INTO Jobs Values('" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + Decimal.Parse(startingpayTextbox.Text) + "','" + tippedBox.Checked + "','"+filename+"')");
                    Log.writeLog(Main.eName + " added job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + Decimal.Parse(startingpayTextbox.Text) + "\n Tipped Job= " + tippedBox.Checked);
                    refreshJobs();
                }
            }
            else
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
            }
        }

        private void deleteJob_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this job? All "+jobsBox.Text+" shifts will also be removed",
                    "Delete Job?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Main.maininstance.sqlCommand("DELETE FROM Jobs WHERE JID='" + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    Log.writeLog(Main.eName + " deleted job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                    refreshJobs();
                }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            imageDialog.FilterIndex = 1;
            imageDialog.InitialDirectory = Application.StartupPath.ToString()+ "\\Graphics\\";
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
                        filenameTextbox.Text = filename;
                        jobPicturebox.ImageLocation = "Graphics\\" + filename;
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        MessageBox.Show("File not found");
                    }
                    catch (System.IO.IOException)
                    {
                        if (System.IO.File.Exists("Graphics\\" + filename))
                        {
                            MessageBox.Show("A file by that name already exists in " + graphicsDirectory);
                        }
                        else
                        {
                            MessageBox.Show("IO Error");
                        }
                    }
                }
                else
                {
                    filenameTextbox.Text = filename;
                    jobPicturebox.ImageLocation = "Graphics\\" + filename;
                }
            }
        }
    }
}

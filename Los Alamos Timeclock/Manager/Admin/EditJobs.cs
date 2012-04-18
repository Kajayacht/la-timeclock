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

    /* Class to handle the creating, changing, and deleting of different jobs in the database */

    public partial class EditJobs : UserControl
    {
        String filename = "";
     
        /* Initialization of the class */
        public EditJobs()
        {
            InitializeComponent();

            //Load the background image
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //Event handlers to handle the idle logout function
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobsBox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            jobnameTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            jobnameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            filenameTextbox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            filenameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event);
            payChooser.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            payChooser.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event); 

            jobsBox.DisplayMember = "getname";
            jobsBox.DataSource = Main.joblist;

        }

        /* Method to get the information of the currently selected job */
        private void jobsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //populate the UI elements with the job info
            jobnameTextbox.Text = jobsBox.Text;
            jobsBox.ValueMember = "getpay";
            payChooser.Value = Decimal.Parse(jobsBox.SelectedValue.ToString());
            jobsBox.ValueMember = "getTipped";
            tippedBox.Checked = Boolean.Parse(jobsBox.SelectedValue.ToString());

            //Get the information from the database
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlReader("SELECT Filename FROM Jobs WHERE JID='" + jobsBox.Text + "'");
                filenameTextbox.Text = Main.reader["Filename"].ToString();
                filename = Main.reader["Filename"].ToString();
                jobPicturebox.ImageLocation = Properties.Settings.Default.jobImageFolderPath + "\\images\\" + filename;
                Main.myConnection.Close();
            }
            catch (Exception)
            {
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        /* Method to handle the validity of the job entered in */
        public Boolean validate()
        {
            //Get the job information stored on the database
            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT * FROM Jobs WHERE JID='"+jobnameTextbox.Text+"'");
            Boolean hasrows = Main.reader.HasRows;
            Main.reader.Close();
            Main.myConnection.Close();

            //If there's already a job with that name in the database
            if (hasrows && jobnameTextbox.Text != jobsBox.Text)
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
                return false;
            }
            else
            {
                return true;
            }
        }

        /* Method to reload the job info when the selected job is changed */
        public void refreshJobs()
        {
            Main.joblist = Main.maininstance.getJobs();
            jobsBox.DataSource = Main.joblist;
            jobsBox.DisplayMember = "getname";
        }

        /* Method to handle updating a job's information */
        private void updateJob_Click(object sender, EventArgs e)
        {
            //if valid information is given
            if (validate())
            {
                //Update the information in the database
                Main.maininstance.sqlCommand("UPDATE Jobs SET JID='" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "',JSPay='" + payChooser.Value + "',TippedJob='" + tippedBox.Checked + "', Filename='" + filename + "' WHERE JID='" + jobsBox.Text + "'");
                MessageBox.Show("Update successful");
                //Write change to the log file
                Log.writeLog(Main.eName + " updated job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + payChooser.Value + "\n Tipped Job= " + tippedBox.Checked + "\n Image= " + filename);
                refreshJobs();
            }
        }

        /* Method to handle adding a new job to the database */
        private void newJob_Click(object sender, EventArgs e)
        {
            if (jobsBox.Text != jobnameTextbox.Text)
            {
                //If valid information is given
                if (validate())
                {
                    //Create the new job info on the database
                    MessageBox.Show("Insert successful");
                    Main.maininstance.sqlCommand("INSERT INTO Jobs Values('" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + payChooser.Value + "','" + tippedBox.Checked + "','" + filename + "')");
                    //Write the change to the log file
                    Log.writeLog(Main.eName + " added job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + payChooser.Value + "\n Tipped Job= " + tippedBox.Checked);
                    refreshJobs();
                }
            }
            //If that job already exists
            else
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
            }
        }

        /* Method to handle removing a job from the database */
        private void deleteJob_Click(object sender, EventArgs e)
        {
            //Ask the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this job? All "+jobsBox.Text+" shifts will also be removed",
                    "Delete Job?", MessageBoxButtons.YesNo);

                //if yes
                if (result == DialogResult.Yes)
                {
                    //remove the job from the database
                    Main.maininstance.sqlCommand("DELETE FROM Jobs WHERE JID='" + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    //Write the change to the log file
                    Log.writeLog(Main.eName + " deleted job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                    refreshJobs();
                }
        }

        /* Method to handle selecting a job image for a job */
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            //Get the image file from the user
            OpenFileDialog imageDialog = new OpenFileDialog();
            //Only show standard image files by default
            imageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            imageDialog.FilterIndex = 1;
            imageDialog.InitialDirectory = Properties.Settings.Default.jobImageFolderPath + "\\images\\";
            imageDialog.RestoreDirectory = false;

            //When the user selects an image
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the file information
                filename = System.IO.Path.GetFileName(imageDialog.FileName);
                String filepath = System.IO.Path.GetFullPath(imageDialog.FileName);
                String directory = System.IO.Path.GetDirectoryName(imageDialog.FileName);

                //checks if the file is already in the directory
                if (directory.ToLower() != (Properties.Settings.Default.jobImageFolderPath + "\\images").ToLower())
                {
                    //Copy the file to the images directory
                    try
                    {                        
                        System.IO.File.Copy(filepath, Properties.Settings.Default.jobImageFolderPath + "\\images\\" + filename);
                        filenameTextbox.Text = filename;
                        jobPicturebox.ImageLocation = Properties.Settings.Default.jobImageFolderPath + "\\images\\" + filename;
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        MessageBox.Show("File not found");
                    }
                    catch (System.IO.IOException)
                    {
                        if (System.IO.File.Exists(Properties.Settings.Default.jobImageFolderPath + "\\images\\" + filename))
                        {
                            MessageBox.Show("A file by that name already exists in " + Properties.Settings.Default.jobImageFolderPath + "\\images\\");
                        }
                        else
                        {
                            MessageBox.Show("IO Error");
                        }
                    }
                }
                //Set the image for that job
                else
                {
                    filenameTextbox.Text = filename;
                    jobPicturebox.ImageLocation = Properties.Settings.Default.jobImageFolderPath + "\\images\\" + filename;
                }
            }
        }
    }
}

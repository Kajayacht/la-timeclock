using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Resources;
using Los_Alamos_Timeclock.Properties;

namespace Los_Alamos_Timeclock
{
    /*
     This file is part of Los Alamos Timeclock.

    Los Alamos Timeclock is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Los Alamos Timeclock is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Los Alamos Timeclock.  If not, see <http://www.gnu.org/licenses/>.
     */




    public partial class Clockinout : UserControl
    {
        public static Override o = new Override();

        public Boolean scheduled = false;
        DateTime startTime, endTime;
        string date;
        int n = 0;
        Boolean lunch = false;
        string job;
        string status;
        Boolean clockedIn = false;
        public MySqlCommand command;
        public Clockinout()
        {
            InitializeComponent();

            //events to reset the idle timer
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);


            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            try
            {
                //sets the welcome message
                welcome.Text = "Welcome " + Main.eName + "!";

                //checks if the employee is already clocked in
                Main.myConnection.Open();
                Main.maininstance.sqlReader("Select a.*,b.Filename From `Hours Worked` a JOIN Jobs b ON a.JID=b.JID WHERE ID='" + Main.id + "' AND Status!='OUT'");
                clockedIn = Main.reader.HasRows;
                if (clockedIn)
                {
                    //sets values to the shift the employee is clocked in for
                    job = Main.reader["JID"].ToString();
                    //sets the image
                    jobImage.ImageLocation = Properties.Settings.Default.jobImageFolderPath + "\\images\\" + Main.reader["Filename"].ToString();
                    
                    //checks to see what break the employee is currently on/can go on
                    if (Main.reader["B1in"].ToString() == "")
                    {
                        //break 1
                        n = 1;
                    }
                    else if (Main.reader["B2in"].ToString() == "")
                    {
                        //break 2
                        n = 2;
                    }

                    //checks to see if the employee's lunch hasn't been registered yet
                    if (Main.reader["Lout"].ToString() == "")
                    {
                        lunch = true;
                    }
                    //sets the values to the shift values
                    date = Main.reader["Date"].ToString();
                    date = DateTime.Parse(date).ToString("yyyy-MM-dd");
                    status = Main.reader["Status"].ToString();

                }
                else
                {
                    date = DateTime.Today.ToString("yyyy-MM-dd");
                }
                Main.reader.Close();

                //checks if the employee is scheduled and updates the information
                Main.maininstance.sqlReader("Select a.FName, b.Date, b.Start, b.End, b.JID, c.Filename from Employee a JOIN Schedule b ON a.ID=b.ID JOIN Jobs c ON c.JID=b.JID Where a.ID='" + Main.id + "' AND b.Date='" + date + "'");

                scheduled = Main.reader.HasRows;
                //scheduled
                if (Main.reader.HasRows)
                {
                    startTime = DateTime.ParseExact(Main.reader["Start"].ToString(), "HH:mm:ss", null);
                    endTime = DateTime.ParseExact(Main.reader["End"].ToString(), "HH:mm:ss", null);
                    if (!clockedIn)
                    {
                        job = Main.reader["JID"].ToString();
                        jobImage.ImageLocation = Properties.Settings.Default.jobImageFolderPath + "\\images\\" + Main.reader["Filename"].ToString();
                    }
                    if (startTime > endTime)
                    {
                        endTime = endTime.AddDays(1); //handles late shift length
                    }

                    Main.reader.Close();
                    Main.myConnection.Close();
                    shiftinfoLabel.Text =
                        "Today's Schedule:\n" +
                        "Start: " + startTime.ToString("hh:mm tt") + "\n" +
                        "End:  " + endTime.ToString("hh:mm tt") + "\n" +
                        "Job:  " + job + "\n" +
                        "Length: " + endTime.Subtract(startTime).ToString();
                }
                    //already clocked in
                else if (clockedIn)
                {
                    shiftinfoLabel.Text = 
                        "Today's Schedule:\n"+
                        "Job:  " + job;
                }
                    //not scheduled or clocked in
                else
                {
                    jobImage.Image = (Image)Resources.ResourceManager.GetObject("none");
                    shiftinfoLabel.Text =
                        "You are not Scheduled\n" +
                        "Please see a manager";
                    Main.myConnection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Main.myConnection.Close();
            }
            supdate();
        }

        //updates the status bar above the job image
        public void supdate()
        {
            if (status == "IN")
            {
                statusMessagebox.Text = "Clocked In";
                statusMessagebox.BackColor = Color.Green;
            }
            else if (status == "BREAK")
            {
                statusMessagebox.Text = "On Break";
                statusMessagebox.BackColor = Color.Yellow;
            }
            else if (status == "LUNCH")
            {
                statusMessagebox.Text = "On Lunch";
                statusMessagebox.BackColor = Color.Yellow;
            }
            else
            {
                statusMessagebox.Text = "Clocked Out";
                statusMessagebox.BackColor = Color.Red;
            }
        }

        //inital clockin for the employee
        private void clockin_Click(object sender, EventArgs e)
        {
            //if the employee is scheduled
            if (scheduled)
            {
                //if the employee's rounded time isn't equal to the current time, they are either late or early, if late then they need an override
                if (startTime == Main.roundtime(DateTime.Now) && status != "IN" && status != "BREAK" && status != "LUNCH")
                {
                    Main.maininstance.sqlCommand("INSERT INTO `Hours Worked` (`ID`, `Date`, `Start`, `JID`,`Status`) VALUES ('" + Main.id + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "' , '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + job + "', 'IN')");
                    status = "IN";
                    supdate();
                }
                else
                {
                    MessageBox.Show("Ring Restricted, contact manager");
                }
            }
            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }
        }

        //clock the employee in/out of a lunch
        private void Break_Click(object sender, EventArgs e)
        {


            if (status == "BREAK" && n > 0)
            {
                Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET B" + n + "in='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='IN' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                status = "IN";
                supdate();
                n = n + 1;
            }
            else if (status == "IN" && n > 0)
            {
                Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET B" + n + "out='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='BREAK' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                status = "BREAK";
                supdate();
            }

            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }
            n = n % 3;
        }

        //clock the employee in/out of a break
        private void Lunch_Click(object sender, EventArgs e)
        {
            if (status == "LUNCH")
            {
                Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET Lin='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='IN' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                status = "IN";
                supdate();
            }
            else if (status == "IN" && lunch)
            {
                Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET Lout='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='LUNCH' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                status = "LUNCH";
                supdate();
                lunch = false;
            }
            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }
        }
        private void Clockout_Click(object sender, EventArgs e)
        {
            if (status == "IN")
            {   
                //find out whether the job is tipped or not 
                Boolean tipped = false;
                try
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlReader("Select TippedJob From Jobs WHERE JID='" + job + "'");
                    tipped = Boolean.Parse(Main.reader["TippedJob"].ToString());
                }
                finally
                {
                    Main.myConnection.Close();
                }

                //if tipped job
                if (tipped == true)
                {
                    double temp;
                    //ask for tips gotten
                    string tips = Microsoft.VisualBasic.Interaction.InputBox("Enter the total Tips you received", "");                                        
                                                          

                    if (double.TryParse(tips, out temp) == true  )
                    {
                        //Check that the tips entered is only two decimal places
                        double doubletips = double.Parse(tips);
                        bool CountDecimalPlaces = doubletips * 100.0 == (int)(doubletips * 100);

                        if (CountDecimalPlaces == true)
                        {
                            //run update statement with the tips                
                            Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET End='" + DateTime.Now.ToString("HH:mm:ss") + "', Tips='" + tips + "', Status='OUT' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                            status = "OUT";
                            clockedIn = false;
                            supdate();
                        }
                        else
                        {
                            MessageBox.Show("Invalid input: Amount entered had more than 2 decimal places");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input");
                    }

                }
                //else do this one
                else if (tipped == false)
                {
                    Main.maininstance.sqlCommand("UPDATE `Hours Worked` SET End='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='OUT' WHERE ID='" + Main.id + "' AND Date='" + date + "'");
                    status = "OUT";
                    clockedIn = false;
                    supdate();
                }            
            }
            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }
        }

        //if the override is clicked, open an override window if the employee isn't clocked in
        private void Override_Click(object sender, EventArgs e)
        {
            if (clockedIn)
            {
                MessageBox.Show("Employee is already clocked in");
            }
            else
            {
                if (!o.Visible)
                {
                    o = new Override();
                    o.Show();
                }
                else
                {
                    o.BringToFront();
                }
            }
        }
    }
}

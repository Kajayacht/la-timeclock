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
    //Generic SQL commands
    //Start:    "INSERT INTO `teamchro_LATSQL`.`Hours Worked` (`ID`, `Date`, `Start`, `JID`) VALUES ('1', '2/13/2012', '3:00', 'Manager');"
    //Set end:  "Update `teamchro_LATSQL`.`Hours Worked` set `End`='7:00' where `ID`='1' and `Date`='2012-02-13' and `End` IS NULL"

    public partial class Clockinout : UserControl
    {
        public Boolean scheduled = false;
        DateTime start, end;
        string date;
        int n = 0;
        Boolean lunch = false;
        string job;
        string status;
        public MySqlCommand command;
        public Clockinout()
        {
            InitializeComponent();


            try
            {
                welcome.Text = "Welcome " + Main.EName + "!";

                Main.myConnection.Open();
                Main.maininstance.sqlreader("Select * From `Hours Worked` WHERE ID='" + Main.ID + "' AND Status!='OUT'");

                if (Main.reader.HasRows)
                {
                    if (Main.reader["B1in"].ToString() == "")
                    {
                        n = 1;
                    }
                    else if (Main.reader["B2in"].ToString() == "")
                    {
                        n = 2;
                    }

                    if (Main.reader["Lout"].ToString() == "")
                    {
                        lunch = true;
                    }

                    date = Main.reader["Date"].ToString();
                    date = DateTime.Parse(date).ToString("yyyy-MM-dd");
                    status = Main.reader["Status"].ToString();
                }
                else
                {
                    date = DateTime.Today.ToString("yyyy-MM-dd");
                }
                Main.reader.Close();
                Main.maininstance.sqlreader("Select Employee.FName, Schedule.Date, Schedule.Start, Schedule.End, Schedule.JID from Employee,Schedule Where Employee.ID='" + Main.ID + "' AND Employee.ID=Schedule.ID AND Schedule.Date='" + date + "'");

                scheduled = Main.reader.HasRows;

                if (Main.reader.HasRows)
                {
                    start = DateTime.ParseExact(Main.reader["Start"].ToString(), "HH:mm:ss", null);
                    end = DateTime.ParseExact(Main.reader["End"].ToString(), "HH:mm:ss", null);
                    job = Main.reader["JID"].ToString();

                    if (start > end)
                    {
                        end = end.AddDays(1); //handles late shift length
                    }


                    Main.reader.Close();
                    Main.myConnection.Close();
                    shiftinfo.Text =
                        "Today's Schedule:\n" +
                        "Start: " + start.ToString("hh:mm tt") + "\n" +
                        "End:  " + end.ToString("hh:mm tt") + "\n" +
                        "Job:  " + job + "\n" +
                        "Length: " + end.Subtract(start).ToString();
                    //sets message


                    jobimg.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(job);  //sets image to job image
                }
                else
                {
                    shiftinfo.Text =
                        "You are not Scheduled\n" +
                        "Please see a manager";
                    Main.reader.Close();
                    Main.myConnection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            supdate();
        }

        public void supdate()
        {
            if (status == "IN")
            {
                statusmessage.Text = "Clocked In";
                statusmessage.BackColor = Color.Green;
            }
            else if (status == "BREAK")
            {
                statusmessage.Text = "On Break";
                statusmessage.BackColor = Color.Yellow;
            }
            else if (status == "LUNCH")
            {
                statusmessage.Text = "On Lunch";
                statusmessage.BackColor = Color.Yellow;
            }
            else
            {
                statusmessage.Text = "Clocked Out";
                statusmessage.BackColor = Color.Red;
            }
        }

        public DateTime roundtime(DateTime t)
        {
            TimeSpan a = TimeSpan.ParseExact(t.ToString("HH:mm:ss"), "g", null);
            int q = 0;
            while (a.Minutes > 15)
            {
                a = a.Subtract(TimeSpan.FromMinutes(15));
                q++;
            }
            if (a.Minutes >= 8)
            {
                a = a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes((q * 15) + 15));
            }
            else
            {
                a = a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes(q * 15));
            }
            a = a.Subtract(TimeSpan.FromSeconds(a.Seconds));
            //return a;
            t = DateTime.ParseExact(a.ToString(), "HH:mm:ss", null);
            return t;
        }

        private void clockin_Click(object sender, EventArgs e)
        {
            if (scheduled)
            {
                if (start == roundtime(DateTime.Now) && status != "IN" && status != "BREAK" && status != "LUNCH")
                {
                    Main.maininstance.sqlinsert("INSERT INTO `Hours Worked` (`ID`, `Date`, `Start`, `JID`,`Status`) VALUES ('" + Main.ID + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "' , '" + roundtime(DateTime.Now).ToString("HH:mm:ss") + "', '" + job + "', 'IN')");
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

        private void Break_Click(object sender, EventArgs e)
        {


            if (status == "BREAK" && n > 0)
            {
                Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET B" + n + "in='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='IN' WHERE ID='" + Main.ID + "' AND Date='" + date + "'");
                status = "IN";
                supdate();
                n = n + 1;
            }
            else if (status == "IN" && n > 0)
            {
                Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET B" + n + "out='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='BREAK' WHERE ID='" + Main.ID + "' AND Date='" + date + "'");
                status = "BREAK";
                supdate();
            }

            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }
            n = n % 3;
        }


        private void Lunch_Click(object sender, EventArgs e)
        {
            if (status == "LUNCH")
            {
                Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET Lin='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='IN' WHERE ID='" + Main.ID + "' AND Date='" + date + "'");
                status = "IN";
                supdate();
            }
            else if (status == "IN" && lunch)
            {
                Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET Lout='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='LUNCH' WHERE ID='" + Main.ID + "' AND Date='" + date + "'");
                status = "LUNCH";
                supdate();
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
                Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET End='" + DateTime.Now.ToString("HH:mm:ss") + "', Status='OUT' WHERE ID='" + Main.ID + "' AND Date='" + date + "'");
                status = "OUT";
                supdate();
            }
            else
            {
                MessageBox.Show("Ring Restricted, contact manager");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void jobimg_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Clockinout_Load(object sender, EventArgs e)
        {

        }

    }
}

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
        DateTime start,end;
        string job;
        public MySqlCommand command;
        public Clockinout()
        {
            InitializeComponent();
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("Select Employee.FName, Schedule.Date, Schedule.Start, Schedule.End, Schedule.JID from Employee,Schedule Where Employee.ID='" + Main.ID + "' AND Employee.ID=Schedule.ID AND Schedule.Date='2012-02-13'");
                //command = new MySqlCommand("Select Employee.FName, Schedule.Date, Schedule.Start, Schedule.End, Schedule.JID from Employee,Schedule Where Employee.ID='"+Main.ID+"' AND Employee.ID=Schedule.ID AND Schedule.Date='2012-02-13'", Main.myConnection);//"Select * from `Schedule` Where `Date`='2012-02-13'", Main.myConnection);
                //Main.reader = command.ExecuteReader();
                //Main.reader.Read();
                if (scheduled = Main.reader.HasRows)
                {
                    start = DateTime.ParseExact(Main.reader["Start"].ToString(), "hh:mm:ss", null);
                    end = DateTime.ParseExact(Main.reader["End"].ToString(), "hh:mm:ss", null);
                    job = Main.reader["JID"].ToString();
                    welcome.Text = "Welcome " + Main.EName + "!";

                    Main.reader.Close();
                    Main.myConnection.Close();
                    shiftinfo.Text =
                        "Today's Schedule:\n" +
                        "Start: " + start.ToString("HH:mm tt") + "\n" +
                        "End:  " + end.ToString("HH:mm tt") + "\n" +
                        "Job:  " + job+"\n"+
                        "Length: "+end.Subtract(start).ToString();

                    jobimg.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(job);  //sets image to job image
                }
                else
                {
                    shiftinfo.Text =
                        "You are not Scheduled\n"+
                        "Please see a manager";
                    Main.reader.Close();
                    Main.myConnection.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public TimeSpan roundtime(TimeSpan a)
        {
            int q = 0;
            while (a.Minutes > 15)
            {
                a=a.Subtract(TimeSpan.FromMinutes(15));
                q++;
            }
            if (a.Minutes >= 8)
            {
                a=a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes((q*15)+15));
            }
            else
            {
                a = a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes(q * 15));
            }
            return a;
        }

        private void clockin_Click(object sender, EventArgs e)
        {
            //command inserts into mysql database, commented out so it doesn't flood the db
            //Main.maininstance.sqlinsert("INSERT INTO `teamchro_LATSQL`.`Hours Worked` (`ID`, `Date`, `Start`, `JID`) VALUES ('1', '2012-02-15', '4:00', 'Manager')");
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock
{
    //Generic SQL commands
    //Start:    "INSERT INTO `teamchro_LATSQL`.`Hours Worked` (`ID`, `Date`, `Start`, `JID`) VALUES ('1', '2/13/2012', '3:00', 'Manager');"
    //Set end:  "Update `teamchro_LATSQL`.`Hours Worked` set `End`='7:00' where `ID`='1' and `Date`='2012-02-13' and `End` IS NULL"

    public partial class Clockinout : UserControl
    {
        public Boolean scheduled = false;
        TimeSpan start,end;
        string job;
        public MySqlCommand command;
        public Clockinout()
        {
            InitializeComponent();
            command = new MySqlCommand("Select * from `Schedule` Where `Date`='2012-02-13'", Main.myConnection);
            Main.reader = command.ExecuteReader();
            Main.reader.Read();
            scheduled=Main.reader.HasRows;
            if (scheduled)
            {
                string[] split;
                split = Main.reader["Start"].ToString().Split(':');
                start = new TimeSpan(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), 0);
                split = Main.reader["End"].ToString().Split(':');
                end = new TimeSpan(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), 0);
                job = Main.reader["JID"].ToString();
                Main.reader.Close();
                sstart.Text = 
                    "Start: "+DateTime.ParseExact(start.ToString(),"HH:mm:ss",null).ToString("HH:mm tt")+"\n"+
                    "End:  "+DateTime.ParseExact(end.ToString(),"HH:mm:ss",null).ToString("HH:mm tt")+"\n"+
                    "Job:  "+job;
            }


        }

        private void clockin_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("INSERT INTO `teamchro_LATSQL`.`Hours Worked` (`ID`, `Date`, `Start`, `JID`) VALUES ('1', '2/13/2012', '3:00', 'Manager')");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

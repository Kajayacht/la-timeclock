using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class Paychecks : UserControl
    {
        public DateTime mon = DateTime.Now.Date;
        public DateTime sun;
        public Paychecks()
        {
            InitializeComponent();
            mon=getmon(mon);
            Week.Value = mon;
            sun = mon.AddDays(6);
            weeklabel.Text = "Pay for " + mon.ToShortDateString() + "-" + sun.ToShortDateString();
            calculate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Week.Value.DayOfWeek != DayOfWeek.Monday)
            {
                Week.Value=getmon(Week.Value.Date);
            }
            mon = Week.Value;
            sun = mon.AddDays(6);
            weeklabel.Text = "Pay for "+mon.ToShortDateString()+"-"+sun.ToShortDateString();
            calculate();
        }

        public DateTime getmon(DateTime a)
        {
            while (a.DayOfWeek != DayOfWeek.Monday)
            {
                a = a.AddDays(-1);
            }
            Grosspay.Text = "Pay:\n";
            return a;

        }

        public void calculate()
        {


            MySqlDataReader misc;
            string ID="";
            TimeSpan hours = TimeSpan.FromHours(0);
            TimeSpan Totalhours = TimeSpan.FromHours(0);
            Double hourlyrate = 0.00;
            Double pay  = 0.00;
            Double Totalpay = 0.00;
            Main.myConnection.Open();


            String c="SELECT * FROM `Hours Worked` WHERE Date>='"+mon.ToString("yyyy-MM-dd")+"' AND '"+sun.ToString("yyyy-MM-dd")+"' AND Status='OUT' ORDER BY ID";
            MySqlCommand command = new MySqlCommand(c, Main.myConnection);
            Main.reader = command.ExecuteReader();

            while(Main.reader.Read())
            {
                if (Main.reader["ID"].ToString() != ID)
                {
                    ID = Main.reader["ID"].ToString();
                    Totalhours = TimeSpan.FromHours(0);
                }
                if (Main.reader["Start"].ToString()!="" && Main.reader["End"].ToString() != "")
                {
                    hours = Main.maininstance.roundtime(DateTime.Parse(Main.reader["End"].ToString())).Subtract(Main.maininstance.roundtime(DateTime.Parse(Main.reader["Start"].ToString())));
                    
                    if (Main.reader["Lout"].ToString() != "" && Main.reader["Lin"].ToString() != "")
                    {
                        hours = hours.Subtract(roundtime(DateTime.Parse(Main.reader["Lin"].ToString()).Subtract(DateTime.Parse(Main.reader["Lout"].ToString()))));
                    }
                    
                    string d = "SELECT JPay FROM `Employee Jobs` WHERE ID='" + ID + "' AND JID='" + Main.reader["JID"].ToString() + "'";
                    MySqlCommand c2 = new MySqlCommand(d, Main.myConnection);
                    misc = command.ExecuteReader();//currently throws error, can't have 2 readers on 1 connection
                    misc.Read();
                    if (misc.HasRows)
                    {
                        hourlyrate = Double.Parse(Main.reader["JPay"].ToString());
                    }
                    else
                    {
                        misc.Close();
                        d = "SELECT JSPay FROM `Jobs` WHERE JID='" + Main.reader["JID"].ToString() + "'";
                        hourlyrate = Double.Parse(Main.reader["JSPay"].ToString());
                    }
                    misc.Close();

                    if (Totalhours.Hours > 40)
                    {
                        hourlyrate *= 1.5;
                        pay = hourlyrate*(hours.Hours + (hours.Minutes / 15 * .25));
                        Totalpay += pay;

                    }
                    else if (Totalhours.Add(hours).Hours > 40)
                    {
                        TimeSpan a = TimeSpan.FromHours(40);
                        a = a.Subtract(Totalhours);
                        hours = hours.Subtract(a);

                        pay = (hourlyrate * (a.Hours + (a.Minutes / 15 * .25))) + ((hourlyrate * 1.5) * (a.Hours + (a.Minutes / 15 * .25)));
                        Totalpay += pay;
                    }
                    else
                    {
                        pay = hourlyrate * (hours.Hours + (hours.Minutes / 15 * .25));
                        Totalpay += pay;
                    }

                    Totalhours = Totalhours.Add(hours);
                    hours = TimeSpan.FromHours(0);
                }




            }


            Main.myConnection.Close();
        }

        public TimeSpan roundtime(TimeSpan a)
        {
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

            return a;
        }
    }
}

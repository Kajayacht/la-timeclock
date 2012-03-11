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
            mon = getmon(mon);
            Week.Value = mon;
            sun = mon.AddDays(6);
            weeklabel.Text = "Pay for " + mon.ToShortDateString() + "-" + sun.ToShortDateString();
            calculate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Week.Value.DayOfWeek != DayOfWeek.Monday)
            {
                Week.Value = getmon(Week.Value.Date);
            }
            mon = Week.Value;
            sun = mon.AddDays(6);
            weeklabel.Text = "Pay for " + mon.ToShortDateString() + "-" + sun.ToShortDateString();
            calculate();
        }

        public DateTime getmon(DateTime a)
        {
            while (a.DayOfWeek != DayOfWeek.Monday)
            {
                a = a.AddDays(-1);
            }
            Pay.Text = "";
            return a;

        }

        public void calculate()
        {
            string ID = "";
            TimeSpan hours = TimeSpan.FromHours(0);
            //TimeSpan Totalhours = TimeSpan.FromHours(0);
            Double Totalhours = 0;
            Double hourlyrate = 0.00;
            Double pay = 0.00;
            Double Totalpay = 0.00;
            Main.myConnection.Open();


            String c = "SELECT d.LName, d.FName, d.MName, a.*,b.JSPay, c.JPay " +
            "FROM `Hours Worked` a " +
            "LEFT OUTER JOIN `Jobs` b " +
            "ON a.JID=b.JID "+
            "LEFT OUTER JOIN `Employee Jobs` c " +
            "ON b.JID=c.JID AND a.ID = c.ID " +
            "JOIN `Employee` d "+
            "ON a.ID=d.ID "+
            "WHERE a.Date>='" + mon.ToString("yyyy-MM-dd") +
            "' AND a.Date<='" + sun.ToString("yyyy-MM-dd") + 
            "' AND a.Status='OUT'"+
            "ORDER BY d.LName "+
            "LIMIT 0,1000";

            string output = "";
            MySqlCommand command = new MySqlCommand(c, Main.myConnection);
            Main.reader = command.ExecuteReader();

            while (Main.reader.Read())
            {
                if (Main.reader["ID"].ToString() != ID)
                {
                    if (ID != "")
                    {
                        output = output + "\tTotal Hours: \t" + Totalhours + "\n" +
                                          "\tGross Pay: \t$" + Totalpay + "\n\n";
                    }
                    ID = Main.reader["ID"].ToString();
                    output = output + Main.reader["LName"].ToString() + ", " + Main.reader["FName"].ToString()+" "+ Main.reader["MName"].ToString()+"\n";
                    Totalhours = 0;
                    Totalpay = 0.00;
                }
                if (Main.reader["Start"].ToString() != "" && Main.reader["End"].ToString() != "")
                {
                    hours = Main.maininstance.roundtime(DateTime.Parse(Main.reader["End"].ToString())).Subtract(Main.maininstance.roundtime(DateTime.Parse(Main.reader["Start"].ToString())));

                    if (Main.reader["Lout"].ToString() != "" && Main.reader["Lin"].ToString() != "")
                    {
                        hours = hours.Subtract(roundtime(DateTime.Parse(Main.reader["Lin"].ToString()).Subtract(DateTime.Parse(Main.reader["Lout"].ToString()))));
                    }


                    if (Main.reader["JPay"].ToString()=="")
                    {
                        hourlyrate = Double.Parse(Main.reader["JSPay"].ToString());
                    }
                    else
                    {
                        hourlyrate = Double.Parse(Main.reader["JPay"].ToString());
                    }

                    if (Totalhours > 40)
                    {
                        hourlyrate *= 1.5;
                        pay = hourlyrate * (hours.Hours + (hours.Minutes / 15 * .25));

                    }
                    else if (Totalhours + (hours.Hours + (hours.Minutes / 15) * .25) > 40)
                    {
                        TimeSpan a = TimeSpan.FromHours(40);
                        a = a.Subtract(TimeSpan.FromHours(Totalhours));
                        hours = hours.Subtract(a);
                        pay = (hourlyrate * (a.Hours + (a.Minutes / 15 * .25))) + ((hourlyrate * 1.5) * (a.Hours + (a.Minutes / 15 * .25)));
                        hours = hours.Add(a);
                    }
                    else
                    {
                        pay = hourlyrate * (hours.Hours + (hours.Minutes / 15 * .25));
                    }
                    Totalpay += pay;
                    pay = 0.00;
                    Totalhours = Totalhours+(hours.Hours+(hours.Minutes/15)*.25);
                    hours = TimeSpan.FromHours(0);
                }




            }
            if (ID != "")
            {
                output = output + "\tTotal Hours: \t" + Totalhours + "\n" +
                                  "\tGross Pay: \t$" + Totalpay + "\n\n";
            }
            ID = "";
            Pay.Text = output;


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

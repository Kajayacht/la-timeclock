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

    public partial class Paychecks : UserControl
    {
        public DateTime mon = DateTime.Now.Date;
        public DateTime sun;
        public Paychecks()
        {
            InitializeComponent();
            mon = getMonday(mon);
            weekCalander.Value = mon;
            sun = mon.AddDays(6);
            weekLabel.Text = "Pay for " + mon.ToShortDateString() + "-" + sun.ToShortDateString();
            calculatePay();
        }

        private void weekCalander_ValueChanged(object sender, EventArgs e)
        {
            if (weekCalander.Value.DayOfWeek != DayOfWeek.Monday)
            {
                weekCalander.Value = getMonday(weekCalander.Value.Date);
            }
            mon = weekCalander.Value;
            sun = mon.AddDays(6);
            weekLabel.Text = "Pay for " + mon.ToShortDateString() + "-" + sun.ToShortDateString();
            calculatePay();
        }

        public DateTime getMonday(DateTime a)
        {
            while (a.DayOfWeek != DayOfWeek.Monday)
            {
                a = a.AddDays(-1);
            }
            payTextbox.Text = "";
            return a;
        }

        public void calculatePay()
        {
            string id = "";
            TimeSpan hours = TimeSpan.FromHours(0);
            Double totalHours = 0;
            Double hourlyRate = 0.00;
            Double pay = 0.00;
            Double totalPay = 0.00;
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
                if (Main.reader["ID"].ToString() != id)
                {
                    if (id != "")
                    {
                        output = output + "\tTotal Hours: \t" + totalHours + "\n" +
                                          "\tGross Pay: \t$" + String.Format("{0:0.00}", Math.Round(totalPay, 2)) + "\n\n";
                    }
                    id = Main.reader["ID"].ToString();
                    output = output + Main.reader["LName"].ToString() + ", " + Main.reader["FName"].ToString()+" "+ Main.reader["MName"].ToString()+"\n";
                    totalHours = 0;
                    totalPay = 0.00;
                }
                if (Main.reader["Start"].ToString() != "" && Main.reader["End"].ToString() != "")
                {
                    if (Main.maininstance.roundtime(DateTime.Parse(Main.reader["End"].ToString())) < Main.maininstance.roundtime(DateTime.Parse(Main.reader["Start"].ToString())))
                    {
                        hours = Main.maininstance.roundtime(DateTime.Parse(Main.reader["End"].ToString())).AddHours(24).Subtract(Main.maininstance.roundtime(DateTime.Parse(Main.reader["Start"].ToString())));
                    }
                    else
                    {
                        hours = Main.maininstance.roundtime(DateTime.Parse(Main.reader["End"].ToString())).Subtract(Main.maininstance.roundtime(DateTime.Parse(Main.reader["Start"].ToString())));
                    }

                    if (Main.reader["Lout"].ToString() != "" && Main.reader["Lin"].ToString() != "")
                    {

                        if (Main.maininstance.roundtime(DateTime.Parse(Main.reader["Lin"].ToString())) < Main.maininstance.roundtime(DateTime.Parse(Main.reader["Lout"].ToString())))
                        {
                            hours = hours.Subtract(roundTime((DateTime.Parse(Main.reader["Lin"].ToString()).AddHours(24)).Subtract(DateTime.Parse(Main.reader["Lout"].ToString()))));
                        }
                        else
                        {
                            hours = hours.Subtract(roundTime(DateTime.Parse(Main.reader["Lin"].ToString()).Subtract(DateTime.Parse(Main.reader["Lout"].ToString()))));
                        }
                    }


                    if (Main.reader["JPay"].ToString()=="")
                    {
                        hourlyRate = Double.Parse(Main.reader["JSPay"].ToString());
                    }
                    else
                    {
                        hourlyRate = Double.Parse(Main.reader["JPay"].ToString());
                    }

                    if (totalHours > 40)
                    {
                        hourlyRate *= 1.5;
                        pay = hourlyRate * (hours.Hours + (hours.Minutes / 15 * .25));

                    }
                    else if (totalHours + (hours.Hours + (hours.Minutes / 15) * .25) > 40)
                    {
                        TimeSpan a = TimeSpan.FromHours(40);
                        a = a.Subtract(TimeSpan.FromHours(totalHours));
                        hours = hours.Subtract(a);
                        pay = (hourlyRate * (a.Hours + (a.Minutes / 15 * .25))) + ((hourlyRate * 1.5) * (a.Hours + (a.Minutes / 15 * .25)));
                        hours = hours.Add(a);
                    }
                    else
                    {
                        pay = hourlyRate * (hours.Hours + (hours.Minutes / 15 * .25));
                    }
                    totalPay += pay;
                    pay = 0.00;
                    totalHours = totalHours+(hours.Hours+(hours.Minutes/15)*.25);
                    hours = TimeSpan.FromHours(0);
                }
            }
            if (id != "")
            {
                output = output + "\tTotal Hours: \t" + totalHours + "\n" +
                                  "\tGross Pay: \t$" + String.Format("{0:0.00}", Math.Round(totalPay, 2)) + "\n\n";
            }
            id = "";
            payTextbox.Text = output;


            Main.myConnection.Close();
        }

        public TimeSpan roundTime(TimeSpan a)
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

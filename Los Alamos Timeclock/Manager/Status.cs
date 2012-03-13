using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock.Manager
{
    public partial class Status : UserControl
    {
        public string date = DateTime.Today.ToString("yyyy-MM-dd");
        public string ID = "";
        public Boolean scheduled = false;
        public Status()
        {
            InitializeComponent();
            calander.MaxDate = DateTime.Today;
            popdg();
            jobs.DisplayMember = "getname";
            jobs.DataSource = Main.Joblist;
            Employees.DisplayMember = "getname";
            Employees.ValueMember = "gid";
            Employees.DataSource = Main.EmployeeList;
            ID = Employees.SelectedValue.ToString();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            popdg();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT * FROM `Hours Worked` WHERE ID='" + ID + "' AND Date='" + date + "'");
                Boolean working = Main.reader.HasRows;
                Main.myConnection.Close();
                String _start = "'" + Start.Text + "'", b1_out, b1_in, b2_out, b2_in, l_out, l_in, _end;

                DateTime a;
                if (!DateTime.TryParse(b1out.Text, out a))
                {
                    b1_out = "NULL";
                }
                else
                {
                    b1_out = "'" + b1out.Text + "'";
                }
                if (!DateTime.TryParse(b1in.Text, out a))
                {
                    b1_in = "NULL";
                }
                else
                {
                    b1_in = "'" + b1in.Text + "'";
                }

                if (!DateTime.TryParse(b2out.Text, out a))
                {
                    b2_out = "NULL";
                }
                else
                {
                    b2_out = "'" + b2out.Text + "'";
                }
                if (!DateTime.TryParse(b2in.Text, out a))
                {
                    b2_in = "NULL";
                }
                else
                {
                    b2_in = "'" + b2in.Text + "'";
                }

                if (!DateTime.TryParse(lout.Text, out a))
                {
                    l_out = "NULL";
                }
                else
                {
                    l_out = "'" + lout.Text + "'";
                }
                if (!DateTime.TryParse(lin.Text, out a))
                {
                    l_in = "NULL";
                }
                else
                {
                    l_in = "'" + lin.Text + "'";
                }

                if (!DateTime.TryParse(End.Text, out a))
                {
                    _end = "NULL";
                }
                else
                {
                    _end = "'" + End.Text + "'";
                }

                string state = "'OUT'";

                if (_end == "NULL")
                {
                    if ((b1_out != "NULL" && b1_in == "NULL") || (b2_out != "NULL" && b2_in == "NULL"))
                    {
                        state = "'BREAK'";
                    }
                    else if (l_out != "NULL" && l_in == "NULL")
                    {
                        state = "'LUNCH'";
                    }
                    else
                    {
                        state = "'IN'";
                    }

                }


                if (working)
                {
                    Main.maininstance.sqlcommand("UPDATE `Hours Worked` "+
                                                "SET "+
                                                "Start=" + _start +", "+
                                                "End=" + _end + ", "+
                                                "B1out=" + b1_out + ", " +
                                                "B1in=" + b1_in + ", " +
                                                "B2out=" + b2_out + ", " +
                                                "B2in=" + b2_in + ", " +
                                                "Lout=" + l_out + ", " +
                                                "Lin=" + l_in + ", " +
                                                "JID='" + jobs.Text + "', "+
                                                "Status=" + state +" "+
                                                "WHERE Date='" + date + "' AND ID='" + ID + "'");
                    MessageBox.Show("Update Successful");
                    Log.writeLog(Main.EName + " changed the Hours Worked for " + Employees.Text + "\n Date= " + date + "\n Job= " + jobs.Text + "\n Start= " + Start.Text + "\n End= " + End.Text + "\n Break 1= " + b1out.Text + "-" + b1in.Text + "\n Break 2= " + b2out.Text + "-" + b2in.Text + "\n Lunch= " + lout.Text + "-" + lin.Text);
                }
                else
                {
                    Main.maininstance.sqlcommand("INSERT INTO `Hours Worked`(`ID` ,`Date` ,`Start` ,`End` ,`JID` ,`B1out` ,`B1in` ,`B2out` ,`B2in` ,`Lout` ,`Lin` ,`Status`)" +
                                                "VALUES('"+ID+"','"+date+"',"+_start+","+_end+",'"+jobs.Text+"',"+b1_out+","+b1_in+","+b2_out+","+b2_in+","+l_out+","+l_in+","+state+")");
                    MessageBox.Show("Insert Successful");
                    Log.writeLog(Main.EName + " inserted into the Hours Worked for " + Employees.Text + "\n Date= " + date + "\n Job= " + jobs.Text + "\n Start= " + Start.Text + "\n End= " + End.Text + "\n Break 1= " + b1out.Text + "-" + b1in.Text + "\n Break 2= " + b2out.Text + "-" + b2in.Text + "\n Lunch= " + lout.Text + "-" + lin.Text);
                }

                popdg();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = calander.Value.ToString("yyyy-MM-dd");
            popdg();
            Eupdate();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = Employees.SelectedValue.ToString();
            Eupdate();
        }

        public void Eupdate()
        {
            Main.myConnection.Open();
            Main.maininstance.sqlreader("Select * from `Hours Worked` where ID='" + ID + "' AND Date='" + date + "'");
            if (Main.reader.HasRows)
            {
                Start.Text = Main.reader["Start"].ToString();
                End.Text = Main.reader["End"].ToString();
                b1out.Text = Main.reader["B1out"].ToString();
                b1in.Text = Main.reader["B1in"].ToString();
                b2out.Text = Main.reader["B2out"].ToString();
                b2in.Text = Main.reader["B2in"].ToString();
                lout.Text = Main.reader["Lout"].ToString();
                lin.Text = Main.reader["Lin"].ToString();
            }
            else
            {
                Start.Text = "";
                End.Text = "";
                b1out.Text = "";
                b1in.Text = "";
                b2out.Text = "";
                b2in.Text = "";
                lout.Text = "";
                lin.Text = "";
                jobs.Text = "";
            }
            Main.reader.Close();
            Main.myConnection.Close();
        }

        public void popdg()
        {
            string query = "Select " +
                                "a.Date, " +
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status,a.JID As Job, a.Start ,b.Start As 'Scheduled Start',  " +
                                "a.B1out As 'B1 OUT', " +
                                "a.B1in As 'B1 IN', " +
                                "a.B2out As 'B2 OUT', " +
                                "a.B2in As 'B2 IN', " +
                                "a.Lout As 'L OUT', " +
                                "a.Lin As 'L IN', " +
                                "a.End, b.End AS 'Scheduled End'  " +
                            "FROM `Hours Worked` a " +
                                "LEFT JOIN Schedule b  " +
                                    "ON a.ID=b.ID AND a.Date=b.Date " +
                                "JOIN Employee c " +
                                    "ON c.ID=a.ID " +
                            "WHERE a.Date='" + date + "' " +
                            "UNION " +
                            "Select " +
                                "b.Date, " +
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status,a.JID As Job, a.Start ,b.Start As 'Scheduled Start', " +
                                "a.B1out As 'B1 OUT', " +
                                "a.B1in As 'B1 IN', " +
                                "a.B2out As 'B2 OUT', " +
                                "a.B2in As 'B2 IN', " +
                                "a.Lout As 'L OUT', " +
                                "a.Lin As 'L IN', " +
                                "a.End, b.End AS 'Scheduled End'  " +
                            "FROM `Hours Worked` a " +
                                "RIGHT JOIN Schedule b  " +
                                    "ON a.ID=b.ID AND a.Date=b.Date " +
                                "JOIN Employee c " +
                                    "ON c.ID=b.ID " +
                            "WHERE a.Date='" + date + "' " +
                            "UNION " +
                            "Select " +
                                "b.Date, " +
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status,a.JID As Job, a.Start ,b.Start As 'Scheduled Start', " +
                                "a.B1out As 'B1 OUT', " +
                                "a.B1in As 'B1 IN', " +
                                "a.B2out As 'B2 OUT', " +
                                "a.B2in As 'B2 IN', " +
                                "a.Lout As 'L OUT', " +
                                "a.Lin As 'L IN', " +
                                "a.End, b.End AS 'Scheduled End'  " +
                            "FROM `Hours Worked` a " +
                                "RIGHT JOIN Schedule b  " +
                                    "ON a.ID=b.ID AND a.Date=b.Date " +
                                "JOIN Employee c " +
                                    "ON c.ID=b.ID " +
                            "WHERE a.Status!='OUT'";

            try
            {
                Main.myConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                try
                {
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);

                    BindingSource bind = new BindingSource();
                    bind.DataSource = dataTable;
                    dg.DataSource = bind;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                Main.myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public Boolean validate()
        {
            DateTime a;

            if (!DateTime.TryParse(Start.Text, out a))
            {
                MessageBox.Show("Start Time not valid");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

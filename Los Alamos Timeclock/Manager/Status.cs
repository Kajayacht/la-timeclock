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
            jobsDropdownlist.DisplayMember = "getname";
            jobsDropdownlist.DataSource = Main.joblist;
            Employees.DisplayMember = "getname";
            Employees.ValueMember = "gid";
            Employees.DataSource = Main.employeeList;
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
                String _start = "'" + startTextbox.Text + "'", b1_out, b1_in, b2_out, b2_in, l_out, l_in, _end;

                DateTime a;
                if (!DateTime.TryParse(b1outTextbox.Text, out a))
                {
                    b1_out = "NULL";
                }
                else
                {
                    b1_out = "'" + b1outTextbox.Text + "'";
                }
                if (!DateTime.TryParse(b1inTextbox.Text, out a))
                {
                    b1_in = "NULL";
                }
                else
                {
                    b1_in = "'" + b1inTextbox.Text + "'";
                }

                if (!DateTime.TryParse(b2outTextbox.Text, out a))
                {
                    b2_out = "NULL";
                }
                else
                {
                    b2_out = "'" + b2outTextbox.Text + "'";
                }
                if (!DateTime.TryParse(b2inTextbox.Text, out a))
                {
                    b2_in = "NULL";
                }
                else
                {
                    b2_in = "'" + b2inTextbox.Text + "'";
                }

                if (!DateTime.TryParse(loutTextbox.Text, out a))
                {
                    l_out = "NULL";
                }
                else
                {
                    l_out = "'" + loutTextbox.Text + "'";
                }
                if (!DateTime.TryParse(linTextbox.Text, out a))
                {
                    l_in = "NULL";
                }
                else
                {
                    l_in = "'" + linTextbox.Text + "'";
                }

                if (!DateTime.TryParse(endTextbox.Text, out a))
                {
                    _end = "NULL";
                }
                else
                {
                    _end = "'" + endTextbox.Text + "'";
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
                                                "JID='" + jobsDropdownlist.Text + "', "+
                                                "Status=" + state +" "+
                                                "WHERE Date='" + date + "' AND ID='" + ID + "'");
                    MessageBox.Show("Update Successful");
                    Log.writeLog(Main.eName + " changed the Hours Worked for " + Employees.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + startTextbox.Text + "\n End= " + endTextbox.Text + "\n Break 1= " + b1outTextbox.Text + "-" + b1inTextbox.Text + "\n Break 2= " + b2outTextbox.Text + "-" + b2inTextbox.Text + "\n Lunch= " + loutTextbox.Text + "-" + linTextbox.Text);
                }
                else
                {
                    Main.maininstance.sqlcommand("INSERT INTO `Hours Worked`(`ID` ,`Date` ,`Start` ,`End` ,`JID` ,`B1out` ,`B1in` ,`B2out` ,`B2in` ,`Lout` ,`Lin` ,`Status`)" +
                                                "VALUES('"+ID+"','"+date+"',"+_start+","+_end+",'"+jobsDropdownlist.Text+"',"+b1_out+","+b1_in+","+b2_out+","+b2_in+","+l_out+","+l_in+","+state+")");
                    MessageBox.Show("Insert Successful");
                    Log.writeLog(Main.eName + " inserted into the Hours Worked for " + Employees.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + startTextbox.Text + "\n End= " + endTextbox.Text + "\n Break 1= " + b1outTextbox.Text + "-" + b1inTextbox.Text + "\n Break 2= " + b2outTextbox.Text + "-" + b2inTextbox.Text + "\n Lunch= " + loutTextbox.Text + "-" + linTextbox.Text);
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
                startTextbox.Text = Main.reader["Start"].ToString();
                endTextbox.Text = Main.reader["End"].ToString();
                b1outTextbox.Text = Main.reader["B1out"].ToString();
                b1inTextbox.Text = Main.reader["B1in"].ToString();
                b2outTextbox.Text = Main.reader["B2out"].ToString();
                b2inTextbox.Text = Main.reader["B2in"].ToString();
                loutTextbox.Text = Main.reader["Lout"].ToString();
                linTextbox.Text = Main.reader["Lin"].ToString();
            }
            else
            {
                startTextbox.Text = "";
                endTextbox.Text = "";
                b1outTextbox.Text = "";
                b1inTextbox.Text = "";
                b2outTextbox.Text = "";
                b2inTextbox.Text = "";
                loutTextbox.Text = "";
                linTextbox.Text = "";
                jobsDropdownlist.Text = "";
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
                                "a.B1out As 'Break 1 OUT', " +
                                "a.B1in As 'Break 1 IN', " +
                                "a.B2out As 'Break 2 OUT', " +
                                "a.B2in As 'Break 2 IN', " +
                                "a.Lout As 'Lunch OUT', " +
                                "a.Lin As 'Lunch IN', " +
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
                                "a.B1out As 'Break 1 OUT', " +
                                "a.B1in As 'Break 1 IN', " +
                                "a.B2out As 'Break 2 OUT', " +
                                "a.B2in As 'Break 2 IN', " +
                                "a.Lout As 'Lunch OUT', " +
                                "a.Lin As 'Lunch IN', " +
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
                                "a.B1out As 'Break 1 OUT', " +
                                "a.B1in As 'Break 1 IN', " +
                                "a.B2out As 'Break 2 OUT', " +
                                "a.B2in As 'Break 2 IN', " +
                                "a.Lout As 'Lunch OUT', " +
                                "a.Lin As 'Lunch IN', " +
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

            if (!DateTime.TryParse(startTextbox.Text, out a))
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

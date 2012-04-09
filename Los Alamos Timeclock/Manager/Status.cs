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
        public string id = "";
        public Boolean scheduled = false;
        public Status()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            datagrid.MouseMove +=new MouseEventHandler(Main.maininstance.notIdle_event);
            datagrid.KeyPress +=new KeyPressEventHandler(Main.maininstance.notIdle_event);

            calander.MaxDate = DateTime.Today;
            populateDatagrid();
            jobsDropdownlist.DisplayMember = "getname";
            jobsDropdownlist.DataSource = Main.joblist;
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
            if (Main.employeeList.Count > 0)
            {
                id = employeeDropdownlist.SelectedValue.ToString();
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            populateDatagrid();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                if (validate())
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlReader("SELECT * FROM `Hours Worked` WHERE ID='" + id + "' AND Date='" + date + "'");
                    Boolean working = Main.reader.HasRows;
                    Main.myConnection.Close();
                    String startTime = "'" + startTextbox.Text + "'", b1_Out, b1_In, b2_Out, b2_In, l_Out, l_In, endTime;

                    DateTime a;
                    if (!DateTime.TryParse(b1outTextbox.Text, out a))
                    {
                        b1_Out = "NULL";
                    }
                    else
                    {
                        b1_Out = "'" + b1outTextbox.Text + "'";
                    }
                    if (!DateTime.TryParse(b1inTextbox.Text, out a))
                    {
                        b1_In = "NULL";
                    }
                    else
                    {
                        b1_In = "'" + b1inTextbox.Text + "'";
                    }

                    if (!DateTime.TryParse(b2outTextbox.Text, out a))
                    {
                        b2_Out = "NULL";
                    }
                    else
                    {
                        b2_Out = "'" + b2outTextbox.Text + "'";
                    }
                    if (!DateTime.TryParse(b2inTextbox.Text, out a))
                    {
                        b2_In = "NULL";
                    }
                    else
                    {
                        b2_In = "'" + b2inTextbox.Text + "'";
                    }

                    if (!DateTime.TryParse(loutTextbox.Text, out a))
                    {
                        l_Out = "NULL";
                    }
                    else
                    {
                        l_Out = "'" + loutTextbox.Text + "'";
                    }
                    if (!DateTime.TryParse(linTextbox.Text, out a))
                    {
                        l_In = "NULL";
                    }
                    else
                    {
                        l_In = "'" + linTextbox.Text + "'";
                    }

                    if (!DateTime.TryParse(endTextbox.Text, out a))
                    {
                        endTime = "NULL";
                    }
                    else
                    {
                        endTime = "'" + endTextbox.Text + "'";
                    }

                    string state = "'OUT'";

                    if (endTime == "NULL")
                    {
                        if ((b1_Out != "NULL" && b1_In == "NULL") || (b2_Out != "NULL" && b2_In == "NULL"))
                        {
                            state = "'BREAK'";
                        }
                        else if (l_Out != "NULL" && l_In == "NULL")
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
                        Main.maininstance.sqlCommand("UPDATE `Hours Worked` " +
                                                    "SET " +
                                                    "Start=" + startTime + ", " +
                                                    "End=" + endTime + ", " +
                                                    "B1out=" + b1_Out + ", " +
                                                    "B1in=" + b1_In + ", " +
                                                    "B2out=" + b2_Out + ", " +
                                                    "B2in=" + b2_In + ", " +
                                                    "Lout=" + l_Out + ", " +
                                                    "Lin=" + l_In + ", " +
                                                    "JID='" + jobsDropdownlist.Text + "', " +
                                                    "Status=" + state + " " +
                                                    "WHERE Date='" + date + "' AND ID='" + id + "'");
                        MessageBox.Show("Update Successful");
                        Log.writeLog(Main.eName + " changed the Hours Worked for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + startTextbox.Text + "\n End= " + endTextbox.Text + "\n Break 1= " + b1outTextbox.Text + "-" + b1inTextbox.Text + "\n Break 2= " + b2outTextbox.Text + "-" + b2inTextbox.Text + "\n Lunch= " + loutTextbox.Text + "-" + linTextbox.Text);
                    }
                    else
                    {
                        Main.maininstance.sqlCommand("INSERT INTO `Hours Worked`(`ID` ,`Date` ,`Start` ,`End` ,`JID` ,`B1out` ,`B1in` ,`B2out` ,`B2in` ,`Lout` ,`Lin` ,`Status`)" +
                                                    "VALUES('" + id + "','" + date + "'," + startTime + "," + endTime + ",'" + jobsDropdownlist.Text + "'," + b1_Out + "," + b1_In + "," + b2_Out + "," + b2_In + "," + l_Out + "," + l_In + "," + state + ")");
                        MessageBox.Show("Insert Successful");
                        Log.writeLog(Main.eName + " inserted into the Hours Worked for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + startTextbox.Text + "\n End= " + endTextbox.Text + "\n Break 1= " + b1outTextbox.Text + "-" + b1inTextbox.Text + "\n Break 2= " + b2outTextbox.Text + "-" + b2inTextbox.Text + "\n Lunch= " + loutTextbox.Text + "-" + linTextbox.Text);
                    }

                    populateDatagrid();
                }
            }
        }

        private void calander_DateChanged(object sender, EventArgs e)
        {
            date = calander.Value.ToString("yyyy-MM-dd");
            populateDatagrid();
            employeeUpdate();

        }
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            employeeUpdate();
        }

        public void employeeUpdate()
        {
            Main.myConnection.Open();
            Main.maininstance.sqlReader("Select * from `Hours Worked` where ID='" + id + "' AND Date='" + date + "'");
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

        public void populateDatagrid()
        {
            string query = "Select " +
                                "a.Date, " +
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status,a.JID As Job, a.Tips as Tips, a.Start ,b.Start As 'Scheduled Start',  " +
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
                                "a.Status,a.JID As Job, a.Tips as Tips, a.Start ,b.Start As 'Scheduled Start', " +
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
                                "a.Status,a.JID As Job, a.Tips as Tips, a.Start ,b.Start As 'Scheduled Start', " +
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
                    datagrid.DataSource = bind;
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

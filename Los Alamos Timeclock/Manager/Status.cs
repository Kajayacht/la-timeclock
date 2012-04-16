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

    /*
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */


    public partial class Status : UserControl
    {
        public string date = DateTime.Today.ToString("yyyy-MM-dd");
        public string id = "";
        public Boolean scheduled = false, allEmpty = false;
        public Status()
        {
            InitializeComponent();

            this.datagrid.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.datagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.datagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;
            this.datagrid.GridColor = Properties.Settings.Default.tableGridColor;

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            datagrid.CellClick += new DataGridViewCellEventHandler(datagrid_Cellclick);
            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

            starttimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            starttimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            endtimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            endtimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            break1intimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            break1intimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            break1outtimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            break1outtimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            break2intimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            break2intimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            break2outtimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            break2outtimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            lunchintimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            lunchintimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            lunchouttimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            lunchouttimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            jobsDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            jobsDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);


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

                    if (allEmpty && working)
                    {
                        DialogResult answer = MessageBox.Show("Are you sure you wish to delete this shift?", "Delete Shift?", MessageBoxButtons.YesNo);

                        if (answer == DialogResult.Yes)
                        {
                            Main.maininstance.sqlCommand("DELETE FROM `Hours Worked` WHERE ID='" + id + "' AND Date='" + date + "'");
                            Log.writeLog(Main.eName + " deleted " + employeeDropdownlist.Text + "'s shift on " + date);
                        }
                    }
                    else
                    {


                        String startTime = "'" + starttimePicker.Value.TimeOfDay.ToString() + "'", b1_Out, b1_In, b2_Out, b2_In, l_Out, l_In, endTime,tips;


                        if (tipsTextbox.Value <= 0 ||tipsTextbox.Value.ToString()=="")
                        {
                            tips = "NULL";
                        }
                        else
                        {
                            tips = "'" + tipsTextbox.Value + "'";
                        }

                        if (break1outtimePicker.Value == DateTime.MinValue)
                        {
                            b1_Out = "NULL";
                            b1_In = "NULL";
                        }
                        else
                        {
                            b1_Out = "'" + break1outtimePicker.Value.TimeOfDay.ToString() + "'";

                            if (break1intimePicker.Value == DateTime.MinValue)
                            {
                                b1_In = "NULL";
                            }
                            else
                            {
                                b1_In = "'" + break1intimePicker.Value.TimeOfDay.ToString() + "'";
                            }
                        }

                        if (break2outtimePicker.Value == DateTime.MinValue)
                        {
                            b2_Out = "NULL";
                            b2_In = "NULL";
                        }
                        else
                        {
                            b2_Out = "'" + break2outtimePicker.Value.TimeOfDay.ToString() + "'";

                            if (break2intimePicker.Value == DateTime.MinValue)
                            {
                                b2_In = "NULL";
                            }
                            else
                            {
                                b2_In = "'" + break2intimePicker.Value.TimeOfDay.ToString() + "'";
                            }
                        }

                        if (lunchouttimePicker.Value == DateTime.MinValue)
                        {
                            l_Out = "NULL";
                            l_In = "NULL";
                        }
                        else
                        {
                            l_Out = "'" + lunchouttimePicker.Value.TimeOfDay.ToString() + "'";

                            if (lunchintimePicker.Value == DateTime.MinValue)
                            {
                                l_In = "NULL";
                            }
                            else
                            {
                                l_In = "'" + lunchintimePicker.Value.TimeOfDay.ToString() + "'";
                            }
                        }

                        if (endtimePicker.Value == DateTime.MinValue)
                        {
                            endTime = "NULL";
                        }
                        else
                        {
                            endTime = "'" + endtimePicker.Value.TimeOfDay.ToString() + "'";
                        }


                        //determines if the employee is in, on break, on lunch, or out
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
                                                        "Tips="+tips+", "+
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
                            Log.writeLog(Main.eName + " changed the Hours Worked for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + starttimePicker.Value.TimeOfDay.ToString() + "\n End= " + endtimePicker.Value.TimeOfDay.ToString() + "\n Break 1= " + break1outtimePicker.Value.TimeOfDay.ToString() + "-" + break1intimePicker.Value.TimeOfDay.ToString() + "\n Break 2= " + break2outtimePicker.Value.TimeOfDay.ToString() + "-" + break2intimePicker.Value.TimeOfDay.ToString() + "\n Lunch= " + lunchouttimePicker.Value.TimeOfDay.ToString() + "-" + lunchintimePicker.Value.TimeOfDay.ToString());
                        }
                        else
                        {
                            Main.maininstance.sqlCommand("INSERT INTO `Hours Worked`(`ID` ,`Date` ,`Start` ,`End` , `Tips` ,`JID` ,`B1out` ,`B1in` ,`B2out` ,`B2in` ,`Lout` ,`Lin` ,`Status`)" +
                                                        "VALUES('" + id + "','" + date + "'," + startTime + "," + endTime + ", "+ tips + " ,'" + jobsDropdownlist.Text + "'," + b1_Out + "," + b1_In + "," + b2_Out + "," + b2_In + "," + l_Out + "," + l_In + "," + state + ")");
                            MessageBox.Show("Insert Successful");
                            Log.writeLog(Main.eName + " inserted into the Hours Worked for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Job= " + jobsDropdownlist.Text + "\n Start= " + starttimePicker.Value.TimeOfDay.ToString() + "\n End= " + endtimePicker.Value.TimeOfDay.ToString() + "\n Break 1= " + break1outtimePicker.Value.TimeOfDay.ToString() + "-" + break1intimePicker.Value.TimeOfDay.ToString() + "\n Break 2= " + break2outtimePicker.Value.TimeOfDay.ToString() + "-" + break2intimePicker.Value.TimeOfDay.ToString() + "\n Lunch= " + lunchouttimePicker.Value.TimeOfDay.ToString() + "-" + lunchintimePicker.Value.TimeOfDay.ToString());
                        }
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


                DateTime parsedTime;
                starttimePicker.Value = DateTime.Parse(Main.reader["Start"].ToString());

                if (Main.reader["Tips"].ToString() != "")
                {
                    tipsTextbox.Value = Decimal.Parse(Main.reader["Tips"].ToString());
                }

                if (DateTime.TryParse(Main.reader["End"].ToString(), out parsedTime))
                {
                    endtimePicker.Value = parsedTime;
                }
                else
                {
                    endtimePicker.Value = DateTime.MinValue;
                }

                if (DateTime.TryParse(Main.reader["B1out"].ToString(), out parsedTime))
                {
                    break1outtimePicker.Value = parsedTime;

                    if (DateTime.TryParse(Main.reader["B1in"].ToString(), out parsedTime))
                    {
                        break1intimePicker.Value = parsedTime;
                    }
                    else
                    {
                        break1intimePicker.Value = DateTime.MinValue;
                    }

                }
                else
                {
                    break1outtimePicker.Value = DateTime.MinValue;
                    break1intimePicker.Value = DateTime.MinValue;
                }

                if (DateTime.TryParse(Main.reader["B2out"].ToString(), out parsedTime))
                {
                    break2outtimePicker.Value = parsedTime;

                    if (DateTime.TryParse(Main.reader["B2in"].ToString(), out parsedTime))
                    {
                        break2intimePicker.Value = parsedTime;
                    }
                    else
                    {
                        break2intimePicker.Value = DateTime.MinValue;
                    }
                }
                else
                {
                    break2outtimePicker.Value = DateTime.MinValue;
                    break2intimePicker.Value = DateTime.MinValue;
                }

                if (DateTime.TryParse(Main.reader["Lout"].ToString(), out parsedTime))
                {
                    lunchouttimePicker.Value = parsedTime;

                    if (DateTime.TryParse(Main.reader["Lin"].ToString(), out parsedTime))
                    {
                        lunchintimePicker.Value = parsedTime;
                    }
                    else
                    {
                        lunchintimePicker.Value = DateTime.MinValue;
                    }

                }
                else
                {
                    lunchouttimePicker.Value = DateTime.MinValue;
                    lunchintimePicker.Value = DateTime.MinValue;
                }
            }
            else
            {
                starttimePicker.Value = DateTime.MinValue;
                endtimePicker.Value = DateTime.MinValue;
                break1intimePicker.Value = DateTime.MinValue;
                break1outtimePicker.Value = DateTime.MinValue;
                break2intimePicker.Value = DateTime.MinValue;
                break2outtimePicker.Value = DateTime.MinValue;
                lunchintimePicker.Value = DateTime.MinValue;
                lunchouttimePicker.Value = DateTime.MinValue;
            }
            Main.reader.Close();
            Main.myConnection.Close();
        }

        public void populateDatagrid()
        {
            string query = "Select " +
                                "a.Date, " +
                                "CONCAT(c.LName, ', ',c.FName) AS Name, " +
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
                            "FROM `Hours Worked` a " +
                                "LEFT JOIN Schedule b  " +
                                    "ON a.ID=b.ID AND a.Date=b.Date " +
                                "JOIN Employee c " +
                                    "ON c.ID=a.ID " +
                            "WHERE a.Date='" + date + "' " +
                            "UNION " +
                            "Select " +
                                "b.Date, " +
                                "CONCAT(c.LName, ', ',c.FName) AS Name, " +
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
                            "FROM `Hours Worked` a " +
                                "RIGHT JOIN Schedule b  " +
                                    "ON a.ID=b.ID AND a.Date=b.Date " +
                                "JOIN Employee c " +
                                    "ON c.ID=b.ID " +
                            "WHERE a.Date='" + date + "' " +
                            "UNION " +
                            "Select " +
                                "b.Date, " +
                                "CONCAT(c.LName, ', ',c.FName) AS Name, " +
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
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


            if (starttimePicker.Value == DateTime.MinValue &&
                break1outtimePicker.Value == DateTime.MinValue &&
                break1intimePicker.Value == DateTime.MinValue &&
                break2outtimePicker.Value == DateTime.MinValue &&
                break2intimePicker.Value == DateTime.MinValue &&
                lunchintimePicker.Value == DateTime.MinValue &&
                lunchouttimePicker.Value == DateTime.MinValue &&
                endtimePicker.Value == DateTime.MinValue)
            {
                allEmpty = true;
                return true;
            }
            else
            {
                allEmpty = false;
            }

            if (starttimePicker.Value == DateTime.MinValue && !allEmpty)
            {
                MessageBox.Show("Cannot have a shift with an empty start time");
                return false;
            }
            else if (endtimePicker.Value != DateTime.MinValue && (
                (break1outtimePicker.Value != DateTime.MinValue && break1intimePicker.Value == DateTime.MinValue) ||
                (break2outtimePicker.Value != DateTime.MinValue && break2intimePicker.Value == DateTime.MinValue) ||
                (lunchouttimePicker.Value != DateTime.MinValue && lunchintimePicker.Value == DateTime.MinValue)
                ))
            {
                MessageBox.Show("Cannot have an open break/lunch in a finished shift");
                return false;
            }
            else if (
                !((break1outtimePicker.Value != DateTime.MinValue && break1intimePicker.Value == DateTime.MinValue) ^
                (break2outtimePicker.Value != DateTime.MinValue && break2intimePicker.Value == DateTime.MinValue) ^
                (lunchouttimePicker.Value != DateTime.MinValue && lunchintimePicker.Value == DateTime.MinValue))
                &&
                !((break1outtimePicker.Value != DateTime.MinValue && break1intimePicker.Value != DateTime.MinValue) &&
                (break2outtimePicker.Value != DateTime.MinValue && break2intimePicker.Value != DateTime.MinValue) &&
                (lunchouttimePicker.Value != DateTime.MinValue && lunchintimePicker.Value != DateTime.MinValue)) 
                ||
                ((break1outtimePicker.Value != DateTime.MinValue && break1intimePicker.Value == DateTime.MinValue) &&
                (break2outtimePicker.Value != DateTime.MinValue && break2intimePicker.Value == DateTime.MinValue) &&
                (lunchouttimePicker.Value != DateTime.MinValue && lunchintimePicker.Value == DateTime.MinValue))
                )
            {
                MessageBox.Show("Cannot have more than 1 break/lunch open at a time");
                return false;
            }
            else if ((break1outtimePicker.Value == DateTime.MinValue &&
                break1intimePicker.Value != DateTime.MinValue) ||
                (break2outtimePicker.Value == DateTime.MinValue &&
                break2intimePicker.Value != DateTime.MinValue) ||
                (lunchouttimePicker.Value == DateTime.MinValue &&
                lunchintimePicker.Value != DateTime.MinValue))
            {
                MessageBox.Show("Cannot have a break/lunch end without a start");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void datagrid_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                calander.Value = DateTime.Parse(datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                employeeDropdownlist.Text = datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeUpdate();
            }
        }
    }
}

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

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class Makesched : UserControl
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

        DateTime mon, sun;
        String date = DateTime.Today.ToString("yyyy-MM-dd");
        String ID = "0";
        Boolean scheduled = false;
        DateTime lastDay;
        TimeSpan length = TimeSpan.FromMinutes(0);
        Boolean terminated = false;
        Boolean del = false;
        public static Overview l = new Overview();

        public Makesched()
        {
            InitializeComponent();

            //sets the datagrid's style to what is set in the program settings
            this.datagrid.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.datagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.datagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;
            this.datagrid.GridColor = Properties.Settings.Default.tableGridColor;



            //tries to set the background, otherwise uses default
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //events that reset the idle timer
            datagrid.CellClick += new DataGridViewCellEventHandler(datagrid_Cellclick);
            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            datagrid.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            datagrid.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            starttimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            starttimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            endtimePicker.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            endtimePicker.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            jobsDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            jobsDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

            //finds what day is monday, so it knows what timeframe to show (Monday-Sunday)
            mon = getmon(DateTime.Today.Date);
            sun = mon.AddDays(6);
            calander.MaxDate = DateTime.Today.AddYears(1);
            //initialize the datagrid, jobsdropdownlist, and employeedropdownlist
            populateDatagrid();
            jobsDropdownlist.DisplayMember = "getname";
            jobsDropdownlist.DataSource = Main.joblist;
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
        }

        //inserts/updates records
        private void update_Click(object sender, EventArgs e)
        {
            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                if (terminated && lastDay < DateTime.Parse(date))
                {
                    MessageBox.Show("Cannot schedule " + employeeDropdownlist.Text + " on " + DateTime.Parse(date).ToShortDateString() + ", employee's last day is " + lastDay.ToShortDateString());
                }
                else
                {
                    if (validate())
                    {
                        //if the employee is scheduled, update, otherwise insert
                        if (scheduled)
                        {
                            Main.maininstance.sqlCommand("UPDATE Schedule SET Start='" + starttimePicker.Value.TimeOfDay.ToString() + "', End='" + endtimePicker.Value.TimeOfDay.ToString() + "', JID='" + jobsDropdownlist.Text + "' WHERE Date='" + date + "' AND ID='" + ID + "'");
                            MessageBox.Show("Record Updated");
                        }
                        else
                        {
                            Main.maininstance.sqlCommand("INSERT INTO Schedule (`ID`, `Date`, `Start`, `End`, `JID`) VALUES ('" + ID + "', '" + date + "', '" + starttimePicker.Value.TimeOfDay.ToString() + "', '" + endtimePicker.Value.TimeOfDay.ToString() + "', '" + jobsDropdownlist.Text + "')");
                            scheduled = true;
                            MessageBox.Show("Record Inserted");
                        }
                        Log.writeLog(Main.eName + " changed the schedule for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Start= " + starttimePicker.Value.TimeOfDay.ToString() + "\n End= " + endtimePicker.Value.TimeOfDay.ToString() + "\n Job= " + jobsDropdownlist.Text);
                        populateDatagrid();
                    }
                }
            }
        }

        //delete record if one exists
        private void delete_Click(object sender, EventArgs e)
        {

            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                del = true;
                if (validate())
                {
                    if (scheduled)
                    {
                        Main.maininstance.sqlCommand("DELETE FROM Schedule WHERE ID='" + ID + "' AND Date='" + date + "'");
                        Log.writeLog(Main.eName + " deleted " + employeeDropdownlist.Text + " from the schedule for: " + "\n Date= " + date + "\n Start= " + starttimePicker.Value.TimeOfDay.ToString() + "\n End= " + endtimePicker.Value.TimeOfDay.ToString() + "\n Job= " + jobsDropdownlist.Text);
                        scheduled = false;
                        MessageBox.Show("Record deleted");
                    }
                    else
                    {
                        MessageBox.Show("No record to delete");
                    }
                    populateDatagrid();
                }
            }
        }

        //updates the table if the week is different after the date changed
        private void calander_DateChanged(object sender, EventArgs e)
        {
            date = calander.Value.ToString("yyyy-MM-dd");

            //checks if it needs to get next week
            if (calander.Value > mon.AddDays(6) || calander.Value < mon)
            {
                mon = getmon(calander.Value);
                sun = mon.AddDays(6);
                populateDatagrid();
            }
            employeeUpdate();
        }

        //updates the id when the selected Employee changes
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = employeeDropdownlist.SelectedValue.ToString();
            employeeUpdate();
        }

        //checks to see if the employee is scheduled on the selected day, if they are update the fields
        private void employeeUpdate()
        {
            scheduled = false;

            try
            {
                Main.myConnection.Open();
                //check if the selected employee is scheduled on the selected date
                Main.maininstance.sqlReader("Select a.*, b.EDate from Schedule a JOIN Employee b ON a.ID=b.ID where a.ID='" + ID + "' AND a.Date='" + date + "'");

                if (Main.reader.HasRows)
                {
                    if (Main.reader["EDate"].ToString() != "")
                    {
                        //if the employee has a last date, they are registered as terminated, and cannnot be scheduled after their last day
                        terminated = true;
                        lastDay = DateTime.Parse(Main.reader["EDate"].ToString());
                    }
                    else
                    {
                        terminated = false;
                    }

                    scheduled = true;
                    //change the update button's text to update instead of insert
                    updatescheduleButon.Text = "Update";

                    //sets the datetimepicker's values to the values of the database
                    DateTime b = DateTime.Parse(Main.reader["Start"].ToString());
                    starttimePicker.Value = b;

                    TimeSpan a = TimeSpan.Parse(Main.reader["End"].ToString());

                    b = DateTime.Parse(Main.reader["End"].ToString());
                    endtimePicker.Value = b;

                    jobsDropdownlist.Text = Main.reader["JID"].ToString();
                }
                else
                {
                    scheduled = false;
                    updatescheduleButon.Text = "Insert";
                    starttimePicker.Value = DateTime.Today;
                    endtimePicker.Value = DateTime.Today;
                }
                changeLength();
                Main.myConnection.Close();
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        //method to fill the datagrid
        private void populateDatagrid()
        {
            //gets all scheduled shifts in the selected week
            String query = "SELECT Date, CONCAT(LName, ', ',FName) AS Name, DATE_FORMAT(Start, '%h:%i %p' ) as Start, DATE_FORMAT(End, '%h:%i %p' ) as End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";

            try
            {
                Main.myConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                datagrid.DataSource = bind;

                Main.myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Failed to retrieve table information from the database");
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        //method to update the shift lenght it shows the user
        private void changeLength()
        {
            DateTime s = starttimePicker.Value;
            DateTime e = endtimePicker.Value;
            //if the end time is less than the start time, it assumes the end is past midnight and adds another day to the end time
            if (e < s)
            {
                e = e.AddDays(1);
            }
            length = e.Subtract(s);
            lengthLabel.Text = "Length: " + length.ToString();
        }

        //method to validate the form has acceptable inputs
        private Boolean validate()
        {

            if (jobsDropdownlist.Text == "")
            {
                MessageBox.Show("Job cannot be blank");
                return false;
            }
            else if (length > TimeSpan.FromHours(8).Add(TimeSpan.FromMinutes(30)) && !del)
            {
                DialogResult answer = MessageBox.Show("Shift is length is " + length.ToString() + ", are you sure?", "Confirm Long Shift", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                del = false;
                return true;
            }
        }

        //method to get the last monday, so the program knows when the week begins/ends
        private DateTime getmon(DateTime a)
        {
            while (a.DayOfWeek != DayOfWeek.Monday)
            {
                a = a.AddDays(-1);
            }
            return a;
        }

        //Method to show the overview so the user can look at requests, previous schedule, hours worked, and employee notes
        private void showRequests_Click(object sender, EventArgs e)
        {
            if (!l.Visible)
            {
                l = new Overview();
                l.Show();
            }
            else
            {
                l.BringToFront();
            }
        }

        //when the datagrid is clicked it updates the fields to the information stored in that field
        private void datagrid_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                calander.Value = DateTime.Parse(datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                employeeDropdownlist.Text = datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeUpdate();
            }
        }

        //methods to update the shown length and round the start/end time to the nearest 15 min
        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            starttimePicker.Value = Main.roundtime(starttimePicker.Value);
            changeLength();
        }

        private void endtimePicker_ValueChanged(object sender, EventArgs e)
        {
            endtimePicker.Value = Main.roundtime(endtimePicker.Value);
            changeLength();
        }
    }
}

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

            starttimePicker.ShowUpDown = true;
            endtimePicker.ShowUpDown = true;

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

            mon = getmon(DateTime.Today.Date);
            sun = mon.AddDays(6);
            calander.MaxDate = DateTime.Today.AddYears(1);
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

        private void delete_Click(object sender, EventArgs e)
        {
            //delete record if one exists
            
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
        public void employeeUpdate()
        {
            scheduled = false;

            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlReader("Select a.*, b.EDate from Schedule a JOIN Employee b ON a.ID=b.ID where a.ID='" + ID + "' AND a.Date='" + date + "'");


                if (Main.reader.HasRows)
                {
                    if (Main.reader["EDate"].ToString() != "")
                    {
                        terminated = true;
                        lastDay = DateTime.Parse(Main.reader["EDate"].ToString());
                    }
                    else
                    {
                        terminated = false;
                    }

                    scheduled = true;
                    updatescheduleButon.Text = "Update";


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
                clength();
                Main.reader.Close();
                Main.myConnection.Close();
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        public void populateDatagrid()
        {
            String query = "SELECT Date, CONCAT(LName, ', ',FName) AS Name, DATE_FORMAT(Start, '%h:%i %p' ) as Start, DATE_FORMAT(End, '%h:%i %p' ) as End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
                
            
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
            finally
            {
                Main.myConnection.Close();
            }
        }

        public void clength()
        {

                    DateTime s = starttimePicker.Value;
                    DateTime e = endtimePicker.Value;
                    if (e < s)
                    {
                        e=e.AddDays(1);
                    }
                    length = e.Subtract(s);
                    lengthLabel.Text = "Length: "+length.ToString();

        }

        public Boolean validate()
        {

            if (jobsDropdownlist.Text=="")
            {
                MessageBox.Show("Job cannot be blank");
                return false;
            }
            else if(length>TimeSpan.FromHours(8).Add(TimeSpan.FromMinutes(30))&&!del)
            {
                DialogResult answer= MessageBox.Show("Shift is length is " + length.ToString() + ", are you sure?", "Confirm Long Shift", MessageBoxButtons.YesNo);

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

        public DateTime getmon(DateTime a)
        {
            while (a.DayOfWeek != DayOfWeek.Monday)
            {
                a = a.AddDays(-1);
            }
            return a;
        }

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

        private void datagrid_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                calander.Value = DateTime.Parse(datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                employeeDropdownlist.Text = datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeUpdate();
            }
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            starttimePicker.Value = Main.roundtime(starttimePicker.Value);
            clength();
        }

        private void endtimePicker_ValueChanged(object sender, EventArgs e)
        {
            endtimePicker.Value = Main.roundtime(endtimePicker.Value);
            clength();
        }
    }
}

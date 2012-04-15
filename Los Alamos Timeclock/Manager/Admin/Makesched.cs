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
        Boolean terminated = false;
        public static Overview l = new Overview();

        public Makesched()
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
            datagrid.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            datagrid.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            startHourDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            startHourDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            startMinDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            startMinDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            endHourDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            endHourDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            endMinDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            endMinDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
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
                        if (scheduled)
                        {
                            Main.maininstance.sqlCommand("UPDATE Schedule SET Start='" + startHourDropdownlist.Text + ":" + startMinDropdownlist.Text + "', End='" + endHourDropdownlist.Text + ":" + endMinDropdownlist.Text + "', JID='" + jobsDropdownlist.Text + "' WHERE Date='" + date + "' AND ID='" + ID + "'");
                        }
                        else
                        {
                            Main.maininstance.sqlCommand("INSERT INTO Schedule (`ID`, `Date`, `Start`, `End`, `JID`) VALUES ('" + ID + "', '" + date + "', '" + startHourDropdownlist.Text + ":" + startMinDropdownlist.Text + "', '" + endHourDropdownlist.Text + ":" + endMinDropdownlist.Text + "', '" + jobsDropdownlist.Text + "')");
                            scheduled = true;
                        }
                        Log.writeLog(Main.eName + " changed the schedule for " + employeeDropdownlist.Text + "\n Date= " + date + "\n Start= " + startHourDropdownlist.Text + ":" + startMinDropdownlist.Text + "\n End= " + endHourDropdownlist.Text + ":" + endMinDropdownlist.Text + "\n Job= " + jobsDropdownlist.Text);
                        populateDatagrid();
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                if (validate())
                {
                    if (scheduled)
                    {
                        Main.maininstance.sqlCommand("DELETE FROM Schedule WHERE ID='" + ID + "' AND Date='" + date + "'");
                        Log.writeLog(Main.eName + " deleted " + employeeDropdownlist.Text + " from the schedule for: " + "\n Date= " + date + "\n Start= " + startHourDropdownlist.Text + ":" + startMinDropdownlist.Text + "\n End= " + endHourDropdownlist.Text + ":" + endMinDropdownlist.Text + "\n Job= " + jobsDropdownlist.Text);
                        scheduled = false;
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

            if (calander.Value > mon.AddDays(6) || calander.Value < mon)
            {
                mon = getmon(calander.Value);
                sun = mon.AddDays(6);
                populateDatagrid();
            }
            employeeUpdate();
        }
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = employeeDropdownlist.SelectedValue.ToString();
            employeeUpdate();
        }

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
                    TimeSpan a = TimeSpan.Parse(Main.reader["Start"].ToString());
                    startHourDropdownlist.Text = a.Hours.ToString();

                    if (a.Minutes == 0)
                    {
                        startMinDropdownlist.Text = "00";
                    }
                    else
                    {
                        startMinDropdownlist.Text = a.Minutes.ToString();
                    }
                    a = TimeSpan.Parse(Main.reader["End"].ToString());
                    endHourDropdownlist.Text = a.Hours.ToString();
                    if (a.Minutes == 0)
                    {
                        endMinDropdownlist.Text = "00";
                    }
                    else
                    {
                        endMinDropdownlist.Text = a.Minutes.ToString();
                    }
                    jobsDropdownlist.Text = Main.reader["JID"].ToString();
                }
                else
                {
                    scheduled = false;
                    startHourDropdownlist.Text = "";
                    startMinDropdownlist.Text = "";
                    endHourDropdownlist.Text = "";
                    endMinDropdownlist.Text = "";
                    jobsDropdownlist.Text = "";
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
            String query = "SELECT Date, CONCAT(LName, ', ',FName) AS Name, Start, End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
                
            
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
            if (startHourDropdownlist.Text == "" || startMinDropdownlist.Text == "" || endHourDropdownlist.Text == "" || endMinDropdownlist.Text == "" || jobsDropdownlist.Text == "")
            {
                lengthLabel.Text = "";
            }
            else
            {
                try
                {
                    DateTime s = DateTime.Parse(startHourDropdownlist.Text + ":" + startMinDropdownlist.Text);
                    DateTime e = DateTime.Parse(endHourDropdownlist.Text + ":" + endMinDropdownlist.Text);
                    if (e < s)
                    {
                        e=e.AddDays(1);
                    }
                    lengthLabel.Text = "Length: "+e.Subtract(s).ToString();
                }
                catch
                {
                }

            }

        }

        public Boolean validate()
        {

            if (startHourDropdownlist.Text == "" || startMinDropdownlist.Text == "" || endHourDropdownlist.Text == "" || endMinDropdownlist.Text == ""||jobsDropdownlist.Text=="")
            {
                MessageBox.Show("Fill in all fields");
                return false;
            }
            else if (int.Parse(startHourDropdownlist.Text) > 23 || int.Parse(startHourDropdownlist.Text) < 0)
            {
                MessageBox.Show("Start hour not valid");
                return false;
            }
            else if (int.Parse(startMinDropdownlist.Text) != 0 && int.Parse(startMinDropdownlist.Text) != 15 && int.Parse(startMinDropdownlist.Text) != 30 && int.Parse(startMinDropdownlist.Text) != 45)
            {
                MessageBox.Show("End minutes not valid");
                return false;
            }
            else if (int.Parse(endHourDropdownlist.Text) > 23 || int.Parse(endHourDropdownlist.Text) < 0)
            {
                MessageBox.Show("End hour not valid");
                return false;
            }
            else if (int.Parse(endMinDropdownlist.Text) != 0 && int.Parse(endMinDropdownlist.Text) != 15 && int.Parse(endMinDropdownlist.Text) != 30 && int.Parse(endMinDropdownlist.Text) != 45)
            {
                MessageBox.Show("End minutes not valid");
                return false;
            }
            else
            {
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

        private void startHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void startMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void endHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void endMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
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
    }
}

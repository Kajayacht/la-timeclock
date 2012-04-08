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
        DateTime mon, sun;
        String date = DateTime.Today.ToString("yyyy-MM-dd");
        String ID = "0";
        Boolean scheduled = false;
        DateTime lastDay;
        Boolean terminated = false;


        public Makesched()
        {
            InitializeComponent();
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
            mon = getmon(calander.Value);
            sun = mon.AddDays(6);
            populateDatagrid();
            employeeUpdate();
        }
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = employeeDropdownlist.SelectedValue.ToString();
            employeeUpdate();
        }

        public void employeeUpdate()
        {
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }

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
                startMinDropdownlist.Text = a.Minutes.ToString();
                a = TimeSpan.Parse(Main.reader["End"].ToString());
                endHourDropdownlist.Text = a.Hours.ToString();
                endMinDropdownlist.Text = a.Minutes.ToString();
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

        public void populateDatagrid()
        {

            string query = "SELECT Date, CONCAT(LName, ', ',FName,' ',MName) AS Name, Start, End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
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
            Overview l=new Overview();
            l.Show();
        }
    }
}

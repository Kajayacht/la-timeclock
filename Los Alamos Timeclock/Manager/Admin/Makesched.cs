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
        public string date = DateTime.Today.ToString("yyyy-MM-dd");
        public string ID = "0";
        public Boolean scheduled = false;
        public Makesched()
        {
            InitializeComponent();
            mon = getmon(DateTime.Today.Date);
            sun = mon.AddDays(6);
            calander.MaxDate = DateTime.Today.AddYears(1);
            popdg();
            jobs.DisplayMember = "getname";
            jobs.DataSource = Main.joblist;
            comboBox1.DisplayMember = "getname";
            comboBox1.ValueMember = "gid";
            comboBox1.DataSource = Main.employeeList;
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            popdg();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (scheduled)
                {
                    Main.maininstance.sqlcommand("UPDATE Schedule SET Start='" + sh.Text + ":" + sm.Text + "', End='" + eh.Text + ":" + em.Text + "', JID='" + jobs.Text + "' WHERE Date='" + date + "' AND ID='" + ID + "'");
                }
                else
                {
                    Main.maininstance.sqlcommand("INSERT INTO Schedule (`ID`, `Date`, `Start`, `End`, `JID`) VALUES ('" + ID + "', '" + date + "', '" + sh.Text + ":" + sm.Text + "', '" + eh.Text + ":" + em.Text + "', '" + jobs.Text + "')");
                    scheduled = true;
                }
                Log.writeLog(Main.eName + " changed the schedule for " + comboBox1.Text + "\n Date= " + date + "\n Start= " + sh.Text + ":" + sm.Text + "\n End= " + eh.Text + ":" + em.Text + "\n Job= " + jobs.Text);
                popdg();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (scheduled)
                {
                    Main.maininstance.sqlcommand("DELETE FROM Schedule WHERE ID='" + ID + "' AND Date='" + date + "'");
                    Log.writeLog(Main.eName + " deleted " + comboBox1.Text + " from the schedule for: " +"\n Date= " + date + "\n Start= " + sh.Text + ":" + sm.Text + "\n End= " + eh.Text + ":" + em.Text + "\n Job= " + jobs.Text);
                    scheduled = false;
                }
                else
                {
                    MessageBox.Show("No record to delete");
                }
                popdg();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = calander.Value.ToString("yyyy-MM-dd");
            mon = getmon(calander.Value);
            sun = mon.AddDays(6);
            popdg();
            Eupdate();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = comboBox1.SelectedValue.ToString();
            Eupdate();
        }

        public void Eupdate()
        {
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }

            Main.myConnection.Open();
            Main.maininstance.sqlreader("Select * from Schedule where ID='" + ID + "' AND Date='" + date + "'");
            if (Main.reader.HasRows)
            {
                scheduled = true;
                TimeSpan a = TimeSpan.Parse(Main.reader["Start"].ToString());
                sh.Text = a.Hours.ToString();
                sm.Text = a.Minutes.ToString();
                a = TimeSpan.Parse(Main.reader["End"].ToString());
                eh.Text = a.Hours.ToString();
                em.Text = a.Minutes.ToString();
                jobs.Text = Main.reader["JID"].ToString();
            }
            else
            {
                scheduled = false;
                sh.Text = "";
                sm.Text = "";
                eh.Text = "";
                em.Text = "";
                jobs.Text = "";
            }
            clength();
            Main.reader.Close();
            Main.myConnection.Close();
        }

        public void popdg()
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

        public void clength()
        {
            if (sh.Text == "" || sm.Text == "" || eh.Text == "" || em.Text == "" || jobs.Text == "")
            {
                Length.Text = "";
            }
            else
            {
                try
                {
                    DateTime s = DateTime.Parse(sh.Text + ":" + sm.Text);
                    DateTime e = DateTime.Parse(eh.Text + ":" + em.Text);
                    if (e < s)
                    {
                        e=e.AddDays(1);
                    }
                    Length.Text = "Length: "+e.Subtract(s).ToString();
                }
                catch
                {
                }

            }

        }

        public Boolean validate()
        {

            if (sh.Text == "" || sm.Text == "" || eh.Text == "" || em.Text == ""||jobs.Text=="")
            {
                MessageBox.Show("Fill in all fields");
                return false;
            }
            else if (int.Parse(sh.Text) > 23 || int.Parse(sh.Text) < 0)
            {
                MessageBox.Show("Start hour not valid");
                return false;
            }
            else if (int.Parse(sm.Text) != 0 && int.Parse(sm.Text) != 15 && int.Parse(sm.Text) != 30 && int.Parse(sm.Text) != 45)
            {
                MessageBox.Show("End minutes not valid");
                return false;
            }
            else if (int.Parse(eh.Text) > 23 || int.Parse(eh.Text) < 0)
            {
                MessageBox.Show("End hour not valid");
                return false;
            }
            else if (int.Parse(em.Text) != 0 && int.Parse(em.Text) != 15 && int.Parse(em.Text) != 30 && int.Parse(em.Text) != 45)
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

        private void Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void sm_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void eh_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }

        private void em_SelectedIndexChanged(object sender, EventArgs e)
        {
            clength();
        }
    }
}

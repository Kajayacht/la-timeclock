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
                Main.maininstance.sqlreader("SELECT * FROM `Hours Worked` WHERE ID='"+ID+"' AND Date='"+date+"'");
                Boolean working = Main.reader.HasRows;
                Main.myConnection.Close();

                if (working)
                {
                    //Main.maininstance.sqlinsert("UPDATE `Hours Worked` SET Start='" + sh.Text + ":" + sm.Text + "', End='" + eh.Text + ":" + em.Text + "', JID='" + jobs.Text + "' WHERE Date='" + date + "' AND ID='" + ID + "'");
                    //Log.writeLog(Main.EName + " changed the Hours Worked for " + comboBox1.Text + "\n Date= " + date + "\n Start= " + sh.Text + ":" + sm.Text + "\n End= " + eh.Text + ":" + em.Text + "\n Job= " + jobs.Text);
                }
                else
                {
                    //Main.maininstance.sqlinsert("INSERT INTO `Hours Worked` SET Start='" + sh.Text + ":" + sm.Text + "', End='" + eh.Text + ":" + em.Text + "', JID='" + jobs.Text + "' WHERE Date='" + date + "' AND ID='" + ID + "'");
                    //Log.writeLog(Main.EName + " changed the Hours Worked for " + comboBox1.Text + "\n Date= " + date + "\n Start= " + sh.Text + ":" + sm.Text + "\n End= " + eh.Text + ":" + em.Text + "\n Job= " + jobs.Text);
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
                //TimeSpan a = TimeSpan.Parse(Main.reader["Start"].ToString());
                //sh.Text = a.Hours.ToString();
                //sm.Text = a.Minutes.ToString();
                //a = TimeSpan.Parse(Main.reader["End"].ToString());
                //eh.Text = a.Hours.ToString();
                //em.Text = a.Minutes.ToString();
                //jobs.Text = Main.reader["JID"].ToString();
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
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status, a.Start ,b.Start As 'Scheduled Start',  " +
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
                                "CONCAT(c.LName, ', ',c.FName,' ',c.MName) AS Name, " +
                                "a.Status, a.Start ,b.Start As 'Scheduled Start', " +
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
                            "WHERE a.Date='" + date + "'";

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
            //DateTime a;
            //if (DateTime.TryParse(Start.Text, out a))
            //{
            //    MessageBox.Show("valid");
            //}

            if (Start.Text == "" || jobs.Text == "")
            {
                MessageBox.Show("Start and Job Cannot be Empty");
                return false;
            }
            else
            {
                return true;
            }
            //else if (int.Parse(sh.Text) > 23 || int.Parse(sh.Text) < 0)
            //{
            //    MessageBox.Show("Start hour not valid");
            //    return false;
            //}
            //else if (int.Parse(sm.Text) != 0 && int.Parse(sm.Text) != 15 && int.Parse(sm.Text) != 30 && int.Parse(sm.Text) != 45)
            //{
            //    MessageBox.Show("End minutes not valid");
            //    return false;
            //}
            //if (int.Parse(eh.Text) > 23 || int.Parse(eh.Text) < 0)
            //{
            //    MessageBox.Show("End hour not valid");
            //    return false;
            //}
            //else if (int.Parse(em.Text) != 0 && int.Parse(em.Text) != 15 && int.Parse(em.Text) != 30 && int.Parse(em.Text) != 45)
            //{
            //    MessageBox.Show("End minutes not valid");
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}

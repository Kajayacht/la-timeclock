using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class Overview : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;

        public Overview()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            requestsDatagridview.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            requestsDatagridview.KeyPress +=new KeyPressEventHandler(Main.maininstance.notIdle_event);

            toCalander.MinDate = fromCalander.Value;
            showwhatDropdownlist.SelectedIndex = 0;
            filldt();
        }

        /** Method to fill the datagridview
        * 
        * @author Nate Rush
        */

        public void filldt()
        {
            //query for the database
            String query = "";

            switch (showwhatDropdownlist.Text)
            {
                case "Schedule":
                    {
                        query = "SELECT Date, CONCAT(LName, ', ',FName,' ',MName) AS Name, Start, End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "' AND Date<='" + toCalander.Value.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
                        break;
                    }
                case "Employee Notes":
                    {
                        query = "SELECT CONCAT(a.LName, ', ',a.FName) as Name, b.Manager, b.Date,b.Note FROM Employee a JOIN EmployeeNotes b ON a.ID=b.ID Where b.Date>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "' AND b.Date<='" + toCalander.Value.ToString("yyyy-MM-dd") + "' ORDER BY Date DESC";
                        break;
                    }
                case "Hours Worked":
                    {
                        query = "Select " +
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
                            "WHERE a.Date>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "' AND a.Date<='" + toCalander.Value.ToString("yyyy-MM-dd") + "' " +
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
                            "WHERE a.Date>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "' AND a.Date<='" + toCalander.Value.ToString("yyyy-MM-dd") + "' " +
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
                        break;
                    }
                default:
                    {
                        query = "Select CONCAT(b.FName,' ',b.LName) as Name, a.SDate as 'Start Date', a.EDate as 'End Date', a.Reason, a.`Submitted Date` FROM Requests a JOIN Employee b ON a.ID=b.ID WHERE " +
                            "((a.EDate>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "'AND a.EDate<='" + toCalander.Value.ToString("yyyy-MM-dd") + "') OR " +
                            "(a.SDate>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "'AND a.SDate<='" + toCalander.Value.ToString("yyyy-MM-dd") + "')) "
                            + " ORDER BY a.SDate,a.`Submitted Date`";
                        break;
                    }
            }
            try
            {
                Main.myConnection.Open();
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                requestsDatagridview.DataSource = bind;

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

        private void fromCalander_ValueChanged(object sender, EventArgs e)
        {
            toCalander.MinDate = fromCalander.Value;
            filldt();
        }

        private void toCalander_ValueChanged(object sender, EventArgs e)
        {
            filldt();
        }

        private void showwhatDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            filldt();
        }
    }
}

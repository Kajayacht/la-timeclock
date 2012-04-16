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

    public partial class Overview : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;

        public Overview()
        {
            InitializeComponent();

            this.overviewDatagridview.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.overviewDatagridview.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.overviewDatagridview.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;
            this.overviewDatagridview.GridColor = Properties.Settings.Default.tableGridColor;

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            overviewDatagridview.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            overviewDatagridview.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

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
                        query = "SELECT Date, CONCAT(LName, ', ',FName) AS Name, DATE_FORMAT(Start, '%h:%i %p') AS Start, DATE_FORMAT(End, '%h:%i %p') AS End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + fromCalander.Value.ToString("yyyy-MM-dd") + "' AND Date<='" + toCalander.Value.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
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
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
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
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
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
                                "a.Status,a.JID As Job, a.Tips as Tips, DATE_FORMAT(a.Start, '%h:%i %p' ) AS Start , DATE_FORMAT(b.Start, '%h:%i %p' ) AS 'Scheduled Start',  " +
                                "DATE_FORMAT(a.B1out, '%h:%i %p' ) As 'Break 1 OUT', " +
                                "DATE_FORMAT(a.B1in, '%h:%i %p' ) As 'Break 1 IN', " +
                                "DATE_FORMAT(a.Lout, '%h:%i %p' ) As 'Lunch OUT', " +
                                "DATE_FORMAT(a.Lin, '%h:%i %p' ) As 'Lunch IN', " +
                                "DATE_FORMAT(a.B2out, '%h:%i %p' ) As 'Break 2 OUT', " +
                                "DATE_FORMAT(a.B2in, '%h:%i %p' ) As 'Break 2 IN', " +
                                "DATE_FORMAT(a.End, '%h:%i %p' ) AS End, DATE_FORMAT(b.End, '%h:%i %p') AS 'Scheduled End'  " +
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
                overviewDatagridview.DataSource = bind;

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

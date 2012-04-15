using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock
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

    public partial class Override : Form
    {
        public Boolean manager = false;
        public Override()
        {
            InitializeComponent();

            jobsBox.DisplayMember = "getname";
            jobsBox.DataSource = Main.joblist;

        }

        private void ok_Click(object sender, EventArgs e)
        {

            if (userTextbox.Text != "" && passTextbox.Text != "")
            {
                try
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlReader("SELECT a.ID, b.ID AS Admin, c.ID AS Manager " +
                                                    "FROM Users a " +
                                                    "LEFT JOIN Admin b " +
                                                    "ON a.ID=b.ID " +
                                                    "LEFT JOIN Manager c " +
                                                    "ON a.ID=c.ID " +
                                                    "Where a.User='" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "' " +
                                                    "And a.Password='" + Main.maininstance.crypt.ComputeHash(passTextbox.Text, "Tlm3AnDR3|aTIv3DlmEn5l0nlN5pA[3", Cryptography.HashName.SHA256) + "'");

                    if (Main.reader.HasRows)
                    {
                        if (Main.reader["Admin"].ToString() != "" || Main.reader["Manager"].ToString() != "")
                        {
                            Main.reader.Close();
                            Main.maininstance.sqlReader("SELECT * FROM `Hours Worked` WHERE ID='"+Main.id+"' and Date='"+DateTime.Today.Date.ToString("yyyy-MM-dd")+"'");
                            
                            if (Main.reader.HasRows)
                            {
                                Main.myConnection.Close();
                                MessageBox.Show("Employee has already been clocked in for today, change in status instead");
                                this.Close();
                            }
                            else
                            {
                                Main.myConnection.Close();
                                Main.maininstance.sqlCommand("INSERT INTO `Hours Worked` (`ID`, `Date`, `Start`, `JID`,`Status`) VALUES ('" + Main.id + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "' , '" + DateTime.Now.ToString("HH:mm:ss") + "', '" + jobsBox.Text + "', 'IN')");
                                Main.maininstance.panel1.Controls.Clear();
                                Main.maininstance.panel1.Controls.Add(new Clockinout());
                                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                                Log.writeLog(userTextbox.Text + " overrode clock in for: " + "\n Employee= " + Main.eName.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Job= " + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Login");
                        }
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }
                finally
                {
                    Main.myConnection.Close();
                }
            }



        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

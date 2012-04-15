using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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


    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            passTextbox.KeyPress += new KeyPressEventHandler(passwordreturn_event);
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            startLogin();
        }


        private void startLogin()
        {
            try
            {

                Main.myConnection.Open();
                Main.maininstance.sqlReader("SELECT a.ID,b.FName, b.LName, c.ID AS Admin, d.ID AS Manager " +
                                            "FROM Users a " +
                                            "Join Employee b " +
                                            "ON a.ID=b.ID " +
                                            "Left Join Admin c " +
                                            "ON a.ID=c.ID " +
                                            "Left Join Manager d " +
                                            "ON a.ID=d.ID " +
                                            "Where LOWER(a.User)=LOWER('" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "') " +
                                            "And a.Password='"+Main.maininstance.crypt.ComputeHash(passTextbox.Text, "Tlm3AnDR3|aTIv3DlmEn5l0nlN5pA[3", Cryptography.HashName.SHA256) +"' "+
                                            "AND (b.EDate>='" + DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd") + "' OR b.EDate is NULL)");

                if (Main.reader.HasRows)
                {
                    Main.id = Main.reader["ID"].ToString();

                    if (Main.reader["Admin"].ToString() != "")
                    {
                        Main.permissions = "Admin";
                    }
                    else if (Main.reader["Manager"].ToString() != "")
                    {
                        Main.permissions = "Manager";
                    }
                    else
                    {
                        Main.permissions = "None";
                    }
                    Main.eName = Main.reader["FName"].ToString() + " " + Main.reader["LName"].ToString();
                    Main.reader.Close();
                    Main.myConnection.Close();

                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Clockinout());
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;

                    Main.maininstance.startTimer();
                }
                else
                {
                    passTextbox.Clear();
                    MessageBox.Show("Incorrect Login");
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.ToString());
                MessageBox.Show("Failed to connect to SQL database");
            }
            finally
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
        }

        private void clock1_Load(object sender, EventArgs e)
        {
            clock1.timer1.Start();
        }

        private void passwordreturn_event(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                passTextbox.Text=passTextbox.Text.ToString().Replace("\r", "");
                startLogin();
            }
            
        }
    }
}

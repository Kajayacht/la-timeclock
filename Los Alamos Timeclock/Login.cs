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

            //sets the background
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //event to check if the user hits enter
            passTextbox.KeyPress += new KeyPressEventHandler(passwordreturn_event);
        }

        //employee clicked the login button
        private void login_Click(object sender, EventArgs e)
        {
            startLogin();
        }


        //login process
        private void startLogin()
        {
            try
            {

                Main.myConnection.Open();
                //checks if the username and pass were valid, and the linked employee's last day isn't less than today minus one day
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
                //the employee exists
                if (Main.reader.HasRows)
                {
                    //set main's id to the reader's id
                    Main.id = Main.reader["ID"].ToString();

                    //sets the user's powers
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
                    //sends the name to main
                    Main.eName = Main.reader["FName"].ToString() + " " + Main.reader["LName"].ToString();
                    Main.myConnection.Close();

                    //open the clockinout screen
                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Clockinout());
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;

                    //start the idle timer
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
                Main.myConnection.Close();
            }
        }

        private void clock_Load(object sender, EventArgs e)
        {
            clock1.timer1.Start();
        }

        //if the user hit enter in the password field, then try to submit
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

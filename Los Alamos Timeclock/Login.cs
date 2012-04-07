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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void B_login_Click(object sender, EventArgs e)
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
                                            "And a.Password=PASSWORD('" + passTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "') " +
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
                }
                else
                {
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
    }
}

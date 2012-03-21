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
                Main.maininstance.sqlreader("SELECT a.ID,b.FName, b.LName, c.ID AS Admin, d.ID AS Manager " +
                                            "FROM Users a " +
                                            "Join Employee b " +
                                            "ON a.ID=b.ID " +
                                            "Left Join Admin c " +
                                            "ON a.ID=c.ID " +
                                            "Left Join Manager d " +
                                            "ON a.ID=d.ID " +
                                            "Where LOWER(a.User)=LOWER('" + IN_USER.Text + "') " +
                                            "And a.Password=PASSWORD('"+IN_PASS.Text + "') "+
                                            "AND (b.EDate>='"+DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd")+"' OR b.EDate='0000-00-00')");

                if (Main.reader.HasRows)
                {
                    Main.ID = Main.reader["ID"].ToString();

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
                    Main.EName = Main.reader["FName"].ToString() + " " + Main.reader["LName"].ToString();
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

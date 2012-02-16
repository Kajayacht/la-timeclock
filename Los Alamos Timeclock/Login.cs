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
                Main.maininstance.sqlreader("SELECT Users.ID,Employee.FName, Employee.Priv, Employee.Status FROM Users, Employee WHERE Users.ID = Employee.ID AND Users.User='" + IN_USER.Text + "' AND Users.Password='" + IN_PASS.Text + "'");

                if (Main.reader.HasRows)
                {
                    Main.status = Main.reader["Status"].ToString();
                    Main.ID = Main.reader["ID"].ToString();
                    Main.permissions = Main.reader["Priv"].ToString();
                    Main.EName = Main.reader["FName"].ToString();
                    Main.reader.Close();
                    Main.myConnection.Close();

                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Clockinout());
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                }
                else
                {
                    Main.myConnection.Close();
                    MessageBox.Show("Incorrect Login");
                }
            }
            catch
            {
                MessageBox.Show("Failed to connect to SQL database");
            }

        }

        private void IN_USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void clock1_Load(object sender, EventArgs e)
        {
            clock1.timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

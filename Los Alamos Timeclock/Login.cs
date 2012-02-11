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
            
            if (Main.myConnection.State == ConnectionState.Open)
            {
                try
                {
                    //MySqlCommand command = new MySqlCommand("SELECT `ID` FROM `Users` WHERE User='" + IN_USER.Text + "' AND Password='" + IN_PASS.Text + "'", Main.myConnection);
                    MySqlCommand command = new MySqlCommand("SELECT Users.ID, Employee.Priv FROM Users JOIN Employee ON Users.ID = Employee.ID WHERE Users.User='"+IN_USER.Text+"' AND Users.Password='"+IN_PASS.Text+"'", Main.myConnection);
                    Main.reader = command.ExecuteReader();
                    Main.reader.Read();
                    Main.ID = Main.reader["ID"].ToString();
                    Main.permissions = Main.reader["Priv"].ToString();
                    Main.reader.Close();

                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                }
                catch(Exception f)
                {
                    //MessageBox.Show(f.ToString());
                    Main.reader.Close();
                    MessageBox.Show("Incorrect Login");
                }

            }
            else
            {

                if (IN_USER.Text.ToLower() == "admin" && IN_PASS.Text.ToLower() == "pass")
                {
                    Main.permissions = "2";
                }
                else if (IN_USER.Text.ToLower() == "manager" && IN_PASS.Text.ToLower() == "pass")
                {
                    Main.permissions = "2";
                }
                else
                {
                    Main.permissions = "0";
                }
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.menu1.Show();
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
    }
}

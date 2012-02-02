using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;




namespace Los_Alamos_Timeclock
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void iplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The IP Addresss is the numeric representation of the database's location on the internet, use localhost if the database is located on this computer.");
        }

        private void portlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The Port is what path the program will take to reach the database once it reaches the IP address. Default 3306");
        }

        private void userlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("User is the username that is used to login to the database server.");
        }

        private void passlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Password is the password that is used to login to the database server.");
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {

            Main.myConnection = new MySqlConnection(
                "SERVER="+ipaddress.Text+
                ";PORT="+port.Text+
				";DATABASE="+database.Text+
				";UID="+user.Text+";" +
				";PASSWORD="+pass.Text+";");
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Employee` WHERE 1", Main.myConnection);


            try
            {
                Main.myConnection.Open();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
            reader = command.ExecuteReader();
            string test="";
            while (reader.Read())
            {
                test=test+reader["LName"].ToString()+"\n";
            }
            Main.myConnection.Close();
            MessageBox.Show(test);

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
            try
            {
                ipaddressTextbox.Text = Properties.Settings.Default.IP;
                portTextbox.Text = Properties.Settings.Default.Port;
                databaseTextbox.Text = Properties.Settings.Default.Database;
                userTextbox.Text = Properties.Settings.Default.User;
                passTextbox.Text = Properties.Settings.Default.Password;
                showCurrentEmployeesCheckbox.Checked = Properties.Settings.Default.showCurrentEmployees;
                showPreviousEmployeesCheckbox.Checked = Properties.Settings.Default.showPreviousEmployees;
            }
            catch
            {
                MessageBox.Show("Failed to get config file");
            }
        }

        private void ipLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The IP Addresss is the numeric representation of the database's location on the internet, use localhost if the database is located on this computer.");
        }

        private void portLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The Port is what path the program will take to reach the database once it reaches the IP address. Default 3306");
        }

        private void userLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("User is the username that is used to login to the database server.");
        }

        private void passLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Password is the password that is used to login to the database server.");
        }

        private void databaseLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is the name of the database that the program will store it's information in.");
        }

        private void Apply_Click(object sender, EventArgs e)
        {

            Main.myConnection = new MySqlConnection(
                "SERVER="+ipaddressTextbox.Text+
                ";PORT="+portTextbox.Text+
				";DATABASE="+databaseTextbox.Text+
				";UID="+userTextbox.Text+";" +
				";PASSWORD="+passTextbox.Text+";");

            try
            {
                Main.myConnection.Open();
                MessageBox.Show("Connection Successful");
                Properties.Settings.Default.IP = ipaddressTextbox.Text;
                Properties.Settings.Default.Port = portTextbox.Text;
                Properties.Settings.Default.Database = databaseTextbox.Text;
                Properties.Settings.Default.User = userTextbox.Text;
                Properties.Settings.Default.Password = passTextbox.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed");
            }
            finally
            {
                Main.myConnection.Close();
            }

        }

        private void saveAppSettings_Click(object sender, EventArgs e)
        {
            if (!showPreviousEmployeesCheckbox.Checked && !showCurrentEmployeesCheckbox.Checked)
            {
                MessageBox.Show("Must show at least 1 group of Employees");
            }
            else
            {
                Properties.Settings.Default.showCurrentEmployees = showCurrentEmployeesCheckbox.Checked;
                Properties.Settings.Default.showPreviousEmployees = showPreviousEmployeesCheckbox.Checked;
                Properties.Settings.Default.Save();
                Main.employeeList= Main.maininstance.getEmployees();
                MessageBox.Show("Application Settings Saved");
            }
        }
    }
}

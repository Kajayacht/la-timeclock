﻿using System;
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
    public partial class Override : Form
    {
        public Boolean manager = false;
        public Override()
        {
            InitializeComponent();

            jobs.DisplayMember = "getname";
            jobs.DataSource = Main.Joblist;
            
        }

        private void ok_Click(object sender, EventArgs e)
        {


            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT Users.ID,Employee.FName, Employee.Priv FROM Users, Employee WHERE Users.ID = Employee.ID AND Users.User='" + user.Text + "' AND Users.Password='" + password.Text + "' AND (Priv='Admin' OR Priv='Manager')");

            if (Main.reader.HasRows&&jobs.Text!="")
            {
                Main.reader.Close();
                Main.myConnection.Close();
                Main.maininstance.sqlinsert("INSERT INTO `Hours Worked` (`ID`, `Date`, `Start`, `JID`,`Status`) VALUES ('" + Main.ID + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "' , '" + Main.maininstance.roundtime(DateTime.Now).ToString("HH:mm:ss") + "', '" + jobs.Text + "', 'IN')");
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Clockinout());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                this.Close();
            }
            else
            {
                Main.reader.Close();
                Main.myConnection.Close();
                MessageBox.Show("Incorrect Login");
            }




        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Override_Load(object sender, EventArgs e)
        {

        }

        private void jobs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.Manager
{
    public partial class Phonebook : UserControl
    {
        String id;
        public Phonebook()
        {
            InitializeComponent();

            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Main.maininstance.notIdle_event);

            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";

            employeeDropdownlist.DataSource = Main.employeeList;
        }

        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            fieldupdate();
        }

        public void fieldupdate()
        {
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlReader("SELECT Phone FROM Employee WHERE ID='"+id+"'");

                phoneNumber.Text = "Phone: " + String.Format("{0:(###) ###-####}", int.Parse(Main.reader["Phone"].ToString()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
        }
    }
}

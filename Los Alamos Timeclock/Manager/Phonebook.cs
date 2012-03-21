using System;
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
        String ID;
        public Phonebook()
        {
            InitializeComponent();
            emplist.DisplayMember = "getname";
            emplist.ValueMember = "gid";
            emplist.DataSource = Main.EmployeeList;
        }

        private void emplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = emplist.SelectedValue.ToString();
            fieldupdate();
        }

        public void fieldupdate()
        {
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT Phone FROM Employee WHERE ID='"+ID+"'");

                phonenumber.Text = "Phone: " + String.Format("{0:(###) ###-####}", int.Parse(Main.reader["Phone"].ToString()));

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

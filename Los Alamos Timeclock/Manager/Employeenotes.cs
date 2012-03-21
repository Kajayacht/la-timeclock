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
    public partial class Employeenotes : UserControl
    {
        string ID;
        public Employeenotes()
        {
            InitializeComponent();
            empnotelist.DisplayMember = "getname";
            empnotelist.ValueMember = "gid";
            empnotelist.DataSource = Main.EmployeeList;
        }

        private void empnotelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = empnotelist.SelectedValue.ToString();
            fieldupdate();
        }


        public void fieldupdate()
        {
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT Phone FROM Employee WHERE ID='" + ID + "'");
                
                empnotesbox.Text = "Phone: " + String.Format("{0:(###) ###-####}", int.Parse(Main.reader["Phone"].ToString()));

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

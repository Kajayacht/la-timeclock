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

        /*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
     */


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

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

    /* Class to show the Phone number of employees to the user */

    public partial class Phonebook : UserControl
    {
        String id;

        /* Method to Initialize the UI */
        public Phonebook()
        {
            InitializeComponent();

            //Load the background image
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //Event handlers for idle logout
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Main.maininstance.notIdle_event);

            //Pull the information from the database into the UI
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
        }

        /* Method to get the employee info for the selected employee */
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            fieldupdate();
        }

        /* Method to update the UI with the employee information */
        public void fieldupdate()
        {
            //Connect to the Database
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlReader("SELECT Phone FROM Employee WHERE ID='"+id+"'");

                //Update the phone number shown onscreen
                phoneNumber.Text = "Phone: " + String.Format("{0:(###) ###-####}", Int64.Parse(Main.reader["Phone"].ToString()));
            }
            //Failed connection
            catch (Exception)
            {
                MessageBox.Show("ERROR: Failed to failed to pull phone number from the database");
            }
            //Close the connection
            finally
            {
                Main.myConnection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock
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

    /* Class to handle the persistent side menu */
    public partial class Menu : UserControl
    {
        /* Initialize the UI */
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        /* Event handler for the Logout button */
        private void Logout_Click(object sender, EventArgs e)
        {
            //Stop the timer
            Main.maininstance.stopTimer();
            //Remove user privaledges
            Main.permissions = "0";
            //Go back to the login screen
            Clockinout.o.Close();
            Manager.Admin.Editemployees.t.Close();
            Manager.Admin.Makesched.l.Close();
            Main.clup.Close();
            Main.maininstance.menu1.Hide();
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Login());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        /* Event handler to handle the Manager button */
        private void Manager_Click(object sender, EventArgs e)
        {
            //Only allow people with admin or manager privaledges to access it
            if (Main.permissions == "Admin" || Main.permissions == "Manager")
            {
                //Go to the Manager screen
                if (Main.maininstance.panel1.HasChildren == false || Main.maininstance.panel1.Controls[0].Name != "Admin")
                {
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Admin());
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                }
            }
            //If a normal user clicks it
            else
            {
                MessageBox.Show("You are not a Manager");
            }
        }

        /* Event handler for the Clockin button */
        private void Clockin_Click(object sender, EventArgs e)
        {
            //Go to the Clockin screen
            if (Main.maininstance.panel1.HasChildren == false || Main.maininstance.panel1.Controls[0].Name != "Clockinout")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Clockinout());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the schedule button */
        private void Schedule_Click(object sender, EventArgs e)
        {
            //Go to the schedule screen
            if (Main.maininstance.panel1.HasChildren==false||Main.maininstance.panel1.Controls[0].Name != "Schedule")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Schedule());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Method for the time to update it */
        private void timer1_Tick(object sender, EventArgs e)
        {
            Menuclock.Text = DateTime.Now.ToLongTimeString();
        }

        /* Event handler for the contact info button */
        private void Contactinfo_Click(object sender, EventArgs e)
        {
            //Go to the contact info UI
            if (Main.maininstance.panel1.HasChildren == false || Main.maininstance.panel1.Controls[0].Name != "Contactinfo")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Contactinfo());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the requests button */
        private void requestsButton_Click(object sender, EventArgs e)
        {
            //Go to the requests UI
            if (Main.maininstance.panel1.HasChildren == false || Main.maininstance.panel1.Controls[0].Name != "Request")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Request());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }

        }

       
    }
}

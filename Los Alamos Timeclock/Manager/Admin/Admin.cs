using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Los_Alamos_Timeclock.Manager.Admin;
using Los_Alamos_Timeclock.Manager;

namespace Los_Alamos_Timeclock
{
    public partial class Admin : UserControl
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

        /** The class to give access to administrative tasks in the program
         * 
         */

        public Admin()
        {
            //Setup the user interface
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);

            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //If current user is a Manager, exclude the options they aren't allowed to do
            if (Main.permissions == "Manager")
            {
                editemployeesButton.BackColor = Color.Gray;
                editjobsButton.BackColor = Color.Gray;
                calculatepayButton.BackColor = Color.Gray;
                viewlogButton.BackColor = Color.Gray;
                settingsButton.BackColor = Color.Gray;

            }
        }

        /* Event handler for the edit employees button */

        private void editemployees_Click(object sender, EventArgs e)
        {
            //Only available to Admin users
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Editemployees());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the calculate pay button */

        private void paychecks_Click(object sender, EventArgs e)
        {
            //Only available to Admin users
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Paychecks());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the settings button */

        private void settings_Click(object sender, EventArgs e)
        {
            //Only available to Admin users
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Settings());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the edit schedule button */

        private void editschedule_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Makesched());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        /* Event handler for the edit jobs button */

        private void editjobs_Click(object sender, EventArgs e)
        {
            //Only available to admin users
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new EditJobs());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the view log button */

        private void viewlog_Click(object sender, EventArgs e)
        {
            //Only available to admin users
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new viewLog());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        /* Event handler for the status button */

        private void status_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Status());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        /* Event handler for the phone book button */

        private void phonebook_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Phonebook());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        /* Event handler for the employee notes button */

        private void employeenotes_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Employeenotes());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }
    }
}

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
        public Admin()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);

            if (Main.permissions == "Manager")
            {
                editemployeesButton.BackColor = Color.Gray;
                editjobsButton.BackColor = Color.Gray;
                calculatepayButton.BackColor = Color.Gray;
                viewlogButton.BackColor = Color.Gray;
                settingsButton.BackColor = Color.Gray;

            }
        }

        private void editemployees_Click(object sender, EventArgs e)
        {
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Editemployees());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void paychecks_Click(object sender, EventArgs e)
        {
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Paychecks());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Settings());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void editschedule_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Makesched());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void editjobs_Click(object sender, EventArgs e)
        {
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new EditJobs());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void viewlog_Click(object sender, EventArgs e)
        {
            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new viewLog());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
        }

        private void status_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Status());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void phonebook_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Phonebook());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void employeenotes_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Employeenotes());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }
    }
}

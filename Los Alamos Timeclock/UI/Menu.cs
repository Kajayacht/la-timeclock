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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Main.permissions = "0";
            Main.maininstance.menu1.Hide();
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Login());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void Manager_Click(object sender, EventArgs e)
        {

            if (Main.permissions == "Admin")
            {
                Main.maininstance.panel1.Controls.Clear();
                Main.maininstance.panel1.Controls.Add(new Admin());
                Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
            else if (Main.permissions == "Manager")
            {
                //no manager user control currently
                //Main.maininstance.panel1.Controls.Clear();
                //Main.maininstance.panel1.Controls.Add(new Manager());
                //Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("You are not a Manager");
            }
        }

        private void Clockin_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Schedule());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void Clockout_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Menuclock.Text = DateTime.Now.ToLongTimeString();
        }

       
    }
}

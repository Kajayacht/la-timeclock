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
            Main.maininstance.menu1.Hide();
            Main.maininstance.Login.IN_USER.ResetText();
            Main.maininstance.Login.IN_PASS.ResetText();
            Main.maininstance.Login.Show();
            Main.maininstance.Login.BringToFront();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Clockin_Click(object sender, EventArgs e)
        {

        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            
            Main.maininstance.Schedule.BringToFront();
            Main.maininstance.Schedule.Show();
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

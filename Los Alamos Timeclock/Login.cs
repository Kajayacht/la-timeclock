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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            if (IN_USER.Text.ToLower()== "admin" && IN_PASS.Text.ToLower() == "pass")
            {
                Main.permissions = 2;
            }
            else if (IN_USER.Text.ToLower() == "manager" && IN_PASS.Text.ToLower() == "pass")
            {
                Main.permissions = 2;
            }
            else
            {
                Main.permissions = 0;
            }
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.menu1.Show();
        }

        private void IN_USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void clock1_Load(object sender, EventArgs e)
        {
            clock1.timer1.Start();
        }
    }
}

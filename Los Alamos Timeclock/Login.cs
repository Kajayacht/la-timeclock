﻿using System;
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
            Main.maininstance.Login.Hide();
            Main.maininstance.menu1.Show();
        }

        private void IN_USER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

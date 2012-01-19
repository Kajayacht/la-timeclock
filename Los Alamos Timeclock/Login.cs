using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock
{
    public partial class Login : Form
    {
        public static Login staticVar = null;
        public Login()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            staticVar = this;
            this.Visible = false;
            Employee employee = new Employee();
            employee.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

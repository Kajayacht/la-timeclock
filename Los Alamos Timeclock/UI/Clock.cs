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
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bigclock_Tick(object sender, EventArgs e)
        {
            Bigclock.Text =DateTime.Now.ToLongTimeString();
        }
    }
}

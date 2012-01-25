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
    
    public partial class Main : Form
    {
        public static Main maininstance = null;
        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                                    ControlStyles.UserPaint |
                                    ControlStyles.AllPaintingInWmPaint, true);

            maininstance = this;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            menu1.Hide();
            
        }

        private void menu1_Load(object sender, EventArgs e)
        {
            
        }

        private void loginControl1_Load(object sender, EventArgs e)
        {
          
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Los_Alamos_Timeclock
{
    
    public partial class Main : Form
    {
        public static Main maininstance = null;
        public static SqlConnection myConnection= new SqlConnection();
        public static int permissions = 0;  
        //used to track user permissions
        //0=employee
        //1=manager
        //2=admin
        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                                    ControlStyles.UserPaint |
                                    ControlStyles.AllPaintingInWmPaint, true);
            maininstance = this;
            panel1.Controls.Clear();
            panel1.Controls.Add(new Login());
            panel1.Controls[0].Dock = DockStyle.Fill;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            menu1.Hide();
            
        }

        private void menu1_Load(object sender, EventArgs e)
        {
            menu1.timer1.Start();
        }
        
        private void loginControl1_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

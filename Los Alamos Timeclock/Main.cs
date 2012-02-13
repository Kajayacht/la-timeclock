using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock
{
    
    public partial class Main : Form
    {
        public static string week;
        public static Main maininstance = null;
        public static string ID;
        public static MySqlConnection myConnection= new MySqlConnection();
        public static MySqlDataReader reader;
        public static DateTime w;
        public static string permissions = "";  
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
            w = DateTime.Now.Date;
            while (w.DayOfWeek != DayOfWeek.Monday)
            {
                w = w.AddDays(-1);
            }
            w = w.Date;
            week = w.Date.ToShortDateString();
            
            
            panel1.Controls.Clear();
            panel1.Controls.Add(new Login());
            panel1.Controls[0].Dock = DockStyle.Fill;



            
            try
            {
                connect();
            }
            catch (Exception f)
            {
                MessageBox.Show("Failed to connect to database, make sure apache is running or change settings");
                //MessageBox.Show(f.ToString());
            }
            
        }

        public void connect()
        {
            Main.myConnection = new MySqlConnection(
                "SERVER=" + Properties.Settings.Default.IP +
                ";PORT=" + Properties.Settings.Default.Port +
                ";DATABASE=" + Properties.Settings.Default.Database +
                ";UID=" + Properties.Settings.Default.User + ";" +
                ";PASSWORD=" + Properties.Settings.Default.Password + ";");
            myConnection.Open();
        }

        public void changeconnection()
        {
            
            
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

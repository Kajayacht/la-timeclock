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
        public static string status;
        public static string ID;
        public static string EName;
        public static MySqlConnection myConnection = new MySqlConnection();
        public static MySqlDataReader reader;
        public static DateTime w;
        public static string permissions = "";


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
            Main.myConnection = new MySqlConnection(
                "SERVER=" + Properties.Settings.Default.IP +
                ";PORT=" + Properties.Settings.Default.Port +
                ";DATABASE=" + Properties.Settings.Default.Database +
                ";UID=" + Properties.Settings.Default.User + ";" +
                ";PASSWORD=" + Properties.Settings.Default.Password + ";");

            connectDB(myConnection);
        }

        /* Method to connect to the database 
         * @author Nate Rush
         * @author Andrew DePersio ajdepersio@gmail.com
         * 
         * @param myConnection = the MySqlConnection server to be connected to
         */
        public void connectDB(MySqlConnection myConnection)
        {
            try
            {
                myConnection.Open();
                myConnection.Close();
            }

           //If connection fails, give user the option to reenter settings or exit the program
            catch (Exception f)
            {
                DialogResult result = MessageBox.Show("Failed to connect to database, make sure apache is running or change settings. \n Do you Want to change connection settings?",
                    "Database Error", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    changeConnection();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }


        /** Method to change database connection settings in case of connection error
         * @author Andrew DePersio ajdepersio@gmail.com
         */
        public void changeConnection()
        {
            //Get input from user
            string server = Microsoft.VisualBasic.Interaction.InputBox("Enter Database IP", "", Properties.Settings.Default.IP, 0, 0);
            string port = Microsoft.VisualBasic.Interaction.InputBox("Enter Database Port", "", Properties.Settings.Default.Port, 0, 0);
            string database = Microsoft.VisualBasic.Interaction.InputBox("Enter Database Name", "", Properties.Settings.Default.Database, 0, 0);
            string uid = Microsoft.VisualBasic.Interaction.InputBox("Enter Database User", "", Properties.Settings.Default.User, 0, 0);
            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter Database User Password", "", Properties.Settings.Default.Password, 0, 0);

            //Build new sql connection
            Main.myConnection = new MySqlConnection(
                "SERVER=" + server +
                ";PORT=" + port +
                ";DATABASE=" + database +
                ";UID=" + uid + ";" +
                ";PASSWORD=" + password + ";");

            //try to connect
            connectDB(myConnection);
        }


        public void sqlinsert(String c)
        {
            try
            {
                myConnection.Open();
                MySqlCommand command = new MySqlCommand(c, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception e)
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
                MessageBox.Show(e.ToString());
            }
        }
        public void sqlreader(String c)
        {
            MySqlCommand command = new MySqlCommand(c, myConnection);
            reader = command.ExecuteReader();
            reader.Read();
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

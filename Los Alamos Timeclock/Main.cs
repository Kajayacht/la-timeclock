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
using Los_Alamos_Timeclock;
using System.Collections;

namespace Los_Alamos_Timeclock
{
    
    public partial class Main : Form
    {
        public static string week;
        public static Main maininstance = null;
        public static string ID;
        public static string EName;
        public static ArrayList Joblist;
        public static ArrayList EmployeeList;
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

            Joblist = getJobs();
            EmployeeList = getEmployees();
        }

        public ArrayList getEmployees()
        {
            ArrayList Employees = new ArrayList();
            try
            {

                Main.myConnection.Open();
                MySqlCommand command = new MySqlCommand("Select ID, LName,FName From Employee ORDER BY LName", Main.myConnection);
                Main.reader = command.ExecuteReader();

                while (Main.reader.Read())
                {
                    Employees.Add(new Employee(Main.reader["LName"].ToString() + ", " + Main.reader["FName"].ToString(), int.Parse(Main.reader["ID"].ToString())));
                }

                Main.reader.Close();
                Main.myConnection.Close();
                return Employees;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

                if (Main.myConnection.State == ConnectionState.Open)
                {
                    Main.reader.Close();
                    Main.myConnection.Close();
                }
                return Employees;
            }

        }
        public class Employee
        {
            private string Name;
            private int ID;


            public Employee(string stringName, int intID)
            {
                this.Name = stringName;
                this.ID = intID;
            }

            public string getname
            {
                get
                {
                    return Name;
                }
            }
            public int gid
            {
                get
                {
                    return ID;
                }
            }
        }

        public ArrayList getJobs()
        {
            ArrayList joblist = new ArrayList();

            Main.myConnection.Open();
            MySqlCommand command = new MySqlCommand("Select * From Jobs ORDER BY JID", Main.myConnection);
            Main.reader = command.ExecuteReader();

            while (Main.reader.Read())
            {
                joblist.Add(new Job(Main.reader["JID"].ToString(), Decimal.Parse(Main.reader["JSPay"].ToString())));
            }

            Main.reader.Close();
            Main.myConnection.Close();
            return joblist;
        }
        public class Job
        {
            private string Jobname;
            private decimal Pay;


            public Job(string stringName, decimal jpay)
            {
                this.Jobname = stringName;
                this.Pay = jpay;
            }

            public string getname
            {
                get
                {
                    return Jobname;
                }
            }
            public decimal getpay
            {
                get
                {
                    return Pay;
                }
            }
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
            catch
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

            Properties.Settings.Default.IP = server;
            Properties.Settings.Default.Port = port;
            Properties.Settings.Default.Database = database;
            Properties.Settings.Default.User = uid;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Save();

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


        public void sqlcommand(String c)
        {
            try
            {
                myConnection.Open();
                MySqlCommand command = new MySqlCommand(c, myConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void sqlreader(String c)
        {
            c = c + " LIMIT 0,1000";
            MySqlCommand command = new MySqlCommand(c, myConnection);
            reader = command.ExecuteReader();
            reader.Read();
        }

        public DateTime roundtime(DateTime t)
        {
            TimeSpan a = TimeSpan.ParseExact(t.ToString("HH:mm:ss"), "g", null);
            int q = 0;
            while (a.Minutes > 15)
            {
                a = a.Subtract(TimeSpan.FromMinutes(15));
                q++;
            }
            if (a.Minutes >= 8)
            {
                a = a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes((q * 15) + 15));
            }
            else
            {
                a = a.Subtract(TimeSpan.FromMinutes(a.Minutes));
                a = a.Add(TimeSpan.FromMinutes(q * 15));
            }
            a = a.Subtract(TimeSpan.FromSeconds(a.Seconds));
            //return a;
            t = DateTime.ParseExact(a.ToString(), "HH:mm:ss", null);
            return t;
        }

        public void error(String s)
        {
            MessageBox.Show(s);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            menu1.Hide();
        }

        private void menu1_Load(object sender, EventArgs e)
        {
            menu1.timer1.Start();
        }
    }
}

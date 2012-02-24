using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class Makesched : UserControl
    {


        public Makesched()
        {
            InitializeComponent();
            calander.MinDate = DateTime.Today;
            calander.MaxDate = DateTime.Today.AddYears(1);
            getEmployees();
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        public void getEmployees()
        {
            ArrayList Employees = new ArrayList();

            try
            {

                Main.myConnection.Open();
                MySqlCommand command = new MySqlCommand("Select ID, LName,FName From Employee", Main.myConnection);
                Main.reader = command.ExecuteReader();
                
                while (Main.reader.Read())
                {
                    Employees.Add(new Employee(Main.reader["LName"].ToString() + ", " + Main.reader["FName"].ToString(), int.Parse(Main.reader["ID"].ToString())));
                    
                }

                comboBox1.DataSource = Employees;
                comboBox1.DisplayMember = "getname";
                comboBox1.ValueMember = "gid";
                

                Main.reader.Close();
                Main.myConnection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

                if (Main.myConnection.State == ConnectionState.Open)
                {
                    Main.reader.Close();
                    Main.myConnection.Close();
                }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        
    }
}

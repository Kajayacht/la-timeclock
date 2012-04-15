using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Los_Alamos_Timeclock.Manager.Admin;

namespace Los_Alamos_Timeclock
{
    class DBInit
    {

        public static void initTables(MySqlConnection myConnection)
        {
            //build the tables if the do not exist

        }

        public static void initAdmin(MySqlConnection myConnection)
        {
            //create initial admin
            //check if there are no admins            
            Main.maininstance.connectDB(myConnection);
            myConnection.Open();
            Main.maininstance.sqlReader("select count(*) from Admin");

            if (int.Parse(Main.reader["count(*)"].ToString()) == 0)
            {
                //Alert that no admins were found, ask if they want to make one
                DialogResult result = MessageBox.Show("No Administrators were found in the Database. \r\nDo you want to create one?", "Admin Not Found", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    bool init = true;

                    //make a new employee 

                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Newemployee(init));
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
     
                    //give him admin rights

                }
                //Or exit the program
                else
                {
                    myConnection.Close();
                    Environment.Exit(0);
                }
            }
            myConnection.Close();
        }
    }
}
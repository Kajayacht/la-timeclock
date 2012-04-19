using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Los_Alamos_Timeclock.Manager.Admin;
using System.IO;

namespace Los_Alamos_Timeclock
{
    /* Class used to initialize the database for use with the program */
    class DBInit
    {
        public static string line;

        /* Method to create the database tables needed to use with the program
         * 
         * @param myConnection      The Database connection info for the database 
         * 
         */
        public static void initTables(MySqlConnection myConnection)
        {
            //Check that the database has information in it
            MySqlCommand command = new MySqlCommand("SELECT * FROM Admin", myConnection);
            try
            {
                Main.myConnection.Open();
                Main.reader = command.ExecuteReader();
                Main.reader.Read();
                Main.myConnection.Close();
            }

            //If the above fails, then the database needs to be initialized
            catch (Exception)
            {
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader r = new StreamReader(@"teamchro_LATSQL-1.sql"))
                    {
                        //Create a string from the text file and return it
                        line = r.ReadToEnd();
                        r.Close();
                    }
                    Main.maininstance.connectDB(myConnection);
                    Main.maininstance.sqlCommand(line);
                }
                catch
                {
                    // Let the user know what went wrong.

                    MessageBox.Show("The file could not be read:");
                }
            }
            

        }

        /* Method to bypass user restrictions and create and the initial administrator
         * 
         * @param myConnection      The database that the user will be created on
         * 
         */
        public static void initAdmin(MySqlConnection myConnection)
        {           
            //check if there are no admins            
            Main.maininstance.connectDB(myConnection);
            myConnection.Open();
            Main.maininstance.sqlReader("select count(*) from Admin");

            //If the Admin table is empty (no admins exist)
            if (int.Parse(Main.reader["count(*)"].ToString()) == 0)
            {
                Main.myConnection.Close();
                //Alert that no admins were found, ask if they want to make one
                DialogResult result = MessageBox.Show("No Administrators were found in the Database. \r\nDo you want to create one?", "Admin Not Found", MessageBoxButtons.YesNo);

                //If yes
                if (result == DialogResult.Yes)
                {
                    //make a new employee with a parameter that will bypass privaledges usually needed to make an admin
                    bool init = true;                    
                    Main.maininstance.menu1.Show();
                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Newemployee(init));
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;                    
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
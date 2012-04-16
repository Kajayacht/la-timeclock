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
    class DBInit
    {
        public static string line;

        public static void initTables(MySqlConnection myConnection)
        {
            //Get the SQL file

            MySqlCommand command = new MySqlCommand("SELECT * FROM Schedule", myConnection);
            try
            {
                Main.myConnection.Open();
                Main.reader = command.ExecuteReader();
                Main.reader.Read();
                Main.myConnection.Close();
            }
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

        public static void initAdmin(MySqlConnection myConnection)
        {
            //create initial admin
            //check if there are no admins            
            Main.maininstance.connectDB(myConnection);
            myConnection.Open();
            Main.maininstance.sqlReader("select count(*) from Admin");

            if (int.Parse(Main.reader["count(*)"].ToString()) == 0)
            {
                Main.myConnection.Close();
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
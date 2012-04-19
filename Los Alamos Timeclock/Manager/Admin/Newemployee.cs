using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    /*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
     */

    public partial class Newemployee : UserControl
    {
        //Boolean to handle creating the first admin
        public static bool myInit;

        /* Class to handle creating data for new employees
         * 
         * @param init  Boolean, if true then this is the initial setup and the user will be given admin user rights
         * 
         */

        public Newemployee(bool init)
        {
            //Initialize the UI
            InitializeComponent();
            myInit = init;

            //Display the background image
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //Set handlers for idle events
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            fNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            mNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            lNameTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            ssnTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aLine1Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aLine2Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aCityTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            aZipTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            phoneTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            emailTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            userTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            pass1Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            pass2Textbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

            phoneTextbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            //If the connection is open, close it
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
        }

        /* Method to handle saving the employee to the database */
        private void save_Click(object sender, EventArgs e)
        {
            //If valid information is given
            if (validate())
            {
                int id = 0;
                Boolean hasrows;

                //Check to make sure the user isn't already in the database
                try
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlReader("SELECT * FROM Users WHERE User='" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    hasrows = Main.reader.HasRows;
                    Main.reader.Close();

                    //Username already exists
                    if (hasrows)
                    {
                        Main.myConnection.Close();
                        MessageBox.Show("Duplicate Username, choose another");
                    }
                    
                    //Grab the highest employee ID from the database
                    else
                    {
                        Main.maininstance.sqlReader("SELECT MAX(ID) FROM Employee");
                        //If there's no employee's then make it 0
                        if (Main.reader["MAX(ID)"].ToString() == "")
                        {
                            id = 0;
                        }
                        else
                        {
                            id = Convert.ToInt32(Main.reader["MAX(ID)"].ToString()) + 1;
                        }
                        Main.myConnection.Close();

                        //Update the database with the new employee info
                        Main.maininstance.sqlCommand("INSERT INTO Employee (`ID`, `LName`, `MName`, `FName`, `SSN`, `Phone`, `Email`, `Address1`, `Address2`,`City`, `State`, `Zip`,`SDate`) VALUES ('" + id + "', '" + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + Main.maininstance.crypt.Encrypt(ssnTextbox.Text, "dR.wH0iS", "tlm3L0rd") + "', '" + phoneTextbox.Text + "', '" + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aStateDropdownlist.Text + "', '" + aZipTextbox.Text + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
                        Main.maininstance.sqlCommand("INSERT INTO Users (`ID`, `User`, `Password`) VALUES ('" + id + "', '" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + Main.maininstance.crypt.ComputeHash(pass1Textbox.Text, "Tlm3AnDR3|aTIv3DlmEn5l0nlN5pA[3", Cryptography.HashName.SHA256) + "')");

                        //If this is the initial employee, have the log write that the system added it
                        if (myInit)
                        {
                            Log.writeLog("SYSTEM added employee: \n" + "LName= " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " MName= " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " FName= " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n SSN= " + Main.maininstance.crypt.Encrypt(ssnTextbox.Text, "dR.wH0iS", "tlm3L0rd") + "\n Phone= " + phoneTextbox.Text + "\n Email= " + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address1= " + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address2= " + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n City= " + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n State= " + aStateDropdownlist.Text + "\n Zip= " + aZipTextbox.Text + "\n ID= " + id + " User= " + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                        }
                        //Else give the user who added the employee
                        else
                        {
                            Log.writeLog(Main.eName + " added employee: \n" + "LName= " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " MName= " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " FName= " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n SSN= " + Main.maininstance.crypt.Encrypt(ssnTextbox.Text, "dR.wH0iS", "tlm3L0rd") + "\n Phone= " + phoneTextbox.Text + "\n Email= " + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address1= " + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address2= " + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n City= " + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n State= " + aStateDropdownlist.Text + "\n Zip= " + aZipTextbox.Text + "\n ID= " + id + " User= " + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                        }

                        //If this isn't the first employee, return to the Editemployees UI
                        if (!myInit)
                        {
                            Main.employeeList = Main.maininstance.getEmployees();
                            Main.maininstance.panel1.Controls.Clear();
                            Main.maininstance.panel1.Controls.Add(new Editemployees());
                            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                        }
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }
                finally
                {
                    Main.myConnection.Close();
                    //If initial employee, give him admin rights and close the program
                    if (myInit == true)
                    {                 
                        Main.maininstance.sqlCommand("INSERT INTO Admin Values('" + id + "')");
                        MessageBox.Show("Admin created.  The program will now exit.");
                        Environment.Exit(0);
                    }
                }
            }
        }
        
        /* Method to handle the user clicking cancel */
        private void cancel_Click(object sender, EventArgs e)
        {
            //Return to the Editemployees screen
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Editemployees());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        /* Method to see if all the new employee info is valid */
        public Boolean validate()
        {
            //See that there isn't already a user with that name
            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT * FROM Users WHERE LOWER(User)=LOWER('" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "')");
            Boolean used = Main.reader.HasRows;
            Main.myConnection.Close();

            if (used)
            {
                MessageBox.Show("Username already exists");
                return false;
            }
            //First name is empty
            else if (fNameTextbox.Text == "")
            {
                MessageBox.Show("First Name cannot be empty");
                return false;
            }
            //Middle name is empty
            else if (mNameTextbox.Text == "")
            {
                MessageBox.Show("Middle Name cannot be empty");
                return false;
            }
            //Last name is empty
            else if (lNameTextbox.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty");
                return false;
            }
            //SSN is empty
            else if (ssnTextbox.Text == "")
            {
                MessageBox.Show("SSN cannot be empty");
                return false;
            }
            //Phone Number is empty
            else if (phoneTextbox.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty");
                return false;
            }
            //User name is empty
            else if (userTextbox.Text == "")
            {
                MessageBox.Show("User cannot be empty");
                return false;
            }
            //Password is empty
            else if (pass1Textbox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            //Password doesn't match the confirmation
            else if (pass1Textbox.Text !=pass2Textbox.Text)
            {
                MessageBox.Show("Password confirmation does not match");
                return false;
            }
            //Everything is good to go
            else
            {
                return true;
            }
        }
    }
}

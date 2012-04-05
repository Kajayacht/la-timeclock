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
    public partial class Newemployee : UserControl
    {
        public Newemployee()
        {
            InitializeComponent();
            ssnTextbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            phoneTextbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int id = 0;
                Boolean hasrows;

                try
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlreader("SELECT * FROM Users WHERE User='" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    hasrows = Main.reader.HasRows;
                    Main.reader.Close();

                    if (hasrows)
                    {
                        Main.myConnection.Close();
                        MessageBox.Show("Duplicate Username, choose another");
                    }
                    else
                    {
                        Main.maininstance.sqlreader("SELECT MAX(ID) FROM Employee");
                        id = Convert.ToInt32(Main.reader["MAX(ID)"]) + 1;
                        Main.reader.Close();
                        Main.myConnection.Close();

                        Main.maininstance.sqlcommand("INSERT INTO Employee (`ID`, `LName`, `MName`, `FName`, `SSN`, `Phone`, `Email`, `Address1`, `Address2`,`City`, `State`, `Zip`,`SDate`) VALUES ('" + id + "', '" + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + ssnTextbox.Text + "', '" + phoneTextbox.Text + "', '" + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aStateDropdownlist.Text + "', '" + aZipTextbox.Text + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
                        Main.maininstance.sqlcommand("INSERT INTO Users (`ID`, `User`, `Password`) VALUES ('" + id + "', '" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', PASSWORD('" + pass1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'))");
                        Log.writeLog(Main.eName + " added employee: \n" + "LName= " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " MName= " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " FName= " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n SSN= " + ssnTextbox.Text + "\n Phone= " + phoneTextbox.Text + "\n Email= " + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address1= " + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address2= " + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n City= " + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n State= " + aStateDropdownlist.Text + "\n Zip= " + aZipTextbox.Text + "\n ID= " + id + " User= " + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));

                        Main.employeeList = Main.maininstance.getEmployees();

                        Main.maininstance.panel1.Controls.Clear();
                        Main.maininstance.panel1.Controls.Add(new Editemployees());
                        Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }
                finally
                {
                    Main.myConnection.Close();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Editemployees());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        public Boolean validate()
        {
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT * FROM Users WHERE LOWER(User)=LOWER('" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "')");
            Boolean used = Main.reader.HasRows;
            Main.myConnection.Close();

            if (used)
            {
                MessageBox.Show("Username already exists");
                return false;
            }
            else if (fNameTextbox.Text == "")
            {
                MessageBox.Show("First Name cannot be empty");
                return false;
            }
            else if (mNameTextbox.Text == "")
            {
                MessageBox.Show("Middle Name cannot be empty");
                return false;
            }
            else if (lNameTextbox.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty");
                return false;
            }
            else if (ssnTextbox.Text == "")
            {
                MessageBox.Show("SSN cannot be empty");
                return false;
            }
            else if (phoneTextbox.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty");
                return false;
            }
            else if (userTextbox.Text == "")
            {
                MessageBox.Show("User cannot be empty");
                return false;
            }
            else if (pass1Textbox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            else if (pass1Textbox.Text !=pass2Textbox.Text)
            {
                MessageBox.Show("Password confirmation does not match");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

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
        public static bool myInit;

        public Newemployee(bool init)
        {
            InitializeComponent();
            myInit = init;


            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

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
                    Main.maininstance.sqlReader("SELECT * FROM Users WHERE User='" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    hasrows = Main.reader.HasRows;
                    Main.reader.Close();

                    if (hasrows)
                    {
                        Main.myConnection.Close();
                        MessageBox.Show("Duplicate Username, choose another");
                    }
                    else
                    {
                        Main.maininstance.sqlReader("SELECT MAX(ID) FROM Employee");
                        id = Convert.ToInt32(Main.reader["MAX(ID)"]) + 1;
                        Main.reader.Close();
                        Main.myConnection.Close();

                        Main.maininstance.sqlCommand("INSERT INTO Employee (`ID`, `LName`, `MName`, `FName`, `SSN`, `Phone`, `Email`, `Address1`, `Address2`,`City`, `State`, `Zip`,`SDate`) VALUES ('" + id + "', '" + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + Main.maininstance.crypt.Encrypt(ssnTextbox.Text, "dR.wH0iS", "tlm3L0rd") + "', '" + phoneTextbox.Text + "', '" + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + aStateDropdownlist.Text + "', '" + aZipTextbox.Text + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "')");
                        Main.maininstance.sqlCommand("INSERT INTO Users (`ID`, `User`, `Password`) VALUES ('" + id + "', '" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + Main.maininstance.crypt.ComputeHash(pass1Textbox.Text, "Tlm3AnDR3|aTIv3DlmEn5l0nlN5pA[3", Cryptography.HashName.SHA256) + "')");
                        Log.writeLog(Main.eName + " added employee: \n" + "LName= " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " MName= " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " FName= " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n SSN= " + Main.maininstance.crypt.Encrypt(ssnTextbox.Text, "dR.wH0iS", "tlm3L0rd") + "\n Phone= " + phoneTextbox.Text + "\n Email= " + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address1= " + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address2= " + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n City= " + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n State= " + aStateDropdownlist.Text + "\n Zip= " + aZipTextbox.Text + "\n ID= " + id + " User= " + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));

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
                    if (myInit == true)
                    {
                        Main.maininstance.sqlReader("SELECT ID FROM Employee ORDER BY ID DESC LIMIT 1");
                        int adminid = int.Parse(Main.reader["ID"].ToString());
                        Main.maininstance.sqlCommand("INSERT INTO Manager Values('" + adminid + "')");
                        Application.Restart();
                    }
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
            Main.maininstance.sqlReader("SELECT * FROM Users WHERE LOWER(User)=LOWER('" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "')");
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

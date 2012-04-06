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
    public partial class Editemployees : UserControl
    {
        string id;
        public Editemployees()
        {
            InitializeComponent();
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
            fieldupdate();
            ssnTextbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            phoneTextbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            jobsBox.DisplayMember = "getname";
            jobsBox.ValueMember = "getpay";
            jobsBox.DataSource = Main.joblist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            fieldupdate();
        }

        public void fieldupdate()
        {
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
            try
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT a.*,b.*,c.ID AS Admin, d.ID AS Manager " +
                                            "FROM Employee a " +
                                            "JOIN Users b " +
                                            "ON a.ID=b.ID " +
                                            "LEFT JOIN Admin c " +
                                            "ON a.ID=c.ID " +
                                            "LEFT JOIN Manager d " +
                                            "ON a.ID=d.ID " +
                                            "WHERE a.ID='" + id + "'");

                fNameTextbox.Text = Main.reader["FName"].ToString();
                mNameTextbox.Text = Main.reader["MName"].ToString();
                lNameTextbox.Text = Main.reader["LName"].ToString();
                ssnTextbox.Text = Main.reader["SSN"].ToString();

                if (Main.reader["EDate"].ToString() == "")
                {
                    employedLabel.Text = "Employed: " + DateTime.Parse(Main.reader["SDate"].ToString()).ToShortDateString() + " - Present";
                }
                else
                {
                    employedLabel.Text = "Employed: " + DateTime.Parse(Main.reader["SDate"].ToString()).ToShortDateString() + " - " + DateTime.Parse(Main.reader["EDate"].ToString()).ToShortDateString();
                }

                aLine1Textbox.Text = Main.reader["Address1"].ToString();
                aLine2Textbox.Text = Main.reader["Address2"].ToString();
                aCityTextbox.Text = Main.reader["City"].ToString();
                aStateDropdownlist.Text = Main.reader["State"].ToString();
                aZipTextbox.Text = Main.reader["Zip"].ToString();

                phoneTextbox.Text = Main.reader["Phone"].ToString();
                emailTextbox.Text = Main.reader["Email"].ToString();


                if (Main.reader["Admin"].ToString() != "")
                {
                    privDropdownlist.SelectedItem = "Admin";
                }
                else if (Main.reader["Manager"].ToString() != "")
                {
                    privDropdownlist.SelectedItem = "Manager";
                }
                else
                {
                    privDropdownlist.SelectedItem = "None";
                }


                userTextbox.Text = Main.reader["User"].ToString();
                pass1Textbox.Text = "";
                pass2Textbox.Text = "";

                Main.reader.Close();
                Main.myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        private void Saveemployee_Click(object sender, EventArgs e)
        {
            if (validateinfo())
            {
                Boolean a=false, m=false;
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT a.ID, b.ID AS Manager, c.ID as Admin "+
                                            "FROM Employee a "+
                                            "LEFT JOIN Manager b "+
                                            "ON b.ID=a.ID "+
                                            "LEFT JOIN Admin c "+
                                            "ON c.ID=a.ID "+
                                            "WHERE a.ID='"+id+"'"
                                            );
                if (Main.reader["Manager"].ToString() != "")
                {
                    m = true;
                }
                else if (Main.reader["Admin"].ToString() != "")
                {
                    a = true;
                }
                Main.reader.Close();
                Main.myConnection.Close();

                if (privDropdownlist.Text == "Admin")
                {
                    
                    if (m)
                    {
                        Main.maininstance.sqlcommand("DELETE FROM Manager WHERE ID='" + id + "'");
                    }
                    if (!a)
                    {
                        try
                        {
                            Main.myConnection.Open();
                            MySqlCommand command = new MySqlCommand("INSERT INTO Admin Values('" + id + "')", Main.myConnection);
                            command.ExecuteNonQuery();
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
                else if (privDropdownlist.Text == "Manager")
                {
                    if (a)
                    {
                        Main.maininstance.sqlcommand("DELETE FROM Admin WHERE ID='" + id + "'");
                    }
                    if (!m)
                    {

                        try
                        {
                            Main.myConnection.Open();
                            MySqlCommand command = new MySqlCommand("INSERT INTO Manager Values('" + id + "')", Main.myConnection);
                            command.ExecuteNonQuery();
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
                else if (privDropdownlist.Text == "None")
                {
                    Main.maininstance.sqlcommand("DELETE FROM Admin WHERE ID='"+id+"'");
                    Main.maininstance.sqlcommand("DELETE FROM Manager WHERE ID='" + id + "'");
                }

                Main.maininstance.sqlcommand("UPDATE Employee SET LName='" + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', MName='" + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', FName='" + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', SSN='" + ssnTextbox.Text + "', Phone='" + phoneTextbox.Text + "', Email='" + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Address1='" + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Address2='" + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', City='" + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', State='" + aStateDropdownlist.Text + "', Zip='" + aZipTextbox.Text + "' WHERE ID='" + id + "'");
                MessageBox.Show("Employee Updated");
                Log.writeLog(Main.eName + " edited employee: \n" + "LName= " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " MName= " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " FName= " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n SSN= " + ssnTextbox.Text + "\n Phone= " + phoneTextbox.Text + "\n Email= " + emailTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address1= " + aLine1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Address2= " + aLine2Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n City= " + aCityTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n State= " + aStateDropdownlist.Text + "\n Zip= " + aZipTextbox.Text + "\n Priv= " + privDropdownlist.Text);
                Main.employeeList = Main.maininstance.getEmployees();
                employeeDropdownlist.DataSource = Main.employeeList;
            }
        }

        public Boolean validateinfo()
        {
            if (id == Main.id && Main.permissions != privDropdownlist.Text)
            {
                MessageBox.Show("You cannot change your own privileges");
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
            else
            {
                return true;
            }
        }

        private void Newemployee_Click(object sender, EventArgs e)
        {
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Newemployee());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        private void Changelogin_Click(object sender, EventArgs e)
        {
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
            if (pass1Textbox.Text == pass2Textbox.Text && userTextbox.Text != "")
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("Select * FROM Users WHERE Lower(User)=Lower('" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "') AND ID!='" + id + "'");
                Boolean rows = Main.reader.HasRows;
                Main.reader.Close();
                if (!rows)
                {

                    Main.maininstance.sqlreader("Select * FROM Users WHERE ID='" + id + "'");
                    rows = Main.reader.HasRows;
                    Main.reader.Close();
                    Main.myConnection.Close();

                    if (rows)
                    {
                        Main.maininstance.sqlcommand("UPDATE Users SET User='" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Password=PASSWORD('" + pass1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "') WHERE ID='" + id.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    }
                    else
                    {
                        Main.maininstance.sqlcommand("INSERT INTO Users (`ID`,`User`,`Password`) Values('" + id + "', '" + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', PASSWORD('" + pass1Textbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'))");
                    }
                    MessageBox.Show("Login Updated");
                    Log.writeLog(Main.eName + " changed login for " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + ": \n" + "User= " + userTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                }
                else
                {
                    MessageBox.Show("Username already exists");
                    Main.myConnection.Close();
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "? All information related to " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " will also be removed.",
        "Delete Employee?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (id == Main.id)
                {
                    MessageBox.Show("You cannot delete your own account");
                }
                else
                {
                    Main.maininstance.sqlcommand("DELETE FROM Employee WHERE ID='" + id + "'");
                    Log.writeLog(Main.eName + " deleted employee: \n " + fNameTextbox.Text + " " + mNameTextbox.Text + " " + lNameTextbox.Text + "\n ID= " + id);
                    Main.employeeList = Main.maininstance.getEmployees();
                    employeeDropdownlist.DataSource = Main.employeeList;
                }
            }

        }

        private void Jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT JPay FROM `Employee Jobs` WHERE ID='" + id + "' AND JID='" + jobsBox.Text + "'");
            if (!Main.reader.HasRows)
            {
                payTextbox.Text = jobsBox.SelectedValue.ToString();
            }
            else
            {
                payTextbox.Text = Main.reader["JPay"].ToString();
            }

            Main.reader.Close();
            Main.myConnection.Close();
        }

        private void Savepay_Click(object sender, EventArgs e)
        {
            Decimal a;
            if (jobsBox.Text == ""|| !Decimal.TryParse(payTextbox.Text, out a))
            {
                if (jobsBox.Text == "")
                {
                    MessageBox.Show("Please select a job");
                }
                else
                {
                    MessageBox.Show("Please enter valid pay ammount");
                }
            }
            else
            {
                
                Decimal opay = Decimal.Parse(jobsBox.SelectedValue.ToString());
                Decimal npay = Decimal.Parse(payTextbox.Text);

                if (opay > npay)
                {
                    MessageBox.Show("Entered pay is below " + jobsBox.Text + "'s minimum wage");
                }
                else
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlreader("SELECT * FROM `Employee Jobs` WHERE ID='" + id + "' AND JID='" + jobsBox.Text + "'");

                    if (Main.reader.HasRows)
                    {
                        Main.reader.Close();
                        Main.myConnection.Close();
                        Main.maininstance.sqlcommand("UPDATE `Employee Jobs` SET JPay='" + payTextbox.Text + "' WHERE ID='" + id + "' AND JID='" + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    }
                    else
                    {
                        Main.myConnection.Close();
                        Main.maininstance.sqlcommand("INSERT INTO `Employee Jobs` Values('" + id + "','" + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', '" + payTextbox.Text + "')");

                    }
                    MessageBox.Show("Pay Updated");
                    Log.writeLog(Main.eName + " changed payrate for " + fNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + mNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " " + lNameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + ": \n" + "Job= " + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + " Pay= " + payTextbox.Text);
                }
            }
        }

    }
}

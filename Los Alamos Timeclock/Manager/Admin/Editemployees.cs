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
        string ID;
        public Editemployees()
        {
            InitializeComponent();
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
            comboBox1.DisplayMember = "getname";
            comboBox1.ValueMember = "gid";
            comboBox1.DataSource = Main.EmployeeList;
            fieldupdate();
            SSN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            jobs.DisplayMember = "getname";
            jobs.ValueMember = "getpay";
            jobs.DataSource = Main.Joblist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = comboBox1.SelectedValue.ToString();
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
                Main.maininstance.sqlreader("SELECT a.*,b.*,c.ID AS Admin, d.ID AS Manager "+
                    "FROM Employee a "+
                    "JOIN Users b "+
                    "ON a.ID=b.ID "+
                    "LEFT JOIN Admin c "+
                    "ON a.ID=c.ID "+
                    "LEFT JOIN Manager d "+
                    "ON a.ID=d.ID "+
                    "WHERE a.ID='" + ID + "'");

                Fname.Text = Main.reader["FName"].ToString();
                Mname.Text = Main.reader["MName"].ToString();
                Lname.Text = Main.reader["LName"].ToString();
                SSN.Text = Main.reader["SSN"].ToString();

                Al1.Text = Main.reader["Address1"].ToString();
                Al2.Text = Main.reader["Address2"].ToString();
                As.Text = Main.reader["State"].ToString();
                Az.Text = Main.reader["Zip"].ToString();

                Phone.Text = Main.reader["Phone"].ToString();
                Email.Text = Main.reader["Email"].ToString();


                if (Main.reader["Admin"].ToString() != "")
                {
                    Priv.SelectedItem = "Admin";
                }
                else if (Main.reader["Manager"].ToString() != "")
                {
                    Priv.SelectedItem = "Manager";
                }
                else
                {
                    Priv.SelectedItem = "None";
                }


                User.Text = Main.reader["User"].ToString();
                Pass1.Text = "";
                Pass2.Text = "";

                Main.reader.Close();
                Main.myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
                                            "WHERE a.ID='"+ID+"'"
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

                if (Priv.Text == "Admin")
                {
                    
                    if (m)
                    {
                        Main.maininstance.sqlcommand("DELETE FROM Manager WHERE ID='" + ID + "'");
                    }
                    if (!a)
                    {
                        try
                        {
                            Main.myConnection.Open();
                            MySqlCommand command = new MySqlCommand("INSERT INTO Admin Values('" + ID + "')", Main.myConnection);
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
                else if (Priv.Text == "Manager")
                {
                    if (a)
                    {
                        Main.maininstance.sqlcommand("DELETE FROM Admin WHERE ID='" + ID + "'");
                    }
                    if (!m)
                    {

                        try
                        {
                            Main.myConnection.Open();
                            MySqlCommand command = new MySqlCommand("INSERT INTO Manager Values('" + ID + "')", Main.myConnection);
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
                else if (Priv.Text == "None")
                {
                    Main.maininstance.sqlcommand("DELETE FROM Admin WHERE ID='"+ID+"'");
                    Main.maininstance.sqlcommand("DELETE FROM Manager WHERE ID='" + ID + "'");
                }

                Main.maininstance.sqlcommand("UPDATE Employee SET LName='" + Lname.Text + "', MName='" + Mname.Text + "', FName='" + Fname.Text + "', SSN='" + SSN.Text + "', Phone='" + Phone.Text + "', Email='" + Email.Text + "', Address1='" + Al1.Text + "', Address2='" + Al2.Text + "', City='" + Ac.Text + "', State='" + As.Text + "', Zip='" + Az.Text + "' WHERE ID='" + ID + "'");
                MessageBox.Show("Employee Updated");
                Log.writeLog(Main.EName + " edited employee: \n" + "LName= " + Lname.Text + " MName= " + Mname.Text + " FName= " + Fname.Text + "\n SSN= " + SSN.Text + "\n Phone= " + Phone.Text + "\n Email= " + Email.Text + "\n Address1= " + Al1.Text + "\n Address2= " + Al2.Text + "\n City= " + Ac.Text + "\n State= " + As.Text + "\n Zip= " + Az.Text + "\n Priv= " + Priv.Text);
                Main.EmployeeList = Main.maininstance.getEmployees();
                comboBox1.DataSource = Main.EmployeeList;
            }
        }

        public Boolean validateinfo()
        {
            if (ID == Main.ID && Main.permissions != Priv.Text)
            {
                MessageBox.Show("You cannot change your own privileges");
                return false;
            }
            else if (Fname.Text == "")
            {
                MessageBox.Show("First Name cannot be empty");
                return false;
            }
            else if (Mname.Text == "")
            {
                MessageBox.Show("Middle Name cannot be empty");
                return false;
            }
            else if (Lname.Text == "")
            {
                MessageBox.Show("Last Name cannot be empty");
                return false;
            }
            else if (SSN.Text == "")
            {
                MessageBox.Show("SSN cannot be empty");
                return false;
            }
            else if (Phone.Text == "")
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
            if (Pass1.Text == Pass2.Text && User.Text != "")
            {
                Main.myConnection.Open();
                Main.maininstance.sqlreader("Select * FROM Users WHERE Lower(User)=Lower('" + User.Text + "') AND ID!='"+ID+"'");
                Boolean rows = Main.reader.HasRows;
                Main.reader.Close();
                if (!rows)
                {

                    Main.maininstance.sqlreader("Select * FROM Users WHERE ID='" + ID + "'");
                    rows = Main.reader.HasRows;
                    Main.reader.Close();
                    Main.myConnection.Close();

                    if (rows)
                    {
                        Main.maininstance.sqlcommand("UPDATE Users SET User='" + User.Text + "', Password=PASSWORD('" + Pass1.Text + "') WHERE ID='" + ID + "'");
                    }
                    else
                    {
                        Main.maininstance.sqlcommand("INSERT INTO Users (`ID`,`User`,`Password`) Values('" + ID + "', '" + User.Text + "', PASSWORD('" + Pass1.Text + "'))");
                    }
                    MessageBox.Show("Login Updated");
                    Log.writeLog(Main.EName + " changed login for " + Fname.Text + " " + Mname.Text + " " + Lname.Text + ": \n" + "User= " + User.Text);
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
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + Fname.Text + " " + Mname.Text + " " + Lname.Text + "? All information related to " + Fname.Text + " " + Mname.Text + " " + Lname.Text + " will also be removed.",
        "Delete Employee?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (ID == Main.ID)
                {
                    MessageBox.Show("You cannot delete your own account");
                }
                else
                {
                    Main.maininstance.sqlcommand("DELETE FROM Employee WHERE ID='" + ID + "'");
                    Log.writeLog(Main.EName + " deleted employee: \n " + Fname.Text + " " + Mname.Text + " " + Lname.Text + "\n ID= " + ID);
                    Main.EmployeeList = Main.maininstance.getEmployees();
                    comboBox1.DataSource = Main.EmployeeList;
                }
            }

        }

        private void Jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT JPay FROM `Employee Jobs` WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");
            if (!Main.reader.HasRows)
            {
                pay.Text = jobs.SelectedValue.ToString();
            }
            else
            {
                pay.Text = Main.reader["JPay"].ToString();
            }

            Main.reader.Close();
            Main.myConnection.Close();
        }

        private void Savepay_Click(object sender, EventArgs e)
        {
            Decimal a;
            if (jobs.Text == ""|| !Decimal.TryParse(pay.Text, out a))
            {
                if (jobs.Text == "")
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
                
                Decimal opay = Decimal.Parse(jobs.SelectedValue.ToString());
                Decimal npay = Decimal.Parse(pay.Text);

                if (opay > npay)
                {
                    MessageBox.Show("Entered pay is below " + jobs.Text + "'s minimum wage");
                }
                else
                {
                    Main.myConnection.Open();
                    Main.maininstance.sqlreader("SELECT * FROM `Employee Jobs` WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");

                    if (Main.reader.HasRows)
                    {
                        Main.reader.Close();
                        Main.myConnection.Close();
                        Main.maininstance.sqlcommand("UPDATE `Employee Jobs` SET JPay='" + pay.Text + "' WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");
                    }
                    else
                    {
                        Main.myConnection.Close();
                        Main.maininstance.sqlcommand("INSERT INTO `Employee Jobs` Values('" + ID + "','" + jobs.Text + "', '" + pay.Text + "')");

                    }
                    MessageBox.Show("Pay Updated");
                    Log.writeLog(Main.EName + " changed payrate for " + Fname.Text + " " + Mname.Text + " " + Lname.Text + ": \n" + "Job= " + jobs.Text + " Pay= " + pay.Text);
                }
            }
        }

    }
}

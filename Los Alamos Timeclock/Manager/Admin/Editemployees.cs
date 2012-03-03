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
            getEmployees();
            fieldupdate();
            SSN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        public void getEmployees()
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

                comboBox1.DisplayMember = "getname";
                comboBox1.ValueMember = "gid";
                comboBox1.DataSource = Employees;

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
                Main.maininstance.sqlreader("SELECT * FROM Employee, Users WHERE Employee.ID='" + ID + "' AND Employee.ID=Users.ID");
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

                Priv.SelectedItem = Main.reader["Priv"].ToString();

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
                Main.maininstance.sqlinsert("UPDATE Employee SET Priv='" + Priv.Text + "', LName='" + Lname.Text + "', MName='" + Mname.Text + "', FName='" + Fname.Text + "', SSN='" + SSN.Text + "', Phone='" + Phone.Text + "', Email='" + Email.Text + "', Address1='" + Al1.Text + "', Address2='" + Al2.Text + "', State='" + As.Text + "', Zip='" + Az.Text + "' WHERE ID='" + ID + "'");
                MessageBox.Show("Employee Updated");

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
                Main.maininstance.sqlreader("Select * FROM Users WHERE ID='" + ID + "'");
                Boolean rows = Main.reader.HasRows;
                Main.reader.Close();
                Main.myConnection.Close();

                if (rows)
                {
                    Main.maininstance.sqlinsert("UPDATE Users SET User='" + User.Text + "', Password='" + Pass1.Text + "' WHERE ID='" + ID + "'");
                }
                else
                {
                    Main.maininstance.sqlinsert("INSERT INTO Users (`ID`,`User`,`Password`) Values('" + ID + "', '" + User.Text + "', '" + Pass1.Text + "')");
                }
                MessageBox.Show("Login Updated");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ID == Main.ID)
            {
                MessageBox.Show("You cannot delete your own account");
            }
            else
            {
                Main.maininstance.sqlinsert("DELETE FROM Employee WHERE ID='" + ID + "'");
                getEmployees();
            }

        }

        private void Jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT JPay FROM `Employee Jobs` WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");
            if (!Main.reader.HasRows)
            {

                Main.reader.Close();
                Main.maininstance.sqlreader("SELECT JSPay FROM `Jobs` WHERE JID='" + jobs.Text + "'");
                pay.Text = Main.reader["JSPay"].ToString();
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
            if (jobs.Text == ""|| !Decimal.TryParse(pay.Text, out a))//also needs to check if pay is empty
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
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT JSPay FROM Jobs WHERE JID='" + jobs.Text + "'");
                Decimal opay = Decimal.Parse(Main.reader["JSPay"].ToString());
                Main.reader.Close();
                Decimal npay = Decimal.Parse(pay.Text);

                if (opay > npay)
                {
                    MessageBox.Show("Entered pay is below " + jobs.Text + "'s minimum wage");
                }
                else
                {
                    Main.maininstance.sqlreader("SELECT * FROM `Employee Jobs` WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");

                    if (Main.reader.HasRows)
                    {
                        Main.reader.Close();
                        Main.myConnection.Close();
                        Main.maininstance.sqlinsert("UPDATE `Employee Jobs` SET JPay='" + pay.Text + "' WHERE ID='" + ID + "' AND JID='" + jobs.Text + "'");
                    }
                    else
                    {
                        Main.myConnection.Close();
                        Main.maininstance.sqlinsert("INSERT INTO `Employee Jobs` Values('" + ID + "','" + jobs.Text + "', '" + pay.Text + "')");

                    }
                }
            }
        }




    }
}

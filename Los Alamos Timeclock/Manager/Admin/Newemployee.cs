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
            SSN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (Main.myConnection.State == ConnectionState.Open)
            {
                Main.reader.Close();
                Main.myConnection.Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int ID = 0;
                Main.myConnection.Open();
                Main.maininstance.sqlreader("SELECT * FROM Users WHERE User='"+User.Text+"'");
                Boolean a = Main.reader.HasRows;
                Main.reader.Close();
                if (a)
                {
                    Main.myConnection.Close();
                    MessageBox.Show("Duplicate Username, choose another");
                }
                else
                {
                    Main.maininstance.sqlreader("SELECT MAX(ID) FROM Employee");
                    ID = Convert.ToInt32(Main.reader["MAX(ID)"]) + 1;
                    Main.reader.Close();
                    Main.myConnection.Close();

                    Main.maininstance.sqlinsert("INSERT INTO Employee (`ID`, `Priv`, `LName`, `MName`, `FName`, `SSN`, `Phone`, `Email`, `Address1`, `Address2`,`City`, `State`, `Zip`) VALUES ('"+ID+"', 'None', '"+Lname.Text+"', '"+Mname.Text+"', '"+Fname.Text+"', '"+SSN.Text+"', '"+Phone.Text+"', '"+Email.Text+"', '"+Al1.Text+"', '"+Al2.Text+"','"+Ac.Text+"', '"+As.Text+"', '"+Az.Text+"')");
                    Main.maininstance.sqlinsert("INSERT INTO Users (`ID`, `User`, `Password`) VALUES ('" + ID + "', '"+User.Text+"', '"+Pass1.Text+"')");
                    Log.writeLog(Main.EName + " added employee: \n" + "LName= " + Lname.Text + " MName= " + Mname.Text + " FName= " + Fname.Text + "\n SSN= " + SSN.Text + "\n Phone= " + Phone.Text + "\n Email= " + Email.Text + "\n Address1= " + Al1.Text + "\n Address2= " + Al2.Text + "\n City= " + Ac.Text + "\n State= " + As.Text + "\n Zip= " + Az.Text + "\n ID= " + ID + " User= " + User.Text + " Pass= " + Pass1.Text);
                    
                    Main.EmployeeList = Main.maininstance.getEmployees();

                    Main.maininstance.panel1.Controls.Clear();
                    Main.maininstance.panel1.Controls.Add(new Editemployees());
                    Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
            Main.maininstance.panel1.Controls.Clear();
            Main.maininstance.panel1.Controls.Add(new Editemployees());
            Main.maininstance.panel1.Controls[0].Dock = DockStyle.Fill;
        }

        public Boolean validate()
        {
            if (Fname.Text == "")
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
            else if (User.Text == "")
            {
                MessageBox.Show("User cannot be empty");
                return false;
            }
            else if (Pass1.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            else if (Pass1.Text !=Pass2.Text)
            {
                MessageBox.Show("Password confirmation does not match");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

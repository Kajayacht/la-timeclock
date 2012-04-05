using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock
{
    public partial class Contactinfo : UserControl
    {
        public Contactinfo()
        {
            InitializeComponent();
            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT * FROM Employee WHERE ID='"+Main.id+"'");
            Al1.Text = Main.reader["Address1"].ToString();
            Al2.Text = Main.reader["Address2"].ToString();
            Ac.Text = Main.reader["City"].ToString();
            As.Text = Main.reader["State"].ToString();
            Az.Text = Main.reader["Zip"].ToString();
            Email.Text = Main.reader["Email"].ToString();
            Phone.Text = Main.reader["Phone"].ToString();
            Main.myConnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (validateinfo())
            {
                Main.maininstance.sqlcommand("UPDATE Employee SET Address1='" + Al1.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Address2='" + Al2.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', City='" + Ac.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', State='" + As.Text + "', Zip='" + Az.Text + "', Email='" + Email.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Phone='" + Phone.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'  WHERE ID='" + Main.id + "'");
                MessageBox.Show("Update Successful");
            }
        }

        public Boolean validateinfo()
        {
            if (Al1.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
                return false;
            }
            else if (Ac.Text == "")
            {
                MessageBox.Show("City cannot be empty");
                return false;
            }
            else if (As.Text == "")
            {
                MessageBox.Show("State cannot be empty");
                return false;
            }
            else if (Az.Text == "")
            {
                MessageBox.Show("Zip code cannot be empty");
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
    }
}

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
        /*
     This file is part of Los Alamos Timeclock.

    Los Alamos Timeclock is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Los Alamos Timeclock is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Los Alamos Timeclock.  If not, see <http://www.gnu.org/licenses/>.
     */

    public partial class Contactinfo : UserControl
    {
        public Contactinfo()
        {
            InitializeComponent();

            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT * FROM Employee WHERE ID='"+Main.id+"'");
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
                Main.maininstance.sqlCommand("UPDATE Employee SET Address1='" + Al1.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Address2='" + Al2.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', City='" + Ac.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', State='" + As.Text + "', Zip='" + Az.Text + "', Email='" + Email.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Phone='" + Phone.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'  WHERE ID='" + Main.id + "'");
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

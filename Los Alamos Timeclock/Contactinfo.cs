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

    /* Class to allow the user to update their contact information */

    public partial class Contactinfo : UserControl
    {
        /* Initialize the UI */
        public Contactinfo()
        {
            InitializeComponent();

            //Set the background image
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //Event handlers for idle timer
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Al1.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            Al1.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Al2.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            Al2.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Ac.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            Ac.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            As.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            As.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Az.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            Az.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Phone.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            Phone.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            Email.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);


            Phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            
            //Get the info of the person stored in the database
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

        /* Event handler for the update button */
        private void Update_Click(object sender, EventArgs e)
        {
            //If information is valid
            if (validateinfo())
            {
                //Update the info
                Main.maininstance.sqlCommand("UPDATE Employee SET Address1='" + Al1.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Address2='" + Al2.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', City='" + Ac.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', State='" + As.Text + "', Zip='" + Az.Text + "', Email='" + Email.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "', Phone='" + Phone.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'  WHERE ID='" + Main.id + "'");
                MessageBox.Show("Update Successful");
            }
        }

        /* Method to validate that the information entered is proper */
        public Boolean validateinfo()
        {
            //Addresss can't be empty
            if (Al1.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
                return false;
            }
            //City can't be empty
            else if (Ac.Text == "")
            {
                MessageBox.Show("City cannot be empty");
                return false;
            }
            //State can't be empty
            else if (As.Text == "")
            {
                MessageBox.Show("State cannot be empty");
                return false;
            }
            //Zip code can't be empty
            else if (Az.Text == "")
            {
                MessageBox.Show("Zip code cannot be empty");
                return false;
            }
            //Phone number can't be empty
            else if (Phone.Text == "")
            {
                MessageBox.Show("Phone Number cannot be empty");
                return false;
            }
            //Everything's good
            else
            {
                return true;
            }
        }
    }
}

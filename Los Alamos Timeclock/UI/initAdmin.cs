using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock
{
    public partial class initAdmin : Form
    {
        public initAdmin()
        {
            InitializeComponent();
        }

    private void Enter_Click(object sender, EventArgs e)
        {

            if (userTextbox.Text != "" && pass1Textbox.Text != "" && pass2Textbox.Text != "" && pass1Textbox.Text == pass2Textbox.Text)
            {
                try
                {
                    Main.myConnection.Open();

                    MySqlCommand command = new MySqlCommand("INSERT into Users");
                    command = new MySqlCommand("INSERT INTO Admin Values('" + 1 + "')", Main.myConnection);
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
            else
            {
                MessageBox.Show("Invalid Input: Check Password?");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 

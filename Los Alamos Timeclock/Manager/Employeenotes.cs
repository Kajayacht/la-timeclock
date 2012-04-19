using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock.Manager
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

    /* Class to handle recording notes about employees */
    public partial class Employeenotes : UserControl
    {
        
        string id;
        public Employeenotes()
        {
            //Build the UI of the modual
            InitializeComponent();

            this.notesDatagrid.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.notesDatagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.notesDatagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;
            this.notesDatagrid.GridColor = Properties.Settings.Default.tableGridColor;

            //Set the background image of the UI
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }
           
            //Initialize the idle event handlers
            this.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            notesDatagrid.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            notesDatagrid.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            noteTextbox.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            noteTextbox.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.MouseMove += new MouseEventHandler(Main.maininstance.notIdle_event);
            employeeDropdownlist.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);

            //Populate the UI elements with the employee info
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
        }

        /* Module to handle changing the information based on which employee is selected */
        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            fillNotesDatagrid();
        }

        /* Module to handle populating the notes area of the UI */
        public void fillNotesDatagrid()
        {
            //Query to be executed
            string query = 
                "SELECT a.Date, a.Note, a.Manager " +
                "FROM EmployeeNotes a "+
                "JOIN Employee b "+
                "ON a.ID=b.ID "+
                "WHERE b.ID='" + id + "' "+
                "ORDER BY a.Date DESC";

            //Open the SQL connection and execute the query
            try
            {
                Main.myConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                //Populate the table
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                notesDatagrid.DataSource = bind;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Failed to pulll notes from the database");
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        /* Method to handle adding a note to an employee */
        private void addnoteButton_Click(object sender, EventArgs e)
        {
            //If no employee is selected
            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                //If there is note text in the note field
                if (noteTextbox.Text == "")
                {
                    MessageBox.Show("Note Cannot be empty");
                }

                //A valid input, so add it to the database
                else
                {
                    Main.maininstance.sqlCommand("INSERT INTO EmployeeNotes VALUES('" + id + "','" + Main.eName + "', NOW() ,'" + noteTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "')");
                    fillNotesDatagrid();
                }
            }
        }
    }
}

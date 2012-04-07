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
    public partial class Employeenotes : UserControl
    {
        string id;
        public Employeenotes()
        {
            InitializeComponent();
            employeeDropdownlist.DisplayMember = "getname";
            employeeDropdownlist.ValueMember = "gid";
            employeeDropdownlist.DataSource = Main.employeeList;
        }

        private void employeeDropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = employeeDropdownlist.SelectedValue.ToString();
            fillNotesDatagrid();
        }


        public void fillNotesDatagrid()
        {
            string query = 
                "SELECT a.Date, a.Note, a.Manager " +
                "FROM EmployeeNotes a "+
                "JOIN Employee b "+
                "ON a.ID=b.ID "+
                "WHERE b.ID='" + id + "' "+
                "ORDER BY a.Date";

            try
            {
                Main.myConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                notesDatagrid.DataSource = bind;
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

        private void addnoteButton_Click(object sender, EventArgs e)
        {
            if (Main.employeeList.Count == 0)
            {
                MessageBox.Show("No Employee Selected");
            }
            else
            {
                if (noteTextbox.Text == "")
                {
                    MessageBox.Show("Note Cannot be empty");
                }
                else
                {
                    Main.maininstance.sqlCommand("INSERT INTO EmployeeNotes VALUES('" + id + "','" + Main.eName + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + noteTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "')");
                    fillNotesDatagrid();
                }
            }
        }
    }
}

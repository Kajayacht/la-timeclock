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
        string ID;
        public Employeenotes()
        {
            InitializeComponent();
            empnotelist.DisplayMember = "getname";
            empnotelist.ValueMember = "gid";
            empnotelist.DataSource = Main.EmployeeList;
        }

        private void empnotelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = empnotelist.SelectedValue.ToString();
            filldt();
        }


        public void filldt()
        {
            string query = 
                "SELECT CONCAT(b.LName,', ',b.FName,' ', b.MName) As Name, a.Date, a.Note, a.Manager " +
                "FROM EmployeeNotes a "+
                "JOIN Employee b "+
                "ON a.ID=b.ID "+
                "WHERE b.ID='" + ID + "' "+
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
                Notes.DataSource = bind;
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

        private void addnote_Click(object sender, EventArgs e)
        {
            if (addnote.Text == "")
            {
                MessageBox.Show("Note Cannot be empty");
            }
            else
            {
                Main.maininstance.sqlcommand("INSERT INTO EmployeeNotes VALUES('"+ID+"','"+Main.EName+"','"+DateTime.Today.ToString("yyyy-MM-dd")+"','"+notetextbox.Text+"')");
                filldt();
            }
        }
    }
}

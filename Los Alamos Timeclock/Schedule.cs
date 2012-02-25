using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Los_Alamos_Timeclock
{
    public partial class Schedule : UserControl
    {
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        public Schedule()
        {
            InitializeComponent();
            string query = "SELECT Date, LName AS Last, FName AS First, Start, End, JID AS Job FROM Schedule JOIN Employee Where Schedule.ID='" + Main.ID + "' AND Schedule.ID=Employee.ID";
            //string query = "SELECT Date, LName AS Last, FName as First, Start, End, JID AS Job FROM Schedule JOIN Employee Where ID='" + Main.ID + "'";

            try
            {
                Main.myConnection.Open();
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                try
                {
                    dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);

                    BindingSource bind = new BindingSource();
                    bind.DataSource = dataTable;
                    Table1.DataSource = bind;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                Main.myConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public DataRowCollection Rows
        {
            get { return dataTable.Rows; }
        }

        private void Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

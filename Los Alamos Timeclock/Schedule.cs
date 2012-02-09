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
        DataTable dataTable;
        public Schedule()
        {
            InitializeComponent();
            string query = "SELECT * FROM Employee ";
            MySqlDataAdapter mySqlDataAdapter;
            MySqlCommandBuilder mySqlCommandBuilder;
            if (Main.myConnection.State==ConnectionState.Open)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
                mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
                mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                Table1.DataSource = bind;
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

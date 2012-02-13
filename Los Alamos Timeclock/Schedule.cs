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
            string query = "SELECT * FROM Schedule Where ID='" + Main.ID + "'";
            //string query = "SELECT Week,MStime As 'M In',MEtime As 'M Out', Mjid As 'M Job',TStime As 'T In',TEtime As 'T Out', Tjid As 'T Job',WStime As 'W In',WEtime As 'W Out', Wjid As 'W Job',TrStime As 'Tr In',TrEtime As 'Tr Out', Trjid As 'Tr Job',FStime As 'F In',FEtime As 'F Out', Mjid As 'F Job',MStime As 'S In',SEtime As 'S Out', Sjid As 'S Job',SuStime As 'Su In',SuEtime As 'Su Out', Sujid As 'Su Job' FROM Schedule Where ID='" + Main.ID + "'";
            if (Main.myConnection.State==ConnectionState.Open)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);
                
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

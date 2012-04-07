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
    public partial class Request : UserControl
    {
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        public Request()
        {
            InitializeComponent();
        }







        public void filldt()
        {
            String query = "Select CONCAT(SDate,'-',EDate) as Date, Reason, `Submitted Date` FROM Requests WHERE ID='"+Main.id+"'";


            try
            {
                Main.myConnection.Open();
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                requestsDatagrid.DataSource = bind;

                Main.myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

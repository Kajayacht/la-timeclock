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
        Boolean existingEntry = false;
        Boolean updating = false;
        String existingSDate;
        public Request()
        {
            InitializeComponent();
            startCalander.MinDate = DateTime.Today;
            endCalander.MinDate = DateTime.Today;
            filldt();
            updateFields();
        }







        public void filldt()
        {
            String query = "Select SDate as 'Start Date', EDate as 'End Date', Reason, `Submitted Date` FROM Requests WHERE ID='"+Main.id+"' and EDate>='"+DateTime.Today.AddDays(-7).ToString("yyyy-MM-dd")+"'";

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
            finally
            {
                Main.myConnection.Close();
            }
        }

        void updateFields()
        {
            if (!updating)
            {
                try
                {
                    updating = true;
                    Main.myConnection.Open();
                    Main.maininstance.sqlReader("SELECT * FROM Requests WHERE ID='" + Main.id +
                                                "' AND SDate<='" + startCalander.Value.ToString("yyyy-MM-dd") +
                                                "' AND EDate>='" + startCalander.Value.ToString("yyyy-MM-dd") + "'");
                    if (Main.reader.HasRows)
                    {
                        existingSDate = DateTime.Parse(Main.reader["SDate"].ToString()).ToString("yyyy-MM-dd");

                        if (!existingEntry)
                        {
                            requestButton.Text = "Update Request";
                            startCalander.Value = DateTime.Parse(Main.reader["SDate"].ToString()).Date;
                            endCalander.MinDate = startCalander.Value;
                            endCalander.Value = DateTime.Parse(Main.reader["EDate"].ToString()).Date;
                            reasonTextbox.Text = Main.reader["Reason"].ToString();
                        }

                        existingEntry = true;
                    }
                    else
                    {
                        existingEntry = false;
                        existingSDate = "";
                        requestButton.Text = "Request";
                        endCalander.MinDate = startCalander.Value;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }
                finally
                {
                    Main.myConnection.Close();
                    updating = false;
                }
            }
        }

        private void startCalander_ValueChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (existingEntry)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this request?", "Delete Request?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    String delete = "DELETE FROM Requests WHERE ID='" + Main.id +
                                    "' AND SDate='" + startCalander.Value.ToString("yyyy-MM-dd") +
                                    "' AND EDate='" + endCalander.Value.ToString("yyyy-MM-dd") + "'";
                    Main.maininstance.sqlCommand(delete);
                    filldt();
                    updateFields();
                }
                else
                {
                    MessageBox.Show("No record selected");
                }
            }
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            if (existingEntry)
            {
                String update = "Update Requests "+
                                "SET SDate='"+startCalander.Value.ToString("yyyy-MM-dd")+"', "+
                                "EDate='"+endCalander.Value.ToString("yyyy-MM-dd")+"', "+
                                "Reason='" + reasonTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'")+"' "+
                                "WHERE ID='"+Main.id+"' AND SDate='"+existingSDate+"'";
                Main.maininstance.sqlCommand(update);
                filldt();
                updateFields();
            }
            else
            {
                String insert="INSERT INTO Requests VALUES('"+Main.id+"','"+
                                    startCalander.Value.ToString("yyyy-MM-dd")+"','"+
                                    endCalander.Value.ToString("yyyy-MM-dd")+"',"+
                                    "NOW(),'"+
                                    reasonTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'")+
                                        "')";
                Main.maininstance.sqlCommand(insert);
                filldt();
                updateFields();
            }
        }
    }
}

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

    public partial class Schedule : UserControl
    {
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        DateTime mon, sun;
        public Schedule()
        {
            InitializeComponent();

            //set datagrid colors
            this.scheduleDatagrid.DefaultCellStyle.ForeColor = Properties.Settings.Default.tableTextColor;
            this.scheduleDatagrid.DefaultCellStyle.BackColor = Properties.Settings.Default.tablerow1Color;
            this.scheduleDatagrid.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.tablerow2Color;
            this.scheduleDatagrid.GridColor = Properties.Settings.Default.tableGridColor;

            //set background
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.backgroundImage);
            }
            catch (Exception)
            {
                this.BackgroundImage = Properties.Resources._1287421014661;
            }

            //events to reset the idle timer
            this.MouseMove+=new MouseEventHandler(Main.maininstance.notIdle_event);
            this.KeyDown += new KeyEventHandler(Main.maininstance.notIdle_event);
            scheduleDatagrid.MouseMove+=new MouseEventHandler(Main.maininstance.notIdle_event);
            scheduleDatagrid.KeyDown+=new KeyEventHandler(Main.maininstance.notIdle_event);

            //get this week's span
            mon = Manager.Admin.Paychecks.getDay(weekCalander.Value, DayOfWeek.Monday);
            sun = mon.AddDays(6);
            //by default you only see your own schedule
            whoDropdownlist.SelectedItem = "Self";
            //set the calander to monday's date
            weekCalander.Value = mon.Date;

            //fill the datatable
            filldt();
        }

        //method to fill the datatable
        private void filldt()
        {
            string query = "";
            //either gets the user's schedule or everyone's
            if (whoDropdownlist.Text == "Self")
            {
                query = "SELECT Date, LName AS Last, FName AS First, DATE_FORMAT(Start, '%h:%i %p') as Start, DATE_FORMAT(End, '%h:%i %p') as End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Schedule.ID='" + Main.id + "' AND Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
            }
            else
            {
                query = "SELECT Date, LName AS Last, FName AS First, DATE_FORMAT(Start, '%h:%i %p') as Start, DATE_FORMAT(End, '%h:%i %p') as End, JID AS Job FROM Schedule JOIN Employee ON Schedule.ID=Employee.ID Where Date>='" + mon.ToString("yyyy-MM-dd") + "' AND Date<='" + sun.ToString("yyyy-MM-dd") + "' ORDER BY Date, Start";
            }

            try
            {
                //fills the datatable with the query results
                Main.myConnection.Open();
                mySqlDataAdapter = new MySqlDataAdapter(query, Main.myConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                BindingSource bind = new BindingSource();
                bind.DataSource = dataTable;
                scheduleDatagrid.DataSource = bind;

                Main.myConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Failed to fill datatable");
            }
            finally
            {
                Main.myConnection.Close();
            }
        }

        //updates the datatable to the selected week
        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (weekCalander.Value.DayOfWeek != DayOfWeek.Monday)
            {
                weekCalander.Value = Manager.Admin.Paychecks.getDay(weekCalander.Value, DayOfWeek.Monday);
            }
            mon = weekCalander.Value;
            sun = mon.AddDays(6);
            filldt();
        }

        private void selfall_DropDownListChanged(object sender, EventArgs e)
        {
            filldt();
        }

    }
}

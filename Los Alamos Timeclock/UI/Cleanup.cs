using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.UI
{
    /* Class used to remove data from the database based on a given date */
    public partial class Cleanup : Form
    {
        /* Method to initialize the UI */
        public Cleanup()
        {
            InitializeComponent();
            //Set the default dates
            beforeCalander.MaxDate = DateTime.Today;
            beforeCalander.Value = DateTime.Today.AddMonths(-1);
        }

        /* Event handler for the submit button 
           Sends the given changes to the database*/
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Get user confirmation to delete the stuff
            if (requestsCheckbox.Checked || schedulecheckBox.Checked || hoursWorkedCheckbox.Checked || employeesCheckbox.Checked)
            {
                DialogResult answer = MessageBox.Show("Are you sure you wish to delete the selected items? This action cannot be undone", "Delete Selected Items?", MessageBoxButtons.YesNo);
                
                //Yes is clicked, so do it
                if (answer == DialogResult.Yes)
                {
                    String Message = "";
                    String deleted="";
                    //Delete the request info
                    if (requestsCheckbox.Checked)
                    {
                        Message += "DELETE FROM Requests WHERE EDate<='" + beforeCalander.Value.ToString("yyyy-MM-dd") + "';\n";
                        deleted+="Requests, ";
                    }
                    //Delete the schedule info
                    if (schedulecheckBox.Checked)
                    {
                        Message += "DELETE FROM Schedule WHERE Date<='" + beforeCalander.Value.ToString("yyyy-MM-dd") + "';\n";
                        deleted+="Schedule, ";
                    }
                    //Delete the hours worked info
                    if (hoursWorkedCheckbox.Checked)
                    {
                        Message += "DELETE FROM `Hours Worked` WHERE Date<='" + beforeCalander.Value.ToString("yyyy-MM-dd") + "';\n";
                        deleted+="Hours Worked, ";
                    }
                    //Delete the employee info
                    if (employeesCheckbox.Checked)
                    {
                        Message += "DELETE FROM Employee WHERE EDate<='" + beforeCalander.Value.ToString("yyyy-MM-dd") + "';\n";
                        deleted+="Employees, ";
                    }
                    //Execute the SQL command to delete the info
                    Main.maininstance.sqlCommand(Message);

                    //Write changes to the log.txt file
                    Log.writeLog(Main.eName + " deleted " + deleted + " before " + beforeCalander.Value.ToShortDateString());
                }
                //No is clicked, so close it
                else
                {
                    this.Close();
                }
            }
            //Nothing is selected, so nothing to delete
            else
            {
                MessageBox.Show("Nothing selected to delete");
            }
        }

        /* Event handler for the Cancel button, just closes the UI */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Event handler for the employee checkbox */
        private void employeesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //If employees is checked
            if (employeesCheckbox.Checked)
            {
                //Tell the user the effects of their action and ask for confirmation
                DialogResult answer = MessageBox.Show("Deleting employees will also delete all information related to them (Requests, Schedule, Hours Worked, Login Information)\n" +
                    "\n Are You Sure you wish to delete employees who's last day was before the selected date?", "Delete Employees?", MessageBoxButtons.YesNo);
                if (answer != DialogResult.Yes)
                {
                    employeesCheckbox.Checked = false;
                }
            }
        }


        
    }
}

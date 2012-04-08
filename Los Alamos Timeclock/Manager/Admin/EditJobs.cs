using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Los_Alamos_Timeclock.Manager.Admin
{
    public partial class EditJobs : UserControl
    {
        public EditJobs()
        {
            InitializeComponent();

            jobsBox.DisplayMember = "getname";
            jobsBox.DataSource = Main.joblist;

            //!Decimal.TryParse(pay.Text, out a)
        }

        private void jobsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobnameTextbox.Text = jobsBox.Text;
            jobsBox.ValueMember = "getpay";
            startingpayTextbox.Text = jobsBox.SelectedValue.ToString();
            jobsBox.ValueMember = "getTipped";
            tippedBox.Checked = Boolean.Parse(jobsBox.SelectedValue.ToString());
        }

        public Boolean validate()
        {
            Decimal a;
            Main.myConnection.Open();
            Main.maininstance.sqlReader("SELECT * FROM Jobs WHERE JID='"+jobnameTextbox.Text+"'");
            Boolean hasrows = Main.reader.HasRows;
            Main.reader.Close();
            Main.myConnection.Close();

            if (hasrows && jobnameTextbox.Text != jobsBox.Text)
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
                return false;
            }
            else if (!Decimal.TryParse(startingpayTextbox.Text, out a))
            {
                MessageBox.Show("Invalid starting pay");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void refreshJobs()
        {
            Main.joblist = Main.maininstance.getJobs();
            jobsBox.DataSource = Main.joblist;
        }

        private void updateJob_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Main.maininstance.sqlCommand("UPDATE Jobs SET JID='" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "',JSPay='" + Decimal.Parse(startingpayTextbox.Text) + "',TippedJob='" + tippedBox.Checked + "' WHERE JID='" + jobsBox.Text + "'");
                MessageBox.Show("Update successful");
                Log.writeLog(Main.eName + " updated job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + Decimal.Parse(startingpayTextbox.Text) + "\n Tipped Job= " + tippedBox.Checked);
                refreshJobs();
            }
      
        }

        private void newJob_Click(object sender, EventArgs e)
        {
            if (jobsBox.Text != jobnameTextbox.Text)
            {
                if (validate())
                {
                    MessageBox.Show("Insert successful");
                    Main.maininstance.sqlCommand("INSERT INTO Jobs Values('" + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "','" + Decimal.Parse(startingpayTextbox.Text) + "','" + tippedBox.Checked + "')");
                    Log.writeLog(Main.eName + " added job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "\n Starting Pay= " + Decimal.Parse(startingpayTextbox.Text) + "\n Tipped Job= " + tippedBox.Checked);
                    refreshJobs();
                }
            }
            else
            {
                MessageBox.Show("A job with the name of " + jobnameTextbox.Text + " already exists");
            }
        }

        private void deleteJob_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this job? All "+jobsBox.Text+" shifts will also be removed",
                    "Delete Job?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Main.maininstance.sqlCommand("DELETE FROM Jobs WHERE JID='" + jobsBox.Text.Replace(@"\", @"\\").Replace("'", @"\'") + "'");
                    Log.writeLog(Main.eName + " deleted job: " + "\n Job= " + jobnameTextbox.Text.Replace(@"\", @"\\").Replace("'", @"\'"));
                    refreshJobs();
                }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Filter = "Pictures (*.jpg)|*.jpg";
            imageDialog.FilterIndex = 1;
        }
    }
}

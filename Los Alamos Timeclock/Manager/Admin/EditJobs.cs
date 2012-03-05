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

            jobs.DisplayMember = "getname";
            jobs.ValueMember = "getpay";
            jobs.DataSource = Main.Joblist;

            //!Decimal.TryParse(pay.Text, out a)
        }

        private void jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            jname.Text = jobs.Text;
            jpay.Text = jobs.SelectedValue.ToString();
        }

        public Boolean validate()
        {
            Decimal a;
            Main.myConnection.Open();
            Main.maininstance.sqlreader("SELECT * FROM Jobs WHERE JID='"+jname.Text+"'");
            Boolean rows = Main.reader.HasRows;
            Main.reader.Close();
            Main.myConnection.Close();

            if (rows && jname.Text != jobs.Text)
            {
                MessageBox.Show("A job with the name of " + jname.Text + " already exists");
                return false;
            }
            else if (!Decimal.TryParse(jpay.Text, out a))
            {
                MessageBox.Show("Invalid starting pay");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void refreshjobs()
        {
            Main.Joblist = Main.maininstance.getJobs();
            jobs.DataSource = Main.Joblist;
        }

        private void Updatejob_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Main.maininstance.sqlinsert("UPDATE Jobs SET JID='"+jname.Text+"',JSPay='"+Decimal.Parse(jpay.Text)+"' WHERE JID='"+jobs.Text+"'");
                MessageBox.Show("Update successful");
                Log.writeLog(Main.EName + " updated job: " + "\n Job= " + jname.Text + "\n Starting Pay= " + Decimal.Parse(jpay.Text));
                refreshjobs();
            }
      
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (jobs.Text != jname.Text)
            {
                if (validate())
                {
                    MessageBox.Show("Insert successful");
                    Main.maininstance.sqlinsert("INSERT INTO Jobs Values('" + jname.Text + "','" + Decimal.Parse(jpay.Text) + "')");
                    Log.writeLog(Main.EName + " added job: " + "\n Job= " + jname.Text + "\n Starting Pay= " + Decimal.Parse(jpay.Text));
                    refreshjobs();
                }
            }
            else
            {
                MessageBox.Show("A job with the name of " + jname.Text + " already exists");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this job? All "+jobs.Text+" shifts will also be removed",
                    "Delete Job?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Main.maininstance.sqlinsert("DELETE FROM Jobs WHERE JID='"+jobs.Text+"'");
                    Log.writeLog(Main.EName + " deleted job: " + "\n Job= " + jname.Text);
                    refreshjobs();
                }
        }
    }
}

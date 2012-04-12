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
    public partial class viewLog : UserControl
    {
        public viewLog()
        {
            InitializeComponent();
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            logViewBox.MouseMove += new System.Windows.Forms.MouseEventHandler(Main.maininstance.notIdle_event);
            logViewBox.KeyDown += new System.Windows.Forms.KeyEventHandler(Main.maininstance.notIdle_event); 

            logViewBox.Text = Log.viewLog();
        }
    }
}

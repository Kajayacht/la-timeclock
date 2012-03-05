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
    public partial class ViewLog : UserControl
    {
        public ViewLog()
        {
            InitializeComponent();
            logViewBox.Text = Log.viewLog();
        }
    }
}

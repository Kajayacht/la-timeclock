using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

    //originally from http://www.codeproject.com/Articles/5428/Nullable-DateTimePicker


    public class nullableDTpicker : System.Windows.Forms.DateTimePicker
    {
        private DateTimePickerFormat oldFormat = DateTimePickerFormat.Custom;
        private string oldCustomFormat = null;
        private bool bIsNull = false;

        public nullableDTpicker()
            : base()
        {
        }

        public new DateTime Value
        {

            get
            {
                if (bIsNull)
                    return DateTime.MinValue;
                else
                    return base.Value;
            }
            set
            {
                if (value == DateTime.MinValue)
                {
                    if (bIsNull == false)
                    {
                        oldFormat = this.Format;
                        oldCustomFormat = this.CustomFormat;
                        bIsNull = true;
                    }

                    this.Format = DateTimePickerFormat.Custom;
                    this.CustomFormat = " ";
                }
                else
                {
                    if (bIsNull)
                    {
                        this.Format = oldFormat;
                        this.CustomFormat = oldCustomFormat;
                        bIsNull = false;
                    }
                    base.Value = value;
                }
            }
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                if (bIsNull)
                {
                    this.Format = oldFormat;
                    this.CustomFormat = oldCustomFormat;
                    bIsNull = false;
                }
            }
            base.OnCloseUp(eventargs);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Delete)
            {
                this.Value = DateTime.MinValue;
            }
            else if(this.Value == DateTime.MinValue)
            {
                this.Value = DateTime.Parse("12 am");
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (this.Value == DateTime.MinValue)
            {
                this.Value = DateTime.Parse("12 am");
            }
        }

        
    }
}

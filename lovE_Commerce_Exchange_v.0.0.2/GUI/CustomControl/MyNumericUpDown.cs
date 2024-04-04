using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomControl
{
    public class MyNumericUpDown : NumericUpDown
    {
        public MyNumericUpDown()
        {
            Controls[0].Hide();
        }

        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
    }
}

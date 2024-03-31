using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace GUI.CustomControl
{
    public partial class GradientText : Label
    {
        public GradientText()
        {
            //InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the formatted text string to the DrawingContext of the control.
            //base.OnPaint(e);
            

        }
    }
}

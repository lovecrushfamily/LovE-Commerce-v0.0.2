using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GUI.CustomControl
{
    public class GradientLabel : Label
    {
        // declare two color for linear gradient
        private Color cLeft;
        private Color cRight;
        private Color BeginTextColor;
        private Color EndTextColor;
        private LinearGradientMode direction;

        // property of begin color in linear gradient
        [Category("Gradient Label")]
        public Color BeginColor
        {
            get
            {
                return cLeft;
            }
            set
            {
                cLeft = value;
                Invalidate();
            }
        }
        // property of end color in linear gradient
        [Category("Gradient Label")]
        public Color EndColor
        {
            get
            {
                return cRight;
            }
            set
            {
                cRight = value;
                Invalidate();
            }
        }

        [Category("Gradient Text")]
        public Color TextColorBegin
        {
            get
            {
                return BeginTextColor;
            }

            set
            {
                BeginTextColor = value;
                Invalidate();
            }
        }
        [Category("Gradient Text")]
        public Color TextColorEnd {
            get
            {
                return EndTextColor;
            }
            set
            {
                EndTextColor = value;
                Invalidate();
            }
        }
        [Category("Gradient Text")]
        public LinearGradientMode Direction {
            get
            {
                return   direction;
            }
            set
            {
                direction = value;
                Invalidate();
            }
        }

        public GradientLabel()
        {
            // Default get system color 
            cLeft = SystemColors.ActiveCaption;
            cRight = SystemColors.Control;
            TextColorBegin = SystemColors.Control;
            TextColorEnd = SystemColors.Control;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // declare linear gradient brush for fill background of label
            LinearGradientBrush GBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, 0), cLeft, cRight);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            // Fill with gradient 
            e.Graphics.FillRectangle(GBrush, rect);

            // draw gradient text on label
            LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, Width, Height + 5), 
                TextColorBegin, TextColorEnd,direction);
            StringFormat sf = new StringFormat();
            // align with center
            sf.Alignment = StringAlignment.Center;
            // set rectangle bound text
            RectangleF rectF = new RectangleF(0, this.Height / 2 - Font.Height / 2, this.Width, this.Height);
            // output string
            e.Graphics.DrawString(Text, Font, brush, rectF, sf);

           
        }
    }
}

using FontAwesome.Sharp;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace GUI
{
    internal class Encryption
    {
        internal static string EncryptPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public static class ICloneable
    {
        public static dynamic DeepClone(this Control obj)
        {
            //if (obj == null)
            //{
            //    return null;
            //}

            var serialized = System.Text.Json.JsonSerializer.Serialize(obj, new System.Text.Json.JsonSerializerOptions()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                WriteIndented = false,
                Converters = {
                                new System.Text.Json.Serialization.JsonStringEnumConverter()
                              },
                IncludeFields = true
            });

            return System.Text.Json.JsonSerializer.Deserialize<Control>(serialized);
        }

    }
    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }

    #region Fill the form to Screen and remove Border
    //Overridden methods
    //protected override void WndProc(ref Message m)
    //{
    //    const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
    //    const int WM_SYSCOMMAND = 0x0112;
    //    const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
    //    const int SC_RESTORE = 0xF120; //Restore form (Before)
    //    const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
    //    const int resizeAreaSize = 10;

    //    #region Form Resize
    //    // Resize/WM_NCHITTEST values
    //    const int HTCLIENT = 1; //Represents the client area of the window
    //    const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
    //    const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
    //    const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
    //    const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
    //    const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
    //    const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
    //    const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
    //    const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

    //    ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

    //    if (m.Msg == WM_NCHITTEST)
    //    { //If the windows m is WM_NCHITTEST
    //        base.WndProc(ref m);
    //        if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
    //        {
    //            if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
    //            {
    //                Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
    //                Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

    //                if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
    //                {
    //                    if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
    //                        m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
    //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
    //                        m.Result = (IntPtr)HTTOP; //Resize vertically up
    //                    else //Resize diagonally to the right
    //                        m.Result = (IntPtr)HTTOPRIGHT;
    //                }
    //                else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
    //                {
    //                    if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
    //                        m.Result = (IntPtr)HTLEFT;
    //                    else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
    //                        m.Result = (IntPtr)HTRIGHT;
    //                }
    //                else
    //                {
    //                    if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
    //                        m.Result = (IntPtr)HTBOTTOMLEFT;
    //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
    //                        m.Result = (IntPtr)HTBOTTOM;
    //                    else //Resize diagonally to the right
    //                        m.Result = (IntPtr)HTBOTTOMRIGHT;
    //                }
    //            }
    //        }
    //        return;
    //    }
    //    #endregion

    //    //Remove border and keep snap window
    //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
    //    {
    //        return;
    //    }

    //    //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
    //    if (m.Msg == WM_SYSCOMMAND)
    //    {
    //        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
    //        /// Quote:
    //        /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
    //        /// are used internally by the system.To obtain the correct result when testing 
    //        /// the value of wParam, an application must combine the value 0xFFF0 with the 
    //        /// wParam value by using the bitwise AND operator.
    //        int wParam = (m.WParam.ToInt32() & 0xFFF0);

    //        if (wParam == SC_MINIMIZE)  //Before
    //            formSize = this.ClientSize;
    //        if (wParam == SC_RESTORE)// Restored form(Before)
    //            this.Size = formSize;
    //    }
    //    base.WndProc(ref m);
    //}
    //private void Main_Load(object sender, EventArgs e)
    //{
    //    formSize = this.ClientSize;
    //}
    #endregion 

    public class MyEventArgs<MyObject> : EventArgs
    {
        public MyEventArgs() { }
    }
    


    #region GUI Control
    internal class RoundedButton : Button
    {
        private int rdus = 100;

        public int Rdus { get => rdus; set => rdus = value; }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

    }

    internal class RoundedButtonIcon : IconButton
    {
        private int rdus = 20;

        public int BorderRadius { get => rdus; set => rdus = value; }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }



    }
    #endregion




}



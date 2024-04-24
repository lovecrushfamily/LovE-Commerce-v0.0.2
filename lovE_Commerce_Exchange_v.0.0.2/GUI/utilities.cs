using BUS;
using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GUI
{
    internal static class Encryption
    {
        internal static string EncryptPassword(this string password)
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

    public class FileDialog
    {
        OpenFileDialog openFile = new OpenFileDialog();
        

    }

    public static class FilePathProcessing
    {
       
        public static string GetProductImagePath(this string productImagePath)
        {
            //string currentDictectoryPath = Directory.GetCurrentDirectory();

            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ProductImagepath = "D" + @currentDirectory + @"Media\productImage\" + productImagePath;
            return ProductImagepath.Replace("\\", "/");

        }
        public static string GetShopImagePath(this string shopImagePath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ShopImagepath = "D" + @currentDirectory + @"Media\shopImage\" + shopImagePath;
            return ShopImagepath.Replace("\\","/");

        }
        public static string GetStaffImagePath(this string staffImagePath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string StaffImagepath = "D" + @currentDirectory + @"Media\staffImage\" + staffImagePath;
            return StaffImagepath.Replace("\\", "/");

        }
        public static string GetCustomerImagePath(this string customerImagePath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\customerImage\" + customerImagePath;
            return CustomerImagepath.Replace("\\","/");
        }
        public static string GetIcons(this string iconsPath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string IconImagepath = "D" + @currentDirectory + @"Media\icons\" + iconsPath;
            return IconImagepath.Replace("\\", "/");
        }
        public static string GetIamgeIcons(this string ImageiconsPath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ImageIconImagepath = "D" + @currentDirectory + @"Media\icons\" + ImageiconsPath;
            return ImageIconImagepath.Replace("\\", "/");
        }
        public static string GetIamgeLogo(this string ImageLogoPath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ImageLogopath = "D" + @currentDirectory + @"Media\icons\" + ImageLogoPath;
            return ImageLogopath.Replace("\\", "/");
        }





        public static string  GetDefaultCustomer()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\customerImage\" + "default.png";
            return CustomerImagepath.Replace("\\", "/");
        }
        public static string GetDefaultProduct()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\productImage\" + "download.png";
            return CustomerImagepath.Replace("\\", "/");
        }
        public static string GetDefaultShop()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\shopImage\" + "default.png";
            return CustomerImagepath.Replace("\\", "/");
        }

        public static string GetAdminFilePath()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            return ("D" + @currentDirectory + "Manager\\administrator.txt").Replace("\\", "/");
        }

        public static string ReadAdminFileData()
        {
            return File.ReadAllText(GetAdminFilePath());
        }

        public static void WriteAdminFileData(string data)
        {
            File.WriteAllText(GetAdminFilePath(), data);
        }





        public static Image TurnToCustomerImage(this string Imagepath)
        {
            if (File.Exists(Imagepath))
                return Image.FromFile(Imagepath);
            else
                return Image.FromFile(GetDefaultCustomer());
        }


        public static Image TurnToProductImage(this string Imagepath)
        {
            if (File.Exists(Imagepath))
                return Image.FromFile(Imagepath);
            else
                return Image.FromFile(GetDefaultProduct());
        }




        public static Image TurnToShopImage(this string Imagepath)
        {
            if (File.Exists(Imagepath))
                return Image.FromFile(Imagepath);
            else
                return Image.FromFile(GetDefaultShop());
        }


        public static Image TurnToStaffImage(this string Imagepath)
        {
            if (File.Exists(Imagepath))
                return Image.FromFile(Imagepath);
            else
                return Image.FromFile(GetDefaultCustomer());
        }

        public static string GetProductImageDirectory()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ProductImagepath = "D" + @currentDirectory + @"Media\productImage\";
            return ProductImagepath.Replace("\\", "/");

        }
        public static string GetStaffImageDirectory()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ProductImagepath = "D" + @currentDirectory + @"Media\staffImage\";
            return ProductImagepath.Replace("\\", "/");

        }
        public static string GetCustomerImageDirectory()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\customerImage\";
            return CustomerImagepath.Replace("\\", "/");

        }
        public static string GetShopImageDirectory()
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string CustomerImagepath = "D" + @currentDirectory + @"Media\shopImage\";
            return CustomerImagepath.Replace("\\", "/");

        }
        public static void RenameFile(this string imagePath, string newName)
        {

        }
        public static void DeleteFile(this string path)
        {

        } 
        public static void CopyToProductImage(this string imagePath)
        {
            string currentDirectory = @Directory.GetCurrentDirectory().Substring(1, Directory.GetCurrentDirectory().Length - 14);
            string ProductImagepath = "D" + @currentDirectory + @"Media\productImage\";
            File.Copy(imagePath, ProductImagepath);
        }

    }

    public static class ImageConverter
    {

        public static string ConvertImageToByte(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return string.Join("",ms.ToArray());

        }
        public static Image ConvertByteToImage(string byteAsArray)
        {
            MemoryStream ms = new MemoryStream((byte[])byteAsArray.Split(' ').Cast<byte>());
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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
    
    internal static class MyDispose
    {
        internal static void RecursivelyDispose(this Control parent)
        {
            if(parent.Controls.Count > 0)
            {
                parent.Controls[0].Dispose();
                RecursivelyDispose(parent);
            }              
        }

    }

    public static class StringExtensionMethod
    {
        //code was copied in the stackoverflow,
        // but who cares, just take advantage of it
        public static int ToInt(this string Str)
        {
            if(Str == "False")
            {
                return 0;
            }
            else if(Str == "True")
            {
                return 1;
            }
            return int.Parse(Str);
        }

        public static bool ToBool(this string Str)
        {
            return Convert.ToBoolean(Str);
        }

        public static bool FilterKeyWord(this string Str, string keyword)
        {
            return LevenshtienDistance.findSimilarity(Str, keyword) > 0.2 ? true : false;
        }
        public static float ToFloat(this string Str)
        {
            return Convert.ToSingle(Str);

        }
        public static IEnumerable<char> ToDescription(this string Str)
        {
            string[] lines = Str.Split('\n');
            int limitEachLine = 60;
            //int count = 
            foreach(string line in lines)
            {
                foreach(char cha in line)
                {
                    if(limitEachLine == 0)
                    {
                        yield return '\n';
                        limitEachLine = 60;
                    }
                    limitEachLine--;
                    yield return cha;
                }
            }
        }
        public static int CalculatedDiscount(this string original, Voucher voucher)
        {
            if(voucher.VoucherType == "1" && original.ToInt() > voucher.MinAmount.ToInt())
            {
                 return original.ToInt() - voucher.FixedAmount.ToInt();
            }
            else if(voucher.VoucherType == "2")
            {
                int discount = original.ToInt() / 100 * voucher.Percentage.ToInt() > voucher.MaxAmount.ToInt() ? voucher.MaxAmount.ToInt() : original.ToInt() / 100 * voucher.Percentage.ToInt();
                return original.ToInt() - discount;
            }
            else
            {
                return 0;
            }
        }
        public static string TurnToPriceFormat(this string Str)
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(info, "{0:c}", Str);

        }
    }

    public static  class LevenshtienDistance
    {
        public static int getEditDistance(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            int[][] T = new int[m + 1][];
            for (int i = 0; i < m + 1; ++i)
            {
                T[i] = new int[n + 1];
            }

            for (int i = 1; i <= m; i++)
            {
                T[i][0] = i;
            }
            for (int j = 1; j <= n; j++)
            {
                T[0][j] = j;
            }

            int cost;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    cost = X[i - 1] == Y[j - 1] ? 0 : 1;
                    T[i][j] = Math.Min(Math.Min(T[i - 1][j] + 1, T[i][j - 1] + 1),
                            T[i - 1][j - 1] + cost);
                }
            }

            return T[m][n];
        }

        public static double findSimilarity(string x, string y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Strings must not be null");
            }

            double maxLength = Math.Max(x.Length, y.Length);
            if (maxLength > 0)
            {
                // optionally ignore case if needed
                return (maxLength - getEditDistance(x, y)) / maxLength;
            }
            return 1.0;
        }
    }
    public static class SimilarityPercentage
    {
        public static bool SimilarPercentage(this string Str, string Str1)
        {
            return CompareStrings(Str, Str1) > 0.4 ? true : false;
        }
        public static double CompareStrings(string str1, string str2)
        {
            List<string> pairs1 = WordLetterPairs(str1.ToUpper());
            List<string> pairs2 = WordLetterPairs(str2.ToUpper());

            int intersection = 0;
            int union = pairs1.Count + pairs2.Count;

            for (int i = 0; i < pairs1.Count; i++)
            {
                for (int j = 0; j < pairs2.Count; j++)
                {
                    if (pairs1[i] == pairs2[j])
                    {
                        intersection++;
                        pairs2.RemoveAt(j);//Must remove the match to prevent "AAAA" from appearing to match "AA" with 100% success
                        break;
                    }
                }
            }

            return (2.0 * intersection * 100) / union; //returns in percentage
                                                       //return (2.0 * intersection) / union; //returns in score from 0 to 1
        }
        // Gets all letter pairs for each
        private static List<string> WordLetterPairs(string str)
        {
            List<string> AllPairs = new List<string>();

            // Tokenize the string and put the tokens/words into an array
            string[] Words = Regex.Split(str, @"\s");

            // For each word
            for (int w = 0; w < Words.Length; w++)
            {
                if (!string.IsNullOrEmpty(Words[w]))
                {
                    // Find the pairs of characters
                    String[] PairsInWord = LetterPairs(Words[w]);

                    for (int p = 0; p < PairsInWord.Length; p++)
                    {
                        AllPairs.Add(PairsInWord[p]);
                    }
                }
            }
            return AllPairs;
        }

        // Generates an array containing every two consecutive letters in the input string
        private static string[] LetterPairs(string str)
        {
            int numPairs = str.Length - 1;
            string[] pairs = new string[numPairs];

            for (int i = 0; i < numPairs; i++)
            {
                pairs[i] = str.Substring(i, 2);
            }
            return pairs;
        }
    }



    #region GUI Control
    public static class ReadonytextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public static void HideCursor(this TextBox textBox)
        {
            textBox.GotFocus += (s1, e1) => {
                HideCaret(textBox.Handle);
            };
            textBox.Cursor = Cursors.Arrow;
        }

    }

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



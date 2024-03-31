using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ViewHomePage : Form
    {
        public ViewHomePage()
        {
            InitializeComponent();
            
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                                
            
            
        }
        public void login()
        {
            Account fdfdfd = new Account();
        }

        //Code for drag form using panel not controlbox
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }                                                
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_cotrol_MouseDown(object sender, MouseEventArgs e)
        {
            //code for drag form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void OpenChildForm(Form ChildForm, FlowLayoutPanel ParentForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.Controls.Add(ChildForm);
            ParentForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void FlowLayoutPanel_category_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Main(), flowLayoutPanel_product_list);
        }

        private void GroupBox3_MouseHover(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

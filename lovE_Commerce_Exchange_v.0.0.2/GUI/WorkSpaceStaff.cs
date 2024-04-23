using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class WorkSpaceStaff : Form
    {
        Form currentChildForm;
        CensorStaff CensorStaff;
        public WorkSpaceStaff( CensorStaff censorStaff)
        {
            InitializeComponent();
            this.CensorStaff = censorStaff;
        }


        void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;


            panel_staff_workspace_body.Controls.Add(currentChildForm);
            panel_staff_workspace_body.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();

        }

        private void WorkSpaceStaff_Load(object sender, EventArgs e)
        {

        }

        private void IconButton_orders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewStaffProduct());
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_staff_info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewStaffAccount());
        }

        private void WorkSpaceStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure, you're being navigated to home page!","Log out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                 Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void WorkSpaceStaff_ParentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Form closing nay");

        }
    }
}

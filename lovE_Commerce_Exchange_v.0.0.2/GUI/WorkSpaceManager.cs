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
    public partial class WorkSpaceManager : Form
    {
        Form currentChildForm;
        Manager manager;
        public WorkSpaceManager(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
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


            panel_manager_workspace_body.Controls.Add(currentChildForm);
            panel_manager_workspace_body.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();

        }
        private void IconButton_messenger_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_notification_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_category_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewManageCategory());
            
        }

        private void IconButton_user_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewManageUser());
        }

        private void WorkSpaceManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure, you're being navigated to home page!", "Log out", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void IconButton_administrator_Click(object sender, EventArgs e)
        {

        }
    }
}

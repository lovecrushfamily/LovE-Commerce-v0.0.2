using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GUI
{
    public partial class WorkSpaceCustomer : Form
    {
        private IconButton currentButton;
        private Form currentChildForm;

        public WorkSpaceCustomer()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if(sender != null)
            {
                //Deactivate the previous button
                DisableButton();

                // style button
                currentButton = sender as IconButton;
                currentButton.BackColor = SystemColors.ControlLight;
                currentButton.ForeColor = System.Drawing.Color.Black;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;

            }

        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = SystemColors.ControlLightLight;
                currentButton.ForeColor = System.Drawing.Color.DimGray;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
            }

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


            panel_customer_workspace_body.Controls.Add(currentChildForm);
            panel_customer_workspace_body.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
            
        }

        private void IconButton_account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewCustomerAccount());
        }

        private void IconButton_orders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewCustormerOrders());


        }

        private void IconButton_comment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewCustomerComment());


        }

        private void IconButton_notification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewNotifications());


        }

        private void IconButton_shop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void IconButton_messenger_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewCustomerMessenger());


        }
    }
}

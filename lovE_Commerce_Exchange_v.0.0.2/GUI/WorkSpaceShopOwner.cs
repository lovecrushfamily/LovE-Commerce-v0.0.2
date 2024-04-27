using BUS;
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

namespace GUI
{
    public partial class WorkSpaceShopOwner : Form
    {

        private IconButton currentButton;
        private Form currentChildForm;


        Customer customer;
        Shop shop;
        public WorkSpaceShopOwner()
        {
            InitializeComponent();
        }

        #region Delegate
        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void ObjectExternalLink(Entity entity);
        // Declare a new instance of the delegate (null)
        public ObjectExternalLink objectExternalLink;
        #endregion

        #region Using System.EventHandler
        //This's enough, perfect, shortest wat to deal with event => navigator form
        public event EventHandler EventExternalLink;
        #endregion


        public void  SetExternalObject(Shop shop)
        {                                                                      ;
            this.shop = Shop.GetShops().Single(sh => sh.ShopId == shop.ShopId);
            customer = Customer.GetCustomers().Single(cus => cus.CustomerId == shop.ShopOwner);
        }
        private void WorkSpaceShopOwner_Load(object sender, EventArgs e)
        {
            SetExternalObject(shop);

            label_shop_name.Text = shop.ShopName;
            label_shop_address.Text = shop.Address;
            label_shop_owner.Text = customer.CustomerName;
            label_shop_phone.Text = shop.PhoneNumber;


            Refresh();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                //Deactivate the previous button
                DisableButton();

                // style button
                currentButton = sender as IconButton;
                currentButton.BackColor = System.Drawing.Color.MediumPurple;
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


            panel_body.Controls.Add(currentChildForm);
            panel_body.Tag = currentChildForm;
            currentChildForm.BringToFront();

            if (currentChildForm.IsDisposed)
            {
                MessageBox.Show("disposed");
            }
            else
            {

                currentChildForm.Show();
            }


        }

        private void IconButton_account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewShopOrders(shop));
        }

        private void IconButton_comment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            SubViewShopComment subViewShopComment = new SubViewShopComment(shop);
            OpenChildForm(subViewShopComment);
        }

        private void IconButton_orders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            OpenChildForm(new SubViewShopProducts(shop));
        }

        private void IconButton_notification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            OpenChildForm(new SubViewShopVoucher());
        }

        private void IconButton_shop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewShopChat());
            ActivateButton(sender);

        }

        private void IconButton_messenger_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewNotifications());
            ActivateButton(sender);

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewShopDashBoard());
            ActivateButton(sender);

        }

        private void IconButton_shopInfor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubViewShopInfor(shop));
            ActivateButton(sender);

        }
    }
}

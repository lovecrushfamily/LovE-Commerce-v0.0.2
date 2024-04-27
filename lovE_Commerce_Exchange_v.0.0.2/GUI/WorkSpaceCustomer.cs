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
using System.Windows.Media;

namespace GUI
{
    
    public partial class WorkSpaceCustomer : Form
    {
        private IconButton currentButton;
        private Form currentChildForm;
        public string subviewkey;
        private Shop currentShop;
        private Account currentAccount;
        private Customer currentCustomer;

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

        SubViewCustormerOrders subViewCustormerOrders;
        SubViewCustomerComment SubViewCustomerComment;
        

        public WorkSpaceCustomer()
        {
            InitializeComponent();
            //SubViewNavigator();

            subViewCustormerOrders = new SubViewCustormerOrders();
            SubViewCustomerComment = new SubViewCustomerComment();
            subViewCustormerOrders.objectExternalLink += OpenObjectExternalLinkSubCustomerOrders;
            SubViewCustomerComment.objectExternalLink += OpenObjectExternalLinkComnent;

        }

       

        private void OpenObjectExternalLinkSubCustomerOrders(Entity entity)
        {
            if(entity is Product)
            {
                objectExternalLink((Product)entity);
            }
            else if(entity is OrderDetail)
            {
                SubViewCustomerComment.SetOrderDetail((OrderDetail)entity);
                IconButton_comment_Click(null,null);
            }
        }
        private void OpenObjectExternalLinkComnent(Entity entity)
        {
            //I dont know what's come up in my mind when i define it
            if(entity is Product)
            {
                objectExternalLink((Product)entity);
            }
            if(entity is Order)
            {
                subViewCustormerOrders.HeadingToRecieveOrder();
                IconButton_orders_Click(null,null);
            }
        }

        public void SetAccount(Account account)
        {
            this.currentAccount = account;
        }
        internal void SetCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            SubViewCustomerComment.SetCustomer(currentCustomer);

        }
        public void HeadingtoMessage(BUS.Message message)
        {
            //navigate here
            //using this message object to check, and navigate to the message GUI, little hard
            //especially using message.ReceivedId to check the one who you're heading for.

        }
        public void HeadingtoWaitingOrder()
        {
            //open waiting order;
        }


        #region GUI Control Effect
        private void ActivateButton(object sender)
        {
            if(sender != null)
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
        #endregion

        private void SubViewNavigator()
        {
            if(subviewkey == "accountInfor")
                OpenCustomerAccount();
            else if (subviewkey == "order")
                IconButton_orders_Click(null,null);
            else if(subviewkey == "messenger")
                IconButton_messenger_Click(null,null);  

        }


        #region Open Sub Form 
        void OpenChildForm(Form childForm)
        {
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
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
            OpenCustomerAccount();
            
        }
        private void OpenCustomerAccount()
        {
            OpenChildForm(new SubViewCustomerAccount(account: currentAccount, customer: currentCustomer));
        }

        //subViewCustormerOrders
        private void IconButton_orders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            subViewCustormerOrders.SetCustomer(currentCustomer);
            OpenChildForm(subViewCustormerOrders);


        }

        private void IconButton_comment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(SubViewCustomerComment);


        }

        private void IconButton_notification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewNotifications());


        }

        private void IconButton_shop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            if (currentCustomer.ShopOwner)
            {
                objectExternalLink(Shop.GetShops().SingleOrDefault(shop => shop.ShopOwner == currentCustomer.CustomerId));
                //return;
            }
            if (!currentCustomer.ShopOwner &&
                MessageBox.Show("You do not have any shop currently,\nWould you like to create your owner shop?","Create your own shop", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                new PopupShopRegister(currentCustomer).ShowDialog();
            }

        }

        private void IconButton_messenger_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SubViewCustomerMessenger());
        }




        #endregion

        private void WorkSpaceCustomer_Load(object sender, EventArgs e)
        {
            SubViewNavigator();
        }

        private void WorkSpaceCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            subviewkey = string.Empty;
        }

        private void IconButton_logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want log out, are you sure","Notice",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                objectExternalLink(currentAccount);

            }

        }
    }
}

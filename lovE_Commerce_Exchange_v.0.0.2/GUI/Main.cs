using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GUI
{
    public partial class Main : Form
    {
        Form currentChildForm;
        Account account;
        //Customer customer;

        public Main()
        {
            InitializeComponent();
            InitializeController();
            IconButton_home_Click(null, null);
        }

        public void InitializeDatasets(Account account)
        {
            this.account= account;
        }

        #region Panel Dragable Code, Ignore it
        //Code for drag form using panel not controlbox
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel_controlbox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
             //code for drag form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Controler
        private ViewProductDetail viewProductDetail;        
        private ViewShop viewShop;
        private ViewHomePage viewHomePage;
        private ViewProductSearch viewProductSearch;
        private ViewCategory viewCategory;
        private ViewShoppingCart viewShoppingCart;
        private ViewOrder viewOrder;

        private WorkSpaceCustomer workSpaceCustomer;
        private WorkSpaceShopOwner workSpaceShopOwner;

        private PopupSignIn SignIn;
        private PopupSignUp SignUp;


        private void InitializeController()
        {
            SignUp = new PopupSignUp();
            SignUp.objectExternalLink += OpenExternalSignUp;

            SignIn = new PopupSignIn();
            SignIn.objectExternalLink += OpenExternalSignIn;

            viewProductDetail = new ViewProductDetail();
            //viewProductDetail.EventExternalLink += ViewProductDetail_EventExternalLink;
            viewProductDetail.objectExternalLink += OpenExternalProductDetail;

            viewShop = new ViewShop();
            //viewShop.EventExternalLink += ViewShop_EventExternalLink;
            viewShop.objectExternalLink += OpenExternalLinkViewShop;
            
            viewHomePage = new ViewHomePage();
            //viewHomePage.EventExternalLink += ViewHomePage_EventExternalLink;
            viewHomePage.objectExternalLink += OpenExternalLinkViewHomePage;

            viewShoppingCart = new ViewShoppingCart();
            //viewShoppingCart.EventExternalLink += ViewShoppingCart_EventExternalLink;
            viewShoppingCart.objectExternalLink += OpenExternalLinkViewShoppingCart;

            viewProductSearch = new ViewProductSearch();
            //viewProductSearch.EventExternalLink += ViewProductSearch_EventExternalLink;
            viewProductSearch.objectExternalLink += OpenExternalLinkViewProductSearch;

            viewCategory = new ViewCategory();
            //viewCategory.EventExternalLink += ViewCategory_EventExternalLink;
            viewCategory.objectExternalLink += OpenExternalLinkViewCategory;

            viewOrder = new ViewOrder();
            viewOrder.objectExternalLink += OpenExternalLinkViewOrder;

            workSpaceCustomer = new WorkSpaceCustomer();
            //workSpaceCustomer.EventExternalLink += WorkSpaceCustomer_EventExternalLink;
            workSpaceCustomer.objectExternalLink += OpenExternalLinkCustomerWorkspace;

            workSpaceShopOwner = new WorkSpaceShopOwner();
            //workSpaceShopOwner.EventExternalLink += WorkSpaceShopOwner_EventExternalLink; 
            workSpaceShopOwner.objectExternalLink += OpenExternalLinkShopOwnerWorkspace;
        }

        private void OpenExternalForgetPassword(Entity entity)
        {

        }

        private void OpenExternalSignIn(Entity entity)
        {
            if(entity is Account)
            {
                InitializeDatasets((Account)entity);
                viewShoppingCart.SetAccount((Account)entity);
            }
            if(entity is CensorStaff)
            {
                SignIn.Hide();
                (new WorkSpaceStaff((CensorStaff)entity)).ShowDialog();

            } if(entity is Manager)
            {
                SignIn.Hide();
                new WorkSpaceManager((Manager)entity).ShowDialog(); ;
            } if(entity is Customer)
            {
                workSpaceCustomer.SetCustomer((Customer)entity);
                //OpenChildForm(workSpaceCustomer);
            }
            if(entity is Category)
            {
                SignIn.Close();
                new PopupSignUp().ShowDialog();
            }
            if(entity is Comment)
            {
                SignIn.Close();
                new PopupForgetPassword().ShowDialog();
            }

        }

        private void OpenExternalSignUp(Entity entity)
        {
            //if(entity is ShoppingCart)
            //{
            //    SignIn.Close();
            //    SignUp.ShowDialog();

            //}

        }

        private void OpenExternalLinkViewOrder(Entity entity)
        {
            if( entity is ShoppingCart)
            {
                OpenChildForm(viewShoppingCart);
            }
            else if( entity is Product)
            {
                OpenChildForm(viewProductDetail);
            }      else if(entity is Account)
            {
                workSpaceCustomer.HeadingtoWaitingOrder();
                OpenChildForm(workSpaceCustomer);
            }
                  
            else if(entity is Customer)
            {
                OpenChildForm(viewHomePage);
            }
           
            
        }

        private void OpenExternalLinkViewProductSearch(Entity entity)
        {
            if (entity is Product)
            {
                viewProductDetail.SetExternalObject((Product)entity);
                OpenChildForm(viewProductDetail);
            }
        }

        private void OpenExternalLinkViewHomePage(Entity entity)
        {
            if(entity is Product)
            {
                viewProductDetail.SetExternalObject((Product)entity);
                OpenChildForm(viewProductDetail);
            } else if (entity is Category)
            {
                viewCategory.SetExternalObject((Category)entity);
                OpenChildForm(viewCategory);
            }    
        }

        private void OpenExternalLinkShopOwnerWorkspace(Entity entity)
        {

        }

        private void OpenExternalLinkCustomerWorkspace(Entity entity)
        {
            if(entity is Shop)
            {
                workSpaceShopOwner.SetExternalObject((Shop)entity);
                OpenChildForm(workSpaceShopOwner);
            }
            if(entity is Account)
            {
                workSpaceCustomer = new WorkSpaceCustomer();
                //workSpaceCustomer.EventExternalLink += WorkSpaceCustomer_EventExternalLink;
                workSpaceCustomer.objectExternalLink += OpenExternalLinkCustomerWorkspace;
                account = null;
                OpenChildForm(viewHomePage);
            }

        }

        private void OpenExternalLinkViewCategory(Entity entity)
        {
            if (entity is Product)
            {
                viewProductDetail.SetExternalObject((Product)entity);
                OpenChildForm(viewProductDetail);
            } else if(entity is Category)
            {
                viewCategory.SetExternalObject((Category)entity);
                OpenChildForm(viewCategory);
            }       else if( entity is ShoppingCart)
            {
                OpenChildForm(viewHomePage);
            }
            

        }

        private void OpenExternalLinkViewShoppingCart(Entity entity)
        {
            if(entity is Product)
            {
                viewProductDetail.SetExternalObject((Product)entity);
                OpenChildForm(viewProductDetail);
            }
            else if( entity is Shop)
            {

                viewShop.SetExternalObject((Shop)entity);
                OpenChildForm(viewShop);
            }
            //open ViewOrder

            else if (entity is OrderDetail)
            {
                viewOrder.SetExternalObject((OrderDetail)entity);
            }
            else if (entity is Customer)
            {
                viewOrder.SetExternalObject(account);
                viewOrder.rjButton_changeToCart.Enabled = true;
                OpenChildForm(viewOrder);
            } 
            else if (entity is ShoppingCart)
            {
                viewOrder.SetExternalObject((ShoppingCart)entity);
            }
        }

        private void OpenExternalLinkViewShop(Entity entity)
        {
            if (entity is Product)
            {
                viewProductDetail.SetExternalObject((Product)entity);
                OpenChildForm(viewProductDetail);
            }
            if (entity is BUS.Message)
            {
                workSpaceCustomer.HeadingtoMessage((BUS.Message)entity);
                OpenChildForm(workSpaceCustomer);
            }
        }

       






        private void OpenExternalProductDetail(Entity entity)
        {
            if(entity is Shop)
            {
                viewShop.SetExternalObject((Shop) entity);
                OpenChildForm(viewShop);
            }
            
            if (entity is BUS.Message)
            {
                workSpaceCustomer.HeadingtoMessage((BUS.Message)entity);
                OpenChildForm(workSpaceCustomer);
            } 


            if(entity is ShoppingCart)
            {
                //using it to clear the orderdetail list before
                viewOrder.SetExternalObject((ShoppingCart)entity);
            }
            //open ViewOrder
             if (entity is OrderDetail)
            {
                viewOrder.SetExternalObject((OrderDetail)entity);
            }  if( entity is Customer)
            {
                if (account is null)
                {
                    SignIn.ShowDialog();
                    return;
                }
                viewOrder.SetExternalObject(account);
                viewOrder.rjButton_changeToCart.Enabled = false;
                OpenChildForm(viewOrder);
            }



             if( entity is Product)
            {
                if(account is null)
                {
                    SignIn.ShowDialog();
                    return;
                }
                viewShoppingCart.SetAccount(account);
                viewShoppingCart.SetExternalObject((Product)entity);
            }



             if(entity is Category)
            {
                viewCategory.SetExternalObject((Category)entity);
                OpenChildForm(viewCategory);
            }

            if (entity is Comment)
            {
                //using it to navogate to homepage
                OpenChildForm(viewHomePage);
            }

        }



        void OpenChildForm(Form childForm)
        {
            //If  uncomment this check, got error cannot access disposed childform
            //be carefull
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;


            panel_body.Controls.Add(currentChildForm);
            //currentChildForm.AutoScaleMode = AutoScaleMode.Dpi;
            panel_body.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        

        private void IconButton_shoppingcart_Click(object sender, EventArgs e)
        {
            if (account is null)
            {
                SignIn.ShowDialog();
                return;
            }
            viewShoppingCart.SetAccount(account);
            OpenChildForm(viewShoppingCart);
        }

        private void IconButton_account_centre_Click(object sender, EventArgs e)
        {
            if(account != null)
            {
                workSpaceCustomer.SetAccount(account);
                OpenChildForm(workSpaceCustomer);
            }else
            {
                SignIn.ShowDialog();
            }

        }

        private void IconButton_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(viewHomePage);
        }
        
        private void IconButton_search_Click(object sender, EventArgs e)
        {
            viewProductSearch.SearchKeyWord(textBox_search.Text);
            OpenChildForm(viewProductSearch);
        }





        #endregion











        

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void PictureBox_logo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkSpaceManager(new Manager(new DLL.Manager_())));
        }

        private void GradientLabel1_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new WorkSpaceStaff();
        }


        private void Label_Click(object sender, EventArgs e)
        {
            textBox_search.Text = (sender as Label).Text;
            IconButton_search_Click(null, null);
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            
        }
















        #region Suggest and recommend product Name (Dangerous area, be carefull)
        string[] productName = Product.GetProducts().Select(pro => pro.ProductName).ToArray();










        #endregion

















































        private void Panel_cotrol_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
                   
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void GradientLabel3_Click(object sender, EventArgs e)
        {

        }

        private void GradientLabel4_logo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Size.ToString());
        }
    }
}

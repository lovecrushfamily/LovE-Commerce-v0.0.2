using BUS;
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
using System.Windows.Input;

namespace GUI
{
    public partial class Main : Form
    {
        Form currentChildForm;
        Account accounts;
        Customer customer;

        public Main()
        {
            InitializeComponent();
            InitializeDatasets();
            InitializeController();
            IconButton_home_Click(null, null);
        }

        private void InitializeDatasets()
        {

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

        private WorkSpaceCustomer workSpaceCustomer;
        private WorkSpaceShopOwner workSpaceShopOwner;


        private void InitializeController()
        {
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
            viewProductDetail.objectExternalLink += OpenExternalLinkViewProductDetail;

            viewCategory = new ViewCategory();
            //viewCategory.EventExternalLink += ViewCategory_EventExternalLink;
            viewCategory.objectExternalLink += OpenExternalLinkViewCategory;

            workSpaceCustomer = new WorkSpaceCustomer();
            //workSpaceCustomer.EventExternalLink += WorkSpaceCustomer_EventExternalLink;
            workSpaceCustomer.objectExternalLink += OpenExternalLinkCustomerWorkspace;

            workSpaceShopOwner = new WorkSpaceShopOwner();
            //workSpaceShopOwner.EventExternalLink += WorkSpaceShopOwner_EventExternalLink; 
            workSpaceShopOwner.objectExternalLink += OpenExternalLinkShopOwnerWorkspace;
        }

        private void OpenExternalLinkViewHomePage(Entity entity)
        {
            if(entity is Product)
            {
                viewProductDetail.SetProduct((Product)entity);
                OpenChildForm(viewProductDetail);
            } else if (entity is Category)
            {
                viewCategory.SetCategory((Category)entity);
                OpenChildForm(viewCategory);
            }    
        }

        private void OpenExternalLinkShopOwnerWorkspace(Entity entity)
        {

        }

        private void OpenExternalLinkCustomerWorkspace(Entity entity)
        {

        }

        private void OpenExternalLinkViewCategory(Entity entity)
        {

        }

        private void OpenExternalLinkViewProductDetail(Entity entity)
        {

        }

        private void OpenExternalLinkViewShoppingCart(Entity entity)
        {

        }


        private void OpenExternalLinkViewShop(Entity entity)
        {

        }

       
        private void OpenExternalProductDetail(Entity entity)
        {
            if(entity is Shop)
            {
                viewShop.SetShop((Shop) entity);
                OpenChildForm(viewShop);
            }
        }
        #endregion


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
            panel_body.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }
        private void IconButton_shoppingcart_Click(object sender, EventArgs e)
        {
            OpenChildForm(viewShoppingCart);
        }

        private void IconButton_account_centre_Click(object sender, EventArgs e)
        {
            OpenChildForm(workSpaceCustomer);
        }

        private void IconButton_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(viewHomePage);
        }
        
        private void IconButton_search_Click(object sender, EventArgs e)
        {
            OpenChildForm(viewProductSearch);
        }
        //private event 
















        

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
    }
}

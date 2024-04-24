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
    public partial class ViewShop : Form
    {
        Shop shop;
        

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

        public ViewShop()
        {
            InitializeComponent();
            label21.BringToFront();
            panel_optionContainer.BringToFront();
        }

        public void SetExternalObject(Shop shop)
        {
            this.shop = shop;
            LoadedEverything();
            //LoadCategory();


        }

        private void LoadedEverything()
        {

        }
        private void ViewShop_Load(object sender, EventArgs e)
        {
            label_shopName.Text = shop.ShopName;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Product(new DLL.Product_() { }));
        }

        private void IconButton_chatShop_Click(object sender, EventArgs e)
        {
            objectExternalLink(new BUS.Message(new DLL.Message_() { ReceivedId = shop.ShopOwner}));
        }

        private void IconButton_search_Click(object sender, EventArgs e)
        {
            //search algprith, here
        }
    }
}

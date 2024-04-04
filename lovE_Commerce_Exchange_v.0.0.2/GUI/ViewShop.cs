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
        public ViewShop()
        {
            InitializeComponent();
        }

        public void SetShop(Shop shop)
        {
            this.shop = shop;

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

        private void ViewShop_Load(object sender, EventArgs e)
        {
            label1.Text = shop.ShopName;
        }
    }
}

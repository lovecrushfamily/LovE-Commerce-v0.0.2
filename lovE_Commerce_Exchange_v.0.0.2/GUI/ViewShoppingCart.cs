using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ViewShoppingCart : Form
    {
        ShoppingCart[] shoppingCarts;
        Customer customer;
        Product[] products;
        Voucher[] vouchers;
        Shop[] shops;

        public ViewShoppingCart()
        {
            InitializeComponent();
            InitializeDatasets();
            //this.customer = customer;
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

        public void SetExternalObject(Product product)
        {
            
            ShoppingCart shoppingCart = new ShoppingCart(new DLL.ShoppingCart_()
            {
                ProducID = product.ProductId,
                CustomerId = customer.CustomerId
            }) ;shoppingCart.AddProduct();
            MessageBox.Show("Product added !");
        }

        private void InitializeDatasets()
        {
            shoppingCarts = ShoppingCart.GetShoppingCarts().Where(shop => shop.CustomerId == customer.CustomerId).ToArray();
            
        }
        public void SetAccount(Account account)
        {
            customer = Customer.GetCustomers().Single(cus => cus.CustomerId == account.AccountID);
        }
        private void ShoppingCart_Resize(object sender, EventArgs e)
        {
            if (panel_product.VerticalScroll.Visible)
            {
                panel_product_tittle.Padding = new Padding(25, 5, 45, 5);
            }
            else
            {
                panel_product_tittle.Padding = new Padding(25, 5, 25, 5);

            }
        }
        private void ViewShoppingCart_Load(object sender, EventArgs e)
        {
                  // do everything here
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_quantityUp_Click(object sender, EventArgs e)
        {
            if (myNumericUpDown_quantity.Value <99)
                myNumericUpDown_quantity.Value += 1;
        }

        private void IconButton_quantityDown_Click(object sender, EventArgs e)
        {
            if (myNumericUpDown_quantity.Value > 0)
                myNumericUpDown_quantity.Value -= 1;
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_product_name_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Product(new DLL.Product_() { }));
        }

        private void Button_shop_name_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Shop(new DLL.Shop_() { }));
        }

        private void RjButton_purcharse_Click(object sender, EventArgs e)
        {
            //open ViewOrder 
            objectExternalLink(new Order(new DLL.Order_()));
            foreach(OrderDetail orderDetail in ReturnOrderDetailFromCart())
            {
                objectExternalLink(orderDetail);
            }
            objectExternalLink(new Customer(new DLL.Customer_()));
        }

        private IEnumerable<OrderDetail> ReturnOrderDetailFromCart()
        {
            //demo
            yield return new OrderDetail(new DLL.OrderDetail_()) { };
        }

      
    }
}

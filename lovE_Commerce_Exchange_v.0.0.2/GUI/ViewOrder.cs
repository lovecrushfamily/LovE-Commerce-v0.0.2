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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class ViewOrder : Form
    {
        Order order;
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        Customer customer;

        public ViewOrder()
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void SetExternalObject(Entity entity)
        {
            if(entity is Order)
            {
                order = (Order)entity;
            } else if(entity is Customer)
            {
                customer = (Customer)entity;
            } else if (entity is OrderDetail)
            {
                orderDetails.Add((OrderDetail)entity);

            }

        }
        public void ResetOrders()
        {
            order = null;
            customer = null;
            orderDetails.Clear();
        }

        private void RjButton_purcharse_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure");
            //add Order Here
            order.Add();
            orderDetails = (List<OrderDetail>)orderDetails.Select(d => d.OrderId = order.OrderId);
            foreach (OrderDetail detail in orderDetails)
            {
                //detail.OrderId = order.OrderId;
                detail.Add();
            }
        }

        private void Label_change_Click(object sender, EventArgs e)
        {
            objectExternalLink(new ShoppingCart(new DLL.ShoppingCart_()));
        }

        private void PictureBox_productImage_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Product(new DLL.Product_()));
        }
    }
}

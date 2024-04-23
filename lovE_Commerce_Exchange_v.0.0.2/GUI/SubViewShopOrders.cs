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
    public partial class SubViewShopOrders : Form
    {
        IconButton currentActivatedButton;
        Panel currentDropDownpanel;

        Shop shop;
        Product[] products;
        Order[] orders;
        OrderDetail[] ordersDetail;
        Customer[] customers;


        public SubViewShopOrders()
        {
            InitializeComponent();
            //InitializeDatesets();
            panel_optionContainer.BringToFront();
        }
        public void SetShop(Shop shop)
        {
            this.shop = shop;
        }

        private void InitializeDatesets()
        {
            // get all product belongs to this shop
            products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();
            // get all orderdetail involved to these product
            ordersDetail = OrderDetail.GetOrderDetails().Join(products, od => od.ProductId,
                                                                        pro => pro.ProductId,
                                                                        (od, pro) => od).ToArray();
            // get all order related to these orderdetail
            orders  = Order.GetOrders().Join(ordersDetail, order => order.OrderId,
                                                             orderdetail => orderdetail.OrderId,
                                                             (order, orderdetail) => order).ToArray();
            //get all customer has bought this order
            customers = Customer.GetCustomers().Join(orders, customer => customer.CustomerId,
                                                                order => order.CustomerID,
                                                                (customer, order) => customer).ToArray();
        }
        private void FillAllShopOrders()
        {
            // get all orderdetail which orderdetailconfirmstate is true, it indicated that your order is waiting confirm
            FillAllWaitingOrder(ordersDetail.Where(orderdetail => orderdetail.OrderDetailConfirmState).ToArray());
            // get all confirmed order
            FillAllConfirmedOrder(ordersDetail.Where(orderdetail => !orderdetail.OrderDetailConfirmState).ToArray());
            // get all cancelled order, using join to order, order is which hold the customerOrderState, we must have that to  know whether customer cancel or not
            FillAllCancelledOrder(ordersDetail.Join(orders.Where(ord => ord.CustomerOrderState),
                                 orderdetail => orderdetail.OrderId, ord => ord.OrderId,
                                 (ordersdetail, ord) => ordersdetail).ToArray());
        }

        private void Timer_dropDown_Tick(object sender, EventArgs e)
        {
            if(currentActivatedButton.IconChar == IconChar.AngleUp)
            {
                currentDropDownpanel.Height += 10;
                if(currentDropDownpanel.Size.Height == currentDropDownpanel.MaximumSize.Height)
                {
                    timer_dropDown.Stop();
                    currentActivatedButton.IconChar = IconChar.AngleDown;
                }
            } else
            {
                currentDropDownpanel.Height -= 10;
                if (currentDropDownpanel.Size.Height == currentDropDownpanel.MinimumSize.Height)
                {
                    currentActivatedButton.IconChar = IconChar.AngleUp;
                    timer_dropDown.Stop();
                }
            }

        }
        private void IconButton_customerDetail_Click(object sender, EventArgs e)
        {
            currentActivatedButton = (IconButton)sender;
            currentDropDownpanel = (Panel)currentActivatedButton.Parent.Controls.Find("panel_OrderDetail", true)[0];
            timer_dropDown.Start();
        }

        private void RjButton_referAll_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_confirmAll_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_waitingOrders_Click(object sender, EventArgs e)
        {
            tabControl_Orders.SelectedTab = tabPage_waitingOrders;
        }

        private void IconButton_confirmedOrders_Click(object sender, EventArgs e)
        {
            tabControl_Orders.SelectedTab = tabPage_comfirmedOrders;
        }

        private void IconButton_cancelledOrder_Click(object sender, EventArgs e)
        {
            tabControl_Orders.SelectedTab =tabPage_cancelledOrders;
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }







        private void FillAllWaitingOrder(OrderDetail[] orderDetails)
        {
            foreach(OrderDetail orderDetail in orderDetails)
            {
                panel_allFatherWaitingOrders.Controls.Add(GenerateWaitingOrder(orderDetail, products.Single(pro => pro.ProductId == orderDetail.ProductId)));
            }
        }
        private GroupBox GenerateWaitingOrder(OrderDetail orderDetail,Product product)
        {
            Order order = orders.Single(ord => ord.OrderId == orderDetail.OrderId);
            GroupBox groupBox = new GroupBox();
            //property here


            groupBox.Controls.Add(GenerateCustomerWaitingOrderInfor(order,customers.Single(cus => cus.CustomerId == order.CustomerID)));
            return groupBox;

        }
        private Panel GenerateCustomerWaitingOrderInfor(Order order, Customer customer)
        {
            Panel panel = new Panel();


            return panel;
        }












        private void FillAllConfirmedOrder(OrderDetail[] orderDetails)
        {
            foreach (OrderDetail orderDetail in orderDetails)
            {
                panel_allFatherConfirmedOrders.Controls.Add(GenerateConfirmedOrder(orderDetail, products.Single(pro => pro.ProductId == orderDetail.ProductId)));
            }
        }
        private GroupBox GenerateConfirmedOrder(OrderDetail orderDetail, Product product)
        {
            Order order = orders.Single(ord => ord.OrderId == orderDetail.OrderId);
            GroupBox groupBox = new GroupBox();
            //property here


            groupBox.Controls.Add(GenerateCustomerConfirmedOrderInfor(order, customers.Single(cus => cus.CustomerId == order.CustomerID)));
            return groupBox;

        }
        private Panel GenerateCustomerConfirmedOrderInfor(Order order, Customer customer)
        {
            Panel panel = new Panel();


            return panel;
        }












        private void FillAllCancelledOrder(OrderDetail[] orderDetails)
        {
            foreach(OrderDetail orderDetail in orderDetails)
            {
                panel_allFatherCancelledOrders.Controls.Add(GenerateCancelledOrder(orderDetail, products.Single(pro => pro.ProductId == orderDetail.ProductId)));
            }

        }
        private GroupBox GenerateCancelledOrder(OrderDetail orderDetail, Product product)
        {
            Order order = orders.Single(ord => ord.OrderId == orderDetail.OrderId);
            GroupBox groupBox = new GroupBox();
            //property here


            groupBox.Controls.Add(GenerateCustomerCancelledOrderInfor(order, customers.Single(cus => cus.CustomerId == order.CustomerID)));
            return groupBox;

        }
        private Panel GenerateCustomerCancelledOrderInfor(Order order, Customer customer)
        {
            Panel panel = new Panel();


            return panel;
        }

        private void RjTextBox_searchWaitingOrders__TextChanged(object sender, EventArgs e)
        {

        }

        private void IconButton7_Click(object sender, EventArgs e)
        {

        }
    }
}

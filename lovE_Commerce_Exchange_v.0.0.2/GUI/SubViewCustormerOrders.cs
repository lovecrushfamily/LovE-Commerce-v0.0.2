using BUS;
using CustomControls.RJControls;
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
    public partial class SubViewCustormerOrders : Form
    {
        //datesets
        Customer customer;
        Order[] orders;
        OrderDetail[] orderDetails;
        Product[] products;
        Shop[] shops;



        public SubViewCustormerOrders()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            ActivateWaitingOrder();
            //InitializeDatasets();

        }
        public void SetCustomer(Customer customer)
        {
            this.customer = customer;

        }
        private void InitializeDatasets()
        {
            //get all orders belong to this customer,
            orders = Order.GetOrders().Where(ord => ord.CustomerID == customer.CustomerId).ToArray();

            //get all orderdetail belong to these orders
            orderDetails = OrderDetail.GetOrderDetails().Join(orders,
                                                               orderdetail => orderdetail.OrderId,
                                                               order => order.OrderId,
                                                               (orderdetail, order) => orderdetail).ToArray();
            products = Product.GetProducts().Join(orderDetails,
                                                    pro => pro.ProductId,
                                                    orderdetail => orderdetail.ProductId,
                                                    (pro, orderdetail) => pro).ToArray();

        }


        //change tab effect
        IconButton currentButton;
        //dropdown effect
        IconButton currentActivatedButton;
        Panel currentDropDownpanel;
        private void IconButton_expandProductDetail_Click(object sender, EventArgs e)
        {
            currentActivatedButton = (IconButton)sender;
            currentDropDownpanel = (Panel)currentActivatedButton.Parent.Controls.Find("panel_OrderDetail", true)[0];
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (currentActivatedButton.IconChar == IconChar.AngleUp)
            {
                currentDropDownpanel.Height += 10;
                if (currentDropDownpanel.Size.Height == currentDropDownpanel.MaximumSize.Height)
                {
                    timer1.Stop();
                    currentActivatedButton.IconChar = IconChar.AngleDown;
                }
            }
            else
            {
                currentDropDownpanel.Height -= 10;
                if (currentDropDownpanel.Size.Height == currentDropDownpanel.MinimumSize.Height)
                {
                    currentActivatedButton.IconChar = IconChar.AngleUp;
                    timer1.Stop();
                }
            }
        }


        //change tabcontrol effects
        private void ActivateWaitingOrder()
        {
            currentButton = iconButton_waitingOrders;
            currentButton.IconColor = Color.DodgerBlue;
            TabControl_Orders.SelectedTab = tabPage_waitingOrders;
        }
        private void IconButton_allProduct_Click(object sender, EventArgs e)
        {
            TabControl_Orders.SelectedTab = tabPage_waitingOrders;
            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
        }
        private void IconButton_confirmedOrders_Click(object sender, EventArgs e)
        {
            TabControl_Orders.SelectedTab = tabPage_confirmedOrders;
            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
        }
        private void IconButton_recievedOrder_Click(object sender, EventArgs e)
        {
            TabControl_Orders.SelectedTab = tabPage_RecievedOrder;
            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
        }
        private void IconButton_cancelledOrder_Click(object sender, EventArgs e)
        {
            TabControl_Orders.SelectedTab = tabPage_cancelledOrder;
            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
        }











        private void FillAllWaitingOrders(Order[] orders, OrderDetail[] orderDetails)
        {
            OrderDetail[] OrdersOrderDetail = new OrderDetail[] { };
            foreach (Order order in orders)
            {
                if (true)
                {
                    OrdersOrderDetail = orderDetails.Where(od => od.OrderId == order.OrderId).ToArray();
                    panel_allfatherWaitingOrders.Controls.Add(GenerateWaitingOrders(
                        order,
                        OrdersOrderDetail,
                        OrdersOrderDetail.Join(products,
                                                od => od.ProductId,
                                                pro => pro.ProductId,
                                                (od, pro) => pro)));

                }
            }
        }
        
        private GroupBox GenerateWaitingOrders(Order order, OrderDetail[] orderDetails, IEnumerable<Product> products)
        {

            GroupBox groupBox = new GroupBox();

            foreach (var tuple in orderDetails.Zip(products, Tuple.Create))
            {
                groupBox.Controls.Add(GenerateWaitingOrderDetail(tuple.Item1, tuple.Item2, shops.Single(sp => sp.ShopId == tuple.Item2.ShopID)));
            }
            return groupBox;

        }
        private Panel GenerateWaitingOrderDetail(OrderDetail orderDetail, Product products, Shop shop)
        {
            Panel panel = new Panel();
            //property

            return panel;
        }










        private void FillAllComfirmedOrders(Order[] orders, OrderDetail[] orderDetails)
        {
            OrderDetail[] OrdersOrderDetail = new OrderDetail[] { };
            foreach (Order order in orders)
            {
                if (true)
                {
                    OrdersOrderDetail = orderDetails.Where(od => od.OrderId == order.OrderId).ToArray();
                    panel_allFatherComfirmOrder.Controls.Add(GenerateConfirmedOrder(
                        order,
                        OrdersOrderDetail,
                        OrdersOrderDetail.Join(products,
                                                od => od.ProductId,
                                                pro => pro.ProductId,
                                                (od, pro) => pro)));

                }
            }

        }
        private GroupBox GenerateConfirmedOrder(Order order, OrderDetail[] orderDetails, IEnumerable<Product> products)
        {
            GroupBox groupBox = new GroupBox();

            foreach (var tuple in orderDetails.Zip(products, Tuple.Create))
            {
                groupBox.Controls.Add(GenerateConfirmedOrderDetail(tuple.Item1, tuple.Item2, shops.Single(sp => sp.ShopId == tuple.Item2.ShopID)));
            }
            return groupBox;

        }
        private Panel GenerateConfirmedOrderDetail(OrderDetail orderDetails, Product products, Shop shop)
        {
            Panel panel = new Panel();







            return panel;

        }








        private void FillAllReceivedOrders(Order[] orders, OrderDetail[] orderDetails)
        {
            OrderDetail[] OrdersOrderDetail = new OrderDetail[] { };
            foreach (Order order in orders)
            {
                if (true)
                {
                    OrdersOrderDetail = orderDetails.Where(od => od.OrderId == order.OrderId).ToArray();
                    panel_allFatherReceivedOrder.Controls.Add(GenerateReceivedOrder(
                        order,
                        OrdersOrderDetail,
                        OrdersOrderDetail.Join(products,
                                                od => od.ProductId,
                                                pro => pro.ProductId,
                                                (od, pro) => pro)));
                }
            }

        }
        private GroupBox GenerateReceivedOrder(Order order,OrderDetail[] orderDetails,IEnumerable<Product> products)
        {

            GroupBox groupBox = new GroupBox();

            foreach (var tuple in orderDetails.Zip(products, Tuple.Create))
            {
                if (true)// chỗ này nhiều khi cũng cần check chi tiết đơn hàng
                {
                    groupBox.Controls.Add(GenerateReceivedOrderDetail(tuple.Item1, tuple.Item2, shops.Single(sp => sp.ShopId == tuple.Item2.ShopID)));

                }

            }
            return groupBox;
        }
        private Panel GenerateReceivedOrderDetail(OrderDetail orderDetails, Product products,Shop shop)
        {
            Panel panel = new Panel();







            return panel;

        }










        private void FillAllCancelledOrders(Order[] orders , OrderDetail[] orderDetails, Product[] products)
        {
            OrderDetail[] OrdersOrderDetail = new OrderDetail[] { };

            foreach (Order order in orders)
            {
                if(true)// check điều kiện xem như nào thì goi là 1 đơn hàng bị hủy
                {
                    OrdersOrderDetail = orderDetails.Where(od => od.OrderId == order.OrderId).ToArray();
                    panel_allFatherCancelledOrders.Controls.Add(GenerateCancelledOrder(
                        order, 
                        OrdersOrderDetail,
                        OrdersOrderDetail.Join( products,
                                                od => od.ProductId, 
                                                pro => pro.ProductId,
                                                (od, pro) => pro)));
                }
            }

        }                                                                
        
        private GroupBox GenerateCancelledOrder(Order order, OrderDetail[] orderDetails, IEnumerable<Product> products)
        {
            // process two array, orderdetail and product
            
            GroupBox groupBox = new GroupBox();

            foreach (var tuple in orderDetails.Zip(products, Tuple.Create))
            {
                if(true)// chỗ này nhiều khi cũng cần check chi tiết đơn hàng
                {
                    groupBox.Controls.Add(GenerateCancelledOrderDetail(tuple.Item1,tuple.Item2, shops.Single(sp => sp.ShopId == tuple.Item2.ShopID)));

                }

            }
            return groupBox;                                            
        }

        private Panel GenerateCancelledOrderDetail(OrderDetail orderDetails, Product product, Shop shop)
        {
            Panel panel = new Panel();







            return panel;
        }

























        private void Panel_optionContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button_shopName_Click(object sender, EventArgs e)
        {
            //objectExternalLink();
        }

        private void SubViewCustormerOrders_Load(object sender, EventArgs e)
        {

        }

        private void RjCircularPictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SubViewShopOrders : Form
    {
        IconButton currentActivatedButton;
        Panel currentDropDownpanel;

        Shop shop;
        Product[] products;
        Order[] orders;
        OrderDetail[] ordersDetail;
        Customer[] customers;


        public SubViewShopOrders(Shop shop)
        {
            this.shop = shop;
            InitializeComponent();
            panel_optionContainer.BringToFront();
            FillEverything();
        }
        public void FillEverything()
        {
            InitializeDatesets();
            FillAllShopOrders();

        }


        private void InitializeDatesets()
        {
            // get all product belongs to shop
            products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();
            // get all orderdetail involved to these product
            ordersDetail = OrderDetail.GetOrderDetails().Join(products, od => od.ProductId,
                                                                        pro => pro.ProductId,
                                                                        (od, pro) => od).ToArray();
            // get all order related to these orderdetail
            orders = Order.GetOrders().Where(order => ordersDetail.Any(ordert => ordert.OrderId == order.OrderId)).ToArray();

            //get all customer has bought order
            customers = Customer.GetCustomers().Where(customer => orders.Any( order => order.CustomerID == customer.CustomerId)).ToArray();
                                                             
        }
        private void FillAllShopOrders()
        {
            // get all orderdetail which orderdetailconfirmstate is true, it indicated that your order is waiting confirm
            FillAllWaitingOrder(ordersDetail.Where(orderdetail => !orderdetail.OrderDetailConfirmState).ToArray());
            //get all confirmed order
            FillAllConfirmedOrder(ordersDetail.Where(orderdetail => orderdetail.OrderDetailConfirmState).ToArray());
            // get all cancelled order, using join to order, order is which hold the customerOrderState, we must have that to  know whether customer cancel or not
            ///FillAllCancelledOrder(ordersDetail.Join(orders.Where(ord => ord.CustomerOrderState),
            //                     orderdetail => orderdetail.OrderId, ord => ord.OrderId,
            //                     (ordersdetail, ord) => ordersdetail).ToArray());
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
            currentDropDownpanel = (Panel)currentActivatedButton.Parent.Controls.Find("panel_customerInfor", true)[0];
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
            panel_allFatherWaitingOrders.Controls.Clear();
            foreach (OrderDetail orderDetail in orderDetails)
            {
                Order order = orders.Single(ord => ord.OrderId == orderDetail.OrderId);
                panel_allFatherWaitingOrders.Controls.Add(GenerateWaitingOrder(orderDetail, 
                    products.Where(pro => pro.ProductId == orderDetail.ProductId).ToArray()[0],
                    customers.Where(cus => cus.CustomerId == order.CustomerID).ToArray()[0]));
            }

            //foreach(IconButton iconButton in panel_allFatherWaitingOrders.Controls.Find("iconButton_customerDetail", true))
            //{
            //    IconButton_customerDetail_Click(iconButton, null);
            //}
        }
        private GroupBox GenerateWaitingOrder(OrderDetail orderDetail,Product product, Customer customer)
        {
            GroupBox groupBox_waitingOrder = new GroupBox();
            Panel panel_productInfor = new Panel();
            PictureBox pictureBox_productImage = new PictureBox();
            Label label_productName = new Label();
            Label label_productQuantity = new Label();
            Label label_originalPrice = new Label();
            Label label_finalPrice = new Label();
            RJButton rjButton_refer = new RJButton();
            RJButton rjButton_confirm = new RJButton();
            Label label_productLeft = new Label();
            IconButton iconButton_customerDetail = new IconButton();
            Panel panel_customerInfor = new Panel();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            Label label_customerName = new Label();
            Label label_date = new Label();
            Panel panel1 = new Panel();
            Label label_totalAmount = new Label();

            label_finalPrice.AutoSize = true;
            label_finalPrice.Location = new System.Drawing.Point(276, 41);
            label_finalPrice.Name = "label_finalPrice";
            label_finalPrice.Size = new System.Drawing.Size(70, 21);
            label_finalPrice.TabIndex = 11;
            label_finalPrice.Text = "đ " + (orderDetail.UnitPrice.ToInt() - orderDetail.Discount.ToInt()).ToString();

            label_totalAmount.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_totalAmount.ForeColor = System.Drawing.Color.LightCoral;
            label_totalAmount.Location = new System.Drawing.Point(3, 25);
            label_totalAmount.Name = "label_totalAmount";
            label_totalAmount.Size = new System.Drawing.Size(321, 50);
            label_totalAmount.TabIndex = 1;
            label_totalAmount.Text = (orderDetail.Quantity.ToInt() * label_finalPrice.Text.Split(' ').Last().ToInt()).ToString();
            label_totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            panel1.Controls.Add(label_totalAmount);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(584, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(338, 100);
            panel1.TabIndex = 12;

            label_date.AutoSize = true;
            label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_date.Location = new System.Drawing.Point(102, 51);
            label_date.Name = "label_date";
            label_date.Size = new System.Drawing.Size(96, 21);
            label_date.TabIndex = 4;
            //label_date.Text = ;

            label_customerName.AutoSize = true;
            label_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_customerName.Location = new System.Drawing.Point(102, 24);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(129, 21);
            label_customerName.TabIndex = 3;
            label_customerName.Text = customer.CustomerName;

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(19, 24);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(50, 50);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 2;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjCircularPictureBox_customerImage.TabStop = false;

            panel_customerInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_customerInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_customerInfor.Location = new System.Drawing.Point(15, 159);
            panel_customerInfor.MaximumSize = new System.Drawing.Size(0, 100);
            panel_customerInfor.Name = "panel_customerInfor";
            panel_customerInfor.Size = new System.Drawing.Size(922, 0);
            panel_customerInfor.TabIndex = 15;

            iconButton_customerDetail.BackColor = System.Drawing.SystemColors.Control;
            iconButton_customerDetail.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_customerDetail.FlatAppearance.BorderSize = 0;
            iconButton_customerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_customerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_customerDetail.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            iconButton_customerDetail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_customerDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_customerDetail.IconSize = 30;
            iconButton_customerDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_customerDetail.Location = new System.Drawing.Point(15, 114);
            iconButton_customerDetail.Name = "iconButton_customerDetail";
            iconButton_customerDetail.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            iconButton_customerDetail.Size = new System.Drawing.Size(922, 45);
            iconButton_customerDetail.TabIndex = 13;
            iconButton_customerDetail.Text = "Customer detail";
            iconButton_customerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_customerDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_customerDetail.UseVisualStyleBackColor = false;
            iconButton_customerDetail.Click += IconButton_customerDetail_Click;

            label_productLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_productLeft.AutoSize = true;
            label_productLeft.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_productLeft.Location = new System.Drawing.Point(813, 55);
            label_productLeft.Name = "label_productLeft";
            label_productLeft.Size = new System.Drawing.Size(66, 21);
            label_productLeft.TabIndex = 11;
            label_productLeft.Text = $"{product.Quantity} left";

            rjButton_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_confirm.BackColor = System.Drawing.Color.LightSkyBlue;
            rjButton_confirm.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            rjButton_confirm.BorderColor = System.Drawing.Color.LightCoral;
            rjButton_confirm.BorderRadius = 15;
            rjButton_confirm.BorderSize = 0;
            rjButton_confirm.FlatAppearance.BorderSize = 0;
            rjButton_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_confirm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_confirm.ForeColor = System.Drawing.Color.DodgerBlue;
            rjButton_confirm.Location = new System.Drawing.Point(774, 17);
            rjButton_confirm.Name = "rjButton_confirm";
            rjButton_confirm.Size = new System.Drawing.Size(134, 35);
            rjButton_confirm.TabIndex = 9;
            rjButton_confirm.Text = "Confirm";
            rjButton_confirm.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_confirm.UseVisualStyleBackColor = false;
            rjButton_confirm.Click += RjButton_confirm_Click;
            rjButton_confirm.Tag = orderDetail;

            rjButton_refer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           rjButton_refer.BackColor = System.Drawing.Color.Gainsboro;
           rjButton_refer.BackgroundColor = System.Drawing.Color.Gainsboro;
           rjButton_refer.BorderColor = System.Drawing.Color.LightCoral;
           rjButton_refer.BorderRadius = 15;
           rjButton_refer.BorderSize = 0;
           rjButton_refer.FlatAppearance.BorderSize = 0;
           rjButton_refer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           rjButton_refer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           rjButton_refer.ForeColor = System.Drawing.Color.LightCoral;
           rjButton_refer.Location = new System.Drawing.Point(634, 17);
           rjButton_refer.Name = "rjButton_refer";
           rjButton_refer.Size = new System.Drawing.Size(134, 35);
           rjButton_refer.TabIndex = 9;
           rjButton_refer.Text = "Refer";
           rjButton_refer.TextColor = System.Drawing.Color.LightCoral;
           rjButton_refer.UseVisualStyleBackColor = false;
            rjButton_refer.Enabled = false;
            rjButton_refer.Click += RjButton_refer_Click;


            label_originalPrice.AutoSize = true;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_originalPrice.ForeColor = System.Drawing.Color.Gray;
            label_originalPrice.Location = new System.Drawing.Point(180, 41);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(70, 21);
            label_originalPrice.TabIndex = 11;
            label_originalPrice.Text = "đ" +orderDetail.UnitPrice;


            label_productQuantity.AutoSize = true;
            label_productQuantity.ForeColor = System.Drawing.Color.LightCoral;
            label_productQuantity.Location = new System.Drawing.Point(102, 41);
            label_productQuantity.Name = "label_productQuantity";
            label_productQuantity.Size = new System.Drawing.Size(41, 21);
            label_productQuantity.TabIndex = 11;
            label_productQuantity.Text = orderDetail.Quantity;

            label_productName.AutoSize = true;
            label_productName.Location = new System.Drawing.Point(102, 17);
            label_productName.Name = "label_productName";
            label_productName.Size = new System.Drawing.Size(263, 21);
            label_productName.TabIndex = 11;
            label_productName.Text = product.ProductName;

            pictureBox_productImage.Location = new System.Drawing.Point(7, 6);
            pictureBox_productImage.Margin = new System.Windows.Forms.Padding(0);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_productImage.TabIndex = 10;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.SizeMode = PictureBoxSizeMode.Zoom;

            panel_productInfor.Dock = System.Windows.Forms.DockStyle.Top;
            panel_productInfor.Location = new System.Drawing.Point(15, 31);
            panel_productInfor.Name = "panel_productInfor";
            panel_productInfor.Size = new System.Drawing.Size(922, 83);
            panel_productInfor.TabIndex = 14;


            panel_customerInfor.Controls.Add(panel1);
            panel_customerInfor.Controls.Add(label_date);
            //panel_customerInfor.Controls.Add(label1_totalAmount);
            panel_customerInfor.Controls.Add(label_customerName);
            panel_customerInfor.Controls.Add(rjCircularPictureBox_customerImage);
            groupBox_waitingOrder.Controls.Add(panel_customerInfor);

            panel_productInfor.Controls.Add(pictureBox_productImage);
            panel_productInfor.Controls.Add(label_productLeft);
            panel_productInfor.Controls.Add(label_finalPrice);
            panel_productInfor.Controls.Add(rjButton_confirm);
            panel_productInfor.Controls.Add(label_originalPrice);
            panel_productInfor.Controls.Add(rjButton_refer);
            panel_productInfor.Controls.Add(label_productQuantity);
            panel_productInfor.Controls.Add(label_productName);

            groupBox_waitingOrder.Controls.Add(iconButton_customerDetail);
            groupBox_waitingOrder.Controls.Add(panel_productInfor);

            //IconButton_customerDetail_Click(iconButton_customerDetail, n)

            groupBox_waitingOrder.AutoSize = true;

            groupBox_waitingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_waitingOrder.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox_waitingOrder.Location = new System.Drawing.Point(0, 0);
            groupBox_waitingOrder.Name = "groupBox_waitingOrder";
            groupBox_waitingOrder.Padding = new System.Windows.Forms.Padding(15, 10, 30, 15);
            groupBox_waitingOrder.Size = new System.Drawing.Size(967, 274);
            groupBox_waitingOrder.TabIndex = 0;
            groupBox_waitingOrder.TabStop = false;

            return groupBox_waitingOrder;

        }

        private void RjButton_confirm_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = (sender as RJButton).Tag as OrderDetail;
            orderDetail.SetConfirmStateOn().Update();
            MessageBox.Show("Product've been updated!");
            products.Single(pro => pro.ProductId == orderDetail.ProductId).Purchase(orderDetail.Quantity.ToInt()).Update();
            FillEverything();
            
        }
        private void RjButton_refer_Click(object sender, EventArgs e)
        {

        }

















        private Panel GenerateCustomerWaitingOrderInfor(Order order, Customer customer)
        {
            Panel panel = new Panel();


            return panel;
        }












        private void FillAllConfirmedOrder(OrderDetail[] orderDetails)
        {
            panel_allFatherConfirmedOrders.Controls.Clear();
            foreach (OrderDetail orderDetail in orderDetails)
            {
                Order order = orders.Single(ord => ord.OrderId == orderDetail.OrderId);
                panel_allFatherConfirmedOrders.Controls.Add(GenerateConfirmedOrder(orderDetail,
                                    products.Where(pro => pro.ProductId == orderDetail.ProductId).ToArray()[0],
                                    customers.Where(cus => cus.CustomerId == order.CustomerID).ToArray()[0]));
            }
        }
        private GroupBox GenerateConfirmedOrder(OrderDetail orderDetail, Product product, Customer customer)
        {
            GroupBox groupBox_waitingOrder = new GroupBox();
            Panel panel_productInfor = new Panel();
            PictureBox pictureBox_productImage = new PictureBox();
            Label label_productName = new Label();
            Label label_originalPrice = new Label();
            Label label_productQuantity = new Label();
            Label label_finalPrice = new Label();
            Label label_confirmed = new Label();
            Label label_recieved = new Label();
            Label label_customerName = new Label();
            Panel panel1 = new Panel();
            Panel panel_customerInfor = new Panel();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            IconButton iconButton_customerDetail = new IconButton();

            panel_customerInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_customerInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_customerInfor.Location = new System.Drawing.Point(15, 159);
            panel_customerInfor.MaximumSize = new System.Drawing.Size(0, 100);
            panel_customerInfor.Name = "panel_customerInfor";
            panel_customerInfor.Size = new System.Drawing.Size(922, 0);
            panel_customerInfor.TabIndex = 15;

            label_recieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_recieved.AutoSize = true;
            label_recieved.ForeColor = System.Drawing.Color.DodgerBlue;
            label_recieved.Location = new System.Drawing.Point(210, 24);
            label_recieved.Name = "label_recieved";
            label_recieved.Size = new System.Drawing.Size(100, 21);
            label_recieved.TabIndex = 11;
            label_recieved.Text = "Received";

            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(584, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(338, 100);
            panel1.TabIndex = 12;

            label_customerName.AutoSize = true;
            label_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_customerName.Location = new System.Drawing.Point(102, 24);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(129, 21);
            label_customerName.TabIndex = 3;
            label_customerName.Text = customer.CustomerName;

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(19, 24);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(50, 50);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 2;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjCircularPictureBox_customerImage.TabStop = false;

        

            iconButton_customerDetail.BackColor = System.Drawing.SystemColors.Control;
            iconButton_customerDetail.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_customerDetail.FlatAppearance.BorderSize = 0;
            iconButton_customerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_customerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_customerDetail.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            iconButton_customerDetail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_customerDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_customerDetail.IconSize = 30;
            iconButton_customerDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_customerDetail.Location = new System.Drawing.Point(15, 114);
            iconButton_customerDetail.Name = "iconButton_customerDetail";
            iconButton_customerDetail.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            iconButton_customerDetail.Size = new System.Drawing.Size(922, 45);
            iconButton_customerDetail.TabIndex = 13;
            iconButton_customerDetail.Text = "Customer detail";
            iconButton_customerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_customerDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_customerDetail.UseVisualStyleBackColor = false;
            iconButton_customerDetail.Click += IconButton_customerDetail_Click;

            label_confirmed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_confirmed.AutoSize = true;
            label_confirmed.Location = new System.Drawing.Point(793, 30);
            label_confirmed.Name = "label_confirmed";
            label_confirmed.Size = new System.Drawing.Size(85, 21);
            label_confirmed.TabIndex = 11;
            label_confirmed.Text = "Confirmed";

            label_productQuantity.AutoSize = true;
            label_productQuantity.ForeColor = System.Drawing.Color.LightCoral;
            label_productQuantity.Location = new System.Drawing.Point(102, 41);
            label_productQuantity.Name = "label_productQuantity";
            label_productQuantity.Size = new System.Drawing.Size(41, 21);
            label_productQuantity.TabIndex = 11;
            label_productQuantity.Text = orderDetail.Quantity;

            label_originalPrice.AutoSize = true;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_originalPrice.ForeColor = System.Drawing.Color.Gray;
            label_originalPrice.Location = new System.Drawing.Point(180, 41);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(70, 21);
            label_originalPrice.TabIndex = 11;
            label_originalPrice.Text = "đ" + orderDetail.UnitPrice;

            label_finalPrice.AutoSize = true;
            label_finalPrice.Location = new System.Drawing.Point(276, 41);
            label_finalPrice.Name = "label_finalPrice";
            label_finalPrice.Size = new System.Drawing.Size(70, 21);
            label_finalPrice.TabIndex = 11;
            label_finalPrice.Text = "đ " + (orderDetail.UnitPrice.ToInt() - orderDetail.Discount.ToInt()).ToString();

            label_productName.AutoSize = true;
            label_productName.Location = new System.Drawing.Point(102, 17);
            label_productName.Name = "label_productName";
            label_productName.Size = new System.Drawing.Size(263, 21);
            label_productName.TabIndex = 11;
            label_productName.Text = "The Picture of Dorian Gray Level 4";

            pictureBox_productImage.Location = new System.Drawing.Point(7, 6);
            pictureBox_productImage.Margin = new System.Windows.Forms.Padding(0);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_productImage.TabIndex = 10;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.SizeMode = PictureBoxSizeMode.Zoom;

            panel_productInfor.Dock = System.Windows.Forms.DockStyle.Top;
            panel_productInfor.Location = new System.Drawing.Point(15, 31);
            panel_productInfor.Name = "panel_productInfor";
            panel_productInfor.Size = new System.Drawing.Size(922, 83);
            panel_productInfor.TabIndex = 14;
           
            panel1.Controls.Add(label_recieved);
            panel_productInfor.Controls.Add(pictureBox_productImage);
            panel_productInfor.Controls.Add(label_finalPrice);
            panel_productInfor.Controls.Add(label_originalPrice);
            panel_productInfor.Controls.Add(label_productQuantity);
            panel_productInfor.Controls.Add(label_confirmed);
            panel_productInfor.Controls.Add(label_productName);

            panel_customerInfor.Controls.Add(rjCircularPictureBox_customerImage);
            panel_customerInfor.Controls.Add(panel1);
            panel_customerInfor.Controls.Add(label_customerName);

            groupBox_waitingOrder.Controls.Add(iconButton_customerDetail);
            groupBox_waitingOrder.Controls.Add(panel_productInfor);
            groupBox_waitingOrder.Controls.Add(panel_customerInfor);


            groupBox_waitingOrder.AutoSize = true;
            groupBox_waitingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_waitingOrder.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox_waitingOrder.Location = new System.Drawing.Point(0, 0);
            groupBox_waitingOrder.Name = "groupBox_waitingOrder";
            groupBox_waitingOrder.Padding = new System.Windows.Forms.Padding(15, 10, 30, 15);
            groupBox_waitingOrder.Size = new System.Drawing.Size(967, 274);
            groupBox_waitingOrder.TabIndex = 0;
            groupBox_waitingOrder.TabStop = false;

            return groupBox_waitingOrder;


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

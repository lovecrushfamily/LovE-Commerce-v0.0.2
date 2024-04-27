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
using System.Threading;
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
        Comment[] comments;
        Shop[] shops;

        #region Delegate
        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void ObjectExternalLink(Entity entity);
        // Declare a new instance of the delegate (null)
        public ObjectExternalLink objectExternalLink;
        #endregion


        public SubViewCustormerOrders()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            ////customer = customerpara;

            //InitializeDatasets();
            //ActivateWaitingOrder();
            //FillAllWaitingOrdersAndConfirmOrder();
            currentButton = iconButton_waitingOrders;

        }
        public void SetCustomer(Customer customerpara)
        {
            customer = customerpara;
            InitializeDatasets();
            ActivateWaitingOrder();
            FillAllWaitingOrdersAndConfirmOrder();
            currentButton = iconButton_waitingOrders;



        }
        private void InitializeDatasets()
        {
            //get all orders belong to customer,
            orders = Order.GetOrders().Where(ord => ord.CustomerID == customer.CustomerId).ToArray();

            //get all orderdetail belong to these orders
            orderDetails = OrderDetail.GetOrderDetails().Where(orderDetails => orders.Any(order => order.OrderId == orderDetails.OrderId)).ToArray();

            comments = Comment.GetComments().Join(orderDetails, comment => comment.OrderDetailID, orderdetail => orderdetail.OrderDetailId, (comment, orderdetail) => comment).ToArray();

            //get all product belongs these order detail
            products = Product.GetProducts().Where(pro => orderDetails.Any(orderdetail => orderdetail.ProductId == pro.ProductId)).ToArray();
                                          
            //get all shop belongs to these product
            shops = Shop.GetShops().Where(shop => products.Any(pro => pro.ShopID == shop.ShopId)).ToArray();
        }


        //change tab effect
        IconButton currentButton ;
        //dropdown effect
        IconButton currentActivatedButton;
        GroupBox currentGroupbox;
        private void IconButton_expandProductDetail_Click(object sender, EventArgs e)
        {
            currentActivatedButton = (IconButton)sender;
            currentGroupbox = currentActivatedButton.Parent as GroupBox;
            timer1.Start();
        }

      
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (currentActivatedButton.IconChar == IconChar.AngleUp)
            {
                currentGroupbox.Height += 10;
                //currentGroupbox.AutoSize = false;
                if (currentGroupbox.Size.Height >= currentGroupbox.MaximumSize.Height)
                {
                    timer1.Stop();
                    currentActivatedButton.IconChar = IconChar.AngleDown;
                }
            }
            else
            {
                currentGroupbox.Height -= 10;
                if (currentGroupbox.Size.Height <= (155))
                {
                    currentActivatedButton.IconChar = IconChar.AngleUp;
                    timer1.Stop();
                    //currentGroupbox.AutoSize = true;

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
            currentButton.IconColor = Color.Silver;
            TabControl_Orders.SelectedTab = tabPage_confirmedOrders;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
            
        }
        private void IconButton_recievedOrder_Click(object sender, EventArgs e)
        {

            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
            TabControl_Orders.SelectedTab = tabPage_RecievedOrder;
        }
        private void IconButton_cancelledOrder_Click(object sender, EventArgs e)
        {
            TabControl_Orders.SelectedTab = tabPage_cancelledOrder;
            currentButton.IconColor = Color.Silver;
            currentButton = sender as IconButton;
            currentButton.IconColor = Color.DodgerBlue;
        }













        private void FillAllWaitingOrdersAndConfirmOrder()
        {
            panel_allFatherComfirmOrder.Controls.Clear();
            panel_allfatherWaitingOrders.Controls.Clear();
            panel_allFatherReceivedOrder.Controls.Clear();

            foreach (Order order in orders)
            {
                OrderDetail[] orderDetailsTemp = orderDetails.Where(orderdetail => orderdetail.OrderId == order.OrderId).ToArray();
                if (order.ReceivedState)
                {
                    panel_allFatherReceivedOrder.Controls.Add(GenerateReceivedOrder(order, orderDetailsTemp, orderDetailsTemp.Join(products, orderdetail => orderdetail.ProductId, pro => pro.ProductId, (orderdetail, pro) => pro)));
                }
                else if (order.OrderConfirmState)
                {
                    panel_allFatherComfirmOrder.Controls.Add(GenerateConfirmedOrder( order, orderDetailsTemp, orderDetailsTemp.Join(products, orderdetail => orderdetail.ProductId, pro => pro.ProductId, (orderdetail, pro) => pro)));
                }
                else
                {
                    panel_allfatherWaitingOrders.Controls.Add(GenerateWaitingOrders( order, orderDetailsTemp, orderDetailsTemp.Join(products, orderdetail => orderdetail.ProductId, pro => pro.ProductId, (orderdetail, pro) => pro).ToArray()));
                }
            }
        }
        
        private GroupBox GenerateWaitingOrders(Order order, OrderDetail[] orderDetails, Product[] products)
        {
            //fill order
            GroupBox groupBox_waitingOrder = new GroupBox();
            Panel panel_orderInfo = new Panel();
            IconButton iconButton_expandProductDetail = new IconButton();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            Label label13 = new Label();
            Label label33 = new Label();
            Label label34 = new Label();
            Label label_customerName = new Label();
            Label label_totalCost = new Label();
            Label label_orderDate = new Label();

            //fill order detail, product and shop.
            foreach (var tuple in products.Zip(orderDetails, Tuple.Create))
            {
                groupBox_waitingOrder.Controls.Add(GenerateWaitingOrderDetail(tuple.Item2, tuple.Item1, shops.Single(shop => shop.ShopId == tuple.Item1.ShopID)));
            }

            //
            RJButton rjButton_cancelWaitingOrder = new RJButton();
            Label label1 = new Label();

            rjButton_cancelWaitingOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_cancelWaitingOrder.BackColor = System.Drawing.Color.LightCoral;
            rjButton_cancelWaitingOrder.BackgroundColor = System.Drawing.Color.LightCoral;
            rjButton_cancelWaitingOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_cancelWaitingOrder.BorderRadius = 15;
            rjButton_cancelWaitingOrder.BorderSize = 0;
            rjButton_cancelWaitingOrder.FlatAppearance.BorderSize = 0;
            rjButton_cancelWaitingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_cancelWaitingOrder.ForeColor = System.Drawing.Color.White;
            rjButton_cancelWaitingOrder.Location = new System.Drawing.Point(766, 40);
            rjButton_cancelWaitingOrder.Name = "rjButton_cancelWaitingOrder";
            rjButton_cancelWaitingOrder.Size = new System.Drawing.Size(134, 35);
            rjButton_cancelWaitingOrder.TabIndex = 7;
            rjButton_cancelWaitingOrder.Text = "Cancel";
            rjButton_cancelWaitingOrder.TextColor = System.Drawing.Color.White;
            rjButton_cancelWaitingOrder.UseVisualStyleBackColor = false;
            rjButton_cancelWaitingOrder.Click += RjButton_cancelWaitingOrder_Click;
            rjButton_cancelWaitingOrder.Tag = order;


            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(793, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Waiting...";
            //

            label_orderDate.AutoSize = true;
            label_orderDate.Location = new System.Drawing.Point(228, 60);
            label_orderDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_orderDate.Name = "label_orderDate";
            label_orderDate.Size = new System.Drawing.Size(107, 21);
            label_orderDate.TabIndex = 0;
            label_orderDate.Text = $": {order.Date}";

            label_totalCost.AutoSize = true;
            label_totalCost.Location = new System.Drawing.Point(228, 34);
            label_totalCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_totalCost.Name = "label_totalCost";
            label_totalCost.Size = new System.Drawing.Size(102, 21);
            label_totalCost.TabIndex = 0;
            label_totalCost.Text = $": {order.TotalAmount}";

            label_customerName.AutoSize = true;
            label_customerName.Location = new System.Drawing.Point(228, 8);
            label_customerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(97, 21);
            label_customerName.TabIndex = 0;
            label_customerName.Text = $": {customer.CustomerName}";

            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(101, 60);
            label34.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(46, 21);
            label34.TabIndex = 0;
            label34.Text = "Date";

            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(101, 34);
            label33.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(84, 21);
            label33.TabIndex = 0;
            label33.Text = "Total cost";

            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(101, 8);
            label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(81, 21);
            label13.TabIndex = 0;
            label13.Text = "Customer";

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(15, 15);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(60, 60);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 1;
            rjCircularPictureBox_customerImage.TabStop = false;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjCircularPictureBox_customerImage.SizeMode = PictureBoxSizeMode.Zoom;


            iconButton_expandProductDetail.BackColor = System.Drawing.SystemColors.Control;
            iconButton_expandProductDetail.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_expandProductDetail.FlatAppearance.BorderSize = 0;
            iconButton_expandProductDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_expandProductDetail.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton_expandProductDetail.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            iconButton_expandProductDetail.IconColor = System.Drawing.Color.LightBlue;
            iconButton_expandProductDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_expandProductDetail.IconSize = 30;
            iconButton_expandProductDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.Location = new System.Drawing.Point(20, 111);
            iconButton_expandProductDetail.Name = "iconButton_expandProductDetail";
            iconButton_expandProductDetail.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            iconButton_expandProductDetail.Size = new System.Drawing.Size(925, 40);
            iconButton_expandProductDetail.TabIndex = 13;
            iconButton_expandProductDetail.Text = "Product Detail";
            iconButton_expandProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_expandProductDetail.UseVisualStyleBackColor = false;
            iconButton_expandProductDetail.Click += new System.EventHandler(IconButton_expandProductDetail_Click);
            //iconButton_expandProductDetail.Margin = new 



            panel_orderInfo.Controls.Add(rjCircularPictureBox_customerImage);
            panel_orderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            panel_orderInfo.Location = new System.Drawing.Point(20, 24);
            panel_orderInfo.Name = "panel_orderInfo";
            panel_orderInfo.Size = new System.Drawing.Size(925, 87);
            panel_orderInfo.TabIndex = 12;

            panel_orderInfo.Controls.Add(label_totalCost);
            panel_orderInfo.Controls.Add(label_customerName);
            panel_orderInfo.Controls.Add(rjButton_cancelWaitingOrder);
            panel_orderInfo.Controls.Add(label_orderDate);
            panel_orderInfo.Controls.Add(label1);
            panel_orderInfo.Controls.Add(label13);
            panel_orderInfo.Controls.Add(label33);
            panel_orderInfo.Controls.Add(label34);

            //groupBox_waitingOrder.Controls.Add(panel_OrderDetail);
            groupBox_waitingOrder.Controls.Add(iconButton_expandProductDetail);
            groupBox_waitingOrder.Controls.Add(panel_orderInfo);

            groupBox_waitingOrder.MaximumSize = new Size(965, 87 + 40 + (130 * orderDetails.Count()) + 40);
            groupBox_waitingOrder.Size = groupBox_waitingOrder.MaximumSize;
            //groupBox_waitingOrder.AutoSize = true;
            groupBox_waitingOrder.BackColor = System.Drawing.SystemColors.Control;
            groupBox_waitingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_waitingOrder.Font = new System.Drawing.Font("Tahoma", 10F);
            groupBox_waitingOrder.Location = new System.Drawing.Point(10, 0);
            groupBox_waitingOrder.Name = "groupBox_waitingOrder";
            groupBox_waitingOrder.Padding = new System.Windows.Forms.Padding(20, 3, 20, 10);
            groupBox_waitingOrder.TabIndex = 1;
            groupBox_waitingOrder.TabStop = false;

            
            return groupBox_waitingOrder;

        }

        private void RjButton_cancelWaitingOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, this action'll delete all these order below?","Warning",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            InitializeDatasets();
            IEnumerable<OrderDetail> orderDetailsTemp = orderDetails.Where(orderdetail => orderdetail.OrderId == ((sender as RJButton).Tag as Order).OrderId);
            if (orderDetailsTemp.Any(orderDetails => orderDetails.OrderDetailConfirmState))
            {
                MessageBox.Show("This order cannot be deleted because it has a confirmed order,\n if you want to delete any order, make sure that all the order inside it wasn't confirmed first", "nvalid action");
                FillAllWaitingOrdersAndConfirmOrder();
            }
            else
            {
                ((sender as RJButton).Parent.Parent as GroupBox).BringToFront();
                ((sender as RJButton).Parent.Parent as GroupBox).RecursivelyDispose();
                ((sender as RJButton).Tag as Order).Delete();
                MessageBox.Show("Your Order has been deleted, !");
            }



        }
        private Panel GenerateWaitingOrderDetail(OrderDetail orderDetail, Product product, Shop shop)
        {
            Panel panel_OrderDetail = new Panel();
            IconButton iconButton_shop = new IconButton();
            Button button_shopName = new Button();
            PictureBox pictureBox_orderDetailImage = new PictureBox();
            Label label_orderDetailProductname = new Label();
            Label label_orderDetailQuantity =  new Label();
            Label label_originalPrice = new Label();
            Label label_finalPrice = new Label();



            //
            Label label_statusWaiting = new Label();
            RJButton rjButton_cancelOrderDetailOne = new RJButton();
            Panel panel3 = new Panel();

            panel3.Controls.Add(rjButton_cancelOrderDetailOne);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(739, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(181, 130);
            panel3.TabIndex = 10;

            rjButton_cancelOrderDetailOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_cancelOrderDetailOne.BackColor = System.Drawing.SystemColors.Control;
            rjButton_cancelOrderDetailOne.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_cancelOrderDetailOne.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_cancelOrderDetailOne.BorderRadius = 15;
            rjButton_cancelOrderDetailOne.BorderSize = 0;
            rjButton_cancelOrderDetailOne.FlatAppearance.BorderSize = 0;
            rjButton_cancelOrderDetailOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_cancelOrderDetailOne.ForeColor = System.Drawing.Color.LightCoral;
            rjButton_cancelOrderDetailOne.Location = new System.Drawing.Point(22, 46);
            rjButton_cancelOrderDetailOne.Name = "rjButton_cancelOrderDetailOne";
            rjButton_cancelOrderDetailOne.Size = new System.Drawing.Size(134, 35);
            rjButton_cancelOrderDetailOne.TabIndex = 8;
            rjButton_cancelOrderDetailOne.Text = "Cancel";
            rjButton_cancelOrderDetailOne.TextColor = System.Drawing.Color.LightCoral;
            rjButton_cancelOrderDetailOne.UseVisualStyleBackColor = false;
            rjButton_cancelOrderDetailOne.Click += RjButton_cancelOrderDetailOne_Click;
            rjButton_cancelOrderDetailOne.Tag = orderDetail;

            if (orderDetail.OrderDetailConfirmState)
            {
                label_statusWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                label_statusWaiting.AutoSize = true;
                label_statusWaiting.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_statusWaiting.ForeColor = System.Drawing.Color.DodgerBlue;
                label_statusWaiting.Location = new System.Drawing.Point(793, 40);
                label_statusWaiting.Name = "label_statusWaiting";
                label_statusWaiting.Size = new System.Drawing.Size(85, 21);
                label_statusWaiting.TabIndex = 0;
                label_statusWaiting.Text = "Confirmed";
                rjButton_cancelOrderDetailOne.Enabled = false;
            }
            else
            {
                label_statusWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                label_statusWaiting.AutoSize = true;
                label_statusWaiting.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_statusWaiting.Location = new System.Drawing.Point(793, 31);
                label_statusWaiting.Name = "label_statusWaiting";
                label_statusWaiting.Size = new System.Drawing.Size(81, 21);
                label_statusWaiting.TabIndex = 0;
                label_statusWaiting.Text = "Waiting...";
            }

            //

            label_orderDetailQuantity.AutoSize = true;
            label_orderDetailQuantity.Location = new System.Drawing.Point(140, 82);
            label_orderDetailQuantity.Name = "label_orderDetailQuantity";
            label_orderDetailQuantity.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            label_orderDetailQuantity.Size = new System.Drawing.Size(41, 21);
            label_orderDetailQuantity.TabIndex = 0;
            label_orderDetailQuantity.Text = $"x{orderDetail.Quantity}";

            label_originalPrice.AutoSize = true;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Strikeout);
            label_originalPrice.ForeColor = System.Drawing.Color.Silver;
            label_originalPrice.Location = new System.Drawing.Point(244, 82);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(70, 21);
            label_originalPrice.TabIndex = 0;
            label_originalPrice.Text = $"đ{orderDetail.Quantity.ToInt() * orderDetail.UnitPrice.ToInt()}";

            label_finalPrice.AutoSize = true;
            label_finalPrice.ForeColor = System.Drawing.Color.LightCoral;
            label_finalPrice.Location = new System.Drawing.Point(334, 82);
            label_finalPrice.Name = "label_finalPrice";
            label_finalPrice.Size = new System.Drawing.Size(70, 21);
            label_finalPrice.TabIndex = 0;
            label_finalPrice.Text = $"đ{label_originalPrice.Text.Split('đ').Last().ToInt() - orderDetail.Discount.ToInt()}";



            label_orderDetailProductname.Location = new System.Drawing.Point(135, 46);
            label_orderDetailProductname.Name = "label_orderDetailProductname";
            label_orderDetailProductname.Size = new System.Drawing.Size(371, 21);
            label_orderDetailProductname.TabIndex = 0;
            label_orderDetailProductname.Text = product.ProductName;

            pictureBox_orderDetailImage.Location = new System.Drawing.Point(45, 46);
            pictureBox_orderDetailImage.Name = "pictureBox_orderDetailImage";
            pictureBox_orderDetailImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_orderDetailImage.TabIndex = 0;
            pictureBox_orderDetailImage.TabStop = false;
            pictureBox_orderDetailImage.Tag = product;
            pictureBox_orderDetailImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_orderDetailImage.Click += PictureBox_orderDetailImage_Click;
            pictureBox_orderDetailImage.SizeMode = PictureBoxSizeMode.Zoom;

            button_shopName.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.BorderSize = 0;
            button_shopName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            button_shopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_shopName.Location = new System.Drawing.Point(81, 7);
            button_shopName.Name = "button_shopName";
            button_shopName.Size = new System.Drawing.Size(138, 35);
            button_shopName.TabIndex = 6;
            button_shopName.Text = shop.ShopName;
            button_shopName.UseVisualStyleBackColor = true;
            button_shopName.Tag = shop;
            button_shopName.Click += Button_shopName_Click1;

            iconButton_shop.Enabled = false;
            iconButton_shop.FlatAppearance.BorderSize = 0;
            iconButton_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_shop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconButton_shop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_shop.IconSize = 35;
            iconButton_shop.Location = new System.Drawing.Point(45, 7);
            iconButton_shop.Name = "iconButton_shop";
            iconButton_shop.Size = new System.Drawing.Size(30, 37);
            iconButton_shop.TabIndex = 5;
            iconButton_shop.UseVisualStyleBackColor = true;


            panel3.Controls.Add(rjButton_cancelOrderDetailOne);
            panel_OrderDetail.Controls.Add(panel3);

            panel_OrderDetail.Controls.Add(pictureBox_orderDetailImage);
            panel_OrderDetail.Controls.Add(label_orderDetailQuantity);
            panel_OrderDetail.Controls.Add(label_finalPrice);
            panel_OrderDetail.Controls.Add(label_originalPrice);
            panel_OrderDetail.Controls.Add(label_orderDetailProductname);
            panel_OrderDetail.Controls.Add(button_shopName);
            panel_OrderDetail.Controls.Add(iconButton_shop);

            panel_OrderDetail.Controls.Add(label_statusWaiting);
            panel_OrderDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_OrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            panel_OrderDetail.Location = new System.Drawing.Point(20, 151);
            panel_OrderDetail.MaximumSize = new System.Drawing.Size(0, 130);
            panel_OrderDetail.Name = "panel_OrderDetail";
            panel_OrderDetail.Size = new System.Drawing.Size(925, 130);
            panel_OrderDetail.TabIndex = 14;

            return panel_OrderDetail;
        }

        private void Button_shopName_Click1(object sender, EventArgs e)
        {
            //using this event too
            //objectExternalLink((Shop)(sender as Button).Tag);
            MessageBox.Show("Click on the product page to get more information about  this shop!");
        }

        private void PictureBox_orderDetailImage_Click(object sender, EventArgs e)
        {
            // just  only this page, using double object external link
            objectExternalLink((Product)(sender as PictureBox).Tag);
        }

        private void RjButton_cancelOrderDetailOne_Click(object sender, EventArgs e)
        {
        //ding somw thing when click on this button
        if(MessageBox.Show("Are you sure, this action will delete your order of this product imediately?", "Caution", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        {
            return;
        }
        InitializeDatasets();
        OrderDetail orderDetailtemp = ((sender as RJButton).Tag as OrderDetail);
        if (!orderDetails.Single(orderdetail => orderdetail.OrderDetailId == orderDetailtemp.OrderDetailId).OrderDetailConfirmState)
        {
            orderDetailtemp.Delete();
            Panel parent = ((sender as RJButton).Parent.Parent as Panel);
            parent.BringToFront();
            parent.RecursivelyDispose();
            parent.Parent.Size = new Size(parent.Parent.Size.Width, parent.Parent.Size.Height - 130);

            //check if order has one or more order detail left
            ///when the order detail was deleted, the groupbax lost like 130 of height and if it under 170 that's mean the order now has nw more order detail left; => delete order
            if (parent.Parent.Size.Height < 90 + 40 + 40)
            {                  
                    orders.Single(order => order.OrderId == orderDetailtemp.OrderId).Delete();
                    parent.Parent.RecursivelyDispose();
            }
            MessageBox.Show("This order've been deleted !");
        }
        else
        {
            MessageBox.Show("Order has been comfirmed, can not refer!");
        }
            InitializeDatasets();

        FillAllWaitingOrdersAndConfirmOrder();
    }

        private GroupBox GenerateConfirmedOrder(Order order, OrderDetail[] orderDetails, IEnumerable<Product> products)
        {
            //fill order
            GroupBox groupBox_OrderConfirmed = new GroupBox();
            Panel panel_orderInfo = new Panel();
            IconButton iconButton_expandProductDetail = new IconButton();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            Label label13 = new Label();
            Label label33 = new Label();
            Label label34 = new Label();
            Label label_customerName = new Label();
            Label label_totalCost = new Label();
            Label label_orderDate = new Label();

            //fill order detail, product and shop.
            foreach (var tuple in products.Zip(orderDetails, Tuple.Create))
            {
                groupBox_OrderConfirmed.Controls.Add(GenerateConfirmedOrderDetail(tuple.Item2, tuple.Item1, shops.Single(shop => shop.ShopId == tuple.Item1.ShopID)));
            }

            //
            RJButton rjButton_receiveOrder = new RJButton();
            Label label1 = new Label();

            rjButton_receiveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_receiveOrder.BackColor = System.Drawing.Color.DodgerBlue;
            rjButton_receiveOrder.BackgroundColor = System.Drawing.Color.DodgerBlue;
            rjButton_receiveOrder.BorderColor = System.Drawing.Color.GhostWhite;
            rjButton_receiveOrder.BorderRadius = 15;
            rjButton_receiveOrder.BorderSize = 0;
            rjButton_receiveOrder.FlatAppearance.BorderSize = 0;
            rjButton_receiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_receiveOrder.ForeColor = System.Drawing.Color.GhostWhite;
            rjButton_receiveOrder.Location = new System.Drawing.Point(766, 40);
            rjButton_receiveOrder.Name = "rjButton_receiveOrder";
            rjButton_receiveOrder.Size = new System.Drawing.Size(134, 35);
            rjButton_receiveOrder.TabIndex = 8;
            rjButton_receiveOrder.Text = "Recieve";
            rjButton_receiveOrder.TextColor = System.Drawing.Color.GhostWhite;
            rjButton_receiveOrder.UseVisualStyleBackColor = false;
            rjButton_receiveOrder.Tag = order;
            rjButton_receiveOrder.Click += RjButton_receiveOrder_Click;



            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(793, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Confirmed";
            //

            label_orderDate.AutoSize = true;
            label_orderDate.Location = new System.Drawing.Point(228, 60);
            label_orderDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_orderDate.Name = "label_orderDate";
            label_orderDate.Size = new System.Drawing.Size(107, 21);
            label_orderDate.TabIndex = 0;
            label_orderDate.Text = $": {order.Date}";

            label_totalCost.AutoSize = true;
            label_totalCost.Location = new System.Drawing.Point(228, 34);
            label_totalCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_totalCost.Name = "label_totalCost";
            label_totalCost.Size = new System.Drawing.Size(102, 21);
            label_totalCost.TabIndex = 0;
            label_totalCost.Text = $": {order.TotalAmount}";

            label_customerName.AutoSize = true;
            label_customerName.Location = new System.Drawing.Point(228, 8);
            label_customerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(97, 21);
            label_customerName.TabIndex = 0;
            label_customerName.Text = $": {customer.CustomerName}";

            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(101, 60);
            label34.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(46, 21);
            label34.TabIndex = 0;
            label34.Text = "Date";

            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(101, 34);
            label33.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(84, 21);
            label33.TabIndex = 0;
            label33.Text = "Total cost";

            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(101, 8);
            label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(81, 21);
            label13.TabIndex = 0;
            label13.Text = "Customer";

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(15, 15);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(60, 60);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 1;
            rjCircularPictureBox_customerImage.TabStop = false;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjCircularPictureBox_customerImage.SizeMode = PictureBoxSizeMode.Zoom;


            iconButton_expandProductDetail.BackColor = System.Drawing.SystemColors.Control;
            iconButton_expandProductDetail.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_expandProductDetail.FlatAppearance.BorderSize = 0;
            iconButton_expandProductDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_expandProductDetail.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton_expandProductDetail.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            iconButton_expandProductDetail.IconColor = System.Drawing.Color.LightBlue;
            iconButton_expandProductDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_expandProductDetail.IconSize = 30;
            iconButton_expandProductDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.Location = new System.Drawing.Point(20, 111);
            iconButton_expandProductDetail.Name = "iconButton_expandProductDetail";
            iconButton_expandProductDetail.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            iconButton_expandProductDetail.Size = new System.Drawing.Size(925, 40);
            iconButton_expandProductDetail.TabIndex = 13;
            iconButton_expandProductDetail.Text = "Product Detail";
            iconButton_expandProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_expandProductDetail.UseVisualStyleBackColor = false;
            iconButton_expandProductDetail.Click += new System.EventHandler(IconButton_expandProductDetail_Click);
            //iconButton_expandProductDetail.Margin = new 



            panel_orderInfo.Controls.Add(rjCircularPictureBox_customerImage);
            panel_orderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            panel_orderInfo.Location = new System.Drawing.Point(20, 24);
            panel_orderInfo.Name = "panel_orderInfo";
            panel_orderInfo.Size = new System.Drawing.Size(925, 87);
            panel_orderInfo.TabIndex = 12;

            panel_orderInfo.Controls.Add(label_totalCost);
            panel_orderInfo.Controls.Add(label_customerName);
            panel_orderInfo.Controls.Add(rjButton_receiveOrder);
            panel_orderInfo.Controls.Add(label_orderDate);
            panel_orderInfo.Controls.Add(label1);
            panel_orderInfo.Controls.Add(label13);
            panel_orderInfo.Controls.Add(label33);
            panel_orderInfo.Controls.Add(label34);

            //groupBox_OrderConfirmed.Controls.Add(panel_OrderDetail);
            groupBox_OrderConfirmed.Controls.Add(iconButton_expandProductDetail);
            groupBox_OrderConfirmed.Controls.Add(panel_orderInfo);

            groupBox_OrderConfirmed.MaximumSize = new Size(965, 87 + 40 + (130 * orderDetails.Count()) + 40);
            groupBox_OrderConfirmed.Size = groupBox_OrderConfirmed.MaximumSize;
            //groupBox_OrderConfirmed.AutoSize = true;
            groupBox_OrderConfirmed.BackColor = System.Drawing.SystemColors.Control;
            groupBox_OrderConfirmed.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_OrderConfirmed.Font = new System.Drawing.Font("Tahoma", 10F);
            groupBox_OrderConfirmed.Location = new System.Drawing.Point(10, 0);
            groupBox_OrderConfirmed.Name = "groupBox_OrderConfirmed";
            groupBox_OrderConfirmed.Padding = new System.Windows.Forms.Padding(20, 3, 20, 10);
            groupBox_OrderConfirmed.TabIndex = 1;
            groupBox_OrderConfirmed.TabStop = false;


            return groupBox_OrderConfirmed;

        }

        private Panel GenerateConfirmedOrderDetail(OrderDetail orderDetail, Product product, Shop shop)
        {
            Panel panel_OrderConfirms = new Panel();
            IconButton iconButton_shop = new IconButton();
            Button button_shopName = new Button();
            PictureBox pictureBox_orderDetailImage = new PictureBox();
            Label label_orderDetailProductname = new Label();
            Label label_orderDetailQuantity = new Label();
            Label label_originalPrice = new Label();
            Label label_finalPrice = new Label();



            //
            Label label_statusWaiting = new Label();
            Panel panel3 = new Panel();

            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(739, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(181, 130);
            panel3.TabIndex = 10;

            //Nếu nó không hiện lên là chuyển xang cái panel 3 kia 

            label_statusWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label_statusWaiting.AutoSize = true;
            label_statusWaiting.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_statusWaiting.ForeColor = System.Drawing.Color.DodgerBlue;
            label_statusWaiting.Location = new System.Drawing.Point(793, 40);
            label_statusWaiting.Name = "label_statusWaiting";
            label_statusWaiting.Size = new System.Drawing.Size(85, 21);
            label_statusWaiting.TabIndex = 0;
            label_statusWaiting.Text = "Confirmed";
  
            //

            label_orderDetailQuantity.AutoSize = true;
            label_orderDetailQuantity.Location = new System.Drawing.Point(140, 82);
            label_orderDetailQuantity.Name = "label_orderDetailQuantity";
            label_orderDetailQuantity.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            label_orderDetailQuantity.Size = new System.Drawing.Size(41, 21);
            label_orderDetailQuantity.TabIndex = 0;
            label_orderDetailQuantity.Text = $"x{orderDetail.Quantity}";

            label_originalPrice.AutoSize = true;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Strikeout);
            label_originalPrice.ForeColor = System.Drawing.Color.Silver;
            label_originalPrice.Location = new System.Drawing.Point(244, 82);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(70, 21);
            label_originalPrice.TabIndex = 0;
            label_originalPrice.Text = $"đ{orderDetail.Quantity.ToInt() * orderDetail.UnitPrice.ToInt()}";

            label_finalPrice.AutoSize = true;
            label_finalPrice.ForeColor = System.Drawing.Color.LightCoral;
            label_finalPrice.Location = new System.Drawing.Point(334, 82);
            label_finalPrice.Name = "label_finalPrice";
            label_finalPrice.Size = new System.Drawing.Size(70, 21);
            label_finalPrice.TabIndex = 0;
            label_finalPrice.Text = $"đ{label_originalPrice.Text.Split('đ').Last().ToInt() - orderDetail.Discount.ToInt()}";



            label_orderDetailProductname.Location = new System.Drawing.Point(135, 46);
            label_orderDetailProductname.Name = "label_orderDetailProductname";
            label_orderDetailProductname.Size = new System.Drawing.Size(371, 21);
            label_orderDetailProductname.TabIndex = 0;
            label_orderDetailProductname.Text = product.ProductName;

            pictureBox_orderDetailImage.Location = new System.Drawing.Point(45, 46);
            pictureBox_orderDetailImage.Name = "pictureBox_orderDetailImage";
            pictureBox_orderDetailImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_orderDetailImage.TabIndex = 0;
            pictureBox_orderDetailImage.TabStop = false;
            pictureBox_orderDetailImage.Tag = product;
            pictureBox_orderDetailImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_orderDetailImage.Click += PictureBox_orderDetailImage_Click;
            pictureBox_orderDetailImage.SizeMode = PictureBoxSizeMode.Zoom;

            button_shopName.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.BorderSize = 0;
            button_shopName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            button_shopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_shopName.Location = new System.Drawing.Point(81, 7);
            button_shopName.Name = "button_shopName";
            button_shopName.Size = new System.Drawing.Size(138, 35);
            button_shopName.TabIndex = 6;
            button_shopName.Text = shop.ShopName;
            button_shopName.UseVisualStyleBackColor = true;
            button_shopName.Tag = shop;
            button_shopName.Click += Button_shopName_Click1;

            iconButton_shop.Enabled = false;
            iconButton_shop.FlatAppearance.BorderSize = 0;
            iconButton_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_shop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconButton_shop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_shop.IconSize = 35;
            iconButton_shop.Location = new System.Drawing.Point(45, 7);
            iconButton_shop.Name = "iconButton_shop";
            iconButton_shop.Size = new System.Drawing.Size(30, 37);
            iconButton_shop.TabIndex = 5;
            iconButton_shop.UseVisualStyleBackColor = true;


            panel3.Controls.Add(label_statusWaiting);
            panel_OrderConfirms.Controls.Add(panel3);

            panel_OrderConfirms.Controls.Add(pictureBox_orderDetailImage);
            panel_OrderConfirms.Controls.Add(label_orderDetailQuantity);
            panel_OrderConfirms.Controls.Add(label_finalPrice);
            panel_OrderConfirms.Controls.Add(label_originalPrice);
            panel_OrderConfirms.Controls.Add(label_orderDetailProductname);
            panel_OrderConfirms.Controls.Add(button_shopName);
            panel_OrderConfirms.Controls.Add(iconButton_shop);                      

            panel_OrderConfirms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_OrderConfirms.Dock = System.Windows.Forms.DockStyle.Top;
            panel_OrderConfirms.Location = new System.Drawing.Point(20, 151);
            panel_OrderConfirms.MaximumSize = new System.Drawing.Size(0, 130);
            panel_OrderConfirms.Name = "panel_OrderConfirms";
            panel_OrderConfirms.Size = new System.Drawing.Size(925, 130);
            panel_OrderConfirms.TabIndex = 14;

            return panel_OrderConfirms;

        }













        private GroupBox GenerateReceivedOrder(Order order, OrderDetail[] orderDetails, IEnumerable<Product> products)
        {

            //fill order
            GroupBox groupBox_recievedOrder = new GroupBox();
            Panel panel_orderInfo = new Panel();
            IconButton iconButton_expandProductDetail = new IconButton();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            Label label13 = new Label();
            Label label33 = new Label();
            Label label34 = new Label();
            Label label_customerName = new Label();
            Label label_totalCost = new Label();
            Label label_orderDate = new Label();

            //fill order detail, product and shop.
            foreach (var tuple in products.Zip(orderDetails, Tuple.Create))
            {
                groupBox_recievedOrder.Controls.Add(GenerateReceivedOrderDetail(tuple.Item2, tuple.Item1, shops.Single(shop => shop.ShopId == tuple.Item1.ShopID)));
            }

            //
            RJButton rjButton_repurchase = new RJButton();
            Label label1 = new Label();

            rjButton_repurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_repurchase.BackColor = System.Drawing.Color.Snow;
            rjButton_repurchase.BackgroundColor = System.Drawing.Color.Snow;
            rjButton_repurchase.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_repurchase.BorderRadius = 15;
            rjButton_repurchase.BorderSize = 0;
            rjButton_repurchase.FlatAppearance.BorderSize = 0;
            rjButton_repurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_repurchase.ForeColor = System.Drawing.Color.LightCoral;
            rjButton_repurchase.Location = new System.Drawing.Point(766, 40);
            rjButton_repurchase.Name = "rjButton_repurchase";
            rjButton_repurchase.Size = new System.Drawing.Size(134, 35);
            rjButton_repurchase.TabIndex = 7;
            rjButton_repurchase.Text = "Repurchase";
            rjButton_repurchase.UseVisualStyleBackColor = false;
            rjButton_repurchase.Click += RjButton_repurchase_Click; ;
            rjButton_repurchase.Tag = order;


            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = Color.LightSlateGray;
            label1.Location = new System.Drawing.Point(793, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Received";
            //

            label_orderDate.AutoSize = true;
            label_orderDate.Location = new System.Drawing.Point(228, 60);
            label_orderDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_orderDate.Name = "label_orderDate";
            label_orderDate.Size = new System.Drawing.Size(107, 21);
            label_orderDate.TabIndex = 0;
            label_orderDate.Text = $": {order.Date}";

            label_totalCost.AutoSize = true;
            label_totalCost.Location = new System.Drawing.Point(228, 34);
            label_totalCost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_totalCost.Name = "label_totalCost";
            label_totalCost.Size = new System.Drawing.Size(102, 21);
            label_totalCost.TabIndex = 0;
            label_totalCost.Text = $": {order.TotalAmount}";

            label_customerName.AutoSize = true;
            label_customerName.Location = new System.Drawing.Point(228, 8);
            label_customerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(97, 21);
            label_customerName.TabIndex = 0;
            label_customerName.Text = $": {customer.CustomerName}";

            label34.AutoSize = true;
            label34.Location = new System.Drawing.Point(101, 60);
            label34.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(46, 21);
            label34.TabIndex = 0;
            label34.Text = "Date";

            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(101, 34);
            label33.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(84, 21);
            label33.TabIndex = 0;
            label33.Text = "Total cost";

            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(101, 8);
            label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(81, 21);
            label13.TabIndex = 0;
            label13.Text = "Customer";

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(15, 15);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(60, 60);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 1;
            rjCircularPictureBox_customerImage.TabStop = false;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjCircularPictureBox_customerImage.SizeMode = PictureBoxSizeMode.Zoom;


            iconButton_expandProductDetail.BackColor = System.Drawing.SystemColors.Control;
            iconButton_expandProductDetail.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_expandProductDetail.FlatAppearance.BorderSize = 0;
            iconButton_expandProductDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_expandProductDetail.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton_expandProductDetail.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            iconButton_expandProductDetail.IconColor = System.Drawing.Color.LightBlue;
            iconButton_expandProductDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_expandProductDetail.IconSize = 30;
            iconButton_expandProductDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.Location = new System.Drawing.Point(20, 111);
            iconButton_expandProductDetail.Name = "iconButton_expandProductDetail";
            iconButton_expandProductDetail.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            iconButton_expandProductDetail.Size = new System.Drawing.Size(925, 40);
            iconButton_expandProductDetail.TabIndex = 13;
            iconButton_expandProductDetail.Text = "Product Detail";
            iconButton_expandProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            iconButton_expandProductDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_expandProductDetail.UseVisualStyleBackColor = false;
            iconButton_expandProductDetail.Click += new System.EventHandler(IconButton_expandProductDetail_Click);
            //iconButton_expandProductDetail.Margin = new 



            panel_orderInfo.Controls.Add(rjCircularPictureBox_customerImage);
            panel_orderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            panel_orderInfo.Location = new System.Drawing.Point(20, 24);
            panel_orderInfo.Name = "panel_orderInfo";
            panel_orderInfo.Size = new System.Drawing.Size(925, 87);
            panel_orderInfo.TabIndex = 12;

            panel_orderInfo.Controls.Add(label_totalCost);
            panel_orderInfo.Controls.Add(label_customerName);
            panel_orderInfo.Controls.Add(rjButton_repurchase);
            panel_orderInfo.Controls.Add(label_orderDate);
            panel_orderInfo.Controls.Add(label1);
            panel_orderInfo.Controls.Add(label13);
            panel_orderInfo.Controls.Add(label33);
            panel_orderInfo.Controls.Add(label34);

            //groupBox_recievedOrder.Controls.Add(panel_OrderDetail);
            groupBox_recievedOrder.Controls.Add(iconButton_expandProductDetail);
            groupBox_recievedOrder.Controls.Add(panel_orderInfo);

            groupBox_recievedOrder.MaximumSize = new Size(965, 87 + 40 + (130 * orderDetails.Count()) + 40);
            groupBox_recievedOrder.Size = groupBox_recievedOrder.MaximumSize;
            //groupBox_recievedOrder.AutoSize = true;
            groupBox_recievedOrder.BackColor = System.Drawing.SystemColors.Control;
            groupBox_recievedOrder.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_recievedOrder.Font = new System.Drawing.Font("Tahoma", 10F);
            groupBox_recievedOrder.Location = new System.Drawing.Point(10, 0);
            groupBox_recievedOrder.Name = "groupBox_recievedOrder";
            groupBox_recievedOrder.Padding = new System.Windows.Forms.Padding(20, 3, 20, 10);
            groupBox_recievedOrder.TabIndex = 1;
            groupBox_recievedOrder.TabStop = false;


            return groupBox_recievedOrder;
        }

        private void RjButton_repurchase_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Are you sure, this order'll purchase again !","Notice",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
             {
                return;
             }

            Order order = ((sender as RJButton).Tag as Order);
            OrderDetail[] orderDetailTem = orderDetails.Where(orderdetail => orderdetail.OrderId == order.OrderId).ToArray();
            order.Add();
            foreach(OrderDetail orderDetail in orderDetailTem)
            {
                orderDetail.OrderId = order.OrderId;
                orderDetail.Add();
            }
            MessageBox.Show("Your Order've been repurchased, Check waiting for more!");
        }

        private Panel GenerateReceivedOrderDetail(OrderDetail orderDetail, Product product, Shop shop)
        {
            Panel panel_OrderDetail = new Panel();
            IconButton iconButton_shop = new IconButton();
            Button button_shopName = new Button();
            PictureBox pictureBox_orderDetailImage = new PictureBox();
            Label label_orderDetailProductname = new Label();
            Label label_orderDetailQuantity = new Label();
            Label label_originalPrice = new Label();
            Label label_finalPrice = new Label();



            //
            RJButton rjButton_commentOrderDetail = new RJButton();
            Panel panel3 = new Panel();

            panel3.Controls.Add(rjButton_commentOrderDetail);
            panel3.Dock = System.Windows.Forms.DockStyle.Right;
            panel3.Location = new System.Drawing.Point(739, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(181, 130);
            panel3.TabIndex = 10;


            rjButton_commentOrderDetail.Location = new System.Drawing.Point(22, 46);
            rjButton_commentOrderDetail.Tag = orderDetail;
            rjButton_commentOrderDetail.Text = "Comment";
            rjButton_commentOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_commentOrderDetail.BackColor = System.Drawing.SystemColors.Control;
            rjButton_commentOrderDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_commentOrderDetail.BorderColor = System.Drawing.Color.LightCoral;
            rjButton_commentOrderDetail.BorderRadius = 15;
            rjButton_commentOrderDetail.BorderSize = 0;
            rjButton_commentOrderDetail.FlatAppearance.BorderSize = 0;
            rjButton_commentOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_commentOrderDetail.ForeColor = System.Drawing.Color.DodgerBlue;
            rjButton_commentOrderDetail.Location = new System.Drawing.Point(20, 46);
            rjButton_commentOrderDetail.Name = "rjButton_commentOrderDetail";
            rjButton_commentOrderDetail.Size = new System.Drawing.Size(134, 35);
            rjButton_commentOrderDetail.TabIndex = 12;
            rjButton_commentOrderDetail.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_commentOrderDetail.UseVisualStyleBackColor = false;
            rjButton_commentOrderDetail.Click += RjButton_commentOrderDetail_Click;
            rjButton_commentOrderDetail.Tag = orderDetail;

            if(comments.Any(comment => comment.OrderDetailID == orderDetail.OrderDetailId))
            {
                rjButton_commentOrderDetail.Enabled = false;
                rjButton_commentOrderDetail.Text = "Commented";
                rjButton_commentOrderDetail.ForeColor = Color.Silver;
            }
            //

            label_orderDetailQuantity.AutoSize = true;
            label_orderDetailQuantity.Location = new System.Drawing.Point(140, 82);
            label_orderDetailQuantity.Name = "label_orderDetailQuantity";
            label_orderDetailQuantity.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            label_orderDetailQuantity.Size = new System.Drawing.Size(41, 21);
            label_orderDetailQuantity.TabIndex = 0;
            label_orderDetailQuantity.Text = $"x{orderDetail.Quantity}";

            label_originalPrice.AutoSize = true;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Strikeout);
            label_originalPrice.ForeColor = System.Drawing.Color.Silver;
            label_originalPrice.Location = new System.Drawing.Point(244, 82);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(70, 21);
            label_originalPrice.TabIndex = 0;
            label_originalPrice.Text = $"đ{orderDetail.Quantity.ToInt() * orderDetail.UnitPrice.ToInt()}";

            label_finalPrice.AutoSize = true;
            label_finalPrice.ForeColor = System.Drawing.Color.LightCoral;
            label_finalPrice.Location = new System.Drawing.Point(334, 82);
            label_finalPrice.Name = "label_finalPrice";
            label_finalPrice.Size = new System.Drawing.Size(70, 21);
            label_finalPrice.TabIndex = 0;
            label_finalPrice.Text = $"đ{label_originalPrice.Text.Split('đ').Last().ToInt() - orderDetail.Discount.ToInt()}";



            label_orderDetailProductname.Location = new System.Drawing.Point(135, 46);
            label_orderDetailProductname.Name = "label_orderDetailProductname";
            label_orderDetailProductname.Size = new System.Drawing.Size(371, 21);
            label_orderDetailProductname.TabIndex = 0;
            label_orderDetailProductname.Text = product.ProductName;

            pictureBox_orderDetailImage.Location = new System.Drawing.Point(45, 46);
            pictureBox_orderDetailImage.Name = "pictureBox_orderDetailImage";
            pictureBox_orderDetailImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_orderDetailImage.TabIndex = 0;
            pictureBox_orderDetailImage.TabStop = false;
            pictureBox_orderDetailImage.Tag = product;
            pictureBox_orderDetailImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_orderDetailImage.Click += PictureBox_orderDetailImage_Click;
            pictureBox_orderDetailImage.SizeMode = PictureBoxSizeMode.Zoom;

            button_shopName.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.BorderSize = 0;
            button_shopName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            button_shopName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            button_shopName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_shopName.Location = new System.Drawing.Point(81, 7);
            button_shopName.Name = "button_shopName";
            button_shopName.Size = new System.Drawing.Size(138, 35);
            button_shopName.TabIndex = 6;
            button_shopName.Text = shop.ShopName;
            button_shopName.UseVisualStyleBackColor = true;
            button_shopName.Tag = shop;
            button_shopName.Click += Button_shopName_Click1;

            iconButton_shop.Enabled = false;
            iconButton_shop.FlatAppearance.BorderSize = 0;
            iconButton_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_shop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconButton_shop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            iconButton_shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_shop.IconSize = 35;
            iconButton_shop.Location = new System.Drawing.Point(45, 7);
            iconButton_shop.Name = "iconButton_shop";
            iconButton_shop.Size = new System.Drawing.Size(30, 37);
            iconButton_shop.TabIndex = 5;
            iconButton_shop.UseVisualStyleBackColor = true;


            panel3.Controls.Add(rjButton_cancelOrderDetailOne);
            panel_OrderDetail.Controls.Add(panel3);

            panel_OrderDetail.Controls.Add(pictureBox_orderDetailImage);
            panel_OrderDetail.Controls.Add(label_orderDetailQuantity);
            panel_OrderDetail.Controls.Add(label_finalPrice);
            panel_OrderDetail.Controls.Add(label_originalPrice);
            panel_OrderDetail.Controls.Add(label_orderDetailProductname);
            panel_OrderDetail.Controls.Add(button_shopName);
            panel_OrderDetail.Controls.Add(iconButton_shop);

            panel_OrderDetail.Controls.Add(label_statusWaiting);
            panel_OrderDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_OrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            panel_OrderDetail.Location = new System.Drawing.Point(20, 151);
            panel_OrderDetail.MaximumSize = new System.Drawing.Size(0, 130);
            panel_OrderDetail.Name = "panel_OrderDetail";
            panel_OrderDetail.Size = new System.Drawing.Size(925, 130);
            panel_OrderDetail.TabIndex = 14;

            return panel_OrderDetail;

        }

        private void RjButton_commentOrderDetail_Click(object sender, EventArgs e)
        {
            //navigate to add comment Gui;
            objectExternalLink((OrderDetail)(sender as RJButton).Tag);


        }

        private void RjButton_receiveOrder_Click(object sender, EventArgs e)
        {
            //set this order recieved;
            ((sender as RJButton).Tag as Order).UpdateReceivedState().Update();
            MessageBox.Show("Your order recieved state has been updated!");
            InitializeDatasets();
            FillAllWaitingOrdersAndConfirmOrder();
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

        internal void HeadingToRecieveOrder()
        {
            //navigate to the received order;
            TabControl_Orders.SelectedTab = tabPage_RecievedOrder;
            IconButton_recievedOrder_Click(iconButton_recievedOrder, null);
                
        }
    }
}

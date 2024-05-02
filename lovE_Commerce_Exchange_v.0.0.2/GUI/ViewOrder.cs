using BUS;
using CustomControls.RJControls;
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
    public partial class ViewOrder : Form
    {
        Order order;
        List<OrderDetail> orderDetails = new List<OrderDetail>();
        Customer customer;
        Voucher[] vouchers;
        Product[] products;
        Account account;

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
            if(entity is ShoppingCart)
            {
                orderDetails.Clear();
            }
            else if (entity is OrderDetail)
            {
                orderDetails.Add((OrderDetail)entity);
            }     
            else if(entity is Account)
            {
               
                account = (Account)entity;
                LoadEvrything();
                //orderDetails
                
            }
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadEvrything()
        {
            //refresh data

            customer = Customer.GetCustomers().Single(acc => acc.CustomerId == account.AccountID);

            //fill order data
            order = new Order(new DLL.Order_());
            order.Date = DateTime.Now.ToString().Split(' ')[0];
            order.CustomerID = customer.CustomerId;
            order.TotalAmount = CalulatedProvisional();

            label_customerName.Text = customer.CustomerName;
            label_customerPhonenumber.Text = customer.PhoneNumber;
            label_customerAddress.Text = customer.Address;
            label_dateNow.Text = order.Date;

            FillProductDetail();
            CalulatedProvisional();


            //order = null;
            //vouchers = null;
            //account = null;
            //products = null;
            //customer = null;
        }

        private string CalulatedProvisional()
        {
            int totalAmount = 0;
            foreach(OrderDetail orderDetail in orderDetails)
            {
                    totalAmount += ((orderDetail.UnitPrice.ToInt() * orderDetail.Quantity.ToInt()) - orderDetail.Discount.ToInt());
            }
            label_totalAmount.Text = totalAmount.ToString();
            label_provisional.Text = totalAmount.ToString();

            return totalAmount.ToString();

        }

        private void FillProductDetail()
        {
            panel_productDetailContainer.Controls.Clear();
            products = Product.GetProducts().Join(orderDetails, pro => pro.ProductId, ordertail => ordertail.ProductId, (pro, ordertail) => pro).ToArray();
            vouchers = Voucher.GetVouchers().Join(products, vou => vou.ShopId, pro => pro.ShopID, (vou, pro) => vou).ToArray();
            foreach (var tuple in products.Zip(orderDetails, Tuple.Create))
            {
                panel_productDetailContainer.Controls.Add(GenerateProductDetail(tuple.Item1,tuple.Item2, vouchers.Where(vou => vou.ShopId == tuple.Item1.ShopID)));
            }
        }
        private Panel GenerateProductDetail(Product product,OrderDetail orderDetail, IEnumerable<Voucher> vouchers) { 
            Panel panel_productDetail = new Panel();
            RJButton rjButton_orderDetailbackground = new RJButton();
            Panel panel_productDetailHolder = new Panel();
            PictureBox pictureBox_productImage = new PictureBox();
            Label label_productName = new Label();
            Label label_promotionShop = new Label();
            Label label_originalPrice = new Label();
            Label label_priceAfterDiscount = new Label();
            ComboBox comboBox_shopvoucher = new ComboBox();
            Label label_productQuantity = new Label();


            comboBox_shopvoucher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            comboBox_shopvoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox_shopvoucher.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox_shopvoucher.ForeColor = System.Drawing.Color.DimGray;
            comboBox_shopvoucher.FormattingEnabled = true;
            comboBox_shopvoucher.Location = new System.Drawing.Point(131, 84);
            comboBox_shopvoucher.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            comboBox_shopvoucher.Name = "comboBox_shopvoucher";
            comboBox_shopvoucher.Size = new System.Drawing.Size(229, 29);
            comboBox_shopvoucher.TabIndex = 9;
            comboBox_shopvoucher.Text = "Shop Voucher";
            comboBox_shopvoucher.SelectedIndexChanged += ComboBox_shopvoucher_SelectedIndexChanged;

            foreach(Voucher vou in vouchers)
            {
                comboBox_shopvoucher.Items.Add(vou);
            }

            label_priceAfterDiscount.AutoSize = true;
            label_priceAfterDiscount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_priceAfterDiscount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_priceAfterDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_priceAfterDiscount.Location = new System.Drawing.Point(175, 42);
            label_priceAfterDiscount.Name = "label_priceAfterDiscount";
            label_priceAfterDiscount.Size = new System.Drawing.Size(75, 21);
            label_priceAfterDiscount.TabIndex = 0;
            //label_priceAfterDiscount.Text ="";

            label_originalPrice.AutoSize = true;
            label_originalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10.2F);
            //label_originalPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_originalPrice.ForeColor = System.Drawing.Color.DarkGray;
            label_originalPrice.Location = new System.Drawing.Point(94, 42);
            label_originalPrice.Name = "label_originalPrice";
            label_originalPrice.Size = new System.Drawing.Size(75, 21);
            label_originalPrice.TabIndex = 0;
            label_originalPrice.Text = product.Price +" đ";

            label_productQuantity.AutoSize = true;
            label_productQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_productQuantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productQuantity.ForeColor = System.Drawing.Color.Firebrick;
            label_productQuantity.Location = new System.Drawing.Point(94 + label_originalPrice.Size.Width + 20, 42);
            label_productQuantity.Name = "label_productQuantity";
            label_productQuantity.Size = new System.Drawing.Size(36, 21);
            label_productQuantity.TabIndex = 0;
            label_productQuantity.Text = "x" + orderDetail.Quantity;

            label_promotionShop.AutoSize = true;
            label_promotionShop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_promotionShop.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_promotionShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_promotionShop.Location = new System.Drawing.Point(3, 86);
            label_promotionShop.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            label_promotionShop.Name = "label_promotionShop";
            label_promotionShop.Size = new System.Drawing.Size(118, 24);
            label_promotionShop.TabIndex = 0;
            label_promotionShop.Text = "Promotion Shop";

            label_productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            label_productName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_productName.Location = new System.Drawing.Point(94, 9);
            label_productName.Name = "label_productName";
            label_productName.Size = new System.Drawing.Size(450, 27);
            label_productName.TabIndex = 7;
            label_productName.Text = product.ProductName;
            label_productName.Click += new System.EventHandler(PictureBox_productImage_Click);
            label_productName.Tag = product;
            label_productName.AutoEllipsis = true;

            pictureBox_productImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_productImage.Location = new System.Drawing.Point(3, 3);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_productImage.TabIndex = 8;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.Click += new System.EventHandler(PictureBox_productImage_Click);
            pictureBox_productImage.Tag = product;

            panel_productDetailHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            panel_productDetailHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_productDetailHolder.Controls.Add(label_promotionShop);
            panel_productDetailHolder.Controls.Add(comboBox_shopvoucher);
            panel_productDetailHolder.Controls.Add(pictureBox_productImage);
            panel_productDetailHolder.Controls.Add(label_productName);
            panel_productDetailHolder.Controls.Add(label_originalPrice);
            panel_productDetailHolder.Controls.Add(label_priceAfterDiscount);
            panel_productDetailHolder.Controls.Add(label_productQuantity);
            panel_productDetailHolder.Location = new System.Drawing.Point(22, 20);
            panel_productDetailHolder.Name = "panel_productDetailHolder";
            panel_productDetailHolder.Size = new System.Drawing.Size(440, 115);
            panel_productDetailHolder.TabIndex = 10;
            panel_productDetailHolder.Tag = product;

            rjButton_orderDetailbackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_orderDetailbackground.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_orderDetailbackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_orderDetailbackground.BorderRadius = 15;
            rjButton_orderDetailbackground.BorderSize = 0;
            rjButton_orderDetailbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_orderDetailbackground.Enabled = false;
            rjButton_orderDetailbackground.FlatAppearance.BorderSize = 0;
            rjButton_orderDetailbackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_orderDetailbackground.ForeColor = System.Drawing.Color.White;
            rjButton_orderDetailbackground.Location = new System.Drawing.Point(0, 0);
            rjButton_orderDetailbackground.Name = "rjButton_orderDetailbackground";
            rjButton_orderDetailbackground.Size = new System.Drawing.Size(474, 155);
            rjButton_orderDetailbackground.TabIndex = 0;
            rjButton_orderDetailbackground.TextColor = System.Drawing.Color.White;
            rjButton_orderDetailbackground.UseVisualStyleBackColor = false;

            panel_productDetail.Controls.Add(panel_productDetailHolder);
            panel_productDetail.Controls.Add(rjButton_orderDetailbackground);
            panel_productDetail.Dock = System.Windows.Forms.DockStyle.Top;
            panel_productDetail.Location = new System.Drawing.Point(5, 0);
            panel_productDetail.Name = "panel_productDetail";
            panel_productDetail.Size = new System.Drawing.Size(474, 155);
            panel_productDetail.TabIndex = 2;
            panel_productDetail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            panel_productDetail.Tag = orderDetail;


            return panel_productDetail;
        }

        private void ComboBox_shopvoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check price and relocation the discount price
            //manipulate the panel prouduct detail;
            Voucher selectedVoucher = (Voucher)(sender as ComboBox).SelectedItem;
            Panel productDetail = (sender as ComboBox).Parent as Panel;

            Label originalPrice = productDetail.Controls.Find("label_originalPrice", true)[0] as Label;
            originalPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            Label afterPrice = productDetail.Controls.Find("label_priceAfterDiscount", true)[0] as Label;

            //int discount =
            afterPrice.Text = originalPrice.Text.Split(' ')[0].CalculatedDiscount(selectedVoucher).ToString();

            OrderDetail orderDetail = orderDetails.Single(ord => ord.ProductId == (productDetail.Tag as Product).ProductId);
            orderDetail.Discount = (originalPrice.Text.ToInt() - afterPrice.Text.ToInt()).ToString();
            orderDetail.VoucherID = selectedVoucher.VoucherId;
            CalulatedProvisional();

        }

        
        private void RjButton_purcharse_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","Purchase",MessageBoxButtons.OKCancel) == DialogResult.Cancel) { return; }
            //add Order Here
            order.Add();

            //orderDetails = GetOrderDetailSelected().ToList();

            foreach (OrderDetail detail in orderDetails)
            {
                //detail.OrderId = order.OrderId;
                detail.OrderId = order.OrderId;
                detail.Add();
            }
            customer = null;
            orderDetails.Clear();
            order = null;
            vouchers = null;
            products = null;
            account = null;
            MessageBox.Show("Thanks for your time, your order've been sending", "Notice");
            //objectExternalLink(account);
            Hide();
            //objectExternalLink(customer);
            //{
            //    objectExternalLink(account);
            //}
            //else
            //{
            //    objectExternalLink(customer);

            //}
           
        }

        private IEnumerable<OrderDetail> GetOrderDetailSelected()
        {
            foreach (Panel orderdetail in panel_productDetailContainer.Controls.OfType<Panel>())
            {
                yield return (orderdetail.Tag as OrderDetail);
            }
        }

        private void Label_change_Click(object sender, EventArgs e)
        {
            objectExternalLink(new ShoppingCart(new DLL.ShoppingCart_()));
        }

        private void PictureBox_productImage_Click(object sender, EventArgs e)
        {
            objectExternalLink((Product)(sender as Control).Tag);
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            objectExternalLink(new ShoppingCart(new DLL.ShoppingCart_() { }));
        }
    }
}

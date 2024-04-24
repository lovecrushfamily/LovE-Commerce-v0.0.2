using BUS;
using CustomControls.RJControls;
using FontAwesome.Sharp;
using GUI.CustomControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class ViewShoppingCart : Form
    {
        private ShoppingCart[] shoppingCarts;
        private Customer customer;
        private Product[] products;
        private Shop[] shops;
        private Account account;

        public ViewShoppingCart()
        {
            InitializeComponent();
            //customer = customer;

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
            //if(customer != null)
            ShoppingCart shoppingCart = new ShoppingCart(new DLL.ShoppingCart_()
            {
                ProducID = product.ProductId,
                CustomerId = customer.CustomerId
            });
            if (shoppingCarts.Any(shoping => shoping.ProducID == shoppingCart.ProducID && shoping.CustomerId == shoppingCart.CustomerId))
            {
                MessageBox.Show("This product's already in your shoppingCart");
                return;
            }
            shoppingCart.AddProduct();
            MessageBox.Show("Product added !");
        }

        public void SetAccount(Account account)
        {                                                                 
            this.account = account;
            customer = Customer.GetCustomers().Single(cus => cus.CustomerId == account.AccountID);
            shoppingCarts = ShoppingCart.GetShoppingCarts().Where(shop => shop.CustomerId == customer.CustomerId).ToArray();
            products = Product.GetProducts().Join(shoppingCarts, pro => pro.ProductId, shopping => shopping.ProducID, (pro, shopping) => pro).ToArray();
            shops = Shop.GetShops().Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray();

            FillEverything();
            FillProduct(

                );
        }

        private void FillEverything()
        {
            label_customerAddress.Text = customer.Address;
            label_customerPhone.Text = customer.PhoneNumber;
            label_customerName.Text = customer.CustomerName;

        }

        private void ShoppingCart_Resize(object sender, EventArgs e)
        {
            if (panel_products.VerticalScroll.Visible)
            {
                panel_products.Padding = new Padding(0, 0, 14, 0);
            }
            else
            {
                panel_products.Padding = new Padding(0, 0, 35, 0);

            }
        }

        private void FillProduct()
        {

            panel_products.Controls.Clear();

            foreach (var tuple in products.Zip(shops, Tuple.Create))
            {
                panel_products.Controls.Add(GenerateProduct(tuple.Item1, tuple.Item2));
            }

        }
        private Panel GenerateProduct(Product product, Shop shop)
        {
            Panel panel_product = new Panel();
            RJButton rjButton_productbackground = new RJButton();
            Panel panel_productControlHolder = new Panel();
            CheckBox checkBox_shopChecker = new CheckBox();
            IconButton iconButton_shopIcon = new IconButton();
            RJButton rjButton_shopNav = new RJButton();
            CheckBox checkBox_productChecker = new CheckBox();
            PictureBox pictureBox_productImage = new PictureBox();
            Label label_productName = new Label();
            Label label_address = new Label();
            Label label_shopDiscount = new Label();
            ComboBox comboBox_shopVoucher = new ComboBox();
            Label label_unitAmount = new Label();
            Label label_unitAmountCurrency = new Label();
            IconButton iconButton_quantityDown = new IconButton();
            IconButton iconButton_quantityUp = new IconButton();
            Label label_price = new Label();
            Label label_productPriceCurrency = new Label();
            IconButton iconButton_delete_product = new IconButton();
            MyNumericUpDown myNumericUpDown_quantity = new MyNumericUpDown();
            Label label7 = new Label();
            Label label17 = new Label();
            Label label16 = new Label();
            Label label15 = new Label();




            label15.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right);
            label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
                label15.Location = new System.Drawing.Point(488, 51);
                label15.Name = "label15";
                label15.Size = new System.Drawing.Size(53, 10);
            label15.TabIndex = 27;

            label16.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label16.Location = new System.Drawing.Point(534, 58);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(10, 45);
            label16.TabIndex = 26;

            label17.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label17.Location = new System.Drawing.Point(485, 58);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(10, 45);
            label17.TabIndex = 25;

            label7.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label7.Location = new System.Drawing.Point(488, 101);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 10);
            label7.TabIndex = 28;

            myNumericUpDown_quantity.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            myNumericUpDown_quantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            myNumericUpDown_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            myNumericUpDown_quantity.ForeColor = System.Drawing.Color.DimGray;
            myNumericUpDown_quantity.Location = new System.Drawing.Point(488, 58);
            myNumericUpDown_quantity.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            myNumericUpDown_quantity.Name = "myNumericUpDown_quantity";
            myNumericUpDown_quantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            myNumericUpDown_quantity.PlaceholderText = "";
            myNumericUpDown_quantity.Size = new System.Drawing.Size(53, 45);
            myNumericUpDown_quantity.TabIndex = 22;
            myNumericUpDown_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            myNumericUpDown_quantity.Value = 1;
            myNumericUpDown_quantity.ValueChanged += MyNumericUpDown_quantity_ValueChanged;

            iconButton_delete_product.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            iconButton_delete_product.FlatAppearance.BorderSize = 0;
            iconButton_delete_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_delete_product.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton_delete_product.IconColor = System.Drawing.Color.DimGray;
            iconButton_delete_product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_delete_product.IconSize = 30;
            iconButton_delete_product.Location = new System.Drawing.Point(795, 66);
            iconButton_delete_product.Name = "iconButton_delete_product";
            iconButton_delete_product.Size = new System.Drawing.Size(38, 31);
            iconButton_delete_product.TabIndex = 3;
            iconButton_delete_product.UseVisualStyleBackColor = true;
            iconButton_delete_product.Click += IconButton_delete_product_Click;
            iconButton_delete_product.Tag = product.ProductId;


            label_price.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            label_price.AutoSize = true;
            label_price.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_price.ForeColor = System.Drawing.Color.Tomato;
            label_price.Location = new System.Drawing.Point(618, 70);
            label_price.Name = "label_price";
            label_price.Size = new System.Drawing.Size(99, 29);
            label_price.TabIndex = 5;
            label_price.Text = product.Price;

            label_productPriceCurrency.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            label_productPriceCurrency.AutoSize = true;
            label_productPriceCurrency.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_productPriceCurrency.ForeColor = System.Drawing.Color.LightCoral;
            label_productPriceCurrency.Location = new System.Drawing.Point(label_price.Location.X + label_price.Size.Width -5, 64);
            label_productPriceCurrency.Name = "label_productPriceCurrency";
            label_productPriceCurrency.Size = new System.Drawing.Size(23, 29);
            label_productPriceCurrency.TabIndex = 5;
            label_productPriceCurrency.Text = "đ";

            iconButton_quantityUp.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            iconButton_quantityUp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            iconButton_quantityUp.ForeColor = System.Drawing.Color.DimGray;
            iconButton_quantityUp.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            iconButton_quantityUp.IconColor = System.Drawing.Color.FromArgb(((byte)(64)), ((byte)(64)), ((byte)(64)));
            iconButton_quantityUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_quantityUp.IconSize = 35;
            iconButton_quantityUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            iconButton_quantityUp.Location = new System.Drawing.Point(547, 58);
            iconButton_quantityUp.Name = "iconButton_quantityUp";
            iconButton_quantityUp.Padding = new System.Windows.Forms.Padding(1, 6, 0, 0);
            iconButton_quantityUp.Size = new System.Drawing.Size(40, 40);
            iconButton_quantityUp.TabIndex = 23;
            iconButton_quantityUp.UseVisualStyleBackColor = false;
            iconButton_quantityUp.Click += IconButton_quantityUp_Click1;

            iconButton_quantityDown.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            iconButton_quantityDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            iconButton_quantityDown.ForeColor = System.Drawing.Color.DimGray;
            iconButton_quantityDown.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton_quantityDown.IconColor = System.Drawing.Color.Black;
            iconButton_quantityDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_quantityDown.IconSize = 20;
            iconButton_quantityDown.Location = new System.Drawing.Point(442, 56);
            iconButton_quantityDown.Name = "iconButton_quantityDown";
            iconButton_quantityDown.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            iconButton_quantityDown.Size = new System.Drawing.Size(40, 40);
            iconButton_quantityDown.TabIndex = 24;
            iconButton_quantityDown.UseVisualStyleBackColor = false;
            iconButton_quantityDown.Click += IconButton_quantityDown_Click1;

            label_unitAmount.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            label_unitAmount.AutoSize = true;
            label_unitAmount.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            label_unitAmount.Location = new System.Drawing.Point(310, 70);
            label_unitAmount.Name = "label_unitAmount";
            label_unitAmount.TabIndex = 5;
            label_unitAmount.Text = product.Price;                  

            label_unitAmountCurrency.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Right);
            label_unitAmountCurrency.AutoSize = true;
            label_unitAmountCurrency.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            label_unitAmountCurrency.Location = new System.Drawing.Point(label_unitAmount.Location.X + label_unitAmount.Size.Width- 10, 67);
            label_unitAmountCurrency.Name = "label_unitAmountCurrency";
            label_unitAmountCurrency.TabIndex = 5;
            label_unitAmountCurrency.Text = "đ";

            comboBox_shopVoucher.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            comboBox_shopVoucher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            comboBox_shopVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox_shopVoucher.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox_shopVoucher.ForeColor = System.Drawing.Color.DimGray;
            comboBox_shopVoucher.FormattingEnabled = true;
            comboBox_shopVoucher.Location = new System.Drawing.Point(207, 139);
            comboBox_shopVoucher.Name = "comboBox_shopVoucher";
            comboBox_shopVoucher.Size = new System.Drawing.Size(175, 29);
            comboBox_shopVoucher.TabIndex = 6;
            comboBox_shopVoucher.Text = "Shop Voucher"; ;
            comboBox_shopVoucher.Click += delegate { MessageBox.Show("Available at Order&&Payment page"); };

            label_shopDiscount.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
            label_shopDiscount.AutoSize = true;
            label_shopDiscount.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            label_shopDiscount.ForeColor = System.Drawing.Color.DimGray;
            label_shopDiscount.Location = new System.Drawing.Point(45, 138);
            label_shopDiscount.Name = "label_shopDiscount";
            label_shopDiscount.Size = new System.Drawing.Size(128, 29);
            label_shopDiscount.TabIndex = 7;
            label_shopDiscount.Text = "Shop Discount";

            label_address.AutoSize = true;
            label_address.Font = new System.Drawing.Font("Sans Serif Collection", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_address.Location = new System.Drawing.Point(136, 101);
            label_address.Name = "label_address";
            label_address.Size = new System.Drawing.Size(144, 23);
            label_address.TabIndex = 9;
            label_address.Text = shop.Address;

            label_productName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right);
            label_productName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_productName.Location = new System.Drawing.Point(137, 44);
            label_productName.Name = "label_productName";
            label_productName.Size = new System.Drawing.Size(156, 69);
            label_productName.TabIndex = 8;
            label_productName.Text = product.ProductName;

            pictureBox_productImage.Location = new System.Drawing.Point(50, 44);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(80, 80);
            pictureBox_productImage.TabIndex = 3;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.Tag = product;
            pictureBox_productImage.Click += PictureBox_productImage_Click;
            pictureBox_productImage.SizeMode = PictureBoxSizeMode.Zoom;

            checkBox_productChecker.AutoSize = true;
            checkBox_productChecker.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBox_productChecker.Location = new System.Drawing.Point(16, 77);
            checkBox_productChecker.Name = "checkBox_productChecker";
            checkBox_productChecker.Size = new System.Drawing.Size(18, 17);
            checkBox_productChecker.TabIndex = 2;
            checkBox_productChecker.UseVisualStyleBackColor = true;
            checkBox_productChecker.CheckedChanged += CheckBox_productChecker_CheckedChanged;
            checkBox_productChecker.Tag = product;


            rjButton_shopNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_shopNav.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_shopNav.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_shopNav.BorderRadius = 10;
            rjButton_shopNav.BorderSize = 0;
            rjButton_shopNav.FlatAppearance.BorderSize = 0;
            rjButton_shopNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_shopNav.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rjButton_shopNav.ForeColor = System.Drawing.Color.FromArgb(((byte)(64)), ((byte)(64)), ((byte)(64)));
            rjButton_shopNav.Location = new System.Drawing.Point(76, 4);
            rjButton_shopNav.Name = "rjButton_shopNav";
            rjButton_shopNav.Size = new System.Drawing.Size(121, 28);
            rjButton_shopNav.TabIndex = 5;
            rjButton_shopNav.Text = "Shop name >";
            rjButton_shopNav.TextColor = System.Drawing.Color.FromArgb(((byte)(64)), ((byte)(64)), ((byte)(64)));
            rjButton_shopNav.UseVisualStyleBackColor = false;
            rjButton_shopNav.Click += RjButton_shopNav_Click;
            rjButton_shopNav.Tag = shop;

            iconButton_shopIcon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            iconButton_shopIcon.FlatAppearance.BorderSize = 0;
            iconButton_shopIcon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            iconButton_shopIcon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            iconButton_shopIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_shopIcon.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconButton_shopIcon.IconColor = System.Drawing.Color.Black;
            iconButton_shopIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_shopIcon.IconSize = 35;
            iconButton_shopIcon.Location = new System.Drawing.Point(40, 0);
            iconButton_shopIcon.Name = "iconButton_shopIcon";
            iconButton_shopIcon.Size = new System.Drawing.Size(30, 37);
            iconButton_shopIcon.TabIndex = 4;
            iconButton_shopIcon.UseVisualStyleBackColor = true;

            checkBox_shopChecker.AutoSize = true;
            checkBox_shopChecker.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBox_shopChecker.Location = new System.Drawing.Point(16, 10);
            checkBox_shopChecker.Name = "checkBox_shopChecker";
            checkBox_shopChecker.Size = new System.Drawing.Size(18, 17);
            checkBox_shopChecker.TabIndex = 2;
            checkBox_shopChecker.UseVisualStyleBackColor = true;
            checkBox_shopChecker.Click += CheckBox_shopChecker_Click;

            panel_productControlHolder.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right);
            panel_productControlHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_productControlHolder.Location = new System.Drawing.Point(10, 20);
            panel_productControlHolder.Margin = new System.Windows.Forms.Padding(10);
            panel_productControlHolder.Name = "panel_productControlHolder";
            panel_productControlHolder.Padding = new System.Windows.Forms.Padding(10);
            panel_productControlHolder.Size = new System.Drawing.Size(843, 179);
            panel_productControlHolder.TabIndex = 1;

            rjButton_productbackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_productbackground.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_productbackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_productbackground.BorderRadius = 15;
            rjButton_productbackground.BorderSize = 0;
            rjButton_productbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_productbackground.Enabled = false;
            rjButton_productbackground.FlatAppearance.BorderSize = 0;
            rjButton_productbackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_productbackground.ForeColor = System.Drawing.Color.White;
            rjButton_productbackground.Location = new System.Drawing.Point(0, 0);
            rjButton_productbackground.Name = "rjButton_productbackground";
            rjButton_productbackground.Size = new System.Drawing.Size(863, 209);
            rjButton_productbackground.TabIndex = 0;
            rjButton_productbackground.TextColor = System.Drawing.Color.White;
            rjButton_productbackground.UseVisualStyleBackColor = false;


            panel_product.Dock = System.Windows.Forms.DockStyle.Top;
            panel_product.Location = new System.Drawing.Point(0, 0);
            panel_product.Name = "panel_product";
            panel_product.Size = new System.Drawing.Size(863, 209);
            panel_product.TabIndex = 1;
            panel_product.Padding = new Padding(0,10,0,0);

            panel_productControlHolder.Controls.Add(iconButton_delete_product);
            panel_productControlHolder.Controls.Add(label17);
            panel_productControlHolder.Controls.Add(label16);
            panel_productControlHolder.Controls.Add(label15);
            panel_productControlHolder.Controls.Add(label7);
            panel_productControlHolder.Controls.Add(iconButton_quantityDown);
            panel_productControlHolder.Controls.Add(iconButton_quantityUp);
            panel_productControlHolder.Controls.Add(myNumericUpDown_quantity);
            panel_productControlHolder.Controls.Add(label_productPriceCurrency);
            panel_productControlHolder.Controls.Add(label_price);
            panel_productControlHolder.Controls.Add(label_unitAmountCurrency);
            panel_productControlHolder.Controls.Add(label_address);
            panel_productControlHolder.Controls.Add(label_productName);
            panel_productControlHolder.Controls.Add(label_shopDiscount);
            panel_productControlHolder.Controls.Add(comboBox_shopVoucher);
            panel_productControlHolder.Controls.Add(rjButton_shopNav);
            panel_productControlHolder.Controls.Add(iconButton_shopIcon);
            panel_productControlHolder.Controls.Add(pictureBox_productImage);
            panel_productControlHolder.Controls.Add(checkBox_shopChecker);
            panel_productControlHolder.Controls.Add(checkBox_productChecker);
            panel_productControlHolder.Controls.Add(label_unitAmount);


            panel_product.Controls.Add(panel_productControlHolder);
            panel_product.Controls.Add(rjButton_productbackground);
            return panel_product;

        }

        private void MyNumericUpDown_quantity_ValueChanged(object sender, EventArgs e)
        {
            MyNumericUpDown my = sender as MyNumericUpDown;
            Panel parent = my.Parent as Panel;
            Label originalPrice = parent.Controls.Find("label_unitAmount", true)[0] as Label;
            Label afterPrice = parent.Controls.Find("label_price", true)[0] as Label;
            afterPrice.Text = (originalPrice.Text.ToInt() * my.Value).ToString();
        }

        private void PictureBox_productImage_Click(object sender, EventArgs e)
        {
            objectExternalLink((Product)(sender as PictureBox).Tag);
        }

        private void CheckBox_shopChecker_Click(object sender, EventArgs e)
        {
            CheckBox checker = (sender as CheckBox);
            if(checker.Checked)
                ((checker.Parent as Panel).Controls.Find("checkBox_productChecker",true)[0] as CheckBox).Checked = true;
            else
                ((checker.Parent as Panel).Controls.Find("checkBox_productChecker", true)[0] as CheckBox).Checked = false;
        }

        private void RjButton_shopNav_Click(object sender, EventArgs e)
        {
            objectExternalLink((Shop)(sender as RJButton).Tag);
        }

        private void CheckBox_productChecker_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checker = (sender as CheckBox);
            if (checker.Checked)
                ((checker.Parent as Panel).Controls.Find("checkBox_shopChecker", true)[0] as CheckBox).Checked = true;
            else
                ((checker.Parent as Panel).Controls.Find("checkBox_shopChecker", true)[0] as CheckBox).Checked = false;
            ReloadProvisional();
            checkBox_allProduct.Text = "All (" + GetSelectedOrderDetail().Count() + ")";

        }

        private void IconButton_quantityDown_Click1(object sender, EventArgs e)
        {
            MyNumericUpDown myNumericUpDown = ((sender as IconButton).Parent as Panel).Controls.Find("myNumericUpDown_quantity", true)[0] as   MyNumericUpDown;
            if (myNumericUpDown.Value > myNumericUpDown.Minimum + 1)
            {
                myNumericUpDown.Value--;
            }
            ReloadProvisional();
        }

        private void IconButton_quantityUp_Click1(object sender, EventArgs e)
        {
            MyNumericUpDown myNumericUpDown = ((sender as IconButton).Parent as Panel).Controls.Find("myNumericUpDown_quantity", true)[0] as MyNumericUpDown;
            if (myNumericUpDown.Value < myNumericUpDown.Maximum )
            {
                myNumericUpDown.Value++;
            }
            ReloadProvisional();

        }

        private void IconButton_delete_product_Click(object sender, EventArgs e)
        {
            
            if(e != null && MessageBox.Show("Are you sure, this product'll be deleted permanently?","Caution",MessageBoxButtons.OKCancel)== DialogResult.Cancel)
            {
                return;
            }
            shoppingCarts.Single(shopping => shopping.ProducID == ((sender as IconButton).Tag.ToString())).RemoveProduct();
            //SetAccount(account);
            Panel parent = (((sender as IconButton).Parent as Panel).Parent as Panel);
            parent.BringToFront();
            parent.RecursivelyDispose();
            ReloadProvisional();
            
        }

        private void ReloadProvisional()
        {

            label_provisional.Text = string.Empty;
            int provision = 0;
            foreach (CheckBox checkBox in panel_products.Controls.Find("checkBox_productChecker", true))
            {
                if (checkBox.Checked)
                {
                    provision += (checkBox.Parent as Panel).Controls.Find("label_price",true)[0].Text.ToInt();
                }
            }
            label_provisional.Text = provision.ToString().TurnToPriceFormat();
            label_total_amount.Text = provision.ToString().TurnToPriceFormat();
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
            if (myNumericUpDown_quantity.Value < 99)
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
            objectExternalLink(new ShoppingCart(new DLL.ShoppingCart_()));
            foreach (OrderDetail orderDetail in GetSelectedOrderDetail())
            {
                objectExternalLink(orderDetail);
            }
            objectExternalLink(new Customer(new DLL.Customer_()));
        }

       
        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Panel_productControlHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox_allProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allProduct.Checked)
            {
                foreach(CheckBox checkBox in panel_products.Controls.Find("checkBox_productChecker", true))
                {
                    checkBox.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox checkBox in panel_products.Controls.Find("checkBox_productChecker", true))
                {
                    checkBox.Checked = false;
                }

            }
        }
        private IEnumerable<OrderDetail> GetSelectedOrderDetail()
        {
            foreach (CheckBox checkBox in panel_products.Controls.Find("checkBox_productChecker", true))
            {
                if(checkBox.Checked)
                {
                    Panel parent = checkBox.Parent as Panel;
                    yield return new OrderDetail(new DLL.OrderDetail_()
                    {
                        ProductId = ((parent.Controls.Find("checkBox_productChecker", true)[0] as CheckBox).Tag as Product).ProductId,
                        UnitPrice = (parent.Controls.Find("label_unitAmount", true)[0] as Label).Text,
                        Discount = "0",
                        VoucherID = "0",
                        Quantity = (parent.Controls.Find("myNumericUpDown_quantity", true)[0] as MyNumericUpDown).Value.ToString()
                    });
                }
            }
        }

        private void IconButton_delete_products_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, these products'll be deleted from your shopping cart permanently!", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            foreach (CheckBox checkBox in panel_products.Controls.Find("checkBox_productChecker", true))
            {
                if (checkBox.Checked)
                {
                    Panel parent = checkBox.Parent as Panel;
                    IconButton_delete_product_Click(parent.Controls.Find("iconButton_delete_product", true)[0], null);
                }
            }
        }
    }
}

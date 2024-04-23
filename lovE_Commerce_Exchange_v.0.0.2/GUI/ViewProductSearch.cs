using BUS;
using FontAwesome.Sharp;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GUI
{
    public partial class ViewProductSearch : Form
    {
        Category[] currentCategories;
        Product[] products;
        Shop[] currentShops;
        Product[] currentProducts;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubViewShopProducts));


        public ViewProductSearch()
        {
            InitializeComponent();
            label12.BringToFront();
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









        #region Load data and filter data
        public void SearchKeyWord(string keyWord)
        {
            //Product.GetProducts().Where(pro => pro.ProductName.FilterKeyWord(keyWord)).
            products = Product.GetProducts().Where(pro => pro.ProductName.Contains(keyWord)).ToArray();
            currentProducts = products;
            currentCategories = Category.GetCategories().Join(products, cate => cate.CategoryId, pro => pro.CategoryID,(cate, pro) => cate).ToArray();
            currentShops = Shop.GetShops().Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray();

            FillProduct(products,currentShops);
            FillAddress(currentShops);
            FillCategoryOfProducts(currentCategories);
        }
        private void FillProduct(Product[] products, Shop[] shops)
        {
            flowLayoutPanel_productsContainer.Controls.Clear();
            foreach (var tuple in products.Zip(shops, Tuple.Create))
            {
                flowLayoutPanel_productsContainer.Controls.Add(GenerateProduct(tuple.Item1, tuple.Item2.Address));
            }
        }
        private void FillAddress(Shop[] shops)
        {
            flowLayoutPanel_addressFilterContainer.Controls.Clear();
            GenerateByAddressPanel();
            foreach (Shop shop in products.Join(shops,pro => pro.ShopID,shop => shop.ShopId,(pro, shop) => shop))
            {
                flowLayoutPanel_addressFilterContainer.Controls.Add(GenerateAddress(shop));
            }
        }
        private void FillCategoryOfProducts(Category[] categories)
        {
            flowLayoutPanel_categoryFilterContainer.Controls.Clear();
            GenerateByCategoryPanel();
            foreach (Category category in products.Join(categories, pro => pro.CategoryID, cate => cate.CategoryId,(pro,cate) => cate))
            {
                flowLayoutPanel_categoryFilterContainer.Controls.Add(GenerateCategory(category));
            }
        }
        private Panel GenerateAddress(Shop shop)
        {
            Panel panel_addressFilter= new Panel();
            CheckBox checkBox_address = new CheckBox();

            checkBox_address.AutoSize = true;
            checkBox_address.Dock = System.Windows.Forms.DockStyle.Top;
            checkBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox_address.Location = new System.Drawing.Point(40, 10);
            checkBox_address.Name = "checkBox_address";
            checkBox_address.Size = new System.Drawing.Size(218, 22);
            checkBox_address.TabIndex = 1;
            checkBox_address.Text = shop.Address;
            checkBox_address.UseVisualStyleBackColor = true;
            checkBox_address.CheckedChanged += CheckBox_address_CheckedChanged;
            checkBox_address.Tag = shop.ShopId;

            panel_addressFilter.Controls.Add(checkBox_address);
            panel_addressFilter.Location = new System.Drawing.Point(3, 50);
            panel_addressFilter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            panel_addressFilter.Name = "panel_addressFilter";
            panel_addressFilter.Padding = new System.Windows.Forms.Padding(40, 10, 30, 0);
            panel_addressFilter.Size = new System.Drawing.Size(288, 43);
            panel_addressFilter.TabIndex = 5;
            return panel_addressFilter;

        }
        private Panel GenerateCategory(Category category)
        {
            Panel panel_categoryFilter = new Panel();
            CheckBox checkBox_categoryName = new CheckBox();

            checkBox_categoryName.AutoSize = true;
            checkBox_categoryName.Dock = System.Windows.Forms.DockStyle.Top;
            checkBox_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox_categoryName.Location = new System.Drawing.Point(40, 10);
            checkBox_categoryName.Name = "checkBox_categoryName";
            checkBox_categoryName.Size = new System.Drawing.Size(218, 22);
            checkBox_categoryName.TabIndex = 1;
            checkBox_categoryName.Tag = category.CategoryId;
            checkBox_categoryName.Text = category.CategoryName;
            checkBox_categoryName.UseVisualStyleBackColor = true;
            checkBox_categoryName.CheckedChanged += CheckBox_categoryName_CheckedChanged;

            panel_categoryFilter.Controls.Add(checkBox_categoryName);
            panel_categoryFilter.Location = new System.Drawing.Point(3, 63);
            panel_categoryFilter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            panel_categoryFilter.Name = "panel_categoryFilter";
            panel_categoryFilter.Padding = new System.Windows.Forms.Padding(40, 10, 30, 0);
            panel_categoryFilter.Size = new System.Drawing.Size(288, 43);
            panel_categoryFilter.TabIndex = 0;

            return panel_categoryFilter;
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
            // If the delegate was instantiated, then call it
            if (objectExternalLink != null)
                objectExternalLink(new Product(new DLL.Product_() { ProductName = "lovecrush" }));
            else
                MessageBox.Show("Object currentProduct external null");
        }

        #endregion

























        #region Filter process

        private void CheckBox_categoryName_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<string> CategoryChecked = GetCategoryIdCheckedFilter();
            IEnumerable<Category> categories = currentCategories.Where(cate => CategoryChecked.Contains(cate.CategoryId));


            currentProducts = products.Join(categories, pro => pro.CategoryID, cate => cate.CategoryId, (pro, cate) => pro).ToArray();
            FillProduct(
                currentProducts,                
                currentShops.Join(currentProducts, shop => shop.ShopId, pro => pro.ShopID,(shop,pro) => shop).ToArray());
        }

        private IEnumerable<string> GetCategoryIdCheckedFilter()
        {
            foreach (CheckBox check in flowLayoutPanel_categoryFilterContainer.Controls.Find("checkBox_categoryName", true))
            {
                if (check.Checked)
                {
                    yield return check.Tag.ToString();
                }
            }
        }


        private void CheckBox_address_CheckedChanged(object sender, EventArgs e)
        {

            string[] AddressChecked = GetAddressCheckedFilter().ToArray();
            Shop[] shops = currentShops.Where(shop => AddressChecked.Contains(shop.Address)).ToArray();

            currentProducts = products.Join(shops, pro => pro.ShopID, shop => shop.ShopId, (pro, shop) => pro).ToArray();
            FillProduct(
            currentProducts,
            currentShops.Join(currentProducts, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());

        }

        private IEnumerable<string> GetAddressCheckedFilter()
        {
            foreach (CheckBox check in flowLayoutPanel_addressFilterContainer.Controls.Find("checkBox_address", true))
            {
                if (check.Checked)
                {
                    yield return check.Text.ToString();
                }
            }
        }


        #endregion
















        private void GenerateByCategoryPanel()
        {
            Panel panel_byCategory = new Panel();
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(23, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 29);
            label1.TabIndex = 0;
            label1.Text = "By category";
            panel_byCategory.Controls.Add(label1);
            panel_byCategory.Location = new System.Drawing.Point(3, 3);
            panel_byCategory.Name = "panel_byCategory";
            panel_byCategory.Size = new System.Drawing.Size(288, 54);
            panel_byCategory.TabIndex = 1;
            flowLayoutPanel_categoryFilterContainer.Controls.Add(panel_byCategory);

        }
        private void GenerateByAddressPanel()
        {
            Label label8 = new Label();
            Panel panel_placeOfSale = new Panel();

            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Top;
            label8.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(25, 10);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(115, 29);
            label8.TabIndex = 1;
            label8.Text = "Place of Sale";

            panel_placeOfSale.Controls.Add(label8);
            panel_placeOfSale.Location = new System.Drawing.Point(3, 3);
            panel_placeOfSale.Name = "panel_placeOfSale";
            panel_placeOfSale.Padding = new System.Windows.Forms.Padding(25, 10, 0, 0);
            panel_placeOfSale.Size = new System.Drawing.Size(288, 41);
            panel_placeOfSale.TabIndex = 1;
            flowLayoutPanel_addressFilterContainer.Controls.Add(panel_placeOfSale);
        }


        private GroupBox GenerateProduct(Product product, string address = "Address")
        {
            GroupBox groupBox_product = new GroupBox();
            Label label_product = new Label();
            PictureBox pictureBox_productImage = new PictureBox();
            IconButton iconButton_verification = new IconButton();
            Label label_sponsor = new Label();
            Label label_prouductName = new Label();
            Label label_productPrice = new Label();
            Label label_productAddress = new Label();


            Label label_colorMaker = new Label();

            label_colorMaker.AutoSize = true;
            label_colorMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_colorMaker.Location = new System.Drawing.Point(160, 413);
            label_colorMaker.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label_colorMaker.Name = "label_colorMaker";
            label_colorMaker.Size = new System.Drawing.Size(21, 20);
            label_colorMaker.TabIndex = 1;
            label_colorMaker.Text = "...";
            label_colorMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label_colorMaker.Click += new System.EventHandler(Label3_Click_1);


            label_productAddress.AutoSize = false;
            label_productAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productAddress.Location = new System.Drawing.Point(20, 413);
            label_productAddress.Name = "label_productAddress";
            label_productAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_productAddress.Size = new System.Drawing.Size(160, 20);
            label_productAddress.TabIndex = 1;
            label_productAddress.Text = address;
            label_productAddress.Click += new System.EventHandler(Label3_Click_1);

            label_productPrice.AutoSize = true;
            label_productPrice.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productPrice.ForeColor = System.Drawing.Color.LightCoral;
            label_productPrice.Location = new System.Drawing.Point(18, 378);
            label_productPrice.Name = "label_productPrice";
            label_productPrice.Size = new System.Drawing.Size(145, 35);
            label_productPrice.TabIndex = 1;
            label_productPrice.Text = "20.000.000 đ";
            label_productPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label_productPrice.Click += new System.EventHandler(Label3_Click_1);

            label_prouductName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_prouductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_prouductName.Location = new System.Drawing.Point(6, 283);
            label_prouductName.Name = "label_prouductName";
            label_prouductName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 3);
            label_prouductName.Size = new System.Drawing.Size(230, 71);
            label_prouductName.TabIndex = 1;
            label_prouductName.Text = product.ProductName;
            label_prouductName.Click += new System.EventHandler(Label3_Click_1);
            label_prouductName.BringToFront();

            for (int i = 1; i < product.RatingStar.ToInt() + 1; i++)
            {

                PictureBox pictureBox_reviewedProductStar = new PictureBox();
                pictureBox_reviewedProductStar.BackColor = System.Drawing.SystemColors.Control;
                pictureBox_reviewedProductStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_reviewedProductStar.Image")));
                pictureBox_reviewedProductStar.Location = new System.Drawing.Point(10 + i * 25, 348);
                pictureBox_reviewedProductStar.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
                pictureBox_reviewedProductStar.Name = "pictureBox_reviewedProductStar";
                pictureBox_reviewedProductStar.Size = new System.Drawing.Size(20, 20);
                pictureBox_reviewedProductStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox_reviewedProductStar.BringToFront();
                groupBox_product.Controls.Add(pictureBox_reviewedProductStar);

            }
            label_sponsor.AutoSize = true;
            label_sponsor.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_sponsor.ForeColor = System.Drawing.Color.DimGray;
            label_sponsor.Location = new System.Drawing.Point(133, 251);
            label_sponsor.Name = "label_sponsor";
            label_sponsor.Size = new System.Drawing.Size(94, 32);
            label_sponsor.TabIndex = 1;
            label_sponsor.Text = "Sponsor";
            label_sponsor.Click += new System.EventHandler(Label3_Click_1);

            iconButton_verification.AutoSize = true;
            iconButton_verification.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            iconButton_verification.FlatAppearance.BorderSize = 0;
            iconButton_verification.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            iconButton_verification.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            iconButton_verification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_verification.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton_verification.IconChar = FontAwesome.Sharp.IconChar.Certificate;
            iconButton_verification.IconColor = System.Drawing.Color.LightSkyBlue;
            iconButton_verification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_verification.IconSize = 25;
            iconButton_verification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton_verification.Location = new System.Drawing.Point(15, 248);
            iconButton_verification.Margin = new System.Windows.Forms.Padding(0);
            iconButton_verification.Name = "iconButton_verification";
            iconButton_verification.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            iconButton_verification.Size = new System.Drawing.Size(161, 42);
            iconButton_verification.TabIndex = 2;
            iconButton_verification.Text = "Verification";
            iconButton_verification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_verification.UseVisualStyleBackColor = true;
            iconButton_verification.Click += new System.EventHandler(Label3_Click_1);

            pictureBox_productImage.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox_productImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_productImage.Image")));
            pictureBox_productImage.Location = new System.Drawing.Point(15, 18);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(215, 227);
            pictureBox_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_productImage.TabIndex = 0;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.Click += Label3_Click_1;

            label_product.BackColor = System.Drawing.SystemColors.Control;
            label_product.Dock = System.Windows.Forms.DockStyle.Fill;
            label_product.Location = new System.Drawing.Point(15, 18);
            label_product.Name = "label_product";
            label_product.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            label_product.Size = new System.Drawing.Size(215, 430);
            label_product.TabIndex = 3;
            label_product.Click += new System.EventHandler(Label3_Click_1);
            label_product.SendToBack();

            groupBox_product.Controls.Add(label_prouductName);
            groupBox_product.Controls.Add(label_sponsor);
            groupBox_product.Controls.Add(iconButton_verification);
            groupBox_product.Controls.Add(label_productAddress);
            groupBox_product.Controls.Add(label_productPrice);
            groupBox_product.Controls.Add(pictureBox_productImage);
            groupBox_product.Controls.Add(label_product);
            groupBox_product.Controls.Add(label_colorMaker);
            label_colorMaker.BringToFront();
            groupBox_product.Location = new System.Drawing.Point(15, 5);
            groupBox_product.Margin = new System.Windows.Forms.Padding(5);
            groupBox_product.Name = "groupBox_product";
            groupBox_product.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            groupBox_product.Size = new System.Drawing.Size(245, 451);
            groupBox_product.TabIndex = 5;
            groupBox_product.TabStop = false;


            return groupBox_product;
        }


        private void ViewProductSearch_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_priceRangeApply_Click(object sender, EventArgs e)
        {
            if(myNumericUpDown_aboveRange.Value < myNumericUpDown_belowRange.Value)
            {
                MessageBox.Show("Invalid price range (below range must less than above range), please check again, ");
                return;
            }

            currentProducts = currentProducts.Where(pro => pro.Price.ToInt() < myNumericUpDown_aboveRange.Value && pro.Price.ToInt() > myNumericUpDown_belowRange.Value).ToArray();
            FillProduct(currentProducts,currentShops.Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());

        }

        private void RadioButton_priceAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_priceAscending.Checked)
            {
                currentProducts = currentProducts.OrderBy(pro => pro.Price).ToArray();
                FillProduct(currentProducts, currentShops.Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());

            }
        }

        private void RadioButton_priceDescend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_priceDescend.Checked)
            {
                currentProducts = currentProducts.OrderByDescending(pro => pro.Price).ToArray();
                FillProduct(currentProducts, currentShops.Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());
            }

        }

        private void CheckBox_fiveStar_CheckedChanged_1(object sender, EventArgs e)
        {
            
            CheckBox checker  = (CheckBox)sender;
            if (!checker.Checked)
            {
                return;
            }
            foreach (CheckBox check in panel_raiting.Controls.OfType<CheckBox>())
            {
                check.Checked = false;
            }
            checker.Checked = true;

            int starExpected = checker.Text.Split('_').Last().ToInt();
            currentProducts = currentProducts.Where(pro => pro.RatingStar.ToInt() >= starExpected).ToArray();
            FillProduct(currentProducts, currentShops.Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());

        }

        private void RjButton_deleteAllFilter_Click(object sender, EventArgs e)
        {
            FillProduct(products, currentShops.Join(products, shop => shop.ShopId, pro => pro.ShopID, (shop, pro) => shop).ToArray());


            foreach (CheckBox check in panel_raiting.Controls.OfType<CheckBox>())
            {
                check.Checked = false;
            }
            radioButton_priceAscending.Checked = false;
            radioButton_priceDescend.Checked = false;

            myNumericUpDown_aboveRange.Value = 0;
            myNumericUpDown_belowRange.Value = 0;
            foreach(CheckBox check in flowLayoutPanel_categoryFilterContainer.Controls.Find("checkBox_categoryName", true))
            {
                check.Checked= false;
            }
            foreach (CheckBox check in flowLayoutPanel_addressFilterContainer.Controls.Find("checkBox_address", true))
            {
                check.Checked = false;


            }

            //có 1 chút sai sót phần filter, nên filter tất cả 1 lượt luôn thì sẽ đạt được hiệu húng hoàn chỉnh, còn cái này not completed
            //mỗi lần lại gán mệt lắm

        }
    }
}

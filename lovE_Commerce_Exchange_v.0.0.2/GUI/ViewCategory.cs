using BUS;
using CustomControls.RJControls;
using FontAwesome.Sharp;
using GUI.CustomControl;
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

namespace GUI
{
    public partial class ViewCategory : Form
    {
        Category[] categories;
        //Category category;
        Product[] products;
        ComponentResourceManager resources = new ComponentResourceManager(typeof(SubViewShopProducts));


        public ViewCategory()
        {
            InitializeComponent();
            InitializeDatset();


        }
        private void InitializeDatset()
        {
            products = Product.GetProducts();
            categories = Category.GetCategories();

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

        public void SetExternalObject(Category category)
        {
            ResetSubCategoryNavigator();
            IconButton_subCategorySample_Click(category, null);
        }

        private void FilterCategory(string categoryID, string categoryName)
        {
            //find all child and nephew
            Category[] SonAndNephewCategories = FindAllChildAndNephew(categoryID).ToArray();
            if (SonAndNephewCategories.Count() == 0)
            {
                MessageBox.Show("Can not find any sub cateogory, you're in the last one!");
                return;
            }
            AddSubCategory(categoryID, categoryName);
            FillCategory(SonAndNephewCategories);
            //filter all product belongs to these categories.
            FillProductByCategory(products.Join(SonAndNephewCategories,                                   
                                                pro => pro.CategoryID,
                                                cate => cate.CategoryId,
                                                (pro, cate) => pro).ToArray());

        }
        private void FillProductByCategory(Product[] products)
        {
            flowLayoutPanel_productsContainer.Controls.Clear();
            foreach (Product product in products)
            {
                flowLayoutPanel_productsContainer.Controls.Add(GenerateProduct(product));
            }
        }
        /// <summary>
        ///find all category and return a sequcence of category by using IEnumerable an yeild return,
        ///which cannot be done with basic syntax and algorithms , using linQ, IEnumberable, Recursion
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        private IEnumerable<Category> FindAllChildAndNephew(string categoryID)
        {
            IEnumerable<Category> categories = FindChildCategory(categoryID);
            if (categories.Count() > 0)
            {
                foreach(Category category in categories)
                {
                    FindAllChildAndNephew(category.CategoryId);
                    yield return category;
                }
            }                    

        }

        private GroupBox GenerateProduct(Product product)
        {
            GroupBox groupBox_product = new GroupBox();
            Label label_product = new Label();
            PictureBox pictureBox_productImage = new PictureBox();
            IconButton iconButton_verification = new IconButton();
            Label label_sponsor = new Label();
            Label label_prouductName = new Label();
            Label label_productPrice = new Label();
            Label label_productAddress = new Label();




            label_productAddress.AutoSize = true;
            label_productAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productAddress.Location = new System.Drawing.Point(20, 413);
            label_productAddress.Name = "label_productAddress";
            label_productAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label_productAddress.Size = new System.Drawing.Size(90, 20);
            label_productAddress.TabIndex = 1;
            label_productAddress.Text = "Nha Trang";
            label_productAddress.Click += new System.EventHandler(Label3_Click_1);
            label_product.Tag = product;

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
            label_productPrice.Tag = product;


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
            label_prouductName.Tag = product;

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
            label_sponsor.Tag = product;


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
            iconButton_verification.Tag = product;
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
            pictureBox_productImage.Tag = product;
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
            label_product.Tag = product;


            groupBox_product.Controls.Add(label_prouductName);
            groupBox_product.Controls.Add(label_sponsor);
            groupBox_product.Controls.Add(iconButton_verification);
            groupBox_product.Controls.Add(label_productAddress);
            groupBox_product.Controls.Add(label_productPrice);
            groupBox_product.Controls.Add(pictureBox_productImage);
            groupBox_product.Controls.Add(label_product);
            groupBox_product.Location = new System.Drawing.Point(15, 5);
            groupBox_product.Margin = new System.Windows.Forms.Padding(5);
            groupBox_product.Name = "groupBox_product";
            groupBox_product.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            groupBox_product.Size = new System.Drawing.Size(245, 451);
            groupBox_product.TabIndex = 5;
            groupBox_product.TabStop = false;


            return groupBox_product;
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
            // If the delegate was instantiated, then call it
            if (objectExternalLink != null)
                objectExternalLink((Product)(sender as Control).Tag);
            else
                MessageBox.Show("Object currentProduct external null");

        }


        private void FillCategory(Category[] categories)
        {
            flowLayoutPanel_subCategories.Controls.Clear();
            flowLayoutPanel_subCategories.Controls.Add(SubCategoryPanel());
            foreach (Category cate in categories)
            {
                flowLayoutPanel_subCategories.Controls.Add(GenerateCategory(cate));

            }
        }


        private IEnumerable<Category> FindChildCategory(string dadID)
        {
            return categories.Where(childCategory => childCategory.AncestorId == dadID);
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            //gradientLabel_subcategoryVisualize.Text = "Home page >";
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Product(new DLL.Product_()));
        }

        private void IconButton_subCategorySample_Click(object sender, EventArgs e)
        {
            if(sender is Category)
            {
                FilterCategory((sender as Category).CategoryId, (sender as Category).CategoryName);
            }
            else
            {
                FilterCategory((sender as Button).Tag.ToString(), (sender as Button).Text);
            }
        }














        private void RjButton_homePageAhead_Click(object sender, EventArgs e)
        {
            //just using ShopingCart to navigated home page
            objectExternalLink(new ShoppingCart( new DLL.ShoppingCart_()));
        }
        private void RjButton_homePageAhead_Click1(object sender, EventArgs e)
        {
            //MessageBox.Show("Oke boys, let's navigated this page");
            //if((sender as Button).Text == category)
            IconButton_subCategorySample_Click(sender, null);
            RemoveSubcategory((sender as Button).Text, false, 0);

        }
        private  void AddSubCategory(string Categoryid, string categoryName)
        {
            RJButton rjButton_homePageAhead = new RJButton();

            rjButton_homePageAhead.AutoSize = true;
            rjButton_homePageAhead.BackColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_homePageAhead.BorderRadius = 10;
            rjButton_homePageAhead.BorderSize = 0;
            rjButton_homePageAhead.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.FlatAppearance.BorderSize = 0;
            rjButton_homePageAhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_homePageAhead.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.GraphicsUnit.Point);
            rjButton_homePageAhead.ForeColor = System.Drawing.Color.DodgerBlue;
            rjButton_homePageAhead.Location = new System.Drawing.Point(5, 0);
            rjButton_homePageAhead.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            rjButton_homePageAhead.Name = "rjButton_homePageAhead";
            rjButton_homePageAhead.Size = new System.Drawing.Size(128, 31);
            rjButton_homePageAhead.TabIndex = 13;
            rjButton_homePageAhead.Text = categoryName;
            rjButton_homePageAhead.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_homePageAhead.UseVisualStyleBackColor = false;
            rjButton_homePageAhead.Tag = Categoryid;
            rjButton_homePageAhead.Click += RjButton_homePageAhead_Click1;

            Label label_subCategorySeparator = new Label();
            label_subCategorySeparator.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_subCategorySeparator.ForeColor = System.Drawing.Color.MediumSlateBlue;
            label_subCategorySeparator.Location = new System.Drawing.Point(133, 0);
            label_subCategorySeparator.Margin = new System.Windows.Forms.Padding(0);
            label_subCategorySeparator.Name = "label_subCategorySeparator";
            label_subCategorySeparator.Size = new System.Drawing.Size(29, 29);
            label_subCategorySeparator.TabIndex = 14;
            label_subCategorySeparator.Text = ">";
            label_subCategorySeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            flowLayoutPanel_subCategoryNav.Controls.AddRange( new Control[] {  label_subCategorySeparator,rjButton_homePageAhead});
        }

      
        private void ResetSubCategoryNavigator()
        {
            RJButton rjButton_homePageAhead = new RJButton();

            rjButton_homePageAhead.AutoSize = true;
            rjButton_homePageAhead.BackColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_homePageAhead.BorderRadius = 10;
            rjButton_homePageAhead.BorderSize = 0;
            rjButton_homePageAhead.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            rjButton_homePageAhead.FlatAppearance.BorderSize = 0;
            rjButton_homePageAhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_homePageAhead.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_homePageAhead.ForeColor = System.Drawing.Color.DodgerBlue;
            rjButton_homePageAhead.Location = new System.Drawing.Point(5, 0);
            rjButton_homePageAhead.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            rjButton_homePageAhead.Name = "rjButton_homePageAhead";
            rjButton_homePageAhead.Size = new System.Drawing.Size(128, 31);
            rjButton_homePageAhead.TabIndex = 13;
            rjButton_homePageAhead.Text = "Home page";
            rjButton_homePageAhead.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_homePageAhead.UseVisualStyleBackColor = false;
            rjButton_homePageAhead.Click += RjButton_homePageAhead_Click;

            flowLayoutPanel_subCategoryNav.Controls.Clear();
            flowLayoutPanel_subCategoryNav.Controls.Add(rjButton_homePageAhead);

        }

        /// <summary>
        /// a superpower resursive algorithm help to remove all the category after the one was clicked;
        ///fantastic right, little headache; 
        ///and it really work properly, no joke but in a project just have three category at maximum
        ///little wasted potential
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="removable"></param>
        /// <param name="index"></param>
        private void RemoveSubcategory(string categoryName, bool removable, int index)
        {
            int i = 0;
            foreach(Control contr in flowLayoutPanel_subCategoryNav.Controls)
            {
                i++;
            }
            if(i == index)
            {
                return;
            }

            Control control = flowLayoutPanel_subCategoryNav.Controls[index];

            if (!removable && (control is RJButton) && control.Text == categoryName)
            {
                RemoveSubcategory(categoryName, true,++index);
            }
            else if(removable)
            {
                RemoveSubcategory("bye bye", true, ++index);
                control.Dispose();
            }
            else
            {
                RemoveSubcategory(categoryName, removable, ++index);
            }

        }







        private Control SubCategoryPanel()
        {
            Panel panel_subCategory = new Panel();
            GradientLabel gradientLabel_subCategory = new GradientLabel();

            gradientLabel_subCategory.AutoSize = true;
            gradientLabel_subCategory.BackColor = System.Drawing.SystemColors.Control;
            gradientLabel_subCategory.BeginColor = System.Drawing.SystemColors.Control;
            gradientLabel_subCategory.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            gradientLabel_subCategory.Dock = System.Windows.Forms.DockStyle.Left;
            gradientLabel_subCategory.EndColor = System.Drawing.SystemColors.Control;
            gradientLabel_subCategory.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradientLabel_subCategory.Location = new System.Drawing.Point(0, 0);
            gradientLabel_subCategory.Name = "gradientLabel_subCategory";
            gradientLabel_subCategory.Size = new System.Drawing.Size(244, 54);
            gradientLabel_subCategory.TabIndex = 1;
            gradientLabel_subCategory.Text = "SubCategoryPanel";
            gradientLabel_subCategory.TextColorBegin = System.Drawing.Color.Orchid;
            gradientLabel_subCategory.TextColorEnd = System.Drawing.Color.MediumSlateBlue;

            panel_subCategory.BackColor = System.Drawing.SystemColors.Control;
            panel_subCategory.Controls.Add(gradientLabel_subCategory);
            panel_subCategory.Dock = System.Windows.Forms.DockStyle.Top;
            panel_subCategory.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel_subCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            panel_subCategory.Location = new System.Drawing.Point(3, 3);
            panel_subCategory.Name = "panel_subCategory";
            panel_subCategory.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            panel_subCategory.Size = new System.Drawing.Size(320, 60);
            panel_subCategory.TabIndex = 1;

            return panel_subCategory;
        }

        private IconButton GenerateCategory(Category category)
        {
            IconButton iconButton_category_sample = new FontAwesome.Sharp.IconButton();
            iconButton_category_sample.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton_category_sample.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            iconButton_category_sample.FlatAppearance.BorderSize = 0;
            iconButton_category_sample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton_category_sample.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton_category_sample.Font = new System.Drawing.Font("Montserrat", 10F);
            iconButton_category_sample.ForeColor = System.Drawing.SystemColors.WindowText;
            iconButton_category_sample.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton_category_sample.IconColor = System.Drawing.Color.IndianRed;
            iconButton_category_sample.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_category_sample.IconSize = 40;
            iconButton_category_sample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton_category_sample.Location = new System.Drawing.Point(3, 69);
            iconButton_category_sample.Name = "iconButton_category_sample";
            iconButton_category_sample.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            iconButton_category_sample.Size = new System.Drawing.Size(320, 60);
            iconButton_category_sample.TabIndex = 0;
            iconButton_category_sample.Text = category.CategoryName;
            iconButton_category_sample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton_category_sample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_category_sample.UseVisualStyleBackColor = true;
            iconButton_category_sample.Click += IconButton_subCategorySample_Click;
            iconButton_category_sample.Tag = category.CategoryId;
            return iconButton_category_sample;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using FontAwesome.Sharp;
using GUI.CustomControl;
using GUI.Properties;

namespace GUI
{
    public partial class ViewHomePage : Form
    {
        Category[] categories;
        Product[] products;
        Shop[] shops;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubViewShopProducts));


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

        public ViewHomePage()
        {
            InitializeComponent();

            LoadedEverything();
        }
        public void LoadedEverything()
        {

            InititalizeDatssets();
            FillCategories();
            FillLastestProducts(products.OrderBy(pro => DateTime.Parse(pro.CreatedDate.Split(' ')[0].Replace("/", "-").Trim())).ToArray());
        }
        private void InititalizeDatssets()
        {
            categories = Category.GetCategories();
            products = Product.GetProducts().Where(pro => pro.ReviewState).ToArray();
            shops = Shop.GetShops();
        }

        private void FillCategories()
        {
            flowLayoutPanel_categories.Controls.Clear();
            flowLayoutPanel_categories.Controls.Add(CategoryPanel());

            foreach (Category category in categories)
            {
                if (category.AncestorId  == "0")
                {
                    flowLayoutPanel_categories.Controls.Add(GenerateCategory(category));
                }
            }
            iconButton_category_sample.Dispose();

        }
        private Control CategoryPanel()
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
            gradientLabel_subCategory.Text = "Category";
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

        private void FillLastestProducts(Product[] products)
        {
            flowLayoutPanel_allFather.Controls.Clear();
            IEnumerable<Shop> shop = products.Join(shops, pro => pro.ShopID, sh => sh.ShopId,(pro, sh) => sh);
            foreach (var Tuple in products.Zip(shop, Tuple.Create))
            {
                flowLayoutPanel_allFather.Controls.Add(GenerateProduct(Tuple.Item1, Tuple.Item2.Address));
            }
        }

        private GroupBox GenerateProduct(Product product,string address)
        {
            GroupBox groupBox_product = new GroupBox();
            Label label_product = new Label();
            PictureBox pictureBox_productImage = new PictureBox();
            IconButton iconButton_verification = new IconButton();
            Label label_sponsor = new Label();
            Label label_prouductName = new Label();
            Label label_productPrice= new Label();
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
            label_colorMaker.Tag = product;


            label_productAddress.AutoSize = false;
            label_productAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productAddress.Location = new System.Drawing.Point(20, 413);
            label_productAddress.Name = "label_productAddress";
            label_productAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_productAddress.Size = new System.Drawing.Size(160, 20);
            label_productAddress.TabIndex = 1;
            label_productAddress.Text = address;
            label_productAddress.Click += new System.EventHandler(Label3_Click_1);
            label_productAddress.Tag = product;

            label_productPrice.AutoSize = true;
            label_productPrice.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productPrice.ForeColor = System.Drawing.Color.LightCoral;
            label_productPrice.Location = new System.Drawing.Point(18, 378);
            label_productPrice.Name = "label_productPrice";
            label_productPrice.Size = new System.Drawing.Size(145, 35);
            label_productPrice.TabIndex = 1;
            label_productPrice.Text = $"{product.Price} đ";
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
            iconButton_verification.Text = "Verification";
            iconButton_verification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton_verification.UseVisualStyleBackColor = true;
            iconButton_verification.Click += new System.EventHandler(Label3_Click_1);
            iconButton_verification.Tag = product;

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
            pictureBox_productImage.Tag = product;

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
      
        private void Label3_Click_1(object sender, EventArgs e)
        {
            // If the delegate was instantiated, then call it
            if (objectExternalLink != null)
                objectExternalLink((Entity)(sender as Control).Tag);
            else
                MessageBox.Show("Object currentProduct external null");

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (objectExternalLink != null)
                objectExternalLink((Entity)(sender as IconButton).Tag);
            else
                MessageBox.Show("Object currentProduct external null");

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
            iconButton_category_sample.Click += IconButton1_Click;
            iconButton_category_sample.Tag = category;
            return iconButton_category_sample;
        }




























        //Code for drag form using panel not controlbox
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }                                                
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel_cotrol_MouseDown(object sender, MouseEventArgs e)
        {
            //code for drag form
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void FlowLayoutPanel_category_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox3_MouseHover(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel_allFather_SizeChanged(object sender, EventArgs e)
        {
            //foreach (Panel panel in flowLayoutPanel_allFather.Controls)
            //{
            //    if (panel != null && panel is Panel)
            //    {
            //        panel.Width = flowLayoutPanel_allFather.Width - 30;
            //    }
            //}
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }

  
   
}

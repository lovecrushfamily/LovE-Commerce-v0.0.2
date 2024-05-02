using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CustomControls.RJControls;

namespace GUI
{
    public partial class SubViewStaffProduct : Form
    {
        Product[] products;
        Category[] categories;
        public SubViewStaffProduct()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            InitialzeDataset();
            IconButton_waitingProducts_Click(null,null);

        }
        private void InitialzeDataset()
        {
            products = Product.GetProducts();
            categories = Category.GetCategories();
        }

        private void ComboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void RjButton_verifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void IconButton_waitingProducts_Click(object sender, EventArgs e)
        {
            tabControl_products.SelectedTab = tabPage_waitingProducts;
            FillWaitingProduct();
        }

        private void IconButton_verifiedProduct_Click(object sender, EventArgs e)
        {
            tabControl_products.SelectedTab = tabPage_verifyProduct;
        }

        private void IconButton_bannedProduct_Click(object sender, EventArgs e)
        {
            tabControl_products.SelectedTab = tabPage_bannedProduct;
        }



        private void FillWaitingProduct()
        {
            foreach(Panel control in tabPage_waitingProducts.Controls.OfType<Panel>())
            {
                control.RecursivelyDispose();
            }
            foreach(Product product in products.Where(pro => !pro.ReviewState))
            {
                tabPage_waitingProducts.Controls.Add(GenerateWaitingProduct(product));
            }
        }









        private Panel GenerateWaitingProduct(Product product)
        {
            Panel panel_waitingProduct = new Panel();
            RJButton rjButton_waitingProductBorder = new RJButton();
            Panel panel_waitingPruductControlHolder = new Panel();
            CheckBox checkBox_waitingProductCheck = new CheckBox();
            PictureBox pictureBox_waitingProductImage= new PictureBox();
            Label label_waitingProductName = new Label();
            Label label_waitingDateCreatedProduct= new Label();
            RJButton rjButton_verifyWaitingProduct = new RJButton();
            RJButton rjButton_waitingProductDetail = new RJButton();

            rjButton_waitingProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            rjButton_waitingProductDetail.BackColor = System.Drawing.SystemColors.ControlLight;
            rjButton_waitingProductDetail.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            rjButton_waitingProductDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_waitingProductDetail.BorderRadius = 15;
            rjButton_waitingProductDetail.BorderSize = 0;
            rjButton_waitingProductDetail.FlatAppearance.BorderSize = 0;
            rjButton_waitingProductDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_waitingProductDetail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_waitingProductDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_waitingProductDetail.Location = new System.Drawing.Point(798, 37);
            rjButton_waitingProductDetail.Name = "rjButton_waitingProductDetail";
            rjButton_waitingProductDetail.Size = new System.Drawing.Size(130, 38);
            rjButton_waitingProductDetail.TabIndex = 3;
            rjButton_waitingProductDetail.Text = "Detail";
            rjButton_waitingProductDetail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_waitingProductDetail.UseVisualStyleBackColor = false;
            rjButton_waitingProductDetail.Click += RjButton_waitingProductDetail_Click;
            rjButton_waitingProductDetail.Tag = product.ProductId;

            rjButton_verifyWaitingProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            rjButton_verifyWaitingProduct.BackColor = System.Drawing.Color.DodgerBlue;
            rjButton_verifyWaitingProduct.BackgroundColor = System.Drawing.Color.DodgerBlue;
            rjButton_verifyWaitingProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_verifyWaitingProduct.BorderRadius = 15;
            rjButton_verifyWaitingProduct.BorderSize = 0;
            rjButton_verifyWaitingProduct.FlatAppearance.BorderSize = 0;
            rjButton_verifyWaitingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_verifyWaitingProduct.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_verifyWaitingProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_verifyWaitingProduct.Location = new System.Drawing.Point(662, 37);
            rjButton_verifyWaitingProduct.Name = "rjButton_verifyWaitingProduct";
            rjButton_verifyWaitingProduct.Size = new System.Drawing.Size(130, 38);
            rjButton_verifyWaitingProduct.TabIndex = 39;
            rjButton_verifyWaitingProduct.Text = "Verify";
            rjButton_verifyWaitingProduct.TextColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_verifyWaitingProduct.UseVisualStyleBackColor = false;
            rjButton_verifyWaitingProduct.Click += RjButton_verifyWaitingProduct_Click;
            rjButton_verifyWaitingProduct.Tag = product.ProductId;

            label_waitingDateCreatedProduct.AutoSize = true;
            label_waitingDateCreatedProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_waitingDateCreatedProduct.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_waitingDateCreatedProduct.Location = new System.Drawing.Point(116, 44);
            label_waitingDateCreatedProduct.Name = "label_waitingDateCreatedProduct";
            label_waitingDateCreatedProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_waitingDateCreatedProduct.Size = new System.Drawing.Size(92, 17);
            label_waitingDateCreatedProduct.TabIndex = 2;
            label_waitingDateCreatedProduct.Text = product.CreatedDate;

            label_waitingProductName.AutoSize = true;
            label_waitingProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_waitingProductName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_waitingProductName.Location = new System.Drawing.Point(115, 15);
            label_waitingProductName.Name = "label_waitingProductName";
            label_waitingProductName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_waitingProductName.Size = new System.Drawing.Size(90, 21);
            label_waitingProductName.TabIndex = 2;
            label_waitingProductName.Text = product.ProductName;

            pictureBox_waitingProductImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_waitingProductImage.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox_waitingProductImage.Location = new System.Drawing.Point(33, 15);
            pictureBox_waitingProductImage.Name = "pictureBox_waitingProductImage";
            pictureBox_waitingProductImage.Size = new System.Drawing.Size(76, 76);
            pictureBox_waitingProductImage.TabIndex = 1;
            pictureBox_waitingProductImage.TabStop = false;
            pictureBox_waitingProductImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_waitingProductImage.SizeMode = PictureBoxSizeMode.Zoom;

            checkBox_waitingProductCheck.AutoSize = true;
            checkBox_waitingProductCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox_waitingProductCheck.Dock = System.Windows.Forms.DockStyle.Left;
            checkBox_waitingProductCheck.Location = new System.Drawing.Point(0, 15);
            checkBox_waitingProductCheck.Name = "checkBox_waitingProductCheck";
            checkBox_waitingProductCheck.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            checkBox_waitingProductCheck.Size = new System.Drawing.Size(33, 76);
            checkBox_waitingProductCheck.TabIndex = 40;
            checkBox_waitingProductCheck.UseVisualStyleBackColor = false;

            panel_waitingPruductControlHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))));
            panel_waitingPruductControlHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_waitingPruductControlHolder.Controls.Add(rjButton_waitingProductDetail);
            panel_waitingPruductControlHolder.Controls.Add(rjButton_verifyWaitingProduct);
            panel_waitingPruductControlHolder.Controls.Add(pictureBox_waitingProductImage);
            panel_waitingPruductControlHolder.Controls.Add(checkBox_waitingProductCheck);
            panel_waitingPruductControlHolder.Controls.Add(label_waitingDateCreatedProduct);
            panel_waitingPruductControlHolder.Controls.Add(label_waitingProductName);
            panel_waitingPruductControlHolder.Location = new System.Drawing.Point(14, 3);
            panel_waitingPruductControlHolder.Name = "panel_waitingPruductControlHolder";
            panel_waitingPruductControlHolder.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            panel_waitingPruductControlHolder.Size = new System.Drawing.Size(954, 106);
            panel_waitingPruductControlHolder.TabIndex = 41;

            rjButton_waitingProductBorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_waitingProductBorder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_waitingProductBorder.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_waitingProductBorder.BorderRadius = 15;
            rjButton_waitingProductBorder.BorderSize = 0;
            rjButton_waitingProductBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_waitingProductBorder.Enabled = false;
            rjButton_waitingProductBorder.FlatAppearance.BorderSize = 0;
            rjButton_waitingProductBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_waitingProductBorder.ForeColor = System.Drawing.Color.White;
            rjButton_waitingProductBorder.Location = new System.Drawing.Point(0, 0);
            rjButton_waitingProductBorder.Name = "rjButton_waitingProductBorder";
            rjButton_waitingProductBorder.Size = new System.Drawing.Size(971, 112);
            rjButton_waitingProductBorder.TabIndex = 0;
            rjButton_waitingProductBorder.TextColor = System.Drawing.Color.White;
            rjButton_waitingProductBorder.UseVisualStyleBackColor = false;

            panel_waitingProduct.Controls.Add(panel_waitingPruductControlHolder);
            panel_waitingProduct.Controls.Add(rjButton_waitingProductBorder);
            panel_waitingProduct.Dock = System.Windows.Forms.DockStyle.Top;
            panel_waitingProduct.Location = new System.Drawing.Point(10, 90);
            panel_waitingProduct.Name = "panel_waitingProduct";
            panel_waitingProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panel_waitingProduct.Size = new System.Drawing.Size(971, 117);
            panel_waitingProduct.TabIndex = 0;

            return panel_waitingProduct;
        }

        private void RjButton_waitingProductDetail_Click(object sender, EventArgs e)
        {
            FillProductDetail(products.SingleOrDefault(pro => pro.ProductId == (sender as RJButton).Tag.ToString()));
            tabControl_products.SelectedTab = tabPage_productDetail;
        }

        private void FillProductDetail(Product product)
        {

            rjTextBox_productName.Texts = product.ProductName;
            rjTextBox_productQuantity.Texts = product.Quantity.ToString();
            rjTextBox_productPrice.Texts = product.Price.ToString();
            rjTextBox_date.Texts = product.CreatedDate;
            rjTextBox_description.Texts = product.Description;

            rjTextBox_productName.Texts = product.ProductName;
            rjTextBox_productName.Tag = product.ProductId;
            rjTextBox_productQuantity.Texts = product.Quantity.ToString();
            rjTextBox_productPrice.Texts = product.Price.ToString();
            rjTextBox_date.Texts = product.CreatedDate;
            rjTextBox_description.Texts = product.Description;

            rjTextBox_categoryName.Tag = product.CategoryID;
            rjTextBox_categoryName.Texts = categories.Single(ca => ca.CategoryId == product.CategoryID).CategoryName;
            FillCategoryAttribute(categories.SingleOrDefault(cate => cate.CategoryId == product.CategoryID),product);



            ClearOldProductImage();
            pictureBox_mainImage.Image = null;
            pictureBox_mainImage.Tag = null;
            //when using local sever storing technique
            if (product.MainImage.Split(' ').Cast<byte>() is byte[])
            {
                pictureBox_mainImage.Image = ImageConverter.ConvertByteToImage(product.MainImage);
                int i2 = 0;
                foreach (string ExtraImage in product.ExtraImageList)
                {
                    (panel_productImageHolder.Controls[i2++] as PictureBox).Image = ImageConverter.ConvertByteToImage(ExtraImage);
                }
                return;
            }

            //when using local machine file path storing technique
            pictureBox_mainImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_mainImage.Tag = product.MainImage;
            (panel_productImageHolder.Controls[0] as PictureBox).Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            (panel_productImageHolder.Controls[0] as PictureBox).Tag = product.MainImage;


            int i = 1;
            foreach (string ExtraImage in product.ExtraImageList)
            {
                (panel_productImageHolder.Controls[i] as PictureBox).Image = ExtraImage.GetProductImagePath().TurnToProductImage();
                (panel_productImageHolder.Controls[i] as PictureBox).Tag = ExtraImage;
                i++;
            }

        }
        private void ClearOldProductImage()
        {

            foreach (PictureBox pictureBox in panel_productImageHolder.Controls)
            {
                pictureBox.Image = null;
                pictureBox.Tag = null;
                pictureBox.ImageLocation = null;
            }
        }
        private void FillCategoryAttribute(Category category, Product product)
        {

            rjTextBox_categoryName.Tag = category.CategoryId;
            rjTextBox_categoryName.Name = category.CategoryName;
            panel_attributesHolder.Controls.Clear();
            foreach (var tupleAttributeNameValue in product.AttributeList.Zip(category.AttributeList.Split(','), Tuple.Create))
            {
                panel_attributesHolder.Controls.Add(GenerateCateogoryAttribute(tupleAttributeNameValue.Item2, tupleAttributeNameValue.Item1));
            }

        }

        private Panel GenerateCateogoryAttribute(string AttributeName, string AttributeValue)
        {
            Panel panel_attribute = new Panel();
            Label label_attributeName = new Label();
            RJTextBox rjTextBox_attriibuteValue = new RJTextBox();
            RJButton rjButton5 = new RJButton();

            label_attributeName.AutoSize = true;
            label_attributeName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_attributeName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_attributeName.Location = new System.Drawing.Point(10, 12);
            label_attributeName.Name = "label_attributeName";
            label_attributeName.Size = new System.Drawing.Size(89, 21);
            label_attributeName.TabIndex = 2;
            label_attributeName.Text = AttributeName;

            rjTextBox_attriibuteValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            rjTextBox_attriibuteValue.BackColor = System.Drawing.SystemColors.Window;
            rjTextBox_attriibuteValue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            rjTextBox_attriibuteValue.BorderFocusColor = System.Drawing.Color.HotPink;
            rjTextBox_attriibuteValue.BorderRadius = 10;
            rjTextBox_attriibuteValue.BorderSize = 1;
            rjTextBox_attriibuteValue.Font = new System.Drawing.Font("Tahoma", 10F);
            rjTextBox_attriibuteValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjTextBox_attriibuteValue.Location = new System.Drawing.Point(140, 6);
            rjTextBox_attriibuteValue.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            rjTextBox_attriibuteValue.Multiline = false;
            rjTextBox_attriibuteValue.Name = "rjTextBox_attriibuteValue";
            rjTextBox_attriibuteValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            rjTextBox_attriibuteValue.PasswordChar = false;
            rjTextBox_attriibuteValue.PlaceholderColor = System.Drawing.Color.DarkGray;
            rjTextBox_attriibuteValue.PlaceholderText = "";
            rjTextBox_attriibuteValue.Size = new System.Drawing.Size(171, 36);
            rjTextBox_attriibuteValue.TabIndex = 1;
            rjTextBox_attriibuteValue.Texts = AttributeValue;
            rjTextBox_attriibuteValue.UnderlinedStyle = false;

            rjButton5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton5.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 0;
            rjButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton5.Enabled = false;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton5.ForeColor = System.Drawing.Color.White;
            rjButton5.Location = new System.Drawing.Point(3, 0);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new System.Drawing.Size(336, 48);
            rjButton5.TabIndex = 0;
            rjButton5.TextColor = System.Drawing.Color.White;
            rjButton5.UseVisualStyleBackColor = false;

            panel_attribute.Controls.Add(label_attributeName);
            panel_attribute.Controls.Add(rjTextBox_attriibuteValue);
            panel_attribute.Controls.Add(rjButton5);
            panel_attribute.Dock = System.Windows.Forms.DockStyle.Top;
            panel_attribute.Location = new System.Drawing.Point(0, 0);
            panel_attribute.Name = "panel_attribute";
            panel_attribute.Padding = new System.Windows.Forms.Padding(3, 0, 3, 5);
            panel_attribute.Size = new System.Drawing.Size(342, 53);
            panel_attribute.TabIndex = 0;

            return panel_attribute;
        }

        private void RjButton_verifyWaitingProduct_Click(object sender, EventArgs e)
        {
            products.SingleOrDefault(pro => pro.ProductId == (sender as RJButton).Tag.ToString()).Verify();
            InitialzeDataset();
            FillWaitingProduct();
            if(e != null)
            {
                MessageBox.Show("Verify sucessfully!");

            }
        }
        private void CheckBox_allProducts_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void SubViewStaffProduct_Load(object sender, EventArgs e)
        {

        }

        private void RjButton11_Click(object sender, EventArgs e)
        {

        }

        private void RjButton7_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in panel_productImageHolder.Controls)
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            PictureBox picture = (PictureBox)sender;
            picture.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_mainImage.Image = picture.Image;
            picture.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_verifyAll_Click(object sender, EventArgs e)
        {
            foreach (RJButton rJButton in tabPage_waitingProducts.Controls.Find("rjButton_verifyWaitingProduct", true))
            {
                RjButton_verifyWaitingProduct_Click(rJButton, null);
            }
            InitialzeDataset();
            FillWaitingProduct();
            MessageBox.Show("Good choice man, I made it for you right!");
        }
    }
}
                                
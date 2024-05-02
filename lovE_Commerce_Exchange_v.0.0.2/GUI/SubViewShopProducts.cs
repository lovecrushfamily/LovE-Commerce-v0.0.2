using BUS;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



// sẽ không có nút gì ở dây cả, và các thao tác verify sẽ trigger bằng cách thoát.
namespace GUI
{
    public partial class SubViewShopProducts : Form
    {

        Product[] products;
        Shop shop;
        Category[] categories;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubViewShopProducts));
        public SubViewShopProducts(Shop shop)
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            this.shop = shop;
            InitializeDataset();

        }
        private void InitializeDataset()
        {
            products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();
            categories = Category.GetCategories();
            //shop = 
        }


        private void SetCurrentProduct(Product product)
        {
            currentProduct = null;
            categoryUpdatable = false;
            currentProduct = products.Single(pro => pro.ProductId == product.ProductId);
            rjTextBox_productName.Texts = currentProduct.ProductName;
            rjTextBox_productName.Tag = product.ProductId;
            rjTextBox_productQuantity.Texts = currentProduct.Quantity.ToString();
            rjTextBox_productPrice.Texts = currentProduct.Price.ToString();
            rjTextBox_date.Texts = currentProduct.CreatedDate;
            rjTextBox_description.Texts = currentProduct.Description;

            rjTextBox_categoryName.Tag = currentProduct.CategoryID;
            rjTextBox_categoryName.Texts = categories.Single(ca => ca.CategoryId == currentProduct.CategoryID).CategoryName;
            FillCategoryAttribute(categories.SingleOrDefault(cate => cate.CategoryId == currentProduct.CategoryID));



            ClearOldProductImage();
            pictureBox_mainImage.Image = null;
            pictureBox_mainImage.Tag = null;
            //when using local sever storing technique
            if (currentProduct.MainImage.Split(' ').Cast<byte>() is byte[])
            {
                pictureBox_mainImage.Image = ImageConverter.ConvertByteToImage(currentProduct.MainImage);
                int i2 = 0;
                foreach (string ExtraImage in currentProduct.ExtraImageList)
                {
                    (panel_productImageHolder.Controls[i2++] as PictureBox).Image = ImageConverter.ConvertByteToImage(ExtraImage);
                }
                return;
            }

            //when using local machine file path storing technique
            pictureBox_mainImage.Image = currentProduct.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_mainImage.Tag = currentProduct.MainImage;
            (panel_productImageHolder.Controls[0] as PictureBox).Image = currentProduct.MainImage.GetProductImagePath().TurnToProductImage();
            (panel_productImageHolder.Controls[0] as PictureBox).Tag = currentProduct.MainImage;


            int i = 1;
            foreach (string ExtraImage in currentProduct.ExtraImageList)
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

        private void IconButton_shopProducts_Click(object sender, EventArgs e)
        {
            tabControl_Products.SelectedTab = tabPage_shopProducts;
            rjButton_addNewProductNavigate.Enabled = true;
        }

        private void IconButton_bannedProduct_Click(object sender, EventArgs e)
        {
            tabControl_Products.SelectedTab = tabPage_bannedProduct;

        }

        private void IconButton_waitingProducts_Click(object sender, EventArgs e)
        {
            tabControl_Products.SelectedTab = tabPage_waitingProducts;
        }


        private void SubViewShopProducts_Load(object sender, EventArgs e)
        {
            FillWaitingProduct();
            FillBannedProduct();
            FillShopProduct();
        }

        private void RjButton_changeImage_Click(object sender, EventArgs e)
        {
            foreach(PictureBox picture in panel_productImageHolder.Controls)
            {
                Random random = new Random();
                if (picture.BorderStyle == BorderStyle.FixedSingle)
                {
                    using (OpenFileDialog openFile = new OpenFileDialog())
                    {
                        openFile.InitialDirectory = FilePathProcessing.GetProductImageDirectory().Replace("/", "\\");
                        openFile.Filter = "Files|*.jpg;*.jpeg;*.png;";
                        if (openFile.ShowDialog() == DialogResult.OK)
                        {
                            //// image duplicated handlder
                            //string fileName = openFile.FileName.Split('\\').Last();
                            //if (products.Any(pro => pro.MainImage == fileName  || pro.ExtraImageList.Contains(fileName)))
                            //{
                            //    openFile.FileName = FilePathProcessing.GetProductImageDirectory() + fileName.Split('.')[0] + random.Next(1000, 9999);
                            //    File.Copy(FilePathProcessing.GetProductImageDirectory() + fileName,
                            //              openFile.FileName);
                            //}
                            picture.Image = openFile.FileName.TurnToProductImage();
                            picture.Tag = openFile.FileName.Split('\\').Last();
                        }
                    }
                    pictureBox_mainImage.Image = picture.Image;
                    return;
                } 
            }
            MessageBox.Show("Please, choose some picture for changing!");

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            foreach(PictureBox pictureBox in panel_productImageHolder.Controls)
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            PictureBox picture = (PictureBox)sender;
            picture.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_mainImage.Image = picture.Image;
            picture.BorderStyle = BorderStyle.FixedSingle;
        }
        private void PictureBox_main_DoubleClick(object sender, EventArgs e)
        {

        }

        private void RjButton_moreDetail_Click(object sender, EventArgs e)
        {
            rjButton_updateProduct.Enabled = true;
            rjButton_addNewProductNavigate.Enabled = false;
            SetCurrentProduct((Product)(sender as RJButton).Tag);
            tabControl_Products.SelectedTab = tabPage_addNewProducts;
        }












        #region AddNewProduct
        private void RjButton_addNewProduct_Click(object sender, EventArgs e)
        {
            tabControl_Products.SelectedTab = tabPage_addNewProducts;
            rjButton_updateProduct.Enabled = false;
            rjButton_addProduct.Enabled = true;
            NewProductDetailLoad();
            currentProduct = null;
        }


        private void RjButton_addProduct_Click(object sender, EventArgs e)
        {
            //check product
            //check existed productName
            //check 5 image atleast
            if(pictureBox_main.Tag == null)
            {
                MessageBox.Show("Main image at least, please!");
                return;
            }
            if (rjTextBox_categoryName .Texts == string.Empty)
            {
                MessageBox.Show("Category, please choose one!");
                return;
            }



            Product newProduct = new Product(new DLL.Product_()
            {
                ProductName = rjTextBox_productName.Texts,
                Quantity = rjTextBox_productQuantity.Texts,
                Price = rjTextBox_productPrice.Texts,
                CreatedDate = rjTextBox_date.Texts,
                Description = rjTextBox_description.Texts.Replace('\'', '’'),
                CategoryID = rjTextBox_categoryName.Tag.ToString(),
                ShopID = shop.ShopId ,

                MainImage = pictureBox_main.Tag.ToString().Split('/').Last(),
                ExtraImageList = ReGenerateExtraImageList().ToArray(),
                AttributeList = RegenerateCategoryAttributeValue().ToArray(),
            });
            newProduct.Add();
            MessageBox.Show("Your currentProduct's being on waiting queue!");
            InitializeDataset();
            IconButton_waitingProducts_Click(null, null);
        }
        private IEnumerable<string> ReGenerateExtraImageList()
        {

            //currentProduct.MainImage.Split(' ').Cast<byte>() is byte[] &&
            if (
                MessageBox.Show(
                "Would you like to store your currentProduct images on your local machine or on our local sever\n" +
                "We recommend that you should save images on your local machine for good, Any offense!","Caution",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Random random = new Random();
                //string ImageLocation = pictureBox_mainImage.Tag.ToString();

                //if (products.Any(pro => pro.MainImage == ImageLocation || pro.ExtraImageList.Contains(ImageLocation)))
                //{
                //    pictureBox_mainImage.Image = null;
                //    File.Copy(FilePathProcessing.GetProductImageDirectory() + ImageLocation,
                //                   FilePathProcessing.GetProductImageDirectory() + ImageLocation.Split('.')[0] + random.Next(1000, 9999));
                //}


                foreach (PictureBox picture in panel_productImageHolder.Controls)
                {
                    if (picture.Tag != null && picture.Name != "pictureBox_main")
                    {
                        yield return picture.Tag.ToString().Split('/').Last().Trim(); 
                    }
                }
            }
            else
            {
                foreach (PictureBox picture in panel_productImageHolder.Controls)
                {
                    yield return ImageConverter.ConvertImageToByte(picture.Image);
                }
            }
        }
        private void NewProductDetailLoad()
        {
            rjTextBox_date.Texts = DateTime.Now.ToString();
            //categories.ToList().ForEach(category => comboBox_category.Items.Add(category.CategoryName ));
            //tabPage_addNewProducts.Controls.Clear();

            foreach(Control control1 in panel_attributesHolder.Controls)
            {
                control1.RecursivelyDispose();
            }
            foreach (Control control in tabPage_addNewProducts.Controls)
            {
                if (control is RJTextBox) { (control as RJTextBox).Texts = string.Empty; }
                if (control is PictureBox) { (control as PictureBox).Image = null; }
            }
            foreach(PictureBox picture in panel_productImageHolder.Controls)
            {
                picture.Image = null;
            }
        }


        private Category[] FindChildCategory(string categoryDadID)
        {
            return categories.Where(childCategory => childCategory.AncestorId == categoryDadID).ToArray();
        }
        private Category FindDadCategoey(Category childCategory)
        {
            return categories.Single(dadCategory => dadCategory.CategoryId == childCategory.AncestorId);
        }




        #endregion









        #region UpdateProduct
        Product currentProduct;
        bool categoryUpdatable = false;
        private void RjButton_updateProduct_Click(object sender, EventArgs e)
        {
            currentProduct.ProductName = rjTextBox_productName.Texts;
            currentProduct.Price = rjTextBox_productPrice.Texts;
            currentProduct.Quantity = rjTextBox_productQuantity.Texts;
            currentProduct.ProductId = rjTextBox_productName.Tag.ToString();
            currentProduct.Description = rjTextBox_description.Texts;
            currentProduct.MainImage = pictureBox_main.Tag.ToString().Split('/').Last();
            currentProduct.ExtraImageList = ReGenerateExtraImageList().ToArray();
            currentProduct.CategoryID = rjTextBox_categoryName.Tag.ToString();
            currentProduct.AttributeList = RegenerateCategoryAttributeValue().ToArray();
            currentProduct.Update();
            MessageBox.Show("Update sucessfully!"); ;
            IconButton_waitingProducts_Click(null, null);
        }



        #endregion





        private void FillCategoryAttribute(Category category)
        {
            
            // trigger these when you add a new product
            if (rjButton_addProduct.Enabled)
            {
                rjTextBox_categoryName.Tag = category.CategoryId;
                rjTextBox_categoryName.Name = category.CategoryName;
                panel_attributesHolder.Controls.Clear();
                category.AttributeList.Split(',').ToList().ForEach(attributeName => panel_attributesHolder.Controls.Add(GenerateCateogoryAttribute(attributeName, "")));
                return;
            }else
            {
                //trigger these when you have a product but loaded it first time
                if (!categoryUpdatable)
                {
                    rjTextBox_categoryName.Tag = category.CategoryId;
                    rjTextBox_categoryName.Name = category.CategoryName;
                    panel_attributesHolder.Controls.Clear();
                    foreach ( var tupleAttributeNameValue in currentProduct.AttributeList.Zip(category.AttributeList.Split(','), Tuple.Create))
                    {
                        panel_attributesHolder.Controls.Add(GenerateCateogoryAttribute(tupleAttributeNameValue.Item2, tupleAttributeNameValue.Item1));
                    }
                    categoryUpdatable = true;
                }
                //trigger these when you've already loaded it and by some way you want to change its category
                else if (categoryUpdatable && 
                    MessageBox.Show("If you change the category of these currentProduct, the category attribute detail data will be removed!, are you sure?", 
                    "Caution",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    rjTextBox_categoryName.Tag = category.CategoryId;
                    rjTextBox_categoryName.Name = category.CategoryName;
                    panel_attributesHolder.Controls.Clear();
                    currentProduct.AttributeList = new string[] { };
                    category.AttributeList.Split(',').ToList().ForEach(attributeName => panel_attributesHolder.Controls.Add(GenerateCateogoryAttribute(attributeName, "")));
                }

            }

        }
        private IEnumerable<string> RegenerateCategoryAttributeValue()
        {
            foreach(RJTextBox text in panel_attributesHolder.Controls.Find("rjTextBox_attriibuteValue", true).OfType<RJTextBox>())
            {
                yield return text.Texts.Trim();
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
            panel_attribute.Padding = new System.Windows.Forms.Padding(3, 0, 15, 5);
            panel_attribute.Size = new System.Drawing.Size(342, 53);
            panel_attribute.TabIndex = 0;

            return panel_attribute;
        }
















        #region Waiting product
        private void FillWaitingProduct()
        {
            foreach (Panel panel in tabPage_waitingProducts.Controls.OfType<Panel>())
            {
                panel.RecursivelyDispose();
            }
            foreach(Product pro in products.Where(pro => !pro.ReviewState))
            {
                tabPage_waitingProducts.Controls.Add(GenerateWaitingProduct(pro));
            }
        }
        
        private Panel GenerateWaitingProduct(Product product)
        {
            Panel panel_waitingProduct = new Panel();
            Panel panel_waitingProductSavior = new Panel();
            RJButton rjButton6 = new RJButton();
            RJButton RjButton_moreDetail = new RJButton();
            RJButton rjButton_cancelWaitingProduct = new RJButton();
            Label label_waitingProuductID = new Label();
            Label label_waitingProductName = new Label();
            CheckBox checkBox_waitingProductChecked = new CheckBox();
            PictureBox pictureBox_waitingProductImage = new PictureBox();
            Label label_waitingProductQuantity = new Label();

            
            rjButton6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton6.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton6.BorderRadius = 15;
            rjButton6.BorderSize = 0;
            rjButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton6.Enabled = false;
            rjButton6.FlatAppearance.BorderSize = 0;
            rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton6.ForeColor = System.Drawing.Color.White;
            rjButton6.Location = new System.Drawing.Point(10, 0);
            rjButton6.Name = "rjButton6";
            rjButton6.Size = new System.Drawing.Size(1017, 134);
            rjButton6.TabIndex = 0;
            rjButton6.TextColor = System.Drawing.Color.White;
            rjButton6.UseVisualStyleBackColor = false;

            rjButton_cancelWaitingProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_cancelWaitingProduct.BackColor = System.Drawing.Color.IndianRed;
            rjButton_cancelWaitingProduct.BackgroundColor = System.Drawing.Color.IndianRed;
            rjButton_cancelWaitingProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_cancelWaitingProduct.BorderRadius = 15;
            rjButton_cancelWaitingProduct.BorderSize = 0;
            rjButton_cancelWaitingProduct.FlatAppearance.BorderSize = 0;
            rjButton_cancelWaitingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_cancelWaitingProduct.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_cancelWaitingProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_cancelWaitingProduct.Location = new System.Drawing.Point(845, 26);
            rjButton_cancelWaitingProduct.Name = "rjButton_cancelWaitingProduct";
            rjButton_cancelWaitingProduct.Size = new System.Drawing.Size(140, 38);
            rjButton_cancelWaitingProduct.TabIndex = 20;
            rjButton_cancelWaitingProduct.Text = "Cancel";
            rjButton_cancelWaitingProduct.TextColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_cancelWaitingProduct.UseVisualStyleBackColor = false;

            label_waitingProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_waitingProductName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_waitingProductName.Location = new System.Drawing.Point(123, 10);
            label_waitingProductName.Name = "label_waitingProductName";
            label_waitingProductName.Size = new System.Drawing.Size(326, 34);
            label_waitingProductName.TabIndex = 19;
            label_waitingProductName.Text = product.ProductName;

            label_waitingProductQuantity.AutoSize = true;
            label_waitingProductQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_waitingProductQuantity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_waitingProductQuantity.Location = new System.Drawing.Point(124, 39);
            label_waitingProductQuantity.Name = "label_waitingProductQuantity";
            label_waitingProductQuantity.Size = new System.Drawing.Size(40, 17);
            label_waitingProductQuantity.TabIndex = 19;
            label_waitingProductQuantity.Text = "x" + product.Quantity;

            label_waitingProuductID.AutoSize = true;
            label_waitingProuductID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_waitingProuductID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_waitingProuductID.Location = new System.Drawing.Point(124, 69);
            label_waitingProuductID.Name = "label_waitingProuductID";
            label_waitingProuductID.Size = new System.Drawing.Size(124, 69);
            label_waitingProuductID.TabIndex = 19;
            label_waitingProuductID.Text = "Id: " + product.ProductId;

            pictureBox_waitingProductImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_waitingProductImage.Location = new System.Drawing.Point(25,10);
            pictureBox_waitingProductImage.Name = "pictureBox_waitingProductImage";
            pictureBox_waitingProductImage.Size = new System.Drawing.Size(82, 76);
            pictureBox_waitingProductImage.TabIndex = 18;
            pictureBox_waitingProductImage.TabStop = false;
            pictureBox_waitingProductImage.Image = product.MainImage.GetProductImagePath().TurnToCustomerImage();
            pictureBox_waitingProductImage.Click += PictureBox_productImage_Click;
            pictureBox_waitingProductImage.SizeMode = PictureBoxSizeMode.Zoom;


            checkBox_waitingProductChecked.AutoSize = true;
            checkBox_waitingProductChecked.BackColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox_waitingProductChecked.Font = new System.Drawing.Font("Tahoma", 10F);
            checkBox_waitingProductChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            checkBox_waitingProductChecked.Location = new System.Drawing.Point(4, 37);
            checkBox_waitingProductChecked.Name = "checkBox_waitingProductChecked";
            checkBox_waitingProductChecked.Size = new System.Drawing.Size(18, 17);
            checkBox_waitingProductChecked.TabIndex = 17;
            checkBox_waitingProductChecked.UseVisualStyleBackColor = false;

            panel_waitingProduct.Controls.Add(RjButton_moreDetail);
            RjButton_moreDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            RjButton_moreDetail.BackColor = System.Drawing.SystemColors.Control;
            RjButton_moreDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            RjButton_moreDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            RjButton_moreDetail.BorderRadius = 15;
            RjButton_moreDetail.BorderSize = 0;
            RjButton_moreDetail.FlatAppearance.BorderSize = 0;
            RjButton_moreDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RjButton_moreDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            RjButton_moreDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            RjButton_moreDetail.Location = new System.Drawing.Point(691, 26);
            RjButton_moreDetail.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            RjButton_moreDetail.Name = "rjButton_moreDetail";
            RjButton_moreDetail.Size = new System.Drawing.Size(140, 38);
            RjButton_moreDetail.TabIndex = 16;
            RjButton_moreDetail.Text = "More detail";
            RjButton_moreDetail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            RjButton_moreDetail.UseVisualStyleBackColor = false;
            RjButton_moreDetail.Click += RjButton_moreDetail_Click;
            RjButton_moreDetail.Tag = product;

            panel_waitingProductSavior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_waitingProductSavior.Location = new System.Drawing.Point(21, 21);
            panel_waitingProductSavior.Name = "panel_waitingProductSavior";
            panel_waitingProductSavior.Size = new System.Drawing.Size(989, 100);
            panel_waitingProductSavior.TabIndex = 21;

            panel_waitingProductSavior.Controls.Add(RjButton_moreDetail);
            panel_waitingProductSavior.Controls.Add(rjButton_cancelWaitingProduct);
            panel_waitingProductSavior.Controls.Add(checkBox_waitingProductChecked);
            panel_waitingProductSavior.Controls.Add(pictureBox_waitingProductImage);
            panel_waitingProductSavior.Controls.Add(label_waitingProuductID);
            panel_waitingProductSavior.Controls.Add(label_waitingProductQuantity);
            panel_waitingProductSavior.Controls.Add(label_waitingProductName);
            panel_waitingProductSavior.Controls.Add(rjButton_cancelWaitingProduct);
            panel_waitingProduct.Controls.Add(panel_waitingProductSavior);
            panel_waitingProduct.Controls.Add(rjButton6);
            rjButton6.SendToBack();

            panel_waitingProduct.Dock = System.Windows.Forms.DockStyle.Top;
            panel_waitingProduct.Location = new System.Drawing.Point(3, 100);
            panel_waitingProduct.Name = "panel_waitingProduct";
            panel_waitingProduct.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            panel_waitingProduct.Size = new System.Drawing.Size(1031, 144);
            panel_waitingProduct.TabIndex = 0;

            return panel_waitingProduct;
        }



        #endregion

        private void PictureBox_productImage_Click(object sender, EventArgs e)
        {
            //Object
        }








        #region Shop product
        private void FillShopProduct()
        {
            foreach (Panel panel in tabPage_shopProducts.Controls.OfType<Panel>())
            {
                panel.RecursivelyDispose();
            }
            foreach (Product pro in products.Where(pro => pro.ReviewState))
            {
                tabPage_shopProducts.Controls.Add(GenerateShopProductReviewed(pro));
            }
        }
        private Panel GenerateShopProductReviewed(Product product)
        {
            Panel panel_reviewedProducts = new Panel();
            Panel panel_revieweddeath = new Panel();
            Panel panel_reviewSavior = new Panel();
            RJButton rjButton_moreDetail = new RJButton();
            RJButton rjButton_waitingProduct = new RJButton();
            RJButton rjButton_waitingMoreDetail = new RJButton();
            CheckBox checkBox_reviewedProductChecked = new CheckBox();
            Label label_reviewedproductName = new Label();
            Label label_reviewedProductQuantity = new Label();
            Label label2 = new Label();
            PictureBox pictureBox_reviewedProductImage = new PictureBox();

            panel_revieweddeath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_revieweddeath.Controls.Add(rjButton_moreDetail);
            panel_revieweddeath.Location = new System.Drawing.Point(801, 20);
            panel_revieweddeath.Name = "panel_revieweddeath";
            panel_revieweddeath.Size = new System.Drawing.Size(200, 100);
            panel_revieweddeath.TabIndex = 25;
            panel_revieweddeath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panel_reviewSavior.BackColor = System.Drawing.SystemColors.ControlLightLight;

            

            panel_reviewSavior.Location = new System.Drawing.Point(16, 20);
            panel_reviewSavior.Name = "panel_reviewSavior";
            panel_reviewSavior.Size = new System.Drawing.Size(662, 100);
            panel_reviewSavior.TabIndex = 26;


            rjButton_moreDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_moreDetail.BackColor = System.Drawing.SystemColors.Control;
            rjButton_moreDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_moreDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_moreDetail.BorderRadius = 15;
            rjButton_moreDetail.BorderSize = 0;
            rjButton_moreDetail.FlatAppearance.BorderSize = 0;
            rjButton_moreDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_moreDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_moreDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_moreDetail.Location = new System.Drawing.Point(44, 26);
            rjButton_moreDetail.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            rjButton_moreDetail.Name = "rjButton_moreDetail";
            rjButton_moreDetail.Size = new System.Drawing.Size(140, 38);
            rjButton_moreDetail.TabIndex = 16;
            rjButton_moreDetail.Text = "More detail";
            rjButton_moreDetail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_moreDetail.UseVisualStyleBackColor = false;
            rjButton_moreDetail.Click += new System.EventHandler(RjButton_moreDetail_Click);
            rjButton_moreDetail.Tag = product;

            checkBox_reviewedProductChecked.AutoSize = true;
            checkBox_reviewedProductChecked.BackColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox_reviewedProductChecked.Font = new System.Drawing.Font("Tahoma", 10F);
            checkBox_reviewedProductChecked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            checkBox_reviewedProductChecked.Location = new System.Drawing.Point(2, 39);
            checkBox_reviewedProductChecked.Name = "checkBox_reviewedProductChecked";
            checkBox_reviewedProductChecked.Size = new System.Drawing.Size(18, 17);
            checkBox_reviewedProductChecked.TabIndex = 17;
            checkBox_reviewedProductChecked.UseVisualStyleBackColor = false;

            rjButton_waitingProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_waitingProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_waitingProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_waitingProduct.BorderRadius = 15;
            rjButton_waitingProduct.BorderSize = 0;
            rjButton_waitingProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_waitingProduct.Enabled = false;
            rjButton_waitingProduct.FlatAppearance.BorderSize = 0;
            rjButton_waitingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_waitingProduct.ForeColor = System.Drawing.Color.White;
            rjButton_waitingProduct.Location = new System.Drawing.Point(10, 0);
            rjButton_waitingProduct.Name = "rjButton_waitingProduct";
            rjButton_waitingProduct.Size = new System.Drawing.Size(1011, 134);
            rjButton_waitingProduct.TabIndex = 0;
            rjButton_waitingProduct.TextColor = System.Drawing.Color.White;
            rjButton_waitingProduct.UseVisualStyleBackColor = false;

            label_reviewedproductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_reviewedproductName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_reviewedproductName.Location = new System.Drawing.Point(135, 11);
            label_reviewedproductName.Name = "label_reviewedproductName";
            label_reviewedproductName.Size = new System.Drawing.Size(326, 34);
            label_reviewedproductName.TabIndex = 19;
            label_reviewedproductName.Text = product.ProductName;

            label_reviewedProductQuantity.AutoSize = true;
            label_reviewedProductQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_reviewedProductQuantity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_reviewedProductQuantity.Location = new System.Drawing.Point(205, 39);
            label_reviewedProductQuantity.Name = "label_reviewedProductQuantity";
            label_reviewedProductQuantity.Size = new System.Drawing.Size(41, 17);
            label_reviewedProductQuantity.TabIndex = 19;
            label_reviewedProductQuantity.Text = product.Quantity;

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(135, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 19;
            label2.Text = "Quantity :";


            pictureBox_reviewedProductImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_reviewedProductImage.Location = new System.Drawing.Point(32, 11);
            pictureBox_reviewedProductImage.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            pictureBox_reviewedProductImage.Name = "pictureBox_reviewedProductImage";
            pictureBox_reviewedProductImage.Size = new System.Drawing.Size(82, 76);
            pictureBox_reviewedProductImage.TabIndex = 18;
            pictureBox_reviewedProductImage.TabStop = false;
            pictureBox_reviewedProductImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_reviewedProductImage.Click += PictureBox_productImage_Click;
            pictureBox_reviewedProductImage.SizeMode = PictureBoxSizeMode.Zoom;

            panel_reviewedProducts.Dock = System.Windows.Forms.DockStyle.Top;
            panel_reviewedProducts.Location = new System.Drawing.Point(3, 100);
            panel_reviewedProducts.Name = "panel_reviewedProducts";
            panel_reviewedProducts.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            panel_reviewedProducts.Size = new System.Drawing.Size(1031, 144);
            panel_reviewedProducts.TabIndex = 0;

            for(int i = 1;i < product.RatingStar.ToInt() + 1; i++)
            {
                PictureBox pictureBox_reviewedProductStar = new PictureBox();
                pictureBox_reviewedProductStar.BackColor = System.Drawing.SystemColors.ControlLightLight;
                pictureBox_reviewedProductStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_reviewedProductStar.Image")));
                pictureBox_reviewedProductStar.Location = new System.Drawing.Point(114 + i * 25, 67);
                pictureBox_reviewedProductStar.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
                pictureBox_reviewedProductStar.Name = "pictureBox_reviewedProductStar";
                pictureBox_reviewedProductStar.Size = new System.Drawing.Size(20, 20);
                pictureBox_reviewedProductStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox_reviewedProductStar.TabIndex = 24;
                pictureBox_reviewedProductStar.TabStop = false;
                panel_reviewSavior.Controls.Add(pictureBox_reviewedProductStar);
                pictureBox_reviewedProductStar.BringToFront();
            }

            panel_reviewSavior.Controls.Add(label2);
            panel_reviewSavior.Controls.Add(label_reviewedProductQuantity);
            panel_reviewSavior.Controls.Add(label_reviewedproductName);
            panel_reviewSavior.Controls.Add(pictureBox_reviewedProductImage);
            panel_reviewSavior.Controls.Add(checkBox_reviewedProductChecked);

            panel_revieweddeath.Controls.Add(rjButton_moreDetail);

            panel_reviewedProducts.Controls.Add(panel_revieweddeath);
            panel_reviewedProducts.Controls.Add(panel_reviewSavior);
            panel_reviewedProducts.Controls.Add(rjButton_waitingProduct);
            rjButton_waitingProduct.SendToBack();


            return panel_reviewedProducts;
        }


        #endregion
        #region something

        #endregion





        #region Menustrip 
        private void IconButton_levelCategory_Click(object sender, EventArgs e)
        {
            contextMenuStrip_levelingCategory.Items.Clear();
            foreach(Category firstClassCategory in categories.Where(cate => cate.AncestorId == "0"))
            {
                contextMenuStrip_levelingCategory.Items.Add(GenerateToolstripMenuItem(firstClassCategory));
            }
            contextMenuStrip_levelingCategory.Show(rjTextBox_categoryName, 10, rjTextBox_categoryName.Size.Height);
            
        }
        private ToolStripMenuItem GenerateToolstripMenuItem(Category category)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();

            menuItem.Text = category.CategoryName;
            menuItem.Tag = category.CategoryId;
            menuItem.Name = category.CategoryName;
            menuItem.Image = (Properties.Resources._2246813_add_photo_add_plus_upload);
            menuItem.Click += MenuItem_Click;
            
            Category[] subcategories = FindChildCategory(category.CategoryId);
            if ( subcategories.Count() > 0) 
            {
                foreach(Category newphewCategory in subcategories)
                {
                    menuItem.DropDownItems.Add(GenerateToolstripMenuItem(newphewCategory));
                }
            }
            return menuItem;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ContextMenuStrip)
            {
                return;
            }
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            rjTextBox_categoryName.Tag = menuItem.Tag;
            rjTextBox_categoryName.Texts = menuItem.Name;
            FillCategoryAttribute(categories.SingleOrDefault(cate => cate.CategoryName == rjTextBox_categoryName.Texts.ToString()));
        }

        private void ContextMenuStrip_levelingCategory_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(sender is ContextMenuStrip)
            {
                MessageBox.Show("Cannot take the first class category");
                return;
            }
        }
       
        #endregion 

        private void CheckBox_allProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allProducts.Checked)
            {
                foreach(CheckBox checkBox in tabPage_shopProducts.Controls.Find("checkBox_reviewedProductChecked", true))
                {
                    checkBox.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox checkBox in tabPage_shopProducts.Controls.Find("checkBox_reviewedProductChecked", true))
                {
                    checkBox.Checked = false;
                }

            }

        }

        private void CheckBox_reviewedProductChecked_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in tabPage_shopProducts.Controls.Find("checkBox_reviewedProductChecked", true))
            {
                if (!checkBox.Checked)
                {
                    checkBox_allProducts.Checked = false;
                    return;
                }
            }
            checkBox_allProducts.Checked = true;

        }

        private void RjButton_deleteProduct_Click(object sender, EventArgs e)
        {
            //if(check)

        }
        private void IconButton_searchShopProducts_Click(object sender, EventArgs e)
        {
            foreach(Label ProductName in tabPage_shopProducts.Controls.Find("label_reviewedproductName", true))
            {
                if (!ProductName.Text.Contains(rjTextBox_searchShopProducts.Texts))
                {
                    ProductName.Parent.Parent.RecursivelyDispose();
                }
            }
        }



        #region Banned Product
        private void FillBannedProduct()
        {
            foreach (Panel product in tabPage_bannedProduct.Controls.OfType<Panel>())
            {
                product.RecursivelyDispose();
            }
            foreach (Product product in products.Where(pro => pro.BannedState))
            {
                tabPage_bannedProduct.Controls.Add(GeneratebannedProduct(product));
            }
        }

        private Control GeneratebannedProduct(Product product)
        {
            Panel panel_bannedPeoduct = new Panel();
            Panel panel_bannedHolder = new Panel();
            RJButton rjButton_bannedProduct = new RJButton();
            RJButton rjButton_bannedMoredetail = new RJButton();

            Label label_bannedProductName = new Label();
            Label label5 = new Label();
            Label label_bannedProductQuantity = new Label();
            PictureBox pictureBox_bannedProductImage= new PictureBox();
            CheckBox checkBox_bannedProductCheck = new CheckBox();

            checkBox_bannedProductCheck.AutoSize = true;
            checkBox_bannedProductCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            checkBox_bannedProductCheck.Font = new System.Drawing.Font("Tahoma", 10F);
            checkBox_bannedProductCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            checkBox_bannedProductCheck.Location = new System.Drawing.Point(3, 38);
            checkBox_bannedProductCheck.Name = "checkBox_bannedProductCheck";
            checkBox_bannedProductCheck.Size = new System.Drawing.Size(18, 17);
            checkBox_bannedProductCheck.TabIndex = 17;
            checkBox_bannedProductCheck.UseVisualStyleBackColor = false;

            pictureBox_bannedProductImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_bannedProductImage.Location = new System.Drawing.Point(24, 11);
            pictureBox_bannedProductImage.Name = "pictureBox_bannedProductImage";
            pictureBox_bannedProductImage.Size = new System.Drawing.Size(82, 76);
            pictureBox_bannedProductImage.TabIndex = 18;
            pictureBox_bannedProductImage.TabStop = false;

            label_bannedProductQuantity.AutoSize = true;
            label_bannedProductQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_bannedProductQuantity.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_bannedProductQuantity.Location = new System.Drawing.Point(200, 45);
            label_bannedProductQuantity.Name = "label_bannedProductQuantity";
            label_bannedProductQuantity.Size = new System.Drawing.Size(41, 17);
            label_bannedProductQuantity.TabIndex = 19;
            label_bannedProductQuantity.Text = product.Quantity;

            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(122, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 17);
            label5.TabIndex = 19;
            label5.Text = "Quantity :";

            label_bannedProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label_bannedProductName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_bannedProductName.ForeColor = System.Drawing.Color.LightCoral;
            label_bannedProductName.Location = new System.Drawing.Point(121, 11);
            label_bannedProductName.Name = "label_bannedProductName";
            label_bannedProductName.Size = new System.Drawing.Size(326, 34);
            label_bannedProductName.TabIndex = 19;
            label_bannedProductName.Text = product.ProductName;

            rjButton_bannedMoredetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_bannedMoredetail.BackColor = System.Drawing.SystemColors.Control;
            rjButton_bannedMoredetail.BackgroundColor = System.Drawing.SystemColors.Control;
            rjButton_bannedMoredetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_bannedMoredetail.BorderRadius = 15;
            rjButton_bannedMoredetail.BorderSize = 0;
            rjButton_bannedMoredetail.FlatAppearance.BorderSize = 0;
            rjButton_bannedMoredetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_bannedMoredetail.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_bannedMoredetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_bannedMoredetail.Location = new System.Drawing.Point(846, 32);
            rjButton_bannedMoredetail.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            rjButton_bannedMoredetail.Name = "rjButton_bannedMoredetail";
            rjButton_bannedMoredetail.Size = new System.Drawing.Size(140, 38);
            rjButton_bannedMoredetail.TabIndex = 16;
            rjButton_bannedMoredetail.Text = "More detail";
            rjButton_bannedMoredetail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_bannedMoredetail.UseVisualStyleBackColor = false;
            rjButton_bannedMoredetail.Click += RjButton_moreDetail_Click;
            rjButton_bannedMoredetail.Tag = product;


            rjButton_bannedProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_bannedProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_bannedProduct.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_bannedProduct.BorderRadius = 15;
            rjButton_bannedProduct.BorderSize = 0;
            rjButton_bannedProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_bannedProduct.Enabled = false;
            rjButton_bannedProduct.FlatAppearance.BorderSize = 0;
            rjButton_bannedProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_bannedProduct.ForeColor = System.Drawing.Color.White;
            rjButton_bannedProduct.Location = new System.Drawing.Point(10, 0);
            rjButton_bannedProduct.Name = "rjButton_bannedProduct";
            rjButton_bannedProduct.Size = new System.Drawing.Size(1011, 134);
            rjButton_bannedProduct.TabIndex = 0;
            rjButton_bannedProduct.TextColor = System.Drawing.Color.White;
            rjButton_bannedProduct.UseVisualStyleBackColor = false;

            panel_bannedHolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_bannedHolder.Controls.Add(checkBox_bannedProductCheck);
            panel_bannedHolder.Controls.Add(pictureBox_bannedProductImage);
            panel_bannedHolder.Controls.Add(label5);
            panel_bannedHolder.Controls.Add(label_bannedProductQuantity);
            panel_bannedHolder.Controls.Add(rjButton_bannedMoredetail);
            panel_bannedHolder.Controls.Add(label_bannedProductName);
            panel_bannedHolder.Location = new System.Drawing.Point(22, 20);
            panel_bannedHolder.Name = "panel_bannedHolder";
            panel_bannedHolder.Size = new System.Drawing.Size(996, 100);
            panel_bannedHolder.TabIndex = 20;

            panel_bannedPeoduct.Controls.Add(panel_bannedHolder);
            panel_bannedPeoduct.Controls.Add(rjButton_bannedProduct);
            panel_bannedPeoduct.Dock = System.Windows.Forms.DockStyle.Top;
            panel_bannedPeoduct.Location = new System.Drawing.Point(3, 70);
            panel_bannedPeoduct.Name = "panel_bannedPeoduct";
            panel_bannedPeoduct.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            panel_bannedPeoduct.Size = new System.Drawing.Size(1031, 144);
            panel_bannedPeoduct.TabIndex = 19;


            return panel_bannedPeoduct;
        }

        #endregion









        private void TabPage_shopProducts_Click(object sender, EventArgs e)
        {

        }
        private void TabPage_addNewProducts_Click(object sender, EventArgs e)
        {

        }
        private void RjTextBox3__TextChanged(object sender, EventArgs e)
        {
        }
        private void ComboBox_category_Click(object sender, EventArgs e)
        {
        }

        private void RjButton4_Click(object sender, EventArgs e)
        {

        }

        private void RjTextBox_description__TextChanged(object sender, EventArgs e)
        {
            //
            

        }
    }

}

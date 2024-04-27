using BUS;
using CustomControls.RJControls;
using FontAwesome.Sharp;
using GUI.Properties;
using System;
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

namespace GUI
{
    public partial class ViewProductDetail : Form
    {
        Product currentProduct;
        Category category;
        Category[] categories;
        Shop shop;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductDetail));


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

        public ViewProductDetail()
        {
            InitializeComponent();
            //numericUpDown_quantity.Controls[0].Enabled = false;
            textBox_description.HideCursor();
        }

        private void ViewProductDetail_Load(object sender, EventArgs e)
        {
            label_hidden_scrollbar.BringToFront();
            label_hide_scrollbar_horizontal.BringToFront();
        }

        public void SetExternalObject(Product product)
        {
            currentProduct = product;
            categories = Category.GetCategories();
            category = categories.Single(ca => ca.CategoryId == product.CategoryID);
            shop = Shop.GetShops().Single(shop => shop.ShopId == product.ShopID);

            orderDetails = OrderDetail.GetOrderDetails().Where(orderdetail => orderdetail.ProductId == product.ProductId).ToArray();
            comments = Comment.GetComments().Join(orderDetails, comment => comment.OrderDetailID, orderdetail => orderdetail.OrderDetailId, (comment, orderdetail) => comment).ToArray();
            FillEveryThing();
            LoadSubCategory();
            LoadComment();
            ResizeCommentArea();
        }

        private void FillEveryThing()
        {
            //basic data Asignment
            label_productName.Text = currentProduct.ProductName;
            label_address.Text = shop.Address;
            labelproductPrice.Text = currentProduct.Price.ToString();
            label_provisionalPrice.Text = currentProduct.Price.ToString();
            label16.Location = new Point(labelproductPrice.Location.X + labelproductPrice.Size.Width - 10, label16.Location.Y);
            label_shopName.Text = shop.ShopName;
            textBox_description.Text = string.Join("",currentProduct.Description.ToDescription());
            rjCircularPictureBox_shopImage.Image = shop.Image.GetShopImagePath().TurnToShopImage();
            myNumericUpDown_quantity.Value = 1;
            //label_ratingStar.Text = currentProduct.RatingStar + ".0";

            currentProduct.RatingStar.ToInt();

            foreach (PictureBox pictureBox in groupBox_productIntro.Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = pictureBox.Name.Split('_').Last().ToInt() >= currentProduct.RatingStar.ToInt() ? true : false;
            }

            //intermediate
            label_numberOfComment.Text = "(" + comments.Count().ToString() + ")";

            //Image process
            //when using local sever storing technique
            flowLayoutPanel_extraImageHolder.Controls.Clear();

            if (currentProduct.MainImage.Split(' ').Cast<byte>() is byte[])
            {
                pictureBox_mainImage.Image = ImageConverter.ConvertByteToImage(currentProduct.MainImage);
                flowLayoutPanel_extraImageHolder.Controls.Add(GenerateExtraButton(ImageConverter.ConvertByteToImage(currentProduct.MainImage)));
                foreach (string ExtraImage in currentProduct.ExtraImageList)
                {
                    flowLayoutPanel_extraImageHolder.Controls.Add(GenerateExtraButton(ImageConverter.ConvertByteToImage(ExtraImage)));
                }
                return;
            }

            //when using local machine file path storing technique
            pictureBox_mainImage.Image = currentProduct.MainImage.GetProductImagePath().TurnToProductImage();
            flowLayoutPanel_extraImageHolder.Controls.Add(GenerateExtraButton(currentProduct.MainImage.GetProductImagePath().TurnToProductImage()));
            foreach (string ExtraImage in currentProduct.ExtraImageList)
            {
                flowLayoutPanel_extraImageHolder.Controls.Add(GenerateExtraButton(ExtraImage.GetProductImagePath().TurnToProductImage()));
            }

            FillProductAttributeDetail();

            // hard code
            groupBox_description.Size = new Size(groupBox_description.Size.Width, textBox_description.Lines.Count() * 27 + 75);
            groupBox_description.Location = new Point(groupBox_description.Location.X, groupBox_productDetailData.Location.Y + groupBox_productDetailData.Size.Height + 5);
            panel_upbody.Size = new Size(panel_upbody.Size.Width, groupBox_productIntro.Size.Height + groupBox_productDetailData.Size.Height + groupBox_description.Size.Height + 15);
        }

        private void FillProductAttributeDetail()
        {
            panel_productDetails.Controls.Clear();
            foreach (var tuple in currentProduct.AttributeList.Zip(category.AttributeList.Split(','), Tuple.Create))
            {
                panel_productDetails.Controls.Add(GenerateAttributeNameValue(tuple.Item2, tuple.Item1));
            }
            //check responsive
            groupBox_productDetailData.Size = new System.Drawing.Size(groupBox_productDetailData.Size.Width, panel_productDetails.Height + 60);

            //TextRenderer

        }
        private Panel GenerateAttributeNameValue(string Name, string value)
        {
            Panel panel_attributeAndName = new Panel();
            Label label_underline = new Label();
            Label label_attributeName = new Label();
            Label label_attributeValue = new Label();

            label_attributeValue.Dock = System.Windows.Forms.DockStyle.Right;
            label_attributeValue.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_attributeValue.Location = new System.Drawing.Point(291, 0);
            label_attributeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_attributeValue.Name = "label_attributeValue";
            label_attributeValue.Size = new System.Drawing.Size(213, 39);
            label_attributeValue.TabIndex = 2;
            label_attributeValue.Text = value;
            label_attributeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            label_attributeName.Dock = System.Windows.Forms.DockStyle.Left;
            label_attributeName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_attributeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_attributeName.Location = new System.Drawing.Point(0, 0);
            label_attributeName.Name = "label_attributeName";
            label_attributeName.Size = new System.Drawing.Size(261, 39);
            label_attributeName.TabIndex = 1;
            label_attributeName.Text = Name;
            label_attributeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            label_underline.BackColor = System.Drawing.Color.Silver;
            label_underline.Dock = System.Windows.Forms.DockStyle.Bottom;
            label_underline.Location = new System.Drawing.Point(0, 39);
            label_underline.Name = "label_underline";
            label_underline.Size = new System.Drawing.Size(504, 1);
            label_underline.TabIndex = 0;

            panel_attributeAndName.Controls.Add(label_attributeValue);
            panel_attributeAndName.Controls.Add(label_attributeName);
            panel_attributeAndName.Controls.Add(label_underline);
            panel_attributeAndName.Dock = System.Windows.Forms.DockStyle.Top;
            panel_attributeAndName.Location = new System.Drawing.Point(20, 5);
            panel_attributeAndName.Name = "panel_attributeAndName";
            panel_attributeAndName.Size = new System.Drawing.Size(504, 40);
            panel_attributeAndName.TabIndex = 0;

            return panel_attributeAndName;
        }

        private RJButton GenerateExtraButton(Image image)
        {
            RJButton rjButton_extraImage = new RJButton();

            rjButton_extraImage.BackColor = System.Drawing.Color.GhostWhite;
            rjButton_extraImage.BackgroundColor = System.Drawing.Color.GhostWhite;
            rjButton_extraImage.BackgroundImage = image;
            rjButton_extraImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rjButton_extraImage.BorderColor = System.Drawing.Color.GhostWhite;
            rjButton_extraImage.BorderRadius = 10;
            rjButton_extraImage.BorderSize = 1;
            rjButton_extraImage.FlatAppearance.BorderSize = 0;
            rjButton_extraImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_extraImage.ForeColor = System.Drawing.Color.White;
            rjButton_extraImage.Location = new System.Drawing.Point(3, 3);
            rjButton_extraImage.Name = "rjButton_extraImage";
            rjButton_extraImage.Size = new System.Drawing.Size(60, 60);
            rjButton_extraImage.TabIndex = 0;
            rjButton_extraImage.TextColor = System.Drawing.Color.White;
            rjButton_extraImage.UseVisualStyleBackColor = false;
            rjButton_extraImage.Click += RjButton_extraImage_Click;

            return rjButton_extraImage;

        }

        private void RjButton_extraImage_Click(object sender, EventArgs e)
        {
            RJButton button = (RJButton)sender;
            pictureBox_mainImage.Image = button.BackgroundImage;
            foreach (RJButton rjButton in flowLayoutPanel_extraImageHolder.Controls.OfType<RJButton>())
            {
                rjButton.BorderColor = Color.GhostWhite;
            }
            button.BorderColor = Color.DodgerBlue;

        }

        private void IconButton_quantityUp_Click_1(object sender, EventArgs e)
        {
            if ((sender as IconButton).IconChar == IconChar.Minus && myNumericUpDown_quantity.Value > myNumericUpDown_quantity.Minimum + 1)
            {
                myNumericUpDown_quantity.Value--;
            }
            else if ((sender as IconButton).IconChar == IconChar.PlusMinus && myNumericUpDown_quantity.Value < myNumericUpDown_quantity.Maximum)
            {
                myNumericUpDown_quantity.Value++;
            }

            label_provisionalPrice.Text = (myNumericUpDown_quantity.Value * currentProduct.Price.ToInt()).ToString();
        }








        //Scroll animation   extraImage

        bool left = false;
        int leftLimit;
        int rightLimit;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (left && flowLayoutPanel_extraImageHolder.AutoScrollPosition.X < leftLimit)
            {
                flowLayoutPanel_extraImageHolder.AutoScrollPosition = new Point(-flowLayoutPanel_extraImageHolder.AutoScrollPosition.X - 10, 0);
            }
            else if (!left && flowLayoutPanel_extraImageHolder.AutoScrollPosition.X > rightLimit)
            {
                flowLayoutPanel_extraImageHolder.AutoScrollPosition = new Point(-flowLayoutPanel_extraImageHolder.AutoScrollPosition.X + 10, 0);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void IconButton_right_Click(object sender, EventArgs e)
        {
            left = false;
            timer1.Start();
            rightLimit = flowLayoutPanel_extraImageHolder.AutoScrollPosition.X - 150;

        }

        private void IconButton_left_Click(object sender, EventArgs e)
        {
            left = true;
            timer1.Start();
            leftLimit = flowLayoutPanel_extraImageHolder.AutoScrollPosition.X + 150;
        }



        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //Image.FromFile("");/
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void RjCircularPictureBox_shopImage_Click(object sender, EventArgs e)
        {

            //create method here
            // If the delegate was instantiated, then call it, I was right about it
            if (objectExternalLink != null)
                objectExternalLink(shop);
            else
                MessageBox.Show("Object external null");
        }
        private void RjButton_buyNow_Click(object sender, EventArgs e)
        {
            
        }
        private void IconButton_chatShop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You'll be navigated to the message GUI, are you sure?","Naviagting",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                objectExternalLink(new BUS.Message(new DLL.Message_() {ReceivedId = shop.ShopOwner}));
            }
        }

        private void IconButton_quantityDown_Click(object sender, EventArgs e)
        {
            if (myNumericUpDown_quantity.Value > 0)
                myNumericUpDown_quantity.Value -= 1;
        }

        private void IconButton_quantityUp_Click(object sender, EventArgs e)
        {
            if (myNumericUpDown_quantity.Value < 99)
                myNumericUpDown_quantity.Value += 1;

        }

        private void FlowLayoutPanel_allFather_Resize(object sender, EventArgs e)
        {
            foreach (Panel panel in flowLayoutPanel_allFather.Controls)
            {
                if (panel != null && panel is Panel)
                {
                    panel.Width = flowLayoutPanel_allFather.Width - 30;
                }
            }

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label30_Click(object sender, EventArgs e)
        {


        }
        private void FlowLayoutPanel_allFather_SizeChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel_allFather_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_provisionalPrice_TextChanged(object sender, EventArgs e)
        {
            label8.Location = new Point(label_provisionalPrice.Location.X + label_provisionalPrice.Size.Width - 10, label8.Location.Y);
        }

        private void RjButton_addTocart_Click(object sender, EventArgs e)
        {
            objectExternalLink(currentProduct);
        }


















        #region Categrory Navigator

        /// <summary>
        /// take a category as the smallest, third category in category list
        /// </summary>
        /// <param name="category">the smallest category of product</param>
        /// <returns>return List of category from ancesstor category to category</returns>
        private IEnumerable<Category> GetCategoryFamily(Category Smallcategory)
        {
            Category dad = FindDadCategory(Smallcategory);
            yield return Smallcategory;
            if(dad.AncestorId == "0")
            {
                yield return dad;
            }
            GetCategoryFamily(dad);
        }
        private Category FindDadCategory(Category Smallcategory)
        {
            return categories.Single(category => category.CategoryId == Smallcategory.AncestorId);
        }

        private void RjButton_homePageAhead_Click(object sender, EventArgs e)
        {
            //just using ShopingCart to navigated home page
            objectExternalLink(new Comment(new DLL.Comment_()));
        }
     
        private void AddSubCategory(Category categoryName)
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
            rjButton_homePageAhead.Name = categoryName.CategoryId;
            rjButton_homePageAhead.Size = new System.Drawing.Size(128, 31);
            rjButton_homePageAhead.TabIndex = 13;
            rjButton_homePageAhead.Text = categoryName.CategoryName;
            rjButton_homePageAhead.Tag = categoryName;
            rjButton_homePageAhead.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_homePageAhead.UseVisualStyleBackColor = false;
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

            flowLayoutPanel_subCategoryNav.Controls.AddRange(new Control[] { label_subCategorySeparator, rjButton_homePageAhead });
        }

        private void RjButton_homePageAhead_Click1(object sender, EventArgs e)
        {
            if((sender as RJButton).Name == "not" || (sender as RJButton).Name == category.CategoryId)
            {
                MessageBox.Show("Action deny!");
                return;
            }
            objectExternalLink((Category)(sender as RJButton).Tag);
        }

        private void LoadSubCategory()
        {
            RemoveSubcategory("Home Page",false, 0);
            foreach (Category category in GetCategoryFamily(category).Reverse())
            {
                AddSubCategory(category);
            }
            AddSubCategory(new Category(new DLL.Category_() {CategoryId = "not",CategoryName = currentProduct.ProductName}));
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
            foreach (Control contr in flowLayoutPanel_subCategoryNav.Controls)
            {
                i++;
            }
            if (i == index)
            {
                return;
            }

            Control control = flowLayoutPanel_subCategoryNav.Controls[index];

            if (!removable && (control is RJButton) && control.Text == categoryName)
            {
                RemoveSubcategory(categoryName, true, ++index);
            }
            else if (removable)
            {
                RemoveSubcategory("bye bye", true, ++index);
                control.Dispose();
            }
            else
            {
                RemoveSubcategory(categoryName, removable, ++index);
            }

        }

        #endregion








        #region Comment process 
        Comment[] comments;
        OrderDetail[] orderDetails;
        Order[] orders;
        Customer[] customers;
        /// <summary>
        /// load all comment
        /// </summary>
        private void LoadComment()
        {
            InitilaizeDataset();

            foreach(GroupBox group in groupBox_commentHolder.Controls.OfType<GroupBox>())
            {
                group.BringToFront();
                group.RecursivelyDispose();
                group.Dispose();

            }



            foreach (OrderDetail orderDetail in orderDetails)
            {
                Comment CusComment = comments.SingleOrDefault(comment => comment.OrderDetailID == orderDetail.OrderDetailId && !comment.ResponseComment);
                Comment respondComment = comments.SingleOrDefault(comment => comment.OrderDetailID == orderDetail.OrderDetailId && comment.ResponseComment);
                Order order = orders.Single(orderVar => orderVar.OrderId == orderDetail.OrderId);
                Customer cus = customers.SingleOrDefault(customer => customer.CustomerId == order.CustomerID);
                //groupBox_commentHolder.Controls.Add(GenerateComment(  cus, CusComment, CusComment ));   //test
                groupBox_commentHolder.Controls.Add(GenerateComment(  cus, CusComment, respondComment));
            }
        }
        private void InitilaizeDataset()
        {
            //get all order detail related to  this current product;
            orderDetails = OrderDetail.GetOrderDetails().Where(orderdetail => orderdetail.ProductId == currentProduct.ProductId).ToArray();

            //get all order related to these order detail
            orders = Order.GetOrders().Where(order => orderDetails.Any(orderdetail => orderdetail.OrderId == order.OrderId)).ToArray();

            customers = Customer.GetCustomers().Where(customer => orders.Any(order => order.CustomerID == customer.CustomerId)).ToArray();

            comments = Comment.GetComments().Join(orderDetails, comment => comment.OrderDetailID, orderdetail => orderdetail.OrderDetailId, (comment, orderdetal) => comment).ToArray();


        }

        private void ResizeCommentArea()
        {
            //check yourself
            int height = 0;
            foreach(GroupBox group in groupBox_commentHolder.Controls.OfType<GroupBox>())
            {
                height += group.Size.Height;
            }
            panel_belowBody.Size = new Size(panel_belowBody.Size.Width, height + 25 + 330 + 50);

        }


        private GroupBox GenerateComment(Customer customer,Comment comment = null, Comment respondComment = null)
        {
            if(comment == null)
            {
                return null;
            }

            GroupBox groupBox_comment = new GroupBox();
            groupBox_comment.BringToFront();
            RJCircularPictureBox rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            Label label_customerName = new Label();
            Label label_commentDate = new Label();
            Label label_Fealing = new Label();
            PictureBox pictureBox_purchaseVerify = new PictureBox();
            Label label_puchase = new Label();
            Label label_comment = new Label();

            if(respondComment != null)
            {
                int limit1 = 80;
                int line1 = 1;
                string newContent1 = "";
                for (int i = 0; i < respondComment.Content.Length; i++)
                {
                    if (limit1 == 0)
                    {
                        newContent1 += respondComment.Content[i];
                        newContent1 += "\n";
                        limit1 = 80;
                        line1++;
                    }

                    else
                    {
                        newContent1 += respondComment.Content[i];

                        limit1--;
                    }
                }

                RJButton rjButton_shopBackground = new RJButton();
                RJCircularPictureBox rjCircularPictureBox_shopComentImage = new RJCircularPictureBox();
                Label label_shopCommentName = new Label();
                Label label_dateShopRespond = new Label();
                Label label_shopRespond= new Label();

                label_shopRespond.BackColor = System.Drawing.SystemColors.ControlLight;
                label_shopRespond.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_shopRespond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                label_shopRespond.Location = new System.Drawing.Point(325, 242);
                label_shopRespond.Name = "label_shopRespond";
                label_shopRespond.Size = new System.Drawing.Size(551, line1 * 26);
                label_shopRespond.TabIndex = 9;
                label_shopRespond.Text = newContent1;
                label_shopRespond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                label_dateShopRespond.AutoSize = true;
                label_dateShopRespond.BackColor = System.Drawing.SystemColors.ControlLight;
                label_dateShopRespond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_dateShopRespond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                label_dateShopRespond.Location = new System.Drawing.Point(458, 210);
                label_dateShopRespond.Name = "label_dateShopRespond";
                label_dateShopRespond.Size = new System.Drawing.Size(127, 20);
                label_dateShopRespond.TabIndex = 1;
                label_dateShopRespond.Text = "|  " + respondComment.Date;
                label_dateShopRespond.Click += new System.EventHandler(Label30_Click);

                label_shopCommentName.BackColor = System.Drawing.SystemColors.ControlLight;
                label_shopCommentName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_shopCommentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                label_shopCommentName.Location = new System.Drawing.Point(325, 202);
                label_shopCommentName.Name = "label_shopCommentName";
                label_shopCommentName.Size = new System.Drawing.Size(127, 40);
                label_shopCommentName.TabIndex = 9;
                label_shopCommentName.Text = shop.ShopName;
                label_shopCommentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                rjCircularPictureBox_shopComentImage.BackColor = System.Drawing.SystemColors.Control;
                rjCircularPictureBox_shopComentImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
                rjCircularPictureBox_shopComentImage.BorderColor = System.Drawing.SystemColors.Control;
                rjCircularPictureBox_shopComentImage.BorderColor2 = System.Drawing.SystemColors.Control;
                rjCircularPictureBox_shopComentImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                rjCircularPictureBox_shopComentImage.BorderSize = 2;
                rjCircularPictureBox_shopComentImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox_shopComentImage.ErrorImage")));
                rjCircularPictureBox_shopComentImage.GradientAngle = 50F;
                rjCircularPictureBox_shopComentImage.Image = shop.Image.GetStaffImagePath().TurnToShopImage();
                rjCircularPictureBox_shopComentImage.Location = new System.Drawing.Point(279, 202);
                rjCircularPictureBox_shopComentImage.Name = "rjCircularPictureBox_shopComentImage";
                rjCircularPictureBox_shopComentImage.Size = new System.Drawing.Size(40, 40);
                rjCircularPictureBox_shopComentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                rjCircularPictureBox_shopComentImage.TabIndex = 8;
                rjCircularPictureBox_shopComentImage.TabStop = false;
                rjCircularPictureBox_shopComentImage.SizeMode = PictureBoxSizeMode.Zoom;
                rjCircularPictureBox_shopComentImage.Tag = shop;
                rjCircularPictureBox_shopComentImage.Click += RjCircularPictureBox_shopImage_Click;


                rjButton_shopBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
                rjButton_shopBackground.BackColor = System.Drawing.SystemColors.ControlLight;
                rjButton_shopBackground.BackgroundColor = System.Drawing.SystemColors.ControlLight;
                rjButton_shopBackground.BorderColor = System.Drawing.Color.LavenderBlush;
                rjButton_shopBackground.BorderRadius = 15;
                rjButton_shopBackground.BorderSize = 1;
                rjButton_shopBackground.Enabled = false;
                rjButton_shopBackground.FlatAppearance.BorderSize = 0;
                rjButton_shopBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                rjButton_shopBackground.ForeColor = System.Drawing.Color.White;
                rjButton_shopBackground.Location = new System.Drawing.Point(259, 183);
                rjButton_shopBackground.Name = "rjButton_shopBackground";
                rjButton_shopBackground.Size = new System.Drawing.Size(644, line1 * 26 + 60);
                rjButton_shopBackground.TabIndex = 7;
                rjButton_shopBackground.TextColor = System.Drawing.Color.White;
                rjButton_shopBackground.UseVisualStyleBackColor = false;

                groupBox_comment.Controls.Add(label_shopRespond);
                groupBox_comment.Controls.Add(label_shopCommentName);
                groupBox_comment.Controls.Add(rjCircularPictureBox_shopComentImage);
                groupBox_comment.Controls.Add(label_dateShopRespond);
                groupBox_comment.Controls.Add(rjButton_shopBackground);
            }


            //
            int limit = 100;
            int line = 1;
            string newContent = "";
            for (int i = 0; i < comment.Content.Length; i++)
            {
                if (limit == 0)
                {
                    newContent += comment.Content[i];
                    newContent += "\n";
                    limit = 100;
                    line++;
                }

                else
                {
                    newContent += comment.Content[i];

                    limit--;
                }
            }
            label_comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            label_comment.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_comment.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label_comment.ImageKey = "(none)";
            label_comment.Location = new System.Drawing.Point(256, 94);
            label_comment.Name = "label_comment";
            label_comment.Size = new System.Drawing.Size(650, line * 26);
            label_comment.TabIndex = 1;
            label_comment.Text = newContent;// check this out.
            //label_comment.BackColor = Color.Gray;

            label_puchase.AutoSize = true;
            label_puchase.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_puchase.ForeColor = System.Drawing.Color.MediumSeaGreen;
            label_puchase.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label_puchase.ImageKey = "(none)";
            label_puchase.Location = new System.Drawing.Point(292, 59);
            label_puchase.Name = "label_puchase";
            label_puchase.Size = new System.Drawing.Size(99, 29);
            label_puchase.TabIndex = 1;
            label_puchase.Text = "Purchased";
            label_puchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            pictureBox_purchaseVerify.Location = new System.Drawing.Point(259, 59);
            pictureBox_purchaseVerify.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
            pictureBox_purchaseVerify.Name = "pictureBox_purchaseVerify";
            pictureBox_purchaseVerify.Size = new System.Drawing.Size(25, 25);
            pictureBox_purchaseVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_purchaseVerify.TabIndex = 6;
            pictureBox_purchaseVerify.TabStop = false;
            pictureBox_purchaseVerify.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_purchaseVerify.Image")));   // not display
            //pictureBox_purchaseVerify.BackColor = Color.Gray;
            pictureBox_purchaseVerify.SizeMode = PictureBoxSizeMode.Zoom;



            label_Fealing.AutoSize = true;
            label_Fealing.Font = new System.Drawing.Font("Sans Serif Collection", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Fealing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_Fealing.Location = new System.Drawing.Point(432, 21);
            label_Fealing.Name = "label_Fealing";
            label_Fealing.Size = new System.Drawing.Size(163, 27);
            label_Fealing.TabIndex = 1;
            //depend on star
            if(comment.Star == 5)
            {
                label_Fealing.Text = "Extremely Satisfied";
            }
            else if(comment.Star == 4)
            {
                label_Fealing.Text = "Satisfied";

            }
            else if (comment.Star == 3)
            {
                label_Fealing.Text = "Neutral";

            }
            else if (comment.Star == 2)
            {
                label_Fealing.Text = "Dissatisfied";

            }
            else if (comment.Star == 1)
            {
                label_Fealing.Text = "Disapointed";

            }


            //dependon star ratin
            for(int  i = 0; i < 5; i++)
            {
                 if(i < comment.Star)
                {
                    PictureBox pictureBox_commment_1 =new PictureBox();
                    pictureBox_commment_1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_commment_1.Image")));
                    pictureBox_commment_1.Location = new System.Drawing.Point( 259 + (i * 35), 21);
                    pictureBox_commment_1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
                    pictureBox_commment_1.Name = "pictureBox_commment_1";
                    pictureBox_commment_1.Size = new System.Drawing.Size(25, 25);
                    pictureBox_commment_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox_commment_1.TabIndex = 6;
                    pictureBox_commment_1.TabStop = false;
                    groupBox_comment.Controls.Add(pictureBox_commment_1);
                }
                else
                {
                    PictureBox pictureBox_commment_1 = new PictureBox();
                    pictureBox_commment_1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
                    pictureBox_commment_1.Location = new System.Drawing.Point(259 + (i * 35), 21);
                    pictureBox_commment_1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 10);
                    pictureBox_commment_1.Name = "pictureBox_commment_1";
                    pictureBox_commment_1.Size = new System.Drawing.Size(25, 25);
                    pictureBox_commment_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox_commment_1.TabIndex = 6;
                    pictureBox_commment_1.TabStop = false;
                    groupBox_comment.Controls.Add(pictureBox_commment_1);

                }
            }


            label_commentDate.AutoSize = true;
            label_commentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_commentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_commentDate.Location = new System.Drawing.Point(102, 59);
            label_commentDate.Name = "label_commentDate";
            label_commentDate.Size = new System.Drawing.Size(113, 20);
            label_commentDate.TabIndex = 1;
            label_commentDate.Text = comment.Date.Split(' ')[0];
            label_commentDate.Click += new System.EventHandler(Label30_Click);

            label_customerName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_customerName.Location = new System.Drawing.Point(95, 21);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(146, 50);
            label_customerName.TabIndex = 1;
            label_customerName.Text = customer.CustomerName;
            label_customerName.Click += new System.EventHandler(Label30_Click);

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(31, 21);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(50, 50);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 0;
            rjCircularPictureBox_customerImage.TabStop = false;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();

            groupBox_comment.Controls.Add(pictureBox_purchaseVerify);
            groupBox_comment.Controls.Add(label_comment);
            groupBox_comment.Controls.Add(label_puchase);
            groupBox_comment.Controls.Add(label_Fealing);
            groupBox_comment.Controls.Add(label_commentDate);
            groupBox_comment.Controls.Add(label_customerName);
            groupBox_comment.Controls.Add(rjCircularPictureBox_customerImage);
            groupBox_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox_comment.Location = new System.Drawing.Point(15, 378);
            groupBox_comment.Name = "groupBox_comment";
            groupBox_comment.Padding = new System.Windows.Forms.Padding(3, 3, 30, 10);

            if(respondComment == null)
            {
                groupBox_comment.Size = new System.Drawing.Size(916, 190);

            }
            else
            {
                groupBox_comment.Size = new System.Drawing.Size(916, 200 + rjButton_shopBackground.Size.Height + 30);

            }
            groupBox_comment.TabIndex = 13;
            groupBox_comment.TabStop = false;
            //groupBox_comment.BackColor = Color.Gray;

            return groupBox_comment;
        }



        #endregion

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (objectExternalLink != null)
            {
                //Just one product
                objectExternalLink(new ShoppingCart(new DLL.ShoppingCart_()));

                objectExternalLink(new OrderDetail(new DLL.OrderDetail_()
                {
                    ProductId = currentProduct.ProductId,
                    Quantity = myNumericUpDown_quantity.Value.ToString(),
                    UnitPrice = currentProduct.Price,
                    Discount = "0",
                    VoucherID = "0"

                }));
                objectExternalLink(new Customer(new DLL.Customer_()));
            }
        }
    }
}

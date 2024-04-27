using BUS;
using CustomControls.RJControls;
using DLL;
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
    public partial class SubViewCustomerComment : Form
    {

        //dataset
        Comment[] comments  ;
        Customer customer;
        Product[] products ;
        OrderDetail[] orderdetails ;
        Order[] orders;





        #region Delegate
        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void ObjectExternalLink(Entity entity);
        // Declare a new instance of the delegate (null)
        public ObjectExternalLink objectExternalLink;
        #endregion




        public SubViewCustomerComment()                                         
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            //InitializeDataset();
        }

        public void SetOrderDetail(OrderDetail Orderdetail)
        {
            // handle orderdetail, nav it to the tab added comemnt
            NavigateNewComment(Orderdetail);
            label_purchase.Visible = true;
        }
        public void SetCustomer(Customer customerPara)
        {
            customer = customerPara;
            InitializeDataset();
            FillMyComment();  
        }



        private void InitializeDataset()
        {
            //get all order belongs to this customer
            orders = Order.GetOrders().Where(order => order.CustomerID == customer.CustomerId).ToArray();

            //Get  all order detail related to these orders
            orderdetails = OrderDetail.GetOrderDetails().Where(orderdetail => orders.Any(order => order.OrderId == orderdetail.OrderId)).ToArray();

            //get all comment related to these order detail => product has already commented  (way1)


            //get all comemnt related to this customer => product has alreadly commented (way2)
            comments = Comment.GetComments().Where(comment => comment.CustomerId == customer.CustomerId).ToArray();



            products = Product.GetProducts().Where(pro => orderdetails.Any(orderdetail => orderdetail.ProductId == pro.ProductId)).ToArray();
        }
     

        private void FillMyComment()
        {
            foreach (GroupBox groupBox in tabPage_myComments.Controls.OfType<GroupBox>())
            {
                groupBox.Dispose();
            }
            foreach (OrderDetail orderDetail in orderdetails)
            {
                Comment CusComment = comments.SingleOrDefault(comment => comment.OrderDetailID == orderDetail.OrderDetailId && !comment.ResponseComment);
                Comment respondComment = comments.SingleOrDefault(comment => comment.OrderDetailID == orderDetail.OrderDetailId && comment.ResponseComment);
                Product product = products.SingleOrDefault(p => p.ProductId == orderDetail.ProductId);
                tabPage_myComments.Controls.Add(GenerateComment(product,CusComment,  respondComment));
            }

        }


        private GroupBox GenerateComment( Product product,Comment comment,Comment respondComment = null)
        {
            if (comment == null)
            {
                return null;

            }
            GroupBox groupBox_comment = new GroupBox();
            Panel panel_respondComment = new Panel();
            RJCircularPictureBox rjCircularPictureBox_customerImage =new RJCircularPictureBox();
            Label label_customerName = new Label();
            Label label_commentDate = new Label();

            Label label_yourComment = new Label();
            Label label_customerComment = new Label();

            //
            Panel panel_product = new Panel();
            PictureBox pictureBox_productImage= new PictureBox();
            Label label_productName = new Label();
            Label label_purchased =     new Label();
            RJButton rjButton_deleteComment = new RJButton();

            rjButton_deleteComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            rjButton_deleteComment.AutoSize = true;
            rjButton_deleteComment.BackColor = System.Drawing.Color.LightGray;
            rjButton_deleteComment.BackgroundColor = System.Drawing.Color.LightGray;
            rjButton_deleteComment.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_deleteComment.BorderRadius = 20;
            rjButton_deleteComment.BorderSize = 0;
            rjButton_deleteComment.FlatAppearance.BorderSize = 0;
            rjButton_deleteComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_deleteComment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_deleteComment.ForeColor = System.Drawing.Color.WhiteSmoke;
            rjButton_deleteComment.Location = new System.Drawing.Point(420, 15);
            rjButton_deleteComment.Name = "rjButton_deleteComment";
            rjButton_deleteComment.Size = new System.Drawing.Size(150, 40);
            rjButton_deleteComment.TabIndex = 15;
            rjButton_deleteComment.Text = "Delete";
            rjButton_deleteComment.TextColor = System.Drawing.Color.WhiteSmoke;
            rjButton_deleteComment.UseVisualStyleBackColor = false;
            rjButton_deleteComment.Click += RjButton_deleteComment_Click;
            rjButton_deleteComment.Tag = comment;

            label_purchased.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            label_purchased.AutoSize = true;
            label_purchased.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_purchased.ForeColor = System.Drawing.Color.DodgerBlue;
            label_purchased.Location = new System.Drawing.Point(83, 26);
            label_purchased.Name = "label_purchased";
            label_purchased.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            label_purchased.Size = new System.Drawing.Size(81, 34);
            label_purchased.TabIndex = 10;
            label_purchased.Text = "Purchased";

            label_productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            label_productName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_productName.Location = new System.Drawing.Point(83, 0);
            label_productName.Name = "label_productName";
            label_productName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            label_productName.Size = new System.Drawing.Size(331, 39);
            label_productName.TabIndex = 10;
            label_productName.Text = product.ProductName;

            pictureBox_productImage.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox_productImage.Location = new System.Drawing.Point(0, 0);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(70, 70);
            pictureBox_productImage.TabIndex = 9;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Click += new System.EventHandler(PictureBox1_Click);
            pictureBox_productImage.Tag = product;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToProductImage();
            pictureBox_productImage.SizeMode = PictureBoxSizeMode.Zoom;

            panel_product.Controls.Add(rjButton_deleteComment);
            panel_product.Controls.Add(label_purchased);
            panel_product.Controls.Add(label_productName);
            panel_product.Controls.Add(pictureBox_productImage);
            panel_product.Dock = System.Windows.Forms.DockStyle.Top;
            panel_product.Location = new System.Drawing.Point(20, 120);
            panel_product.Name = "panel_product";
            panel_product.Size = new System.Drawing.Size(700, 70);
            panel_product.TabIndex = 10;


            //

            Label label_shopRespond = new Label();     
            Label label_respondComment = new Label();
            if(respondComment != null)
            {

                label_respondComment.Dock = System.Windows.Forms.DockStyle.Top;
                label_respondComment.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_respondComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                label_respondComment.Location = new System.Drawing.Point(20, 31);
                label_respondComment.Name = "label_respondComment";
                label_respondComment.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
                label_respondComment.Size = new System.Drawing.Size(599, 89);
                label_respondComment.TabIndex = 7;
                label_respondComment.Text = respondComment.Content;

                label_shopRespond.AutoSize = true;
                label_shopRespond.Dock = System.Windows.Forms.DockStyle.Top;
                label_shopRespond.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_shopRespond.Location = new System.Drawing.Point(20, 10);
                label_shopRespond.Name = "label_shopRespond";
                label_shopRespond.Size = new System.Drawing.Size(110, 21);
                label_shopRespond.TabIndex = 7;
                label_shopRespond.Text = "Shop respond";

            //
            }


            //label_customerComment.AutoSize = true;
            int limit = 100;
            int line = 1;
            string newContent = "";
            for(int i = 0; i < comment.Content.Length; i++)
            {
                if(limit == 0)
                {
                    newContent += comment.Content[i];
                    newContent += "\n";
                    limit = 70;
                    line++;
                }

                else
                {
                    newContent += comment.Content[i];

                    limit--;
                }
            }
            
            label_customerComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            label_customerComment.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerComment.Location = new System.Drawing.Point(241, 62);
            label_customerComment.Name = "label_customerComment";
            label_customerComment.Size = new Size(width: 600, height: line * 40);

            label_customerComment.TabIndex = 7;
            //label_customerComment.Text = newContent;
            label_customerComment.Text = comment.Content;

            label_yourComment.AutoSize = true;
            label_yourComment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_yourComment.Location = new System.Drawing.Point(241, 30);
            label_yourComment.Name = "label_yourComment";
            label_yourComment.Size = new System.Drawing.Size(118, 21);
            label_yourComment.TabIndex = 7;
            label_yourComment.Text = "Your comment";


            //
            Panel panel_starCustomerholder = new Panel();
            PictureBox pictureBox_1 = new PictureBox();
            PictureBox pictureBox_2 = new PictureBox();

            pictureBox_2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_2.Image")));
            pictureBox_2.Location = new System.Drawing.Point(27, 7);
            pictureBox_2.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            pictureBox_2.Name = "pictureBox_2";
            pictureBox_2.Size = new System.Drawing.Size(15, 15);
            pictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_2.TabIndex = 5;
            pictureBox_2.TabStop = false;

            PictureBox pictureBox_3 = new PictureBox();

            pictureBox_3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_3.Image")));
            pictureBox_3.Location = new System.Drawing.Point(47, 7);
            pictureBox_3.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            pictureBox_3.Name = "pictureBox_3";
            pictureBox_3.Size = new System.Drawing.Size(15, 15);
            pictureBox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_3.TabIndex = 5;
            pictureBox_3.TabStop = false;

            PictureBox pictureBox_4 = new PictureBox();

            pictureBox_4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_4.Image")));
            pictureBox_4.Location = new System.Drawing.Point(67, 7);
            pictureBox_4.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            pictureBox_4.Name = "pictureBox_4";
            pictureBox_4.Size = new System.Drawing.Size(15, 15);
            pictureBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_4.TabIndex = 5;
            pictureBox_4.TabStop = false;

            PictureBox pictureBox_5 = new PictureBox();

            pictureBox_5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_5.Image")));
            pictureBox_5.Location = new System.Drawing.Point(87, 7);
            pictureBox_5.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            pictureBox_5.Name = "pictureBox_5";
            pictureBox_5.Size = new System.Drawing.Size(15, 15);
            pictureBox_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_5.TabIndex = 5;
            pictureBox_5.TabStop = false;

            pictureBox_1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_5.Image")));
            pictureBox_1.Location = new System.Drawing.Point(7, 7);
            pictureBox_1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            pictureBox_1.Name = "pictureBox_1";
            pictureBox_1.Size = new System.Drawing.Size(15, 15);
            pictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_1.TabIndex = 6;
            pictureBox_1.TabStop = false;

            panel_starCustomerholder.Controls.Add(pictureBox_1);
            panel_starCustomerholder.Controls.Add(pictureBox_2);
            panel_starCustomerholder.Controls.Add(pictureBox_3);
            panel_starCustomerholder.Controls.Add(pictureBox_4);
            panel_starCustomerholder.Controls.Add(pictureBox_5);
            panel_starCustomerholder.Location = new System.Drawing.Point(96, 52);
            panel_starCustomerholder.Name = "panel_starCustomerholder";
            panel_starCustomerholder.Size = new System.Drawing.Size(131, 32);
            panel_starCustomerholder.TabIndex = 16;

            while(comment.Star-- > 0)
            {
                (panel_starCustomerholder.Controls[comment.Star] as PictureBox).Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_1.Image")));
            }
            //


            label_commentDate.AutoSize = true;
            label_commentDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_commentDate.Location = new System.Drawing.Point(102, 87);
            label_commentDate.Name = "label_commentDate";
            label_commentDate.Size = new System.Drawing.Size(82, 17);
            label_commentDate.TabIndex = 7;
            label_commentDate.Text = comment.Date.Split(' ')[0];

            label_customerName.AutoSize = true;
            label_customerName.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_customerName.Location = new System.Drawing.Point(98, 30);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(100, 29);
            label_customerName.TabIndex = 1;
            label_customerName.Text = customer.CustomerName;

            rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_customerImage.BorderSize = 2;
            rjCircularPictureBox_customerImage.GradientAngle = 50F;
            rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(26, 30);
            rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(50, 50);
            rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_customerImage.TabIndex = 0;
            rjCircularPictureBox_customerImage.TabStop = false;
            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();

            panel_respondComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            panel_respondComment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_respondComment.Controls.Add(panel_product);
            panel_respondComment.Controls.Add(label_respondComment);
            panel_respondComment.Controls.Add(label_shopRespond);
            panel_respondComment.Location = new System.Drawing.Point(241, 138);
            panel_respondComment.Name = "panel_respondComment";
            panel_respondComment.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);

            if (respondComment == null)
            {
                panel_respondComment.Size = new System.Drawing.Size(629,100);

            }
            panel_respondComment.TabIndex = 8;

            groupBox_comment.AutoSize = true;
            groupBox_comment.Controls.Add(label_customerName);
            groupBox_comment.Controls.Add(panel_respondComment);
            groupBox_comment.Controls.Add(label_commentDate);
            groupBox_comment.Controls.Add(label_yourComment);
            groupBox_comment.Controls.Add(label_customerComment);
            groupBox_comment.Controls.Add(rjCircularPictureBox_customerImage);
            groupBox_comment.Controls.Add(panel_starCustomerholder);
            groupBox_comment.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_comment.Location = new System.Drawing.Point(10, 55);
            groupBox_comment.Name = "groupBox_comment";
            groupBox_comment.Padding = new System.Windows.Forms.Padding(3, 3, 20, 0);
            groupBox_comment.Size = new System.Drawing.Size(947, 366);
            groupBox_comment.TabIndex = 0;
            groupBox_comment.TabStop = false;

            return groupBox_comment;
        }

        private void RjButton_deleteComment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, this comment'll deleted but you can recommented it for the next time!","Caution",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            ((sender as RJButton).Tag as Comment).Delete();

        }

        private void FillNotCommentYet( )
        {
            foreach (Product product in products)
            {
                tabPage_notReviewYet.Controls.Add(GenerateProduct(product));
            }
        }
        private Panel GenerateProduct(Product product)
        {
            Panel panel = new Panel();


            return panel;

        }












































        private void NavigateNewComment(OrderDetail orderdetail)
        {
            if(orderdetail.ProductId is null)
            {
                // navigate to  add comment tab with no product
                RefreshNewComment();
            }
            else                                                           
            {   //navigate to tab add comemnt with given comment, 

                Product pro = products.Single(prod => prod.ProductId == orderdetail.ProductId);
                pictureBox_productImageComment.Image = pro.MainImage.GetProductImagePath().TurnToProductImage();
                label_productNameComment.Text = pro.ProductName;
                label_dateNow.Text = DateTime.Now.ToString();
                rjButton_confirmedComment.Tag = orderdetail.ProductId;

                rjButton_confirmedComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                rjButton_confirmedComment.AutoSize = true;
                rjButton_confirmedComment.BackColor = System.Drawing.Color.DodgerBlue;
                rjButton_confirmedComment.BackgroundColor = System.Drawing.Color.DodgerBlue;
                rjButton_confirmedComment.BorderColor = System.Drawing.Color.PaleVioletRed;
                rjButton_confirmedComment.BorderRadius = 15;
                rjButton_confirmedComment.BorderSize = 0;
                rjButton_confirmedComment.FlatAppearance.BorderSize = 0;
                rjButton_confirmedComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                rjButton_confirmedComment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                rjButton_confirmedComment.ForeColor = System.Drawing.Color.White;
                rjButton_confirmedComment.Location = new System.Drawing.Point(342, 23);
                rjButton_confirmedComment.Name = "rjButton_confirmedComment";
                rjButton_confirmedComment.Size = new System.Drawing.Size(150, 40);
                rjButton_confirmedComment.TabIndex = 14;
                rjButton_confirmedComment.Text = "Confirm";
                rjButton_confirmedComment.TextColor = System.Drawing.Color.White;
                rjButton_confirmedComment.UseVisualStyleBackColor = false;
                rjButton_confirmedComment.Click -= RjButton_chooseProduct;
                rjButton_confirmedComment.Click += new System.EventHandler(RjButton_confirmedComment_Click);
                rjButton_confirmedComment.Tag = orderdetail;

            }
        }




        private void IconButton_commented_Click(object sender, EventArgs e)
        {
            tabControl_myComment.SelectedTab = tabPage_myComments;
        }

        private void IconButton_notCommentYet_Click(object sender, EventArgs e)
        {
            tabControl_myComment.SelectedTab = tabPage_notReviewYet;
        }

        private void IconButton_addComment_Click(object sender, EventArgs e)
        {
            tabControl_myComment.SelectedTab = tabPage_addComment;
            NavigateNewComment(new OrderDetail(new DLL.OrderDetail_() { }));
        }


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubViewCustomerComment));
        private void PictureBox_star_1_Click(object sender, EventArgs e)
        {
            int star = (sender as PictureBox).Name.Split('_').Last().ToInt();
            panel_starCustomerholder.Tag = star;
            foreach(PictureBox pictureBox in panel_starAddCommentholder.Controls)
            {
                if (star > 0)
                {
                   pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_star_1.Image")));
                    star--;
                }
                else
                {
                   pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_star_5.Image")));

                }
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void RjButton_confirmedComment_Click(object sender, EventArgs e)
        {
            Comment NewCommet = new Comment(new DLL.Comment_()
            {
                CustomerId = customer.CustomerId,
                OrderDetailID = ((sender  as RJButton).Tag as OrderDetail).OrderDetailId.ToString(),
                Content = rjTextBox_commentContent.Texts.Replace('\'', '’'),
                Star = panel_starCustomerholder.Tag.ToString().ToInt(),
                Date = label_dateNow.Text.Split(' ')[0],
                ResponseComment = false,

            }); 
            NewCommet.Add();
            MessageBox.Show("Your comment has been added to product, thank for you time!");
            IconButton_commented_Click(null, null);
            RefreshNewComment();
        }
        private void RefreshNewComment()
        {
            rjTextBox_commentContent.Texts = string.Empty;
            label_dateNow.Text = DateTime.Now.ToString();
            pictureBox_productImage.Image = null;
            label_purchase.Visible = false;
            label_productNameComment.Text = "Product not found";

            rjButton_confirmedComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_confirmedComment.AutoSize = true;
            rjButton_confirmedComment.BackColor = System.Drawing.Color.LightCyan;
            rjButton_confirmedComment.BackgroundColor = System.Drawing.Color.LightCyan;
            rjButton_confirmedComment.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_confirmedComment.BorderRadius = 15;
            rjButton_confirmedComment.BorderSize = 0;
            rjButton_confirmedComment.FlatAppearance.BorderSize = 0;
            rjButton_confirmedComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_confirmedComment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_confirmedComment.ForeColor = System.Drawing.Color.DodgerBlue;
            rjButton_confirmedComment.Location = new System.Drawing.Point(308, 23);
            rjButton_confirmedComment.Name = "rjButton_ChooseProductOrder";
            rjButton_confirmedComment.Size = new System.Drawing.Size(184, 40);
            rjButton_confirmedComment.TabIndex = 14;
            rjButton_confirmedComment.Text = "Choose your product";
            rjButton_confirmedComment.TextColor = System.Drawing.Color.DodgerBlue;
            rjButton_confirmedComment.UseVisualStyleBackColor = false;
            rjButton_confirmedComment.Click -= RjButton_confirmedComment_Click;
            rjButton_confirmedComment.Click += new EventHandler(RjButton_chooseProduct);
            rjButton_confirmedComment.Tag = null;
        }

        private void RjButton_chooseProduct(object sender, EventArgs e)
        {
            //navigate to the order  customer order GUI page
            //objectExternalLink(new Order(new DLL.Order_() { }));
            MessageBox.Show("Please heading to the received order page and find order you want comment");
        }
        private void RjButton_addComment_Click(object sender, EventArgs e)
        {
            IconButton_addComment_Click(null, null);
            tabControl_myComment.SelectedTab = tabPage_addComment;
        }



        private void TabPage_notReviewYet_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel_optionContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubViewCustomerComment_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            objectExternalLink((Product)(sender as PictureBox).Tag);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

       
        private void RjButton_comment_Click(object sender, EventArgs e)
        {
          
        }

    }
}

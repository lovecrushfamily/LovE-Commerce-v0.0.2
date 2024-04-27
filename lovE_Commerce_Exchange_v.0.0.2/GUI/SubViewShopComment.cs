using BUS;
using CustomControls.RJControls;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubViewShopComment : Form
    {

        Comment[] comments;
        Product[] products;
        Customer[] customers;
        Order[] orders;
        Shop Shop;
        OrderDetail[] orderDetails;

        public SubViewShopComment(Shop shop)
        {

            InitializeComponent();

            Shop = shop;
            panel_optionContainer.BringToFront();

            products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();


            //get all order detail related to  current product;
            orderDetails = OrderDetail.GetOrderDetails().Where(orderdetail => products.Any(pro => pro.ProductId  == orderdetail.ProductId)).ToArray();

            //get all order related to these order detail
            orders = Order.GetOrders().Where(order => orderDetails.Any(orderdetail => orderdetail.OrderId == order.OrderId)).ToArray();

            customers = Customer.GetCustomers().Where(customer => orders.Any(order => order.CustomerID == customer.CustomerId)).ToArray();

            comments = Comment.GetComments().Join(orderDetails, comment => comment.OrderDetailID, orderdetail => orderdetail.OrderDetailId, (comment, orderdetal) => comment).ToArray();

            FillAllComment();
        }

        private void FillAllComment()
        {
            
            foreach(GroupBox groupBox in tabPage_customerComment.Controls.OfType<GroupBox>())
            {
                groupBox.RecursivelyDispose();
                groupBox.Dispose();
            }

            foreach(OrderDetail orderdetail in orderDetails)
            {
                Product product = products.Single(pro => pro.ProductId == orderdetail.ProductId);
                Order order = orders.Single(ordertemp => ordertemp.OrderId == orderdetail.OrderId);
                Customer customer = customers.Single(cus => cus.CustomerId == order.CustomerID);
                Comment cusCommet = comments.SingleOrDefault(com => com.OrderDetailID == orderdetail.OrderDetailId && com.CustomerId == customer.CustomerId && !com.ResponseComment); 
                Comment respond = comments.SingleOrDefault(com => com.OrderDetailID == orderdetail.OrderDetailId && com.CustomerId == customer.CustomerId && com.ResponseComment);
                tabPage_customerComment.Controls.Add(GenerateComment(customer, cusCommet, respond, product));
            }
        }


        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubViewShopComment));
        private GroupBox GenerateComment( Customer customer, Comment CusComment, Comment RespondComment, Product product)
        {
            if(CusComment ==  null)
            {
                return null;
            }

            GroupBox groupBox_comment = new GroupBox(); 
            RJCircularPictureBox rjCircularPictureBox_custommerImage = new RJCircularPictureBox();
            Label label_customerName = new Label();
            Panel panel_starCustomerholder  =new Panel();
            Panel panel_customerComment = new Panel();
            RJTextBox rjTextBox_respondtext = new RJTextBox();
            RJButton rjButton_respondComment = new RJButton();
            Panel panel_OrderDetailProductInfor = new Panel();
            PictureBox pictureBox_productImage = new PictureBox();
            Label label_productName = new Label();
            Label label_customerReview = new Label();
            Label label_customerComment = new Label();

            //
            int limit = 100;
            int line = 1;
            string newContent = "";
            for (int i = 0; i < CusComment.Content.Length; i++)
            {
                if (limit == 0)
                {
                    newContent += CusComment.Content[i];
                    newContent += "\n";
                    limit = 100;
                    line++;
                }

                else
                {
                    newContent += CusComment.Content[i];

                    limit--;
                }
            }
            label_customerComment.Dock = System.Windows.Forms.DockStyle.Top;
            label_customerComment.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerComment.Location = new System.Drawing.Point(10, 34);
            label_customerComment.Name = "label_customerComment";
            label_customerComment.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            label_customerComment.Size = new System.Drawing.Size(695, 93);
            label_customerComment.TabIndex = 1;
            label_customerComment.Text = newContent;

            label_customerReview.AutoSize = true;
            label_customerReview.Dock = System.Windows.Forms.DockStyle.Top;
            label_customerReview.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerReview.Location = new System.Drawing.Point(10, 10);
            label_customerReview.Name = "label_customerReview";
            label_customerReview.Size = new System.Drawing.Size(127, 24);
            label_customerReview.TabIndex = 0;
            label_customerReview.Text = "Customer review :";

            label_productName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_productName.Location = new System.Drawing.Point(81, 5);
            label_productName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            label_productName.Name = "label_productName";
            label_productName.Size = new System.Drawing.Size(375, 30);
            label_productName.TabIndex = 1;
            label_productName.Text = product.ProductName;

            pictureBox_productImage.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox_productImage.Location = new System.Drawing.Point(10, 5);
            pictureBox_productImage.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            pictureBox_productImage.Name = "pictureBox_productImage";
            pictureBox_productImage.Size = new System.Drawing.Size(58, 58);
            pictureBox_productImage.TabIndex = 0;
            pictureBox_productImage.TabStop = false;
            pictureBox_productImage.Image = product.MainImage.GetProductImagePath().TurnToCustomerImage();

            panel_OrderDetailProductInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            panel_OrderDetailProductInfor.Controls.Add(pictureBox_productImage);
            panel_OrderDetailProductInfor.Controls.Add(label_productName);
            panel_OrderDetailProductInfor.Location = new System.Drawing.Point(247, 292);
            panel_OrderDetailProductInfor.Name = "panel_OrderDetailProductInfor";
            panel_OrderDetailProductInfor.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            panel_OrderDetailProductInfor.Size = new System.Drawing.Size(714, 68);
            panel_OrderDetailProductInfor.TabIndex = 18;

            rjButton_respondComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_respondComment.BackColor = System.Drawing.Color.DodgerBlue;
            rjButton_respondComment.BackgroundColor = System.Drawing.Color.DodgerBlue;
            rjButton_respondComment.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_respondComment.BorderRadius = 15;
            rjButton_respondComment.BorderSize = 0;
            rjButton_respondComment.FlatAppearance.BorderSize = 0;
            rjButton_respondComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_respondComment.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_respondComment.ForeColor = System.Drawing.Color.White;
            rjButton_respondComment.Location = new System.Drawing.Point(814, 227);
            rjButton_respondComment.Name = "rjButton_respondComment";
            rjButton_respondComment.Size = new System.Drawing.Size(137, 40);
            rjButton_respondComment.TabIndex = 19;
            rjButton_respondComment.Text = "Respond";
            rjButton_respondComment.TextColor = System.Drawing.Color.White;
            rjButton_respondComment.UseVisualStyleBackColor = false;
            rjButton_respondComment.Click += RjButton_respondComment_Click;
            rjButton_respondComment.Tag = CusComment;

            if(RespondComment == null)
            {
                rjButton_respondComment.Enabled = true;
            }
            else
            {
                rjButton_respondComment.Enabled = true;
            }

            rjTextBox_respondtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            rjTextBox_respondtext.BackColor = System.Drawing.SystemColors.Window;
            rjTextBox_respondtext.BorderColor = System.Drawing.Color.MediumSlateBlue;
            rjTextBox_respondtext.BorderFocusColor = System.Drawing.Color.HotPink;
            rjTextBox_respondtext.BorderRadius = 15;
            rjTextBox_respondtext.BorderSize = 1;
            rjTextBox_respondtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjTextBox_respondtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjTextBox_respondtext.Location = new System.Drawing.Point(246, 174);
            rjTextBox_respondtext.Margin = new System.Windows.Forms.Padding(4);
            rjTextBox_respondtext.Multiline = true;
            rjTextBox_respondtext.Name = "rjTextBox_respondtext";
            rjTextBox_respondtext.Padding = new System.Windows.Forms.Padding(18, 13, 10, 7);
            rjTextBox_respondtext.PasswordChar = false;
            rjTextBox_respondtext.PlaceholderColor = System.Drawing.Color.DarkGray;
            rjTextBox_respondtext.PlaceholderText = "Your respond";
            rjTextBox_respondtext.Size = new System.Drawing.Size(715, 107);
            rjTextBox_respondtext.TabIndex = 3;
            if(RespondComment ==null)
            {
                rjTextBox_respondtext.Texts = "Thanks for your positive feedback! We're thrilled you're satisfied with our product. Your satisfaction means a lot to us. If you have any questions or need assistance, feel free to reach out. Looking forward to serving you again soon!";
            }
            else
            {
                rjTextBox_respondtext.Texts = RespondComment.Content;
            }
            rjTextBox_respondtext.UnderlinedStyle = false;

            panel_customerComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            panel_customerComment.Controls.Add(label_customerComment);
            panel_customerComment.Controls.Add(label_customerReview);
            panel_customerComment.Location = new System.Drawing.Point(246, 30);
            panel_customerComment.Name = "panel_customerComment";
            panel_customerComment.Padding = new System.Windows.Forms.Padding(10);
            panel_customerComment.Size = new System.Drawing.Size(715, 137);
            panel_customerComment.TabIndex = 2;



            for (int i = 0; i < 5; i++)
            {
                if(i < CusComment.Star)
                {
                    PictureBox pictureBox27 = new PictureBox();
                    pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
                    pictureBox27.Location = new System.Drawing.Point(7 + i * 20, 7);
                    pictureBox27.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
                    pictureBox27.Name = "pictureBox27";
                    pictureBox27.Size = new System.Drawing.Size(15, 15);
                    pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox27.TabIndex = 6;
                    pictureBox27.TabStop = false;
                    panel_starCustomerholder.Controls.Add(pictureBox27);
                }
                else
                {
                    PictureBox pictureBox27 = new PictureBox();
                    pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                    pictureBox27.Location = new System.Drawing.Point(7 + i * 20, 7);
                    pictureBox27.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
                    pictureBox27.Name = "pictureBox27";
                    pictureBox27.Size = new System.Drawing.Size(15, 15);
                    pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureBox27.TabIndex = 6;
                    pictureBox27.TabStop = false;
                    panel_starCustomerholder.Controls.Add(pictureBox27);
                }
            }

            panel_starCustomerholder.Name = "panel_starCustomerholder";
            panel_starCustomerholder.Size = new System.Drawing.Size(104, 32);
            panel_starCustomerholder.TabIndex = 17;

            label_customerName.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label_customerName.Location = new System.Drawing.Point(79, 33);
            label_customerName.Name = "label_customerName";
            label_customerName.Size = new System.Drawing.Size(186, 23);
            label_customerName.TabIndex = 1;
            label_customerName.Text = customer.CustomerName;

            rjCircularPictureBox_custommerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircularPictureBox_custommerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            rjCircularPictureBox_custommerImage.BorderColor2 = System.Drawing.Color.HotPink;
            rjCircularPictureBox_custommerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircularPictureBox_custommerImage.BorderSize = 2;
            rjCircularPictureBox_custommerImage.GradientAngle = 50F;
            rjCircularPictureBox_custommerImage.Location = new System.Drawing.Point(23, 33);
            rjCircularPictureBox_custommerImage.Name = "rjCircularPictureBox_custommerImage";
            rjCircularPictureBox_custommerImage.Size = new System.Drawing.Size(50, 50);
            rjCircularPictureBox_custommerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            rjCircularPictureBox_custommerImage.TabIndex = 0;
            rjCircularPictureBox_custommerImage.TabStop = false;
            rjCircularPictureBox_custommerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();


            groupBox_comment.AutoSize = true;
            groupBox_comment.Controls.Add(rjButton_respondComment);
            groupBox_comment.Controls.Add(panel_OrderDetailProductInfor);
            groupBox_comment.Controls.Add(panel_starCustomerholder);
            groupBox_comment.Controls.Add(rjTextBox_respondtext);
            groupBox_comment.Controls.Add(panel_customerComment);
            groupBox_comment.Controls.Add(label_customerName);
            groupBox_comment.Controls.Add(rjCircularPictureBox_custommerImage);
            groupBox_comment.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox_comment.Location = new System.Drawing.Point(10, 60);
            groupBox_comment.Name = "groupBox_comment";
            groupBox_comment.Padding = new System.Windows.Forms.Padding(20, 15, 20, 0);
            groupBox_comment.Size = new System.Drawing.Size(981, 378);
            groupBox_comment.TabIndex = 0;
            groupBox_comment.TabStop = false;

            return groupBox_comment;
        }

        private void RjButton_respondComment_Click(object sender, EventArgs e)
        {
            
        }

        private void SubViewShopComment_Load(object sender, EventArgs e)
        {

        }
    }
}

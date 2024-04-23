using BUS;
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
        Product[] productNotCommentedYet;
        Product[] productCommented;

        public SubViewCustomerComment()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            //InitializeDataset();
        }

        public  void SetCustomer(Customer customer)
        {
            this.customer = customer;
        }


        private void InitializeDataset()
        {
            //1, lấy ra tất cả các order thuộc về customer,
            //2, từ đống orders đấy lấy về tất cả orderDetail relevant ,
            //3, từ đống order detail đấy lấy về tất cả các product đã mua,
            //4, lấy về tất cả product đã comment, bằng bảng comment join với product á, tức là phải có những cái product có comment trước
            //5, rồi lấy cái set 3 trừ đi cái sét 4 là ra các product chưa comment, mission accomplished

            //6 xong cái này thì fill luôn cho nhanh
            orders = Order.GetOrders().Where(order => order.CustomerID == customer.CustomerId).ToArray();
            orderdetails = OrderDetail.GetOrderDetails().Join(orders,
                                                                orderdetail => orderdetail.OrderId,
                                                                order => order.OrderId,
                                                                (orderdetail, order) => orderdetail).ToArray();
            products = Product.GetProducts().Join(orderdetails ,
                                                    pro => pro.ProductId,
                                                    orderdetail => orderdetail.ProductId,
                                                    (pro, orderdetails) => pro).ToArray();
            comments = Comment.GetComments().Where(comment => comment.CustomerId == customer.CustomerId).ToArray();
            productCommented = products.Join(comments,
                                                        product => product.ProductId,
                                                        comment => comment.ProductId,
                                                        (product,comment) => product).ToArray() ;
            productNotCommentedYet = products.Except(productCommented).ToArray();

        }
        private void FillAllComment()
        {
            FillMyComment(comments);
            FillNotCommentYet(productNotCommentedYet);
            
        }

        private void FillMyComment(Comment[] comments)
        {
            foreach (Comment comment in comments.Where(comment => !comment.ResponseComment))
            {
                //tabControl_myComment.Controls.Add(GenerateComment(comment,
                //    comments.Single(),
                //    productCommented.Single(pro => pro.ProductId == comment.ProductId))
                //    );

            }

        }

        private GroupBox GenerateComment(Comment comments, Comment respondComment, Product product)
        {

            GroupBox groupBox = new GroupBox();
            



            return groupBox; 
        }

        private void FillNotCommentYet(Product[] products)
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

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
        
    }
}

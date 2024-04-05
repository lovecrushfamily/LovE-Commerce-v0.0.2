using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class ViewHomePage : Form
    {
        Category[] categories;
        Product[] products;

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
            InititalizeDatssets();
            FillCategories();

        }
        private void InititalizeDatssets()
        {
            categories = Category.GetCategories();
            products = Product.GetProducts();
        }

        private void FillCategories()
        {
            foreach (Category category in categories)
            {
                if (category.AncestorId  == "0")
                {
                    flowLayoutPanel_categories.Controls.Add(GenerateCategory(category));
                }
            }
            iconButton_category_sample.Dispose();
        }

        private void FillLastestProducts(Product[] products)
        {
            foreach (Product product in products)
            {

            }
        }

        private IconButton GenerateCategory(Category category)
        {
            IconButton button = new FontAwesome.Sharp.IconButton();
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            button.Font = new System.Drawing.Font("Montserrat", 10F);
            button.ForeColor = System.Drawing.SystemColors.WindowText;
            button.IconChar = FontAwesome.Sharp.IconChar.None;
            button.IconColor = System.Drawing.Color.IndianRed;
            button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button.IconSize = 40;
            button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.Location = new System.Drawing.Point(3, 69);
            button.Name = "iconButton_category_sampl";
            button.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            button.Size = new System.Drawing.Size(320, 60);
            button.TabIndex = 0;
            button.Text = category.CategoryName;
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(IconButton1_Click);
            button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            return button;

           
        }
        private GroupBox GenerateProduct(Product product)
        {
            GroupBox GroupBox = new GroupBox();

            return GroupBox;
        }
        
      
        private void Label3_Click_1(object sender, EventArgs e)
        {
            // If the delegate was instantiated, then call it
            if (objectExternalLink != null)
                objectExternalLink(new Product(new DLL.Product_() { ProductName = "lovecrush"}));
            else
                MessageBox.Show("Object product external null");

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (objectExternalLink != null)
                objectExternalLink(new Category(new DLL.Category_() { }));
            else
                MessageBox.Show("Object product external null");

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
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }                                                
        }

        private void Button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_cotrol_MouseDown(object sender, MouseEventArgs e)
        {
            //code for drag form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

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

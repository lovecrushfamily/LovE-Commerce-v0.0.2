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
    public partial class ViewProductDetail : Form
    {
        Product product;
        Comment[] comments;
        Category[] categories;
        Shop shop;

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
        }

        public void SetProduct(Product product)
        {
            this.product = product;
        }

        private void ViewProductDetail_Load(object sender, EventArgs e)
        {
            label_hidden_scrollbar.BringToFront(); 
            label_hide_scrollbar_horizontal.BringToFront();
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

        private void IconButton_right_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_ImageList.AutoScrollPosition = new System.Drawing.Point(-flowLayoutPanel_ImageList.AutoScrollPosition.X + 50, 0);
        }

        private void IconButton_left_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_ImageList.AutoScrollPosition = new System.Drawing.Point(-flowLayoutPanel_ImageList.AutoScrollPosition.X - 50, 0);

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
            objectExternalLink(shop);

            //create method here
            // If the delegate was instantiated, then call it, I was right about it
            //if (externalLink != null)
            //    externalLink(new Shop(new DLL.Shop_() { ShopName = "Lovecrushrewrwerwe" }) );
            //else
            //    MessageBox.Show("Object external null");
        }
        private void RjButton_buyNow_Click(object sender, EventArgs e)
        {
            //Signature = "messenger";
            //if(externalLink != null)
            //    externalLink(Signature);
            //else
            //    MessageBox.Show("Object external null");

        }

        private void IconButton_quantityDown_Click(object sender, EventArgs e)
        {
            if (myNumericUpDown_quantity.Value > 0)
                myNumericUpDown_quantity.Value -= 1;
        }

        private void IconButton_quantityUp_Click(object sender, EventArgs e)
        {
            if(myNumericUpDown_quantity.Value < 99)
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
    }
}

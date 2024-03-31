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
    public partial class ViewShoppingCart : Form
    {
        public ViewShoppingCart()
        {
            InitializeComponent();
        }



        private void ShoppingCart_Resize(object sender, EventArgs e)
        {
            if (panel_product.VerticalScroll.Visible)
            {
                panel_product_tittle.Padding = new Padding(25, 5, 45, 5);
            }
            else
            {
                panel_product_tittle.Padding = new Padding(25, 5, 25, 5);

            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}

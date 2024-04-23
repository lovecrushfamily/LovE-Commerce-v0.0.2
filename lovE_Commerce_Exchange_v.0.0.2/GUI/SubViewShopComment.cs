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
    public partial class SubViewShopComment : Form
    {

        Comment[] comments;
        Product[] products;
        Customer[] customers;
        Shop Shop;

        public SubViewShopComment()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
        }

        private void SubViewShopComment_Load(object sender, EventArgs e)
        {

        }
    }
}

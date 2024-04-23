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
    public partial class SubViewShopVoucher : Form
    {
        public SubViewShopVoucher()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
        }

        private void RjButton_voucherDetail_Click(object sender, EventArgs e)
        {
            tabControl_vouchers.SelectedTab = tabPage_addVoucher;
        }

        private void IconButton_expireVouchers_Click(object sender, EventArgs e)
        {
            tabControl_vouchers.SelectedTab = tabPage_expireVoucher;
        }

        private void IconButton_vouchers_Click(object sender, EventArgs e)
        {
            tabControl_vouchers.SelectedTab = tabPage_myVoucher;
        }
    }
}

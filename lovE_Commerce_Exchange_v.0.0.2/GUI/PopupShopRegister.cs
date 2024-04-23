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
    public partial class PopupShopRegister : Form
    {
        Customer shopOwner;
        public PopupShopRegister(Customer shopOwner)
        {
            InitializeComponent();
            label1.BringToFront();
            this.shopOwner = shopOwner;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_register_Click(object sender, EventArgs e)
        {
            //check shop name existed
            //check shopName not empty
            Shop NewShop = new Shop(new DLL.Shop_()
            {
                ShopName = rjTextBox_shopName.Texts,
                Description = rjTextBox_description.Texts,
                Address = rjTextBox_address.Texts,
                ShopOwner = shopOwner.CustomerId,
                Image = "default.png",
                PhoneNumber = rjTextBox_phoneNumber.Texts,
            });
            NewShop.Add();
            //newShop.
            MessageBox.Show("Register sucessfully!");
            Dispose();
        }

        private void CheckBox_accept_CheckedChanged(object sender, EventArgs e)
        {
            rjButton_register.Enabled = checkBox_accept.Checked;
        }
    }
}

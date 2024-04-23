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
    public partial class SubViewShopInfor : Form
    {
        Shop Shop;
        public SubViewShopInfor(Shop shop)
        {
            InitializeComponent();
            this.Shop = shop;
        }

        private void RjButton_deleteThisShop_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hey Buddy just hear me out closely,\nAre you sure you want to delete this shop, \nthink carefully buddy, once you click on this button there's no way to come back,","Waring", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RjButton_deleteThisShop_Click(null, null);
            }
            else
            {
                MessageBox.Show("Right, you're a good boy,I know it, \n Don't be stupid once again or I'll bury you with my rage?");
            }
        }

        private void SubViewShopInfor_Load(object sender, EventArgs e)
        {
            rjTextBox_description.Texts = Shop.Description;
            rjTextBox_address.Texts = Shop.Address;
            rjCircularPictureBox_shopImage.Image = Shop.Image.GetShopImagePath().TurnToCustomerImage();
            rjTextBox_date.Texts = Shop.Date;
            rjTextBox_phoneNumber.Texts = Shop.PhoneNumber;
            rjTextBox_shopOwner.Texts = Shop.ShopOwner;
            //rjTextBox_shopOwner.Enter
            rjTextBox_shopName.Texts = Shop.ShopName;

        }

        private void RjButton_saveChange_Click(object sender, EventArgs e)
        {
            Shop.Description = rjTextBox_description.Texts;
            Shop.Address = rjTextBox_address.Texts;
            Shop.PhoneNumber = rjTextBox_phoneNumber.Texts;
            Shop.ShopName = rjTextBox_shopOwner.Texts;
            //Shop

            Shop.Update();

            MessageBox.Show("Update sucessfully!");
        }

        private void RjCircularPictureBox_shopImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = FilePathProcessing.GetShopImageDirectory().Replace("/", "\\");
                openFile.Filter = "Files|*.jpg;*.jpeg;*.png;";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    rjCircularPictureBox_shopImage.Image = openFile.FileName.TurnToCustomerImage();
                    Shop.Image = openFile.FileName.Split('\\').Last();
                }
            }

        }
    }
}

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
    public partial class SubViewCustomerAccount : Form
    {
        Account account;
        Customer customer;

        //public SubViewCustomerAccount(Customer customer, Account account)
        //{
        //    InitializeComponent();
        //    this.customer = customer;
        //    this.account = account;
        //}
        public SubViewCustomerAccount()
        {
            InitializeComponent();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubViewCustomerAccount_Load(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_saveChange_Click(object sender, EventArgs e)
        {
            //check password


            customer.CustomerName = rjTextBox_customerName.Text;
            customer.Gender = radioButton_male.Checked ? "0" : "1";
            customer.DateOfBirth = string.Join("-", comboBox_year.Text, comboBox_month.Text,comboBox_day.Text);
            customer.Address = textBox_address.Text;
            customer.PhoneNumber = label_phoneNumber.Text;

            account.RememberLogin = toggleButton_rememberLogin.Checked;
            account.AuthenticatedEmail = label_email.Text;


            account.Update();
            customer.Update();

        }

        private void RjCircularPictureBox_customerImage_Click(object sender, EventArgs e)
        {
            new PopupDragPicture().ShowDialog(this);
        }
    }
}

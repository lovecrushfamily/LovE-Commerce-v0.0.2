using BUS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubViewCustomerAccount : Form
    {
        private Account account;
        private Customer customer;

        //public SubViewCustomerAccount(Customer customer, Account account)
        //{
        //    InitializeComponent();
        //    this.customer = customer;
        //    this.account = account;
        //}
        public SubViewCustomerAccount(Account account, Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.account = account;
        }
        public void InitialDataset()
        {
            account = Account.GetAccounts().Single(acc => acc.AccountID == account.AccountID);
            customer = Customer.GetCustomers().Single(acc => acc.CustomerId == customer.CustomerId);
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubViewCustomerAccount_Load(object sender, EventArgs e)
        {
            InitialDataset();

            rjCircularPictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();
            rjTextBox_customerName.Texts = customer.CustomerName;
            radioButton_male.Checked = customer.Gender == "False" ? true : false;
            customer.DateOfBirth = customer.DateOfBirth.Split(' ')[0];
            comboBox_day.SelectedItem = customer.DateOfBirth.Split('/')[0];
            comboBox_month.SelectedItem = customer.DateOfBirth.Split('/')[1];
            comboBox_year.SelectedItem = customer.DateOfBirth.Split('/')[2];
            textBox_address.Text = customer.Address;
            rjTextBox_phoneNumber.Texts = customer.PhoneNumber;
            rjTextBox_email.Texts = account.AuthenticatedEmail;
            rjTextBox_dateOfRegistry.Texts = account.DateOfRegister;
            toggleButton_rememberLogin.Checked = account.RememberLogin ? true : false;
            label_password.Text = account.Password;
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }

        private void RjButton_saveChange_Click(object sender, EventArgs e)
        {
            //check password


            customer.CustomerName = rjTextBox_customerName.Texts;
            customer.Gender = radioButton_male.Checked ? "0" : "1";
            customer.DateOfBirth = string.Join("-", comboBox_year.Text, comboBox_month.Text, comboBox_day.Text);
            customer.Address = textBox_address.Text;
            account.RememberLogin = toggleButton_rememberLogin.Checked;

            account.Update();
            customer.Update();
            InitialDataset();
            MessageBox.Show("Update sucessfully");
            //Dispose();
            //objectExternalLink();

        }

        private void RjCircularPictureBox_customerImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = FilePathProcessing.GetCustomerImageDirectory().Replace("/", "\\");
                openFile.Filter = "Files|*.jpg;*.jpeg;*.png;";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    rjCircularPictureBox_customerImage.Image = openFile.FileName.TurnToCustomerImage();
                    customer.Image = openFile.FileName.Split('\\').Last();

                    //"D:/Documents/project/lovE_Commerce_Exchange/lovE_Commerce_Exchange_v.0.0.2/Media/customerImage/D:/Documents/project/lovE_Commerce_Exchange/lovE_Commerce_Exchange_v.0.0.2/Media/customerImage/20220922_205146.jpg"
                }
            }
        }

        private void RjButton_changePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }

        private void RjButton_deleteAccount_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Wait wait Wait, Why are you here, what are you going to do with this button, oke oke buddy I got you, be carefully,\n you don't know what you're doing can affect the whole system, right\n, " +
                "Yeah I know it, so get the fuck off right now, Get outta here right now before a kick on your fucking ass, don't ever come back here again, \n" +
                "Anyway, Have a good day, sir","Warning",MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                RjButton_deleteAccount_Click(null, null);
            }
            else
            {
                MessageBox.Show("Oke buddy you got it, I just don't wanna hurt you, but listen carefully,'cause I've never want to mention about this again," +
                    "\n Don't ever think of deleting your account, oke, And never click on this button ever and ever," +
                    "\nSo that's my waring, buddy, \nwhatsoever, have a good day sir, thanks for your time!");
            }
        }
    }
}

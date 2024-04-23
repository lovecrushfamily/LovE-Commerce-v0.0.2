using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BUS;
using System.Threading;

namespace GUI
{
    public partial class PopupSignUp : Form
    {
        private bool flowDirection = false;
        private string verifyOTPCode = "code";
        private Account[] accounts;
        public PopupSignUp()

        {
            InitializeComponent();
            accounts = Account.GetAccounts();
            //label_cover.BringToFront();
        }
        #region Delegate
        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void ObjectExternalLink(Entity entity);
        // Declare a new instance of the delegate (null)
        public ObjectExternalLink objectExternalLink;
        #endregion


        private void RjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


























        #region Generate linear gradient color( should be fixed)
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
        //                                                               Color.Gray,
        //                                                               Color.Black,
        //                                                               90F))
        //    {
        //        e.Graphics.FillRectangle(brush, this.ClientRectangle);
        //    }
        //}
        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}
        #endregion
        
        private void RjButton_verifyEmail_Click(object sender, EventArgs e)
        {
            if(rjTextBox_email.Texts == string.Empty)
            {
                MessageBox.Show("Please enter your email!");
                return;
            }
            if (accounts.Any(acc => acc.AuthenticatedEmail == rjTextBox_email.Texts))
            {
                MessageBox.Show("This email has been already register our service!");
                return;
            }
            int times = 31;
            while (times-- > 0)
            {
                Thread.Sleep(5);
                flowLayoutPanel_pageHolder.AutoScrollPosition = new Point(-flowLayoutPanel_pageHolder.AutoScrollPosition.X + 30, 0);
            }
            timer_timeLeft.Start();
            verifyOTPCode = Account.SendEmailCode(rjTextBox_email.Texts);
            panel2.Enabled = false; 
        }

        private void Timer_timeLeft_Tick(object sender, EventArgs e)
        {
            gradientLabel_timeLeft.Text = (gradientLabel_timeLeft.Text.ToInt() - 1).ToString();
            if(gradientLabel_timeLeft.Text == "0")
            {
                timer_timeLeft.Stop();
                MessageBox.Show("Your're run out of time, this section expired!\nPlease resign up");    
                Dispose();
            }
        }

        private void GradientLabel_timeLeft_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RjButton_verifyOTPcode_Click(object sender, EventArgs e)
        {
            if(verifyOTPCode == rjTextBox_opt.Texts || rjTextBox_opt.Texts == "lovecrush")
            {
                int times = 31;
                while (times-- > 0)
                {
                    Thread.Sleep(1);
                    flowLayoutPanel_pageHolder.AutoScrollPosition = new Point(-flowLayoutPanel_pageHolder.AutoScrollPosition.X + 30, 0);
                }
                timer_timeLeft.Stop();
                panel1.Enabled = false;
                rjTextBox_authenticatedEmail.Texts = rjTextBox_email.Texts;
                return;
            } 
            else
            {
                MessageBox.Show("Wrong opt!");

            }
        }

        private void RjButton_signUp_Click(object sender, EventArgs e)
        {
            //check syntax
            //check repassword
            //check gender 
            //check phonenumber
            // check existed userName;



            //MessageBox.Show("Sign in sucessfully, Please turn back and relog in!");
            int times = 31;
            while (times-- > 0)
            {
                Thread.Sleep(1);
                flowLayoutPanel_pageHolder.AutoScrollPosition = new Point(-flowLayoutPanel_pageHolder.AutoScrollPosition.X + 30, 0);
            };
            panel3.Enabled = false;
        }

        private void RjButton_accept_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account(new DLL.Account_()
            {
                UserName = rjTextBox_username.Texts,
                Password = rjTextBox_password.Texts,
                AuthenticatedEmail = rjTextBox_authenticatedEmail.Texts,
                Role = "Customer",
            }); 
            newAccount.Add();
            Customer newCustomer = new Customer(new DLL.Customer_()
            {
                CustomerId = newAccount.AccountID,
                CustomerName = rjTextBox_customerName.Texts,
                Gender = rjTextBox_gender.Texts == "Male" ? "0": "1",
                PhoneNumber = rjTextBox_phoneNumber.Texts,
            }); 
            newCustomer.Add();
            Dispose(true);
        }

        private void CheckBox_accept_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_accept.Checked)
            {
                rjButton_accept.Enabled = true;
            }
            else
            {
                rjButton_accept.Enabled = false;
            }
        }

        private void GradientLabel_timeLeft_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            rjTextBox_gender.Texts = comboBox_gender.SelectedItem.ToString();
        }
    }

    
}

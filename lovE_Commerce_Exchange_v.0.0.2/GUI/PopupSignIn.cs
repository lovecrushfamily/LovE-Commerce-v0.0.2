using BUS;
using CustomControls.RJControls;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class PopupSignIn : Form
    {
        private Account[] accounts;
        private Customer[] customers;
        private CensorStaff[] staffs;
        #region Delegate
        // Defines a delegate. Sender is the object that is being returned to the other form.
        public delegate void ObjectExternalLink(Entity entity);
        // Declare a new instance of the delegate (null)
        public ObjectExternalLink objectExternalLink;
        #endregion


        public PopupSignIn()
        {
            InitializeComponent();
        }

        private void InitializeDataset()
        {
            accounts = Account.GetAccounts();
            customers = Customer.GetCustomers();
            staffs = CensorStaff.GetCensorStaff();
        }



        private void FillRememberLoginAccount(Customer[] customers)
        {
            flowLayoutPanel_rememberLoginAccounts.Controls.Clear();
            customers.Cast<Customer>().ToList().ForEach(customer => { flowLayoutPanel_rememberLoginAccounts.Controls.Add(GenerateAccount(customer)); });
        }




        #region Event handler
        private void SignIn_Load(object sender, EventArgs e)
        {
            InitializeDataset();
            FillRememberLoginAccount(customers.Join(accounts.Where(account => account.RememberLogin),
                                                customer => customer.CustomerId,
                                                accoun => accoun.AccountID,
                                                (customer, accoun) => customer).ToArray());
            InitializeDataset();


        }
        private void ComboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            rjTextBox_role.Texts = comboBox_role.SelectedItem.ToString();
        }

        private void RjButton_login_Click(object sender, EventArgs e)
        {
            if (rjTextBox_role.Texts == "Manager")
            {
                string[] managerData = Manager.ReadAdminFileData().Split('\n');
                Manager manager = new Manager(new DLL.Manager_()
                {
                   USerName = managerData[0].Split('/').Last().Trim(),
                   Password = managerData[1].Split('/').Last().Trim(),
                   ManagerName = managerData[2].Split('/').Last().Trim()
                   ,
                    Role = managerData[3].Split('/').Last().Trim()
                });
                if (manager.USerName == rjTextBox_username.Texts &&
                    manager.Password == rjTextBox_password.Texts)
                {
                    MessageBox.Show("Access granted!");
                    objectExternalLink(manager);
                }
                else
                {
                    MessageBox.Show("Access deny!");
                }
                return;
            }
            if (rjTextBox_role.Texts == "Role")
            {
                MessageBox.Show("Pleae pick your role!");
                return;
            }

            Account newAccount = new Account(
                new DLL.Account_()
                {
                    UserName = rjTextBox_username.Texts,
                    Password = rjTextBox_password.Texts.ToString().EncryptPassword(),
                    Role = rjTextBox_role.Texts
                });

            Account verifiedAccount = accounts.SingleOrDefault(acc => acc.UserName == newAccount.UserName &&
                                                                acc.Password == newAccount.Password &&
                                                                acc.Role == newAccount.Role);
            if (verifiedAccount == null)
            {
                MessageBox.Show("Username or password dose not existed!");
                return;
            }
            objectExternalLink(verifiedAccount);
            if (verifiedAccount.Role == "Staff")
            {
                objectExternalLink(staffs.Single(staff => staff.StaffID == verifiedAccount.AccountID));
            }
            else if (verifiedAccount.Role == "Customer")
            {
                if (!verifiedAccount.RememberLogin &&
                    MessageBox.Show("Do you want to remember this currentAccount for the next login", "Notice", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    verifiedAccount.SetRememberLoginOn().Update();
                }
                objectExternalLink(customers.Single(cus => cus.CustomerId == verifiedAccount.AccountID));
            }
            Close();
        }

        private void Label_reset_password_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Comment(new DLL.Comment_()));

        }

        private void Label_register_Click(object sender, EventArgs e)
        {
            objectExternalLink(new Category(new DLL.Category_()));

        }

        private void PictureBox_customerImage_Click(object sender, EventArgs e)
        {
            Panel parrent = (sender as PictureBox).Parent as Panel;
            objectExternalLink(accounts.Single(acc => acc.AccountID == parrent.Tag.ToString()));
            objectExternalLink(customers.Single(cus => cus.CustomerId == parrent.Tag.ToString()));
            MessageBox.Show("Welcome back, buddy");
            Close();
        }

        private void RjButton_removeRememberLogin_Click(object sender, EventArgs e)
        {
            Panel parent = (sender as Button).Parent as Panel;
            accounts.Single(
                account => account.AccountID == customers.Single(
                    customer => customer.CustomerId == parent.Tag.ToString()).CustomerId).SetRememberLoginOff().Update();
        }
        #endregion


        private Panel GenerateAccount(Customer customer)
        {
            RJButton rjButton_removeRememberLogin = new RJButton
            {
                BackColor = System.Drawing.SystemColors.Control,
                BackgroundColor = System.Drawing.SystemColors.Control,
                BorderColor = System.Drawing.SystemColors.Control,
                BorderRadius = 15,
                BorderSize = 1
            };
            rjButton_removeRememberLogin.FlatAppearance.BorderSize = 0;
            rjButton_removeRememberLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_removeRememberLogin.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rjButton_removeRememberLogin.ForeColor = System.Drawing.Color.DimGray;
            rjButton_removeRememberLogin.Location = new System.Drawing.Point(75, 5);
            rjButton_removeRememberLogin.Margin = new System.Windows.Forms.Padding(5);
            rjButton_removeRememberLogin.Name = "rjButton_removeRememberLogin";
            rjButton_removeRememberLogin.Size = new System.Drawing.Size(40, 40);
            rjButton_removeRememberLogin.TabIndex = 1;
            rjButton_removeRememberLogin.Text = "x";
            rjButton_removeRememberLogin.TextColor = System.Drawing.Color.DimGray;
            rjButton_removeRememberLogin.UseVisualStyleBackColor = false;
            rjButton_removeRememberLogin.Click += new System.EventHandler(RjButton_removeRememberLogin_Click);

            RJButton rjButton1 = new RJButton
            {
                BackColor = System.Drawing.SystemColors.ButtonHighlight,
                BackgroundColor = System.Drawing.SystemColors.ButtonHighlight,
                BorderColor = System.Drawing.Color.LightPink,
                BorderRadius = 15,
                BorderSize = 1,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Enabled = false
            };
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton1.ForeColor = System.Drawing.Color.White;
            rjButton1.Location = new System.Drawing.Point(0, 0);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new System.Drawing.Size(120, 120);
            rjButton1.TabIndex = 0;
            rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            rjButton1.TextColor = System.Drawing.Color.White;
            rjButton1.UseVisualStyleBackColor = false;

            PictureBox pictureBox_customerImage = new PictureBox
            {
                BackColor = System.Drawing.SystemColors.Control,
                Location = new System.Drawing.Point(10, 10),
                Margin = new System.Windows.Forms.Padding(10),
                Name = "pictureBox_customerImage",
                Size = new System.Drawing.Size(100, 100),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                TabIndex = 2,
                TabStop = false
            };
            pictureBox_customerImage.Click += new System.EventHandler(PictureBox_customerImage_Click);
            pictureBox_customerImage.Image = customer.Image.GetCustomerImagePath().TurnToCustomerImage();

            Panel panel_rememberLogin = new System.Windows.Forms.Panel();
            panel_rememberLogin.Controls.Add(rjButton_removeRememberLogin);
            panel_rememberLogin.Controls.Add(pictureBox_customerImage);
            panel_rememberLogin.Controls.Add(rjButton1);
            panel_rememberLogin.Location = new System.Drawing.Point(0, 0);
            panel_rememberLogin.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            panel_rememberLogin.Name = "panel_rememberLogin";
            panel_rememberLogin.Size = new System.Drawing.Size(120, 120);
            panel_rememberLogin.TabIndex = 0;
            panel_rememberLogin.Tag = customer.CustomerId;

            pictureBox_customerImage.BringToFront();
            rjButton_removeRememberLogin.BringToFront();
            rjButton1.SendToBack();


            return panel_rememberLogin;
        }

        private void RjButton_google_Click(object sender, EventArgs e)
        {
            Process.Start("https://accounts.google.com/v3/signin/identifier?authuser=0&continue=https%3A%2F%2Fwww.google.com%2F&ec=GAlAmgQ&hl=vi&flowName=GlifWebSignIn&flowEntry=AddSession&dsh=S84514019%3A1714207066266077&theme=mn&ddm=0".ToString());
        }
    }
}

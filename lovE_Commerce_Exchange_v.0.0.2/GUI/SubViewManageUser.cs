using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using CustomControls.RJControls;

namespace GUI
{
    public partial class SubViewManageUser : Form
    {
        CensorStaff[] staffs;
        CensorStaff currentStaff;
        Account currentStaffAccount;

        public SubViewManageUser()
        {
            InitializeComponent();
            panel_optionContainer.BringToFront();
            InitializeDataset();
            IconButton_staff_Click(null, null);

        }
        private void InitializeDataset()
        {
            staffs = CensorStaff.GetCensorStaff();
            
        }

        private void TabControl_users_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjButton_addNewStaffNav_Click(object sender, EventArgs e)
        {
            tabControl_users.SelectedTab = tabPage_addStaff;
            currentStaff = null;
            SetCurrentStaff();
        }

        private void SetCurrentStaff()
        {
            if(currentStaff is  null)
            {
                pictureBox_staffImageNew.Image = null;
                foreach(var text in tabPage_addStaff.Controls)
                {
                    if(text is RJTextBox)
                    {
                        (text as RJTextBox).Texts = string.Empty;
                    }
                }
                rjTextBox_dateofBirthNew.Texts = "2004/10/16";
                return;
            }
            pictureBox_staffImageNew.Image = currentStaff.Image.GetStaffImagePath().TurnToStaffImage();
            pictureBox_staffImageNew.Tag = currentStaff.Image;
            rjTextBox_dateofBirthNew.Texts = currentStaff.DateOfBirth;
            rjTextBox_dateOfRegistryNew.Texts = currentStaff.DateOfBirth;
            rjTextBox_emailNew.Texts = currentStaffAccount.AuthenticatedEmail;
            rjTextBox_staffIdNew.Texts = currentStaffAccount.AccountID;
            rjTextBox_staffNameNew.Texts = currentStaff.StaffName;
            rjTextBox_phoneNumberNew.Texts = currentStaff.PhoneNumber;
            comboBox_genderNew.SelectedIndex = currentStaff.Gender.ToInt();
            rjTextBox_usernameNew.Texts = currentStaffAccount.UserName;
            rjTextBox_passwordNew.Texts = currentStaffAccount.Password;
            rjTextBox_roleNew.Texts = "Staff";
        }

        private void RjButton_staffMore_Click(object sender, EventArgs e)
        {
            GroupBox parent = ((sender as RJButton).Parent as Panel).Parent as GroupBox;
            currentStaff = staffs.Single(stf => stf.StaffID == parent.Controls.Find("label_staffId", true)[0].Text.Split(':').Last());
            currentStaffAccount = Account.GetAccounts().GetStaffAccount(currentStaff);
            SetCurrentStaff();
            tabControl_users.SelectedTab = tabPage_addStaff;
        }


        private void RjButton_customerMore_Click(object sender, EventArgs e)
        {

        }

        private void RjButton_addNewStaff_Click(object sender, EventArgs e)
        {
            Account account = new Account(new DLL.Account_()
            {
                UserName = rjTextBox_usernameNew.Texts,
                Password = rjTextBox_passwordNew.Texts,
                Role = "Staff",
                AuthenticatedEmail = rjTextBox_emailNew.Texts,
                DateOfRegister = rjTextBox_dateOfRegistryNew.Texts,

            }); account.Add();

            CensorStaff censorStaff = new CensorStaff(new DLL.CensorStaff_()
            {
                DateOfBirth = rjTextBox_dateofBirthNew.Texts,
                StaffName = rjTextBox_staffNameNew.Texts,
                Gender = comboBox_genderNew.SelectedIndex.ToString(),
                PhoneNumber = rjTextBox_phoneNumberNew.Texts,
                StaffID = account.AccountID,
                //Image = pictureBox_staffImageNew.Tag.ToString().Split('\\').Last()
                Image = pictureBox_staffImageNew.Tag.ToString(),
            });
            censorStaff.Add();
            MessageBox.Show("successfully!");
            IconButton_staff_Click(null, null);
        }

        private void RjButton_changeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = FilePathProcessing.GetStaffImageDirectory().Replace("/", "\\");
                openFile.Filter = "Files|*.jpg;*.jpeg;*.png;";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // image duplicated handlder
                    string fileName = openFile.FileName.Split('\\').Last();
                    pictureBox_staffImageNew.Image = fileName.GetStaffImagePath().TurnToStaffImage();
                    pictureBox_staffImageNew.Tag = fileName;
                }
            }
        }

        private void IconButton_staff_Click(object sender, EventArgs e)
        {
            tabControl_users.SelectedTab = tabPage_staffs;
            InitializeDataset();
            FillStaffs();

        }
       
        private void FillStaffs()
        {
            foreach(Panel panel in tabPage_staffs.Controls.OfType<Panel>())
            {
                panel.RecursivelyDispose();
            }
            foreach (CensorStaff staff in staffs)
            {
                tabPage_staffs.Controls.Add(GenerateStaffControl(staff));
            }
        }

        private Control GenerateStaffControl(CensorStaff staff)
        {
            Panel panel_staff = new Panel();
            GroupBox groupBox_staff = new GroupBox();
            RJButton rjButton_staffMore = new RJButton();
            CheckBox checkBox_staffCheck = new CheckBox();
            PictureBox pictureBox_staffImage = new PictureBox();
            Label label_staffName = new Label();
            Label label_staffId = new Label();
            Panel panel_staffMoreHolder = new Panel();

            
            //panel_staffMoreHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom))); ;
            panel_staffMoreHolder.Controls.Add(rjButton_staffMore);
            panel_staffMoreHolder.Location = new System.Drawing.Point(792, 25);
            panel_staffMoreHolder.Name = "panel_staffMoreHolder";
            panel_staffMoreHolder.Size = new System.Drawing.Size(165, 57);
            panel_staffMoreHolder.TabIndex = 21;

            label_staffId.AutoSize = true;
            label_staffId.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_staffId.Location = new System.Drawing.Point(104, 49);
            label_staffId.Name = "label_staffId";
            label_staffId.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_staffId.Size = new System.Drawing.Size(86, 24);
            label_staffId.TabIndex = 19;
            label_staffId.Text = "Staff id :" + staff.StaffID;

            label_staffName.AutoSize = true;
            label_staffName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_staffName.Location = new System.Drawing.Point(104, 25);
            label_staffName.Name = "label_staffName";
            label_staffName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            label_staffName.Size = new System.Drawing.Size(93, 24);
            label_staffName.TabIndex = 19;
            label_staffName.Text = staff.StaffName;


            pictureBox_staffImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pictureBox_staffImage.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox_staffImage.Location = new System.Drawing.Point(43, 25);
            pictureBox_staffImage.Name = "pictureBox_staffImage";
            pictureBox_staffImage.Size = new System.Drawing.Size(60, 60);
            pictureBox_staffImage.TabIndex = 18;
            pictureBox_staffImage.TabStop = false;
            pictureBox_staffImage.Image = staff.Image.GetStaffImagePath().TurnToStaffImage();
            pictureBox_staffImage.SizeMode = PictureBoxSizeMode.Zoom;

            checkBox_staffCheck.AutoSize = true;
            checkBox_staffCheck.Dock = System.Windows.Forms.DockStyle.Left;
            checkBox_staffCheck.Location = new System.Drawing.Point(10, 25);
            checkBox_staffCheck.Name = "checkBox_staffCheck";
            checkBox_staffCheck.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            checkBox_staffCheck.Size = new System.Drawing.Size(33, 60);
            checkBox_staffCheck.TabIndex = 20;
            checkBox_staffCheck.UseVisualStyleBackColor = true;

            rjButton_staffMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            rjButton_staffMore.BackColor = System.Drawing.Color.LightGray;
            rjButton_staffMore.BackgroundColor = System.Drawing.Color.LightGray;
            rjButton_staffMore.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_staffMore.BorderRadius = 15;
            rjButton_staffMore.BorderSize = 0;
            rjButton_staffMore.FlatAppearance.BorderSize = 0;
            rjButton_staffMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_staffMore.Font = new System.Drawing.Font("Tahoma", 10F);
            rjButton_staffMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_staffMore.Location = new System.Drawing.Point(19, 8);
            rjButton_staffMore.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            rjButton_staffMore.Name = "rjButton_staffMore";
            rjButton_staffMore.Size = new System.Drawing.Size(130, 38);
            rjButton_staffMore.TabIndex = 17;
            rjButton_staffMore.Text = "More";
            rjButton_staffMore.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_staffMore.UseVisualStyleBackColor = false;
            rjButton_staffMore.Click += RjButton_staffMore_Click;
            //rjButton_staffMore.BringToFront();

            groupBox_staff.BackColor = System.Drawing.SystemColors.Control;
            groupBox_staff.Controls.Add(pictureBox_staffImage);
            groupBox_staff.Controls.Add(checkBox_staffCheck);
            groupBox_staff.Controls.Add(label_staffId);                                                                                                 
            groupBox_staff.Controls.Add(label_staffName);
            groupBox_staff.Controls.Add(panel_staffMoreHolder);
            groupBox_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_staff.Location = new System.Drawing.Point(0, 0);
            groupBox_staff.Name = "groupBox_staff";
            groupBox_staff.Padding = new System.Windows.Forms.Padding(10, 10, 10, 15);
            groupBox_staff.Size = new System.Drawing.Size(970, 100);
            groupBox_staff.TabIndex = 0;
            groupBox_staff.TabStop = false;


            panel_staff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel_staff.Controls.Add(groupBox_staff);
            panel_staff.Dock = System.Windows.Forms.DockStyle.Top;
            panel_staff.Location = new System.Drawing.Point(10, 70);
            panel_staff.Name = "panel_staff";
            panel_staff.Size = new System.Drawing.Size(970, 100);
            panel_staff.TabIndex = 21;


            return panel_staff;
        }

        private void IconButton_customer_Click(object sender, EventArgs e)
        {
            tabControl_users.SelectedTab = tabPage_customers;

        }

        private void IconButton_shopOwner_Click(object sender, EventArgs e)
        {
            tabControl_users.SelectedTab = tabPage_shopOwners;
        }


    }
}

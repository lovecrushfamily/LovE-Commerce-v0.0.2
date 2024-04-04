namespace GUI
{
    partial class SubViewCustomerAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.rjButton_changePasssword = new CustomControls.RJControls.RJButton();
            this.rjButton_changeEmail = new CustomControls.RJControls.RJButton();
            this.rjButton_changePhonenumber = new CustomControls.RJControls.RJButton();
            this.rjTextBox_customerName = new CustomControls.RJControls.RJTextBox();
            this.toggleButton_rememberLogin = new GUI.CustomControl.ToggleButton();
            this.rjButton_saveChange = new CustomControls.RJControls.RJButton();
            this.rjCircularPictureBox_customerImage = new RJCircularPictureBox();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_customerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientLabel1);
            this.panel1.Controls.Add(this.gradientLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Personal information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(608, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(608, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Security";
            // 
            // iconButton1
            // 
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(641, 339);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(198, 48);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Change passsword";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Enabled = false;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Shield;
            this.iconButton2.IconColor = System.Drawing.Color.DimGray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(642, 398);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(201, 48);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Remember Login";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox_day
            // 
            this.comboBox_day.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(315, 264);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(80, 32);
            this.comboBox_day.TabIndex = 6;
            // 
            // comboBox_month
            // 
            this.comboBox_month.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(401, 264);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(80, 32);
            this.comboBox_month.TabIndex = 6;
            // 
            // comboBox_year
            // 
            this.comboBox_year.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(487, 264);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(80, 32);
            this.comboBox_year.TabIndex = 6;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(316, 209);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(63, 28);
            this.radioButton_male.TabIndex = 7;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(401, 207);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(80, 28);
            this.radioButton_female.TabIndex = 7;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneNumber.Location = new System.Drawing.Point(638, 148);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(90, 24);
            this.label_phoneNumber.TabIndex = 3;
            this.label_phoneNumber.Text = "0379120730";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(637, 209);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(180, 24);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "vuquangphuc@gmail.com";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Address";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(316, 329);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(251, 139);
            this.textBox_address.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(715, 303);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(114, 24);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "*********";
            this.label_password.Visible = false;
            // 
            // rjButton_changePasssword
            // 
            this.rjButton_changePasssword.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton_changePasssword.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton_changePasssword.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePasssword.BorderRadius = 10;
            this.rjButton_changePasssword.BorderSize = 1;
            this.rjButton_changePasssword.FlatAppearance.BorderSize = 0;
            this.rjButton_changePasssword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_changePasssword.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_changePasssword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePasssword.Location = new System.Drawing.Point(845, 344);
            this.rjButton_changePasssword.Name = "rjButton_changePasssword";
            this.rjButton_changePasssword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton_changePasssword.Size = new System.Drawing.Size(138, 40);
            this.rjButton_changePasssword.TabIndex = 9;
            this.rjButton_changePasssword.Text = "Update";
            this.rjButton_changePasssword.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePasssword.UseVisualStyleBackColor = false;
            this.rjButton_changePasssword.Click += new System.EventHandler(this.RjButton2_Click);
            // 
            // rjButton_changeEmail
            // 
            this.rjButton_changeEmail.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton_changeEmail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton_changeEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changeEmail.BorderRadius = 10;
            this.rjButton_changeEmail.BorderSize = 1;
            this.rjButton_changeEmail.FlatAppearance.BorderSize = 0;
            this.rjButton_changeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_changeEmail.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_changeEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changeEmail.Location = new System.Drawing.Point(845, 189);
            this.rjButton_changeEmail.Name = "rjButton_changeEmail";
            this.rjButton_changeEmail.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton_changeEmail.Size = new System.Drawing.Size(138, 40);
            this.rjButton_changeEmail.TabIndex = 9;
            this.rjButton_changeEmail.Text = "Update";
            this.rjButton_changeEmail.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changeEmail.UseVisualStyleBackColor = false;
            this.rjButton_changeEmail.Click += new System.EventHandler(this.RjButton2_Click);
            // 
            // rjButton_changePhonenumber
            // 
            this.rjButton_changePhonenumber.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton_changePhonenumber.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton_changePhonenumber.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePhonenumber.BorderRadius = 10;
            this.rjButton_changePhonenumber.BorderSize = 1;
            this.rjButton_changePhonenumber.FlatAppearance.BorderSize = 0;
            this.rjButton_changePhonenumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_changePhonenumber.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_changePhonenumber.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePhonenumber.Location = new System.Drawing.Point(845, 119);
            this.rjButton_changePhonenumber.Name = "rjButton_changePhonenumber";
            this.rjButton_changePhonenumber.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton_changePhonenumber.Size = new System.Drawing.Size(138, 40);
            this.rjButton_changePhonenumber.TabIndex = 9;
            this.rjButton_changePhonenumber.Text = "Update";
            this.rjButton_changePhonenumber.TextColor = System.Drawing.Color.DeepSkyBlue;
            this.rjButton_changePhonenumber.UseVisualStyleBackColor = false;
            // 
            // rjTextBox_customerName
            // 
            this.rjTextBox_customerName.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_customerName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_customerName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBox_customerName.BorderRadius = 10;
            this.rjTextBox_customerName.BorderSize = 2;
            this.rjTextBox_customerName.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_customerName.Location = new System.Drawing.Point(315, 132);
            this.rjTextBox_customerName.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_customerName.Multiline = false;
            this.rjTextBox_customerName.Name = "rjTextBox_customerName";
            this.rjTextBox_customerName.Padding = new System.Windows.Forms.Padding(10, 10, 10, 7);
            this.rjTextBox_customerName.PasswordChar = false;
            this.rjTextBox_customerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_customerName.PlaceholderText = "";
            this.rjTextBox_customerName.Size = new System.Drawing.Size(252, 50);
            this.rjTextBox_customerName.TabIndex = 8;
            this.rjTextBox_customerName.Texts = "";
            this.rjTextBox_customerName.UnderlinedStyle = false;
            // 
            // toggleButton_rememberLogin
            // 
            this.toggleButton_rememberLogin.Location = new System.Drawing.Point(886, 408);
            this.toggleButton_rememberLogin.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton_rememberLogin.Name = "toggleButton_rememberLogin";
            this.toggleButton_rememberLogin.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton_rememberLogin.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton_rememberLogin.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton_rememberLogin.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton_rememberLogin.Size = new System.Drawing.Size(63, 31);
            this.toggleButton_rememberLogin.TabIndex = 5;
            this.toggleButton_rememberLogin.UseVisualStyleBackColor = true;
            // 
            // rjButton_saveChange
            // 
            this.rjButton_saveChange.AutoSize = true;
            this.rjButton_saveChange.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_saveChange.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_saveChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_saveChange.BorderRadius = 15;
            this.rjButton_saveChange.BorderSize = 0;
            this.rjButton_saveChange.FlatAppearance.BorderSize = 0;
            this.rjButton_saveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_saveChange.Font = new System.Drawing.Font("Sans Serif Collection", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_saveChange.ForeColor = System.Drawing.Color.White;
            this.rjButton_saveChange.Location = new System.Drawing.Point(315, 506);
            this.rjButton_saveChange.Name = "rjButton_saveChange";
            this.rjButton_saveChange.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.rjButton_saveChange.Size = new System.Drawing.Size(252, 55);
            this.rjButton_saveChange.TabIndex = 2;
            this.rjButton_saveChange.Text = "Save change";
            this.rjButton_saveChange.TextColor = System.Drawing.Color.White;
            this.rjButton_saveChange.UseVisualStyleBackColor = false;
            this.rjButton_saveChange.Click += new System.EventHandler(this.RjButton_saveChange_Click);
            // 
            // rjCircularPictureBox_customerImage
            // 
            this.rjCircularPictureBox_customerImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox_customerImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox_customerImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox_customerImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox_customerImage.BorderSize = 2;
            this.rjCircularPictureBox_customerImage.GradientAngle = 50F;
            this.rjCircularPictureBox_customerImage.Location = new System.Drawing.Point(18, 132);
            this.rjCircularPictureBox_customerImage.Name = "rjCircularPictureBox_customerImage";
            this.rjCircularPictureBox_customerImage.Size = new System.Drawing.Size(150, 150);
            this.rjCircularPictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox_customerImage.TabIndex = 1;
            this.rjCircularPictureBox_customerImage.TabStop = false;
            this.rjCircularPictureBox_customerImage.Click += new System.EventHandler(this.RjCircularPictureBox_customerImage_Click);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BeginColor = System.Drawing.Color.CornflowerBlue;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.gradientLabel1.Size = new System.Drawing.Size(260, 50);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = "Account manager";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.DarkOrchid;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.MediumSlateBlue;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.CornflowerBlue;
            this.gradientLabel2.Location = new System.Drawing.Point(260, 0);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(753, 54);
            this.gradientLabel2.TabIndex = 1;
            this.gradientLabel2.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel2.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // SubViewCustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 573);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.rjButton_changePasssword);
            this.Controls.Add(this.rjButton_changeEmail);
            this.Controls.Add(this.rjButton_changePhonenumber);
            this.Controls.Add(this.rjTextBox_customerName);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.comboBox_day);
            this.Controls.Add(this.toggleButton_rememberLogin);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label_phoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton_saveChange);
            this.Controls.Add(this.rjCircularPictureBox_customerImage);
            this.Controls.Add(this.panel1);
            this.Name = "SubViewCustomerAccount";
            this.Load += new System.EventHandler(this.SubViewCustomerAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_customerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.GradientLabel gradientLabel1;
        private CustomControl.GradientLabel gradientLabel2;
        private RJCircularPictureBox rjCircularPictureBox_customerImage;
        private CustomControls.RJControls.RJButton rjButton_saveChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private CustomControl.ToggleButton toggleButton_rememberLogin;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private CustomControls.RJControls.RJTextBox rjTextBox_customerName;
        private CustomControls.RJControls.RJButton rjButton_changePhonenumber;
        private CustomControls.RJControls.RJButton rjButton_changeEmail;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_address;
        private CustomControls.RJControls.RJButton rjButton_changePasssword;
        private System.Windows.Forms.Label label_password;
    }
}
namespace GUI
{
    partial class PopupSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupSignIn));
            this.label_reset_password = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_rememberLoginAccounts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_rememberLogin = new System.Windows.Forms.Panel();
            this.rjButton_removeRememberLogin = new CustomControls.RJControls.RJButton();
            this.pictureBox_customerImage = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.rjTextBox_password = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_username = new CustomControls.RJControls.RJTextBox();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton_login = new CustomControls.RJControls.RJButton();
            this.rjTextBox_role = new CustomControls.RJControls.RJTextBox();
            this.flowLayoutPanel_rememberLoginAccounts.SuspendLayout();
            this.panel_rememberLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_reset_password
            // 
            this.label_reset_password.AutoSize = true;
            this.label_reset_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reset_password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_reset_password.Location = new System.Drawing.Point(677, 444);
            this.label_reset_password.Name = "label_reset_password";
            this.label_reset_password.Size = new System.Drawing.Size(166, 20);
            this.label_reset_password.TabIndex = 3;
            this.label_reset_password.Text = "Forgotten password?";
            this.label_reset_password.Click += new System.EventHandler(this.Label_reset_password_Click);
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_register.Location = new System.Drawing.Point(833, 498);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(79, 24);
            this.label_register.TabIndex = 3;
            this.label_register.Text = "Register";
            this.label_register.Click += new System.EventHandler(this.Label_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(620, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Can I have an currentAccount?";
            // 
            // flowLayoutPanel_rememberLoginAccounts
            // 
            this.flowLayoutPanel_rememberLoginAccounts.AutoScroll = true;
            this.flowLayoutPanel_rememberLoginAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_rememberLoginAccounts.Controls.Add(this.panel_rememberLogin);
            this.flowLayoutPanel_rememberLoginAccounts.Location = new System.Drawing.Point(70, 133);
            this.flowLayoutPanel_rememberLoginAccounts.Name = "flowLayoutPanel_rememberLoginAccounts";
            this.flowLayoutPanel_rememberLoginAccounts.Size = new System.Drawing.Size(526, 331);
            this.flowLayoutPanel_rememberLoginAccounts.TabIndex = 5;
            // 
            // panel_rememberLogin
            // 
            this.panel_rememberLogin.Controls.Add(this.rjButton_removeRememberLogin);
            this.panel_rememberLogin.Controls.Add(this.pictureBox_customerImage);
            this.panel_rememberLogin.Controls.Add(this.rjButton1);
            this.panel_rememberLogin.Location = new System.Drawing.Point(0, 0);
            this.panel_rememberLogin.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.panel_rememberLogin.Name = "panel_rememberLogin";
            this.panel_rememberLogin.Size = new System.Drawing.Size(120, 120);
            this.panel_rememberLogin.TabIndex = 0;
            // 
            // rjButton_removeRememberLogin
            // 
            this.rjButton_removeRememberLogin.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton_removeRememberLogin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton_removeRememberLogin.BorderColor = System.Drawing.SystemColors.Control;
            this.rjButton_removeRememberLogin.BorderRadius = 15;
            this.rjButton_removeRememberLogin.BorderSize = 1;
            this.rjButton_removeRememberLogin.FlatAppearance.BorderSize = 0;
            this.rjButton_removeRememberLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_removeRememberLogin.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_removeRememberLogin.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton_removeRememberLogin.Location = new System.Drawing.Point(75, 5);
            this.rjButton_removeRememberLogin.Margin = new System.Windows.Forms.Padding(5);
            this.rjButton_removeRememberLogin.Name = "rjButton_removeRememberLogin";
            this.rjButton_removeRememberLogin.Size = new System.Drawing.Size(40, 40);
            this.rjButton_removeRememberLogin.TabIndex = 10;
            this.rjButton_removeRememberLogin.Text = "x";
            this.rjButton_removeRememberLogin.TextColor = System.Drawing.Color.DimGray;
            this.rjButton_removeRememberLogin.UseVisualStyleBackColor = false;
            this.rjButton_removeRememberLogin.Click += new System.EventHandler(this.RjButton_removeRememberLogin_Click);
            // 
            // pictureBox_customerImage
            // 
            this.pictureBox_customerImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_customerImage.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_customerImage.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_customerImage.Name = "pictureBox_customerImage";
            this.pictureBox_customerImage.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_customerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_customerImage.TabIndex = 2;
            this.pictureBox_customerImage.TabStop = false;
            this.pictureBox_customerImage.Click += new System.EventHandler(this.PictureBox_customerImage_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rjButton1.BorderColor = System.Drawing.Color.LightPink;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(120, 120);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // comboBox_role
            // 
            this.comboBox_role.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_role.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.ForeColor = System.Drawing.Color.Gray;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Staff",
            "Manager",
            "Customer"});
            this.comboBox_role.Location = new System.Drawing.Point(639, 260);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(273, 29);
            this.comboBox_role.TabIndex = 3;
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.ComboBox_role_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(572, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 331);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(646, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 1);
            this.label1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 401);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderRadius = 16;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton2.Location = new System.Drawing.Point(740, 359);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(35, 35);
            this.rjButton2.TabIndex = 10;
            this.rjButton2.Text = "or";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.RjButton_login_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.AutoSize = true;
            this.gradientLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.Location = new System.Drawing.Point(250, 81);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(278, 38);
            this.gradientLabel3.TabIndex = 7;
            this.gradientLabel3.Text = "Love the way you like";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientLabel3.TextColorBegin = System.Drawing.Color.Crimson;
            this.gradientLabel3.TextColorEnd = System.Drawing.Color.Orchid;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.AutoSize = true;
            this.gradientLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Font = new System.Drawing.Font("Love Crush", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.Location = new System.Drawing.Point(122, 26);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(334, 62);
            this.gradientLabel2.TabIndex = 7;
            this.gradientLabel2.Text = "LovE-Commerce";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradientLabel2.TextColorBegin = System.Drawing.Color.DarkOrchid;
            this.gradientLabel2.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.AutoSize = true;
            this.gradientLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(690, 43);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(137, 41);
            this.gradientLabel1.TabIndex = 7;
            this.gradientLabel1.Text = "Welcome";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.SlateBlue;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // rjTextBox_password
            // 
            this.rjTextBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_password.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox_password.BorderRadius = 10;
            this.rjTextBox_password.BorderSize = 1;
            this.rjTextBox_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_password.Location = new System.Drawing.Point(630, 199);
            this.rjTextBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_password.Multiline = false;
            this.rjTextBox_password.Name = "rjTextBox_password";
            this.rjTextBox_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_password.PasswordChar = true;
            this.rjTextBox_password.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_password.PlaceholderText = "Password";
            this.rjTextBox_password.Size = new System.Drawing.Size(261, 36);
            this.rjTextBox_password.TabIndex = 1;
            this.rjTextBox_password.Texts = "";
            this.rjTextBox_password.UnderlinedStyle = true;
            // 
            // rjTextBox_username
            // 
            this.rjTextBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_username.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_username.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjTextBox_username.BorderRadius = 10;
            this.rjTextBox_username.BorderSize = 1;
            this.rjTextBox_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_username.Location = new System.Drawing.Point(630, 133);
            this.rjTextBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_username.Multiline = false;
            this.rjTextBox_username.Name = "rjTextBox_username";
            this.rjTextBox_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_username.PasswordChar = false;
            this.rjTextBox_username.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_username.PlaceholderText = "Username";
            this.rjTextBox_username.Size = new System.Drawing.Size(261, 36);
            this.rjTextBox_username.TabIndex = 0;
            this.rjTextBox_username.Texts = "";
            this.rjTextBox_username.UnderlinedStyle = true;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton3.BackgroundImage")));
            this.rjButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjButton3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.Enabled = false;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.DimGray;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rjButton3.Location = new System.Drawing.Point(630, 397);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.rjButton3.Size = new System.Drawing.Size(261, 42);
            this.rjButton3.TabIndex = 1;
            this.rjButton3.Text = "Continue with Google";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton3.TextColor = System.Drawing.Color.DimGray;
            this.rjButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.RjButton_login_Click);
            // 
            // rjButton_login
            // 
            this.rjButton_login.BackColor = System.Drawing.Color.Snow;
            this.rjButton_login.BackgroundColor = System.Drawing.Color.Snow;
            this.rjButton_login.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton_login.BorderRadius = 20;
            this.rjButton_login.BorderSize = 1;
            this.rjButton_login.FlatAppearance.BorderSize = 0;
            this.rjButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_login.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_login.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton_login.Location = new System.Drawing.Point(630, 317);
            this.rjButton_login.Name = "rjButton_login";
            this.rjButton_login.Size = new System.Drawing.Size(261, 42);
            this.rjButton_login.TabIndex = 4;
            this.rjButton_login.Text = "Log in";
            this.rjButton_login.TextColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_login.UseVisualStyleBackColor = false;
            this.rjButton_login.Click += new System.EventHandler(this.RjButton_login_Click);
            // 
            // rjTextBox_role
            // 
            this.rjTextBox_role.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_role.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_role.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_role.BorderRadius = 10;
            this.rjTextBox_role.BorderSize = 1;
            this.rjTextBox_role.Enabled = false;
            this.rjTextBox_role.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_role.ForeColor = System.Drawing.Color.Gray;
            this.rjTextBox_role.Location = new System.Drawing.Point(630, 258);
            this.rjTextBox_role.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_role.Multiline = false;
            this.rjTextBox_role.Name = "rjTextBox_role";
            this.rjTextBox_role.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_role.PasswordChar = false;
            this.rjTextBox_role.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_role.PlaceholderText = "";
            this.rjTextBox_role.Size = new System.Drawing.Size(261, 36);
            this.rjTextBox_role.TabIndex = 2;
            this.rjTextBox_role.Texts = "Role";
            this.rjTextBox_role.UnderlinedStyle = true;
            // 
            // PopupSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.flowLayoutPanel_rememberLoginAccounts);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_reset_password);
            this.Controls.Add(this.rjTextBox_password);
            this.Controls.Add(this.rjTextBox_username);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton_login);
            this.Controls.Add(this.rjTextBox_role);
            this.Controls.Add(this.comboBox_role);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PopupSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.flowLayoutPanel_rememberLoginAccounts.ResumeLayout(false);
            this.panel_rememberLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_customerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton rjButton_login;
        private CustomControls.RJControls.RJTextBox rjTextBox_username;
        private CustomControls.RJControls.RJTextBox rjTextBox_password;
        private System.Windows.Forms.Label label_reset_password;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_rememberLoginAccounts;
        private System.Windows.Forms.ComboBox comboBox_role;
        private CustomControl.GradientLabel gradientLabel1;
        private CustomControls.RJControls.RJTextBox rjTextBox_role;
        private System.Windows.Forms.Panel panel_rememberLogin;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton_removeRememberLogin;
        private System.Windows.Forms.PictureBox pictureBox_customerImage;
        private System.Windows.Forms.Label label3;
        private CustomControl.GradientLabel gradientLabel2;
        private CustomControl.GradientLabel gradientLabel3;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
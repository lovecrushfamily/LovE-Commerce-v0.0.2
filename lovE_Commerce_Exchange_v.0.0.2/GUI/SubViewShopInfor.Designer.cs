namespace GUI
{
    partial class SubViewShopInfor
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
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjTextBox_date = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_shopOwner = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_description = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_phoneNumber = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_address = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_shopName = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton_deleteThisShop = new CustomControls.RJControls.RJButton();
            this.rjButton_saveChange = new CustomControls.RJControls.RJButton();
            this.rjCircularPictureBox_shopImage = new RJCircularPictureBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_shopImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel2.BeginColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.Thistle;
            this.gradientLabel2.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.gradientLabel2.Location = new System.Drawing.Point(197, 0);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(747, 44);
            this.gradientLabel2.TabIndex = 22;
            this.gradientLabel2.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel2.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel1.BeginColor = System.Drawing.Color.MediumPurple;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(3, 0);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(194, 44);
            this.gradientLabel1.TabIndex = 21;
            this.gradientLabel1.Text = "Shop Information";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.SlateBlue;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.Crimson;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rjTextBox_date);
            this.panel1.Controls.Add(this.rjTextBox_shopOwner);
            this.panel1.Controls.Add(this.rjTextBox_description);
            this.panel1.Controls.Add(this.rjTextBox_phoneNumber);
            this.panel1.Controls.Add(this.rjTextBox_address);
            this.panel1.Controls.Add(this.rjTextBox_shopName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjButton_deleteThisShop);
            this.panel1.Controls.Add(this.rjButton_saveChange);
            this.panel1.Controls.Add(this.rjCircularPictureBox_shopImage);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(921, 487);
            this.panel1.TabIndex = 23;
            // 
            // rjTextBox_date
            // 
            this.rjTextBox_date.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_date.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_date.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_date.BorderRadius = 15;
            this.rjTextBox_date.BorderSize = 1;
            this.rjTextBox_date.Enabled = false;
            this.rjTextBox_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_date.Location = new System.Drawing.Point(457, 292);
            this.rjTextBox_date.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_date.Multiline = false;
            this.rjTextBox_date.Name = "rjTextBox_date";
            this.rjTextBox_date.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_date.PasswordChar = false;
            this.rjTextBox_date.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_date.PlaceholderText = "";
            this.rjTextBox_date.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_date.TabIndex = 5;
            this.rjTextBox_date.Texts = "";
            this.rjTextBox_date.UnderlinedStyle = true;
            // 
            // rjTextBox_shopOwner
            // 
            this.rjTextBox_shopOwner.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_shopOwner.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_shopOwner.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_shopOwner.BorderRadius = 15;
            this.rjTextBox_shopOwner.BorderSize = 1;
            this.rjTextBox_shopOwner.Enabled = false;
            this.rjTextBox_shopOwner.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_shopOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_shopOwner.Location = new System.Drawing.Point(457, 346);
            this.rjTextBox_shopOwner.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_shopOwner.Multiline = false;
            this.rjTextBox_shopOwner.Name = "rjTextBox_shopOwner";
            this.rjTextBox_shopOwner.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_shopOwner.PasswordChar = false;
            this.rjTextBox_shopOwner.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_shopOwner.PlaceholderText = "";
            this.rjTextBox_shopOwner.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_shopOwner.TabIndex = 5;
            this.rjTextBox_shopOwner.Texts = "";
            this.rjTextBox_shopOwner.UnderlinedStyle = true;
            // 
            // rjTextBox_description
            // 
            this.rjTextBox_description.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_description.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_description.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_description.BorderRadius = 15;
            this.rjTextBox_description.BorderSize = 1;
            this.rjTextBox_description.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_description.Location = new System.Drawing.Point(457, 167);
            this.rjTextBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_description.Multiline = false;
            this.rjTextBox_description.Name = "rjTextBox_description";
            this.rjTextBox_description.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_description.PasswordChar = false;
            this.rjTextBox_description.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_description.PlaceholderText = "";
            this.rjTextBox_description.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_description.TabIndex = 5;
            this.rjTextBox_description.Texts = "";
            this.rjTextBox_description.UnderlinedStyle = true;
            // 
            // rjTextBox_phoneNumber
            // 
            this.rjTextBox_phoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_phoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_phoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_phoneNumber.BorderRadius = 15;
            this.rjTextBox_phoneNumber.BorderSize = 1;
            this.rjTextBox_phoneNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_phoneNumber.Location = new System.Drawing.Point(457, 99);
            this.rjTextBox_phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_phoneNumber.Multiline = false;
            this.rjTextBox_phoneNumber.Name = "rjTextBox_phoneNumber";
            this.rjTextBox_phoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_phoneNumber.PasswordChar = false;
            this.rjTextBox_phoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_phoneNumber.PlaceholderText = "";
            this.rjTextBox_phoneNumber.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_phoneNumber.TabIndex = 5;
            this.rjTextBox_phoneNumber.Texts = "";
            this.rjTextBox_phoneNumber.UnderlinedStyle = true;
            // 
            // rjTextBox_address
            // 
            this.rjTextBox_address.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_address.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_address.BorderRadius = 15;
            this.rjTextBox_address.BorderSize = 1;
            this.rjTextBox_address.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_address.Location = new System.Drawing.Point(457, 228);
            this.rjTextBox_address.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_address.Multiline = false;
            this.rjTextBox_address.Name = "rjTextBox_address";
            this.rjTextBox_address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_address.PasswordChar = false;
            this.rjTextBox_address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_address.PlaceholderText = "";
            this.rjTextBox_address.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_address.TabIndex = 5;
            this.rjTextBox_address.Texts = "";
            this.rjTextBox_address.UnderlinedStyle = true;
            // 
            // rjTextBox_shopName
            // 
            this.rjTextBox_shopName.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_shopName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_shopName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_shopName.BorderRadius = 15;
            this.rjTextBox_shopName.BorderSize = 1;
            this.rjTextBox_shopName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_shopName.Location = new System.Drawing.Point(457, 44);
            this.rjTextBox_shopName.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_shopName.Multiline = false;
            this.rjTextBox_shopName.Name = "rjTextBox_shopName";
            this.rjTextBox_shopName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_shopName.PasswordChar = false;
            this.rjTextBox_shopName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_shopName.PlaceholderText = "";
            this.rjTextBox_shopName.Size = new System.Drawing.Size(260, 36);
            this.rjTextBox_shopName.TabIndex = 5;
            this.rjTextBox_shopName.Texts = "";
            this.rjTextBox_shopName.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(276, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(276, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date created Shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(276, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shop Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(276, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(276, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shop Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(276, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shop Name";
            // 
            // rjButton_deleteThisShop
            // 
            this.rjButton_deleteThisShop.AutoSize = true;
            this.rjButton_deleteThisShop.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton_deleteThisShop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton_deleteThisShop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_deleteThisShop.BorderRadius = 15;
            this.rjButton_deleteThisShop.BorderSize = 0;
            this.rjButton_deleteThisShop.FlatAppearance.BorderSize = 0;
            this.rjButton_deleteThisShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_deleteThisShop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rjButton_deleteThisShop.ForeColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteThisShop.Location = new System.Drawing.Point(320, 409);
            this.rjButton_deleteThisShop.Name = "rjButton_deleteThisShop";
            this.rjButton_deleteThisShop.Size = new System.Drawing.Size(166, 38);
            this.rjButton_deleteThisShop.TabIndex = 3;
            this.rjButton_deleteThisShop.Text = "Delete shop";
            this.rjButton_deleteThisShop.TextColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteThisShop.UseVisualStyleBackColor = false;
            this.rjButton_deleteThisShop.Click += new System.EventHandler(this.RjButton_deleteThisShop_Click);
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
            this.rjButton_saveChange.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rjButton_saveChange.ForeColor = System.Drawing.Color.White;
            this.rjButton_saveChange.Location = new System.Drawing.Point(503, 409);
            this.rjButton_saveChange.Name = "rjButton_saveChange";
            this.rjButton_saveChange.Size = new System.Drawing.Size(166, 38);
            this.rjButton_saveChange.TabIndex = 3;
            this.rjButton_saveChange.Text = "Save change";
            this.rjButton_saveChange.TextColor = System.Drawing.Color.White;
            this.rjButton_saveChange.UseVisualStyleBackColor = false;
            this.rjButton_saveChange.Click += new System.EventHandler(this.RjButton_saveChange_Click);
            // 
            // rjCircularPictureBox_shopImage
            // 
            this.rjCircularPictureBox_shopImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjCircularPictureBox_shopImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox_shopImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox_shopImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox_shopImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox_shopImage.BorderSize = 2;
            this.rjCircularPictureBox_shopImage.GradientAngle = 50F;
            this.rjCircularPictureBox_shopImage.Location = new System.Drawing.Point(65, 50);
            this.rjCircularPictureBox_shopImage.Name = "rjCircularPictureBox_shopImage";
            this.rjCircularPictureBox_shopImage.Size = new System.Drawing.Size(120, 120);
            this.rjCircularPictureBox_shopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox_shopImage.TabIndex = 1;
            this.rjCircularPictureBox_shopImage.TabStop = false;
            this.rjCircularPictureBox_shopImage.Click += new System.EventHandler(this.RjCircularPictureBox_shopImage_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(20, 20);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(881, 447);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // SubViewShopInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(945, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.gradientLabel1);
            this.Name = "SubViewShopInfor";
            this.Text = "SubViewShopInfor";
            this.Load += new System.EventHandler(this.SubViewShopInfor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_shopImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.GradientLabel gradientLabel2;
        private CustomControl.GradientLabel gradientLabel1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private RJCircularPictureBox rjCircularPictureBox_shopImage;
        private CustomControls.RJControls.RJButton rjButton_saveChange;
        private CustomControls.RJControls.RJTextBox rjTextBox_date;
        private CustomControls.RJControls.RJTextBox rjTextBox_shopOwner;
        private CustomControls.RJControls.RJTextBox rjTextBox_phoneNumber;
        private CustomControls.RJControls.RJTextBox rjTextBox_address;
        private CustomControls.RJControls.RJTextBox rjTextBox_shopName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox_description;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton rjButton_deleteThisShop;
    }
}
namespace GUI
{
    partial class ViewHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHomePage));
            this.flowLayoutPanel_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.iconButton_category_sample = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel_allFather = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.pictureBox_reviewedProductStar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label_prouductName = new System.Windows.Forms.Label();
            this.label_sponsor = new System.Windows.Forms.Label();
            this.iconButton_verification = new FontAwesome.Sharp.IconButton();
            this.label_colorMaker = new System.Windows.Forms.Label();
            this.label_productAddress = new System.Windows.Forms.Label();
            this.label_productPrice = new System.Windows.Forms.Label();
            this.pictureBox_productImage = new System.Windows.Forms.PictureBox();
            this.label_product = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.flowLayoutPanel_categories.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel_allFather.SuspendLayout();
            this.groupBox_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reviewedProductStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_categories
            // 
            this.flowLayoutPanel_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_categories.AutoScroll = true;
            this.flowLayoutPanel_categories.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_categories.Controls.Add(this.panel5);
            this.flowLayoutPanel_categories.Controls.Add(this.iconButton_category_sample);
            this.flowLayoutPanel_categories.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_categories.Name = "flowLayoutPanel_categories";
            this.flowLayoutPanel_categories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_categories.Size = new System.Drawing.Size(324, 531);
            this.flowLayoutPanel_categories.TabIndex = 5;
            this.flowLayoutPanel_categories.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.gradientLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 20);
            this.panel5.Size = new System.Drawing.Size(320, 60);
            this.panel5.TabIndex = 1;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.AutoSize = true;
            this.gradientLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(10, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(202, 62);
            this.gradientLabel1.TabIndex = 1;
            this.gradientLabel1.Text = "Category";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.Orchid;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.MediumSlateBlue;
            // 
            // iconButton_category_sample
            // 
            this.iconButton_category_sample.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_category_sample.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_category_sample.FlatAppearance.BorderSize = 0;
            this.iconButton_category_sample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_category_sample.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton_category_sample.Font = new System.Drawing.Font("Montserrat", 10F);
            this.iconButton_category_sample.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iconButton_category_sample.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_category_sample.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton_category_sample.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_category_sample.IconSize = 40;
            this.iconButton_category_sample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category_sample.Location = new System.Drawing.Point(3, 69);
            this.iconButton_category_sample.Name = "iconButton_category_sample";
            this.iconButton_category_sample.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_category_sample.Size = new System.Drawing.Size(320, 60);
            this.iconButton_category_sample.TabIndex = 0;
            this.iconButton_category_sample.Tag = "sample";
            this.iconButton_category_sample.Text = "Category Name";
            this.iconButton_category_sample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category_sample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_category_sample.UseVisualStyleBackColor = true;
            this.iconButton_category_sample.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // flowLayoutPanel_allFather
            // 
            this.flowLayoutPanel_allFather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_allFather.AutoScroll = true;
            this.flowLayoutPanel_allFather.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_allFather.Controls.Add(this.groupBox_product);
            this.flowLayoutPanel_allFather.Controls.Add(this.hScrollBar1);
            this.flowLayoutPanel_allFather.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.flowLayoutPanel_allFather.Location = new System.Drawing.Point(342, 58);
            this.flowLayoutPanel_allFather.Name = "flowLayoutPanel_allFather";
            this.flowLayoutPanel_allFather.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel_allFather.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_allFather.Size = new System.Drawing.Size(675, 482);
            this.flowLayoutPanel_allFather.TabIndex = 6;
            // 
            // groupBox_product
            // 
            this.groupBox_product.Controls.Add(this.pictureBox_reviewedProductStar);
            this.groupBox_product.Controls.Add(this.pictureBox3);
            this.groupBox_product.Controls.Add(this.pictureBox13);
            this.groupBox_product.Controls.Add(this.pictureBox14);
            this.groupBox_product.Controls.Add(this.pictureBox15);
            this.groupBox_product.Controls.Add(this.label_prouductName);
            this.groupBox_product.Controls.Add(this.label_sponsor);
            this.groupBox_product.Controls.Add(this.iconButton_verification);
            this.groupBox_product.Controls.Add(this.label_colorMaker);
            this.groupBox_product.Controls.Add(this.label_productAddress);
            this.groupBox_product.Controls.Add(this.label_productPrice);
            this.groupBox_product.Controls.Add(this.pictureBox_productImage);
            this.groupBox_product.Controls.Add(this.label_product);
            this.groupBox_product.Location = new System.Drawing.Point(15, 5);
            this.groupBox_product.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.groupBox_product.Size = new System.Drawing.Size(245, 451);
            this.groupBox_product.TabIndex = 5;
            this.groupBox_product.TabStop = false;
            // 
            // pictureBox_reviewedProductStar
            // 
            this.pictureBox_reviewedProductStar.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_reviewedProductStar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_reviewedProductStar.Image")));
            this.pictureBox_reviewedProductStar.Location = new System.Drawing.Point(25, 357);
            this.pictureBox_reviewedProductStar.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            this.pictureBox_reviewedProductStar.Name = "pictureBox_reviewedProductStar";
            this.pictureBox_reviewedProductStar.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_reviewedProductStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reviewedProductStar.TabIndex = 29;
            this.pictureBox_reviewedProductStar.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 357);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(74, 357);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 20);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 26;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(99, 357);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(20, 20);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 27;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(124, 357);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(5, 3, 0, 10);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 20);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 28;
            this.pictureBox15.TabStop = false;
            // 
            // label_prouductName
            // 
            this.label_prouductName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prouductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_prouductName.Location = new System.Drawing.Point(6, 283);
            this.label_prouductName.Name = "label_prouductName";
            this.label_prouductName.Padding = new System.Windows.Forms.Padding(10, 0, 5, 3);
            this.label_prouductName.Size = new System.Drawing.Size(230, 71);
            this.label_prouductName.TabIndex = 1;
            this.label_prouductName.Text = "Điện thoại Apple iPhone 15 128GBwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww" +
    "wwwwwwwwwwwww\r\nwwww\r\nwwww\r\n";
            this.label_prouductName.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label_sponsor
            // 
            this.label_sponsor.AutoSize = true;
            this.label_sponsor.Font = new System.Drawing.Font("Sans Serif Collection", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sponsor.ForeColor = System.Drawing.Color.DimGray;
            this.label_sponsor.Location = new System.Drawing.Point(133, 251);
            this.label_sponsor.Name = "label_sponsor";
            this.label_sponsor.Size = new System.Drawing.Size(94, 32);
            this.label_sponsor.TabIndex = 1;
            this.label_sponsor.Text = "Sponsor";
            this.label_sponsor.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // iconButton_verification
            // 
            this.iconButton_verification.AutoSize = true;
            this.iconButton_verification.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_verification.FlatAppearance.BorderSize = 0;
            this.iconButton_verification.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconButton_verification.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconButton_verification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_verification.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_verification.IconChar = FontAwesome.Sharp.IconChar.Certificate;
            this.iconButton_verification.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton_verification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_verification.IconSize = 25;
            this.iconButton_verification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_verification.Location = new System.Drawing.Point(15, 248);
            this.iconButton_verification.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_verification.Name = "iconButton_verification";
            this.iconButton_verification.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton_verification.Size = new System.Drawing.Size(161, 42);
            this.iconButton_verification.TabIndex = 2;
            this.iconButton_verification.Text = "Verification";
            this.iconButton_verification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_verification.UseVisualStyleBackColor = true;
            this.iconButton_verification.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label_colorMaker
            // 
            this.label_colorMaker.AutoSize = true;
            this.label_colorMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colorMaker.Location = new System.Drawing.Point(183, 413);
            this.label_colorMaker.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_colorMaker.Name = "label_colorMaker";
            this.label_colorMaker.Size = new System.Drawing.Size(21, 20);
            this.label_colorMaker.TabIndex = 1;
            this.label_colorMaker.Text = "...";
            this.label_colorMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_colorMaker.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label_productAddress
            // 
            this.label_productAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productAddress.Location = new System.Drawing.Point(20, 413);
            this.label_productAddress.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_productAddress.Name = "label_productAddress";
            this.label_productAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_productAddress.Size = new System.Drawing.Size(160, 20);
            this.label_productAddress.TabIndex = 1;
            this.label_productAddress.Text = "Loadsdasdasdasddsadsadsa";
            this.label_productAddress.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label_productPrice
            // 
            this.label_productPrice.AutoSize = true;
            this.label_productPrice.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPrice.ForeColor = System.Drawing.Color.LightCoral;
            this.label_productPrice.Location = new System.Drawing.Point(18, 378);
            this.label_productPrice.Name = "label_productPrice";
            this.label_productPrice.Size = new System.Drawing.Size(145, 35);
            this.label_productPrice.TabIndex = 1;
            this.label_productPrice.Text = "20.000.000 đ";
            this.label_productPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_productPrice.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // pictureBox_productImage
            // 
            this.pictureBox_productImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_productImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_productImage.Image")));
            this.pictureBox_productImage.Location = new System.Drawing.Point(15, 18);
            this.pictureBox_productImage.Name = "pictureBox_productImage";
            this.pictureBox_productImage.Size = new System.Drawing.Size(215, 227);
            this.pictureBox_productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_productImage.TabIndex = 0;
            this.pictureBox_productImage.TabStop = false;
            this.pictureBox_productImage.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label_product
            // 
            this.label_product.BackColor = System.Drawing.SystemColors.Control;
            this.label_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_product.Location = new System.Drawing.Point(15, 18);
            this.label_product.Name = "label_product";
            this.label_product.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label_product.Size = new System.Drawing.Size(215, 430);
            this.label_product.TabIndex = 3;
            this.label_product.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(265, 0);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(306, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 531);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(13, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 20);
            this.label7.TabIndex = 10;
            this.label7.Click += new System.EventHandler(this.Label6_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel3.BeginColor = System.Drawing.Color.Thistle;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel3.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.Location = new System.Drawing.Point(602, 12);
            this.gradientLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(415, 43);
            this.gradientLabel3.TabIndex = 8;
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.Thistle;
            this.gradientLabel2.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.Location = new System.Drawing.Point(357, 12);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(245, 43);
            this.gradientLabel2.TabIndex = 9;
            this.gradientLabel2.Text = "Lastest Products";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel2.TextColorBegin = System.Drawing.Color.DodgerBlue;
            this.gradientLabel2.TextColorEnd = System.Drawing.Color.MediumPurple;
            // 
            // ViewHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.flowLayoutPanel_allFather);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.flowLayoutPanel_categories);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ViewHomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel_categories.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel_allFather.ResumeLayout(false);
            this.groupBox_product.ResumeLayout(false);
            this.groupBox_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reviewedProductStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_productImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_categories;
        private System.Windows.Forms.Panel panel5;
        private CustomControl.GradientLabel gradientLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_allFather;
        private CustomControl.GradientLabel gradientLabel3;
        private CustomControl.GradientLabel gradientLabel2;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.Label label_prouductName;
        private FontAwesome.Sharp.IconButton iconButton_verification;
        private System.Windows.Forms.Label label_sponsor;
        private System.Windows.Forms.Label label_productAddress;
        private System.Windows.Forms.Label label_productPrice;
        private System.Windows.Forms.PictureBox pictureBox_productImage;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton_category_sample;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox_reviewedProductStar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label_colorMaker;
    }
}


namespace GUI
{
    partial class SubViewManageCategory
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
            this.comboBox_level1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_attributes = new System.Windows.Forms.Panel();
            this.panel_attribute = new System.Windows.Forms.Panel();
            this.rjButton_deleteAttribute = new CustomControls.RJControls.RJButton();
            this.rjTextBox_attriibuteName = new CustomControls.RJControls.RJTextBox();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_level2 = new System.Windows.Forms.ComboBox();
            this.comboBox_level3 = new System.Windows.Forms.ComboBox();
            this.panel_firstClassCategory = new System.Windows.Forms.Panel();
            this.panel_category = new System.Windows.Forms.Panel();
            this.rjButton_category = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton_refreshDataField = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label_attributeQuantity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_ancestorName = new System.Windows.Forms.ComboBox();
            this.rjButton_addAttribute = new CustomControls.RJControls.RJButton();
            this.rjButton_addCategory = new CustomControls.RJControls.RJButton();
            this.rjButton_deleteCategory = new CustomControls.RJControls.RJButton();
            this.rjTextBox_categoryId = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_ancestorId = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_categoryName = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.rjButton_update = new CustomControls.RJControls.RJButton();
            this.panel_attributes.SuspendLayout();
            this.panel_attribute.SuspendLayout();
            this.panel_firstClassCategory.SuspendLayout();
            this.panel_category.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_level1
            // 
            this.comboBox_level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_level1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_level1.FormattingEnabled = true;
            this.comboBox_level1.Location = new System.Drawing.Point(246, 103);
            this.comboBox_level1.Name = "comboBox_level1";
            this.comboBox_level1.Size = new System.Drawing.Size(163, 29);
            this.comboBox_level1.TabIndex = 23;
            this.comboBox_level1.SelectedIndexChanged += new System.EventHandler(this.ComboBox_level1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Level 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Level 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Level 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ancestor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id";
            // 
            // panel_attributes
            // 
            this.panel_attributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_attributes.AutoScroll = true;
            this.panel_attributes.Controls.Add(this.panel_attribute);
            this.panel_attributes.Location = new System.Drawing.Point(581, 200);
            this.panel_attributes.Name = "panel_attributes";
            this.panel_attributes.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.panel_attributes.Size = new System.Drawing.Size(283, 238);
            this.panel_attributes.TabIndex = 26;
            // 
            // panel_attribute
            // 
            this.panel_attribute.Controls.Add(this.rjButton_deleteAttribute);
            this.panel_attribute.Controls.Add(this.rjTextBox_attriibuteName);
            this.panel_attribute.Controls.Add(this.rjButton5);
            this.panel_attribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_attribute.Location = new System.Drawing.Point(0, 10);
            this.panel_attribute.Name = "panel_attribute";
            this.panel_attribute.Padding = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.panel_attribute.Size = new System.Drawing.Size(263, 50);
            this.panel_attribute.TabIndex = 0;
            // 
            // rjButton_deleteAttribute
            // 
            this.rjButton_deleteAttribute.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton_deleteAttribute.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton_deleteAttribute.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_deleteAttribute.BorderRadius = 10;
            this.rjButton_deleteAttribute.BorderSize = 0;
            this.rjButton_deleteAttribute.FlatAppearance.BorderSize = 0;
            this.rjButton_deleteAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_deleteAttribute.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_deleteAttribute.ForeColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteAttribute.Location = new System.Drawing.Point(215, 4);
            this.rjButton_deleteAttribute.Name = "rjButton_deleteAttribute";
            this.rjButton_deleteAttribute.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.rjButton_deleteAttribute.Size = new System.Drawing.Size(38, 38);
            this.rjButton_deleteAttribute.TabIndex = 2;
            this.rjButton_deleteAttribute.Text = "x";
            this.rjButton_deleteAttribute.TextColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteAttribute.UseVisualStyleBackColor = false;
            this.rjButton_deleteAttribute.Click += new System.EventHandler(this.RjButton_deleteAttribute_Click);
            // 
            // rjTextBox_attriibuteName
            // 
            this.rjTextBox_attriibuteName.AllowDrop = true;
            this.rjTextBox_attriibuteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox_attriibuteName.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_attriibuteName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_attriibuteName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_attriibuteName.BorderRadius = 10;
            this.rjTextBox_attriibuteName.BorderSize = 1;
            this.rjTextBox_attriibuteName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rjTextBox_attriibuteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_attriibuteName.Location = new System.Drawing.Point(15, 0);
            this.rjTextBox_attriibuteName.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.rjTextBox_attriibuteName.Multiline = false;
            this.rjTextBox_attriibuteName.Name = "rjTextBox_attriibuteName";
            this.rjTextBox_attriibuteName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_attriibuteName.PasswordChar = false;
            this.rjTextBox_attriibuteName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_attriibuteName.PlaceholderText = "";
            this.rjTextBox_attriibuteName.Size = new System.Drawing.Size(189, 36);
            this.rjTextBox_attriibuteName.TabIndex = 1;
            this.rjTextBox_attriibuteName.Texts = "";
            this.rjTextBox_attriibuteName.UnderlinedStyle = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton5.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton5.Enabled = false;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(3, 0);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(257, 45);
            this.rjButton5.TabIndex = 0;
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Attributes";
            // 
            // comboBox_level2
            // 
            this.comboBox_level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_level2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_level2.FormattingEnabled = true;
            this.comboBox_level2.Location = new System.Drawing.Point(458, 103);
            this.comboBox_level2.Name = "comboBox_level2";
            this.comboBox_level2.Size = new System.Drawing.Size(163, 29);
            this.comboBox_level2.TabIndex = 23;
            this.comboBox_level2.SelectedIndexChanged += new System.EventHandler(this.ComboBox_level2_SelectedIndexChanged);
            // 
            // comboBox_level3
            // 
            this.comboBox_level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_level3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_level3.FormattingEnabled = true;
            this.comboBox_level3.Location = new System.Drawing.Point(679, 103);
            this.comboBox_level3.Name = "comboBox_level3";
            this.comboBox_level3.Size = new System.Drawing.Size(163, 29);
            this.comboBox_level3.TabIndex = 23;
            this.comboBox_level3.SelectedIndexChanged += new System.EventHandler(this.ComboBox_level3_SelectedIndexChanged);
            // 
            // panel_firstClassCategory
            // 
            this.panel_firstClassCategory.AutoScroll = true;
            this.panel_firstClassCategory.Controls.Add(this.panel_category);
            this.panel_firstClassCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_firstClassCategory.Location = new System.Drawing.Point(0, 0);
            this.panel_firstClassCategory.Name = "panel_firstClassCategory";
            this.panel_firstClassCategory.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panel_firstClassCategory.Size = new System.Drawing.Size(213, 586);
            this.panel_firstClassCategory.TabIndex = 27;
            // 
            // panel_category
            // 
            this.panel_category.Controls.Add(this.rjButton_category);
            this.panel_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_category.Location = new System.Drawing.Point(0, 100);
            this.panel_category.Name = "panel_category";
            this.panel_category.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel_category.Size = new System.Drawing.Size(213, 52);
            this.panel_category.TabIndex = 0;
            // 
            // rjButton_category
            // 
            this.rjButton_category.BackColor = System.Drawing.Color.White;
            this.rjButton_category.BackgroundColor = System.Drawing.Color.White;
            this.rjButton_category.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_category.BorderRadius = 15;
            this.rjButton_category.BorderSize = 0;
            this.rjButton_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton_category.FlatAppearance.BorderSize = 0;
            this.rjButton_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_category.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton_category.Location = new System.Drawing.Point(5, 0);
            this.rjButton_category.Name = "rjButton_category";
            this.rjButton_category.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rjButton_category.Size = new System.Drawing.Size(203, 47);
            this.rjButton_category.TabIndex = 0;
            this.rjButton_category.Text = "Cetegory";
            this.rjButton_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton_category.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton_category.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = ">";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(641, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = ">";
            // 
            // iconButton_refreshDataField
            // 
            this.iconButton_refreshDataField.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton_refreshDataField.FlatAppearance.BorderSize = 0;
            this.iconButton_refreshDataField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_refreshDataField.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.iconButton_refreshDataField.IconColor = System.Drawing.Color.DimGray;
            this.iconButton_refreshDataField.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_refreshDataField.IconSize = 30;
            this.iconButton_refreshDataField.Location = new System.Drawing.Point(860, 95);
            this.iconButton_refreshDataField.Name = "iconButton_refreshDataField";
            this.iconButton_refreshDataField.Size = new System.Drawing.Size(40, 40);
            this.iconButton_refreshDataField.TabIndex = 30;
            this.iconButton_refreshDataField.UseVisualStyleBackColor = true;
            this.iconButton_refreshDataField.Click += new System.EventHandler(this.IconButton_refreshDataField_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "/10";
            // 
            // label_attributeQuantity
            // 
            this.label_attributeQuantity.AutoSize = true;
            this.label_attributeQuantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_attributeQuantity.Location = new System.Drawing.Point(747, 168);
            this.label_attributeQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.label_attributeQuantity.Name = "label_attributeQuantity";
            this.label_attributeQuantity.Size = new System.Drawing.Size(19, 21);
            this.label_attributeQuantity.TabIndex = 22;
            this.label_attributeQuantity.Text = "0";
            this.label_attributeQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ancestor";
            // 
            // comboBox_ancestorName
            // 
            this.comboBox_ancestorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_ancestorName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ancestorName.FormattingEnabled = true;
            this.comboBox_ancestorName.Location = new System.Drawing.Point(349, 339);
            this.comboBox_ancestorName.Name = "comboBox_ancestorName";
            this.comboBox_ancestorName.Size = new System.Drawing.Size(179, 29);
            this.comboBox_ancestorName.TabIndex = 23;
            this.comboBox_ancestorName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ancestorName_SelectedIndexChanged);
            // 
            // rjButton_addAttribute
            // 
            this.rjButton_addAttribute.BackColor = System.Drawing.Color.SpringGreen;
            this.rjButton_addAttribute.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.rjButton_addAttribute.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_addAttribute.BorderRadius = 15;
            this.rjButton_addAttribute.BorderSize = 0;
            this.rjButton_addAttribute.FlatAppearance.BorderSize = 0;
            this.rjButton_addAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_addAttribute.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_addAttribute.ForeColor = System.Drawing.Color.White;
            this.rjButton_addAttribute.Location = new System.Drawing.Point(670, 160);
            this.rjButton_addAttribute.Name = "rjButton_addAttribute";
            this.rjButton_addAttribute.Size = new System.Drawing.Size(55, 36);
            this.rjButton_addAttribute.TabIndex = 28;
            this.rjButton_addAttribute.Text = "+";
            this.rjButton_addAttribute.TextColor = System.Drawing.Color.White;
            this.rjButton_addAttribute.UseVisualStyleBackColor = false;
            this.rjButton_addAttribute.Click += new System.EventHandler(this.RjButton_addAttribute_Click);
            // 
            // rjButton_addCategory
            // 
            this.rjButton_addCategory.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_addCategory.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_addCategory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_addCategory.BorderRadius = 15;
            this.rjButton_addCategory.BorderSize = 0;
            this.rjButton_addCategory.FlatAppearance.BorderSize = 0;
            this.rjButton_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_addCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_addCategory.ForeColor = System.Drawing.Color.White;
            this.rjButton_addCategory.Location = new System.Drawing.Point(396, 400);
            this.rjButton_addCategory.Name = "rjButton_addCategory";
            this.rjButton_addCategory.Size = new System.Drawing.Size(132, 38);
            this.rjButton_addCategory.TabIndex = 28;
            this.rjButton_addCategory.Text = "Add";
            this.rjButton_addCategory.TextColor = System.Drawing.Color.White;
            this.rjButton_addCategory.UseVisualStyleBackColor = false;
            this.rjButton_addCategory.Click += new System.EventHandler(this.RjButton_addCategory_Click);
            // 
            // rjButton_deleteCategory
            // 
            this.rjButton_deleteCategory.BackColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteCategory.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjButton_deleteCategory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_deleteCategory.BorderRadius = 15;
            this.rjButton_deleteCategory.BorderSize = 0;
            this.rjButton_deleteCategory.FlatAppearance.BorderSize = 0;
            this.rjButton_deleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_deleteCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_deleteCategory.ForeColor = System.Drawing.Color.White;
            this.rjButton_deleteCategory.Location = new System.Drawing.Point(246, 400);
            this.rjButton_deleteCategory.Name = "rjButton_deleteCategory";
            this.rjButton_deleteCategory.Size = new System.Drawing.Size(132, 38);
            this.rjButton_deleteCategory.TabIndex = 28;
            this.rjButton_deleteCategory.Text = "Delete";
            this.rjButton_deleteCategory.TextColor = System.Drawing.Color.White;
            this.rjButton_deleteCategory.UseVisualStyleBackColor = false;
            this.rjButton_deleteCategory.Click += new System.EventHandler(this.RjButton_deleteCategory_Click);
            // 
            // rjTextBox_categoryId
            // 
            this.rjTextBox_categoryId.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_categoryId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_categoryId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_categoryId.BorderRadius = 10;
            this.rjTextBox_categoryId.BorderSize = 1;
            this.rjTextBox_categoryId.Enabled = false;
            this.rjTextBox_categoryId.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rjTextBox_categoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_categoryId.Location = new System.Drawing.Point(340, 194);
            this.rjTextBox_categoryId.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.rjTextBox_categoryId.Multiline = false;
            this.rjTextBox_categoryId.Name = "rjTextBox_categoryId";
            this.rjTextBox_categoryId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_categoryId.PasswordChar = false;
            this.rjTextBox_categoryId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_categoryId.PlaceholderText = "";
            this.rjTextBox_categoryId.Size = new System.Drawing.Size(199, 36);
            this.rjTextBox_categoryId.TabIndex = 1;
            this.rjTextBox_categoryId.Texts = "";
            this.rjTextBox_categoryId.UnderlinedStyle = false;
            // 
            // rjTextBox_ancestorId
            // 
            this.rjTextBox_ancestorId.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_ancestorId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_ancestorId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_ancestorId.BorderRadius = 10;
            this.rjTextBox_ancestorId.BorderSize = 1;
            this.rjTextBox_ancestorId.Enabled = false;
            this.rjTextBox_ancestorId.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_ancestorId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_ancestorId.Location = new System.Drawing.Point(340, 285);
            this.rjTextBox_ancestorId.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_ancestorId.Multiline = false;
            this.rjTextBox_ancestorId.Name = "rjTextBox_ancestorId";
            this.rjTextBox_ancestorId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_ancestorId.PasswordChar = false;
            this.rjTextBox_ancestorId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_ancestorId.PlaceholderText = "";
            this.rjTextBox_ancestorId.Size = new System.Drawing.Size(199, 39);
            this.rjTextBox_ancestorId.TabIndex = 24;
            this.rjTextBox_ancestorId.Texts = "";
            this.rjTextBox_ancestorId.UnderlinedStyle = false;
            // 
            // rjTextBox_categoryName
            // 
            this.rjTextBox_categoryName.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_categoryName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_categoryName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_categoryName.BorderRadius = 10;
            this.rjTextBox_categoryName.BorderSize = 1;
            this.rjTextBox_categoryName.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_categoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_categoryName.Location = new System.Drawing.Point(340, 238);
            this.rjTextBox_categoryName.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_categoryName.Multiline = false;
            this.rjTextBox_categoryName.Name = "rjTextBox_categoryName";
            this.rjTextBox_categoryName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_categoryName.PasswordChar = false;
            this.rjTextBox_categoryName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_categoryName.PlaceholderText = "";
            this.rjTextBox_categoryName.Size = new System.Drawing.Size(199, 39);
            this.rjTextBox_categoryName.TabIndex = 24;
            this.rjTextBox_categoryName.Texts = "";
            this.rjTextBox_categoryName.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderRadius = 10;
            this.rjTextBox5.BorderSize = 1;
            this.rjTextBox5.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(670, 96);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(183, 39);
            this.rjTextBox5.TabIndex = 24;
            this.rjTextBox5.Texts = "";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel2.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.gradientLabel2.Location = new System.Drawing.Point(170, -2);
            this.gradientLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(778, 44);
            this.gradientLabel2.TabIndex = 20;
            this.gradientLabel2.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel2.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 10;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(449, 96);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(183, 39);
            this.rjTextBox3.TabIndex = 24;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(340, 332);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(199, 39);
            this.rjTextBox1.TabIndex = 24;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.BeginColor = System.Drawing.Color.Plum;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(1, -2);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(169, 44);
            this.gradientLabel1.TabIndex = 19;
            this.gradientLabel1.Text = "All categories";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.DarkOrchid;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.MediumSlateBlue;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderRadius = 10;
            this.rjTextBox4.BorderSize = 1;
            this.rjTextBox4.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(237, 96);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(183, 39);
            this.rjTextBox4.TabIndex = 24;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // rjButton_update
            // 
            this.rjButton_update.BackColor = System.Drawing.Color.Azure;
            this.rjButton_update.BackgroundColor = System.Drawing.Color.Azure;
            this.rjButton_update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_update.BorderRadius = 15;
            this.rjButton_update.BorderSize = 0;
            this.rjButton_update.FlatAppearance.BorderSize = 0;
            this.rjButton_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_update.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_update.Location = new System.Drawing.Point(396, 444);
            this.rjButton_update.Name = "rjButton_update";
            this.rjButton_update.Size = new System.Drawing.Size(132, 38);
            this.rjButton_update.TabIndex = 28;
            this.rjButton_update.Text = "Update";
            this.rjButton_update.TextColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_update.UseVisualStyleBackColor = false;
            this.rjButton_update.Click += new System.EventHandler(this.RjButton_update_Click);
            // 
            // SubViewManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(952, 586);
            this.Controls.Add(this.iconButton_refreshDataField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rjButton_addAttribute);
            this.Controls.Add(this.rjButton_update);
            this.Controls.Add(this.rjButton_addCategory);
            this.Controls.Add(this.rjButton_deleteCategory);
            this.Controls.Add(this.panel_attributes);
            this.Controls.Add(this.rjTextBox_categoryId);
            this.Controls.Add(this.rjTextBox_ancestorId);
            this.Controls.Add(this.rjTextBox_categoryName);
            this.Controls.Add(this.comboBox_level3);
            this.Controls.Add(this.comboBox_level2);
            this.Controls.Add(this.comboBox_ancestorName);
            this.Controls.Add(this.comboBox_level1);
            this.Controls.Add(this.label_attributeQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjTextBox5);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.rjTextBox3);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.rjTextBox4);
            this.Controls.Add(this.panel_firstClassCategory);
            this.Name = "SubViewManageCategory";
            this.Text = "SubViewManageCategory";
            this.Load += new System.EventHandler(this.SubViewManageCategory_Load);
            this.panel_attributes.ResumeLayout(false);
            this.panel_attribute.ResumeLayout(false);
            this.panel_firstClassCategory.ResumeLayout(false);
            this.panel_category.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private CustomControl.GradientLabel gradientLabel2;
        private CustomControl.GradientLabel gradientLabel1;
        private System.Windows.Forms.ComboBox comboBox_level1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox_categoryName;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox rjTextBox_ancestorId;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private System.Windows.Forms.Panel panel_attributes;
        private System.Windows.Forms.Panel panel_attribute;
        private CustomControls.RJControls.RJTextBox rjTextBox_attriibuteName;
        private CustomControls.RJControls.RJButton rjButton5;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.ComboBox comboBox_level2;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private System.Windows.Forms.ComboBox comboBox_level3;
        private CustomControls.RJControls.RJTextBox rjTextBox_categoryId;
        private System.Windows.Forms.Panel panel_firstClassCategory;
        private CustomControls.RJControls.RJButton rjButton_deleteCategory;
        private CustomControls.RJControls.RJButton rjButton_addCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJButton rjButton_deleteAttribute;
        private CustomControls.RJControls.RJButton rjButton_addAttribute;
        private System.Windows.Forms.Panel panel_category;
        private CustomControls.RJControls.RJButton rjButton_category;
        private FontAwesome.Sharp.IconButton iconButton_refreshDataField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_attributeQuantity;
        private System.Windows.Forms.Label label11;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.ComboBox comboBox_ancestorName;
        private CustomControls.RJControls.RJButton rjButton_update;
    }
}
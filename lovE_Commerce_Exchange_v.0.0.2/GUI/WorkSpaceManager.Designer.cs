namespace GUI
{
    partial class WorkSpaceManager
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_role = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_manager_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_manager_image = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton_administrator = new FontAwesome.Sharp.IconButton();
            this.iconButton_logout = new FontAwesome.Sharp.IconButton();
            this.iconButton_dahsboard = new FontAwesome.Sharp.IconButton();
            this.iconButton_category = new FontAwesome.Sharp.IconButton();
            this.iconButton_product = new FontAwesome.Sharp.IconButton();
            this.iconButton_shopOwner = new FontAwesome.Sharp.IconButton();
            this.iconButton_user = new FontAwesome.Sharp.IconButton();
            this.panel_manager_workspace_body = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_role);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label_manager_name);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_manager_image);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 133);
            this.panel3.TabIndex = 0;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.ForeColor = System.Drawing.Color.DimGray;
            this.label_role.Location = new System.Drawing.Point(188, 44);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(83, 29);
            this.label_role.TabIndex = 1;
            this.label_role.Text = "Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(108, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Role";
            // 
            // label_manager_name
            // 
            this.label_manager_name.AutoSize = true;
            this.label_manager_name.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manager_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_manager_name.Location = new System.Drawing.Point(188, 15);
            this.label_manager_name.Name = "label_manager_name";
            this.label_manager_name.Size = new System.Drawing.Size(100, 29);
            this.label_manager_name.TabIndex = 1;
            this.label_manager_name.Text = "LoveCrush";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // button_manager_image
            // 
            this.button_manager_image.FlatAppearance.BorderSize = 0;
            this.button_manager_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manager_image.Location = new System.Drawing.Point(12, 3);
            this.button_manager_image.Name = "button_manager_image";
            this.button_manager_image.Size = new System.Drawing.Size(90, 90);
            this.button_manager_image.TabIndex = 0;
            this.button_manager_image.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.iconButton_administrator);
            this.panel2.Controls.Add(this.iconButton_logout);
            this.panel2.Controls.Add(this.iconButton_dahsboard);
            this.panel2.Controls.Add(this.iconButton_category);
            this.panel2.Controls.Add(this.iconButton_product);
            this.panel2.Controls.Add(this.iconButton_shopOwner);
            this.panel2.Controls.Add(this.iconButton_user);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 747);
            this.panel2.TabIndex = 4;
            // 
            // iconButton_administrator
            // 
            this.iconButton_administrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_administrator.FlatAppearance.BorderSize = 0;
            this.iconButton_administrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_administrator.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_administrator.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_administrator.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton_administrator.IconColor = System.Drawing.Color.LightGray;
            this.iconButton_administrator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_administrator.IconSize = 40;
            this.iconButton_administrator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_administrator.Location = new System.Drawing.Point(0, 398);
            this.iconButton_administrator.Name = "iconButton_administrator";
            this.iconButton_administrator.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_administrator.Size = new System.Drawing.Size(321, 53);
            this.iconButton_administrator.TabIndex = 11;
            this.iconButton_administrator.Text = "Administrator";
            this.iconButton_administrator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_administrator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_administrator.UseVisualStyleBackColor = true;
            this.iconButton_administrator.Click += new System.EventHandler(this.IconButton_administrator_Click);
            // 
            // iconButton_logout
            // 
            this.iconButton_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton_logout.FlatAppearance.BorderSize = 0;
            this.iconButton_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_logout.Font = new System.Drawing.Font("Sans Serif Collection", 6F);
            this.iconButton_logout.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButton_logout.IconColor = System.Drawing.Color.Salmon;
            this.iconButton_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_logout.IconSize = 40;
            this.iconButton_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.Location = new System.Drawing.Point(0, 694);
            this.iconButton_logout.Name = "iconButton_logout";
            this.iconButton_logout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_logout.Size = new System.Drawing.Size(321, 53);
            this.iconButton_logout.TabIndex = 10;
            this.iconButton_logout.Text = "Log out";
            this.iconButton_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_logout.UseVisualStyleBackColor = true;
            // 
            // iconButton_dahsboard
            // 
            this.iconButton_dahsboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_dahsboard.FlatAppearance.BorderSize = 0;
            this.iconButton_dahsboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_dahsboard.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_dahsboard.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_dahsboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton_dahsboard.IconColor = System.Drawing.Color.LightGreen;
            this.iconButton_dahsboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_dahsboard.IconSize = 40;
            this.iconButton_dahsboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_dahsboard.Location = new System.Drawing.Point(0, 345);
            this.iconButton_dahsboard.Name = "iconButton_dahsboard";
            this.iconButton_dahsboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_dahsboard.Size = new System.Drawing.Size(321, 53);
            this.iconButton_dahsboard.TabIndex = 9;
            this.iconButton_dahsboard.Text = "Dashboard";
            this.iconButton_dahsboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_dahsboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_dahsboard.UseVisualStyleBackColor = true;
            this.iconButton_dahsboard.Click += new System.EventHandler(this.IconButton_notification_Click);
            // 
            // iconButton_category
            // 
            this.iconButton_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_category.FlatAppearance.BorderSize = 0;
            this.iconButton_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_category.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_category.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_category.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconButton_category.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton_category.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_category.IconSize = 40;
            this.iconButton_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category.Location = new System.Drawing.Point(0, 292);
            this.iconButton_category.Name = "iconButton_category";
            this.iconButton_category.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_category.Size = new System.Drawing.Size(321, 53);
            this.iconButton_category.TabIndex = 5;
            this.iconButton_category.Text = "Category";
            this.iconButton_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_category.UseVisualStyleBackColor = true;
            this.iconButton_category.Click += new System.EventHandler(this.IconButton_category_Click);
            // 
            // iconButton_product
            // 
            this.iconButton_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_product.FlatAppearance.BorderSize = 0;
            this.iconButton_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_product.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_product.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_product.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iconButton_product.IconColor = System.Drawing.Color.Silver;
            this.iconButton_product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_product.IconSize = 40;
            this.iconButton_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_product.Location = new System.Drawing.Point(0, 239);
            this.iconButton_product.Name = "iconButton_product";
            this.iconButton_product.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_product.Size = new System.Drawing.Size(321, 53);
            this.iconButton_product.TabIndex = 3;
            this.iconButton_product.Text = "Products";
            this.iconButton_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_product.UseVisualStyleBackColor = true;
            // 
            // iconButton_shopOwner
            // 
            this.iconButton_shopOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_shopOwner.FlatAppearance.BorderSize = 0;
            this.iconButton_shopOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_shopOwner.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_shopOwner.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_shopOwner.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton_shopOwner.IconColor = System.Drawing.Color.Gold;
            this.iconButton_shopOwner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_shopOwner.IconSize = 40;
            this.iconButton_shopOwner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shopOwner.Location = new System.Drawing.Point(0, 186);
            this.iconButton_shopOwner.Name = "iconButton_shopOwner";
            this.iconButton_shopOwner.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_shopOwner.Size = new System.Drawing.Size(321, 53);
            this.iconButton_shopOwner.TabIndex = 2;
            this.iconButton_shopOwner.Text = "Shop Owners";
            this.iconButton_shopOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shopOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_shopOwner.UseVisualStyleBackColor = true;
            // 
            // iconButton_user
            // 
            this.iconButton_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_user.FlatAppearance.BorderSize = 0;
            this.iconButton_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_user.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_user.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_user.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconButton_user.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_user.IconSize = 40;
            this.iconButton_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_user.Location = new System.Drawing.Point(0, 133);
            this.iconButton_user.Name = "iconButton_user";
            this.iconButton_user.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_user.Size = new System.Drawing.Size(321, 53);
            this.iconButton_user.TabIndex = 1;
            this.iconButton_user.Text = "Users";
            this.iconButton_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_user.UseVisualStyleBackColor = true;
            this.iconButton_user.Click += new System.EventHandler(this.IconButton_user_Click);
            // 
            // panel_manager_workspace_body
            // 
            this.panel_manager_workspace_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_manager_workspace_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_manager_workspace_body.Location = new System.Drawing.Point(327, 50);
            this.panel_manager_workspace_body.Name = "panel_manager_workspace_body";
            this.panel_manager_workspace_body.Size = new System.Drawing.Size(907, 747);
            this.panel_manager_workspace_body.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manager WorkSpace";
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gradientLabel3.BeginColor = System.Drawing.Color.Plum;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel3.Location = new System.Drawing.Point(317, 50);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(10, 747);
            this.gradientLabel3.TabIndex = 7;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // WorkSpaceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1234, 797);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_manager_workspace_body);
            this.Name = "WorkSpaceManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkSpaceManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSpaceManager_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton_category;
        private FontAwesome.Sharp.IconButton iconButton_product;
        private FontAwesome.Sharp.IconButton iconButton_shopOwner;
        private FontAwesome.Sharp.IconButton iconButton_user;
        private System.Windows.Forms.Panel panel_manager_workspace_body;
        private FontAwesome.Sharp.IconButton iconButton_dahsboard;
        private FontAwesome.Sharp.IconButton iconButton_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_manager_image;
        private FontAwesome.Sharp.IconButton iconButton_administrator;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_manager_name;
        private CustomControl.GradientLabel gradientLabel3;
    }
}
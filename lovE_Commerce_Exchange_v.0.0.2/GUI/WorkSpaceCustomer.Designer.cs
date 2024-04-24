namespace GUI
{
    partial class WorkSpaceCustomer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton_logout = new FontAwesome.Sharp.IconButton();
            this.iconButton_messenger = new FontAwesome.Sharp.IconButton();
            this.iconButton_shop = new FontAwesome.Sharp.IconButton();
            this.iconButton_notification = new FontAwesome.Sharp.IconButton();
            this.iconButton_comment = new FontAwesome.Sharp.IconButton();
            this.iconButton_orders = new FontAwesome.Sharp.IconButton();
            this.iconButton_account = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_customer_workspace_body = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_current_tab_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCircularPictureBox();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.iconButton_logout);
            this.panel2.Controls.Add(this.iconButton_messenger);
            this.panel2.Controls.Add(this.iconButton_shop);
            this.panel2.Controls.Add(this.iconButton_notification);
            this.panel2.Controls.Add(this.iconButton_comment);
            this.panel2.Controls.Add(this.iconButton_orders);
            this.panel2.Controls.Add(this.iconButton_account);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 552);
            this.panel2.TabIndex = 1;
            // 
            // iconButton_logout
            // 
            this.iconButton_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton_logout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_logout.FlatAppearance.BorderSize = 0;
            this.iconButton_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_logout.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_logout.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButton_logout.IconColor = System.Drawing.Color.Salmon;
            this.iconButton_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_logout.IconSize = 40;
            this.iconButton_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.Location = new System.Drawing.Point(0, 499);
            this.iconButton_logout.Name = "iconButton_logout";
            this.iconButton_logout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_logout.Size = new System.Drawing.Size(321, 53);
            this.iconButton_logout.TabIndex = 7;
            this.iconButton_logout.Text = "Log out";
            this.iconButton_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_logout.UseVisualStyleBackColor = true;
            this.iconButton_logout.Click += new System.EventHandler(this.IconButton_logout_Click);
            // 
            // iconButton_messenger
            // 
            this.iconButton_messenger.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_messenger.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_messenger.FlatAppearance.BorderSize = 0;
            this.iconButton_messenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_messenger.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_messenger.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_messenger.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.iconButton_messenger.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton_messenger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_messenger.IconSize = 40;
            this.iconButton_messenger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_messenger.Location = new System.Drawing.Point(0, 385);
            this.iconButton_messenger.Name = "iconButton_messenger";
            this.iconButton_messenger.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_messenger.Size = new System.Drawing.Size(321, 53);
            this.iconButton_messenger.TabIndex = 6;
            this.iconButton_messenger.Text = "Messenger";
            this.iconButton_messenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_messenger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_messenger.UseVisualStyleBackColor = true;
            this.iconButton_messenger.Click += new System.EventHandler(this.IconButton_messenger_Click);
            // 
            // iconButton_shop
            // 
            this.iconButton_shop.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_shop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_shop.FlatAppearance.BorderSize = 0;
            this.iconButton_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_shop.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_shop.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_shop.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.iconButton_shop.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton_shop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_shop.IconSize = 40;
            this.iconButton_shop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shop.Location = new System.Drawing.Point(0, 332);
            this.iconButton_shop.Name = "iconButton_shop";
            this.iconButton_shop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_shop.Size = new System.Drawing.Size(321, 53);
            this.iconButton_shop.TabIndex = 5;
            this.iconButton_shop.Text = "My Shop";
            this.iconButton_shop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_shop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_shop.UseVisualStyleBackColor = true;
            this.iconButton_shop.Click += new System.EventHandler(this.IconButton_shop_Click);
            // 
            // iconButton_notification
            // 
            this.iconButton_notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_notification.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_notification.FlatAppearance.BorderSize = 0;
            this.iconButton_notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_notification.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_notification.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_notification.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton_notification.IconColor = System.Drawing.Color.LightGreen;
            this.iconButton_notification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_notification.IconSize = 40;
            this.iconButton_notification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_notification.Location = new System.Drawing.Point(0, 279);
            this.iconButton_notification.Name = "iconButton_notification";
            this.iconButton_notification.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_notification.Size = new System.Drawing.Size(321, 53);
            this.iconButton_notification.TabIndex = 4;
            this.iconButton_notification.Text = "Notification";
            this.iconButton_notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_notification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_notification.UseVisualStyleBackColor = true;
            this.iconButton_notification.Click += new System.EventHandler(this.IconButton_notification_Click);
            // 
            // iconButton_comment
            // 
            this.iconButton_comment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton_comment.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_comment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_comment.FlatAppearance.BorderSize = 0;
            this.iconButton_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_comment.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_comment.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_comment.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.iconButton_comment.IconColor = System.Drawing.Color.Silver;
            this.iconButton_comment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_comment.IconSize = 40;
            this.iconButton_comment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_comment.Location = new System.Drawing.Point(0, 226);
            this.iconButton_comment.Name = "iconButton_comment";
            this.iconButton_comment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_comment.Size = new System.Drawing.Size(321, 53);
            this.iconButton_comment.TabIndex = 3;
            this.iconButton_comment.Text = "Comments";
            this.iconButton_comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_comment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_comment.UseVisualStyleBackColor = false;
            this.iconButton_comment.Click += new System.EventHandler(this.IconButton_comment_Click);
            // 
            // iconButton_orders
            // 
            this.iconButton_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_orders.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_orders.FlatAppearance.BorderSize = 0;
            this.iconButton_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_orders.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_orders.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_orders.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton_orders.IconColor = System.Drawing.Color.Gold;
            this.iconButton_orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_orders.IconSize = 40;
            this.iconButton_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_orders.Location = new System.Drawing.Point(0, 173);
            this.iconButton_orders.Name = "iconButton_orders";
            this.iconButton_orders.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_orders.Size = new System.Drawing.Size(321, 53);
            this.iconButton_orders.TabIndex = 2;
            this.iconButton_orders.Text = "Orders";
            this.iconButton_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_orders.UseVisualStyleBackColor = true;
            this.iconButton_orders.Click += new System.EventHandler(this.IconButton_orders_Click);
            // 
            // iconButton_account
            // 
            this.iconButton_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_account.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.iconButton_account.FlatAppearance.BorderSize = 0;
            this.iconButton_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_account.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_account.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_account.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.iconButton_account.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton_account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_account.IconSize = 40;
            this.iconButton_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_account.Location = new System.Drawing.Point(0, 120);
            this.iconButton_account.Name = "iconButton_account";
            this.iconButton_account.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_account.Size = new System.Drawing.Size(321, 53);
            this.iconButton_account.TabIndex = 1;
            this.iconButton_account.Text = "Account";
            this.iconButton_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_account.UseVisualStyleBackColor = true;
            this.iconButton_account.Click += new System.EventHandler(this.IconButton_account_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjCircularPictureBox1);
            this.panel3.Controls.Add(this.label_customer_name);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 120);
            this.panel3.TabIndex = 0;
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_customer_name.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_name.ForeColor = System.Drawing.Color.DimGray;
            this.label_customer_name.Location = new System.Drawing.Point(149, 58);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(118, 32);
            this.label_customer_name.TabIndex = 0;
            this.label_customer_name.Text = "LoveCrush";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account of";
            // 
            // panel_customer_workspace_body
            // 
            this.panel_customer_workspace_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_customer_workspace_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_customer_workspace_body.Location = new System.Drawing.Point(327, 50);
            this.panel_customer_workspace_body.Name = "panel_customer_workspace_body";
            this.panel_customer_workspace_body.Size = new System.Drawing.Size(715, 552);
            this.panel_customer_workspace_body.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Home Page";
            // 
            // label_current_tab_name
            // 
            this.label_current_tab_name.AutoSize = true;
            this.label_current_tab_name.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_tab_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_current_tab_name.Location = new System.Drawing.Point(124, 13);
            this.label_current_tab_name.Name = "label_current_tab_name";
            this.label_current_tab_name.Size = new System.Drawing.Size(78, 29);
            this.label_current_tab_name.TabIndex = 3;
            this.label_current_tab_name.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(110, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = ">";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(18, 5);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 1;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gradientLabel3.BeginColor = System.Drawing.Color.Plum;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel3.Location = new System.Drawing.Point(318, 50);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(10, 552);
            this.gradientLabel3.TabIndex = 4;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // WorkSpaceCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1042, 602);
            this.Controls.Add(this.panel_customer_workspace_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_current_tab_name);
            this.Controls.Add(this.label2);
            this.Name = "WorkSpaceCustomer";
            this.Text = "CustomerWorkSpace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkSpaceCustomer_FormClosed);
            this.Load += new System.EventHandler(this.WorkSpaceCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton_messenger;
        private FontAwesome.Sharp.IconButton iconButton_notification;
        private FontAwesome.Sharp.IconButton iconButton_comment;
        private FontAwesome.Sharp.IconButton iconButton_orders;
        private FontAwesome.Sharp.IconButton iconButton_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_customer_workspace_body;
        private FontAwesome.Sharp.IconButton iconButton_shop;
        private FontAwesome.Sharp.IconButton iconButton_logout;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_current_tab_name;
        private System.Windows.Forms.Label label3;
        private RJCircularPictureBox rjCircularPictureBox1;
        private CustomControl.GradientLabel gradientLabel3;
    }
}
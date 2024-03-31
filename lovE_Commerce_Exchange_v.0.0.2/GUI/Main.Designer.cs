namespace GUI
{
    partial class Main
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
            this.panel_margin_left_side = new System.Windows.Forms.Panel();
            this.panel_margin_right_side = new System.Windows.Forms.Panel();
            this.panel_controlbox = new System.Windows.Forms.Panel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_maximize = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.iconButton_account_centre = new FontAwesome.Sharp.IconButton();
            this.iconButton_home = new FontAwesome.Sharp.IconButton();
            this.iconButton_shoppingcart = new FontAwesome.Sharp.IconButton();
            this.iconButton_search = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_controlbox.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_margin_left_side
            // 
            this.panel_margin_left_side.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_margin_left_side.Location = new System.Drawing.Point(12, 150);
            this.panel_margin_left_side.Name = "panel_margin_left_side";
            this.panel_margin_left_side.Size = new System.Drawing.Size(108, 411);
            this.panel_margin_left_side.TabIndex = 1;
            // 
            // panel_margin_right_side
            // 
            this.panel_margin_right_side.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_margin_right_side.Location = new System.Drawing.Point(877, 150);
            this.panel_margin_right_side.Name = "panel_margin_right_side";
            this.panel_margin_right_side.Size = new System.Drawing.Size(111, 411);
            this.panel_margin_right_side.TabIndex = 1;
            this.panel_margin_right_side.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel_controlbox
            // 
            this.panel_controlbox.BackColor = System.Drawing.Color.Pink;
            this.panel_controlbox.Controls.Add(this.button_minimize);
            this.panel_controlbox.Controls.Add(this.button_maximize);
            this.panel_controlbox.Controls.Add(this.button_exit);
            this.panel_controlbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controlbox.Location = new System.Drawing.Point(0, 0);
            this.panel_controlbox.Name = "panel_controlbox";
            this.panel_controlbox.Padding = new System.Windows.Forms.Padding(40, 0, 9, 0);
            this.panel_controlbox.Size = new System.Drawing.Size(997, 50);
            this.panel_controlbox.TabIndex = 2;
            this.panel_controlbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_controlbox_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.Lime;
            this.button_minimize.Location = new System.Drawing.Point(868, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(40, 50);
            this.button_minimize.TabIndex = 2;
            this.button_minimize.Text = "O";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.Button_minimize_Click);
            // 
            // button_maximize
            // 
            this.button_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_maximize.FlatAppearance.BorderSize = 0;
            this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maximize.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maximize.ForeColor = System.Drawing.Color.Yellow;
            this.button_maximize.Location = new System.Drawing.Point(908, 0);
            this.button_maximize.Name = "button_maximize";
            this.button_maximize.Size = new System.Drawing.Size(40, 50);
            this.button_maximize.TabIndex = 1;
            this.button_maximize.Text = "O";
            this.button_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_maximize.UseVisualStyleBackColor = true;
            this.button_maximize.Click += new System.EventHandler(this.Button_maximize_Click);
            // 
            // button_exit
            // 
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_exit.Location = new System.Drawing.Point(948, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 50);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "O";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_header.Controls.Add(this.iconButton_account_centre);
            this.panel_header.Controls.Add(this.iconButton_home);
            this.panel_header.Controls.Add(this.iconButton_shoppingcart);
            this.panel_header.Controls.Add(this.iconButton_search);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Controls.Add(this.pictureBox_logo);
            this.panel_header.Controls.Add(this.panel1);
            this.panel_header.Controls.Add(this.panel4);
            this.panel_header.Controls.Add(this.textBox_search);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 50);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(997, 94);
            this.panel_header.TabIndex = 3;
            // 
            // iconButton_account_centre
            // 
            this.iconButton_account_centre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_account_centre.FlatAppearance.BorderSize = 0;
            this.iconButton_account_centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_account_centre.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.iconButton_account_centre.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_account_centre.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton_account_centre.IconColor = System.Drawing.Color.DimGray;
            this.iconButton_account_centre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_account_centre.IconSize = 40;
            this.iconButton_account_centre.Location = new System.Drawing.Point(664, 11);
            this.iconButton_account_centre.Name = "iconButton_account_centre";
            this.iconButton_account_centre.Size = new System.Drawing.Size(130, 45);
            this.iconButton_account_centre.TabIndex = 11;
            this.iconButton_account_centre.Text = "Account";
            this.iconButton_account_centre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_account_centre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_account_centre.UseVisualStyleBackColor = true;
            // 
            // iconButton_home
            // 
            this.iconButton_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_home.FlatAppearance.BorderSize = 0;
            this.iconButton_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_home.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_home.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton_home.IconColor = System.Drawing.Color.DimGray;
            this.iconButton_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_home.IconSize = 40;
            this.iconButton_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.Location = new System.Drawing.Point(528, 11);
            this.iconButton_home.Name = "iconButton_home";
            this.iconButton_home.Size = new System.Drawing.Size(130, 45);
            this.iconButton_home.TabIndex = 11;
            this.iconButton_home.Text = "Home";
            this.iconButton_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_home.UseVisualStyleBackColor = true;
            // 
            // iconButton_shoppingcart
            // 
            this.iconButton_shoppingcart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_shoppingcart.FlatAppearance.BorderSize = 0;
            this.iconButton_shoppingcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_shoppingcart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton_shoppingcart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.iconButton_shoppingcart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_shoppingcart.Location = new System.Drawing.Point(800, 9);
            this.iconButton_shoppingcart.Name = "iconButton_shoppingcart";
            this.iconButton_shoppingcart.Size = new System.Drawing.Size(50, 50);
            this.iconButton_shoppingcart.TabIndex = 10;
            this.iconButton_shoppingcart.UseVisualStyleBackColor = true;
            // 
            // iconButton_search
            // 
            this.iconButton_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_search.FlatAppearance.BorderSize = 0;
            this.iconButton_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton_search.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_search.IconSize = 30;
            this.iconButton_search.Location = new System.Drawing.Point(384, 12);
            this.iconButton_search.Name = "iconButton_search";
            this.iconButton_search.Size = new System.Drawing.Size(40, 40);
            this.iconButton_search.TabIndex = 9;
            this.iconButton_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search key word1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search key word1";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Location = new System.Drawing.Point(126, 6);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(121, 80);
            this.pictureBox_logo.TabIndex = 7;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(877, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 94);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 94);
            this.panel4.TabIndex = 5;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_search.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_search.Location = new System.Drawing.Point(256, 11);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_search.Size = new System.Drawing.Size(122, 44);
            this.textBox_search.TabIndex = 2;
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_body.Location = new System.Drawing.Point(126, 150);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(745, 411);
            this.panel_body.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(997, 573);
            this.ControlBox = false;
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_controlbox);
            this.Controls.Add(this.panel_margin_right_side);
            this.Controls.Add(this.panel_margin_left_side);
            this.Controls.Add(this.panel_body);
            this.Name = "Main";
            this.panel_controlbox.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_margin_left_side;
        private System.Windows.Forms.Panel panel_margin_right_side;
        private System.Windows.Forms.Panel panel_controlbox;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_maximize;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel_header;
        private FontAwesome.Sharp.IconButton iconButton_shoppingcart;
        private FontAwesome.Sharp.IconButton iconButton_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_search;
        private FontAwesome.Sharp.IconButton iconButton_account_centre;
        private FontAwesome.Sharp.IconButton iconButton_home;
        private System.Windows.Forms.Panel panel_body;
    }
}
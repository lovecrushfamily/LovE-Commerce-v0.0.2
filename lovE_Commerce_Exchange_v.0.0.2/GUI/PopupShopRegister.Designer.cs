namespace GUI
{
    partial class PopupShopRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupShopRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_accept = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox_description = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_phoneNumber = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_address = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_shopName = new CustomControls.RJControls.RJTextBox();
            this.rjButton_register = new CustomControls.RJControls.RJButton();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_accept);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rjTextBox_description);
            this.panel1.Controls.Add(this.rjTextBox_phoneNumber);
            this.panel1.Controls.Add(this.rjTextBox_address);
            this.panel1.Controls.Add(this.rjTextBox_shopName);
            this.panel1.Controls.Add(this.rjButton_register);
            this.panel1.Controls.Add(this.gradientLabel3);
            this.panel1.Controls.Add(this.gradientLabel2);
            this.panel1.Controls.Add(this.gradientLabel1);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(40, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 503);
            this.panel1.TabIndex = 9;
            // 
            // checkBox_accept
            // 
            this.checkBox_accept.AutoSize = true;
            this.checkBox_accept.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_accept.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_accept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox_accept.Location = new System.Drawing.Point(489, 403);
            this.checkBox_accept.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.checkBox_accept.Name = "checkBox_accept";
            this.checkBox_accept.Size = new System.Drawing.Size(295, 25);
            this.checkBox_accept.TabIndex = 13;
            this.checkBox_accept.Text = "I accept with the Prolicy and Terms";
            this.checkBox_accept.UseVisualStyleBackColor = false;
            this.checkBox_accept.CheckedChanged += new System.EventHandler(this.CheckBox_accept_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(489, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 243);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 2000);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // rjTextBox_description
            // 
            this.rjTextBox_description.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_description.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_description.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_description.BorderRadius = 10;
            this.rjTextBox_description.BorderSize = 1;
            this.rjTextBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_description.Location = new System.Drawing.Point(96, 310);
            this.rjTextBox_description.Margin = new System.Windows.Forms.Padding(10);
            this.rjTextBox_description.Multiline = true;
            this.rjTextBox_description.Name = "rjTextBox_description";
            this.rjTextBox_description.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_description.PasswordChar = false;
            this.rjTextBox_description.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_description.PlaceholderText = "Description";
            this.rjTextBox_description.Size = new System.Drawing.Size(284, 118);
            this.rjTextBox_description.TabIndex = 11;
            this.rjTextBox_description.Texts = "";
            this.rjTextBox_description.UnderlinedStyle = true;
            // 
            // rjTextBox_phoneNumber
            // 
            this.rjTextBox_phoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_phoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_phoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_phoneNumber.BorderRadius = 10;
            this.rjTextBox_phoneNumber.BorderSize = 1;
            this.rjTextBox_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_phoneNumber.Location = new System.Drawing.Point(96, 257);
            this.rjTextBox_phoneNumber.Margin = new System.Windows.Forms.Padding(10);
            this.rjTextBox_phoneNumber.Multiline = false;
            this.rjTextBox_phoneNumber.Name = "rjTextBox_phoneNumber";
            this.rjTextBox_phoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_phoneNumber.PasswordChar = false;
            this.rjTextBox_phoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_phoneNumber.PlaceholderText = "Shop phone number";
            this.rjTextBox_phoneNumber.Size = new System.Drawing.Size(284, 35);
            this.rjTextBox_phoneNumber.TabIndex = 11;
            this.rjTextBox_phoneNumber.Texts = "";
            this.rjTextBox_phoneNumber.UnderlinedStyle = true;
            // 
            // rjTextBox_address
            // 
            this.rjTextBox_address.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_address.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_address.BorderRadius = 10;
            this.rjTextBox_address.BorderSize = 1;
            this.rjTextBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_address.Location = new System.Drawing.Point(96, 202);
            this.rjTextBox_address.Margin = new System.Windows.Forms.Padding(10);
            this.rjTextBox_address.Multiline = false;
            this.rjTextBox_address.Name = "rjTextBox_address";
            this.rjTextBox_address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_address.PasswordChar = false;
            this.rjTextBox_address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_address.PlaceholderText = "Address";
            this.rjTextBox_address.Size = new System.Drawing.Size(284, 35);
            this.rjTextBox_address.TabIndex = 11;
            this.rjTextBox_address.Texts = "";
            this.rjTextBox_address.UnderlinedStyle = true;
            // 
            // rjTextBox_shopName
            // 
            this.rjTextBox_shopName.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_shopName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_shopName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_shopName.BorderRadius = 10;
            this.rjTextBox_shopName.BorderSize = 1;
            this.rjTextBox_shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_shopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_shopName.Location = new System.Drawing.Point(96, 147);
            this.rjTextBox_shopName.Margin = new System.Windows.Forms.Padding(10);
            this.rjTextBox_shopName.Multiline = false;
            this.rjTextBox_shopName.Name = "rjTextBox_shopName";
            this.rjTextBox_shopName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_shopName.PasswordChar = false;
            this.rjTextBox_shopName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_shopName.PlaceholderText = "Shop name";
            this.rjTextBox_shopName.Size = new System.Drawing.Size(284, 35);
            this.rjTextBox_shopName.TabIndex = 11;
            this.rjTextBox_shopName.Texts = "";
            this.rjTextBox_shopName.UnderlinedStyle = true;
            // 
            // rjButton_register
            // 
            this.rjButton_register.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_register.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjButton_register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton_register.BorderRadius = 17;
            this.rjButton_register.BorderSize = 0;
            this.rjButton_register.Enabled = false;
            this.rjButton_register.FlatAppearance.BorderSize = 0;
            this.rjButton_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_register.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_register.ForeColor = System.Drawing.Color.AliceBlue;
            this.rjButton_register.Location = new System.Drawing.Point(687, 438);
            this.rjButton_register.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.rjButton_register.Name = "rjButton_register";
            this.rjButton_register.Size = new System.Drawing.Size(150, 40);
            this.rjButton_register.TabIndex = 10;
            this.rjButton_register.Text = "Register";
            this.rjButton_register.TextColor = System.Drawing.Color.AliceBlue;
            this.rjButton_register.UseVisualStyleBackColor = false;
            this.rjButton_register.Click += new System.EventHandler(this.RjButton_register_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.AutoSize = true;
            this.gradientLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel3.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientLabel3.Location = new System.Drawing.Point(150, 95);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(167, 25);
            this.gradientLabel3.TabIndex = 8;
            this.gradientLabel3.Text = "Shop information";
            this.gradientLabel3.TextColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientLabel3.TextColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.AutoSize = true;
            this.gradientLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientLabel2.Location = new System.Drawing.Point(572, 95);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(164, 25);
            this.gradientLabel2.TabIndex = 8;
            this.gradientLabel2.Text = "Policy and Terms";
            this.gradientLabel2.TextColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientLabel2.TextColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.AutoSize = true;
            this.gradientLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.BeginColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(269, 38);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(349, 41);
            this.gradientLabel1.TabIndex = 8;
            this.gradientLabel1.Text = "Welcome to shop register";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.SlateBlue;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(902, 503);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // PopupShopRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PopupShopRegister";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupShopRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.GradientLabel gradientLabel1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox rjTextBox_shopName;
        private CustomControls.RJControls.RJButton rjButton_register;
        private System.Windows.Forms.CheckBox checkBox_accept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox_description;
        private CustomControls.RJControls.RJTextBox rjTextBox_address;
        private CustomControl.GradientLabel gradientLabel3;
        private CustomControl.GradientLabel gradientLabel2;
        private CustomControls.RJControls.RJTextBox rjTextBox_phoneNumber;
    }
}
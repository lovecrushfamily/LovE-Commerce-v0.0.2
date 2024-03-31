namespace GUI
{
    partial class SignIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.rjButton_login = new CustomControls.RJControls.RJButton();
            this.rjTextBox_username = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox_password = new CustomControls.RJControls.RJTextBox();
            this.label_reset_password = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.checkBox_remember_password = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 60);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(985, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "o";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rjButton_login
            // 
            this.rjButton_login.BackColor = System.Drawing.Color.SlateBlue;
            this.rjButton_login.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rjButton_login.BorderColor = System.Drawing.Color.LightBlue;
            this.rjButton_login.BorderRadius = 25;
            this.rjButton_login.BorderSize = 2;
            this.rjButton_login.FlatAppearance.BorderSize = 0;
            this.rjButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_login.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_login.ForeColor = System.Drawing.Color.White;
            this.rjButton_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton_login.Location = new System.Drawing.Point(710, 339);
            this.rjButton_login.Name = "rjButton_login";
            this.rjButton_login.Size = new System.Drawing.Size(270, 53);
            this.rjButton_login.TabIndex = 1;
            this.rjButton_login.Text = "Log in";
            this.rjButton_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton_login.TextColor = System.Drawing.Color.White;
            this.rjButton_login.UseVisualStyleBackColor = false;
            // 
            // rjTextBox_username
            // 
            this.rjTextBox_username.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_username.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_username.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_username.BorderRadius = 10;
            this.rjTextBox_username.BorderSize = 2;
            this.rjTextBox_username.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_username.Location = new System.Drawing.Point(698, 139);
            this.rjTextBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_username.Multiline = false;
            this.rjTextBox_username.Name = "rjTextBox_username";
            this.rjTextBox_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_username.PasswordChar = false;
            this.rjTextBox_username.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_username.PlaceholderText = "Username";
            this.rjTextBox_username.Size = new System.Drawing.Size(282, 50);
            this.rjTextBox_username.TabIndex = 2;
            this.rjTextBox_username.Texts = "";
            this.rjTextBox_username.UnderlinedStyle = true;
            // 
            // rjTextBox_password
            // 
            this.rjTextBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_password.BorderRadius = 10;
            this.rjTextBox_password.BorderSize = 2;
            this.rjTextBox_password.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_password.Location = new System.Drawing.Point(698, 213);
            this.rjTextBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_password.Multiline = false;
            this.rjTextBox_password.Name = "rjTextBox_password";
            this.rjTextBox_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_password.PasswordChar = false;
            this.rjTextBox_password.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_password.PlaceholderText = "Password";
            this.rjTextBox_password.Size = new System.Drawing.Size(282, 50);
            this.rjTextBox_password.TabIndex = 2;
            this.rjTextBox_password.Texts = "";
            this.rjTextBox_password.UnderlinedStyle = true;
            // 
            // label_reset_password
            // 
            this.label_reset_password.AutoSize = true;
            this.label_reset_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reset_password.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_reset_password.Location = new System.Drawing.Point(767, 405);
            this.label_reset_password.Name = "label_reset_password";
            this.label_reset_password.Size = new System.Drawing.Size(166, 20);
            this.label_reset_password.TabIndex = 3;
            this.label_reset_password.Text = "Forgotten password?";
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_register.Location = new System.Drawing.Point(919, 494);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(79, 24);
            this.label_register.TabIndex = 3;
            this.label_register.Text = "Register";
            // 
            // checkBox_remember_password
            // 
            this.checkBox_remember_password.AutoSize = true;
            this.checkBox_remember_password.Font = new System.Drawing.Font("Sans Serif Collection", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_remember_password.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox_remember_password.Location = new System.Drawing.Point(719, 277);
            this.checkBox_remember_password.Name = "checkBox_remember_password";
            this.checkBox_remember_password.Size = new System.Drawing.Size(18, 17);
            this.checkBox_remember_password.TabIndex = 4;
            this.checkBox_remember_password.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_remember_password.UseVisualStyleBackColor = true;
            this.checkBox_remember_password.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(743, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Remember password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 79);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(292, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "LovE-Commerce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(706, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Can I have an account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(263, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Love the way you like";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(771, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 42);
            this.label5.TabIndex = 3;
            this.label5.Text = "Welcome";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 585);
            this.Controls.Add(this.checkBox_remember_password);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_reset_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjTextBox_password);
            this.Controls.Add(this.rjTextBox_username);
            this.Controls.Add(this.rjButton_login);
            this.Controls.Add(this.panel1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private CustomControls.RJControls.RJButton rjButton_login;
        private CustomControls.RJControls.RJTextBox rjTextBox_username;
        private CustomControls.RJControls.RJTextBox rjTextBox_password;
        private System.Windows.Forms.Label label_reset_password;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.CheckBox checkBox_remember_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
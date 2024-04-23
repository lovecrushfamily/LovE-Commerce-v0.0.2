namespace GUI
{
    partial class PopupForgetPassword
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
            this.rjButton_resetPassword = new CustomControls.RJControls.RJButton();
            this.rjTextBox_email = new CustomControls.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjButton_resetPassword
            // 
            this.rjButton_resetPassword.AutoSize = true;
            this.rjButton_resetPassword.BackColor = System.Drawing.Color.SlateBlue;
            this.rjButton_resetPassword.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rjButton_resetPassword.BorderColor = System.Drawing.Color.LightBlue;
            this.rjButton_resetPassword.BorderRadius = 20;
            this.rjButton_resetPassword.BorderSize = 2;
            this.rjButton_resetPassword.FlatAppearance.BorderSize = 0;
            this.rjButton_resetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_resetPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_resetPassword.ForeColor = System.Drawing.Color.White;
            this.rjButton_resetPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton_resetPassword.Location = new System.Drawing.Point(320, 318);
            this.rjButton_resetPassword.Name = "rjButton_resetPassword";
            this.rjButton_resetPassword.Size = new System.Drawing.Size(221, 43);
            this.rjButton_resetPassword.TabIndex = 6;
            this.rjButton_resetPassword.Text = "Reset my password";
            this.rjButton_resetPassword.TextColor = System.Drawing.Color.White;
            this.rjButton_resetPassword.UseVisualStyleBackColor = false;
            this.rjButton_resetPassword.Click += new System.EventHandler(this.RjButton_resetPassword_Click);
            // 
            // rjTextBox_email
            // 
            this.rjTextBox_email.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_email.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_email.BorderRadius = 10;
            this.rjTextBox_email.BorderSize = 1;
            this.rjTextBox_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_email.Location = new System.Drawing.Point(266, 248);
            this.rjTextBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_email.Multiline = false;
            this.rjTextBox_email.Name = "rjTextBox_email";
            this.rjTextBox_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_email.PasswordChar = false;
            this.rjTextBox_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_email.PlaceholderText = "Your authenticated email";
            this.rjTextBox_email.Size = new System.Drawing.Size(337, 36);
            this.rjTextBox_email.TabIndex = 0;
            this.rjTextBox_email.Texts = "";
            this.rjTextBox_email.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientLabel1);
            this.panel1.Controls.Add(this.rjButton_resetPassword);
            this.panel1.Controls.Add(this.rjTextBox_email);
            this.panel1.Controls.Add(this.gradientLabel2);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(60, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 463);
            this.panel1.TabIndex = 7;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.AutoSize = true;
            this.gradientLabel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel1.BeginColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(273, 58);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(283, 41);
            this.gradientLabel1.TabIndex = 8;
            this.gradientLabel1.Text = "Recovery password";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.SlateBlue;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel2.BeginColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.GhostWhite;
            this.gradientLabel2.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.Location = new System.Drawing.Point(147, 56);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(563, 172);
            this.gradientLabel2.TabIndex = 8;
            this.gradientLabel2.Text = "We\'ll send you a recovery code, you can use that code as your password and login " +
    "to our e-commerce platform,\r\nYou should change your password imediately after lo" +
    "gin successful";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradientLabel2.TextColorBegin = System.Drawing.Color.SlateBlue;
            this.gradientLabel2.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(862, 463);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // PopupForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.panel1);
            this.Name = "PopupForgetPassword";
            this.Padding = new System.Windows.Forms.Padding(60);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox_email;
        private CustomControls.RJControls.RJButton rjButton_resetPassword;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControl.GradientLabel gradientLabel2;
        private CustomControl.GradientLabel gradientLabel1;
    }
}
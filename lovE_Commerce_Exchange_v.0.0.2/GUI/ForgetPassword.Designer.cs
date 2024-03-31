namespace GUI
{
    partial class ForgetPassword
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
            this.rjButton_resetPassword.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_resetPassword.ForeColor = System.Drawing.Color.White;
            this.rjButton_resetPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton_resetPassword.Location = new System.Drawing.Point(170, 220);
            this.rjButton_resetPassword.Name = "rjButton_resetPassword";
            this.rjButton_resetPassword.Size = new System.Drawing.Size(303, 56);
            this.rjButton_resetPassword.TabIndex = 6;
            this.rjButton_resetPassword.Text = "Reset your password";
            this.rjButton_resetPassword.TextColor = System.Drawing.Color.White;
            this.rjButton_resetPassword.UseVisualStyleBackColor = false;
            // 
            // rjTextBox_email
            // 
            this.rjTextBox_email.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox_email.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_email.BorderRadius = 10;
            this.rjTextBox_email.BorderSize = 2;
            this.rjTextBox_email.Font = new System.Drawing.Font("Sans Serif Collection", 8F);
            this.rjTextBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_email.Location = new System.Drawing.Point(171, 144);
            this.rjTextBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_email.Multiline = false;
            this.rjTextBox_email.Name = "rjTextBox_email";
            this.rjTextBox_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_email.PasswordChar = false;
            this.rjTextBox_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox_email.PlaceholderText = "Email";
            this.rjTextBox_email.Size = new System.Drawing.Size(302, 50);
            this.rjTextBox_email.TabIndex = 0;
            this.rjTextBox_email.Texts = "";
            this.rjTextBox_email.UnderlinedStyle = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 386);
            this.Controls.Add(this.rjButton_resetPassword);
            this.Controls.Add(this.rjTextBox_email);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox_email;
        private CustomControls.RJControls.RJButton rjButton_resetPassword;
    }
}
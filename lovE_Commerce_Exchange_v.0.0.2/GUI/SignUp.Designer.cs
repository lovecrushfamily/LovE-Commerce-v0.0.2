namespace GUI
{
    partial class SignUp
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
            this.rjTextBox_email = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjButton_send_code = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // rjTextBox_email
            // 
            this.rjTextBox_email.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox_email.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox_email.BorderRadius = 10;
            this.rjTextBox_email.BorderSize = 2;
            this.rjTextBox_email.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox_email.Location = new System.Drawing.Point(85, 143);
            this.rjTextBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_email.Multiline = false;
            this.rjTextBox_email.Name = "rjTextBox_email";
            this.rjTextBox_email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_email.PasswordChar = false;
            this.rjTextBox_email.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjTextBox_email.PlaceholderText = "Email";
            this.rjTextBox_email.Size = new System.Drawing.Size(324, 50);
            this.rjTextBox_email.TabIndex = 3;
            this.rjTextBox_email.Texts = "";
            this.rjTextBox_email.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(181, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Register";
            // 
            // rjButton_send_code
            // 
            this.rjButton_send_code.BackColor = System.Drawing.Color.SlateBlue;
            this.rjButton_send_code.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.rjButton_send_code.BorderColor = System.Drawing.Color.LightBlue;
            this.rjButton_send_code.BorderRadius = 25;
            this.rjButton_send_code.BorderSize = 2;
            this.rjButton_send_code.FlatAppearance.BorderSize = 0;
            this.rjButton_send_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton_send_code.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton_send_code.ForeColor = System.Drawing.Color.White;
            this.rjButton_send_code.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton_send_code.Location = new System.Drawing.Point(107, 234);
            this.rjButton_send_code.Name = "rjButton_send_code";
            this.rjButton_send_code.Size = new System.Drawing.Size(270, 53);
            this.rjButton_send_code.TabIndex = 5;
            this.rjButton_send_code.Text = "Verify Email";
            this.rjButton_send_code.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton_send_code.TextColor = System.Drawing.Color.White;
            this.rjButton_send_code.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(927, 558);
            this.Controls.Add(this.rjButton_send_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rjTextBox_email);
            this.Name = "SignUp";
            this.Text = "SIgnUp";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox_email;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJButton rjButton_send_code;
    }
}
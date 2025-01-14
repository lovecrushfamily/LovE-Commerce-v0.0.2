﻿namespace GUI
{
    partial class WorkSpaceStaff
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
            this.panel_staff_workspace_body = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_staff_image = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton_logout = new FontAwesome.Sharp.IconButton();
            this.iconButton_products = new FontAwesome.Sharp.IconButton();
            this.iconButton_staff_info = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_staff_workspace_body
            // 
            this.panel_staff_workspace_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_staff_workspace_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_staff_workspace_body.Location = new System.Drawing.Point(327, 50);
            this.panel_staff_workspace_body.Name = "panel_staff_workspace_body";
            this.panel_staff_workspace_body.Size = new System.Drawing.Size(545, 524);
            this.panel_staff_workspace_body.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_staff_image);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 131);
            this.panel3.TabIndex = 0;
            // 
            // button_staff_image
            // 
            this.button_staff_image.FlatAppearance.BorderSize = 0;
            this.button_staff_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_staff_image.Location = new System.Drawing.Point(12, 12);
            this.button_staff_image.Name = "button_staff_image";
            this.button_staff_image.Size = new System.Drawing.Size(90, 90);
            this.button_staff_image.TabIndex = 1;
            this.button_staff_image.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(184, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Censor Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(108, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(184, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "LoveCrush";
            this.label6.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.iconButton_logout);
            this.panel2.Controls.Add(this.iconButton_products);
            this.panel2.Controls.Add(this.iconButton_staff_info);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 524);
            this.panel2.TabIndex = 7;
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
            this.iconButton_logout.Location = new System.Drawing.Point(0, 471);
            this.iconButton_logout.Name = "iconButton_logout";
            this.iconButton_logout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_logout.Size = new System.Drawing.Size(321, 53);
            this.iconButton_logout.TabIndex = 11;
            this.iconButton_logout.Text = "Log out";
            this.iconButton_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_logout.UseVisualStyleBackColor = true;
            // 
            // iconButton_products
            // 
            this.iconButton_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_products.FlatAppearance.BorderSize = 0;
            this.iconButton_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_products.Font = new System.Drawing.Font("Sans Serif Collection", 6F);
            this.iconButton_products.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_products.IconChar = FontAwesome.Sharp.IconChar.Hourglass1;
            this.iconButton_products.IconColor = System.Drawing.Color.Gold;
            this.iconButton_products.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_products.IconSize = 40;
            this.iconButton_products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_products.Location = new System.Drawing.Point(0, 184);
            this.iconButton_products.Name = "iconButton_products";
            this.iconButton_products.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_products.Size = new System.Drawing.Size(321, 53);
            this.iconButton_products.TabIndex = 2;
            this.iconButton_products.Text = "Products";
            this.iconButton_products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_products.UseVisualStyleBackColor = true;
            this.iconButton_products.Click += new System.EventHandler(this.IconButton_orders_Click);
            // 
            // iconButton_staff_info
            // 
            this.iconButton_staff_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_staff_info.FlatAppearance.BorderSize = 0;
            this.iconButton_staff_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_staff_info.Font = new System.Drawing.Font("Sans Serif Collection", 6F);
            this.iconButton_staff_info.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_staff_info.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton_staff_info.IconColor = System.Drawing.Color.SkyBlue;
            this.iconButton_staff_info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_staff_info.IconSize = 40;
            this.iconButton_staff_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_staff_info.Location = new System.Drawing.Point(0, 131);
            this.iconButton_staff_info.Name = "iconButton_staff_info";
            this.iconButton_staff_info.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton_staff_info.Size = new System.Drawing.Size(321, 53);
            this.iconButton_staff_info.TabIndex = 1;
            this.iconButton_staff_info.Text = "Staff";
            this.iconButton_staff_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_staff_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_staff_info.UseVisualStyleBackColor = true;
            this.iconButton_staff_info.Click += new System.EventHandler(this.IconButton_staff_info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Staff  WorkSpace";
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
            this.gradientLabel3.Size = new System.Drawing.Size(10, 524);
            this.gradientLabel3.TabIndex = 9;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // WorkSpaceStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(872, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_staff_workspace_body);
            this.Name = "WorkSpaceStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WorkSpaceStaff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkSpaceStaff_FormClosing);
            this.Load += new System.EventHandler(this.WorkSpaceStaff_Load);
            this.ParentChanged += new System.EventHandler(this.WorkSpaceStaff_ParentChanged);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_staff_workspace_body;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton_products;
        private FontAwesome.Sharp.IconButton iconButton_staff_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_staff_image;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton_logout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomControl.GradientLabel gradientLabel3;
    }
}
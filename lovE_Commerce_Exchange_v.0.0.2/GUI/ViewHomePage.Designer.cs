namespace GUI
{
    partial class ViewHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHomePage));
            this.flowLayoutPanel_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton_category_sample = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel_allFather = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.flowLayoutPanel_categories.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel_allFather.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_categories
            // 
            this.flowLayoutPanel_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_categories.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel_categories.Controls.Add(this.panel5);
            this.flowLayoutPanel_categories.Controls.Add(this.iconButton_category_sample);
            this.flowLayoutPanel_categories.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_categories.Name = "flowLayoutPanel_categories";
            this.flowLayoutPanel_categories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_categories.Size = new System.Drawing.Size(324, 579);
            this.flowLayoutPanel_categories.TabIndex = 5;
            this.flowLayoutPanel_categories.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.gradientLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 20);
            this.panel5.Size = new System.Drawing.Size(320, 60);
            this.panel5.TabIndex = 1;
            // 
            // iconButton_category_sample
            // 
            this.iconButton_category_sample.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_category_sample.FlatAppearance.BorderSize = 0;
            this.iconButton_category_sample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_category_sample.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton_category_sample.Font = new System.Drawing.Font("Montserrat", 10F);
            this.iconButton_category_sample.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iconButton_category_sample.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_category_sample.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton_category_sample.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_category_sample.IconSize = 40;
            this.iconButton_category_sample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category_sample.Location = new System.Drawing.Point(3, 69);
            this.iconButton_category_sample.Name = "iconButton_category_sample";
            this.iconButton_category_sample.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton_category_sample.Size = new System.Drawing.Size(320, 60);
            this.iconButton_category_sample.TabIndex = 0;
            this.iconButton_category_sample.Tag = "sample";
            this.iconButton_category_sample.Text = "Category Name";
            this.iconButton_category_sample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_category_sample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_category_sample.UseVisualStyleBackColor = true;
            this.iconButton_category_sample.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // flowLayoutPanel_allFather
            // 
            this.flowLayoutPanel_allFather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_allFather.AutoScroll = true;
            this.flowLayoutPanel_allFather.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel_allFather.Controls.Add(this.groupBox1);
            this.flowLayoutPanel_allFather.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.flowLayoutPanel_allFather.Location = new System.Drawing.Point(342, 58);
            this.flowLayoutPanel_allFather.Name = "flowLayoutPanel_allFather";
            this.flowLayoutPanel_allFather.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel_allFather.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_allFather.Size = new System.Drawing.Size(709, 533);
            this.flowLayoutPanel_allFather.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.iconButton4);
            this.groupBox1.Controls.Add(this.iconButton5);
            this.groupBox1.Controls.Add(this.iconButton6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.groupBox1.Size = new System.Drawing.Size(245, 451);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 283);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.label1.Size = new System.Drawing.Size(230, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điện thoại Apple iPhone 15 128GBwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww" +
    "wwwwwwwwwwwww\r\nwwww\r\nwwww\r\n";
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Certificate;
            this.iconButton1.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(15, 247);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(113, 31);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Verification";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(142, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sponsor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nha Trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(16, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "20.000.000 đ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton2.IconColor = System.Drawing.Color.Gold;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(131, 348);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(30, 30);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton3.IconColor = System.Drawing.Color.Gold;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(101, 348);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(30, 30);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton4.IconColor = System.Drawing.Color.Gold;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(71, 348);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(30, 30);
            this.iconButton4.TabIndex = 2;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton5.IconColor = System.Drawing.Color.Gold;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.Location = new System.Drawing.Point(41, 348);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(30, 30);
            this.iconButton5.TabIndex = 2;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton6.IconColor = System.Drawing.Color.Gold;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 25;
            this.iconButton6.Location = new System.Drawing.Point(11, 348);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(30, 30);
            this.iconButton6.TabIndex = 2;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(215, 430);
            this.label5.TabIndex = 3;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel3.BeginColor = System.Drawing.Color.Thistle;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel3.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.Location = new System.Drawing.Point(652, 12);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(399, 43);
            this.gradientLabel3.TabIndex = 8;
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BeginColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.EndColor = System.Drawing.Color.Thistle;
            this.gradientLabel2.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.Location = new System.Drawing.Point(342, 12);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(311, 43);
            this.gradientLabel2.TabIndex = 9;
            this.gradientLabel2.Text = "Lastest Products";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientLabel2.TextColorBegin = System.Drawing.Color.RoyalBlue;
            this.gradientLabel2.TextColorEnd = System.Drawing.Color.MediumPurple;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.AutoSize = true;
            this.gradientLabel1.BeginColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientLabel1.EndColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradientLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(10, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(202, 62);
            this.gradientLabel1.TabIndex = 1;
            this.gradientLabel1.Text = "Category";
            this.gradientLabel1.TextColorBegin = System.Drawing.Color.Orchid;
            this.gradientLabel1.TextColorEnd = System.Drawing.Color.MediumSlateBlue;
            // 
            // ViewHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 603);
            this.Controls.Add(this.gradientLabel3);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.flowLayoutPanel_allFather);
            this.Controls.Add(this.flowLayoutPanel_categories);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ViewHomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel_categories.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel_allFather.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_categories;
        private FontAwesome.Sharp.IconButton iconButton_category_sample;
        private System.Windows.Forms.Panel panel5;
        private CustomControl.GradientLabel gradientLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_allFather;
        private CustomControl.GradientLabel gradientLabel3;
        private CustomControl.GradientLabel gradientLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Label label5;
    }
}


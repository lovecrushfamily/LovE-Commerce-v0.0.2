using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomControl
{
    public class MyNumericUpDown : NumericUpDown
    {
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;

        public MyNumericUpDown()
        {
            Controls[0].Hide();
        }

        [Category("RJ Code Advance")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    this.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                this.Text = "";
                SetPlaceholder();
            }
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(this.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                this.Text = placeholderText;
                this.ForeColor = placeholderColor;
                
            }
        }
    }
}

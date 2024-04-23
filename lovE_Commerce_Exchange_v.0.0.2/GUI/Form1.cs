using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Category[] categories;
        public Form1()
        {
            InitializeComponent();
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(rjButton2, rjButton2.Width, 0);

        }
    }
}

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
    public partial class PopupDragPicture : Form
    {
        public PopupDragPicture()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {

            var data =  e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var item = data as string[];
                if(item.Length > 0)
                {
                    label1.Visible = false;
                    pictureBox1.Image = Image.FromFile(item[0]);

                }
            }
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Jpeg2Bitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FitPic(Image pic, PictureBox box)
        {
            box.Width = 200;
            box.Height = 180;
            pic = resizeImage(pic, new Size(200, 200));
           
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog(this) != DialogResult.Cancel)
            {
                tbJpeg.Text = ofd.FileName;
            }
            Image pic = resizeImage(new Bitmap(tbJpeg.Text), new Size(200, 200));
            jpeg.Image = new Bitmap(pic);
            pic.Dispose();
        }

        private void output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                tbBitmap.Text = fbd.SelectedPath;
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {
            var bitmapImage = Image.FromFile(tbJpeg.Text);
            string oldName = Path.GetFileNameWithoutExtension(tbJpeg.Text);
            string newName = tbBitmap.Text +"\\" + oldName + ".bmp";
            bitmapImage.Save(newName, ImageFormat.Bmp);

            /*** for showing in picture box  ***/
            Image pic = resizeImage(new Bitmap(newName), new Size(200, 200));
            bitmap.Image = new Bitmap(pic);
            pic.Dispose();
        }
    }
}

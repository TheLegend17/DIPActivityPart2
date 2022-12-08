using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPActivityPart2
{
    public partial class Form1 : Form
    {
        Bitmap picture, back, colorGreen;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picture = new Bitmap(openFileDialog1.FileName);
            image.Image = picture;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            back = new Bitmap(openFileDialog2.FileName);
            background.Image = back;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            colorGreen = new Bitmap(picture.Width, picture.Height);
            Color myGreen = Color.FromArgb(0, 0, 255);
            int greyGreen = Convert.ToInt32((myGreen.R + myGreen.G +myGreen.B) / 3);
            int threshold = 5;
            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    Color pixel = picture.GetPixel(x, y);
                    Color backPixel = back.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greyGreen);
                    if (subtractValue < threshold)
                        colorGreen.SetPixel(x, y, backPixel);
                    else
                        colorGreen.SetPixel(x, y, pixel);
                }
            }
            final.Image = colorGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salera_ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
            bcopy.Enabled = true;
            grey.Enabled = true;
            invert.Enabled = true;
            hist.Enabled = true;
            sepia.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void bcopy_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            label1.Text = "Copying...";
            Application.DoEvents();

            for(int x=0; x<loaded.Width; x++)
            {
                for(int y=0; y<loaded.Height; y++)
                {
                    processed.SetPixel(x,y,loaded.GetPixel(x,y));
                }
            }

            pictureBox2.Image = processed;
            label1.Text = "Copy successful!";
        }

        private void grey_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            label1.Text = "Greyscaling...";
            Application.DoEvents();

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x,y);
                    int grey = (pixel.R + pixel.G + pixel.B)/3;
                    processed.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }


            pictureBox2.Image = processed;
            label1.Text = "Greyscale successful!";
        }

        private void invert_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            label1.Text = "Inverting...";
            Application.DoEvents();

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B));
                }
            }

            pictureBox2.Image = processed;
            label1.Text = "Inversion successful!";
        }

        private void hist_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);

            label1.Text = "Graphing...";
            Application.DoEvents();

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    processed.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }

            }

            int[] histdata = new int[256];
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = processed.GetPixel(x, y);
                    histdata[pixel.R]++;
                }
            }

            Bitmap histmap = new Bitmap(256, 800);

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    Color pixel = Color.White;
                    histmap.SetPixel(x,y, pixel);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x]/5, 800); y++)
                {
                    Color pixel = Color.Black;
                    histmap.SetPixel(x, 799-y, pixel);
                }
            }

            pictureBox2.Image = histmap;
            label1.Text = "Histogram drawn!";
            processed = histmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            label1.Text = "Applying sepia...";
            Application.DoEvents();

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    Color pixel = loaded.GetPixel(x, y);
                    int  red = (int) Math.Min((pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189),255.0);
                    int green = (int) Math.Min((pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168), 255.0);
                    int blue = (int) Math.Min((pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131), 255.0);
                    processed.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }

            }

            pictureBox2.Image = processed;
            label1.Text = "Congratulations! You are now in Mexico.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }
    }
}

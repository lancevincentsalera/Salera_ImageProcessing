using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace Salera_ImageProcessing
{
    public partial class Form2 : Form
    {
        Bitmap foreground, background, resultImage;
        Device[] allDevices;
        Device firstDevice;
        private Form form1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void openForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                foreground = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = foreground;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog(this);
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                background = new Bitmap(openFileDialog2.FileName);
                pictureBox2.Image = background;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opencam_Click(object sender, EventArgs e)
        {
            if(firstDevice == null)
            {
                try
                {
                    allDevices = DeviceManager.GetAllDevices();
                    firstDevice = allDevices[0];
                    if (allDevices.Length > 0)
                    {
                        string deviceInfo = "Available Devices:\n\n";

                        for (int i = 0; i < allDevices.Length; i++)
                        {
                            deviceInfo += $"Device {i + 1}: {allDevices[i].Name} - Version: {allDevices[i].Version}\n";
                        }
                        MessageBox.Show(deviceInfo, "Available Devices");

                        firstDevice.ShowWindow(pictureBox4);
                    }
                    else
                    {
                        MessageBox.Show("No webcam devices found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing webcam: {ex.Message}");
                }
            }
        }

        private void closecam_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null && timer1.Enabled)
            {
                timer1.Stop();
                pictureBox2.Image.Dispose();
                pictureBox2.Image = null;
                background = null;
            }
            if (pictureBox3.Image != null && timer2.Enabled)
            {
                timer2.Stop();
                pictureBox3.Image.Dispose();
                pictureBox3.Image = null;
            }
            if (firstDevice != null)
            {
                firstDevice.Stop();
                firstDevice = null;
            }
        }

        private void capture_Click(object sender, EventArgs e)
        {
            if (firstDevice == null)
            {
                MessageBox.Show("No device selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            if (timer2.Enabled)
            {
                timer2.Stop();
            }
            if (pictureBox2 != null && pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
                background = null;
            }
            if (pictureBox3 != null && pictureBox3.Image != null)
            {
                pictureBox3.Image.Dispose();
                pictureBox3.Image = null;
            }
            try
            {
                background = CaptureAndDisplayImage();
                pictureBox2.Image = background;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nPlease open webcam first");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (firstDevice != null)
            {
                background = CaptureAndDisplayImage();
                if (background != null)
                {
                    if (pictureBox2 != null && pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                    }
                    pictureBox2.Image = background;
                }
            }
        }

        private void capturert_Click(object sender, EventArgs e)
        {
            if(firstDevice != null)
            {
                if (pictureBox3 != null && pictureBox3.Image != null)
                {
                    pictureBox3.Image.Dispose();
                    pictureBox3.Image = null;
                }
                timer1.Start();
            }
            else
            {
                MessageBox.Show("No device selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Bitmap newFrame = CaptureAndDisplayImage();
            if (newFrame != null)
            {
                subtract(newFrame);
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (background == null || foreground == null)
            {
                MessageBox.Show("Please load both images before subtracting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (timer1.Enabled && pictureBox2 != null && pictureBox2.Image != null)
            {
                timer2.Start();
            }
            else
            {
                subtract(background);
            }
        }

        public void subtract(Bitmap frame)
        {
            resultImage = new Bitmap(foreground.Width, foreground.Height);
            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 10;
            for (int x = 0; x < foreground.Width; x++)
            {
                for (int y = 0; y < foreground.Height; y++)
                {
                    Color fg = foreground.GetPixel(x, y);
                    Color bg = frame.GetPixel(x, y);
                    int grey = (fg.R + fg.G + fg.B) / 3;
                    bool s = Math.Abs(grey - greygreen) < threshold;
                    if (s)
                        resultImage.SetPixel(x, y, bg);
                    else
                        resultImage.SetPixel(x, y, fg);
                }
            }
            pictureBox3.Image = resultImage;
        }

        private Bitmap CaptureAndDisplayImage()
        {
            if (firstDevice == null)
            {
                MessageBox.Show("No device selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            firstDevice.Sendmessage();
            IDataObject data = Clipboard.GetDataObject();
            if (data != null && data.GetData("System.Drawing.Bitmap", true) != null)
            {
                Image bmap = (Image)data.GetData("System.Drawing.Bitmap", true);
                if (bmap != null)
                {
                    return new Bitmap(bmap);
                }
            }
            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

    }
}

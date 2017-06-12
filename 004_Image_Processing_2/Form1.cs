using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _004_Image_Processing_2
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox2;
        Bitmap copy;
        Chart mychart;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*pictureBox2 = new PictureBox();
            pictureBox2.SetBounds(457, 27, 580, 580);
            pictureBox2.Name = "sonuc";
            pictureBox2.BackColor = Color.Black;
            this.Controls.Add(pictureBox2);*/
            pictureBox2 = new PictureBox();
            chart1.Visible = false;
            chart2.Visible = false;
        }
        private void setPictureBox(Bitmap copy)
        {
            Controls.Remove(pictureBox2);
            pictureBox2.SetBounds(457, 27, copy.Width, copy.Height);
            pictureBox2.Name = "result";
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = copy;
            Controls.Add(pictureBox2);
        }

        private void textboxBrightness_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image File (*.bmp, *.jpg, *.png)|(*.bmp;*.jpg;*.png)";
                if (DialogResult.OK == openFile.ShowDialog())
                {
                    pictureBox1.Image = Image.FromFile(openFile.FileName);
                }
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy=ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "red");
            setPictureBox(copy);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "green");
            setPictureBox(copy);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "blue");
            setPictureBox(copy);
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = Brightness.SetBrightness((Bitmap)pictureBox1.Image, Convert.ToInt32(TextboxBrightness.Text));
            setPictureBox(copy);
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "gray");
            setPictureBox(copy);
        }

        private void ınvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "invert");
            setPictureBox(copy);
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            copy = new Bitmap((Bitmap)pictureBox1.Image);
            Brightness.SetBrightness(copy, Convert.ToInt32(TextboxBrightness.Text));
            setPictureBox(copy);
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            copy = new Bitmap((Bitmap)pictureBox1.Image);
            Contrast.setContrast(copy, Convert.ToInt32(TextboxContrast.Text));
            setPictureBox(copy);
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            copy = new Bitmap((Bitmap)pictureBox1.Image);
            Normalize.setNormalize(copy);
            setPictureBox(copy);
        }

        private void btnReverseX_Click(object sender, EventArgs e)
        {
            copy = new Bitmap((Bitmap)pictureBox1.Image);
            Reverse.setReverseX((Bitmap)pictureBox1.Image, copy);
            setPictureBox(copy);
        }

        private void btnReverseY_Click(object sender, EventArgs e)
        {
            copy = new Bitmap((Bitmap)pictureBox1.Image);
            Reverse.setReverseY((Bitmap)pictureBox1.Image, copy);
            setPictureBox(copy);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double degress;
            if (string.IsNullOrEmpty(textboxDegress.Text))
                degress = 0;
            else
                degress = Convert.ToDouble(textboxDegress.Text);

            copy = Rotate.setRotate((Bitmap)pictureBox1.Image, degress);
            setPictureBox(copy);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Controls.Remove(pictureBox2);
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            string[] shift = textboxShift.Text.Split(',');
            copy = Shift.setShift((Bitmap)pictureBox1.Image, shift);
            setPictureBox(copy);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            copy = Zoom.setZoomIn((Bitmap)pictureBox1.Image);
            setPictureBox(copy);
        }

        private void btnZoomIn2_Click(object sender, EventArgs e)
        {
            copy = Zoom.setZoomIn2((Bitmap)pictureBox1.Image);
            setPictureBox(copy);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            copy = Zoom.setZoomOut((Bitmap)pictureBox1.Image);
            setPictureBox(copy);
        }

        private void btnLoadChartRGB_Click_1(object sender, EventArgs e)
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();

            Bitmap bmap;
            if (pictureBox2.Image == null)
                bmap = (Bitmap)pictureBox1.Image;
            else
                bmap = (Bitmap)pictureBox2.Image;

            int[,] histogram = new int[3, 256];

            histogram = Histogram.getHistogram(bmap);

            for (int i = 0; i < 256; i++)
                chart1.Series["Red"].Points.AddXY(i, histogram[0, i]);
            for (int i = 0; i < 256; i++)
                chart1.Series["Green"].Points.AddXY(i, histogram[1, i]);
            for (int i = 0; i < 256; i++)
                chart1.Series["Blue"].Points.AddXY(i, histogram[2, i]);

            chart1.Visible = true;
            chart2.Visible = false;
        }

        private void btnLoadChartGray_Click(object sender, EventArgs e)
        {
            chart2.Series["Gray"].Points.Clear();

            Bitmap bmap;
            if (pictureBox2.Image == null)
                bmap = (Bitmap)pictureBox1.Image;
            else
                bmap = (Bitmap)pictureBox2.Image;

            byte[] arrayColor = new byte[256];
            int gray;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    gray = (bmap.GetPixel(i, j).R + bmap.GetPixel(i, j).G + bmap.GetPixel(i, j).B) / 3;
                    arrayColor[gray]++;
                }
            }

            for (int i = 0; i < arrayColor.Length; i++)
                chart2.Series["Gray"].Points.AddXY(i, arrayColor[i]);

            chart2.Visible = true;
            chart1.Visible = false;
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            int[,] histogram = Histogram.getHistogram((Bitmap)pictureBox1.Image);
            histogram = Histogram.getCumulativeHistogram(histogram);
            histogram = Histogram.getNormalizeCumulativeHistogram(histogram, pictureBox1.Image.Width * pictureBox1.Image.Height);
            copy = Histogram.setHistogramEqualization((Bitmap)pictureBox1.Image, histogram);
            setPictureBox(copy);
        }

        private void btnOtsu_Click(object sender, EventArgs e)
        {
            copy = ColorFilter.SetColorFilter((Bitmap)pictureBox1.Image, "gray");
            int tresholdValue = Otsu.getThresholdValue(copy);
            copy = Otsu.setThresholding((Bitmap)pictureBox1.Image, tresholdValue);
            setPictureBox(copy);
        }

        private void btnTresholding_Click(object sender, EventArgs e)
        {
            int tresholdValue;
            if (!string.IsNullOrEmpty(textboxTreshold.Text))
                tresholdValue = Convert.ToInt32(textboxTreshold.Text);
            else
                tresholdValue = 150;
            copy = Otsu.setThresholding((Bitmap)pictureBox1.Image, tresholdValue);
            setPictureBox(copy);
        }

        private void btnStretching_Click(object sender, EventArgs e)
        {
            string[] stretch = new string[2];
            if (!string.IsNullOrEmpty(textboxStretching.Text))
                stretch = textboxStretching.Text.Split(',');
            else
            {
                stretch[0] = "0";
                stretch[1] = "255";
            }
            copy = Histogram.setHistogramStretching((Bitmap)pictureBox1.Image, Convert.ToInt32(stretch[0]), Convert.ToInt32(stretch[1]));
            setPictureBox(copy);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Histogram
    {
        Histogram()
        {

        }

        public static int[,] getHistogram(Bitmap bmap)
        {
            int[,] histogram = new int[3, 256];

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    histogram[0, bmap.GetPixel(x, y).R]++;
                    histogram[1, bmap.GetPixel(x, y).G]++;
                    histogram[2, bmap.GetPixel(x, y).B]++;
                }
            }

            return histogram;
        }
        public static int[,] getCumulativeHistogram(int[,] histogram)
        {
            int[,] cumulativeHistogram = new int[3, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    cumulativeHistogram[0, i] += histogram[0, j];
                    cumulativeHistogram[1, i] += histogram[1, j];
                    cumulativeHistogram[2, i] += histogram[2, j];
                }
            }

            return cumulativeHistogram;
        }
        public static int[,] getNormalizeCumulativeHistogram(int[,] cumulativeHistogram, int pixel)
        {
            float[,] normalizeCumulativeHistogram = new float[3, 256];
            int[,] normal = new int[3, 256];

            for (int i = 0; i < 256; i++)
            {
                normalizeCumulativeHistogram[0, i] = (float)(cumulativeHistogram[0, i] * 255.0) / pixel;
                normalizeCumulativeHistogram[1, i] = (float)(cumulativeHistogram[1, i] * 255.0) / pixel;
                normalizeCumulativeHistogram[2, i] = (float)(cumulativeHistogram[2, i] * 255.0) / pixel;
            }

            for (int i = 0; i < 256; i++)
            {
                normal[0, i] = (int)Math.Round(normalizeCumulativeHistogram[0, i]);
                normal[1, i] = (int)Math.Round(normalizeCumulativeHistogram[1, i]);
                normal[2, i] = (int)Math.Round(normalizeCumulativeHistogram[2, i]);
            }

            return normal;
        }
        public static Bitmap setHistogramEqualization(Bitmap bmap, int[,] histogram)
        {
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);
            Color c;
            int r=0, g=0, b=0;
            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    for (int k = 0; k < 256; k++)
                    {
                        if (c.R == k)
                            r = histogram[0, k];
                        if (c.G == k)
                            g = histogram[0, k];
                        if (c.B == k)
                            b = histogram[0, k];
                    }
                    copy.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return copy;
        }
        public static Bitmap setHistogramStretching(Bitmap bmap,int newMin,int newMax) {
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);
            int minR = 255, maxR = 0, minG = 255, maxG = 0, minB = 255, maxB = 0;
            int newR,newG,newB;
            Color c;
            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    if (minR > c.R)
                        minR = c.R;
                    if (minG > c.G)
                        minG = c.G;
                    if (minB > c.B)
                        minB = c.B;
                    if (maxR < c.R)
                        maxR = c.R;
                    if (maxG < c.G)
                        maxG = c.G;
                    if (maxB < c.B)
                        maxB = c.B;
                }
            }

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    newR = ((newMax - newMin) * ((c.R - minR) / (maxR - minR))) + newMin;
                    newG = ((newMax - newMin) * ((c.G - minG) / (maxG - minG))) + newMin;
                    newB = ((newMax - newMin) * ((c.B - minB) / (maxB - minB))) + newMin;
                    copy.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return copy;
        }

    }
}

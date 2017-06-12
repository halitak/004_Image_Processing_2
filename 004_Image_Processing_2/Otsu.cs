using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Otsu
    {
        Otsu()
        {

        }

        public static int getThresholdValue(Bitmap bmap)
        {
            //otsu algoritm
            int thresholdValue= 150;
            double weight1 = 0, weight2 = 0, weightTotal = 0, total = 0, total2 = 0, mean1 = 0, mean2 = 0, sigma = 0;

            int[,] histogram = Histogram.getHistogram(bmap);

            weightTotal = bmap.Width * bmap.Height;

            for (int i = 0; i < 256; i++)
            {
                total2 += i * histogram[0, i];
            }

            for (int i = 0; i < 256; i++)
            {
                weight1 += histogram[0, i];
                if (weight1 == 0)
                    continue;
                weight2 = weightTotal - weight1;
                if (weight2 == 0)
                    break;

                total += (double)i * histogram[0, i];
                mean1 = total / weight1;
                mean2 = (total2 - total) / weight2;

                double sigmaSquare = weight1 * weight2 * (mean1 - mean2) * (mean1 - mean2);

                if (sigmaSquare > sigma)
                {
                    sigma = sigmaSquare;
                    thresholdValue = i;
                }
            }
            return thresholdValue;
        }
        public static Bitmap setThresholding(Bitmap bmap,int tresholdValue)
        {
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);
            int colorGray;
            Color c;
            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    colorGray = (c.R + c.G + c.B) / 3;
                    copy.SetPixel(x, y, Color.FromArgb(colorGray, colorGray, colorGray));
                }
            }
            for (int x = 0; x < copy.Width; x++)
            {
                for (int y = 0; y < copy.Height; y++)
                {
                    if (copy.GetPixel(x, y).R < tresholdValue)
                        copy.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        copy.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            return copy;
        }
    }
}

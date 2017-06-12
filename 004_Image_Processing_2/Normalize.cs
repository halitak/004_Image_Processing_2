using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Normalize
    {
        Normalize()
        {

        }
        public static bool setNormalize(Bitmap bmap)
        {
            Color c;
            double newR;
            double newG;
            double newB;
            double maxR = 0, minR = 255, maxG = 0, minG = 255, maxB = 0, minB = 255;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    if (c.R > maxR)
                        maxR = c.R;
                    if (c.G > maxG)
                        maxG = c.G;
                    if (c.B > maxB)
                        maxB = c.B;
                    if (c.R < minR)
                        minR = c.R;
                    if (c.G < minG)
                        minG = c.G;
                    if (c.B < minB)
                        minB = c.B;
                }
            }

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    newR = FixColor.fix(((c.R - minR) / (maxR - minR)) * 255);
                    newG = FixColor.fix(((c.G - minG) / (maxG - minG)) * 255);
                    newB = FixColor.fix(((c.B - minB) / (maxB - minB)) * 255);
                    bmap.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(newR), Convert.ToInt32(newG), Convert.ToInt32(newB)));
                }
            }
            return true;
        }
    }
}

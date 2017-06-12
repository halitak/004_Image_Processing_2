using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class ColorFilter
    {

        ColorFilter()
        {

        }

        public static Bitmap SetColorFilter(Bitmap bmap, string colorFilterType)
        {
            Color c;
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    switch (colorFilterType)
                    {
                        case "red":
                            nPixelR = c.R;
                            nPixelG = c.G - 255;
                            nPixelB = c.B - 255;
                            break;
                        case "green":
                            nPixelR = c.R - 255;
                            nPixelG = c.G;
                            nPixelB = c.B - 255;
                            break;
                        case "blue":
                            nPixelR = c.R - 255;
                            nPixelG = c.G - 255;
                            nPixelB = c.B;
                            break;
                        case "gray":
                            nPixelR = (c.R + c.G + c.B) / 3;
                            nPixelG = nPixelR;
                            nPixelB = nPixelR;
                            break;
                        case "invert":
                            nPixelR = 255 - c.R;
                            nPixelG = 255 - c.G;
                            nPixelB = 255 - c.B;
                            break;
                        default:
                            break;
                    }

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    copy.SetPixel(i, j, Color.FromArgb(nPixelR, nPixelG, nPixelB));

                }
            }
            return copy;
        }
    }
}

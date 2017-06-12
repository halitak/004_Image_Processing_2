using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Brightness
    {
        Brightness()
        {

        }
        public static Bitmap SetBrightness(Bitmap bmap,int brightness)
        {
            Color c;
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;
                    if (cR < 0)
                        cR = 0;
                    else if (cR > 255)
                        cR = 255;
                    if (cG < 0)
                        cG = 0;
                    else if (cG > 255)
                        cG = 255;
                    if (cB < 0)
                        cB = 0;
                    else if (cB > 255)
                        cB = 255;
                    bmap.SetPixel(i, j, Color.FromArgb(cR, cG, cB));
                }
            }

            return copy;
        }
    }
}

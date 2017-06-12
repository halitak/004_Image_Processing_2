using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Contrast
    {
        Contrast()
        {

        }
        public static bool setContrast(Bitmap bmap, int contrast)
        {
            Color c;
            double newR;
            double newG;
            double newB;
            contrast = contrast % 100;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    newR = FixColor.fix(c.R * contrast);
                    newG = FixColor.fix(c.G * contrast);
                    newB = FixColor.fix(c.B * contrast);
                    bmap.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(newR), Convert.ToInt32(newG), Convert.ToInt32(newB)));
                }
            }
            return true;
        }
    }
}

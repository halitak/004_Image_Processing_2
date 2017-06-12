using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Reverse
    {
        Reverse()
        {

        }

        public static bool setReverseX(Bitmap bmap, Bitmap copy)
        {
            int newY;
            Color c;
            int h = bmap.Height-1;
            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    newY = h - y;
                    copy.SetPixel(x, newY, c);
                }
            }

            return true;
        }
        public static bool setReverseY(Bitmap bmap, Bitmap copy)
        {
            int newX;
            Color c;
            int h = bmap.Width - 1;
            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    newX = h - x;
                    copy.SetPixel(newX, y, c);
                }
            }

            return true;
        }
    }
}

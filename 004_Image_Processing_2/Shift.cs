using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Shift
    {
        Shift()
        {

        }

        public static Bitmap setShift(Bitmap bmap, string[] shift)
        {
            int shiftX = Convert.ToInt32(shift[0]);
            int shiftY = Convert.ToInt32(shift[1]);
            Color c;
            Bitmap copy = new Bitmap(bmap.Width, bmap.Height);

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    if (x + shiftX < bmap.Width && y + shiftY < bmap.Height)
                        copy.SetPixel(x + shiftX, y + shiftY, c);
                }
            }

            return copy;
        }
    }
}

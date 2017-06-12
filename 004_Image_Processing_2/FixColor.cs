using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class FixColor
    {
        FixColor()
        {

        }
        public static double fix(double color)
        {
            if (color <= 255 && color >= 0)
                return color;
            else
            {
                if (color < 255)
                    return 255;
                else
                    return 0;
            }
        }
    }
}

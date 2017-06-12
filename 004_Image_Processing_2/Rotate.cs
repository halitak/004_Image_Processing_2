using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Rotate
    {
        Rotate()
        {

        }

        public static Bitmap setRotate(Bitmap bmap, double degress)
        {
            degress = degress * Math.PI / 180.0;
            int enkwid = 0, enkhei = 0;

            float sin = (float)Math.Abs(Math.Sin(degress)); // this function takes radians
            float cos = (float)Math.Abs(Math.Cos(degress)); // this one too
            float newImgWidth = sin * bmap.Height + cos * bmap.Width;
            float newImgHeight = sin * bmap.Width + cos * bmap.Height;


            Bitmap copy = new Bitmap((int)Math.Ceiling(newImgWidth), (int)Math.Ceiling(newImgHeight));
            Color c;
            int newX, newY;
            double xo = bmap.Width / 2.0;
            double yo = bmap.Height / 2.0;


            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    newX = Convert.ToInt32((Math.Cos(degress) * (x - xo)) - (Math.Sin(degress) * (y - yo)) + (xo));
                    newY = Convert.ToInt32((Math.Sin(degress) * (x - xo)) + (Math.Cos(degress) * (y - yo)) + (yo));
                    if (enkwid > newX)
                        enkwid = newX;
                    if (enkhei > newY)
                        enkhei = newY;
                }
            }

            enkwid *= -1;
            enkhei *= -1;

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);
                    newX = Convert.ToInt32((Math.Cos(degress) * (x - xo)) - (Math.Sin(degress) * (y - yo)) + (xo));
                    newY = Convert.ToInt32((Math.Sin(degress) * (x - xo)) + (Math.Cos(degress) * (y - yo)) + (yo));
                    copy.SetPixel(newX + enkwid, newY + enkhei, c);
                }
            }
            /*int denR = 0, denG = 0, denB = 0;
            for (int x = 0; x < copy.Width; x++)
            {
                for (int y = 0; y < copy.Height; y++)
                {
                    c = copy.GetPixel(x, y);
                    if ((c.R == 0 && c.G == 0 && c.B == 0)&&((x+1<copy.Width)&&(y+1<copy.Height)))
                    {
                        denR = (copy.GetPixel(x, y).R + copy.GetPixel(x + 1, y).R + copy.GetPixel(x, y + 1).R + copy.GetPixel(x + 1, y + 1).R) / 4;
                        denG = (copy.GetPixel(x, y).G + copy.GetPixel(x + 1, y).G + copy.GetPixel(x, y + 1).G + copy.GetPixel(x + 1, y + 1).G) / 4;
                        denB = (copy.GetPixel(x, y).B + copy.GetPixel(x + 1, y).B + copy.GetPixel(x, y + 1).B + copy.GetPixel(x + 1, y + 1).B) / 4;
                    }
                    copy.SetPixel(x, y, Color.FromArgb(denR, denG, denB));
                }
            }*/

            return copy;
        }
    }
}

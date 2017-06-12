using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Image_Processing_2
{
    class Zoom
    {
        Zoom()
        {

        }

        public static Bitmap setZoomIn(Bitmap bmap)
        {
            Bitmap copy = new Bitmap(bmap.Width * 2, bmap.Height * 2);
            int x = 0, y = 0;
            for (int i = 0; i < bmap.Width * 2; i += 2)
            {
                for (int j = 0; j < bmap.Height * 2; j += 2)
                {
                    if ((i + 1) < copy.Width && (j + 1) < copy.Height)
                    {
                        copy.SetPixel(i, j, bmap.GetPixel(x, y));
                        copy.SetPixel(i + 1, j, bmap.GetPixel(x, y));
                        copy.SetPixel(i, j + 1, bmap.GetPixel(x, y));
                        copy.SetPixel(i + 1, j + 1, bmap.GetPixel(x, y));
                    }
                    y++;
                }
                x++;
                y = 0;
            }


            return copy;
        }
        public static Bitmap setZoomIn2(Bitmap bmap)
        {
            int R, G, B;
            Bitmap copy = new Bitmap((bmap.Width * 2) - 1, (bmap.Height * 2) - 1);
            Color[,] dizi = new Color[bmap.Width, bmap.Height];
            Color[,] dizi2 = new Color[(bmap.Width * 2) - 1, (bmap.Height * 2) - 1];


            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    dizi[i, j] = bmap.GetPixel(i, j);
                }
            }

            int x = 0, y = 0;
            for (int i = 0; i < (bmap.Width * 2) - 1; i += 2)
            {
                for (int j = 0; j < (bmap.Height * 2) - 1; j += 2)
                {
                    dizi2[i, j] = dizi[x, y];

                    if (x != bmap.Width - 1)
                    {
                        R = (dizi[x, y].R + dizi[x + 1, y].R) / 2;
                        G = (dizi[x, y].G + dizi[x + 1, y].G) / 2;
                        B = (dizi[x, y].B + dizi[x + 1, y].B) / 2;
                        dizi2[i + 1, j] = Color.FromArgb(R, G, B);
                    }

                    if (y != bmap.Height - 1)
                    {
                        R = (dizi[x, y].R + dizi[x, y + 1].R) / 2;
                        G = (dizi[x, y].G + dizi[x, y + 1].G) / 2;
                        B = (dizi[x, y].B + dizi[x, y + 1].B) / 2;
                        dizi2[i, j + 1] = Color.FromArgb(R, G, B);
                    }

                    if ((y != bmap.Height - 1) && (x != bmap.Width - 1))
                    {
                        R = (dizi[x, y].R + dizi[x, y + 1].R + dizi[x + 1, y].R + dizi[x + 1, y + 1].R) / 4;
                        G = (dizi[x, y].G + dizi[x, y + 1].G + dizi[x + 1, y].G + dizi[x + 1, y + 1].G) / 4;
                        B = (dizi[x, y].B + dizi[x, y + 1].B + dizi[x + 1, y].B + dizi[x + 1, y + 1].B) / 4;
                        dizi2[i + 1, j + 1] = Color.FromArgb(R, G, B);
                    }
                    y++;
                }
                y = 0;
                x++;
            }

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    copy.SetPixel(i, j, dizi2[i, j]);
                }
            }


            return copy;
        }
        public static Bitmap setZoomOut(Bitmap bmap)
        {
            int newWith, newHeight;
            newWith = bmap.Width / 2;
            newHeight = bmap.Height / 2;
            /* if (bmap.Width % 2 != 0)
                 newWith++;
             if (bmap.Height % 2 != 0)
                 newHeight++;*/

            Bitmap copy = new Bitmap(newWith, newHeight);
            int i = 0, j = 0;
            int R, G, B;
            for (int x = 0; x < newWith; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    R = (bmap.GetPixel(i, j).R + bmap.GetPixel(i + 1, j).R + bmap.GetPixel(i, j + 1).R + bmap.GetPixel(i + 1, j + 1).R) / 4;
                    G = (bmap.GetPixel(i, j).G + bmap.GetPixel(i + 1, j).G + bmap.GetPixel(i, j + 1).G + bmap.GetPixel(i + 1, j + 1).G) / 4;
                    B = (bmap.GetPixel(i, j).B + bmap.GetPixel(i + 1, j).B + bmap.GetPixel(i, j + 1).B + bmap.GetPixel(i + 1, j + 1).B) / 4;
                    copy.SetPixel(x, y, Color.FromArgb(R, G, B));
                    j += 2;
                }
                j = 0;
                i += 2;
            }

            return copy;
        }
    }
}

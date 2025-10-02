using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLoader
{
    internal class Soma2
    {
        public Soma2(){ }

        public Bitmap somaImagens (byte[,] vImg1R, byte[,] vImg1G, byte[,] vImg1B, byte[,] vImg2R, byte[,] vImg2G, byte[,] vImg2B)
        {
            int width = Math.Min(vImg1R.GetLength(0), vImg2R.GetLength(0));
            int height = Math.Min(vImg1R.GetLength(1), vImg2R.GetLength(1));

            byte[,] vImg3R = new byte[width, height];
            byte[,] vImg3G = new byte[width, height];
            byte[,] vImg3B = new byte[width, height];

            Bitmap img3 = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = vImg1R[i, j] + vImg2R[i, j];
                    int g = vImg1G[i, j] + vImg2G[i, j];
                    int b = vImg1B[i, j] + vImg2B[i, j];

                    vImg3R[i, j] = (byte)(r > 255 ? 255 : r);
                    vImg3G[i, j] = (byte)(g > 255 ? 255 : g);
                    vImg3B[i, j] = (byte)(b > 255 ? 255 : b);

                    Color cor = Color.FromArgb(
                        255,
                        vImg3R[i, j],
                        vImg3G[i, j],
                        vImg3B[i, j]);

                    img3.SetPixel(i, j, cor);
                }
            }

            return img3;
        }
    }
}

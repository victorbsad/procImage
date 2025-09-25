using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLoader
{
    internal class Subt2
    {
        public Subt2(){ }

        public Bitmap subtImagens(byte[,] vImg1R, byte[,] vImg1G, byte[,] vImg1B, byte[,] vImg2R, byte[,] vImg2G, byte[,] vImg2B)
        {
            int width = Math.Min(vImg1R.GetLength(0), vImg2R.GetLength(0));
            int height = Math.Min(vImg1R.GetLength(1), vImg2R.GetLength(1));

            byte[,] vImg4R = new byte[width, height];
            byte[,] vImg4G = new byte[width, height];
            byte[,] vImg4B = new byte[width, height];

            Bitmap img4 = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = vImg1R[i, j] - vImg2R[i, j];
                    int g = vImg1G[i, j] - vImg2G[i, j];
                    int b = vImg1B[i, j] - vImg2B[i, j];

                    vImg4R[i, j] = (byte)(r > 255 ? 255 : r);
                    vImg4G[i, j] = (byte)(g > 255 ? 255 : g);
                    vImg4B[i, j] = (byte)(b > 255 ? 255 : b);

                    Color cor = Color.FromArgb(
                        255,
                        vImg4R[i, j],
                        vImg4G[i, j],
                        vImg4B[i, j]);

                    img4.SetPixel(i, j, cor);
                }
            }

            return img4;
        }
    }
}

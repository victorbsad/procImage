using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLoader
{
    internal class Brilho
    {
        public Brilho() { }

        public Bitmap brilhoImagem(byte[,] vImg1R, byte[,] vImg1G, byte[,] vImg1B, int brilho)
        {
            int width = vImg1R.GetLength(0);
            int height = vImg1R.GetLength(1);

            byte[,] vImg4R = new byte[width, height];
            byte[,] vImg4G = new byte[width, height];
            byte[,] vImg4B = new byte[width, height];

            Bitmap img4 = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = vImg1R[i, j] + brilho;
                    int g = vImg1G[i, j] + brilho;
                    int b = vImg1B[i, j] + brilho;

                    vImg4R[i, j] = (byte)(r > 255 ? 255 : (r < 0 ? 0 : r));
                    vImg4G[i, j] = (byte)(g > 255 ? 255 : (g < 0 ? 0 : g));
                    vImg4B[i, j] = (byte)(b > 255 ? 255 : (b < 0 ? 0 : b));

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

    internal class MenosBrilho
    {
        public MenosBrilho() { }

        public Bitmap menosBrilhoImagem(byte[,] vImg1R, byte[,] vImg1G, byte[,] vImg1B, int menosBrilho)
        {
            int width = vImg1R.GetLength(0);
            int height = vImg1R.GetLength(1);

            byte[,] vImg4R = new byte[width, height];
            byte[,] vImg4G = new byte[width, height];
            byte[,] vImg4B = new byte[width, height];

            Bitmap img4 = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int r = vImg1R[i, j] - menosBrilho;
                    int g = vImg1G[i, j] - menosBrilho;
                    int b = vImg1B[i, j] - menosBrilho;

                    vImg4R[i, j] = (byte)(r > 255 ? 255 : (r < 0 ? 0 : r));
                    vImg4G[i, j] = (byte)(g > 255 ? 255 : (g < 0 ? 0 : g));
                    vImg4B[i, j] = (byte)(b > 255 ? 255 : (b < 0 ? 0 : b));

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

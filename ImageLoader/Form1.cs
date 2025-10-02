using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {
        
        Bitmap img1;
        Bitmap img2;
        Bitmap img3;
        Bitmap img4;

        byte[,] vImg1Gray;
        byte[,] vImg2Gray;
        byte[,] vImg3Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;



        byte[,] vImg2R;
        byte[,] vImg2G;
        byte[,] vImg2B;
        byte[,] vImg2A;

        byte[,] vImg3R;
        byte[,] vImg3G;
        byte[,] vImg3B;
        byte[,] vImg3A;


        public Form1()
        {
            InitializeComponent();
            txValor.Controls.RemoveAt(0);
        }

        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            //Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //Caso o arquivo seja localizado com sucesso
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //Armazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;

                bool bLoadImg1Ok = false;
                try
                {
                    bLoadImg1Ok = true;
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir Imagem, valide a imagem selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImg1Ok = false;
                }

                //se ficou tudo certo
                if (bLoadImg1Ok == true)
                {
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];
                }
            }
        }
                }
        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "C:\\Users\\amand\\Desktop";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            ImageFormat format = pictureBox3.Image.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                pictureBox3.Image.Save(saveFileDialog1.FileName, format);
            }
        }


        private void btCarregarImagemB_Click(object sender, EventArgs e)
        {
            //Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //Caso o arquivo seja localizado com sucesso
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //Armazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;

                bool bLoadImg1Ok = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImg1Ok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir Imagem, valide a imagem selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImg1Ok = false;
                }

                //se ficou tudo certo
                if (bLoadImg1Ok == true)
                {
                    pictureBox2.Image = img2;
                    vImg2Gray = new byte[img2.Width, img2.Height];
                    vImg2R = new byte[img2.Width, img2.Height];
                    vImg2G = new byte[img2.Width, img2.Height];
                    vImg2B = new byte[img2.Width, img2.Height];
                    vImg2A = new byte[img2.Width, img2.Height];
                }
            }
        }

        private void btSomarImg_Click(object sender, EventArgs e)
        {
            if (vImg1R == null || vImg2R == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                            Color pixel = img2.GetPixel(i, j);
            Soma2 sum = new Soma2();

            pictureBox3.Image = sum.somaImagens(vImg1R, vImg1G, vImg1B, vImg2R, vImg2G, vImg2B);
            pictureBox3.Refresh();
        }

        private void btSubImg_Click(object sender, EventArgs e)
        {
            if (vImg1R == null || vImg2R == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subt2 subt = new Subt2();

            pictureBox3.Image = subt.subtImagens(vImg1R, vImg1G, vImg1B, vImg2R, vImg2G, vImg2B);
            pictureBox3.Refresh();
        }

        private void btSomarManual_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }

                Bitmap maisBrilho = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        byte R = (byte)Math.Min(Math.Round(pixel.R + valorAux), 255);
                        byte G = (byte)Math.Min(Math.Round(pixel.G + valorAux), 255);
                        byte B = (byte)Math.Min(Math.Round(pixel.B + valorAux), 255);
                        byte A = 255;

                        Color cor = Color.FromArgb(A, R, G, B);
                        maisBrilho.SetPixel(i, j, cor);
                    }
                }

                pictureBox3.Image = maisBrilho;

            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btSubtManual_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }

                Bitmap menosBrilho = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        byte R = (byte)Math.Max(Math.Round(pixel.R - valorAux), 0);
                        byte G = (byte)Math.Max(Math.Round(pixel.G - valorAux), 0);
                        byte B = (byte)Math.Max(Math.Round(pixel.B - valorAux), 0);
                        byte A = 255;

                        Color cor = Color.FromArgb(A, R, G, B);
                        menosBrilho.SetPixel(i, j, cor);
                    }
                }

                pictureBox3.Image = menosBrilho;

            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }

                if (valorAux > 2)
                {
                    MessageBox.Show("Digite um valor entre 0 e 2!");
                    return;
                }

                Bitmap maisContraste = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        byte R = (byte)Math.Min(Math.Round(pixel.R * valorAux), 255);
                        byte G = (byte)Math.Min(Math.Round(pixel.G * valorAux), 255);
                        byte B = (byte)Math.Min(Math.Round(pixel.B * valorAux), 255);
                        byte A = 255;

                        Color cor = Color.FromArgb(A, R, G, B);
                        maisContraste.SetPixel(i, j, cor);
                    }
                }

                pictureBox3.Image = maisContraste;

            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btDivid_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }

                if (valorAux > 2 || valorAux <= 0)
                {
                    MessageBox.Show("Digite um valor entre 0.1 e 2!");
                    return;
                }

                Bitmap menosContraste = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        byte R = (byte)Math.Max(Math.Round(pixel.R / valorAux), 0);
                        byte G = (byte)Math.Max(Math.Round(pixel.G / valorAux), 0);
                        byte B = (byte)Math.Max(Math.Round(pixel.B / valorAux), 0);
                        byte A = 255;

                        Color cor = Color.FromArgb(A, R, G, B);
                        menosContraste.SetPixel(i, j, cor);
                    }
                }

                pictureBox3.Image = menosContraste;

            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btCinza_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {   
                Bitmap escalaCinza = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        // Para imagens em escala de cinza, extrair o valor do pixel com...
                        //byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                        byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                        vImg1Gray[i, j] = pixelIntensity;

                        // Para imagens RGB, extrair o valor do pixel com...
                        byte R = pixel.R;
                        byte G = pixel.G;
                        byte B = pixel.B;
                        byte A = pixel.A;

                        vImg1R[i, j] = R;
                        vImg1G[i, j] = G;
                        vImg1B[i, j] = B;
                        vImg1A[i, j] = A;

                        Color cor = Color.FromArgb(
                            255,
                            vImg1Gray[i, j],
                            vImg1Gray[i, j],
                            vImg1Gray[i, j]);

                        escalaCinza.SetPixel(i, j, cor);
                    }
                }
            
                pictureBox3.Image = escalaCinza;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btFlipX_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap flipX = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        int widI = img1.Width - 1 - i;

                        flipX.SetPixel(widI, j, pixel);
                    }
                }

                pictureBox3.Image = flipX;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btFlipY_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap flipY = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);

                        int heiI = img1.Height - 1 - j;

                        flipY.SetPixel(i, heiI, pixel);
                    }
                }

                pictureBox3.Image = flipY;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btDiff_Click(object sender, EventArgs e)
        {
            if (img1 != null && img2 != null)
            {
                if (img1.Width != img2.Width || img1.Height != img2.Height)
                {
                    MessageBox.Show("A imagem 1 e a imagem 2 devem ter o mesmo tamanho para ser calculada a diferença", "Aviso");
                    return;
                }

                Bitmap imgAux1 = new Bitmap(img1.Width, img1.Height);
                Bitmap imgAux2 = new Bitmap(img1.Width, img1.Height);
                Bitmap imgFinal = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte R_C = (byte)Math.Max(pixel1.R - pixel2.R, 0);
                        byte G_C = (byte)Math.Max(pixel1.G - pixel2.G, 0);
                        byte B_C = (byte)Math.Max(pixel1.B - pixel2.B, 0);
                        imgAux1.SetPixel(i, j, Color.FromArgb(255, R_C, G_C, B_C));
                                vImg2B[i, j]);
                        byte R_D = (byte)Math.Max(pixel2.R - pixel1.R, 0);
                        byte G_D = (byte)Math.Max(pixel2.G - pixel1.G, 0);
                        byte B_D = (byte)Math.Max(pixel2.B - pixel1.B, 0);
                        imgAux2.SetPixel(i, j, Color.FromArgb(255, R_D, G_D, B_D));
                    }
                }
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel3 = imgAux1.GetPixel(i, j);
                        Color pixel4 = imgAux2.GetPixel(i, j);
                    }
                        byte R = (byte)Math.Min(pixel3.R + pixel4.R, 255);
                        byte G = (byte)Math.Min(pixel3.G + pixel4.G, 255);
                        byte B = (byte)Math.Min(pixel3.B + pixel4.B, 255);
                        imgFinal.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                    }
                }

                pictureBox3.Image = imgFinal;
            }
            else
            {
                MessageBox.Show("Duas imagens devem ser inseridas antes de calcular a diferença", "Aviso");
            }
        }

        private void btBlend_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }
        }
                Bitmap blending = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte r = (byte)Math.Min(Math.Max((valorAux * pixel1.R + (1 - valorAux) * pixel2.R), 0), 255);
                        byte g = (byte)Math.Min(Math.Max((valorAux * pixel1.G + (1 - valorAux) * pixel2.G), 0), 255);
                        byte b = (byte)Math.Min(Math.Max((valorAux * pixel1.B + (1 - valorAux) * pixel2.B), 0), 255);
                        blending.SetPixel(i, j, Color.FromArgb(255, r, g, b));

                    }
                }

                pictureBox3.Image = blending;

            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                return;
            }

        }
        private void btLinear_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap linear = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte r = (byte)((pixel1.R + pixel2.R) / 2);
                        byte g = (byte)((pixel1.G + pixel2.G) / 2);
                        byte b = (byte)((pixel1.B + pixel2.B) / 2);
                        linear.SetPixel(i, j, Color.FromArgb(255, r, g, b));

                    }
                }

                pictureBox3.Image = linear;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox3.Refresh();
        }

        private void btAND_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap btAND = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte r1 = pixel1.R;
                        byte r2 = pixel2.R;

                        byte r = (byte)(r1 & r2);

                        btAND.SetPixel(i, j, Color.FromArgb(255, r, r, r));

                    }
                }

                pictureBox3.Image = btAND;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btOR_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap btOR = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte r1 = pixel1.R;
                        byte r2 = pixel2.R;

                        byte r = (byte)(r1 | r2);

                        btOR.SetPixel(i, j, Color.FromArgb(255, r, r, r));

                    }
                }

                pictureBox3.Image = btOR;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btNOT_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap btNOT = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);

                        byte r = pixel1.R;

                        if (r == 255)
                        {
                            r = 0;
                        }
                        else
                        {
                            r = 255;
                        }

                        btNOT.SetPixel(i, j, Color.FromArgb(255, r, r, r));

                    }
                }

                pictureBox3.Image = btNOT;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btXOR_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap btXOR = new Bitmap(img1.Width, img1.Height);
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte r1 = pixel1.R;
                        byte r2 = pixel2.R;

                        byte r = (byte)(r1 ^ r2);

                        btXOR.SetPixel(i, j, Color.FromArgb(255, r, r, r));

                    }
                }

                pictureBox3.Image = btXOR;
            }
            else
            } else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btLimiar_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                     System.Globalization.NumberStyles.Any,
                                     System.Globalization.CultureInfo.InvariantCulture,
                                     out double valorAux))
                {
                    MessageBox.Show("Digite um valor numérico válido.");
                    return;
                }

                Bitmap limiar = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);

                        byte r = pixel1.R;

                        if (r < valorAux)
                        {
                            r = 0;
                        }
                        else
                        {
                            r = 255;
                        }

                        limiar.SetPixel(i, j, Color.FromArgb(255, r, r, r));

                    }
                }

                pictureBox3.Image = limiar;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btNegativo_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                Bitmap negativo = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);

                        byte r = (byte)(255 - pixel1.R);
                        byte g = (byte)(255 - pixel1.G);
                        byte b = (byte)(255 - pixel1.B);

                        negativo.SetPixel(i, j, Color.FromArgb(255, r, g, b));

                    }
                }

                pictureBox3.Image = negativo;
            }
            else
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btHistograma_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;
                int totalPixels = largura * altura;

                // Calcula o histograma da imagem 1
                int[] histogramaOrg = new int[256];
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        int intensidadeR = pixel.R;
                        histogramaOrg[pixel.R]++;
                    }
                }

                // Preenche o gráfico com os dados do histograma original
                chartImagem1.Series.Clear();
                var seriesImgOriginal = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Histograma Original",
                    Color = Color.Chocolate,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chartImagem1.Series.Add(seriesImgOriginal);

                for (int i = 0; i < histogramaOrg.Length; i++)
                {
                    seriesImgOriginal.Points.AddXY(i, histogramaOrg[i]);
                }

                // Atualiza o gráfico
                chartImagem1.Invalidate();

                // Calcula a Cumulative Frequency Distribution
                int[] cfd = new int[256];
                cfd[0] = histogramaOrg[0];
                for (int i = 1; i < 256; i++)
                {
                    cfd[i] = cfd[i - 1] + histogramaOrg[i];
                }

                // Encontra o valor mínimo da Cumulative Frequency Distribution maior que zero
                int cfdMin = int.MaxValue;
                for (int i = 0; i < 256; i++)
                {
                    if (cfd[i] > 0)
                    {
                        cfdMin = Math.Min(cfdMin, cfd[i]);
                    }
                }

                Bitmap imgEqualizada = new Bitmap(largura, altura);
                // Para armazenar o novo histograma
                int[] histogramaEqualizado = new int[256];
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color pixel = img1.GetPixel(x, y);
                        int intensidade = pixel.R;
                        int novoValor = (int)(((cfd[intensidade] - cfdMin) / (float)(totalPixels - cfdMin)) * 255);
                        novoValor = Math.Max(0, Math.Min(255, novoValor));
                        Color novoPixel = Color.FromArgb(novoValor, novoValor, novoValor);
                        imgEqualizada.SetPixel(x, y, novoPixel);
                        histogramaEqualizado[novoValor]++;
                    }
                }

                // Atualizar o PictureBox com a imagem equalizada (se aplicável)
                pictureBox3.Image = imgEqualizada;

                // Exibir o histograma da imagem equalizada no chart
                chartImagemFinal.Series.Clear();  // Limpa séries anteriores
                var serieEqualizada = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Histograma Equalizado",
                    Color = Color.Red,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };
                chartImagemFinal.Series.Add(serieEqualizada);

                for (int i = 0; i < histogramaEqualizado.Length; i++)
                {
                    serieEqualizada.Points.AddXY(i, histogramaEqualizado[i]);
                }

                // Atualiza o gráfico com o Histograma Equalizado
                chartImagemFinal.Invalidate();

            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Equalização do Histograma", "Atenção");
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
           //t
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //t
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "C:\\Users\\amand\\Desktop";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            ImageFormat format = pictureBox3.Image.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                pictureBox3.Image.Save(saveFileDialog1.FileName, format);
            }
        }

        
    }
}

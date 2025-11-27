using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

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

        bool alterando = false;

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
                    img1 = new Bitmap(filePath);
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
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                }
            }
        }
    
        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Cria e configura o SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\Matlab"; // Diretório inicial
                saveFileDialog.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|Bitmap Image (*.bmp)|*.bmp|TIFF Image (*.tif)|*.tif";
                saveFileDialog.FilterIndex = 1; // Define o filtro padrão para PNG
                saveFileDialog.RestoreDirectory = true;

                // Exibe a caixa de diálogo para o usuário
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Salva a imagem no caminho especificado pelo usuário
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Imagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Mostra uma mensagem de erro se algo der errado
                        MessageBox.Show("Erro ao salvar imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há imagem para salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //valida se as 2 imagens estão carregadas
            if (img1 != null && img2 != null)
            {

                // Garante que as imagens tenham o mesmo tamanho
                if (img1.Width != img2.Width || img1.Height != img2.Height)
                {
                    MessageBox.Show("As imagens devem ter o mesmo tamanho.", "Atenção");
                    return;
                }

                Bitmap Soma = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        // obtem os pixels da imagem1 e imagem2
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        //calcula a soma dos valores dos pixels
                        byte R = (byte)Math.Min(pixel1.R + pixel2.R, 255);
                        byte G = (byte)Math.Min(pixel1.G + pixel2.G, 255);
                        byte B = (byte)Math.Min(pixel1.B + pixel2.B, 255);
                        byte A = 255;

                        //Define o pixel na nova imagem
                        Color cor = Color.FromArgb(A, R, G, B);
                        Soma.SetPixel(i, j, cor);
                    }
                }

                //Atualiza imagem do resultado com as imagens somadas
                pictureBox3.Image = Soma;

            }
            else
            {
                MessageBox.Show("As imagens 1 e 2 devem ser carregadas antes de somar", "Atenção");
            }
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
                MessageBox.Show("A imagem 1 e a imagem 2 devem ter o mesmo tamanho para ser calculada a diferença", "Atenção");
                return;
            }

            Bitmap imgAux1 = new Bitmap(img1.Width, img1.Height);
            Bitmap imgAux2 = new Bitmap(img1.Width, img1.Height);
            Bitmap imgResultFinal = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel1 = img1.GetPixel(i, j);
                    Color pixel2 = img2.GetPixel(i, j);

                    byte R_CalcC = (byte)Math.Max(pixel1.R - pixel2.R, 0);
                    byte G_CalcC = (byte)Math.Max(pixel1.G - pixel2.G, 0);
                    byte B_CalcC = (byte)Math.Max(pixel1.B - pixel2.B, 0);
                    imgAux1.SetPixel(i, j, Color.FromArgb(255, R_CalcC, G_CalcC, B_CalcC));

                    byte R_CalcD = (byte)Math.Max(pixel2.R - pixel1.R, 0);
                    byte G_CalcD = (byte)Math.Max(pixel2.G - pixel1.G, 0);
                    byte B_CalcD = (byte)Math.Max(pixel2.B - pixel1.B, 0);
                    imgAux2.SetPixel(i, j, Color.FromArgb(255, R_CalcD, G_CalcD, B_CalcD));
                }
            }
            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel3 = imgAux1.GetPixel(i, j);
                    Color pixel4 = imgAux2.GetPixel(i, j);

                    byte R = (byte)Math.Min(pixel3.R + pixel4.R, 255);
                    byte G = (byte)Math.Min(pixel3.G + pixel4.G, 255);
                    byte B = (byte)Math.Min(pixel3.B + pixel4.B, 255);
                    imgResultFinal.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                }
            }

                pictureBox3.Image = imgResultFinal;
        }
        else
        {
            MessageBox.Show("A imagem 1 e a imagem 2 devem ser inseridas antes de calcular a diferença", "Atenção");
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

        private void checkTres_CheckedChanged(object sender, EventArgs e)
        {
            if (alterando) return;

            alterando = true;
            if (checkTres.Checked)
            {
                checkCinco.Checked = false;
            }
            alterando = false;
        }

        private void checkCinco_CheckedChanged(object sender, EventArgs e)
        {
            if (alterando) return;

            alterando = true;
            if (checkCinco.Checked)
            {
                checkTres.Checked = false;
            }
            alterando = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgMax = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // List para armazenar os valores de intensidade dos pixels vizinhos
                            List<int> vizinhos = new List<int>();

                            // matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel
                                    vizinhos.Add(pixel.R);
                                }
                            }

                            // Encontrar o menor valor 
                            int menorValor = vizinhos.Max();

                            // Definir o novo valor do pixel na imagem filtrada
                            imgMax.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                        }
                    }
                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            // List para armazenar os valores de intensidade dos pixels vizinhos
                            List<int> vizinhos = new List<int>();

                            // Varre a matriz 5x5
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel 
                                    vizinhos.Add(pixel.R);
                                }
                            }

                            // Encontrar o menor valor de intensidade na vizinhança 5x5
                            int menorValor = vizinhos.Max();

                            imgMax.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Max", "Atenção");
                }

                pictureBox3.Image = imgMax;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Max", "Atenção");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgMin = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            List<int> vizinhos = new List<int>();

                            // Varre a matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel
                                    vizinhos.Add(pixel.R);
                                }
                            }

                            // Encontrar o menor valor de intensidade na vizinhança 3x3
                            int menorValor = vizinhos.Min();

                            imgMin.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                        }
                    }
                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {

                            List<int> vizinhos = new List<int>();

                            // Varre a matriz 5x5
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel
                                    vizinhos.Add(pixel.R);
                                }
                            }

                            // Encontrar o menor valor de intensidade na vizinhança 5x5
                            int menorValor = vizinhos.Min();

                            imgMin.SetPixel(x, y, Color.FromArgb(menorValor, menorValor, menorValor));
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Min", "Atenção");
                }

                pictureBox3.Image = imgMin;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Min", "Atenção");
            }

        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgMean = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    // Varrer a imagem pixel por pixel, exceto as bordas
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            int soma = 0;

                            // Varre a matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel
                                    soma += pixel.R;
                                }
                            }

                            // Calcula a média dos 9 valores
                            int media = soma / 9;

                            imgMean.SetPixel(x, y, Color.FromArgb(media, media, media));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            int soma = 0;

                            // Varre a matriz 5x5 
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Adiciona a intensidade do pixel
                                    soma += pixel.R;
                                }
                            }

                            // Calcula a média dos 25 valores
                            int media = soma / 25;

                            imgMean.SetPixel(x, y, Color.FromArgb(media, media, media));
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Mean", "Atenção");
                }

                pictureBox3.Image = imgMean;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Mean", "Atenção");
            }
        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgMediana = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            int[] valores = new int[9];
                            int contador = 0;

                            // Varre a matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel 
                                    valores[contador] = pixel.R;
                                    contador++;
                                }
                            }

                            // Ordena o array em ordem crescente
                            Array.Sort(valores);

                            // O valor mediano é o 5º valor (índice 4) do array ordenado
                            int valorMediano = valores[4];

                            imgMediana.SetPixel(x, y, Color.FromArgb(valorMediano, valorMediano, valorMediano));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            int[] valores = new int[25];
                            int contador = 0;

                            // Varre a matriz 5x5
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel 
                                    valores[contador] = pixel.R;
                                    contador++;
                                }
                            }

                            // Ordena o array em ordem crescente
                            Array.Sort(valores);

                            // O valor mediano é o 13º valor (índice 12) do array ordenado
                            int valorMediano = valores[12];

                            imgMediana.SetPixel(x, y, Color.FromArgb(valorMediano, valorMediano, valorMediano));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Mediana", "Atenção");
                }

                pictureBox3.Image = imgMediana;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Mediana", "Atenção");
            }

        }

        private void btnOrdem_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgOrdem = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                    System.Globalization.NumberStyles.Any,
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    out double ValorCalc))
                    {
                        MessageBox.Show("Digite um valor numérico válido.");
                        return;
                    }
                    //valida se o valor está no intervalo da ordem
                    if (ValorCalc < 0 || ValorCalc > 8)
                    {
                        MessageBox.Show("O valor deve estar entre 0 e 8.");
                        return;
                    }
                    // Varrer a imagem pixel por pixel, exceto as bordas
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // Array para armazenar os valores dos 9 pixels vizinhos
                            int[] valores = new int[9];
                            int contador = 0;

                            // Varre a matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel 
                                    valores[contador] = pixel.R;
                                    contador++;
                                }
                            }

                            // Ordena o array em ordem crescente
                            Array.Sort(valores);

                            // O valor selecionado é o da posição fornecida pela TextBox
                            int valorSelecionado = valores[(int)ValorCalc];

                            imgOrdem.SetPixel(x, y, Color.FromArgb(valorSelecionado, valorSelecionado, valorSelecionado));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                    System.Globalization.NumberStyles.Any,
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    out double ValorCalc))
                    {
                        MessageBox.Show("Digite um valor numérico válido.");
                        return;
                    }
                    //valida se o valor está no intervalo da ordem
                    if (ValorCalc < 0 || ValorCalc > 24)
                    {
                        MessageBox.Show("O valor deve estar entre 0 e 24.");
                        return;
                    }
                    // Varrer a imagem pixel por pixel, exceto as bordas
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            // Array para armazenar os valores dos 25 pixels vizinhos
                            int[] valores = new int[25];
                            int contador = 0;

                            // Varre a matriz 5x5 
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    // Pega o pixel vizinho
                                    Color pixel = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel 
                                    valores[contador] = pixel.R;
                                    contador++;
                                }
                            }

                            // Ordena o array em ordem crescente
                            Array.Sort(valores);

                            // O valor selecionado é o da posição fornecida pela TextBox
                            int valorSelecionado = valores[(int)ValorCalc];

                            imgOrdem.SetPixel(x, y, Color.FromArgb(valorSelecionado, valorSelecionado, valorSelecionado));
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular a Ordem", "Atenção");
                }

                pictureBox3.Image = imgOrdem;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Ordem", "Atenção");
            }
        }

        private int Clamp(int valor)
        {
            return Math.Max(0, Math.Min(255, valor));
        }

        private bool IsGrayscaleImage(Bitmap img)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);

                    if (pixel.R != pixel.G || pixel.G != pixel.B)
                    {
                        return false;
                    }
                }
            }
            return true; // Todos os pixels são em escala de cinza
        }

        private void btnGauss_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de aplicar o filtro.");
                return;
            }

            // Verificar se a imagem é em preto e branco (escala de cinza)
            if (!IsGrayscaleImage(img1))
            {
                MessageBox.Show("A imagem não está em preto e branco. Carregue uma imagem em escala de cinza.");
                return;
            }

            // Obter o valor de sigma da TextBox
            if (!double.TryParse(txValor.Text.Replace(',', '.'),
                                   System.Globalization.NumberStyles.Any,
                                   System.Globalization.CultureInfo.InvariantCulture,
                                   out double ValorCalc))
            {
                MessageBox.Show("Digite um valor numérico válido.");
                return;
            }
            if (checkTres.Checked || checkCinco.Checked)
            {
                MessageBox.Show("Desmarque os Kernels para calcular o Gaussiano");
                return;
            }

            int largura = img1.Width;
            int altura = img1.Height;

            // Criar o kernel gaussiano 5x5
            double[,] kernel = new double[5, 5];
            double soma = 0.0;
            int halfSize = 2; // Para um kernel 5x5

            // Gerar o kernel gaussiano
            for (int y = -halfSize; y <= halfSize; y++)
            {
                for (int x = -halfSize; x <= halfSize; x++)
                {
                    double gauss = (1 / (2 * Math.PI * ValorCalc * ValorCalc)) *
                                   Math.Exp(-(x * x + y * y) / (2 * ValorCalc * ValorCalc));
                    kernel[y + halfSize, x + halfSize] = gauss;
                    soma += gauss;
                }
            }

            // Normalizar o kernel
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    kernel[y, x] /= soma;
                }
            }

            // Criar uma nova imagem para armazenar o resultado
            Bitmap imgFiltrada = new Bitmap(largura, altura);

            // Aplicar o filtro usando convolução
            for (int y = 2; y < altura - 2; y++)
            {
                for (int x = 2; x < largura - 2; x++)
                {
                    double intensidade = 0;

                    // Convolução para intensidade (escala de cinza)
                    for (int ky = -halfSize; ky <= halfSize; ky++)
                    {
                        for (int kx = -halfSize; kx <= halfSize; kx++)
                        {
                            Color pixel = img1.GetPixel(x + kx, y + ky);

                            // Calcular a intensidade média (escala de cinza)
                            byte intensidadePixel = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                            double coef = kernel[ky + halfSize, kx + halfSize];

                            // Somar o valor da intensidade ponderado pelo coeficiente do kernel
                            intensidade += intensidadePixel * coef;
                        }
                    }

                    // Definir o novo pixel na imagem filtrada (em escala de cinza)
                    int valorFinal = Clamp((int)intensidade);
                    imgFiltrada.SetPixel(x, y, Color.FromArgb(valorFinal, valorFinal, valorFinal));
                }
            }

            // Atualizar a PictureBox com a imagem filtrada
            pictureBox3.Image = imgFiltrada;
        }

        private void btnSuave_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgSauvConsertiva = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // Array para armazenar os valores dos 8 pixels vizinhos
                            int[] valoresVizinhos = new int[8];
                            int contador = 0;

                            Color pixelCentral = img1.GetPixel(x, y);
                            int valorCentral = pixelCentral.R;

                            // Varre a matriz 3x3 
                            for (int j = -1; j <= 1; j++)
                            {
                                for (int i = -1; i <= 1; i++)
                                {
                                    // Ignorar o pixel central
                                    if (i == 0 && j == 0)
                                        continue;

                                    // Pega o pixel vizinho
                                    Color pixelVizinho = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel vizinho
                                    valoresVizinhos[contador] = pixelVizinho.R;
                                    contador++;
                                }
                            }

                            // Encontra o valor máximo e o mínimo dos 8 vizinhos
                            int valorMaximo = valoresVizinhos.Max();
                            int valorMinimo = valoresVizinhos.Min();

                            // Define o novo valor do pixel central com base no máximo e mínimo
                            int novoValor;
                            if (valorCentral > valorMaximo)
                            {
                                novoValor = valorMaximo;
                            }
                            else if (valorCentral < valorMinimo)
                            {
                                novoValor = valorMinimo;
                            }
                            else
                            {
                                novoValor = valorCentral; // Mantém o valor original se estiver dentro dos limites
                            }

                            imgSauvConsertiva.SetPixel(x, y, Color.FromArgb(novoValor, novoValor, novoValor));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            // Array para armazenar os valores dos 24 pixels vizinhos
                            int[] valoresVizinhos = new int[24];
                            int contador = 0;

                            // Pega o valor do pixel central
                            Color pixelCentral = img1.GetPixel(x, y);
                            int valorCentral = pixelCentral.R;

                            // Varre a matriz 5x5 ao redor do pixel (x, y), ignorando o pixel central
                            for (int j = -2; j <= 2; j++)
                            {
                                for (int i = -2; i <= 2; i++)
                                {
                                    // Ignorar o pixel central
                                    if (i == 0 && j == 0)
                                        continue;

                                    // Pega o pixel vizinho
                                    Color pixelVizinho = img1.GetPixel(x + i, y + j);
                                    // Armazena a intensidade do pixel vizinho
                                    valoresVizinhos[contador] = pixelVizinho.R;
                                    contador++;
                                }
                            }

                            // Encontra o valor máximo e o mínimo dos 24 vizinhos
                            int valorMaximo = valoresVizinhos.Max();
                            int valorMinimo = valoresVizinhos.Min();

                            // Define o novo valor do pixel central com base no máximo e mínimo
                            int novoValor;
                            if (valorCentral > valorMaximo)
                            {
                                novoValor = valorMaximo;
                            }
                            else if (valorCentral < valorMinimo)
                            {
                                novoValor = valorMinimo;
                            }
                            else
                            {
                                novoValor = valorCentral; // Mantém o valor original se estiver dentro dos limites
                            }

                            imgSauvConsertiva.SetPixel(x, y, Color.FromArgb(novoValor, novoValor, novoValor));
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular a Suavização Consertiva", "Atenção");
                }

                pictureBox3.Image = imgSauvConsertiva;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Suavização Consertiva", "Atenção");
            }
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgSobel = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // Valores dos pixels vizinhos para Gx
                            int v00x = img1.GetPixel(x - 1, y - 1).R;
                            int v01x = img1.GetPixel(x - 1, y).R;
                            int v02x = img1.GetPixel(x - 1, y + 1).R;
                            int v10x = img1.GetPixel(x, y - 1).R;
                            int v11x = img1.GetPixel(x, y).R;
                            int v12x = img1.GetPixel(x, y + 1).R;
                            int v20x = img1.GetPixel(x + 1, y - 1).R;
                            int v21x = img1.GetPixel(x + 1, y).R;
                            int v22x = img1.GetPixel(x + 1, y + 1).R;

                            // Calcular Gx usando o kernel de Sobel
                            int gx = (-1 * v00x) + (0 * v01x) + (1 * v02x) +
                                     (-2 * v10x) + (0 * v11x) + (2 * v12x) +
                                     (-1 * v20x) + (0 * v21x) + (1 * v22x);

                            // Valores dos pixels vizinhos para Gy
                            int v00y = img1.GetPixel(x - 1, y - 1).R;
                            int v01y = img1.GetPixel(x - 1, y).R;
                            int v02y = img1.GetPixel(x - 1, y + 1).R;
                            int v10y = img1.GetPixel(x, y - 1).R;
                            int v11y = img1.GetPixel(x, y).R;
                            int v12y = img1.GetPixel(x, y + 1).R;
                            int v20y = img1.GetPixel(x + 1, y - 1).R;
                            int v21y = img1.GetPixel(x + 1, y).R;
                            int v22y = img1.GetPixel(x + 1, y + 1).R;

                            // Calcular Gy usando o kernel de Sobel
                            int gy = (1 * v00y) + (2 * v01y) + (1 * v02y) +
                                     (0 * v10y) + (0 * v11y) + (0 * v12y) +
                                     (-1 * v20y) + (-2 * v21y) + (-1 * v22y);

                            // Calcular a magnitude e aplicar o clamp
                            int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                            imgSobel.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            // Declarar os 25 pixels vizinhos (R canal)
                            int v00 = img1.GetPixel(x - 2, y - 2).R;
                            int v01 = img1.GetPixel(x - 1, y - 2).R;
                            int v02 = img1.GetPixel(x, y - 2).R;
                            int v03 = img1.GetPixel(x + 1, y - 2).R;
                            int v04 = img1.GetPixel(x + 2, y - 2).R;

                            int v10 = img1.GetPixel(x - 2, y - 1).R;
                            int v11 = img1.GetPixel(x - 1, y - 1).R;
                            int v12 = img1.GetPixel(x, y - 1).R;
                            int v13 = img1.GetPixel(x + 1, y - 1).R;
                            int v14 = img1.GetPixel(x + 2, y - 1).R;

                            int v20 = img1.GetPixel(x - 2, y).R;
                            int v21 = img1.GetPixel(x - 1, y).R;
                            int v22 = img1.GetPixel(x, y).R;
                            int v23 = img1.GetPixel(x + 1, y).R;
                            int v24 = img1.GetPixel(x + 2, y).R;

                            int v30 = img1.GetPixel(x - 2, y + 1).R;
                            int v31 = img1.GetPixel(x - 1, y + 1).R;
                            int v32 = img1.GetPixel(x, y + 1).R;
                            int v33 = img1.GetPixel(x + 1, y + 1).R;
                            int v34 = img1.GetPixel(x + 2, y + 1).R;

                            int v40 = img1.GetPixel(x - 2, y + 2).R;
                            int v41 = img1.GetPixel(x - 1, y + 2).R;
                            int v42 = img1.GetPixel(x, y + 2).R;
                            int v43 = img1.GetPixel(x + 1, y + 2).R;
                            int v44 = img1.GetPixel(x + 2, y + 2).R;

                            // Aplicar kernel Sobel 5x5 em Gx
                            int gx = (-5 * v00) + (-4 * v01) + (0 * v02) + (4 * v03) + (5 * v04)
                                   + (-8 * v10) + (-10 * v11) + (0 * v12) + (10 * v13) + (8 * v14)
                                   + (-10 * v20) + (-20 * v21) + (0 * v22) + (20 * v23) + (10 * v24)
                                   + (-8 * v30) + (-10 * v31) + (0 * v32) + (10 * v33) + (8 * v34)
                                   + (-5 * v40) + (-4 * v41) + (0 * v42) + (4 * v43) + (5 * v44);

                            // Aplicar kernel Sobel 5x5 em Gy (transposto)
                            int gy = (-5 * v00) + (-8 * v01) + (-10 * v02) + (-8 * v03) + (-5 * v04)
                                   + (-4 * v10) + (-10 * v11) + (-20 * v12) + (-10 * v13) + (-4 * v14)
                                   + (0 * v20) + (0 * v21) + (0 * v22) + (0 * v23) + (0 * v24)
                                   + (4 * v30) + (10 * v31) + (20 * v32) + (10 * v33) + (4 * v34)
                                   + (5 * v40) + (8 * v41) + (10 * v42) + (8 * v43) + (5 * v44);

                            // Calcular magnitude
                            int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                            imgSobel.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Sobel", "Atenção");
                }

                pictureBox3.Image = imgSobel;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Sobel", "Atenção");
            }

        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgPrewitt = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    for (int y = 1; y < altura - 1; y++)
                    {
                        for (int x = 1; x < largura - 1; x++)
                        {
                            // Valores dos pixels vizinhos para Gx
                            int v00x = img1.GetPixel(x - 1, y - 1).R;
                            int v01x = img1.GetPixel(x - 1, y).R;
                            int v02x = img1.GetPixel(x - 1, y + 1).R;
                            int v10x = img1.GetPixel(x, y - 1).R;
                            int v11x = img1.GetPixel(x, y).R;
                            int v12x = img1.GetPixel(x, y + 1).R;
                            int v20x = img1.GetPixel(x + 1, y - 1).R;
                            int v21x = img1.GetPixel(x + 1, y).R;
                            int v22x = img1.GetPixel(x + 1, y + 1).R;

                            // Calcular Gx
                            double gx = (-1 * v00x) + (0 * v01x) + (1 * v02x) +
                                        (-1 * v10x) + (0 * v11x) + (1 * v12x) +
                                        (-1 * v20x) + (0 * v21x) + (1 * v22x);

                            // Valores dos pixels vizinhos para Gy
                            int v00y = img1.GetPixel(x - 1, y - 1).R;
                            int v01y = img1.GetPixel(x - 1, y).R;
                            int v02y = img1.GetPixel(x - 1, y + 1).R;
                            int v10y = img1.GetPixel(x, y - 1).R;
                            int v11y = img1.GetPixel(x, y).R;
                            int v12y = img1.GetPixel(x, y + 1).R;
                            int v20y = img1.GetPixel(x + 1, y - 1).R;
                            int v21y = img1.GetPixel(x + 1, y).R;
                            int v22y = img1.GetPixel(x + 1, y + 1).R;

                            // Calcular Gy
                            double gy = (-1 * v00y) + (-1 * v01y) + (-1 * v02y) +
                                        (0 * v10y) + (0 * v11y) + (0 * v12y) +
                                        (1 * v20y) + (1 * v21y) + (1 * v22y);

                            // Calcular a magnitude e aplicar o clamp
                            int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                            imgPrewitt.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                        }
                    }

                }
                else if (checkCinco.Checked == true)
                {
                    for (int y = 2; y < altura - 2; y++)
                    {
                        for (int x = 2; x < largura - 2; x++)
                        {
                            // Pega os pixels vizinhos para Gx
                            int v00x = img1.GetPixel(x - 2, y - 2).R;
                            int v01x = img1.GetPixel(x - 2, y - 1).R;
                            int v02x = img1.GetPixel(x - 2, y).R;
                            int v03x = img1.GetPixel(x - 2, y + 1).R;
                            int v04x = img1.GetPixel(x - 2, y + 2).R;

                            int v10x = img1.GetPixel(x - 1, y - 2).R;
                            int v11x = img1.GetPixel(x - 1, y - 1).R;
                            int v12x = img1.GetPixel(x - 1, y).R;
                            int v13x = img1.GetPixel(x - 1, y + 1).R;
                            int v14x = img1.GetPixel(x - 1, y + 2).R;

                            int v20x = img1.GetPixel(x, y - 2).R;
                            int v21x = img1.GetPixel(x, y - 1).R;
                            int v22x = img1.GetPixel(x, y).R;
                            int v23x = img1.GetPixel(x, y + 1).R;
                            int v24x = img1.GetPixel(x, y + 2).R;

                            int v30x = img1.GetPixel(x + 1, y - 2).R;
                            int v31x = img1.GetPixel(x + 1, y - 1).R;
                            int v32x = img1.GetPixel(x + 1, y).R;
                            int v33x = img1.GetPixel(x + 1, y + 1).R;
                            int v34x = img1.GetPixel(x + 1, y + 2).R;

                            int v40x = img1.GetPixel(x + 2, y - 2).R;
                            int v41x = img1.GetPixel(x + 2, y - 1).R;
                            int v42x = img1.GetPixel(x + 2, y).R;
                            int v43x = img1.GetPixel(x + 2, y + 1).R;
                            int v44x = img1.GetPixel(x + 2, y + 2).R;

                            // Calcula Gx usando o kernel Prewitt 5x5
                            double gx = (-2 * v00x) + (-1 * v01x) + (0 * v02x) + (1 * v03x) + (2 * v04x) +
                                        (-2 * v10x) + (-1 * v11x) + (0 * v12x) + (1 * v13x) + (2 * v14x) +
                                        (-2 * v20x) + (-1 * v21x) + (0 * v22x) + (1 * v23x) + (2 * v24x) +
                                        (-2 * v30x) + (-1 * v31x) + (0 * v32x) + (1 * v33x) + (2 * v34x) +
                                        (-2 * v40x) + (-1 * v41x) + (0 * v42x) + (1 * v43x) + (2 * v44x);

                            // Pega os pixels vizinhos para Gy (mesma ordem, mas pesos do Gy)
                            int v00y = img1.GetPixel(x - 2, y - 2).R;
                            int v01y = img1.GetPixel(x - 2, y - 1).R;
                            int v02y = img1.GetPixel(x - 2, y).R;
                            int v03y = img1.GetPixel(x - 2, y + 1).R;
                            int v04y = img1.GetPixel(x - 2, y + 2).R;

                            int v10y = img1.GetPixel(x - 1, y - 2).R;
                            int v11y = img1.GetPixel(x - 1, y - 1).R;
                            int v12y = img1.GetPixel(x - 1, y).R;
                            int v13y = img1.GetPixel(x - 1, y + 1).R;
                            int v14y = img1.GetPixel(x - 1, y + 2).R;

                            int v20y = img1.GetPixel(x, y - 2).R;
                            int v21y = img1.GetPixel(x, y - 1).R;
                            int v22y = img1.GetPixel(x, y).R;
                            int v23y = img1.GetPixel(x, y + 1).R;
                            int v24y = img1.GetPixel(x, y + 2).R;

                            int v30y = img1.GetPixel(x + 1, y - 2).R;
                            int v31y = img1.GetPixel(x + 1, y - 1).R;
                            int v32y = img1.GetPixel(x + 1, y).R;
                            int v33y = img1.GetPixel(x + 1, y + 1).R;
                            int v34y = img1.GetPixel(x + 1, y + 2).R;

                            int v40y = img1.GetPixel(x + 2, y - 2).R;
                            int v41y = img1.GetPixel(x + 2, y - 1).R;
                            int v42y = img1.GetPixel(x + 2, y).R;
                            int v43y = img1.GetPixel(x + 2, y + 1).R;
                            int v44y = img1.GetPixel(x + 2, y + 2).R;

                            // Calcula Gy usando o kernel Prewitt 5x5
                            double gy = (-2 * v00y) + (-2 * v01y) + (-2 * v02y) + (-2 * v03y) + (-2 * v04y) +
                                        (-1 * v10y) + (-1 * v11y) + (-1 * v12y) + (-1 * v13y) + (-1 * v14y) +
                                        (0 * v20y) + (0 * v21y) + (0 * v22y) + (0 * v23y) + (0 * v24y) +
                                        (1 * v30y) + (1 * v31y) + (1 * v32y) + (1 * v33y) + (1 * v34y) +
                                        (2 * v40y) + (2 * v41y) + (2 * v42y) + (2 * v43y) + (2 * v44y);

                            // Calcula a magnitude do gradiente e faz o clamp
                            int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));

                            imgPrewitt.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Prewitt", "Atenção");
                }

                pictureBox3.Image = imgPrewitt;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Prewitt", "Atenção");
            }
        }

        private void btnLaplaciano_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                Bitmap imgLaplaciano = new Bitmap(largura, altura);

                if (checkTres.Checked == true)
                {
                    if (checkSet1.Checked == true)
                    {
                        for (int y = 1; y < altura - 1; y++)
                        {
                            for (int x = 1; x < largura - 1; x++)
                            {
                                // Valores dos pixels vizinhos para Gx
                                int v00x = img1.GetPixel(x - 1, y - 1).R;
                                int v01x = img1.GetPixel(x - 1, y).R;
                                int v02x = img1.GetPixel(x - 1, y + 1).R;
                                int v10x = img1.GetPixel(x, y - 1).R;
                                int v11x = img1.GetPixel(x, y).R;
                                int v12x = img1.GetPixel(x, y + 1).R;
                                int v20x = img1.GetPixel(x + 1, y - 1).R;
                                int v21x = img1.GetPixel(x + 1, y).R;
                                int v22x = img1.GetPixel(x + 1, y + 1).R;

                                // Calcular Gx usando o kernel Laplaciano
                                int gx = (0 * v00x) + (1 * v01x) + (0 * v02x) +
                                         (1 * v10x) + (-4 * v11x) + (1 * v12x) +
                                         (0 * v20x) + (1 * v21x) + (0 * v22x);

                                // Valores dos pixels vizinhos para Gy
                                int v00y = img1.GetPixel(x - 1, y - 1).R;
                                int v01y = img1.GetPixel(x - 1, y).R;
                                int v02y = img1.GetPixel(x - 1, y + 1).R;
                                int v10y = img1.GetPixel(x, y - 1).R;
                                int v11y = img1.GetPixel(x, y).R;
                                int v12y = img1.GetPixel(x, y + 1).R;
                                int v20y = img1.GetPixel(x + 1, y - 1).R;
                                int v21y = img1.GetPixel(x + 1, y).R;
                                int v22y = img1.GetPixel(x + 1, y + 1).R;

                                // Calcular Gy usando o kernel Laplaciano
                                int gy = (0 * v00y) + (-1 * v01y) + (0 * v02y) +
                                         (-1 * v10y) + (4 * v11y) + (-1 * v12y) +
                                         (0 * v20y) + (-1 * v21y) + (0 * v22y);

                                // A intensidade final pode ser baseada em gx ou gy (ou ambos)
                                int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                                imgLaplaciano.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                            }
                        }

                    }
                    else if (checkSet2.Checked == true)
                    {
                        for (int y = 1; y < altura - 1; y++)
                        {
                            for (int x = 1; x < largura - 1; x++)
                            {
                                // Valores dos pixels vizinhos para Gx
                                int v00x = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                                int v01x = img1.GetPixel(x - 1, y).R;     // Cima
                                int v02x = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                                int v10x = img1.GetPixel(x, y - 1).R;     // Esquerda
                                int v11x = img1.GetPixel(x, y).R;         // Centro
                                int v12x = img1.GetPixel(x, y + 1).R;     // Direita
                                int v20x = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                                int v21x = img1.GetPixel(x + 1, y).R;     // Baixo
                                int v22x = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                                // Calcular Gx usando o kernel Laplaciano
                                int gx = (1 * v00x) + (1 * v01x) + (1 * v02x) +
                                         (1 * v10x) + (-8 * v11x) + (1 * v12x) +
                                         (1 * v20x) + (1 * v21x) + (1 * v22x);

                                // Valores dos pixels vizinhos para Gy
                                int v00y = img1.GetPixel(x - 1, y - 1).R; // Cima à esquerda
                                int v01y = img1.GetPixel(x - 1, y).R;     // Cima
                                int v02y = img1.GetPixel(x - 1, y + 1).R; // Cima à direita
                                int v10y = img1.GetPixel(x, y - 1).R;     // Esquerda
                                int v11y = img1.GetPixel(x, y).R;         // Centro
                                int v12y = img1.GetPixel(x, y + 1).R;     // Direita
                                int v20y = img1.GetPixel(x + 1, y - 1).R; // Baixo à esquerda
                                int v21y = img1.GetPixel(x + 1, y).R;     // Baixo
                                int v22y = img1.GetPixel(x + 1, y + 1).R; // Baixo à direita

                                // Calcular Gy usando o kernel Laplaciano
                                int gy = (-1 * v00y) + (-1 * v01y) + (-1 * v02y) +
                                         (-1 * v10y) + (8 * v11y) + (-1 * v12y) +
                                         (-1 * v20y) + (-1 * v21y) + (-1 * v22y);

                                // A intensidade final pode ser baseada em gx ou gy (ou ambos)
                                int intensidade = Clamp((int)Math.Sqrt(gx * gx + gy * gy));
                                imgLaplaciano.SetPixel(x, y, Color.FromArgb(intensidade, intensidade, intensidade));
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione um preset o Laplaciano", "Atenção");
                    }
                }
                else if (checkCinco.Checked == true)
                {
                    MessageBox.Show("Selecione o 3x3 para calcular o Laplaciano", "Atenção");
                }
                else
                {
                    MessageBox.Show("Marque um Kernel antes de calcular o Laplaciano", "Atenção");
                }

                pictureBox3.Image = imgLaplaciano;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Laplaciano", "Atenção");
            }

        }

        private void checkSet1_CheckedChanged(object sender, EventArgs e)
        {

            if (alterando) return;

            alterando = true;
            if (checkSet1.Checked)
            {
                checkSet2.Checked = false;
            }
            alterando = false;
        }

        private void checkSet2_CheckedChanged(object sender, EventArgs e)
        {
            if (alterando) return;

            alterando = true;
            if (checkSet2.Checked)
            {
                checkSet1.Checked = false;
            }
            alterando = false;
        }

        private void btnDila_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Cria uma nova imagem para armazenar o resultado da dilatação
                Bitmap imgDilatada = new Bitmap(largura, altura);

                // Percorre a imagem original e aplicar a dilatação
                for (int y = 1; y < altura - 1; y++) // Ignora as bordas
                {
                    for (int x = 1; x < largura - 1; x++) // Ignora as bordas
                    {
                        bool dilatado = false;

                        // Verifica a vizinhança 3x3 ao redor do pixel 
                        for (int ky = -1; ky <= 1; ky++)
                        {
                            for (int kx = -1; kx <= 1; kx++)
                            {
                                // Cria a cruz do elemento estruturante 3x3
                                if (kx == 0 || ky == 0)
                                {
                                    Color pixel = img1.GetPixel(x + kx, y + ky);

                                    // Verificar se o pixel é "diferente de 0" 
                                    if (pixel.R > 0 || pixel.G > 0 || pixel.B > 0)
                                    {
                                        dilatado = true; // Se qualquer pixel na vizinhança for diferente de preto, dilata
                                        break;
                                    }
                                }
                            }
                            if (dilatado) break;
                        }

                        // Se a vizinhança tem pelo menos um pixel"branco, dilata (coloca 1)
                        if (dilatado)
                        {
                            imgDilatada.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            imgDilatada.SetPixel(x, y, Color.Black);
                        }
                    }
                }

                pictureBox3.Image = imgDilatada;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Dilatação", "Atenção");
            }
        }

        private void btnEro_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                // Criar uma nova imagem para armazenar o resultado da dilatação
                Bitmap imgErosao = new Bitmap(largura, altura);

                // Elemento estruturante cruzado 3x3
                int[,] elementoEstruturante = {
                                          { 0, 1, 0 },
                                          { 1, 1, 1 },
                                          { 0, 1, 0 }
                                                    };

                // Percorre a imagem original e aplica a erosão
                for (int y = 1; y < altura - 1; y++) // Ignora as bordas
                {
                    for (int x = 1; x < largura - 1; x++) // Ignora as bordas
                    {
                        bool erodido = true; // Inicializa como verdadeiro

                        // Verifica a vizinhança 3x3 ao redor do pixel (x, y)
                        for (int ky = -1; ky <= 1; ky++)
                        {
                            for (int kx = -1; kx <= 1; kx++)
                            {
                                if (elementoEstruturante[ky + 1, kx + 1] == 1) // Verifica se o elemento estruturante é 1
                                {
                                    Color pixel = img1.GetPixel(x + kx, y + ky);

                                    // Se algum pixel na vizinhança for preto (0), a erosão falha
                                    if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                                    {
                                        erodido = false; // Se encontrar um pixel preto, a erosão falha
                                        break;
                                    }
                                }
                            }
                            if (!erodido)
                                break;
                        }

                        // Se todos os pixels na vizinhança forem diferentes de preto, coloca 1 (branco)
                        if (erodido)
                        {
                            imgErosao.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            imgErosao.SetPixel(x, y, Color.Black);
                        }
                    }
                }

                pictureBox3.Image = imgErosao;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Erosão", "Atenção");
            }
        }

        private Bitmap Erosao(Bitmap imagem, int[,] elementoEstruturante)
        {
            int largura = imagem.Width;
            int altura = imagem.Height;
            Bitmap imagemErosao = new Bitmap(largura, altura);

            // Percorre a imagem aplicando a erosão
            for (int y = 1; y < altura - 1; y++)
            {
                for (int x = 1; x < largura - 1; x++)
                {
                    bool erodido = true; // Inicializa como verdadeiro

                    // Verifica a vizinhança 3x3 ao redor do pixel (x, y)
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            if (elementoEstruturante[ky + 1, kx + 1] == 1) // Verifica se o elemento estruturante é 1
                            {
                                Color pixel = imagem.GetPixel(x + kx, y + ky);

                                // Se algum pixel na vizinhança for preto (0), a erosão falha
                                if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                                {
                                    erodido = false; // Se encontrar um pixel preto, a erosão falha
                                    break;
                                }
                            }
                        }
                        if (!erodido)
                            break;
                    }

                    // Se todos os pixels na vizinhança forem diferentes de preto, coloca 1 (branco)
                    if (erodido)
                    {
                        imagemErosao.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        imagemErosao.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return imagemErosao;
        }

        private Bitmap Dilatacao(Bitmap imagem, int[,] elementoEstruturante)
        {
            int largura = imagem.Width;
            int altura = imagem.Height;
            Bitmap imagemDilatada = new Bitmap(largura, altura);

            // Percorre a Imagem 
            for (int y = 1; y < altura - 1; y++)
            {
                for (int x = 1; x < largura - 1; x++)
                {
                    bool dilatado = false; // Inicializa como falso

                    // Verifica a vizinhança 3x3 ao redor do pixel (x, y)
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            if (elementoEstruturante[ky + 1, kx + 1] == 1) // Verifica se o elemento estruturante é 1
                            {
                                Color pixel = imagem.GetPixel(x + kx, y + ky);

                                // Se qualquer pixel da vizinhança for branco (1), a dilatação é bem-sucedida
                                if (pixel.R == 255 && pixel.G == 255 && pixel.B == 255)
                                {
                                    dilatado = true;
                                    break;
                                }
                            }
                        }
                        if (dilatado)
                            break;
                    }

                    // Se a dilatação foi bem-sucedida, coloca 1 (branco)
                    if (dilatado)
                    {
                        imagemDilatada.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        imagemDilatada.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return imagemDilatada;
        }

        private void btnAbert_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                // Elemento Estruturante 3x3
                int[,] elementoEstruturante = {
                                              { 0, 1, 0 },
                                              { 1, 1, 1 },
                                              { 0, 1, 0 }
                                                        };

                // Erosão
                Bitmap imagemErosao = Erosao(img1, elementoEstruturante);

                // Dilatação
                Bitmap imagemAbertura = Dilatacao(imagemErosao, elementoEstruturante);


                pictureBox3.Image = imagemAbertura;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Abertura", "Atenção");


            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                // Elemento Estruturante 3x3
                int[,] elementoEstruturante = {
                                              { 0, 1, 0 },
                                              { 1, 1, 1 },
                                              { 0, 1, 0 }
                                                        };

                // Dilatação
                Bitmap imagemDilatada = Dilatacao(img1, elementoEstruturante);

                // Erosão
                Bitmap imagemFechamento = Erosao(imagemDilatada, elementoEstruturante);


                pictureBox3.Image = imagemFechamento;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular o Fechamento", "Atenção");
            }
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                int largura = img1.Width;
                int altura = img1.Height;

                int[,] elementoEstruturante = {
                                              { 0, 1, 0 },
                                              { 1, 1, 1 },
                                              { 0, 1, 0 }
                                                        };

                Bitmap imgErosao = new Bitmap(largura, altura);
                Bitmap imgContorno = new Bitmap(largura, altura);

                // Aplica Erosão
                for (int y = 1; y < altura - 1; y++)
                {
                    for (int x = 1; x < largura - 1; x++)
                    {
                        bool erodido = true;

                        for (int ky = -1; ky <= 1; ky++)
                        {
                            for (int kx = -1; kx <= 1; kx++)
                            {
                                if (elementoEstruturante[ky + 1, kx + 1] == 1)
                                {
                                    Color pixel = img1.GetPixel(x + kx, y + ky);

                                    if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                                    {
                                        erodido = false;
                                        break;
                                    }
                                }
                            }
                            if (!erodido)
                                break;
                        }

                        imgErosao.SetPixel(x, y, erodido ? Color.White : Color.Black);
                    }
                }

                // Calcula contorno
                for (int y = 0; y < altura; y++)
                {
                    for (int x = 0; x < largura; x++)
                    {
                        Color original = img1.GetPixel(x, y);
                        Color erodido = imgErosao.GetPixel(x, y);

                        // Subtrai pixel a pixel
                        int r = Clamp(original.R - erodido.R);
                        imgContorno.SetPixel(x, y, Color.FromArgb(r, r, r));
                    }
                }

                pictureBox3.Image = imgContorno;
            }
            else
            {
                MessageBox.Show("A imagem 1 deve ser inserida antes de calcular a Erosão/Contorno", "Atenção");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //aa
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //aa
        }
    }
}

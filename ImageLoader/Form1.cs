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

        byte[,] vImg4R;
        byte[,] vImg4G;
        byte[,] vImg4B;
        byte[,] vImg4A;


        public Form1()
        {
            InitializeComponent();
            txSumManual.Controls.RemoveAt(0);
            txSubtManual.Controls.RemoveAt(0);
        }

        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Users\\amand\\Desktop\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;


                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                }

            }
        }
        private void btCarregarImagemB_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            openFileDialog2.InitialDirectory = "C:\\Matlab";
            openFileDialog2.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Armnazena o path do arquivo de imagem
                filePath = openFileDialog2.FileName;

                bool bLoadImgOK = false;
                try
                {
                    img2 = new Bitmap(filePath);
                    img3 = new Bitmap(img2.Width, img2.Height);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    // Adiciona imagem na PictureBox
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
            if (img1 != null && img2 != null)
            {
                if (img1.Width != img2.Width || img1.Height != img2.Height)
                {
                    MessageBox.Show("As imagens devem ter o mesmo tamanho.", "Atenção");
                    return;
                }

                Bitmap imgSoma = new Bitmap(img1.Width, img1.Height);

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel1 = img1.GetPixel(i, j);
                        Color pixel2 = img2.GetPixel(i, j);

                        byte R = (byte)Math.Min(pixel1.R + pixel2.R, 255);
                        byte G = (byte)Math.Min(pixel1.G + pixel2.G, 255);
                        byte B = (byte)Math.Min(pixel1.B + pixel2.B, 255);
                        byte A = 255;
                        
                        Color cor = Color.FromArgb(A, R, G, B);
                        imgSoma.SetPixel(i, j, cor);
                    }
                }

                pictureBox3.Image = imgSoma;
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
            if (vImg1R == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Brilho brilho = new Brilho();

            if (int.TryParse(txSumManual.Text, out var brilhoInt))
            {
                brilho.brilhoImagem(vImg1R, vImg1G, vImg1B, brilhoInt);
            }
            else
            {
                MessageBox.Show("Valor inválido para brilho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox3.Image = brilho.brilhoImagem(vImg1R, vImg1G, vImg1B, brilhoInt);
            pictureBox3.Refresh();
        }


        private void btSubtManual_Click(object sender, EventArgs e)
        {
            if (vImg1R == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MenosBrilho menosBrilho = new MenosBrilho();

            if (int.TryParse(txSubtManual.Text, out var menosBrilhoInt))
            {
                menosBrilho.menosBrilhoImagem(vImg1R, vImg1G, vImg1B, menosBrilhoInt);
            }
            else
            {
                MessageBox.Show("Valor inválido para brilho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox3.Image = menosBrilho.menosBrilhoImagem(vImg1R, vImg1G, vImg1B, menosBrilhoInt);
            pictureBox3.Refresh();
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

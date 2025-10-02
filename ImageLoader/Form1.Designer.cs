namespace ImageLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btCarregarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSalvarImagem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btCarregarImagemB = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btSomarImg = new System.Windows.Forms.Button();
            this.btSomarManual = new System.Windows.Forms.Button();
            this.btSubImg = new System.Windows.Forms.Button();
            this.txValor = new System.Windows.Forms.NumericUpDown();
            this.btSubtManual = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDivid = new System.Windows.Forms.Button();
            this.btCinza = new System.Windows.Forms.Button();
            this.btFlipX = new System.Windows.Forms.Button();
            this.btFlipY = new System.Windows.Forms.Button();
            this.btDiff = new System.Windows.Forms.Button();
            this.btBlend = new System.Windows.Forms.Button();
            this.btLinear = new System.Windows.Forms.Button();
            this.btAND = new System.Windows.Forms.Button();
            this.btOR = new System.Windows.Forms.Button();
            this.btNOT = new System.Windows.Forms.Button();
            this.btXOR = new System.Windows.Forms.Button();
            this.btLimiar = new System.Windows.Forms.Button();
            this.btNegativo = new System.Windows.Forms.Button();
            this.btHistograma = new System.Windows.Forms.Button();
            this.chartImagem1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartImagemFinal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImagemFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(37, 184);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagem.TabIndex = 0;
            this.btCarregarImagem.Text = "Carregar ImagemA";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(283, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(1109, 188);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1088, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btCarregarImagemB
            // 
            this.btCarregarImagemB.Location = new System.Drawing.Point(303, 184);
            this.btCarregarImagemB.Name = "btCarregarImagemB";
            this.btCarregarImagemB.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagemB.TabIndex = 6;
            this.btCarregarImagemB.Text = "Carregar ImagemB";
            this.btCarregarImagemB.UseVisualStyleBackColor = true;
            this.btCarregarImagemB.Click += new System.EventHandler(this.btCarregarImagemB_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btSomarImg
            // 
            this.btSomarImg.Location = new System.Drawing.Point(545, 38);
            this.btSomarImg.Name = "btSomarImg";
            this.btSomarImg.Size = new System.Drawing.Size(86, 30);
            this.btSomarImg.TabIndex = 7;
            this.btSomarImg.Text = "SOMA";
            this.btSomarImg.UseVisualStyleBackColor = true;
            this.btSomarImg.Click += new System.EventHandler(this.btSomarImg_Click);
            // 
            // btSomarManual
            // 
            this.btSomarManual.Location = new System.Drawing.Point(545, 110);
            this.btSomarManual.Name = "btSomarManual";
            this.btSomarManual.Size = new System.Drawing.Size(86, 30);
            this.btSomarManual.TabIndex = 10;
            this.btSomarManual.Text = "BRILHO +";
            this.btSomarManual.UseVisualStyleBackColor = true;
            this.btSomarManual.Click += new System.EventHandler(this.btSomarManual_Click);
            // 
            // btSubImg
            // 
            this.btSubImg.Location = new System.Drawing.Point(545, 74);
            this.btSubImg.Name = "btSubImg";
            this.btSubImg.Size = new System.Drawing.Size(86, 30);
            this.btSubImg.TabIndex = 11;
            this.btSubImg.Text = "SUBT";
            this.btSubImg.UseVisualStyleBackColor = true;
            this.btSubImg.Click += new System.EventHandler(this.btSubImg_Click);
            // 
            // txValor
            // 
            this.txValor.DecimalPlaces = 1;
            this.txValor.Location = new System.Drawing.Point(545, 12);
            this.txValor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(86, 20);
            this.txValor.TabIndex = 12;
            this.txValor.UseWaitCursor = true;
            // 
            // btSubtManual
            // 
            this.btSubtManual.Location = new System.Drawing.Point(545, 146);
            this.btSubtManual.Name = "btSubtManual";
            this.btSubtManual.Size = new System.Drawing.Size(86, 30);
            this.btSubtManual.TabIndex = 14;
            this.btSubtManual.Text = "BRILHO -";
            this.btSubtManual.UseVisualStyleBackColor = true;
            this.btSubtManual.Click += new System.EventHandler(this.btSubtManual_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(545, 182);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(86, 30);
            this.btMulti.TabIndex = 15;
            this.btMulti.Text = "MULTI";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDivid
            // 
            this.btDivid.Location = new System.Drawing.Point(637, 38);
            this.btDivid.Name = "btDivid";
            this.btDivid.Size = new System.Drawing.Size(86, 30);
            this.btDivid.TabIndex = 16;
            this.btDivid.Text = "DIVID";
            this.btDivid.UseVisualStyleBackColor = true;
            this.btDivid.Click += new System.EventHandler(this.btDivid_Click);
            // 
            // btCinza
            // 
            this.btCinza.Location = new System.Drawing.Point(637, 74);
            this.btCinza.Name = "btCinza";
            this.btCinza.Size = new System.Drawing.Size(86, 30);
            this.btCinza.TabIndex = 17;
            this.btCinza.Text = "CINZA";
            this.btCinza.UseVisualStyleBackColor = true;
            this.btCinza.Click += new System.EventHandler(this.btCinza_Click);
            // 
            // btFlipX
            // 
            this.btFlipX.Location = new System.Drawing.Point(637, 110);
            this.btFlipX.Name = "btFlipX";
            this.btFlipX.Size = new System.Drawing.Size(86, 30);
            this.btFlipX.TabIndex = 18;
            this.btFlipX.Text = "FLIPX";
            this.btFlipX.UseVisualStyleBackColor = true;
            this.btFlipX.Click += new System.EventHandler(this.btFlipX_Click);
            // 
            // btFlipY
            // 
            this.btFlipY.Location = new System.Drawing.Point(637, 146);
            this.btFlipY.Name = "btFlipY";
            this.btFlipY.Size = new System.Drawing.Size(86, 30);
            this.btFlipY.TabIndex = 19;
            this.btFlipY.Text = "FLIPY";
            this.btFlipY.UseVisualStyleBackColor = true;
            this.btFlipY.Click += new System.EventHandler(this.btFlipY_Click);
            // 
            // btDiff
            // 
            this.btDiff.Location = new System.Drawing.Point(637, 182);
            this.btDiff.Name = "btDiff";
            this.btDiff.Size = new System.Drawing.Size(86, 30);
            this.btDiff.TabIndex = 20;
            this.btDiff.Text = "DIFF";
            this.btDiff.UseVisualStyleBackColor = true;
            this.btDiff.Click += new System.EventHandler(this.btDiff_Click);
            // 
            // btBlend
            // 
            this.btBlend.Location = new System.Drawing.Point(729, 38);
            this.btBlend.Name = "btBlend";
            this.btBlend.Size = new System.Drawing.Size(86, 30);
            this.btBlend.TabIndex = 21;
            this.btBlend.Text = "BLEND";
            this.btBlend.UseVisualStyleBackColor = true;
            this.btBlend.Click += new System.EventHandler(this.btBlend_Click);
            // 
            // btLinear
            // 
            this.btLinear.Location = new System.Drawing.Point(729, 74);
            this.btLinear.Name = "btLinear";
            this.btLinear.Size = new System.Drawing.Size(86, 30);
            this.btLinear.TabIndex = 22;
            this.btLinear.Text = "LINEAR";
            this.btLinear.UseVisualStyleBackColor = true;
            this.btLinear.Click += new System.EventHandler(this.btLinear_Click);
            // 
            // btAND
            // 
            this.btAND.Location = new System.Drawing.Point(729, 110);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(86, 30);
            this.btAND.TabIndex = 23;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = true;
            this.btAND.Click += new System.EventHandler(this.btAND_Click);
            // 
            // btOR
            // 
            this.btOR.Location = new System.Drawing.Point(729, 146);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(86, 30);
            this.btOR.TabIndex = 24;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btNOT
            // 
            this.btNOT.Location = new System.Drawing.Point(729, 182);
            this.btNOT.Name = "btNOT";
            this.btNOT.Size = new System.Drawing.Size(86, 30);
            this.btNOT.TabIndex = 25;
            this.btNOT.Text = "NOT";
            this.btNOT.UseVisualStyleBackColor = true;
            this.btNOT.Click += new System.EventHandler(this.btNOT_Click);
            // 
            // btXOR
            // 
            this.btXOR.Location = new System.Drawing.Point(821, 38);
            this.btXOR.Name = "btXOR";
            this.btXOR.Size = new System.Drawing.Size(86, 30);
            this.btXOR.TabIndex = 26;
            this.btXOR.Text = "XOR";
            this.btXOR.UseVisualStyleBackColor = true;
            this.btXOR.Click += new System.EventHandler(this.btXOR_Click);
            // 
            // btLimiar
            // 
            this.btLimiar.Location = new System.Drawing.Point(821, 74);
            this.btLimiar.Name = "btLimiar";
            this.btLimiar.Size = new System.Drawing.Size(86, 30);
            this.btLimiar.TabIndex = 27;
            this.btLimiar.Text = "LIMIAR";
            this.btLimiar.UseVisualStyleBackColor = true;
            this.btLimiar.Click += new System.EventHandler(this.btLimiar_Click);
            // 
            // btNegativo
            // 
            this.btNegativo.Location = new System.Drawing.Point(821, 110);
            this.btNegativo.Name = "btNegativo";
            this.btNegativo.Size = new System.Drawing.Size(86, 30);
            this.btNegativo.TabIndex = 28;
            this.btNegativo.Text = "NEGATIVO";
            this.btNegativo.UseVisualStyleBackColor = true;
            this.btNegativo.Click += new System.EventHandler(this.btNegativo_Click);
            // 
            // btHistograma
            // 
            this.btHistograma.Location = new System.Drawing.Point(821, 146);
            this.btHistograma.Name = "btHistograma";
            this.btHistograma.Size = new System.Drawing.Size(86, 30);
            this.btHistograma.TabIndex = 29;
            this.btHistograma.Text = "HISTOGRAMA";
            this.btHistograma.UseVisualStyleBackColor = true;
            this.btHistograma.Click += new System.EventHandler(this.btHistograma_Click);
            // 
            // chartImagem1
            // 
            this.chartImagem1.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chartImagem1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartImagem1.Legends.Add(legend1);
            this.chartImagem1.Location = new System.Drawing.Point(52, 364);
            this.chartImagem1.Name = "chartImagem1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartImagem1.Series.Add(series1);
            this.chartImagem1.Size = new System.Drawing.Size(300, 300);
            this.chartImagem1.TabIndex = 30;
            this.chartImagem1.Text = "chart1";
            // 
            // chartImagemFinal
            // 
            chartArea2.Name = "ChartArea1";
            this.chartImagemFinal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartImagemFinal.Legends.Add(legend2);
            this.chartImagemFinal.Location = new System.Drawing.Point(466, 364);
            this.chartImagemFinal.Name = "chartImagemFinal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartImagemFinal.Series.Add(series2);
            this.chartImagemFinal.Size = new System.Drawing.Size(300, 300);
            this.chartImagemFinal.TabIndex = 31;
            this.chartImagemFinal.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 584);
            this.Controls.Add(this.chartImagemFinal);
            this.Controls.Add(this.chartImagem1);
            this.Controls.Add(this.btHistograma);
            this.Controls.Add(this.btNegativo);
            this.Controls.Add(this.btLimiar);
            this.Controls.Add(this.btXOR);
            this.Controls.Add(this.btNOT);
            this.Controls.Add(this.btOR);
            this.Controls.Add(this.btAND);
            this.Controls.Add(this.btLinear);
            this.Controls.Add(this.btBlend);
            this.Controls.Add(this.btDiff);
            this.Controls.Add(this.btFlipY);
            this.Controls.Add(this.btFlipX);
            this.Controls.Add(this.btCinza);
            this.Controls.Add(this.btDivid);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btSubtManual);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.btSubImg);
            this.Controls.Add(this.btSomarManual);
            this.Controls.Add(this.btSomarImg);
            this.Controls.Add(this.btCarregarImagemB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCarregarImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImagemFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCarregarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSalvarImagem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btCarregarImagemB;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btSomarImg;
        private System.Windows.Forms.Button btSomarManual;
        private System.Windows.Forms.Button btSubImg;
        private System.Windows.Forms.NumericUpDown txValor;
        private System.Windows.Forms.Button btSubtManual;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDivid;
        private System.Windows.Forms.Button btCinza;
        private System.Windows.Forms.Button btFlipX;
        private System.Windows.Forms.Button btFlipY;
        private System.Windows.Forms.Button btDiff;
        private System.Windows.Forms.Button btBlend;
        private System.Windows.Forms.Button btLinear;
        private System.Windows.Forms.Button btAND;
        private System.Windows.Forms.Button btOR;
        private System.Windows.Forms.Button btNOT;
        private System.Windows.Forms.Button btXOR;
        private System.Windows.Forms.Button btLimiar;
        private System.Windows.Forms.Button btNegativo;
        private System.Windows.Forms.Button btHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartImagem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartImagemFinal;
    }
}


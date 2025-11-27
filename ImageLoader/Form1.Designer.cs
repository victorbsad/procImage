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
            this.btnMax = new System.Windows.Forms.Button();
            this.checkTres = new System.Windows.Forms.CheckBox();
            this.checkCinco = new System.Windows.Forms.CheckBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            this.btnSuave = new System.Windows.Forms.Button();
            this.btnPrewitt = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.checkSet1 = new System.Windows.Forms.CheckBox();
            this.checkSet2 = new System.Windows.Forms.CheckBox();
            this.btnLaplaciano = new System.Windows.Forms.Button();
            this.btnDila = new System.Windows.Forms.Button();
            this.btnEro = new System.Windows.Forms.Button();
            this.btnAbert = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(283, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(1186, 188);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1165, 12);
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
            this.btSomarImg.Location = new System.Drawing.Point(639, 106);
            this.btSomarImg.Name = "btSomarImg";
            this.btSomarImg.Size = new System.Drawing.Size(91, 30);
            this.btSomarImg.TabIndex = 7;
            this.btSomarImg.Text = "SOMA";
            this.btSomarImg.UseVisualStyleBackColor = true;
            this.btSomarImg.Click += new System.EventHandler(this.btSomarImg_Click);
            // 
            // btSomarManual
            // 
            this.btSomarManual.Location = new System.Drawing.Point(639, 34);
            this.btSomarManual.Name = "btSomarManual";
            this.btSomarManual.Size = new System.Drawing.Size(91, 30);
            this.btSomarManual.TabIndex = 10;
            this.btSomarManual.Text = "BRILHO +";
            this.btSomarManual.UseVisualStyleBackColor = true;
            this.btSomarManual.Click += new System.EventHandler(this.btSomarManual_Click);
            // 
            // btSubImg
            // 
            this.btSubImg.Location = new System.Drawing.Point(639, 142);
            this.btSubImg.Name = "btSubImg";
            this.btSubImg.Size = new System.Drawing.Size(91, 30);
            this.btSubImg.TabIndex = 11;
            this.btSubImg.Text = "SUBT";
            this.btSubImg.UseVisualStyleBackColor = true;
            this.btSubImg.Click += new System.EventHandler(this.btSubImg_Click);
            // 
            // txValor
            // 
            this.txValor.DecimalPlaces = 1;
            this.txValor.Location = new System.Drawing.Point(547, 34);
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
            this.btSubtManual.Location = new System.Drawing.Point(639, 70);
            this.btSubtManual.Name = "btSubtManual";
            this.btSubtManual.Size = new System.Drawing.Size(91, 30);
            this.btSubtManual.TabIndex = 14;
            this.btSubtManual.Text = "BRILHO -";
            this.btSubtManual.UseVisualStyleBackColor = true;
            this.btSubtManual.Click += new System.EventHandler(this.btSubtManual_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(740, 70);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(91, 30);
            this.btMulti.TabIndex = 15;
            this.btMulti.Text = "MULTI";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDivid
            // 
            this.btDivid.Location = new System.Drawing.Point(740, 106);
            this.btDivid.Name = "btDivid";
            this.btDivid.Size = new System.Drawing.Size(91, 30);
            this.btDivid.TabIndex = 16;
            this.btDivid.Text = "DIVID";
            this.btDivid.UseVisualStyleBackColor = true;
            this.btDivid.Click += new System.EventHandler(this.btDivid_Click);
            // 
            // btCinza
            // 
            this.btCinza.Location = new System.Drawing.Point(934, 34);
            this.btCinza.Name = "btCinza";
            this.btCinza.Size = new System.Drawing.Size(91, 30);
            this.btCinza.TabIndex = 17;
            this.btCinza.Text = "CINZA";
            this.btCinza.UseVisualStyleBackColor = true;
            this.btCinza.Click += new System.EventHandler(this.btCinza_Click);
            // 
            // btFlipX
            // 
            this.btFlipX.Location = new System.Drawing.Point(934, 70);
            this.btFlipX.Name = "btFlipX";
            this.btFlipX.Size = new System.Drawing.Size(91, 30);
            this.btFlipX.TabIndex = 18;
            this.btFlipX.Text = "FLIPX";
            this.btFlipX.UseVisualStyleBackColor = true;
            this.btFlipX.Click += new System.EventHandler(this.btFlipX_Click);
            // 
            // btFlipY
            // 
            this.btFlipY.Location = new System.Drawing.Point(934, 106);
            this.btFlipY.Name = "btFlipY";
            this.btFlipY.Size = new System.Drawing.Size(91, 30);
            this.btFlipY.TabIndex = 19;
            this.btFlipY.Text = "FLIPY";
            this.btFlipY.UseVisualStyleBackColor = true;
            this.btFlipY.Click += new System.EventHandler(this.btFlipY_Click);
            // 
            // btDiff
            // 
            this.btDiff.Location = new System.Drawing.Point(740, 34);
            this.btDiff.Name = "btDiff";
            this.btDiff.Size = new System.Drawing.Size(91, 30);
            this.btDiff.TabIndex = 20;
            this.btDiff.Text = "DIFF";
            this.btDiff.UseVisualStyleBackColor = true;
            this.btDiff.Click += new System.EventHandler(this.btDiff_Click);
            // 
            // btBlend
            // 
            this.btBlend.Location = new System.Drawing.Point(1031, 34);
            this.btBlend.Name = "btBlend";
            this.btBlend.Size = new System.Drawing.Size(91, 30);
            this.btBlend.TabIndex = 21;
            this.btBlend.Text = "BLEND";
            this.btBlend.UseVisualStyleBackColor = true;
            this.btBlend.Click += new System.EventHandler(this.btBlend_Click);
            // 
            // btLinear
            // 
            this.btLinear.Location = new System.Drawing.Point(1031, 70);
            this.btLinear.Name = "btLinear";
            this.btLinear.Size = new System.Drawing.Size(91, 30);
            this.btLinear.TabIndex = 22;
            this.btLinear.Text = "LINEAR";
            this.btLinear.UseVisualStyleBackColor = true;
            this.btLinear.Click += new System.EventHandler(this.btLinear_Click);
            // 
            // btAND
            // 
            this.btAND.Location = new System.Drawing.Point(837, 34);
            this.btAND.Name = "btAND";
            this.btAND.Size = new System.Drawing.Size(91, 30);
            this.btAND.TabIndex = 23;
            this.btAND.Text = "AND";
            this.btAND.UseVisualStyleBackColor = true;
            this.btAND.Click += new System.EventHandler(this.btAND_Click);
            // 
            // btOR
            // 
            this.btOR.Location = new System.Drawing.Point(837, 70);
            this.btOR.Name = "btOR";
            this.btOR.Size = new System.Drawing.Size(91, 30);
            this.btOR.TabIndex = 24;
            this.btOR.Text = "OR";
            this.btOR.UseVisualStyleBackColor = true;
            this.btOR.Click += new System.EventHandler(this.btOR_Click);
            // 
            // btNOT
            // 
            this.btNOT.Location = new System.Drawing.Point(837, 106);
            this.btNOT.Name = "btNOT";
            this.btNOT.Size = new System.Drawing.Size(91, 30);
            this.btNOT.TabIndex = 25;
            this.btNOT.Text = "NOT";
            this.btNOT.UseVisualStyleBackColor = true;
            this.btNOT.Click += new System.EventHandler(this.btNOT_Click);
            // 
            // btXOR
            // 
            this.btXOR.Location = new System.Drawing.Point(837, 143);
            this.btXOR.Name = "btXOR";
            this.btXOR.Size = new System.Drawing.Size(91, 30);
            this.btXOR.TabIndex = 26;
            this.btXOR.Text = "XOR";
            this.btXOR.UseVisualStyleBackColor = true;
            this.btXOR.Click += new System.EventHandler(this.btXOR_Click);
            // 
            // btLimiar
            // 
            this.btLimiar.Location = new System.Drawing.Point(1031, 106);
            this.btLimiar.Name = "btLimiar";
            this.btLimiar.Size = new System.Drawing.Size(91, 30);
            this.btLimiar.TabIndex = 27;
            this.btLimiar.Text = "LIMIAR";
            this.btLimiar.UseVisualStyleBackColor = true;
            this.btLimiar.Click += new System.EventHandler(this.btLimiar_Click);
            // 
            // btNegativo
            // 
            this.btNegativo.Location = new System.Drawing.Point(1031, 142);
            this.btNegativo.Name = "btNegativo";
            this.btNegativo.Size = new System.Drawing.Size(91, 30);
            this.btNegativo.TabIndex = 28;
            this.btNegativo.Text = "NEGATIVO";
            this.btNegativo.UseVisualStyleBackColor = true;
            this.btNegativo.Click += new System.EventHandler(this.btNegativo_Click);
            // 
            // btHistograma
            // 
            this.btHistograma.Location = new System.Drawing.Point(1031, 178);
            this.btHistograma.Name = "btHistograma";
            this.btHistograma.Size = new System.Drawing.Size(91, 30);
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
            this.chartImagem1.Location = new System.Drawing.Point(52, 445);
            this.chartImagem1.Name = "chartImagem1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartImagem1.Series.Add(series1);
            this.chartImagem1.Size = new System.Drawing.Size(364, 219);
            this.chartImagem1.TabIndex = 30;
            this.chartImagem1.Text = "chart1";
            // 
            // chartImagemFinal
            // 
            chartArea2.Name = "ChartArea1";
            this.chartImagemFinal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartImagemFinal.Legends.Add(legend2);
            this.chartImagemFinal.Location = new System.Drawing.Point(467, 445);
            this.chartImagemFinal.Name = "chartImagemFinal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartImagemFinal.Series.Add(series2);
            this.chartImagemFinal.Size = new System.Drawing.Size(364, 219);
            this.chartImagemFinal.TabIndex = 31;
            this.chartImagemFinal.Text = "chart2";
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(159, 287);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(86, 30);
            this.btnMax.TabIndex = 32;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // checkTres
            // 
            this.checkTres.AutoSize = true;
            this.checkTres.Location = new System.Drawing.Point(547, 92);
            this.checkTres.Name = "checkTres";
            this.checkTres.Size = new System.Drawing.Size(43, 17);
            this.checkTres.TabIndex = 33;
            this.checkTres.Text = "3x3";
            this.checkTres.UseVisualStyleBackColor = true;
            this.checkTres.CheckedChanged += new System.EventHandler(this.checkTres_CheckedChanged);
            // 
            // checkCinco
            // 
            this.checkCinco.AutoSize = true;
            this.checkCinco.Location = new System.Drawing.Point(547, 115);
            this.checkCinco.Name = "checkCinco";
            this.checkCinco.Size = new System.Drawing.Size(43, 17);
            this.checkCinco.TabIndex = 34;
            this.checkCinco.Text = "5x5";
            this.checkCinco.UseVisualStyleBackColor = true;
            this.checkCinco.CheckedChanged += new System.EventHandler(this.checkCinco_CheckedChanged);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(159, 323);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(86, 30);
            this.btnMin.TabIndex = 35;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(159, 359);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(86, 30);
            this.btnMean.TabIndex = 36;
            this.btnMean.Text = "MEAN";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(251, 287);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(86, 30);
            this.btnMediana.TabIndex = 37;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.Location = new System.Drawing.Point(251, 323);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(86, 30);
            this.btnOrdem.TabIndex = 38;
            this.btnOrdem.Text = "Ordem";
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.Location = new System.Drawing.Point(251, 359);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(86, 30);
            this.btnGauss.TabIndex = 39;
            this.btnGauss.Text = "Gaussiano";
            this.btnGauss.UseVisualStyleBackColor = true;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // btnSuave
            // 
            this.btnSuave.Location = new System.Drawing.Point(205, 395);
            this.btnSuave.Name = "btnSuave";
            this.btnSuave.Size = new System.Drawing.Size(86, 30);
            this.btnSuave.TabIndex = 40;
            this.btnSuave.Text = "Suavização";
            this.btnSuave.UseVisualStyleBackColor = true;
            this.btnSuave.Click += new System.EventHandler(this.btnSuave_Click);
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.Location = new System.Drawing.Point(590, 287);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(86, 30);
            this.btnPrewitt.TabIndex = 41;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = true;
            this.btnPrewitt.Click += new System.EventHandler(this.btnPrewitt_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(590, 323);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(86, 30);
            this.btnSobel.TabIndex = 42;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // checkSet1
            // 
            this.checkSet1.AutoSize = true;
            this.checkSet1.Location = new System.Drawing.Point(692, 315);
            this.checkSet1.Name = "checkSet1";
            this.checkSet1.Size = new System.Drawing.Size(65, 17);
            this.checkSet1.TabIndex = 44;
            this.checkSet1.Text = "Preset 1";
            this.checkSet1.UseVisualStyleBackColor = true;
            this.checkSet1.CheckedChanged += new System.EventHandler(this.checkSet1_CheckedChanged);
            // 
            // checkSet2
            // 
            this.checkSet2.AutoSize = true;
            this.checkSet2.Location = new System.Drawing.Point(692, 338);
            this.checkSet2.Name = "checkSet2";
            this.checkSet2.Size = new System.Drawing.Size(65, 17);
            this.checkSet2.TabIndex = 45;
            this.checkSet2.Text = "Preset 2";
            this.checkSet2.UseVisualStyleBackColor = true;
            this.checkSet2.CheckedChanged += new System.EventHandler(this.checkSet2_CheckedChanged);
            // 
            // btnLaplaciano
            // 
            this.btnLaplaciano.Location = new System.Drawing.Point(590, 359);
            this.btnLaplaciano.Name = "btnLaplaciano";
            this.btnLaplaciano.Size = new System.Drawing.Size(86, 30);
            this.btnLaplaciano.TabIndex = 43;
            this.btnLaplaciano.Text = "Laplaciano";
            this.btnLaplaciano.UseVisualStyleBackColor = true;
            this.btnLaplaciano.Click += new System.EventHandler(this.btnLaplaciano_Click);
            // 
            // btnDila
            // 
            this.btnDila.Location = new System.Drawing.Point(946, 287);
            this.btnDila.Name = "btnDila";
            this.btnDila.Size = new System.Drawing.Size(86, 30);
            this.btnDila.TabIndex = 46;
            this.btnDila.Text = "Dilatação";
            this.btnDila.UseVisualStyleBackColor = true;
            this.btnDila.Click += new System.EventHandler(this.btnDila_Click);
            // 
            // btnEro
            // 
            this.btnEro.Location = new System.Drawing.Point(946, 323);
            this.btnEro.Name = "btnEro";
            this.btnEro.Size = new System.Drawing.Size(86, 30);
            this.btnEro.TabIndex = 47;
            this.btnEro.Text = "Erosão";
            this.btnEro.UseVisualStyleBackColor = true;
            this.btnEro.Click += new System.EventHandler(this.btnEro_Click);
            // 
            // btnAbert
            // 
            this.btnAbert.Location = new System.Drawing.Point(946, 359);
            this.btnAbert.Name = "btnAbert";
            this.btnAbert.Size = new System.Drawing.Size(86, 30);
            this.btnAbert.TabIndex = 48;
            this.btnAbert.Text = "Abertura";
            this.btnAbert.UseVisualStyleBackColor = true;
            this.btnAbert.Click += new System.EventHandler(this.btnAbert_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(1038, 287);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(86, 30);
            this.btnFecha.TabIndex = 49;
            this.btnFecha.Text = "Fechamento";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(1038, 323);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(86, 30);
            this.btnCont.TabIndex = 50;
            this.btnCont.Text = "Contorno";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Kernels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Valor Constante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Filtros Passa-Baixa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Filtros Passa-Alta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(978, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = " Operações Morfológicas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnAbert);
            this.Controls.Add(this.btnEro);
            this.Controls.Add(this.btnDila);
            this.Controls.Add(this.checkSet2);
            this.Controls.Add(this.checkSet1);
            this.Controls.Add(this.btnLaplaciano);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.btnPrewitt);
            this.Controls.Add(this.btnSuave);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.btnOrdem);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.checkCinco);
            this.Controls.Add(this.checkTres);
            this.Controls.Add(this.btnMax);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.CheckBox checkTres;
        private System.Windows.Forms.CheckBox checkCinco;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Button btnSuave;
        private System.Windows.Forms.Button btnPrewitt;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.CheckBox checkSet1;
        private System.Windows.Forms.CheckBox checkSet2;
        private System.Windows.Forms.Button btnLaplaciano;
        private System.Windows.Forms.Button btnDila;
        private System.Windows.Forms.Button btnEro;
        private System.Windows.Forms.Button btnAbert;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


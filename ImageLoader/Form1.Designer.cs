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
            this.txSumManual = new System.Windows.Forms.NumericUpDown();
            this.txSubtManual = new System.Windows.Forms.NumericUpDown();
            this.btSubtManual = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txMulti = new System.Windows.Forms.NumericUpDown();
            this.txDiv = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSumManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubtManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiv)).BeginInit();
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
            this.btSomarImg.Location = new System.Drawing.Point(547, 12);
            this.btSomarImg.Name = "btSomarImg";
            this.btSomarImg.Size = new System.Drawing.Size(86, 30);
            this.btSomarImg.TabIndex = 7;
            this.btSomarImg.Text = "SOMA";
            this.btSomarImg.UseVisualStyleBackColor = true;
            this.btSomarImg.Click += new System.EventHandler(this.btSomarImg_Click);
            // 
            // btSomarManual
            // 
            this.btSomarManual.Location = new System.Drawing.Point(547, 84);
            this.btSomarManual.Name = "btSomarManual";
            this.btSomarManual.Size = new System.Drawing.Size(86, 30);
            this.btSomarManual.TabIndex = 10;
            this.btSomarManual.Text = "SOMA MAN.";
            this.btSomarManual.UseVisualStyleBackColor = true;
            this.btSomarManual.Click += new System.EventHandler(this.btSomarManual_Click);
            // 
            // btSubImg
            // 
            this.btSubImg.Location = new System.Drawing.Point(547, 48);
            this.btSubImg.Name = "btSubImg";
            this.btSubImg.Size = new System.Drawing.Size(86, 30);
            this.btSubImg.TabIndex = 11;
            this.btSubImg.Text = "SUBT";
            this.btSubImg.UseVisualStyleBackColor = true;
            this.btSubImg.Click += new System.EventHandler(this.btSubImg_Click);
            // 
            // txSumManual
            // 
            this.txSumManual.Location = new System.Drawing.Point(639, 91);
            this.txSumManual.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txSumManual.Name = "txSumManual";
            this.txSumManual.Size = new System.Drawing.Size(86, 20);
            this.txSumManual.TabIndex = 12;
            this.txSumManual.UseWaitCursor = true;
            // 
            // txSubtManual
            // 
            this.txSubtManual.Location = new System.Drawing.Point(639, 127);
            this.txSubtManual.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txSubtManual.Name = "txSubtManual";
            this.txSubtManual.Size = new System.Drawing.Size(86, 20);
            this.txSubtManual.TabIndex = 13;
            this.txSubtManual.UseWaitCursor = true;
            // 
            // btSubtManual
            // 
            this.btSubtManual.Location = new System.Drawing.Point(547, 120);
            this.btSubtManual.Name = "btSubtManual";
            this.btSubtManual.Size = new System.Drawing.Size(86, 30);
            this.btSubtManual.TabIndex = 14;
            this.btSubtManual.Text = "SUBT MAN.";
            this.btSubtManual.UseVisualStyleBackColor = true;
            this.btSubtManual.Click += new System.EventHandler(this.btSubtManual_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(547, 156);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(86, 30);
            this.btnMulti.TabIndex = 15;
            this.btnMulti.Text = "MULTI";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(547, 192);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(86, 30);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "DIVIS";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txMulti
            // 
            this.txMulti.DecimalPlaces = 2;
            this.txMulti.Location = new System.Drawing.Point(639, 163);
            this.txMulti.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txMulti.Name = "txMulti";
            this.txMulti.Size = new System.Drawing.Size(86, 20);
            this.txMulti.TabIndex = 17;
            this.txMulti.UseWaitCursor = true;
            // 
            // txDiv
            // 
            this.txDiv.DecimalPlaces = 2;
            this.txDiv.Location = new System.Drawing.Point(639, 199);
            this.txDiv.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txDiv.Name = "txDiv";
            this.txDiv.Size = new System.Drawing.Size(86, 20);
            this.txDiv.TabIndex = 18;
            this.txDiv.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 584);
            this.Controls.Add(this.txDiv);
            this.Controls.Add(this.txMulti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btSubtManual);
            this.Controls.Add(this.txSubtManual);
            this.Controls.Add(this.txSumManual);
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
            ((System.ComponentModel.ISupportInitialize)(this.txSumManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubtManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiv)).EndInit();
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
        private System.Windows.Forms.NumericUpDown txSumManual;
        private System.Windows.Forms.NumericUpDown txSubtManual;
        private System.Windows.Forms.Button btSubtManual;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.NumericUpDown txMulti;
        private System.Windows.Forms.NumericUpDown txDiv;
    }
}


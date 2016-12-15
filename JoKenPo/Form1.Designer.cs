namespace JoKenPo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgEscolhaComputador = new System.Windows.Forms.PictureBox();
            this.imgEscolhaJogador = new System.Windows.Forms.PictureBox();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoPedra = new System.Windows.Forms.Button();
            this.grupoPlacar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placarJogador = new System.Windows.Forms.Label();
            this.placarComputador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaJogador)).BeginInit();
            this.grupoPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.grupoPlacar);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.botaoTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPapel);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPedra);
            this.splitContainer1.Size = new System.Drawing.Size(624, 522);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgEscolhaJogador);
            this.groupBox1.Location = new System.Drawing.Point(13, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha Jogador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgEscolhaComputador);
            this.groupBox2.Location = new System.Drawing.Point(420, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha Computador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::JoKenPo.Properties.Resources.Regra;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(214, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 131);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JoKenPo.Properties.Resources.Jkp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imgEscolhaComputador
            // 
            this.imgEscolhaComputador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgEscolhaComputador.Location = new System.Drawing.Point(7, 19);
            this.imgEscolhaComputador.Name = "imgEscolhaComputador";
            this.imgEscolhaComputador.Size = new System.Drawing.Size(187, 161);
            this.imgEscolhaComputador.TabIndex = 1;
            this.imgEscolhaComputador.TabStop = false;
            // 
            // imgEscolhaJogador
            // 
            this.imgEscolhaJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgEscolhaJogador.Location = new System.Drawing.Point(7, 19);
            this.imgEscolhaJogador.Name = "imgEscolhaJogador";
            this.imgEscolhaJogador.Size = new System.Drawing.Size(187, 155);
            this.imgEscolhaJogador.TabIndex = 0;
            this.imgEscolhaJogador.TabStop = false;
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoTesoura.Location = new System.Drawing.Point(420, 0);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(213, 193);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.Text = "Tesoura";
            this.botaoTesoura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.botaoTesoura_Click);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPapel.Location = new System.Drawing.Point(213, 0);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(207, 193);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.Text = "Papel";
            this.botaoPapel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.botaoPapel_Click);
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPedra.Location = new System.Drawing.Point(0, 0);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(213, 193);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.Text = "Pedra";
            this.botaoPedra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.botaoPedra_Click);
            // 
            // grupoPlacar
            // 
            this.grupoPlacar.Controls.Add(this.placarComputador);
            this.grupoPlacar.Controls.Add(this.placarJogador);
            this.grupoPlacar.Controls.Add(this.label2);
            this.grupoPlacar.Controls.Add(this.label1);
            this.grupoPlacar.Location = new System.Drawing.Point(214, 142);
            this.grupoPlacar.Name = "grupoPlacar";
            this.grupoPlacar.Size = new System.Drawing.Size(200, 180);
            this.grupoPlacar.TabIndex = 4;
            this.grupoPlacar.TabStop = false;
            this.grupoPlacar.Text = "Placar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computador";
            // 
            // placarJogador
            // 
            this.placarJogador.AutoSize = true;
            this.placarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarJogador.Location = new System.Drawing.Point(23, 91);
            this.placarJogador.Name = "placarJogador";
            this.placarJogador.Size = new System.Drawing.Size(29, 31);
            this.placarJogador.TabIndex = 2;
            this.placarJogador.Text = "0";
            // 
            // placarComputador
            // 
            this.placarComputador.AutoSize = true;
            this.placarComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarComputador.Location = new System.Drawing.Point(130, 91);
            this.placarComputador.Name = "placarComputador";
            this.placarComputador.Size = new System.Drawing.Size(29, 31);
            this.placarComputador.TabIndex = 3;
            this.placarComputador.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 522);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoKenPo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaJogador)).EndInit();
            this.grupoPlacar.ResumeLayout(false);
            this.grupoPlacar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgEscolhaComputador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgEscolhaJogador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grupoPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placarComputador;
        private System.Windows.Forms.Label placarJogador;
    }
}


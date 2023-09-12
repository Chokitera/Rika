﻿namespace Rika.views
{
    partial class FrmTelaAdministrativa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.lblAeroDecolagem = new System.Windows.Forms.Label();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVoo = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(342, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(176, 129);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(110, 13);
            this.label1lblCodigoPassagem.TabIndex = 1;
            this.label1lblCodigoPassagem.Text = "Código da Passagem:";
            this.label1lblCodigoPassagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Location = new System.Drawing.Point(176, 158);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(128, 13);
            this.lblAeroDecolagem.TabIndex = 2;
            this.lblAeroDecolagem.Text = "Aeroporto de Decolagem:";
            this.lblAeroDecolagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Location = new System.Drawing.Point(176, 186);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(110, 13);
            this.lblAeroDestino.TabIndex = 3;
            this.lblAeroDestino.Text = "Aeroporto de Destino:";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(176, 263);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(89, 13);
            this.lblHoraSaida.TabIndex = 4;
            this.lblHoraSaida.Text = "Horário de Saida:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(176, 213);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(80, 13);
            this.lblDataSaida.TabIndex = 5;
            this.lblDataSaida.Text = "Data de Saída:";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(176, 238);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(94, 13);
            this.lblDataChegada.TabIndex = 6;
            this.lblDataChegada.Text = "Data de Chegada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avião:";
            // 
            // lblVoo
            // 
            this.lblVoo.AutoSize = true;
            this.lblVoo.Location = new System.Drawing.Point(503, 129);
            this.lblVoo.Name = "lblVoo";
            this.lblVoo.Size = new System.Drawing.Size(29, 13);
            this.lblVoo.TabIndex = 8;
            this.lblVoo.Text = "Voo:";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(176, 289);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(105, 13);
            this.lblHoraChegada.TabIndex = 9;
            this.lblHoraChegada.Text = "Horário de Chegada:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvar.BorderRadius = 20;
            this.btnSalvar.BorderSize = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(290, 332);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 38);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluir.BorderRadius = 20;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(390, 332);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 38);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.White;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 20;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(490, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 38);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.modeloBotao1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Avião:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade de Acentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Duração:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmTelaAdministrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblHoraChegada);
            this.Controls.Add(this.lblVoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaAdministrativa";
            this.Text = "FrmTelaAdministrativa";
            this.Load += new System.EventHandler(this.FrmTelaAdministrativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVoo;
        private System.Windows.Forms.Label lblHoraChegada;
        private controls.ModeloBotao btnSalvar;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
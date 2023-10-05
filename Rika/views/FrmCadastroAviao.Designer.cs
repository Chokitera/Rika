namespace Rika.views
{
    partial class FrmCadastroAviao
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
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.lblAeroDecolagem = new System.Windows.Forms.Label();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQtdAcentos = new Rika.controls.novoTextBox();
            this.txtModelAviao = new Rika.controls.novoTextBox();
            this.txtCompAerea = new Rika.controls.novoTextBox();
            this.txtCodAviao = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoo = new Rika.controls.novoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(17, 290);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(178, 22);
            this.lblDataSaida.TabIndex = 49;
            this.lblDataSaida.Text = "Quantidade Acentos:";
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(17, 251);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(123, 22);
            this.lblAeroDestino.TabIndex = 47;
            this.lblAeroDestino.Text = "Modelo Avião:";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(17, 212);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(159, 22);
            this.lblAeroDecolagem.TabIndex = 46;
            this.lblAeroDecolagem.Text = "Companhia Aerea:";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(17, 173);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(147, 22);
            this.label1lblCodigoPassagem.TabIndex = 45;
            this.label1lblCodigoPassagem.Text = "Código do Avião:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtQtdAcentos
            // 
            this.txtQtdAcentos.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtdAcentos.BorderColor = System.Drawing.Color.DimGray;
            this.txtQtdAcentos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtQtdAcentos.BorderSize = 1;
            this.txtQtdAcentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdAcentos.ForeColor = System.Drawing.Color.DimGray;
            this.txtQtdAcentos.Location = new System.Drawing.Point(238, 290);
            this.txtQtdAcentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdAcentos.Multiline = false;
            this.txtQtdAcentos.Name = "txtQtdAcentos";
            this.txtQtdAcentos.Padding = new System.Windows.Forms.Padding(7);
            this.txtQtdAcentos.PasswordChar = false;
            this.txtQtdAcentos.Size = new System.Drawing.Size(250, 31);
            this.txtQtdAcentos.TabIndex = 67;
            this.txtQtdAcentos.TextNew = "";
            this.txtQtdAcentos.UnderlinedStyle = false;
            // 
            // txtModelAviao
            // 
            this.txtModelAviao.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelAviao.BorderColor = System.Drawing.Color.DimGray;
            this.txtModelAviao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtModelAviao.BorderSize = 1;
            this.txtModelAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelAviao.ForeColor = System.Drawing.Color.DimGray;
            this.txtModelAviao.Location = new System.Drawing.Point(238, 251);
            this.txtModelAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelAviao.Multiline = false;
            this.txtModelAviao.Name = "txtModelAviao";
            this.txtModelAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtModelAviao.PasswordChar = false;
            this.txtModelAviao.Size = new System.Drawing.Size(250, 31);
            this.txtModelAviao.TabIndex = 66;
            this.txtModelAviao.TextNew = "";
            this.txtModelAviao.UnderlinedStyle = false;
            // 
            // txtCompAerea
            // 
            this.txtCompAerea.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompAerea.BorderColor = System.Drawing.Color.DimGray;
            this.txtCompAerea.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCompAerea.BorderSize = 1;
            this.txtCompAerea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompAerea.ForeColor = System.Drawing.Color.DimGray;
            this.txtCompAerea.Location = new System.Drawing.Point(238, 212);
            this.txtCompAerea.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompAerea.Multiline = false;
            this.txtCompAerea.Name = "txtCompAerea";
            this.txtCompAerea.Padding = new System.Windows.Forms.Padding(7);
            this.txtCompAerea.PasswordChar = false;
            this.txtCompAerea.Size = new System.Drawing.Size(250, 31);
            this.txtCompAerea.TabIndex = 65;
            this.txtCompAerea.TextNew = "";
            this.txtCompAerea.UnderlinedStyle = false;
            // 
            // txtCodAviao
            // 
            this.txtCodAviao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAviao.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAviao.BorderSize = 1;
            this.txtCodAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAviao.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.Location = new System.Drawing.Point(238, 173);
            this.txtCodAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAviao.Multiline = false;
            this.txtCodAviao.Name = "txtCodAviao";
            this.txtCodAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAviao.PasswordChar = false;
            this.txtCodAviao.Size = new System.Drawing.Size(250, 31);
            this.txtCodAviao.TabIndex = 64;
            this.txtCodAviao.TextNew = "";
            this.txtCodAviao.UnderlinedStyle = false;
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
            this.btnSair.Location = new System.Drawing.Point(338, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 55;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.Red;
            this.btnExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluir.BorderRadius = 20;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(177, 373);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.White;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalvar.BorderRadius = 20;
            this.btnSalvar.BorderSize = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(17, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "Voo:";
            // 
            // txtVoo
            // 
            this.txtVoo.BackColor = System.Drawing.SystemColors.Window;
            this.txtVoo.BorderColor = System.Drawing.Color.DimGray;
            this.txtVoo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVoo.BorderSize = 1;
            this.txtVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoo.ForeColor = System.Drawing.Color.DimGray;
            this.txtVoo.Location = new System.Drawing.Point(238, 329);
            this.txtVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoo.Multiline = false;
            this.txtVoo.Name = "txtVoo";
            this.txtVoo.Padding = new System.Windows.Forms.Padding(7);
            this.txtVoo.PasswordChar = false;
            this.txtVoo.Size = new System.Drawing.Size(250, 31);
            this.txtVoo.TabIndex = 69;
            this.txtVoo.TextNew = "";
            this.txtVoo.UnderlinedStyle = false;
            // 
            // FrmCadastroAviao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 439);
            this.Controls.Add(this.txtVoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdAcentos);
            this.Controls.Add(this.txtModelAviao);
            this.Controls.Add(this.txtCompAerea);
            this.Controls.Add(this.txtCodAviao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroAviao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAviao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.novoTextBox txtQtdAcentos;
        private controls.novoTextBox txtModelAviao;
        private controls.novoTextBox txtCompAerea;
        private controls.novoTextBox txtCodAviao;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox txtVoo;
    }
}
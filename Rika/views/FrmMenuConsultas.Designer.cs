namespace Rika.views
{
    partial class FrmMenuConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuConsultas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuConUsuario = new Rika.controls.MenuCategorias();
            this.menuConVoo = new Rika.controls.MenuCategorias();
            this.menuConEndereco = new Rika.controls.MenuCategorias();
            this.menuConTitulo = new Rika.controls.MenuCategorias();
            this.menuConTipoVenda = new Rika.controls.MenuCategorias();
            this.menuConSituacao = new Rika.controls.MenuCategorias();
            this.menuConPassagem = new Rika.controls.MenuCategorias();
            this.menuConPais = new Rika.controls.MenuCategorias();
            this.menuConCompAerea = new Rika.controls.MenuCategorias();
            this.menuConClasse = new Rika.controls.MenuCategorias();
            this.menuConAviao = new Rika.controls.MenuCategorias();
            this.menuConAeroporto = new Rika.controls.MenuCategorias();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(612, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // menuConUsuario
            // 
            this.menuConUsuario.BackColor = System.Drawing.Color.White;
            this.menuConUsuario.Imagem = global::Rika.Properties.Resources.menu_usuario;
            this.menuConUsuario.Informacao = "Consultar Usuários";
            this.menuConUsuario.Location = new System.Drawing.Point(924, 676);
            this.menuConUsuario.Name = "menuConUsuario";
            this.menuConUsuario.Size = new System.Drawing.Size(394, 127);
            this.menuConUsuario.TabIndex = 39;
            this.menuConUsuario.Titulo = "Consulta Usuário";
            this.menuConUsuario.Click += new System.EventHandler(this.menuConUsuario_Click);
            // 
            // menuConVoo
            // 
            this.menuConVoo.BackColor = System.Drawing.Color.White;
            this.menuConVoo.Imagem = global::Rika.Properties.Resources.voo_direto;
            this.menuConVoo.Informacao = "Consultar Voos";
            this.menuConVoo.Location = new System.Drawing.Point(498, 676);
            this.menuConVoo.Name = "menuConVoo";
            this.menuConVoo.Size = new System.Drawing.Size(394, 127);
            this.menuConVoo.TabIndex = 38;
            this.menuConVoo.Titulo = "Consulta Voo";
            this.menuConVoo.Click += new System.EventHandler(this.menuConVoo_Click);
            // 
            // menuConEndereco
            // 
            this.menuConEndereco.BackColor = System.Drawing.Color.White;
            this.menuConEndereco.Imagem = global::Rika.Properties.Resources.endereco;
            this.menuConEndereco.Informacao = "Consultar Endereços";
            this.menuConEndereco.Location = new System.Drawing.Point(66, 676);
            this.menuConEndereco.Name = "menuConEndereco";
            this.menuConEndereco.Size = new System.Drawing.Size(394, 127);
            this.menuConEndereco.TabIndex = 37;
            this.menuConEndereco.Titulo = "Consulta Endereço";
            this.menuConEndereco.Click += new System.EventHandler(this.menuConEndereco_Click);
            // 
            // menuConTitulo
            // 
            this.menuConTitulo.BackColor = System.Drawing.Color.White;
            this.menuConTitulo.Imagem = global::Rika.Properties.Resources.menu_titulos_fino1;
            this.menuConTitulo.Informacao = "Consultar Títulos";
            this.menuConTitulo.Location = new System.Drawing.Point(924, 526);
            this.menuConTitulo.Name = "menuConTitulo";
            this.menuConTitulo.Size = new System.Drawing.Size(394, 127);
            this.menuConTitulo.TabIndex = 36;
            this.menuConTitulo.Titulo = "Consulta Título";
            this.menuConTitulo.Click += new System.EventHandler(this.menuConTitulo_Click);
            // 
            // menuConTipoVenda
            // 
            this.menuConTipoVenda.BackColor = System.Drawing.Color.White;
            this.menuConTipoVenda.Imagem = global::Rika.Properties.Resources.menu_tipovenda;
            this.menuConTipoVenda.Informacao = "Consultar Tipos de Vendas";
            this.menuConTipoVenda.Location = new System.Drawing.Point(498, 526);
            this.menuConTipoVenda.Name = "menuConTipoVenda";
            this.menuConTipoVenda.Size = new System.Drawing.Size(394, 127);
            this.menuConTipoVenda.TabIndex = 35;
            this.menuConTipoVenda.Titulo = "Consulta Tipo de Venda";
            this.menuConTipoVenda.Click += new System.EventHandler(this.menuConTipoVenda_Click);
            // 
            // menuConSituacao
            // 
            this.menuConSituacao.BackColor = System.Drawing.Color.White;
            this.menuConSituacao.Imagem = global::Rika.Properties.Resources.menu_situacao;
            this.menuConSituacao.Informacao = "Consultar Situações";
            this.menuConSituacao.Location = new System.Drawing.Point(66, 526);
            this.menuConSituacao.Name = "menuConSituacao";
            this.menuConSituacao.Size = new System.Drawing.Size(394, 127);
            this.menuConSituacao.TabIndex = 34;
            this.menuConSituacao.Titulo = "Consulta Situação";
            this.menuConSituacao.Click += new System.EventHandler(this.menuConSituacao_Click);
            // 
            // menuConPassagem
            // 
            this.menuConPassagem.BackColor = System.Drawing.Color.White;
            this.menuConPassagem.Imagem = global::Rika.Properties.Resources.menu_passagem;
            this.menuConPassagem.Informacao = "Consultar Passagens";
            this.menuConPassagem.Location = new System.Drawing.Point(924, 376);
            this.menuConPassagem.Name = "menuConPassagem";
            this.menuConPassagem.Size = new System.Drawing.Size(394, 127);
            this.menuConPassagem.TabIndex = 33;
            this.menuConPassagem.Titulo = "Consulta Passagem";
            this.menuConPassagem.Click += new System.EventHandler(this.menuConPassagem_Click);
            // 
            // menuConPais
            // 
            this.menuConPais.BackColor = System.Drawing.Color.White;
            this.menuConPais.Imagem = global::Rika.Properties.Resources.menu_pais;
            this.menuConPais.Informacao = "Consultar Países";
            this.menuConPais.Location = new System.Drawing.Point(498, 376);
            this.menuConPais.Name = "menuConPais";
            this.menuConPais.Size = new System.Drawing.Size(394, 127);
            this.menuConPais.TabIndex = 32;
            this.menuConPais.Titulo = "Consulta País";
            this.menuConPais.Click += new System.EventHandler(this.menuConPais_Click);
            // 
            // menuConCompAerea
            // 
            this.menuConCompAerea.BackColor = System.Drawing.Color.White;
            this.menuConCompAerea.Imagem = global::Rika.Properties.Resources.menu_compaerea;
            this.menuConCompAerea.Informacao = "Consultar Companhias Aéreas";
            this.menuConCompAerea.Location = new System.Drawing.Point(66, 376);
            this.menuConCompAerea.Name = "menuConCompAerea";
            this.menuConCompAerea.Size = new System.Drawing.Size(394, 127);
            this.menuConCompAerea.TabIndex = 31;
            this.menuConCompAerea.Titulo = "Consulta Companhia Aérea";
            this.menuConCompAerea.Click += new System.EventHandler(this.menuConCompAerea_Click);
            // 
            // menuConClasse
            // 
            this.menuConClasse.BackColor = System.Drawing.Color.White;
            this.menuConClasse.Imagem = global::Rika.Properties.Resources.menu_classe_fina1;
            this.menuConClasse.Informacao = "Consultar Classes";
            this.menuConClasse.Location = new System.Drawing.Point(924, 224);
            this.menuConClasse.Name = "menuConClasse";
            this.menuConClasse.Size = new System.Drawing.Size(394, 127);
            this.menuConClasse.TabIndex = 30;
            this.menuConClasse.Titulo = "Consulta Classe";
            this.menuConClasse.Click += new System.EventHandler(this.menuConClasse_Click);
            // 
            // menuConAviao
            // 
            this.menuConAviao.BackColor = System.Drawing.Color.White;
            this.menuConAviao.Imagem = global::Rika.Properties.Resources.menu_aviao;
            this.menuConAviao.Informacao = "Consultar Aviões";
            this.menuConAviao.Location = new System.Drawing.Point(498, 224);
            this.menuConAviao.Name = "menuConAviao";
            this.menuConAviao.Size = new System.Drawing.Size(394, 127);
            this.menuConAviao.TabIndex = 29;
            this.menuConAviao.Titulo = "Consulta Avião";
            this.menuConAviao.Click += new System.EventHandler(this.menuConAviao_Click);
            // 
            // menuConAeroporto
            // 
            this.menuConAeroporto.BackColor = System.Drawing.Color.White;
            this.menuConAeroporto.Imagem = global::Rika.Properties.Resources.menu_aeroporto;
            this.menuConAeroporto.Informacao = "Consultar Aeroportos";
            this.menuConAeroporto.Location = new System.Drawing.Point(66, 224);
            this.menuConAeroporto.Name = "menuConAeroporto";
            this.menuConAeroporto.Size = new System.Drawing.Size(394, 127);
            this.menuConAeroporto.TabIndex = 28;
            this.menuConAeroporto.Titulo = "Consulta Aeroporto";
            this.menuConAeroporto.Click += new System.EventHandler(this.menuConAeroporto_Click);
            // 
            // FrmMenuConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 669);
            this.Controls.Add(this.menuConUsuario);
            this.Controls.Add(this.menuConVoo);
            this.Controls.Add(this.menuConEndereco);
            this.Controls.Add(this.menuConTitulo);
            this.Controls.Add(this.menuConTipoVenda);
            this.Controls.Add(this.menuConSituacao);
            this.Controls.Add(this.menuConPassagem);
            this.Controls.Add(this.menuConPais);
            this.Controls.Add(this.menuConCompAerea);
            this.Controls.Add(this.menuConClasse);
            this.Controls.Add(this.menuConAviao);
            this.Controls.Add(this.menuConAeroporto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MenuCategorias menuConUsuario;
        private controls.MenuCategorias menuConVoo;
        private controls.MenuCategorias menuConEndereco;
        private controls.MenuCategorias menuConTitulo;
        private controls.MenuCategorias menuConTipoVenda;
        private controls.MenuCategorias menuConSituacao;
        private controls.MenuCategorias menuConPassagem;
        private controls.MenuCategorias menuConPais;
        private controls.MenuCategorias menuConCompAerea;
        private controls.MenuCategorias menuConClasse;
        private controls.MenuCategorias menuConAviao;
        private controls.MenuCategorias menuConAeroporto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
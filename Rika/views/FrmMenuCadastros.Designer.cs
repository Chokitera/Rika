namespace Rika.views
{
    partial class FrmMenuCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCadastros));
            this.menuCadTitulo = new Rika.controls.MenuCategorias();
            this.menuCadTipoVenda = new Rika.controls.MenuCategorias();
            this.menuCadSituacao = new Rika.controls.MenuCategorias();
            this.menuCadPassagem = new Rika.controls.MenuCategorias();
            this.menuCadPais = new Rika.controls.MenuCategorias();
            this.menuCadCompAerea = new Rika.controls.MenuCategorias();
            this.menuCadClasse = new Rika.controls.MenuCategorias();
            this.menuCadAviao = new Rika.controls.MenuCategorias();
            this.menuCadAeroporto = new Rika.controls.MenuCategorias();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuCadTitulo
            // 
            this.menuCadTitulo.BackColor = System.Drawing.Color.White;
            this.menuCadTitulo.Imagem = global::Rika.Properties.Resources.menu_titulos;
            this.menuCadTitulo.Informacao = "Cadastrar Títulos";
            this.menuCadTitulo.Location = new System.Drawing.Point(923, 519);
            this.menuCadTitulo.Name = "menuCadTitulo";
            this.menuCadTitulo.Size = new System.Drawing.Size(394, 127);
            this.menuCadTitulo.TabIndex = 20;
            this.menuCadTitulo.Titulo = "Cadastro Título";
            this.menuCadTitulo.Click += new System.EventHandler(this.menuCadTitulo_Click);
            // 
            // menuCadTipoVenda
            // 
            this.menuCadTipoVenda.BackColor = System.Drawing.Color.White;
            this.menuCadTipoVenda.Imagem = global::Rika.Properties.Resources.menu_tipovenda;
            this.menuCadTipoVenda.Informacao = "Cadastrar Tipos de Vendas";
            this.menuCadTipoVenda.Location = new System.Drawing.Point(497, 519);
            this.menuCadTipoVenda.Name = "menuCadTipoVenda";
            this.menuCadTipoVenda.Size = new System.Drawing.Size(394, 127);
            this.menuCadTipoVenda.TabIndex = 19;
            this.menuCadTipoVenda.Titulo = "Cadastro Tipo de Venda";
            this.menuCadTipoVenda.Click += new System.EventHandler(this.menuCadTipoVenda_Click);
            // 
            // menuCadSituacao
            // 
            this.menuCadSituacao.BackColor = System.Drawing.Color.White;
            this.menuCadSituacao.Imagem = global::Rika.Properties.Resources.menu_situacao;
            this.menuCadSituacao.Informacao = "Cadastrar Situações";
            this.menuCadSituacao.Location = new System.Drawing.Point(65, 519);
            this.menuCadSituacao.Name = "menuCadSituacao";
            this.menuCadSituacao.Size = new System.Drawing.Size(394, 127);
            this.menuCadSituacao.TabIndex = 18;
            this.menuCadSituacao.Titulo = "Cadastro Situação";
            this.menuCadSituacao.Click += new System.EventHandler(this.menuCadSituacao_Click);
            // 
            // menuCadPassagem
            // 
            this.menuCadPassagem.BackColor = System.Drawing.Color.White;
            this.menuCadPassagem.Imagem = global::Rika.Properties.Resources.menu_passagem;
            this.menuCadPassagem.Informacao = "Cadastrar Passagens";
            this.menuCadPassagem.Location = new System.Drawing.Point(923, 369);
            this.menuCadPassagem.Name = "menuCadPassagem";
            this.menuCadPassagem.Size = new System.Drawing.Size(394, 127);
            this.menuCadPassagem.TabIndex = 17;
            this.menuCadPassagem.Titulo = "Cadastro Passagem";
            this.menuCadPassagem.Click += new System.EventHandler(this.menuCadPassagem_Click);
            // 
            // menuCadPais
            // 
            this.menuCadPais.BackColor = System.Drawing.Color.White;
            this.menuCadPais.Imagem = global::Rika.Properties.Resources.menu_pais;
            this.menuCadPais.Informacao = "Cadastrar Países";
            this.menuCadPais.Location = new System.Drawing.Point(497, 369);
            this.menuCadPais.Name = "menuCadPais";
            this.menuCadPais.Size = new System.Drawing.Size(394, 127);
            this.menuCadPais.TabIndex = 16;
            this.menuCadPais.Titulo = "Cadastro País";
            this.menuCadPais.Click += new System.EventHandler(this.menuCadPais_Click);
            // 
            // menuCadCompAerea
            // 
            this.menuCadCompAerea.BackColor = System.Drawing.Color.White;
            this.menuCadCompAerea.Imagem = global::Rika.Properties.Resources.menu_compaerea;
            this.menuCadCompAerea.Informacao = "Cadastrar Companhias Aéreas";
            this.menuCadCompAerea.Location = new System.Drawing.Point(65, 369);
            this.menuCadCompAerea.Name = "menuCadCompAerea";
            this.menuCadCompAerea.Size = new System.Drawing.Size(394, 127);
            this.menuCadCompAerea.TabIndex = 15;
            this.menuCadCompAerea.Titulo = "Cadastro Companhia Aérea";
            this.menuCadCompAerea.Click += new System.EventHandler(this.menuCadCompAerea_Click);
            // 
            // menuCadClasse
            // 
            this.menuCadClasse.BackColor = System.Drawing.Color.White;
            this.menuCadClasse.Imagem = global::Rika.Properties.Resources.menu_classe;
            this.menuCadClasse.Informacao = "Cadastrar Classes";
            this.menuCadClasse.Location = new System.Drawing.Point(923, 217);
            this.menuCadClasse.Name = "menuCadClasse";
            this.menuCadClasse.Size = new System.Drawing.Size(394, 127);
            this.menuCadClasse.TabIndex = 14;
            this.menuCadClasse.Titulo = "Cadastro Classe";
            this.menuCadClasse.Click += new System.EventHandler(this.menuCadClasse_Click);
            // 
            // menuCadAviao
            // 
            this.menuCadAviao.BackColor = System.Drawing.Color.White;
            this.menuCadAviao.Imagem = global::Rika.Properties.Resources.menu_aviao;
            this.menuCadAviao.Informacao = "Cadastrar Aviões";
            this.menuCadAviao.Location = new System.Drawing.Point(497, 217);
            this.menuCadAviao.Name = "menuCadAviao";
            this.menuCadAviao.Size = new System.Drawing.Size(394, 127);
            this.menuCadAviao.TabIndex = 13;
            this.menuCadAviao.Titulo = "Cadastro Avião";
            this.menuCadAviao.Click += new System.EventHandler(this.menuCadAviao_Click);
            // 
            // menuCadAeroporto
            // 
            this.menuCadAeroporto.BackColor = System.Drawing.Color.White;
            this.menuCadAeroporto.Imagem = global::Rika.Properties.Resources.menu_aeroporto;
            this.menuCadAeroporto.Informacao = "Cadastrar Aeroportos";
            this.menuCadAeroporto.Location = new System.Drawing.Point(65, 217);
            this.menuCadAeroporto.Name = "menuCadAeroporto";
            this.menuCadAeroporto.Size = new System.Drawing.Size(394, 127);
            this.menuCadAeroporto.TabIndex = 12;
            this.menuCadAeroporto.Titulo = "Cadastro Aeroporto";
            this.menuCadAeroporto.Click += new System.EventHandler(this.menuCadAeroporto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(611, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 669);
            this.Controls.Add(this.menuCadTitulo);
            this.Controls.Add(this.menuCadTipoVenda);
            this.Controls.Add(this.menuCadSituacao);
            this.Controls.Add(this.menuCadPassagem);
            this.Controls.Add(this.menuCadPais);
            this.Controls.Add(this.menuCadCompAerea);
            this.Controls.Add(this.menuCadClasse);
            this.Controls.Add(this.menuCadAviao);
            this.Controls.Add(this.menuCadAeroporto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Cadastros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.MenuCategorias menuCadTitulo;
        private controls.MenuCategorias menuCadTipoVenda;
        private controls.MenuCategorias menuCadSituacao;
        private controls.MenuCategorias menuCadPassagem;
        private controls.MenuCategorias menuCadPais;
        private controls.MenuCategorias menuCadCompAerea;
        private controls.MenuCategorias menuCadClasse;
        private controls.MenuCategorias menuCadAviao;
        private controls.MenuCategorias menuCadAeroporto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
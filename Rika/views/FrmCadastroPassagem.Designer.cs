namespace Rika.views
{
    partial class FrmCadastroPassagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroPassagem));
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.lblVoo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlArrastarFormulario = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirPasta = new System.Windows.Forms.Button();
            this.btnVisualizarImagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSituacao = new Rika.controls.novosComboBox();
            this.txtVoo = new Rika.controls.novoTextBoxReadOnly();
            this.txtClasse = new Rika.controls.novoTextBoxReadOnly();
            this.cmbTipoPassagem = new Rika.controls.novosComboBox();
            this.txtImagem = new Rika.controls.novoTextBoxReadOnly();
            this.txtValor = new Rika.controls.novoTextBox();
            this.txtCodClasse = new Rika.controls.novoTextBox();
            this.txtCodVoo = new Rika.controls.novoTextBox();
            this.txtCodigo = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.pnlArrastarFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(29, 256);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 1;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // lblVoo
            // 
            this.lblVoo.AutoSize = true;
            this.lblVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoo.Location = new System.Drawing.Point(621, 298);
            this.lblVoo.Name = "lblVoo";
            this.lblVoo.Size = new System.Drawing.Size(42, 22);
            this.lblVoo.TabIndex = 8;
            this.lblVoo.Text = "Voo";
            this.lblVoo.Click += new System.EventHandler(this.lblVoo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Classe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Direto ou Escala";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Imagem Destaque";
            // 
            // pnlArrastarFormulario
            // 
            this.pnlArrastarFormulario.Controls.Add(this.iconFechar);
            this.pnlArrastarFormulario.Controls.Add(this.iconMinimizar);
            this.pnlArrastarFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArrastarFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlArrastarFormulario.Name = "pnlArrastarFormulario";
            this.pnlArrastarFormulario.Size = new System.Drawing.Size(1094, 24);
            this.pnlArrastarFormulario.TabIndex = 23;
            this.pnlArrastarFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArrastarFormulario_MouseDown);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(1062, 4);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 30;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Rika.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(1036, 4);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 31;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Situação";
            // 
            // btnAbrirPasta
            // 
            this.btnAbrirPasta.BackgroundImage = global::Rika.Properties.Resources.pasta_128px;
            this.btnAbrirPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirPasta.FlatAppearance.BorderSize = 0;
            this.btnAbrirPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPasta.Location = new System.Drawing.Point(527, 369);
            this.btnAbrirPasta.Name = "btnAbrirPasta";
            this.btnAbrirPasta.Size = new System.Drawing.Size(30, 31);
            this.btnAbrirPasta.TabIndex = 46;
            this.btnAbrirPasta.UseVisualStyleBackColor = true;
            this.btnAbrirPasta.Click += new System.EventHandler(this.btnAbrirPasta_Click);
            // 
            // btnVisualizarImagem
            // 
            this.btnVisualizarImagem.BackgroundImage = global::Rika.Properties.Resources.imagem_128px;
            this.btnVisualizarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizarImagem.FlatAppearance.BorderSize = 0;
            this.btnVisualizarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarImagem.Location = new System.Drawing.Point(492, 370);
            this.btnVisualizarImagem.Name = "btnVisualizarImagem";
            this.btnVisualizarImagem.Size = new System.Drawing.Size(30, 31);
            this.btnVisualizarImagem.TabIndex = 45;
            this.btnVisualizarImagem.UseVisualStyleBackColor = true;
            this.btnVisualizarImagem.Click += new System.EventHandler(this.btnVisualizarImagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(469, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.BackColor = System.Drawing.Color.White;
            this.cmbSituacao.BorderColor = System.Drawing.Color.DimGray;
            this.cmbSituacao.BorderSize = 1;
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSituacao.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSituacao.IconColor = System.Drawing.Color.DimGray;
            this.cmbSituacao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSituacao.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSituacao.Location = new System.Drawing.Point(715, 253);
            this.cmbSituacao.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Padding = new System.Windows.Forms.Padding(1);
            this.cmbSituacao.Size = new System.Drawing.Size(250, 30);
            this.cmbSituacao.TabIndex = 89;
            this.cmbSituacao.Texts = "";
            // 
            // txtVoo
            // 
            this.txtVoo.BackColor = System.Drawing.SystemColors.Window;
            this.txtVoo.BorderColor = System.Drawing.Color.DimGray;
            this.txtVoo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVoo.BorderSize = 1;
            this.txtVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoo.ForeColor = System.Drawing.Color.DimGray;
            this.txtVoo.Location = new System.Drawing.Point(813, 290);
            this.txtVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoo.Multiline = false;
            this.txtVoo.Name = "txtVoo";
            this.txtVoo.Padding = new System.Windows.Forms.Padding(7);
            this.txtVoo.PasswordChar = false;
            this.txtVoo.ReadOnly = true;
            this.txtVoo.Size = new System.Drawing.Size(250, 31);
            this.txtVoo.TabIndex = 87;
            this.txtVoo.TextNew = "";
            this.txtVoo.UnderlinedStyle = false;
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.SystemColors.Window;
            this.txtClasse.BorderColor = System.Drawing.Color.DimGray;
            this.txtClasse.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtClasse.BorderSize = 1;
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasse.ForeColor = System.Drawing.Color.DimGray;
            this.txtClasse.Location = new System.Drawing.Point(308, 329);
            this.txtClasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtClasse.Multiline = false;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Padding = new System.Windows.Forms.Padding(7);
            this.txtClasse.PasswordChar = false;
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(250, 31);
            this.txtClasse.TabIndex = 84;
            this.txtClasse.TextNew = "";
            this.txtClasse.UnderlinedStyle = false;
            // 
            // cmbTipoPassagem
            // 
            this.cmbTipoPassagem.BackColor = System.Drawing.Color.White;
            this.cmbTipoPassagem.BorderColor = System.Drawing.Color.DimGray;
            this.cmbTipoPassagem.BorderSize = 1;
            this.cmbTipoPassagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTipoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipoPassagem.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoPassagem.IconColor = System.Drawing.Color.DimGray;
            this.cmbTipoPassagem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoPassagem.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoPassagem.Location = new System.Drawing.Point(210, 290);
            this.cmbTipoPassagem.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipoPassagem.Name = "cmbTipoPassagem";
            this.cmbTipoPassagem.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoPassagem.Size = new System.Drawing.Size(250, 30);
            this.cmbTipoPassagem.TabIndex = 83;
            this.cmbTipoPassagem.Texts = "";
            // 
            // txtImagem
            // 
            this.txtImagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtImagem.BorderColor = System.Drawing.Color.DimGray;
            this.txtImagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtImagem.BorderSize = 1;
            this.txtImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtImagem.Location = new System.Drawing.Point(210, 368);
            this.txtImagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagem.Multiline = false;
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtImagem.PasswordChar = false;
            this.txtImagem.ReadOnly = true;
            this.txtImagem.Size = new System.Drawing.Size(275, 31);
            this.txtImagem.TabIndex = 47;
            this.txtImagem.TextNew = "";
            this.txtImagem.UnderlinedStyle = false;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.BorderColor = System.Drawing.Color.DimGray;
            this.txtValor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValor.BorderSize = 1;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.Location = new System.Drawing.Point(715, 329);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Padding = new System.Windows.Forms.Padding(7);
            this.txtValor.PasswordChar = false;
            this.txtValor.Size = new System.Drawing.Size(90, 31);
            this.txtValor.TabIndex = 39;
            this.txtValor.TextNew = "";
            this.txtValor.UnderlinedStyle = false;
            // 
            // txtCodClasse
            // 
            this.txtCodClasse.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodClasse.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodClasse.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodClasse.BorderSize = 1;
            this.txtCodClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodClasse.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodClasse.Location = new System.Drawing.Point(210, 329);
            this.txtCodClasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodClasse.Multiline = false;
            this.txtCodClasse.Name = "txtCodClasse";
            this.txtCodClasse.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodClasse.PasswordChar = false;
            this.txtCodClasse.Size = new System.Drawing.Size(90, 31);
            this.txtCodClasse.TabIndex = 37;
            this.txtCodClasse.TextNew = "";
            this.txtCodClasse.UnderlinedStyle = false;
            // 
            // txtCodVoo
            // 
            this.txtCodVoo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodVoo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodVoo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodVoo.BorderSize = 1;
            this.txtCodVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVoo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodVoo.Location = new System.Drawing.Point(715, 290);
            this.txtCodVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVoo.Multiline = false;
            this.txtCodVoo.Name = "txtCodVoo";
            this.txtCodVoo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodVoo.PasswordChar = false;
            this.txtCodVoo.Size = new System.Drawing.Size(90, 31);
            this.txtCodVoo.TabIndex = 33;
            this.txtCodVoo.TextNew = "";
            this.txtCodVoo.UnderlinedStyle = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(210, 252);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.Size = new System.Drawing.Size(90, 31);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.TextNew = "";
            this.txtCodigo.UnderlinedStyle = false;
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
            this.btnSair.Location = new System.Drawing.Point(635, 454);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 14;
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
            this.btnExcluir.Location = new System.Drawing.Point(474, 454);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 13;
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
            this.btnSalvar.Location = new System.Drawing.Point(314, 454);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroPassagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 521);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.txtVoo);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.cmbTipoPassagem);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.btnVisualizarImagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodClasse);
            this.Controls.Add(this.txtCodVoo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pnlArrastarFormulario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblVoo);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroPassagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Passagens";
            this.Load += new System.EventHandler(this.FrmTelaAdministrativa_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTelaAdministrativa_Paint);
            this.pnlArrastarFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.Label lblVoo;
        private controls.ModeloBotao btnSalvar;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlArrastarFormulario;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private controls.novoTextBox txtCodigo;
        private controls.novoTextBox txtValor;
        private controls.novoTextBox txtCodClasse;
        private controls.novoTextBox txtCodVoo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizarImagem;
        private System.Windows.Forms.Button btnAbrirPasta;
        private controls.novoTextBoxReadOnly txtImagem;
        private controls.novosComboBox cmbTipoPassagem;
        private controls.novoTextBoxReadOnly txtClasse;
        private controls.novoTextBoxReadOnly txtVoo;
        private controls.novosComboBox cmbSituacao;
    }
}
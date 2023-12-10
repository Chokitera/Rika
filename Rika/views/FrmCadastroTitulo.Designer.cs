namespace Rika.views
{
    partial class FrmCadastroTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTitulo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.lblAeroDecolagem = new System.Windows.Forms.Label();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTipoVenda = new Rika.controls.novoTextBoxReadOnly();
            this.txtValor = new Rika.controls.novoTextBox();
            this.txtCodTipoVenda = new Rika.controls.novoTextBox();
            this.txtCodTitulo = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.txtPassagem = new Rika.controls.novoTextBoxReadOnly();
            this.txtCodPassagem = new Rika.controls.novoTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 30);
            this.panel2.TabIndex = 101;
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(511, 6);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 28;
            this.iconFechar.TabStop = false;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Rika.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(485, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(27, 359);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(52, 22);
            this.lblAeroDestino.TabIndex = 99;
            this.lblAeroDestino.Text = "Valor";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(27, 317);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(128, 22);
            this.lblAeroDecolagem.TabIndex = 98;
            this.lblAeroDecolagem.Text = "Tipo de Venda";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(27, 239);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 97;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(185, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // txtTipoVenda
            // 
            this.txtTipoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoVenda.BorderColor = System.Drawing.Color.DimGray;
            this.txtTipoVenda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipoVenda.BorderSize = 1;
            this.txtTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVenda.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipoVenda.Location = new System.Drawing.Point(263, 315);
            this.txtTipoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoVenda.Multiline = false;
            this.txtTipoVenda.Name = "txtTipoVenda";
            this.txtTipoVenda.Padding = new System.Windows.Forms.Padding(7);
            this.txtTipoVenda.PasswordChar = false;
            this.txtTipoVenda.ReadOnly = true;
            this.txtTipoVenda.Size = new System.Drawing.Size(250, 31);
            this.txtTipoVenda.TabIndex = 102;
            this.txtTipoVenda.TabStop = false;
            this.txtTipoVenda.TextNew = "";
            this.txtTipoVenda.UnderlinedStyle = false;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.BorderColor = System.Drawing.Color.DimGray;
            this.txtValor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValor.BorderSize = 1;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.DimGray;
            this.txtValor.Location = new System.Drawing.Point(165, 354);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Padding = new System.Windows.Forms.Padding(7);
            this.txtValor.PasswordChar = false;
            this.txtValor.Size = new System.Drawing.Size(90, 31);
            this.txtValor.TabIndex = 90;
            this.txtValor.TextNew = "";
            this.txtValor.UnderlinedStyle = false;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTitulo_KeyPress);
            // 
            // txtCodTipoVenda
            // 
            this.txtCodTipoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodTipoVenda.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodTipoVenda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodTipoVenda.BorderSize = 1;
            this.txtCodTipoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTipoVenda.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodTipoVenda.Location = new System.Drawing.Point(165, 315);
            this.txtCodTipoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodTipoVenda.Multiline = false;
            this.txtCodTipoVenda.Name = "txtCodTipoVenda";
            this.txtCodTipoVenda.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodTipoVenda.PasswordChar = false;
            this.txtCodTipoVenda.Size = new System.Drawing.Size(90, 31);
            this.txtCodTipoVenda.TabIndex = 92;
            this.txtCodTipoVenda.TextNew = "";
            this.txtCodTipoVenda.UnderlinedStyle = false;
            this.txtCodTipoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTitulo_KeyPress);
            this.txtCodTipoVenda.Leave += new System.EventHandler(this.txtCodTipoVenda_Leave);
            // 
            // txtCodTitulo
            // 
            this.txtCodTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodTitulo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodTitulo.BorderSize = 1;
            this.txtCodTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodTitulo.Location = new System.Drawing.Point(165, 237);
            this.txtCodTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodTitulo.Multiline = false;
            this.txtCodTitulo.Name = "txtCodTitulo";
            this.txtCodTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodTitulo.PasswordChar = false;
            this.txtCodTitulo.Size = new System.Drawing.Size(90, 31);
            this.txtCodTitulo.TabIndex = 89;
            this.txtCodTitulo.TextNew = "";
            this.txtCodTitulo.UnderlinedStyle = false;
            this.txtCodTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTitulo_KeyPress);
            this.txtCodTitulo.Leave += new System.EventHandler(this.txtCodTitulo_Leave);
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
            this.btnSair.Location = new System.Drawing.Point(358, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 95;
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
            this.btnExcluir.Location = new System.Drawing.Point(197, 417);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 94;
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
            this.btnSalvar.Location = new System.Drawing.Point(37, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 93;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPassagem
            // 
            this.txtPassagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassagem.BorderColor = System.Drawing.Color.DimGray;
            this.txtPassagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassagem.BorderSize = 1;
            this.txtPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassagem.Location = new System.Drawing.Point(263, 276);
            this.txtPassagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassagem.Multiline = false;
            this.txtPassagem.Name = "txtPassagem";
            this.txtPassagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassagem.PasswordChar = false;
            this.txtPassagem.ReadOnly = true;
            this.txtPassagem.Size = new System.Drawing.Size(250, 31);
            this.txtPassagem.TabIndex = 104;
            this.txtPassagem.TabStop = false;
            this.txtPassagem.TextNew = "";
            this.txtPassagem.UnderlinedStyle = false;
            // 
            // txtCodPassagem
            // 
            this.txtCodPassagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodPassagem.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodPassagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodPassagem.BorderSize = 1;
            this.txtCodPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPassagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodPassagem.Location = new System.Drawing.Point(165, 276);
            this.txtCodPassagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPassagem.Multiline = false;
            this.txtCodPassagem.Name = "txtCodPassagem";
            this.txtCodPassagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodPassagem.PasswordChar = false;
            this.txtCodPassagem.Size = new System.Drawing.Size(90, 31);
            this.txtCodPassagem.TabIndex = 103;
            this.txtCodPassagem.TextNew = "";
            this.txtCodPassagem.UnderlinedStyle = false;
            this.txtCodPassagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodTitulo_KeyPress);
            this.txtCodPassagem.Leave += new System.EventHandler(this.txtCodPassagem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 105;
            this.label1.Text = "Passagem";
            // 
            // txtStatus
            // 
            this.txtStatus.AccessibleName = "";
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(403, 42);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(110, 22);
            this.txtStatus.TabIndex = 106;
            this.txtStatus.Text = "Pago/Aberto";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmCadastroTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 478);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassagem);
            this.Controls.Add(this.txtCodPassagem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTipoVenda);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCodTipoVenda);
            this.Controls.Add(this.txtCodTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Títulos";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.novoTextBoxReadOnly txtTipoVenda;
        private controls.novoTextBox txtValor;
        private controls.novoTextBox txtCodTipoVenda;
        private controls.novoTextBox txtCodTitulo;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private controls.novoTextBoxReadOnly txtPassagem;
        private controls.novoTextBox txtCodPassagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStatus;
    }
}
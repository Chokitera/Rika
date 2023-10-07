namespace Rika.views
{
    partial class FrmConsultaUsuario
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
            this.lblAeroDecolagem = new System.Windows.Forms.Label();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new Rika.controls.novosComboBox();
            this.txtSenha = new Rika.controls.novoTextBox();
            this.txtNome = new Rika.controls.novoTextBox();
            this.txtCodUsuario = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlArrastarFormulario = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.txtNomeUsuario = new Rika.controls.novoTextBoxReadOnly();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlArrastarFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(66, 322);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(149, 22);
            this.lblDataSaida.TabIndex = 72;
            this.lblDataSaida.Text = "Nome de Usuário";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(66, 244);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(57, 22);
            this.lblAeroDecolagem.TabIndex = 70;
            this.lblAeroDecolagem.Text = "Nome";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(66, 205);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 69;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Senha";
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(66, 283);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(113, 22);
            this.lblAeroDestino.TabIndex = 71;
            this.lblAeroDestino.Text = "Tipo Usuário";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.cmbTipoUsuario.BorderSize = 1;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoUsuario.IconColor = System.Drawing.Color.DimGray;
            this.cmbTipoUsuario.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoUsuario.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(238, 283);
            this.cmbTipoUsuario.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoUsuario.Size = new System.Drawing.Size(250, 30);
            this.cmbTipoUsuario.TabIndex = 82;
            this.cmbTipoUsuario.Texts = "";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.DimGray;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha.BorderSize = 1;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(238, 362);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(7);
            this.txtSenha.PasswordChar = false;
            this.txtSenha.Size = new System.Drawing.Size(250, 31);
            this.txtSenha.TabIndex = 81;
            this.txtSenha.TextNew = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(238, 244);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 77;
            this.txtNome.TextNew = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodUsuario.BorderSize = 1;
            this.txtCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodUsuario.Location = new System.Drawing.Point(238, 205);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodUsuario.Multiline = false;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodUsuario.PasswordChar = false;
            this.txtCodUsuario.Size = new System.Drawing.Size(90, 31);
            this.txtCodUsuario.TabIndex = 76;
            this.txtCodUsuario.TextNew = "";
            this.txtCodUsuario.UnderlinedStyle = false;
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
            this.btnSair.Location = new System.Drawing.Point(364, 431);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 75;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
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
            this.btnExcluir.Location = new System.Drawing.Point(203, 431);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 74;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.White;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
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
            this.btnSalvar.Location = new System.Drawing.Point(43, 431);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 73;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox2.Location = new System.Drawing.Point(190, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // pnlArrastarFormulario
            // 
            this.pnlArrastarFormulario.Controls.Add(this.iconFechar);
            this.pnlArrastarFormulario.Controls.Add(this.iconMinimizar);
            this.pnlArrastarFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArrastarFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlArrastarFormulario.Name = "pnlArrastarFormulario";
            this.pnlArrastarFormulario.Size = new System.Drawing.Size(556, 24);
            this.pnlArrastarFormulario.TabIndex = 90;
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(524, 4);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 30;
            this.iconFechar.TabStop = false;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Rika.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(498, 4);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 31;
            this.iconMinimizar.TabStop = false;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomeUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNomeUsuario.BorderSize = 1;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeUsuario.Location = new System.Drawing.Point(238, 321);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.Multiline = false;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtNomeUsuario.PasswordChar = false;
            this.txtNomeUsuario.ReadOnly = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(250, 31);
            this.txtNomeUsuario.TabIndex = 88;
            this.txtNomeUsuario.TextNew = "";
            this.txtNomeUsuario.UnderlinedStyle = false;
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 493);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.pnlArrastarFormulario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaUsuario";
            this.Text = "FrmConsultaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlArrastarFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.novoTextBox txtNome;
        private controls.novoTextBox txtCodUsuario;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private controls.novoTextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAeroDestino;
        private controls.novosComboBox cmbTipoUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlArrastarFormulario;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private controls.novoTextBoxReadOnly txtNomeUsuario;
    }
}
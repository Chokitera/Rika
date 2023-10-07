namespace Rika.views
{
    partial class FrmCadastroAeroporto
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
            this.txtDescricao = new Rika.controls.novoTextBox();
            this.txtNome = new Rika.controls.novoTextBox();
            this.txtCodEndereco = new Rika.controls.novoTextBox();
            this.txtCodAeroporto = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.txtEndereco = new Rika.controls.novoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(29, 315);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(90, 22);
            this.lblDataSaida.TabIndex = 49;
            this.lblDataSaida.Text = "Descrição";
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(29, 276);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(57, 22);
            this.lblAeroDestino.TabIndex = 47;
            this.lblAeroDestino.Text = "Nome";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(29, 354);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(87, 22);
            this.lblAeroDecolagem.TabIndex = 46;
            this.lblAeroDecolagem.Text = "Endereço";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(29, 237);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 45;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(180, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescricao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescricao.BorderSize = 1;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescricao.Location = new System.Drawing.Point(154, 315);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescricao.PasswordChar = false;
            this.txtDescricao.Size = new System.Drawing.Size(348, 31);
            this.txtDescricao.TabIndex = 67;
            this.txtDescricao.TextNew = "";
            this.txtDescricao.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(154, 276);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(348, 31);
            this.txtNome.TabIndex = 66;
            this.txtNome.TextNew = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtCodEndereco
            // 
            this.txtCodEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodEndereco.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodEndereco.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodEndereco.BorderSize = 1;
            this.txtCodEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEndereco.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodEndereco.Location = new System.Drawing.Point(154, 354);
            this.txtCodEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodEndereco.Multiline = false;
            this.txtCodEndereco.Name = "txtCodEndereco";
            this.txtCodEndereco.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodEndereco.PasswordChar = false;
            this.txtCodEndereco.Size = new System.Drawing.Size(90, 31);
            this.txtCodEndereco.TabIndex = 65;
            this.txtCodEndereco.TextNew = "";
            this.txtCodEndereco.UnderlinedStyle = false;
            // 
            // txtCodAeroporto
            // 
            this.txtCodAeroporto.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAeroporto.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAeroporto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAeroporto.BorderSize = 1;
            this.txtCodAeroporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAeroporto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAeroporto.Location = new System.Drawing.Point(154, 237);
            this.txtCodAeroporto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAeroporto.Multiline = false;
            this.txtCodAeroporto.Name = "txtCodAeroporto";
            this.txtCodAeroporto.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAeroporto.PasswordChar = false;
            this.txtCodAeroporto.Size = new System.Drawing.Size(90, 31);
            this.txtCodAeroporto.TabIndex = 64;
            this.txtCodAeroporto.TextNew = "";
            this.txtCodAeroporto.UnderlinedStyle = false;
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
            this.btnSair.Location = new System.Drawing.Point(353, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 55;
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
            this.btnExcluir.Location = new System.Drawing.Point(192, 417);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 54;
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
            this.btnSalvar.Location = new System.Drawing.Point(32, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 30);
            this.panel2.TabIndex = 68;
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(503, 6);
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
            this.iconMinimizar.Location = new System.Drawing.Point(477, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.BorderColor = System.Drawing.Color.DimGray;
            this.txtEndereco.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEndereco.BorderSize = 1;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.DimGray;
            this.txtEndereco.Location = new System.Drawing.Point(252, 354);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Padding = new System.Windows.Forms.Padding(7);
            this.txtEndereco.PasswordChar = false;
            this.txtEndereco.Size = new System.Drawing.Size(250, 31);
            this.txtEndereco.TabIndex = 69;
            this.txtEndereco.TextNew = "";
            this.txtEndereco.UnderlinedStyle = false;
            // 
            // FrmCadastroAeroporto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 478);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodEndereco);
            this.Controls.Add(this.txtCodAeroporto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroAeroporto";
            this.Text = "Aeroporto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.novoTextBox txtDescricao;
        private controls.novoTextBox txtNome;
        private controls.novoTextBox txtCodEndereco;
        private controls.novoTextBox txtCodAeroporto;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private controls.novoTextBox txtEndereco;
    }
}
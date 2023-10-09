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
            this.txtCodAviao = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.txtCodCompAerea = new Rika.controls.novoTextBox();
            this.txtCompAerea = new Rika.controls.novoTextBoxTextAlign();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
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
            this.lblDataSaida.Location = new System.Drawing.Point(17, 325);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(173, 22);
            this.lblDataSaida.TabIndex = 49;
            this.lblDataSaida.Text = "Quantidade Acentos";
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(17, 244);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(68, 22);
            this.lblAeroDestino.TabIndex = 47;
            this.lblAeroDestino.Text = "Modelo";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(17, 284);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(154, 22);
            this.lblAeroDecolagem.TabIndex = 46;
            this.lblAeroDecolagem.Text = "Companhia Aerea";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(17, 204);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 45;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(224, 43);
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
            this.txtQtdAcentos.Location = new System.Drawing.Point(219, 321);
            this.txtQtdAcentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdAcentos.Multiline = false;
            this.txtQtdAcentos.Name = "txtQtdAcentos";
            this.txtQtdAcentos.Padding = new System.Windows.Forms.Padding(7);
            this.txtQtdAcentos.PasswordChar = false;
            this.txtQtdAcentos.Size = new System.Drawing.Size(90, 31);
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
            this.txtModelAviao.Location = new System.Drawing.Point(219, 243);
            this.txtModelAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelAviao.Multiline = false;
            this.txtModelAviao.Name = "txtModelAviao";
            this.txtModelAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtModelAviao.PasswordChar = false;
            this.txtModelAviao.Size = new System.Drawing.Size(347, 31);
            this.txtModelAviao.TabIndex = 66;
            this.txtModelAviao.TextNew = "";
            this.txtModelAviao.UnderlinedStyle = false;
            // 
            // txtCodAviao
            // 
            this.txtCodAviao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAviao.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAviao.BorderSize = 1;
            this.txtCodAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAviao.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.Location = new System.Drawing.Point(219, 204);
            this.txtCodAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAviao.Multiline = false;
            this.txtCodAviao.Name = "txtCodAviao";
            this.txtCodAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAviao.PasswordChar = false;
            this.txtCodAviao.Size = new System.Drawing.Size(90, 31);
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
            this.btnSair.Location = new System.Drawing.Point(378, 394);
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
            this.btnExcluir.Location = new System.Drawing.Point(217, 394);
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
            this.btnSalvar.Location = new System.Drawing.Point(57, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodCompAerea
            // 
            this.txtCodCompAerea.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCompAerea.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodCompAerea.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodCompAerea.BorderSize = 1;
            this.txtCodCompAerea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCompAerea.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodCompAerea.Location = new System.Drawing.Point(219, 282);
            this.txtCodCompAerea.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCompAerea.Multiline = false;
            this.txtCodCompAerea.Name = "txtCodCompAerea";
            this.txtCodCompAerea.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodCompAerea.PasswordChar = false;
            this.txtCodCompAerea.Size = new System.Drawing.Size(90, 31);
            this.txtCodCompAerea.TabIndex = 68;
            this.txtCodCompAerea.TextNew = "";
            this.txtCodCompAerea.UnderlinedStyle = false;
            // 
            // txtCompAerea
            // 
            this.txtCompAerea.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompAerea.BorderColor = System.Drawing.Color.DimGray;
            this.txtCompAerea.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCompAerea.BorderSize = 1;
            this.txtCompAerea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompAerea.ForeColor = System.Drawing.Color.DimGray;
            this.txtCompAerea.Location = new System.Drawing.Point(316, 282);
            this.txtCompAerea.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompAerea.Multiline = false;
            this.txtCompAerea.Name = "txtCompAerea";
            this.txtCompAerea.Padding = new System.Windows.Forms.Padding(7);
            this.txtCompAerea.PasswordChar = false;
            this.txtCompAerea.ReadOnly = true;
            this.txtCompAerea.Size = new System.Drawing.Size(250, 31);
            this.txtCompAerea.TabIndex = 69;
            this.txtCompAerea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompAerea.TextNew = "";
            this.txtCompAerea.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 30);
            this.panel2.TabIndex = 70;
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(558, 6);
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
            this.iconMinimizar.Location = new System.Drawing.Point(532, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            // 
            // FrmCadastroAviao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCompAerea);
            this.Controls.Add(this.txtCodCompAerea);
            this.Controls.Add(this.txtQtdAcentos);
            this.Controls.Add(this.txtModelAviao);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.novoTextBox txtQtdAcentos;
        private controls.novoTextBox txtModelAviao;
        private controls.novoTextBox txtCodAviao;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.novoTextBox txtCodCompAerea;
        private controls.novoTextBoxTextAlign txtCompAerea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
    }
}
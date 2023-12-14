namespace Rika.controls
{
    partial class PassagensAerea
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtIdaVolta = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDiretoEscala = new System.Windows.Forms.TextBox();
            this.lblPrecoFinal = new System.Windows.Forms.Label();
            this.ptbConfirmar = new System.Windows.Forms.PictureBox();
            this.imgPassagem = new System.Windows.Forms.PictureBox();
            this.txtDataViagem = new Rika.controls.novoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.Indigo;
            this.txtDestino.Location = new System.Drawing.Point(7, 136);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(223, 28);
            this.txtDestino.TabIndex = 3;
            this.txtDestino.Text = "destino";
            this.txtDestino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIdaVolta
            // 
            this.txtIdaVolta.BackColor = System.Drawing.Color.White;
            this.txtIdaVolta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdaVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdaVolta.Location = new System.Drawing.Point(7, 175);
            this.txtIdaVolta.Name = "txtIdaVolta";
            this.txtIdaVolta.ReadOnly = true;
            this.txtIdaVolta.Size = new System.Drawing.Size(105, 16);
            this.txtIdaVolta.TabIndex = 4;
            this.txtIdaVolta.Text = "Somente Ida";
            this.txtIdaVolta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtClasse
            // 
            this.txtClasse.BackColor = System.Drawing.Color.White;
            this.txtClasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasse.Location = new System.Drawing.Point(114, 175);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(112, 16);
            this.txtClasse.TabIndex = 5;
            this.txtClasse.Text = "Classe";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Indigo;
            this.txtValor.Location = new System.Drawing.Point(7, 237);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(155, 22);
            this.txtValor.TabIndex = 7;
            this.txtValor.Text = "R$9999,99";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtDiretoEscala
            // 
            this.txtDiretoEscala.BackColor = System.Drawing.Color.White;
            this.txtDiretoEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiretoEscala.Location = new System.Drawing.Point(7, 270);
            this.txtDiretoEscala.Name = "txtDiretoEscala";
            this.txtDiretoEscala.ReadOnly = true;
            this.txtDiretoEscala.Size = new System.Drawing.Size(223, 13);
            this.txtDiretoEscala.TabIndex = 8;
            this.txtDiretoEscala.Text = "Voo Direto";
            this.txtDiretoEscala.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblPrecoFinal
            // 
            this.lblPrecoFinal.AutoSize = true;
            this.lblPrecoFinal.Location = new System.Drawing.Point(4, 218);
            this.lblPrecoFinal.Name = "lblPrecoFinal";
            this.lblPrecoFinal.Size = new System.Drawing.Size(110, 13);
            this.lblPrecoFinal.TabIndex = 9;
            this.lblPrecoFinal.Text = "Preço final a partir de:";
            // 
            // ptbConfirmar
            // 
            this.ptbConfirmar.Image = global::Rika.Properties.Resources.seta_correta;
            this.ptbConfirmar.Location = new System.Drawing.Point(333, 237);
            this.ptbConfirmar.Name = "ptbConfirmar";
            this.ptbConfirmar.Size = new System.Drawing.Size(56, 50);
            this.ptbConfirmar.TabIndex = 10;
            this.ptbConfirmar.TabStop = false;
            this.ptbConfirmar.Click += new System.EventHandler(this.ptbConfirmar_Click);
            // 
            // imgPassagem
            // 
            this.imgPassagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPassagem.Location = new System.Drawing.Point(0, 0);
            this.imgPassagem.Name = "imgPassagem";
            this.imgPassagem.Size = new System.Drawing.Size(410, 113);
            this.imgPassagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPassagem.TabIndex = 2;
            this.imgPassagem.TabStop = false;
            // 
            // txtDataViagem
            // 
            this.txtDataViagem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDataViagem.BorderColor = System.Drawing.Color.Transparent;
            this.txtDataViagem.BorderFocusColor = System.Drawing.Color.Black;
            this.txtDataViagem.BorderSize = 2;
            this.txtDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataViagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataViagem.Location = new System.Drawing.Point(0, 98);
            this.txtDataViagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataViagem.Multiline = false;
            this.txtDataViagem.Name = "txtDataViagem";
            this.txtDataViagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtDataViagem.PasswordChar = false;
            this.txtDataViagem.ReadOnly = true;
            this.txtDataViagem.Size = new System.Drawing.Size(410, 31);
            this.txtDataViagem.TabIndex = 0;
            this.txtDataViagem.TextNew = "data viage";
            this.txtDataViagem.UnderlinedStyle = false;
            this.txtDataViagem.Paint += new System.Windows.Forms.PaintEventHandler(this.txtDataViagem_Paint);
            // 
            // PassagensAerea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptbConfirmar);
            this.Controls.Add(this.lblPrecoFinal);
            this.Controls.Add(this.txtDiretoEscala);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.txtIdaVolta);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtDataViagem);
            this.Controls.Add(this.imgPassagem);
            this.Name = "PassagensAerea";
            this.Size = new System.Drawing.Size(410, 298);
            this.Load += new System.EventHandler(this.PassagensAerea_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PassagensAerea_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private novoTextBox txtDataViagem;
        private System.Windows.Forms.PictureBox imgPassagem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtIdaVolta;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDiretoEscala;
        private System.Windows.Forms.Label lblPrecoFinal;
        private System.Windows.Forms.PictureBox ptbConfirmar;
    }
}

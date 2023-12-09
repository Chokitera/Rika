namespace Rika.controls
{
    partial class MenuCategorias
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
            this.txtInformacao = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInformacao
            // 
            this.txtInformacao.BackColor = System.Drawing.Color.White;
            this.txtInformacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInformacao.Enabled = false;
            this.txtInformacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformacao.Location = new System.Drawing.Point(148, 58);
            this.txtInformacao.Multiline = true;
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.ReadOnly = true;
            this.txtInformacao.Size = new System.Drawing.Size(217, 45);
            this.txtInformacao.TabIndex = 11;
            this.txtInformacao.Text = "Consultar e verificar diversos Países.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 23);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Título";
            // 
            // ptbImagem
            // 
            this.ptbImagem.Enabled = false;
            this.ptbImagem.Location = new System.Drawing.Point(27, 21);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(100, 84);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagem.TabIndex = 9;
            this.ptbImagem.TabStop = false;
            // 
            // MenuCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtInformacao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ptbImagem);
            this.Name = "MenuCategorias";
            this.Size = new System.Drawing.Size(394, 127);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuCategorias_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInformacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbImagem;
    }
}

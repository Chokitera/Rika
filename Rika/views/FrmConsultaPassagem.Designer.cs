namespace Rika.views
{
    partial class FrmConsultaPassagem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new Rika.controls.novoTextBox();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.txtCodigo = new Rika.controls.novoTextBox();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnConfirmar = new Rika.controls.ModeloBotao();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 30);
            this.panel2.TabIndex = 71;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(790, 6);
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
            this.iconMinimizar.Location = new System.Drawing.Point(764, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(328, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(114, 223);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(347, 31);
            this.txtNome.TabIndex = 74;
            this.txtNome.TextNew = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(31, 227);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(57, 22);
            this.lblAeroDestino.TabIndex = 73;
            this.lblAeroDestino.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(589, 223);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.Size = new System.Drawing.Size(90, 31);
            this.txtCodigo.TabIndex = 76;
            this.txtCodigo.TextNew = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(503, 227);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 75;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 316);
            this.dataGridView1.TabIndex = 77;
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
            this.btnSair.Location = new System.Drawing.Point(416, 605);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 79;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmar.BorderRadius = 20;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(260, 605);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 45);
            this.btnConfirmar.TabIndex = 78;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultaPassagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 662);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaPassagem";
            this.Text = "Consulta de Passagem";
            this.Load += new System.EventHandler(this.FrmConsultaPassagem_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.novoTextBox txtNome;
        private System.Windows.Forms.Label lblAeroDestino;
        private controls.novoTextBox txtCodigo;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnConfirmar;
    }
}
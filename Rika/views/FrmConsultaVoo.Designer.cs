namespace Rika.views
{
    partial class FrmConsultaVoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaVoo));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlVoo = new System.Windows.Forms.Panel();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnConfirmar = new Rika.controls.ModeloBotao();
            this.tabelaVoos = new System.Windows.Forms.DataGridView();
            this.idvoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_Chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new Rika.controls.novoTextBox();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.txtNome = new Rika.controls.novoTextBox();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.pnlVoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaVoos)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(820, 30);
            this.panel2.TabIndex = 71;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
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
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click_1);
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
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click_1);
            // 
            // pnlVoo
            // 
            this.pnlVoo.Controls.Add(this.btnSair);
            this.pnlVoo.Controls.Add(this.btnConfirmar);
            this.pnlVoo.Controls.Add(this.tabelaVoos);
            this.pnlVoo.Controls.Add(this.txtCodigo);
            this.pnlVoo.Controls.Add(this.label1lblCodigoPassagem);
            this.pnlVoo.Controls.Add(this.txtNome);
            this.pnlVoo.Controls.Add(this.lblAeroDestino);
            this.pnlVoo.Controls.Add(this.pictureBox1);
            this.pnlVoo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVoo.Location = new System.Drawing.Point(0, 30);
            this.pnlVoo.Name = "pnlVoo";
            this.pnlVoo.Size = new System.Drawing.Size(820, 632);
            this.pnlVoo.TabIndex = 72;
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
            this.btnSair.Location = new System.Drawing.Point(419, 566);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 103;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.btnConfirmar.Location = new System.Drawing.Point(263, 566);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 45);
            this.btnConfirmar.TabIndex = 102;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tabelaVoos
            // 
            this.tabelaVoos.AllowUserToAddRows = false;
            this.tabelaVoos.AllowUserToDeleteRows = false;
            this.tabelaVoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaVoos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvoo,
            this.Modelo,
            this.dt_saida,
            this.dt_chegada,
            this.Duracao,
            this.Horario_saida,
            this.Horario_Chegada});
            this.tabelaVoos.Location = new System.Drawing.Point(38, 239);
            this.tabelaVoos.Name = "tabelaVoos";
            this.tabelaVoos.ReadOnly = true;
            this.tabelaVoos.Size = new System.Drawing.Size(749, 316);
            this.tabelaVoos.TabIndex = 101;
            // 
            // idvoo
            // 
            this.idvoo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idvoo.DataPropertyName = "IDVOO";
            this.idvoo.HeaderText = "Código";
            this.idvoo.Name = "idvoo";
            this.idvoo.ReadOnly = true;
            this.idvoo.Width = 65;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "MODELO";
            this.Modelo.HeaderText = "Modelo Avião";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // dt_saida
            // 
            this.dt_saida.DataPropertyName = "dt_saida";
            this.dt_saida.HeaderText = "Data Saída";
            this.dt_saida.Name = "dt_saida";
            this.dt_saida.ReadOnly = true;
            // 
            // dt_chegada
            // 
            this.dt_chegada.DataPropertyName = "DT_CHEGADA";
            this.dt_chegada.HeaderText = "Data Chegada";
            this.dt_chegada.Name = "dt_chegada";
            this.dt_chegada.ReadOnly = true;
            // 
            // Duracao
            // 
            this.Duracao.DataPropertyName = "DURACAO";
            this.Duracao.HeaderText = "Duracao";
            this.Duracao.Name = "Duracao";
            this.Duracao.ReadOnly = true;
            // 
            // Horario_saida
            // 
            this.Horario_saida.DataPropertyName = "HORARIO_SAIDA";
            this.Horario_saida.HeaderText = "Horário de Saída";
            this.Horario_saida.Name = "Horario_saida";
            this.Horario_saida.ReadOnly = true;
            // 
            // Horario_Chegada
            // 
            this.Horario_Chegada.DataPropertyName = "HORARIO_CHEGADA";
            this.Horario_Chegada.HeaderText = "Horário de Chegada";
            this.Horario_Chegada.Name = "Horario_Chegada";
            this.Horario_Chegada.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(592, 189);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.Size = new System.Drawing.Size(90, 31);
            this.txtCodigo.TabIndex = 100;
            this.txtCodigo.TextNew = "";
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.Visible = false;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(506, 193);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 99;
            this.label1lblCodigoPassagem.Text = "Código";
            this.label1lblCodigoPassagem.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(117, 189);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(347, 31);
            this.txtNome.TabIndex = 98;
            this.txtNome.TextNew = "";
            this.txtNome.UnderlinedStyle = false;
            this.txtNome._TextChanged += new System.EventHandler(this.txtNome__TextChanged_1);
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(34, 193);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(57, 22);
            this.lblAeroDestino.TabIndex = 97;
            this.lblAeroDestino.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(331, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 662);
            this.Controls.Add(this.pnlVoo);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaVoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Voo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmConsultaVoo_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.pnlVoo.ResumeLayout(false);
            this.pnlVoo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaVoos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Panel pnlVoo;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnConfirmar;
        private System.Windows.Forms.DataGridView tabelaVoos;
        private controls.novoTextBox txtCodigo;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private controls.novoTextBox txtNome;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_chegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_Chegada;
    }
}
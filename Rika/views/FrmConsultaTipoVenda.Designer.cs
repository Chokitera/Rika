namespace Rika.views
{
    partial class FrmConsultaTipoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaTipoVenda));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlTipoVenda = new System.Windows.Forms.Panel();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnConfirmar = new Rika.controls.ModeloBotao();
            this.txtCodigo = new Rika.controls.novoTextBox();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.txtNome = new Rika.controls.novoTextBox();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabelaTipoVenda = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglapais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.pnlTipoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTipoVenda)).BeginInit();
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
            // pnlTipoVenda
            // 
            this.pnlTipoVenda.Controls.Add(this.tabelaTipoVenda);
            this.pnlTipoVenda.Controls.Add(this.btnSair);
            this.pnlTipoVenda.Controls.Add(this.btnConfirmar);
            this.pnlTipoVenda.Controls.Add(this.txtCodigo);
            this.pnlTipoVenda.Controls.Add(this.label1lblCodigoPassagem);
            this.pnlTipoVenda.Controls.Add(this.txtNome);
            this.pnlTipoVenda.Controls.Add(this.lblAeroDestino);
            this.pnlTipoVenda.Controls.Add(this.pictureBox1);
            this.pnlTipoVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTipoVenda.Location = new System.Drawing.Point(0, 30);
            this.pnlTipoVenda.Name = "pnlTipoVenda";
            this.pnlTipoVenda.Size = new System.Drawing.Size(820, 602);
            this.pnlTipoVenda.TabIndex = 72;
            this.pnlTipoVenda.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTipoVenda_Paint);
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
            this.btnSair.Location = new System.Drawing.Point(419, 551);
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
            this.btnConfirmar.Location = new System.Drawing.Point(263, 551);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 45);
            this.btnConfirmar.TabIndex = 102;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(592, 174);
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
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(506, 178);
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
            this.txtNome.Location = new System.Drawing.Point(117, 174);
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
            this.lblAeroDestino.Location = new System.Drawing.Point(34, 178);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(57, 22);
            this.lblAeroDestino.TabIndex = 97;
            this.lblAeroDestino.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(331, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // tabelaTipoVenda
            // 
            this.tabelaTipoVenda.AllowUserToAddRows = false;
            this.tabelaTipoVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.tabelaTipoVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaTipoVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaTipoVenda.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabelaTipoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaTipoVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabelaTipoVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaTipoVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaTipoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTipoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nomepais,
            this.siglapais});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaTipoVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaTipoVenda.EnableHeadersVisualStyles = false;
            this.tabelaTipoVenda.Location = new System.Drawing.Point(36, 216);
            this.tabelaTipoVenda.MultiSelect = false;
            this.tabelaTipoVenda.Name = "tabelaTipoVenda";
            this.tabelaTipoVenda.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaTipoVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelaTipoVenda.RowHeadersWidth = 20;
            this.tabelaTipoVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.tabelaTipoVenda.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabelaTipoVenda.Size = new System.Drawing.Size(749, 316);
            this.tabelaTipoVenda.TabIndex = 104;
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "IDPAIS";
            this.idpais.FillWeight = 45.68528F;
            this.idpais.HeaderText = "Código";
            this.idpais.Name = "idpais";
            this.idpais.ReadOnly = true;
            // 
            // nomepais
            // 
            this.nomepais.DataPropertyName = "NOME";
            this.nomepais.FillWeight = 161.8271F;
            this.nomepais.HeaderText = "Nome";
            this.nomepais.Name = "nomepais";
            this.nomepais.ReadOnly = true;
            // 
            // siglapais
            // 
            this.siglapais.DataPropertyName = "SIGLA";
            this.siglapais.FillWeight = 92.48762F;
            this.siglapais.HeaderText = "Sigla";
            this.siglapais.Name = "siglapais";
            this.siglapais.ReadOnly = true;
            // 
            // FrmConsultaTipoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 632);
            this.Controls.Add(this.pnlTipoVenda);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaTipoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Tipo de Venda";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmConsultaTipoVenda_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.pnlTipoVenda.ResumeLayout(false);
            this.pnlTipoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTipoVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Panel pnlTipoVenda;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnConfirmar;
        private controls.novoTextBox txtCodigo;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private controls.novoTextBox txtNome;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabelaTipoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepais;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglapais;
    }
}
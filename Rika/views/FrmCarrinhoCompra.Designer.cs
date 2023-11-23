namespace Rika.views
{
    partial class FrmCarrinhoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrinhoCompra));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCupomDesconto = new Rika.controls.novoTextBoxTextAlign();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTaxaEntrega = new Rika.controls.novoTextBoxTextAlign();
            this.txtTempoEntrega = new Rika.controls.novoTextBoxTextAlign();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotalCarrinho = new Rika.controls.novoTextBoxTextAlign();
            this.txtTotalResumo = new Rika.controls.novoTextBoxTextAlign();
            this.txtSubTotal = new Rika.controls.novoTextBoxTextAlign();
            this.btnVoltarCompras = new Rika.controls.ModeloBotao();
            this.btnComprarAgora = new Rika.controls.ModeloBotao();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAplicarCupom = new Rika.controls.ModeloBotao();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modeloItemNoCarrinho1 = new Rika.controls.ModeloItemNoCarrinho();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 30);
            this.panel2.TabIndex = 15;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(977, 6);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 28;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Rika.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(951, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Carrinho de Compras";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCupomDesconto);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txtTaxaEntrega);
            this.panel1.Controls.Add(this.txtTempoEntrega);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtTotalCarrinho);
            this.panel1.Controls.Add(this.txtTotalResumo);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.btnVoltarCompras);
            this.panel1.Controls.Add(this.btnComprarAgora);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAplicarCupom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(634, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 496);
            this.panel1.TabIndex = 29;
            // 
            // txtCupomDesconto
            // 
            this.txtCupomDesconto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCupomDesconto.BorderColor = System.Drawing.Color.White;
            this.txtCupomDesconto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCupomDesconto.BorderSize = 0;
            this.txtCupomDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCupomDesconto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCupomDesconto.Location = new System.Drawing.Point(22, 90);
            this.txtCupomDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCupomDesconto.Multiline = false;
            this.txtCupomDesconto.Name = "txtCupomDesconto";
            this.txtCupomDesconto.Padding = new System.Windows.Forms.Padding(7);
            this.txtCupomDesconto.PasswordChar = false;
            this.txtCupomDesconto.ReadOnly = false;
            this.txtCupomDesconto.Size = new System.Drawing.Size(191, 35);
            this.txtCupomDesconto.TabIndex = 53;
            this.txtCupomDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCupomDesconto.TextNew = "Cupom de Desconto";
            this.txtCupomDesconto.UnderlinedStyle = false;
            this.txtCupomDesconto._TextChanged += new System.EventHandler(this.txtCupomDesconto__TextChanged_1);
            this.txtCupomDesconto.Enter += new System.EventHandler(this.txtCupomDesconto_Enter);
            this.txtCupomDesconto.Leave += new System.EventHandler(this.txtCupomDesconto_Leave);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(22, 317);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(282, 1);
            this.panel7.TabIndex = 55;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(-109, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 2);
            this.panel8.TabIndex = 53;
            // 
            // txtTaxaEntrega
            // 
            this.txtTaxaEntrega.BackColor = System.Drawing.Color.White;
            this.txtTaxaEntrega.BorderColor = System.Drawing.Color.White;
            this.txtTaxaEntrega.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTaxaEntrega.BorderSize = 0;
            this.txtTaxaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTaxaEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtTaxaEntrega.Location = new System.Drawing.Point(184, 233);
            this.txtTaxaEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaEntrega.Multiline = false;
            this.txtTaxaEntrega.Name = "txtTaxaEntrega";
            this.txtTaxaEntrega.Padding = new System.Windows.Forms.Padding(7);
            this.txtTaxaEntrega.PasswordChar = false;
            this.txtTaxaEntrega.ReadOnly = false;
            this.txtTaxaEntrega.Size = new System.Drawing.Size(120, 35);
            this.txtTaxaEntrega.TabIndex = 56;
            this.txtTaxaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxaEntrega.TextNew = "Sem*";
            this.txtTaxaEntrega.UnderlinedStyle = false;
            // 
            // txtTempoEntrega
            // 
            this.txtTempoEntrega.BackColor = System.Drawing.Color.White;
            this.txtTempoEntrega.BorderColor = System.Drawing.Color.White;
            this.txtTempoEntrega.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTempoEntrega.BorderSize = 0;
            this.txtTempoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTempoEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtTempoEntrega.Location = new System.Drawing.Point(184, 199);
            this.txtTempoEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempoEntrega.Multiline = false;
            this.txtTempoEntrega.Name = "txtTempoEntrega";
            this.txtTempoEntrega.Padding = new System.Windows.Forms.Padding(7);
            this.txtTempoEntrega.PasswordChar = false;
            this.txtTempoEntrega.ReadOnly = false;
            this.txtTempoEntrega.Size = new System.Drawing.Size(120, 35);
            this.txtTempoEntrega.TabIndex = 55;
            this.txtTempoEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTempoEntrega.TextNew = "Sem*";
            this.txtTempoEntrega.UnderlinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(22, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 1);
            this.panel5.TabIndex = 54;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(-109, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 2);
            this.panel6.TabIndex = 53;
            // 
            // txtTotalCarrinho
            // 
            this.txtTotalCarrinho.BackColor = System.Drawing.Color.White;
            this.txtTotalCarrinho.BorderColor = System.Drawing.Color.White;
            this.txtTotalCarrinho.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotalCarrinho.BorderSize = 0;
            this.txtTotalCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalCarrinho.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCarrinho.Location = new System.Drawing.Point(184, 332);
            this.txtTotalCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCarrinho.Multiline = false;
            this.txtTotalCarrinho.Name = "txtTotalCarrinho";
            this.txtTotalCarrinho.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotalCarrinho.PasswordChar = false;
            this.txtTotalCarrinho.ReadOnly = false;
            this.txtTotalCarrinho.Size = new System.Drawing.Size(120, 35);
            this.txtTotalCarrinho.TabIndex = 48;
            this.txtTotalCarrinho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCarrinho.TextNew = "R$ 0,00";
            this.txtTotalCarrinho.UnderlinedStyle = false;
            // 
            // txtTotalResumo
            // 
            this.txtTotalResumo.BackColor = System.Drawing.Color.White;
            this.txtTotalResumo.BorderColor = System.Drawing.Color.White;
            this.txtTotalResumo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotalResumo.BorderSize = 0;
            this.txtTotalResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalResumo.ForeColor = System.Drawing.Color.Black;
            this.txtTotalResumo.Location = new System.Drawing.Point(184, 265);
            this.txtTotalResumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalResumo.Multiline = false;
            this.txtTotalResumo.Name = "txtTotalResumo";
            this.txtTotalResumo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotalResumo.PasswordChar = false;
            this.txtTotalResumo.ReadOnly = false;
            this.txtTotalResumo.Size = new System.Drawing.Size(120, 35);
            this.txtTotalResumo.TabIndex = 47;
            this.txtTotalResumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalResumo.TextNew = "R$ 0,00";
            this.txtTotalResumo.UnderlinedStyle = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSubTotal.BorderSize = 0;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(184, 168);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Multiline = false;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Padding = new System.Windows.Forms.Padding(7);
            this.txtSubTotal.PasswordChar = false;
            this.txtSubTotal.ReadOnly = false;
            this.txtSubTotal.Size = new System.Drawing.Size(120, 35);
            this.txtSubTotal.TabIndex = 46;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.TextNew = "R$ 0,00";
            this.txtSubTotal.UnderlinedStyle = false;
            // 
            // btnVoltarCompras
            // 
            this.btnVoltarCompras.BackColor = System.Drawing.Color.White;
            this.btnVoltarCompras.BackgroundColor = System.Drawing.Color.White;
            this.btnVoltarCompras.BorderColor = System.Drawing.Color.DimGray;
            this.btnVoltarCompras.BorderRadius = 5;
            this.btnVoltarCompras.BorderSize = 1;
            this.btnVoltarCompras.FlatAppearance.BorderSize = 0;
            this.btnVoltarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCompras.ForeColor = System.Drawing.Color.DimGray;
            this.btnVoltarCompras.Location = new System.Drawing.Point(22, 444);
            this.btnVoltarCompras.Name = "btnVoltarCompras";
            this.btnVoltarCompras.Size = new System.Drawing.Size(282, 31);
            this.btnVoltarCompras.TabIndex = 40;
            this.btnVoltarCompras.Text = "Voltar às compras";
            this.btnVoltarCompras.TextColor = System.Drawing.Color.DimGray;
            this.btnVoltarCompras.UseVisualStyleBackColor = false;
            // 
            // btnComprarAgora
            // 
            this.btnComprarAgora.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnComprarAgora.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnComprarAgora.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComprarAgora.BorderRadius = 5;
            this.btnComprarAgora.BorderSize = 0;
            this.btnComprarAgora.FlatAppearance.BorderSize = 0;
            this.btnComprarAgora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarAgora.ForeColor = System.Drawing.Color.White;
            this.btnComprarAgora.Location = new System.Drawing.Point(22, 400);
            this.btnComprarAgora.Name = "btnComprarAgora";
            this.btnComprarAgora.Size = new System.Drawing.Size(282, 38);
            this.btnComprarAgora.TabIndex = 39;
            this.btnComprarAgora.Text = "Comprar agora";
            this.btnComprarAgora.TextColor = System.Drawing.Color.White;
            this.btnComprarAgora.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "*Após aplicar as taxas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total Carrinho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Total Resumo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Taxa para Entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tempo para Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "SubTotal";
            // 
            // btnAplicarCupom
            // 
            this.btnAplicarCupom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAplicarCupom.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAplicarCupom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAplicarCupom.BorderRadius = 5;
            this.btnAplicarCupom.BorderSize = 0;
            this.btnAplicarCupom.FlatAppearance.BorderSize = 0;
            this.btnAplicarCupom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarCupom.ForeColor = System.Drawing.Color.White;
            this.btnAplicarCupom.Location = new System.Drawing.Point(220, 90);
            this.btnAplicarCupom.Name = "btnAplicarCupom";
            this.btnAplicarCupom.Size = new System.Drawing.Size(84, 35);
            this.btnAplicarCupom.TabIndex = 32;
            this.btnAplicarCupom.Text = "Aplicar";
            this.btnAplicarCupom.TextColor = System.Drawing.Color.White;
            this.btnAplicarCupom.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cupom de Desconto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Resumo do Carrinho";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(41, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 2);
            this.panel4.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(31, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 2);
            this.panel3.TabIndex = 53;
            // 
            // modeloItemNoCarrinho1
            // 
            this.modeloItemNoCarrinho1.Location = new System.Drawing.Point(41, 116);
            this.modeloItemNoCarrinho1.Name = "modeloItemNoCarrinho1";
            this.modeloItemNoCarrinho1.Size = new System.Drawing.Size(562, 258);
            this.modeloItemNoCarrinho1.TabIndex = 53;
            // 
            // FrmCarrinhoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1007, 690);
            this.Controls.Add(this.modeloItemNoCarrinho1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarrinhoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho de Compra";
            this.Load += new System.EventHandler(this.FrmCarrinhoCompra_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCarrinhoCompra_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private controls.ModeloBotao btnVoltarCompras;
        private controls.ModeloBotao btnComprarAgora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private controls.ModeloBotao btnAplicarCupom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private controls.novoTextBoxTextAlign txtTotalCarrinho;
        private controls.novoTextBoxTextAlign txtTotalResumo;
        private controls.novoTextBoxTextAlign txtSubTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private controls.novoTextBoxTextAlign txtTaxaEntrega;
        private controls.novoTextBoxTextAlign txtTempoEntrega;
        private controls.novoTextBoxTextAlign txtCupomDesconto;
        private controls.ModeloItemNoCarrinho modeloItemNoCarrinho1;
    }
}
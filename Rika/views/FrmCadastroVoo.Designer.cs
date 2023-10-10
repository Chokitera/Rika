namespace Rika.views
{
    partial class FrmCadastroVoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroVoo));
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblAeroDestino = new System.Windows.Forms.Label();
            this.lblAeroDecolagem = new System.Windows.Forms.Label();
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.txtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraChegada = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAeroportoDestino = new Rika.controls.novoTextBoxReadOnly();
            this.txtAeroportoDecolagem = new Rika.controls.novoTextBoxReadOnly();
            this.txtAviao = new Rika.controls.novoTextBoxReadOnly();
            this.txtCodAviao = new Rika.controls.novoTextBox();
            this.txtCodAeroportoDestino = new Rika.controls.novoTextBox();
            this.txtCodAeroportoDecolagem = new Rika.controls.novoTextBox();
            this.txtCodVoo = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(683, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Duração";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraChegada.Location = new System.Drawing.Point(683, 312);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(172, 22);
            this.lblHoraChegada.TabIndex = 52;
            this.lblHoraChegada.Text = "Horário de Chegada";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataChegada.Location = new System.Drawing.Point(68, 390);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(151, 22);
            this.lblDataChegada.TabIndex = 50;
            this.lblDataChegada.Text = "Data de Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(68, 351);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(124, 22);
            this.lblDataSaida.TabIndex = 49;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaida.Location = new System.Drawing.Point(683, 273);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(145, 22);
            this.lblHoraSaida.TabIndex = 48;
            this.lblHoraSaida.Text = "Horário de Saida";
            // 
            // lblAeroDestino
            // 
            this.lblAeroDestino.AutoSize = true;
            this.lblAeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDestino.Location = new System.Drawing.Point(68, 312);
            this.lblAeroDestino.Name = "lblAeroDestino";
            this.lblAeroDestino.Size = new System.Drawing.Size(180, 22);
            this.lblAeroDestino.TabIndex = 47;
            this.lblAeroDestino.Text = "Aeroporto de Destino";
            // 
            // lblAeroDecolagem
            // 
            this.lblAeroDecolagem.AutoSize = true;
            this.lblAeroDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroDecolagem.Location = new System.Drawing.Point(68, 273);
            this.lblAeroDecolagem.Name = "lblAeroDecolagem";
            this.lblAeroDecolagem.Size = new System.Drawing.Size(209, 22);
            this.lblAeroDecolagem.TabIndex = 46;
            this.lblAeroDecolagem.Text = "Aeroporto de Decolagem";
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(68, 234);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(67, 22);
            this.label1lblCodigoPassagem.TabIndex = 45;
            this.label1lblCodigoPassagem.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Avião";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataSaida.Location = new System.Drawing.Point(289, 352);
            this.txtDataSaida.Mask = "00/00/0000";
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(137, 26);
            this.txtDataSaida.TabIndex = 76;
            this.txtDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataChegada
            // 
            this.txtDataChegada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataChegada.Location = new System.Drawing.Point(289, 389);
            this.txtDataChegada.Mask = "00/00/0000";
            this.txtDataChegada.Name = "txtDataChegada";
            this.txtDataChegada.Size = new System.Drawing.Size(137, 26);
            this.txtDataChegada.TabIndex = 77;
            this.txtDataChegada.ValidatingType = typeof(System.DateTime);
            // 
            // txtDuracao
            // 
            this.txtDuracao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDuracao.Location = new System.Drawing.Point(871, 235);
            this.txtDuracao.Mask = "00:00";
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(137, 26);
            this.txtDuracao.TabIndex = 78;
            this.txtDuracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraChegada
            // 
            this.txtHoraChegada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoraChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoraChegada.Location = new System.Drawing.Point(871, 273);
            this.txtHoraChegada.Mask = "00:00";
            this.txtHoraChegada.Name = "txtHoraChegada";
            this.txtHoraChegada.Size = new System.Drawing.Size(137, 26);
            this.txtHoraChegada.TabIndex = 81;
            this.txtHoraChegada.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoraSaida.Location = new System.Drawing.Point(871, 314);
            this.txtHoraSaida.Mask = "00:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(137, 26);
            this.txtHoraSaida.TabIndex = 82;
            this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconFechar);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 30);
            this.panel2.TabIndex = 87;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(1253, 6);
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
            this.iconMinimizar.Location = new System.Drawing.Point(1227, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 29;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox2.Location = new System.Drawing.Point(544, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // txtAeroportoDestino
            // 
            this.txtAeroportoDestino.BackColor = System.Drawing.SystemColors.Window;
            this.txtAeroportoDestino.BorderColor = System.Drawing.Color.DimGray;
            this.txtAeroportoDestino.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAeroportoDestino.BorderSize = 1;
            this.txtAeroportoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeroportoDestino.ForeColor = System.Drawing.Color.DimGray;
            this.txtAeroportoDestino.Location = new System.Drawing.Point(387, 312);
            this.txtAeroportoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtAeroportoDestino.Multiline = false;
            this.txtAeroportoDestino.Name = "txtAeroportoDestino";
            this.txtAeroportoDestino.Padding = new System.Windows.Forms.Padding(7);
            this.txtAeroportoDestino.PasswordChar = false;
            this.txtAeroportoDestino.ReadOnly = true;
            this.txtAeroportoDestino.Size = new System.Drawing.Size(250, 31);
            this.txtAeroportoDestino.TabIndex = 91;
            this.txtAeroportoDestino.TextNew = "";
            this.txtAeroportoDestino.UnderlinedStyle = false;
            // 
            // txtAeroportoDecolagem
            // 
            this.txtAeroportoDecolagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtAeroportoDecolagem.BorderColor = System.Drawing.Color.DimGray;
            this.txtAeroportoDecolagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAeroportoDecolagem.BorderSize = 1;
            this.txtAeroportoDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeroportoDecolagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtAeroportoDecolagem.Location = new System.Drawing.Point(387, 273);
            this.txtAeroportoDecolagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtAeroportoDecolagem.Multiline = false;
            this.txtAeroportoDecolagem.Name = "txtAeroportoDecolagem";
            this.txtAeroportoDecolagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtAeroportoDecolagem.PasswordChar = false;
            this.txtAeroportoDecolagem.ReadOnly = true;
            this.txtAeroportoDecolagem.Size = new System.Drawing.Size(250, 31);
            this.txtAeroportoDecolagem.TabIndex = 90;
            this.txtAeroportoDecolagem.TextNew = "";
            this.txtAeroportoDecolagem.UnderlinedStyle = false;
            // 
            // txtAviao
            // 
            this.txtAviao.BackColor = System.Drawing.SystemColors.Window;
            this.txtAviao.BorderColor = System.Drawing.Color.DimGray;
            this.txtAviao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAviao.BorderSize = 1;
            this.txtAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAviao.ForeColor = System.Drawing.Color.DimGray;
            this.txtAviao.Location = new System.Drawing.Point(969, 351);
            this.txtAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAviao.Multiline = false;
            this.txtAviao.Name = "txtAviao";
            this.txtAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtAviao.PasswordChar = false;
            this.txtAviao.ReadOnly = true;
            this.txtAviao.Size = new System.Drawing.Size(250, 31);
            this.txtAviao.TabIndex = 89;
            this.txtAviao.TextNew = "";
            this.txtAviao.UnderlinedStyle = false;
            // 
            // txtCodAviao
            // 
            this.txtCodAviao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAviao.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAviao.BorderSize = 1;
            this.txtCodAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAviao.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAviao.Location = new System.Drawing.Point(871, 351);
            this.txtCodAviao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAviao.Multiline = false;
            this.txtCodAviao.Name = "txtCodAviao";
            this.txtCodAviao.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAviao.PasswordChar = false;
            this.txtCodAviao.Size = new System.Drawing.Size(90, 31);
            this.txtCodAviao.TabIndex = 71;
            this.txtCodAviao.TextNew = "";
            this.txtCodAviao.UnderlinedStyle = false;
            // 
            // txtCodAeroportoDestino
            // 
            this.txtCodAeroportoDestino.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAeroportoDestino.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAeroportoDestino.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAeroportoDestino.BorderSize = 1;
            this.txtCodAeroportoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAeroportoDestino.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAeroportoDestino.Location = new System.Drawing.Point(289, 312);
            this.txtCodAeroportoDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAeroportoDestino.Multiline = false;
            this.txtCodAeroportoDestino.Name = "txtCodAeroportoDestino";
            this.txtCodAeroportoDestino.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAeroportoDestino.PasswordChar = false;
            this.txtCodAeroportoDestino.Size = new System.Drawing.Size(90, 31);
            this.txtCodAeroportoDestino.TabIndex = 66;
            this.txtCodAeroportoDestino.TextNew = "";
            this.txtCodAeroportoDestino.UnderlinedStyle = false;
            // 
            // txtCodAeroportoDecolagem
            // 
            this.txtCodAeroportoDecolagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodAeroportoDecolagem.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodAeroportoDecolagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodAeroportoDecolagem.BorderSize = 1;
            this.txtCodAeroportoDecolagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAeroportoDecolagem.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodAeroportoDecolagem.Location = new System.Drawing.Point(289, 273);
            this.txtCodAeroportoDecolagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAeroportoDecolagem.Multiline = false;
            this.txtCodAeroportoDecolagem.Name = "txtCodAeroportoDecolagem";
            this.txtCodAeroportoDecolagem.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodAeroportoDecolagem.PasswordChar = false;
            this.txtCodAeroportoDecolagem.Size = new System.Drawing.Size(90, 31);
            this.txtCodAeroportoDecolagem.TabIndex = 65;
            this.txtCodAeroportoDecolagem.TextNew = "";
            this.txtCodAeroportoDecolagem.UnderlinedStyle = false;
            // 
            // txtCodVoo
            // 
            this.txtCodVoo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodVoo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodVoo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodVoo.BorderSize = 1;
            this.txtCodVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVoo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodVoo.Location = new System.Drawing.Point(289, 234);
            this.txtCodVoo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVoo.Multiline = false;
            this.txtCodVoo.Name = "txtCodVoo";
            this.txtCodVoo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodVoo.PasswordChar = false;
            this.txtCodVoo.Size = new System.Drawing.Size(90, 31);
            this.txtCodVoo.TabIndex = 64;
            this.txtCodVoo.TextNew = "";
            this.txtCodVoo.UnderlinedStyle = false;
            this.txtCodVoo.Leave += new System.EventHandler(this.txtCodVoo_Leave);
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
            this.btnSair.Location = new System.Drawing.Point(715, 463);
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
            this.btnExcluir.Location = new System.Drawing.Point(554, 463);
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
            this.btnSalvar.Location = new System.Drawing.Point(394, 463);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 537);
            this.Controls.Add(this.txtAeroportoDestino);
            this.Controls.Add(this.txtAeroportoDecolagem);
            this.Controls.Add(this.txtAviao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.txtHoraChegada);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.txtDataChegada);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.txtCodAviao);
            this.Controls.Add(this.txtCodAeroportoDestino);
            this.Controls.Add(this.txtCodAeroportoDecolagem);
            this.Controls.Add(this.txtCodVoo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblHoraChegada);
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.lblAeroDestino);
            this.Controls.Add(this.lblAeroDecolagem);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroVoo";
            this.Text = "Voo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCadastroVoo_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controls.novoTextBox txtCodAeroportoDestino;
        private controls.novoTextBox txtCodAeroportoDecolagem;
        private controls.novoTextBox txtCodVoo;
        private System.Windows.Forms.Label label4;
        private controls.ModeloBotao btnSair;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSalvar;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblAeroDestino;
        private System.Windows.Forms.Label lblAeroDecolagem;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.Label label5;
        private controls.novoTextBox txtCodAviao;
        private System.Windows.Forms.MaskedTextBox txtDataSaida;
        private System.Windows.Forms.MaskedTextBox txtDataChegada;
        private System.Windows.Forms.MaskedTextBox txtDuracao;
        private System.Windows.Forms.MaskedTextBox txtHoraChegada;
        private System.Windows.Forms.MaskedTextBox txtHoraSaida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private controls.novoTextBoxReadOnly txtAviao;
        private controls.novoTextBoxReadOnly txtAeroportoDecolagem;
        private controls.novoTextBoxReadOnly txtAeroportoDestino;
    }
}
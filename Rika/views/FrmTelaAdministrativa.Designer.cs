namespace Rika.views
{
    partial class FrmTelaAdministrativa
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
            this.label1lblCodigoPassagem = new System.Windows.Forms.Label();
            this.lblVoo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlArrastarFormulario = new System.Windows.Forms.Panel();
            this.novoTextBox17 = new Rika.controls.novoTextBox();
            this.novoTextBox9 = new Rika.controls.novoTextBox();
            this.novoTextBox10 = new Rika.controls.novoTextBox();
            this.novoTextBox12 = new Rika.controls.novoTextBox();
            this.novoTextBox16 = new Rika.controls.novoTextBox();
            this.novoTextBox1 = new Rika.controls.novoTextBox();
            this.btnSair = new Rika.controls.ModeloBotao();
            this.btnExcluir = new Rika.controls.ModeloBotao();
            this.btnSalvar = new Rika.controls.ModeloBotao();
            this.label1 = new System.Windows.Forms.Label();
            this.novoTextBox15 = new Rika.controls.novoTextBox();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlArrastarFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1lblCodigoPassagem
            // 
            this.label1lblCodigoPassagem.AccessibleName = "";
            this.label1lblCodigoPassagem.AutoSize = true;
            this.label1lblCodigoPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1lblCodigoPassagem.Location = new System.Drawing.Point(15, 229);
            this.label1lblCodigoPassagem.Name = "label1lblCodigoPassagem";
            this.label1lblCodigoPassagem.Size = new System.Drawing.Size(186, 22);
            this.label1lblCodigoPassagem.TabIndex = 1;
            this.label1lblCodigoPassagem.Text = "Código da Passagem:";
            this.label1lblCodigoPassagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVoo
            // 
            this.lblVoo.AutoSize = true;
            this.lblVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoo.Location = new System.Drawing.Point(15, 268);
            this.lblVoo.Name = "lblVoo";
            this.lblVoo.Size = new System.Drawing.Size(47, 22);
            this.lblVoo.TabIndex = 8;
            this.lblVoo.Text = "Voo:";
            this.lblVoo.Click += new System.EventHandler(this.lblVoo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Classe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Direto ou Escala:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Imagem Destaque:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pnlArrastarFormulario
            // 
            this.pnlArrastarFormulario.Controls.Add(this.iconFechar);
            this.pnlArrastarFormulario.Controls.Add(this.iconMinimizar);
            this.pnlArrastarFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArrastarFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlArrastarFormulario.Name = "pnlArrastarFormulario";
            this.pnlArrastarFormulario.Size = new System.Drawing.Size(508, 24);
            this.pnlArrastarFormulario.TabIndex = 23;
            this.pnlArrastarFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArrastarFormulario_MouseDown);
            // 
            // novoTextBox17
            // 
            this.novoTextBox17.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox17.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox17.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox17.BorderSize = 1;
            this.novoTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox17.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox17.Location = new System.Drawing.Point(233, 463);
            this.novoTextBox17.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox17.Multiline = false;
            this.novoTextBox17.Name = "novoTextBox17";
            this.novoTextBox17.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox17.PasswordChar = false;
            this.novoTextBox17.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox17.TabIndex = 41;
            this.novoTextBox17.TextNew = "";
            this.novoTextBox17.UnderlinedStyle = false;
            // 
            // novoTextBox9
            // 
            this.novoTextBox9.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox9.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox9.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox9.BorderSize = 1;
            this.novoTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox9.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox9.Location = new System.Drawing.Point(233, 424);
            this.novoTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox9.Multiline = false;
            this.novoTextBox9.Name = "novoTextBox9";
            this.novoTextBox9.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox9.PasswordChar = false;
            this.novoTextBox9.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox9.TabIndex = 40;
            this.novoTextBox9.TextNew = "";
            this.novoTextBox9.UnderlinedStyle = false;
            // 
            // novoTextBox10
            // 
            this.novoTextBox10.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox10.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox10.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox10.BorderSize = 1;
            this.novoTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox10.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox10.Location = new System.Drawing.Point(233, 385);
            this.novoTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox10.Multiline = false;
            this.novoTextBox10.Name = "novoTextBox10";
            this.novoTextBox10.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox10.PasswordChar = false;
            this.novoTextBox10.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox10.TabIndex = 39;
            this.novoTextBox10.TextNew = "";
            this.novoTextBox10.UnderlinedStyle = false;
            // 
            // novoTextBox12
            // 
            this.novoTextBox12.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox12.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox12.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox12.BorderSize = 1;
            this.novoTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox12.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox12.Location = new System.Drawing.Point(233, 307);
            this.novoTextBox12.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox12.Multiline = false;
            this.novoTextBox12.Name = "novoTextBox12";
            this.novoTextBox12.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox12.PasswordChar = false;
            this.novoTextBox12.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox12.TabIndex = 37;
            this.novoTextBox12.TextNew = "";
            this.novoTextBox12.UnderlinedStyle = false;
            // 
            // novoTextBox16
            // 
            this.novoTextBox16.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox16.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox16.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox16.BorderSize = 1;
            this.novoTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox16.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox16.Location = new System.Drawing.Point(233, 268);
            this.novoTextBox16.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox16.Multiline = false;
            this.novoTextBox16.Name = "novoTextBox16";
            this.novoTextBox16.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox16.PasswordChar = false;
            this.novoTextBox16.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox16.TabIndex = 33;
            this.novoTextBox16.TextNew = "";
            this.novoTextBox16.UnderlinedStyle = false;
            // 
            // novoTextBox1
            // 
            this.novoTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox1.BorderSize = 1;
            this.novoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox1.Location = new System.Drawing.Point(233, 229);
            this.novoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox1.Multiline = false;
            this.novoTextBox1.Name = "novoTextBox1";
            this.novoTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox1.PasswordChar = false;
            this.novoTextBox1.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox1.TabIndex = 25;
            this.novoTextBox1.TextNew = "";
            this.novoTextBox1.UnderlinedStyle = false;
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
            this.btnSair.Location = new System.Drawing.Point(333, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 45);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.modeloBotao1_Click_1);
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
            this.btnExcluir.Location = new System.Drawing.Point(172, 512);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 13;
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
            this.btnSalvar.Location = new System.Drawing.Point(12, 512);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Situação:";
            // 
            // novoTextBox15
            // 
            this.novoTextBox15.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox15.BorderColor = System.Drawing.Color.DimGray;
            this.novoTextBox15.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox15.BorderSize = 1;
            this.novoTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox15.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox15.Location = new System.Drawing.Point(233, 346);
            this.novoTextBox15.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox15.Multiline = false;
            this.novoTextBox15.Name = "novoTextBox15";
            this.novoTextBox15.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox15.PasswordChar = false;
            this.novoTextBox15.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox15.TabIndex = 43;
            this.novoTextBox15.TextNew = "";
            this.novoTextBox15.UnderlinedStyle = false;
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Rika.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(476, 4);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 30;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Rika.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(450, 4);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 31;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rika.Properties.Resources.Logo_Rika_Preto;
            this.pictureBox1.Location = new System.Drawing.Point(172, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTelaAdministrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 569);
            this.Controls.Add(this.novoTextBox15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.novoTextBox17);
            this.Controls.Add(this.novoTextBox9);
            this.Controls.Add(this.novoTextBox10);
            this.Controls.Add(this.novoTextBox12);
            this.Controls.Add(this.novoTextBox16);
            this.Controls.Add(this.novoTextBox1);
            this.Controls.Add(this.pnlArrastarFormulario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblVoo);
            this.Controls.Add(this.label1lblCodigoPassagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaAdministrativa";
            this.Text = "FrmTelaAdministrativa";
            this.Load += new System.EventHandler(this.FrmTelaAdministrativa_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTelaAdministrativa_Paint);
            this.pnlArrastarFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1lblCodigoPassagem;
        private System.Windows.Forms.Label lblVoo;
        private controls.ModeloBotao btnSalvar;
        private controls.ModeloBotao btnExcluir;
        private controls.ModeloBotao btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlArrastarFormulario;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private controls.novoTextBox novoTextBox1;
        private controls.novoTextBox novoTextBox9;
        private controls.novoTextBox novoTextBox10;
        private controls.novoTextBox novoTextBox12;
        private controls.novoTextBox novoTextBox16;
        private controls.novoTextBox novoTextBox17;
        private System.Windows.Forms.Label label1;
        private controls.novoTextBox novoTextBox15;
    }
}
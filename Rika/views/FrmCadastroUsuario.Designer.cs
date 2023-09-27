namespace Rika.views
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkEntrar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkTermos = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkPolitica = new System.Windows.Forms.LinkLabel();
            this.txtConfimarSenha2 = new Rika.controls.textBoxComImagem();
            this.txtSenha2 = new Rika.controls.textBoxComImagem();
            this.txtConfirmarSenha = new Rika.controls.textBoxComImagem();
            this.txtSenha = new Rika.controls.textBoxComImagem();
            this.txtUsuario = new Rika.controls.textBoxComImagem();
            this.txtSobrenome = new Rika.controls.textBoxComImagem();
            this.txtNome = new Rika.controls.textBoxComImagem();
            this.btnCriaConta = new Rika.controls.ModeloBotao();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(141, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Já tem uma conta?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(74, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cadastro de Usuário";
            // 
            // linkEntrar
            // 
            this.linkEntrar.AutoSize = true;
            this.linkEntrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkEntrar.LinkColor = System.Drawing.Color.Blue;
            this.linkEntrar.Location = new System.Drawing.Point(234, 498);
            this.linkEntrar.Name = "linkEntrar";
            this.linkEntrar.Size = new System.Drawing.Size(35, 13);
            this.linkEntrar.TabIndex = 38;
            this.linkEntrar.TabStop = true;
            this.linkEntrar.Text = "Entrar";
            this.linkEntrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEntrar_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ao se inscrever, você concorda com os";
            // 
            // linkTermos
            // 
            this.linkTermos.AutoSize = true;
            this.linkTermos.BackColor = System.Drawing.Color.White;
            this.linkTermos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkTermos.Location = new System.Drawing.Point(246, 380);
            this.linkTermos.Name = "linkTermos";
            this.linkTermos.Size = new System.Drawing.Size(96, 13);
            this.linkTermos.TabIndex = 35;
            this.linkTermos.TabStop = true;
            this.linkTermos.Text = "Termos de Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "e";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "a";
            // 
            // linkPolitica
            // 
            this.linkPolitica.AutoSize = true;
            this.linkPolitica.BackColor = System.Drawing.Color.Transparent;
            this.linkPolitica.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPolitica.Location = new System.Drawing.Point(64, 394);
            this.linkPolitica.Name = "linkPolitica";
            this.linkPolitica.Size = new System.Drawing.Size(120, 13);
            this.linkPolitica.TabIndex = 36;
            this.linkPolitica.TabStop = true;
            this.linkPolitica.Text = "Política de Privacidade.";
            // 
            // txtConfimarSenha2
            // 
            this.txtConfimarSenha2.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfimarSenha2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConfimarSenha2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfimarSenha2.BorderSize = 2;
            this.txtConfimarSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfimarSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtConfimarSenha2.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfimarSenha2.Location = new System.Drawing.Point(57, 328);
            this.txtConfimarSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfimarSenha2.Multiline = false;
            this.txtConfimarSenha2.Name = "txtConfimarSenha2";
            this.txtConfimarSenha2.NovaImagem = global::Rika.Properties.Resources.icon_cadeado;
            this.txtConfimarSenha2.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfimarSenha2.PasswordChar = false;
            this.txtConfimarSenha2.Size = new System.Drawing.Size(295, 31);
            this.txtConfimarSenha2.TabIndex = 43;
            this.txtConfimarSenha2.TabStop = false;
            this.txtConfimarSenha2.TextNew = "Confirmar Senha";
            this.txtConfimarSenha2.UnderlinedStyle = false;
            this.txtConfimarSenha2.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            this.txtConfimarSenha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfimarSenha2_KeyPress);
            this.txtConfimarSenha2.Leave += new System.EventHandler(this.txtConfirmarSenha_Leave);
            // 
            // txtSenha2
            // 
            this.txtSenha2.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha2.BorderSize = 2;
            this.txtSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtSenha2.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha2.Location = new System.Drawing.Point(57, 275);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha2.Multiline = false;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.NovaImagem = global::Rika.Properties.Resources.icon_cadeado;
            this.txtSenha2.Padding = new System.Windows.Forms.Padding(7);
            this.txtSenha2.PasswordChar = false;
            this.txtSenha2.Size = new System.Drawing.Size(295, 31);
            this.txtSenha2.TabIndex = 42;
            this.txtSenha2.TabStop = false;
            this.txtSenha2.TextNew = "Senha";
            this.txtSenha2.UnderlinedStyle = false;
            this.txtSenha2.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha2_KeyPress);
            this.txtSenha2.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmarSenha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConfirmarSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmarSenha.BorderSize = 2;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(57, 328);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarSenha.Multiline = false;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.NovaImagem = global::Rika.Properties.Resources.icon_cadeado;
            this.txtConfirmarSenha.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmarSenha.PasswordChar = true;
            this.txtConfirmarSenha.Size = new System.Drawing.Size(295, 31);
            this.txtConfirmarSenha.TabIndex = 34;
            this.txtConfirmarSenha.TextNew = "";
            this.txtConfirmarSenha.UnderlinedStyle = false;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            this.txtConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarSenha_KeyPress);
            this.txtConfirmarSenha.Leave += new System.EventHandler(this.txtConfirmarSenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(57, 275);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.NovaImagem = global::Rika.Properties.Resources.icon_cadeado;
            this.txtSenha.Padding = new System.Windows.Forms.Padding(7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(295, 31);
            this.txtSenha.TabIndex = 33;
            this.txtSenha.TextNew = "";
            this.txtSenha.UnderlinedStyle = false;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(57, 221);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NovaImagem = global::Rika.Properties.Resources.icon_perfil_de_usuario;
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.Size = new System.Drawing.Size(295, 31);
            this.txtUsuario.TabIndex = 32;
            this.txtUsuario.TextNew = "Usuário";
            this.txtUsuario.UnderlinedStyle = false;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.SystemColors.Window;
            this.txtSobrenome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSobrenome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSobrenome.BorderSize = 2;
            this.txtSobrenome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtSobrenome.ForeColor = System.Drawing.Color.DimGray;
            this.txtSobrenome.Location = new System.Drawing.Point(57, 166);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Multiline = false;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.NovaImagem = global::Rika.Properties.Resources.icon_nome;
            this.txtSobrenome.Padding = new System.Windows.Forms.Padding(7);
            this.txtSobrenome.PasswordChar = false;
            this.txtSobrenome.Size = new System.Drawing.Size(295, 31);
            this.txtSobrenome.TabIndex = 31;
            this.txtSobrenome.TextNew = "Sobrenome";
            this.txtSobrenome.UnderlinedStyle = false;
            this.txtSobrenome.Enter += new System.EventHandler(this.txtSobrenome_Enter);
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSobrenome_KeyPress);
            this.txtSobrenome.Leave += new System.EventHandler(this.txtSobrenome_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 2;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(57, 111);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.NovaImagem = global::Rika.Properties.Resources.icon_nome;
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(295, 31);
            this.txtNome.TabIndex = 30;
            this.txtNome.TextNew = "Nome";
            this.txtNome.UnderlinedStyle = false;
            this.txtNome.Load += new System.EventHandler(this.txtNome_Load);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnCriaConta
            // 
            this.btnCriaConta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCriaConta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCriaConta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCriaConta.BorderRadius = 20;
            this.btnCriaConta.BorderSize = 0;
            this.btnCriaConta.FlatAppearance.BorderSize = 0;
            this.btnCriaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriaConta.ForeColor = System.Drawing.Color.White;
            this.btnCriaConta.Location = new System.Drawing.Point(96, 436);
            this.btnCriaConta.Name = "btnCriaConta";
            this.btnCriaConta.Size = new System.Drawing.Size(217, 40);
            this.btnCriaConta.TabIndex = 37;
            this.btnCriaConta.Text = "Criar Conta";
            this.btnCriaConta.TextColor = System.Drawing.Color.White;
            this.btnCriaConta.UseVisualStyleBackColor = false;
            this.btnCriaConta.Click += new System.EventHandler(this.btnCriaConta_Click);
            this.btnCriaConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCriaConta_KeyPress);
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 578);
            this.Controls.Add(this.txtConfimarSenha2);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.linkPolitica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkTermos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCriaConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroUsuario";
            this.Text = "FrmCadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private controls.ModeloBotao btnCriaConta;
        private controls.textBoxComImagem txtNome;
        private controls.textBoxComImagem txtSobrenome;
        private controls.textBoxComImagem txtUsuario;
        private controls.textBoxComImagem txtSenha;
        private controls.textBoxComImagem txtConfirmarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkTermos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkPolitica;
        private controls.textBoxComImagem txtSenha2;
        private controls.textBoxComImagem txtConfimarSenha2;
    }
}
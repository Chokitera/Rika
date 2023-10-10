namespace Rika.views
{
    partial class FrmTelaLogin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Rika.controls.ModeloBotao();
            this.LinkInscrever = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkResetarSenha = new System.Windows.Forms.LinkLabel();
            this.txtSenha = new Rika.controls.novoTextBox();
            this.txtUsuario = new Rika.controls.novoTextBox();
            this.txtSenha2 = new Rika.controls.novoTextBox();
            this.lblContinuarSemLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(41, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Seja bem vindo de volta.";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(128, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Faça o seu login agora";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(41, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Olá!";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(114, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Esqueceu a sua senha?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(136, 418);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 43;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // LinkInscrever
            // 
            this.LinkInscrever.AutoSize = true;
            this.LinkInscrever.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkInscrever.LinkColor = System.Drawing.Color.Blue;
            this.LinkInscrever.Location = new System.Drawing.Point(235, 471);
            this.LinkInscrever.Name = "LinkInscrever";
            this.LinkInscrever.Size = new System.Drawing.Size(62, 13);
            this.LinkInscrever.TabIndex = 44;
            this.LinkInscrever.TabStop = true;
            this.LinkInscrever.Text = "Inscreva-se";
            this.LinkInscrever.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInscrever_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(131, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Não tem uma conta?";
            // 
            // linkResetarSenha
            // 
            this.linkResetarSenha.AutoSize = true;
            this.linkResetarSenha.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkResetarSenha.LinkColor = System.Drawing.Color.Blue;
            this.linkResetarSenha.Location = new System.Drawing.Point(233, 366);
            this.linkResetarSenha.Name = "linkResetarSenha";
            this.linkResetarSenha.Size = new System.Drawing.Size(78, 13);
            this.linkResetarSenha.TabIndex = 42;
            this.linkResetarSenha.TabStop = true;
            this.linkResetarSenha.Text = "Resetar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.DimGray;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha.BorderSize = 1;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha.Location = new System.Drawing.Point(47, 289);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(325, 38);
            this.txtSenha.TabIndex = 41;
            this.txtSenha.TextNew = "";
            this.txtSenha.UnderlinedStyle = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(47, 241);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.Size = new System.Drawing.Size(325, 38);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.TextNew = "Usuário";
            this.txtUsuario.UnderlinedStyle = true;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha2
            // 
            this.txtSenha2.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha2.BorderColor = System.Drawing.Color.DimGray;
            this.txtSenha2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenha2.BorderSize = 1;
            this.txtSenha2.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtSenha2.ForeColor = System.Drawing.Color.DimGray;
            this.txtSenha2.Location = new System.Drawing.Point(47, 289);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha2.Multiline = false;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSenha2.PasswordChar = false;
            this.txtSenha2.Size = new System.Drawing.Size(325, 38);
            this.txtSenha2.TabIndex = 45;
            this.txtSenha2.TabStop = false;
            this.txtSenha2.TextNew = "Senha";
            this.txtSenha2.UnderlinedStyle = true;
            this.txtSenha2.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha2.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lblContinuarSemLogin
            // 
            this.lblContinuarSemLogin.AutoSize = true;
            this.lblContinuarSemLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblContinuarSemLogin.Location = new System.Drawing.Point(161, 490);
            this.lblContinuarSemLogin.Name = "lblContinuarSemLogin";
            this.lblContinuarSemLogin.Size = new System.Drawing.Size(99, 13);
            this.lblContinuarSemLogin.TabIndex = 46;
            this.lblContinuarSemLogin.Text = "Continuar sem login";
            this.lblContinuarSemLogin.Click += new System.EventHandler(this.lblContinuarSemLogin_Click);
            // 
            // FrmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 578);
            this.Controls.Add(this.lblContinuarSemLogin);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.linkResetarSenha);
            this.Controls.Add(this.LinkInscrever);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLogin_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private controls.ModeloBotao btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkInscrever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkResetarSenha;
        private controls.novoTextBox txtUsuario;
        private controls.novoTextBox txtSenha;
        private controls.novoTextBox txtSenha2;
        private System.Windows.Forms.Label lblContinuarSemLogin;
    }
}
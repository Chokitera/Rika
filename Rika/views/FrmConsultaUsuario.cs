using Rika.controllers;
using Rika.models.Comum;
using Rika.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rika.dao;

namespace Rika.views
{
    public partial class FrmConsultaUsuario : Form
    {
        private UsuarioController usuarioController;
        public FrmConsultaUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();  
        }

        #region Ajustes da Borda
        //Campos para alterar a borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(255, 255, 255);

        private GraphicsPath CriaBordaFormulario(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void AjustaBordaFormulario(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = CriaBordaFormulario(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            AjustaBordaFormulario(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        #region Ajustes da Parte Superior do Formulário e Adiciona Sombra no Formulário
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private const int SombraFormulario = 0x00020000;
        private const int EstiloFormulario = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = SombraFormulario; //Sombra do Formulário
                cp.Style = EstiloFormulario; //Minimizar a borda
                return cp;
            }
        }

        private void pnlArrastarFormulario_MouseDown_1(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region Botões/Ações

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Usuario usuario = new Usuario();

            //Atribuições
            if (txtCodUsuario.Text == "")
            {
                txtCodUsuario.Focus();
                MessageBox.Show("Não é possível cadastrar um usuário. Por favor, utilize a tela de cadastro!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new Helpers().LimparTela(this);
                AjustesLimpezaTela();
            }
            else
            {
                usuario.Id = int.Parse(txtCodUsuario.Text);
                usuario.Nome = txtNome.Text;
                usuario.SobreNome = txtSobrenome.Text;
                usuario.NomeUsuario = txtNomeUsuario.Text;
                if (cmbTipoUsuario.SelectedItem == "Administrador")
                    usuario.Tipo = 1;
                else
                    usuario.Tipo = 0;
                usuario.Senha = txtSenha.Text;
                usuario.ConfirmarSenha = txtSenha.Text;

                //Chamada do Controlador
                bool isValid = usuarioController.SalvaUsuario(usuario);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    AjustesLimpezaTela();
                    txtCodUsuario.Focus();
                }
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodUsuario.Text != "")
            {
                //Instancia do model
                Usuario usuario = new Usuario
                {
                    //Atribuições
                    Id = int.Parse(txtCodUsuario.Text)
                };

                //Chamada do Controlador
                bool isValid = usuarioController.Excluirusuario(usuario.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    AjustesLimpezaTela();
                    txtCodUsuario.Focus();
                }
            }
        }

        #endregion
  
        #region Eventos
        private void txtCodUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Evento Leave
        private void txtCodUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCodUsuario.Text != "")
            {
                //Instancia do model
                Usuario usuario = new Usuario
                {
                    //Atribuição
                    Id = int.Parse(txtCodUsuario.Text),
                };

                //Consulta
                usuario = usuarioController.ConsultausuarioPorId(usuario.Id);

                //Atribuição da consulta
                if (usuario.Nome != "")
                {
                    txtCodUsuario.Text = usuario.Id.ToString();
                    txtNome.Text = usuario.Nome;
                    txtSobrenome.Text = usuario.SobreNome;
                    if (usuario.Tipo == 0)
                        cmbTipoUsuario.SelectedItem = "Normal";
                    else
                        cmbTipoUsuario.SelectedItem = "Administrador";
                    txtNomeUsuario.Text = usuario.NomeUsuario;

                }
                else
                {
                    new Helpers().LimparTela(this);
                    AjustesLimpezaTela();
                    txtCodUsuario.Focus();
                }
            }
            else
            {
                new Helpers().LimparTela(this);
                AjustesLimpezaTela();
            }
        }
        #endregion

        #region Ajustes na limpeza da tela
        public void AjustesLimpezaTela()
        {
            txtSenha.Text = "12345678"; //Define sempre a senha padrão (somente visualização na tela)
            cmbTipoUsuario.SelectedIndex = -1; //Limpa o ComboBox
        }
        #endregion

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text != "") //Verifica se o nome de usuário já existe
            {
                Usuario usuario = new Usuario();

                usuario.NomeUsuario = txtNomeUsuario.Text;

                bool cadastroUsuario = usuarioController.VerificaNomeUsuario(usuario);

                if (cadastroUsuario)
                {
                    txtNomeUsuario.Focus(); //Se existir não deixa continuar
                }
            }
        }
    }
}

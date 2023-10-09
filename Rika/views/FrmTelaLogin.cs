using Rika.dao;
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

namespace Rika.views
{
    public partial class FrmTelaLogin : Form
    {
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

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            AjustaBordaFormulario(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        #region Ajustes da Parte Superior do Formulário
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Posibilidade de arrastar o formulário
        }
        #endregion

        public FrmTelaLogin(Usuario usuario)
        {
            InitializeComponent();
            if (usuario.NomeUsuario != null)
                txtUsuario.TextNew = usuario.NomeUsuario;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        #region Ajuste no Visual dos TextBoxs
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(28, 28, 28);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.ForeColor = Color.FromArgb(28, 28, 28);
                txtSenha.Focus();
                txtSenha2.Visible = false;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.ForeColor = Color.DimGray;
                txtSenha2.Visible = true;
            }
        }
        #endregion

        #region Realização do Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            EfetuarLogin(); //Irá tentar efetuar o login
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                EfetuarLogin(); //Irá tentar efetuar o login
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) //Se preessionou o Enter
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                btnLogin.Focus();
            }
        }

        public void EfetuarLogin()
        {
            //Instancia do model e atribuições
            Usuario usuario = new Usuario();

            usuario.NomeUsuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            //Instancia do dao
            UsuarioDAO dao = new UsuarioDAO();

            if (VerificaCampoVazioLogin(usuario))
            {
                bool login = dao.EfetuarLogin(usuario);

                if (login) //Se efetuou o login
                {
                    //Tela inicial
                }
                else
                    txtSenha.Focus();
            }
        }
        #endregion

        #region Método para verificar se existe campo não preenchido no login
        public bool VerificaCampoVazioLogin(Usuario usuario)
        {
            if (usuario.NomeUsuario == null || usuario.NomeUsuario == "Usuário")
            {
                MessageBox.Show("Necessário preencher o campo Usuário!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (usuario.Senha == null || usuario.Senha == "Senha")
            {
                MessageBox.Show("Necessário preencher o campo Senha!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            return true; //Se não caiu em nenhum if
        }
        #endregion

        #region Link para Inscrever-Se
        private void LinkInscrever_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmTelaPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmTelaPrincipal)qrForm.First()).ColocarFormNoPainel(new FrmCadastroUsuario());
            }
        }

        #endregion

    }
}

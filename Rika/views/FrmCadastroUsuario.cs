using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }
        private void txtNome_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }
        #region Link para Entrar no sistema
        private void linkEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).ColocarFormNoPainel(new FrmLogin());
            }
        }
        #endregion

        #region Ajustes nos eventos das boxes

        //Botão 'Nome'
        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.FromArgb(28, 28, 28);
            }
        }
        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.DimGray;
            }
        }

        //Botão 'Sobrenome'
        private void txtSobrenome_Enter(object sender, EventArgs e)
        {
            if (txtSobrenome.Text == "Sobrenome")
            {
                txtSobrenome.Text = "";
                txtSobrenome.ForeColor = Color.FromArgb(28, 28, 28);
            }
        }
        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            if (txtSobrenome.Text == "")
            {
                txtSobrenome.Text = "Sobrenome";
                txtSobrenome.ForeColor = Color.DimGray;
            }
        }

        //Botão 'Usuário'
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
            if ( txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        //Botão 'Senha'
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha2.Visible = false;
                txtSenha.ForeColor = Color.FromArgb(28, 28,28);
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

        //Botão 'Confirmar Senha'
        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "")
            {
                txtConfimarSenha2.Visible = false;
                txtConfirmarSenha.ForeColor = Color.FromArgb(28, 28, 28);
            }
        }
        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "")
            {
                txtConfimarSenha2.Visible = true;
                txtConfirmarSenha.ForeColor = Color.DimGray;
            }
        }
        #endregion

        #region Dados enviados ao banco

        #endregion

       
    }
}


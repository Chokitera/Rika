using Rika.controllers;
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
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();

            usuarioController = new UsuarioController();
        }
        private void txtNome_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        #region Link para Entrar no sistema
        private void linkEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmTelaPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                Usuario usuario = new Usuario();
                ((FrmTelaPrincipal)qrForm.First()).ColocarFormNoPainel(new FrmTelaLogin(usuario));
            }
        }
        #endregion

        #region Ajustes nos eventos das boxes (enter e leave)

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
            if (txtUsuario.Text != "") //Verifica se o nome de usuário já existe
            {
                Usuario usuario = new Usuario();

                usuario.NomeUsuario = txtUsuario.Text;

                bool cadastroUsuario = usuarioController.VerificaNomeUsuario(usuario);

                if (cadastroUsuario)
                {
                    txtUsuario.Focus(); //Se existir não deixa continuar
                }
            }
        }

        //Botão 'Senha'
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha2.Visible = false;
                txtSenha.Focus();
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
                txtConfirmarSenha.Focus();
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

        #region Efetuar Cadastro

        private void btnCriaConta_Click(object sender, EventArgs e)
        {
            EfetuarCadastro(); //Efetua o cadastro
        }

        private void btnCriaConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //13 == enter
            {
                EfetuarCadastro();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                txtSobrenome.Focus();
            }
        }
        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                txtUsuario.Focus();
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                txtSenha.Focus();
            }
        }
        private void txtSenha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                txtConfirmarSenha.Focus();
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                txtConfirmarSenha.Focus();
            }
        }
        private void txtConfimarSenha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                btnCriaConta.Focus();
            }
        }
        private void txtConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Se preessionou o Enter
            {
                btnCriaConta.Focus();
            }
        }
        public void EfetuarCadastro()
        {
            //Instancia do model e atribuições
            Usuario usuario = new Usuario();

            if (txtNome.Text == "Nome")
                txtNome.Text = "";
            else
                usuario.Nome = txtNome.Text;
            if (txtSobrenome.Text == "Sobrenome")
                usuario.SobreNome = "";
            else
                usuario.SobreNome = txtSobrenome.Text;
            if (txtUsuario.Text == "Usuário")
                usuario.NomeUsuario = "";
            else
                usuario.NomeUsuario = txtUsuario.Text;
            if (txtSenha.Text == "Senha")
                usuario.Senha = "";
            else
                usuario.Senha = txtSenha.Text;
            usuario.ConfirmarSenha = txtConfirmarSenha.Text;

            if (VerificarSenhas(usuario))
            {
                //Chamada do Controlador
                bool isValid = usuarioController.SalvaUsuario(usuario);

                if (isValid) // Se efetuou o cadastro
                {
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                    where frm is FrmTelaPrincipal
                                    select frm;

                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((FrmTelaPrincipal)qrForm.First()).ColocarFormNoPainel(new FrmTelaLogin(usuario));
                    }
                }
            }
            else
                txtNome.Focus();
        }
        #endregion

        #region Verifica se confirmar senha é igual a senha

        public bool VerificarSenhas(Usuario usuario)
        {
            if(usuario.Senha.Length < 8) //Verifica se a senha possue 8 caracteres
            {
                MessageBox.Show("A senha precisa ter no mínimo 8 caracteres! Tente novamente", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            if(usuario.Senha != usuario.ConfirmarSenha) // Verifica se a senha é igual a confirmar senha
            {
                MessageBox.Show("As senhas não coincidem! Tente novamente", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return false;
            }
            return true;
        }

        #endregion
    }
}

﻿using Rika.models;
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

        #region Validar o cadastro

        public bool VerificaCampoVazioCadastro(Usuario usuario)
        {
            if (usuario.Nome == null || usuario.Nome == "Nome")
            {
                MessageBox.Show("Necessário preencher o campo Nome!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            if (usuario.SobreNome == null || usuario.SobreNome == "Sobrenome")
            {
                MessageBox.Show("Necessário preencher o campo Sobrenome!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSobrenome.Focus();
                return false;
            }
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
            if (usuario.NomeUsuario == null || usuario.NomeUsuario == "Confirmar Senha")
            {
                MessageBox.Show("Necessário preencher o campo Confirmar Senha!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarSenha.Focus();
                return false;
            }
            return true;
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

        }
        #endregion
    }
}


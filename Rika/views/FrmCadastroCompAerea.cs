using Rika.controllers;
using Rika.models;
using Rika.models.Comum;
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
    public partial class FrmCadastroCompAerea : Form
    {
        private CompAereaController CompAereaController; //Controlador
        public FrmCadastroCompAerea()
        {
            InitializeComponent();
            txtCodigo.Focus();

            CompAereaController = new CompAereaController();
        }

        #region Evento/Ações dos Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            CompanhiaAerea companhiaAerea = new CompanhiaAerea();

            //Atribuições
            if (txtCodigo.Text == "")
                companhiaAerea.Id = 0;
            else
                companhiaAerea.Id = int.Parse(txtCodigo.Text);
            companhiaAerea.Nome = txtNome.Text;
            companhiaAerea.Descricao = txtDescricao.Text;
            companhiaAerea.Inscricao = txtInscricao.Text;

            //Chamada do Controlador
            bool isValid = CompAereaController.SalvaCompanhia(companhiaAerea);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodigo.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                //Instancia do model
                CompanhiaAerea companhiaAerea = new CompanhiaAerea
                {
                    //Atribuições
                    Id = int.Parse(txtCodigo.Text)
                };

                //Chamada do Controlador
                bool isValid = CompAereaController.ExcluirCompanhia(companhiaAerea.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtCodigo.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "")
            {
                //Instancia do model
                CompanhiaAerea companhiaAerea = new CompanhiaAerea
                {
                    //Atribuição
                    Id = int.Parse(txtCodigo.Text),
                };

                //Consulta
                companhiaAerea = CompAereaController.ConsultaCompanhiaPorId(companhiaAerea.Id);

                //Atribuição da consulta
                if (companhiaAerea.Nome != "")
                {
                    txtCodigo.Text = companhiaAerea.Id.ToString();
                    txtNome.Text = companhiaAerea.Nome;
                    txtInscricao.Text = companhiaAerea.Inscricao;
                    txtDescricao.Text = companhiaAerea.Descricao;
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodigo.Focus();
                }
            }
        }
        #endregion
    }
}

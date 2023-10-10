using Rika.controllers;
using Rika.models.Comum;
using Rika.models;
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
    public partial class FrmCadastroClasse : Form
    {
        private ClasseController classeController;
        public FrmCadastroClasse()
        {
            InitializeComponent();

            classeController = new ClasseController();
        }

        #region Evento/Ações dos Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Classe classe = new Classe();

            //Atribuições
            if (txtCodClasse.Text == "")
                classe.Id = 0;
            else
                classe.Id = int.Parse(txtCodClasse.Text);
            classe.Nome = txtNome.Text;
            classe.Descricao = txtDescricao.Text;

            //Chamada do Controlador
            bool isValid = classeController.SalvaClasse(classe);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodClasse.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodClasse.Text != "")
            {
                //Instancia do model
                Classe classe = new Classe
                {
                    //Atribuições
                    Id = int.Parse(txtCodClasse.Text)
                };

                //Chamada do Controlador
                bool isValid = classeController.ExcluirClasse(classe.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtCodClasse.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        private void txtCodClasse_Leave(object sender, EventArgs e)
        {
            if (txtCodClasse.Text != "")
            {
                //Instancia do model
                Classe classe = new Classe
                {
                    //Atribuição
                    Id = int.Parse(txtCodClasse.Text),
                };

                //Consulta
                classe = classeController.ConsultaClassePorId(classe.Id);

                //Atribuição da consulta
                if (classe.Nome != "")
                {
                    txtCodClasse.Text = classe.Id.ToString();
                    txtNome.Text = classe.Nome;
                    txtDescricao.Text = classe.Descricao;
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodClasse.Focus();
                }
            }
            else
                new Helpers().LimparTela(this);
        }
        #endregion
    }
}

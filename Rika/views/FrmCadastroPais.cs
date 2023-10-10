using Rika.controllers;
using Rika.dao;
using Rika.models;
using Rika.models.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCadastroPais : Form
    {
        private PaisController paisController;
        public FrmCadastroPais()
        {
            InitializeComponent();

            paisController = new PaisController();
        }

        #region Evento/Ações dos Botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Pais pais = new Pais();

            //Atribuições
            if (txtIdPais.Text == "")
                pais.Id = 0;
            else
                pais.Id = int.Parse(txtIdPais.Text);
            pais.Nome = txtNomePais.Text;
            pais.Sigla = txtSiglaPais.Text;

            //Chamada do Controlador
            bool isValid = paisController.SalvaPais(pais);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtIdPais.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdPais.Text != "")
            {
                //Instancia do model
                Pais pais = new Pais
                {
                    //Atribuições
                    Id = int.Parse(txtIdPais.Text)
                };

                //Chamada do Controlador
                bool isValid = paisController.ExcluirPais(pais.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtIdPais.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        //FAZER
        #endregion
    }
}

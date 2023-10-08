    using Rika.dao;
using Rika.models;
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
        public FrmCadastroPais()
        {
            InitializeComponent();
        }

        #region Efetuar cadastro país
        public void EfetuarCadastroPais()
        {
            //Instanciar o model e atribuir valores
            Pais pais = new Pais();

            pais.Nome = txtNomePais.Text;
            pais.Sigla = txtSiglaPais.Text;

            //Instanciar DAO
            PaisDAO dao = new PaisDAO();

            if (VerificaCampoVazio(pais))
            {
                bool cadastro = dao.EfetuarCadastroPais(pais);

                if (cadastro) { } //Cadastro feito
                
            } 

        }
        #endregion

        #region Verificar campos vazios

        public bool VerificaCampoVazio(Pais pais)
        {
            if (pais.Nome == null || pais.Nome == "")
            {
                MessageBox.Show("Necessário preencher o campo Nome!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomePais.Focus();
                return false;
            }
            if (pais.Sigla == "")
            {
                MessageBox.Show("Necessário preencher o campo Sigla!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiglaPais.Focus();
                return false;
            }
            //if (pais.Id == null)
            //{
            //    MessageBox.Show("Necessário preencher o campo!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNomePais.Focus();
            //    return false;
            //}
            return true;
        }

        #endregion

        #region Excluir país da tabela

        public void ExcluirPais()
        {
            //Instanciar o model e atribuir os valores
            Pais pais = new Pais();

            PaisDAO dao = new PaisDAO();

            bool exclusao = dao.ExcluirPais(pais);

            if (exclusao) 
            {

            }   
        }

        #endregion

        #region



        #endregion

        #region Ações dos botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EfetuarCadastroPais();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdPais.TextNew != "")
            {
                ExcluirPais();
            }
            else
                MessageBox.Show("O campo Código não pode estar vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

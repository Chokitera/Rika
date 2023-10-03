using Rika.dao;
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
    public partial class FrmCadastroCompAerea : Form
    {
        public FrmCadastroCompAerea()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroCompanhiaAerea();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cadastro de Companhia Aerea
        public void CadastroCompanhiaAerea() {
            //Instancia do Model

            CompanhiaAerea compaerea = new CompanhiaAerea();
            
            compaerea.Nome = txtNome.Text;

            compaerea.Descricao = txtDescricao.Text;

            compaerea.Inscricao = txtInscricao.Text;

            if (VerificaCampoBranco(compaerea)) {
                //Instanica do DAO
                CompanhiaAereaDAO companhiaAereaDAO = new CompanhiaAereaDAO();
                companhiaAereaDAO.efetuarCadastro(compaerea);
            }
        }
        #endregion

        #region Verificar campos em branco

        public bool VerificaCampoBranco(CompanhiaAerea compaerea) {
            if (compaerea.Nome == "" || compaerea.Nome == null)
            {
                MessageBox.Show("Necessário preencher o campo Nome!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (compaerea.Inscricao == "" || compaerea.Inscricao == null)
            {
                MessageBox.Show("Necessário preencher o campo Inscrição!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInscricao.Focus();
                return false;
            }

            if (compaerea.Descricao == "" || compaerea.Descricao == null)
            {
                MessageBox.Show("Necessário preencher o campo Descrição!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }
            return true;
        }

        #endregion
    }
}

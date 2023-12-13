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
    public partial class FrmMenuConsultas : Form
    {
        public FrmMenuConsultas()
        {
            InitializeComponent();
        }

        #region Acesso aos Menus
        private void menuConAeroporto_Click(object sender, EventArgs e)
        {
            FrmConsultaAeroporto tela = new FrmConsultaAeroporto();
            tela.ShowDialog();
        }

        private void menuConAviao_Click(object sender, EventArgs e)
        {
            FrmConsultaAviao tela = new FrmConsultaAviao();
            tela.ShowDialog();
        }

        private void menuConClasse_Click(object sender, EventArgs e)
        {
            FrmConsultaClasse tela = new FrmConsultaClasse();
            tela.ShowDialog();
        }

        private void menuConCompAerea_Click(object sender, EventArgs e)
        {
            FrmConsultaCompAerea tela = new FrmConsultaCompAerea();
            tela.ShowDialog();
        }

        private void menuConPais_Click(object sender, EventArgs e)
        {
            FrmConsultaPais tela = new FrmConsultaPais();
            tela.ShowDialog();
        }

        private void menuConPassagem_Click(object sender, EventArgs e)
        {
            FrmConsultaPassagem tela = new FrmConsultaPassagem();
            tela.ShowDialog();
        }

        private void menuConSituacao_Click(object sender, EventArgs e)
        {
            FrmConsultaSituacao tela = new FrmConsultaSituacao();
            tela.ShowDialog();
        }

        private void menuConTipoVenda_Click(object sender, EventArgs e)
        {
            FrmConsultaTipoVenda tela = new FrmConsultaTipoVenda();
            tela.ShowDialog();
        }

        private void menuConTitulo_Click(object sender, EventArgs e)
        {
            FrmConsultaTitulos tela = new FrmConsultaTitulos();
            tela.ShowDialog();
        }

        private void menuConEndereco_Click(object sender, EventArgs e)
        {
            FrmConsultaEndereco tela = new FrmConsultaEndereco();
            tela.ShowDialog();
        }

        private void menuConVoo_Click(object sender, EventArgs e)
        {
            FrmConsultaVoo tela = new FrmConsultaVoo();
            tela.ShowDialog();
        }

        private void menuConUsuario_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuario tela = new FrmConsultaUsuario();
            tela.ShowDialog();
        }
        #endregion
    }
}

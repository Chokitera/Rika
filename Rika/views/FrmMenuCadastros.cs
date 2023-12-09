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
    public partial class FrmMenuCadastros : Form
    {
        public FrmMenuCadastros()
        {
            InitializeComponent();
        }

        #region Acesso aos Menus
        private void menuCadAeroporto_Click(object sender, EventArgs e)
        {
            FrmCadastroAeroporto tela = new FrmCadastroAeroporto();
            tela.ShowDialog();
        }

        private void menuCadAviao_Click(object sender, EventArgs e)
        {
            FrmCadastroAviao tela = new FrmCadastroAviao();
            tela.ShowDialog();
        }

        private void menuCadClasse_Click(object sender, EventArgs e)
        {
            FrmCadastroClasse tela = new FrmCadastroClasse();
            tela.ShowDialog();
        }

        private void menuCadCompAerea_Click(object sender, EventArgs e)
        {
            FrmCadastroCompAerea tela = new FrmCadastroCompAerea();
            tela.ShowDialog();
        }

        private void menuCadPais_Click(object sender, EventArgs e)
        {
            FrmCadastroPais tela = new FrmCadastroPais();
            tela.ShowDialog();
        }

        private void menuCadPassagem_Click(object sender, EventArgs e)
        {
            FrmCadastroPassagem tela = new FrmCadastroPassagem();
            tela.ShowDialog();
        }

        private void menuCadSituacao_Click(object sender, EventArgs e)
        {
            FrmCadastroSituacao tela = new FrmCadastroSituacao();
            tela.ShowDialog();
        }

        private void menuCadTipoVenda_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoVenda tela = new FrmCadastroTipoVenda();
            tela.ShowDialog();
        }

        private void menuCadTitulo_Click(object sender, EventArgs e)
        {
            FrmCadastroTitulo tela = new FrmCadastroTitulo();
            tela.ShowDialog();
        }

        private void menuCadEndereco_Click(object sender, EventArgs e)
        {
            FrmCadastroEndereco tela = new FrmCadastroEndereco();
            tela.ShowDialog();
        }

        private void menuCadVoo_Click(object sender, EventArgs e)
        {
            FrmCadastroVoo tela = new FrmCadastroVoo();
            tela.ShowDialog();
        }
        #endregion
    }
}

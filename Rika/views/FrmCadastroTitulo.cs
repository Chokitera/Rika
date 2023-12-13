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
    public partial class FrmCadastroTitulo : Form
    {
        public FrmCadastroTitulo()
        {
            InitializeComponent();
        }

        #region Evento/Ações dos Botões
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        private void txtCodTitulo_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Evento Passagem Leave
        private void txtCodPassagem_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Evento Tipo de Venda Leave
        private void txtCodTipoVenda_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validações
        private void txtCodTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Tratado
            }
        }
        #endregion
    }
}

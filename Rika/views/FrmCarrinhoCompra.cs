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
    public partial class FrmCarrinhoCompra : Form
    {
        public FrmCarrinhoCompra()
        {
            InitializeComponent();
        }

        private void FrmCarrinhoCompra_Load(object sender, EventArgs e)
        {
            //Inicialização

            //Botão de desconto inativado
            btnAplicarCupom.BackColor = Color.DarkGray;
            btnAplicarCupom.Enabled = false;
        }

        #region Eventos de Ajuste no Menu do Carrinho
        private void txtCupomDesconto_Enter(object sender, EventArgs e)
        {
            if (txtCupomDesconto.TextNew == "Cupom de Desconto") //Limpar o campo
            {
                txtCupomDesconto.TextNew = "";
            }
        }

        private void txtCupomDesconto_Leave(object sender, EventArgs e)
        {
            if (txtCupomDesconto.TextNew == "") //Recolocar o valor no campo
            {
                txtCupomDesconto.TextNew = "Cupom de Desconto";
            }
        }

        private void txtCupomDesconto__TextChanged_1(object sender, EventArgs e)
        {
            if (txtCupomDesconto.TextNew.Length <= 0)
            {
                btnAplicarCupom.BackColor = Color.DarkGray;
                btnAplicarCupom.Enabled = false;
            }
            else
            {
                btnAplicarCupom.BackColor = Color.MediumSlateBlue;
                btnAplicarCupom.Enabled = true;
            }
        }
        #endregion
    }
}

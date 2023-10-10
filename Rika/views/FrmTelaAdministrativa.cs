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
    public partial class FrmTelaAdministrativa : Form
    {
        public FrmTelaAdministrativa()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FrmCadastroPassagem tela = new FrmCadastroPassagem();
            tela.ShowDialog();
        }
    }
}

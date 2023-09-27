using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rika.models;

namespace Rika.views
{
    public partial class FrmVoo : Form
    {
        public FrmVoo()
        {
            InitializeComponent();
        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instânciando a classe Voo
            Voo voo = new Voo();
            voo.Id = int.Parse(txtCodVoo.Text);
            voo.Destino = int.Parse(txtDestino.Text);
            voo.Decolagem = int.Parse(txtDecolagem.Text);
            voo.DataSaida = DateTime.Parse(txtDataSaida.Text);
            voo.DataChegada = DateTime.Parse(txtDataChegada.Text);
            voo.Duracao = DateTime.Parse(txtDuracao.Text);
            voo.HorarioSaida = DateTime.Parse(txtHoraSaida.Text);
            voo.HorarioChegada = DateTime.Parse(txtHoraChegada.Text);
            voo.Cod_Aviao.Id = int.Parse(txtAviao.Text);
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha o objeto(TELA) inteira
            this.Close();
        }
    }
}

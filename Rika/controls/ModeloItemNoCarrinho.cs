using Rika.controllers;
using Rika.models;
using Rika.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.controls
{
    public partial class ModeloItemNoCarrinho : UserControl
    {
        private CarrinhoCompraController carrinhoController;
        public ModeloItemNoCarrinho()
        {
            InitializeComponent();

            carrinhoController = new CarrinhoCompraController();
        }

        private void ModeloItemNoCarrinho_Load(object sender, EventArgs e)
        {
            CalculaValorItem(); //Calcula o valor do item (valor * quantidade) ** Precisa ficar no Load, assim já foi inicializado os valores e é possível fazer o cálculo
        }
        private int _idCarrinho;

        public int IdCarrinho
        {
            get { return _idCarrinho; }
            set { _idCarrinho = value; }
        }

        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private DateTime _dtAdicao;

        public DateTime DataAdicao
        {
            get { return _dtAdicao; }
            set { _dtAdicao = value; }
        }

        private int _codPass;

        public int CodPass
        {
            get { return _codPass; }
            set { _codPass = value; }
        }

        private string _caminhoImg;

        public string CaminhoImg
        {
            get { return _caminhoImg; }
            set { _caminhoImg = value; ptbImagemPassagem.Image = Image.FromFile(value); }
        }

        private double _valor;

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }


        private string _valorInformativo;

        public string ValorInformativo
        {
            get { return _valorInformativo; }
            set { _valorInformativo = value; txtValorPassagem.Text = value; }
        }

        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; txtNomePassagem.Text = value; }
        }

        private string _idaVolta;

        public string IdaVolta
        {
            get { return _idaVolta; }
            set { _idaVolta = value; lblTipoPassagem.Text = value; }
        }

        private string _data;

        public string Data
        {
            get { return _data; }
            set { _data = value; lblData.Text = value; }
        }

        private string _saida;

        public string Saida
        {
            get { return _saida; }
            set { _saida = value; lblSaida.Text = value; }
        }

        private string _chegada;

        public string Chegada
        {
            get { return _chegada; }
            set { _chegada = value; lblChegada.Text = value; }
        }

        private string _quantidade;

        public string Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; btnQuantidade.Text = value; }
        }

        private double _valorItem;
        public double ValorItem
        {
            get { return _valorItem; }
            set { _valorItem = value; }
        }

        private int quantidade;

        #region Botões principais
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (btnQuantidade.Text != string.Empty)
            {
                if (int.Parse(btnQuantidade.Text) > 1)
                {
                    quantidade = int.Parse(btnQuantidade.Text);
                    quantidade -= 1;

                    btnQuantidade.Text = quantidade.ToString();

                    CalculaValorItem(); //Calcula o novo valor do item

                    //Atualiza a quantidade no BD
                    AtualizarCarrinho();

                    //Atualiza o totalizador do carrinho
                    AtualizaTotalizadorCarrinho();
                }
            }
            else
                btnQuantidade.Text = "1";
        }


        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (btnQuantidade.Text != string.Empty)
            {
                quantidade = int.Parse(btnQuantidade.Text);
                quantidade += 1;

                btnQuantidade.Text = quantidade.ToString();

                CalculaValorItem(); //Calcula o novo valor do item

                //Atualiza a quantidade no BD
                AtualizarCarrinho();

                //Atualiza o totalizador do carrinho
                AtualizaTotalizadorCarrinho();
            }
            else
                btnQuantidade.Text = "1";
        }

        private void lblRemover_Click(object sender, EventArgs e)
        {
            //Elimina o item do carrinho
            DialogResult result = MessageBox.Show("Você deseja Excluir o Item do Carrinho?", "RIKA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Exclui o item do carrinho
                bool exclusao = carrinhoController.ExcluirCarrinhoCompra(IdCarrinho);

                if (exclusao) //Se excluiu
                {
                    //Atualiza a tela?
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is FrmCarrinhoCompra
                                 select frm;

                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((FrmCarrinhoCompra)qrForm.First()).CarregarCarrinhoCompra();
                    }
                }
            }
        }
        #endregion

        #region Calcula Valor do Item
        public void CalculaValorItem()
        {
            double valorAux;
            if (quantidade == 0 && _quantidade != null)
                quantidade = int.Parse(_quantidade);

            valorAux = (_valor + 0.99) * quantidade;

            _valorItem = valorAux;
            ValorInformativo = "R$" + valorAux.ToString().Replace(".", ",");
        }
        #endregion

        #region Atualizar o Carrinho - Quantidade
        public CarrinhoCompra AtualizarCarrinho()
        {
            //Preenche o model
            CarrinhoCompra carrinhoCompra = new CarrinhoCompra();
            carrinhoCompra.Id = IdCarrinho;
            carrinhoCompra.Quantidade = int.Parse(btnQuantidade.Text);

            //Atualiza a quantidade do itens no carrinho de compras
            carrinhoController.AtualizarQuantidadeCarrinhoCompra(carrinhoCompra);

            return carrinhoCompra;
        }
        #endregion

        #region Atualizar o Totalizador do Carrinho de Compra
        public void AtualizaTotalizadorCarrinho()
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmCarrinhoCompra
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmCarrinhoCompra)qrForm.First()).AtualizaTotalizador();
            }
        }
        #endregion

        private void btnComprarAgora_Click(object sender, EventArgs e)
        {
            //Gerar o(os) título


            //Limpar o item do carrinho


            //Chama a tela de compra finalizada
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmCarrinhoCompra
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmCarrinhoCompra)qrForm.First()).CompraFinalizada();
            }
        }
    }
}

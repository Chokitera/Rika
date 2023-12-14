using Rika.controllers;
using Rika.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCarrinhoCompra : Form
    {
        private CarrinhoCompraController carrinhoController;
        public FrmCarrinhoCompra()
        {
            InitializeComponent();

            carrinhoController = new CarrinhoCompraController();

            CarregarCarrinhoCompra(); //Carregar os itens do carrinho ao inicializar
        }
        #region Ajustes da Borda
        //Campos para alterar a borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(255, 255, 255);

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void FrmCarrinhoCompra_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        #region Ajustes da Parte Superior do Formulário e Adiciona Sombra no Formulário
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private const int SombraFormulario = 0x00020000;
        private const int EstiloFormulario = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = SombraFormulario; //Sombra do Formulário
                cp.Style = EstiloFormulario; //Minimizar a borda
                return cp;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botões/Ações
        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void FrmCarrinhoCompra_Load(object sender, EventArgs e)
        {
            //Inicialização
            AtualizaTotalizador(); //Atualiza o Totalizador na inicilização da tela

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

        #region Botões laterais
        private void btnComprarAgora_Click(object sender, EventArgs e)
        {
            CompraFinalizada();
        }

        private void btnVoltarCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para carregar o carrinho de compras
        public void CarregarCarrinhoCompra()
        {
            //Limpa o FlowPanel + inicialização
            DateTime dataAux;
            flpItens.Controls.Clear();
            DataTable dataTable = new DataTable();

            //Chama o controlador e preenche o dataTable
            dataTable = carrinhoController.CarregarCarrinhoCompra();

            //////if (dataTable != null && dataTable.Rows.Count > 0) //Verifica se conseguiu encontrar registros
            //////{
            //////    controls.ModeloItemNoCarrinho[] itemCarrinho = new controls.ModeloItemNoCarrinho[dataTable.Rows.Count + 1]; //Recebe a quantidade de linhas da consulta (DataTable)

            //////    foreach (DataRow row in dataTable.Rows) //Varre as linhas do DataTable (consulta)
            //////    {
            //////        //Inicializa o controle
            //////        itemCarrinho[0] = new controls.ModeloItemNoCarrinho();

            //////        //Atribui os registros da consulta no controle
            //////        //dataAux = DateTime.ParseExact(row["dt_adicao"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null); //Excluir item após 7 dias (não implementado)
            //////        itemCarrinho[0].IdCarrinho = int.Parse(row["idcarrinho"].ToString());
            //////        itemCarrinho[0].IdUsuario  = int.Parse(row["idusuario"].ToString());
            //////        itemCarrinho[0].DataAdicao = DateTime.ParseExact(row["dt_adicao"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
            //////        itemCarrinho[0].CodPass    = int.Parse(row["codpass"].ToString());
            //////        itemCarrinho[0].Titulo     = "Passagem para " + row["cidade"].ToString() ?? "";
            //////        dataAux = DateTime.ParseExact(row["datasaida"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
            //////        itemCarrinho[0].Data       = "      Data " + dataAux.ToString("dd/MM/yyyy") ?? "";
            //////        itemCarrinho[0].Saida      = "      Saída " + row["hor_sai"].ToString() ?? "";
            //////        itemCarrinho[0].Chegada    = "      Chegada " + row["hor_che"].ToString() ?? "";
            //////        itemCarrinho[0].CaminhoImg = row["caminho_img"].ToString() ?? "";
            //////        itemCarrinho[0].Quantidade = row["qtd_item"].ToString() ?? "";
            //////        itemCarrinho[0].IdaVolta   = "      Somente ida";
            //////        if (row["valor"].ToString() != "")
            //////            itemCarrinho[0].Valor  = double.Parse(row["valor"].ToString());
            //////        else
            //////            itemCarrinho[0].Valor  = 0;
            //////        itemCarrinho[0].ValorInformativo = "R$" + row["valor"].ToString() + ",99" ?? "";

            //////        flpItens.Controls.Add(itemCarrinho[0]);
            //////    }

            //////    AtualizaTotalizador();
            //////}
            ///

            if (dataTable != null && dataTable.Rows.Count > 0) //Verifica se conseguiu encontrar registros
            {
                controls.ModeloItemNoCarrinho[] itemCarrinho = new controls.ModeloItemNoCarrinho[dataTable.Rows.Count]; //Recebe a quantidade de linhas da consulta (DataTable)

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i]; //Inclui conforme quantidade de linhas
                   
                    //Inicializa o controle
                    itemCarrinho[0] = new controls.ModeloItemNoCarrinho();

                    //Atribui os registros da consulta no controle
                    //dataAux = DateTime.ParseExact(row["dt_adicao"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null); //Excluir item após 7 dias (não implementado)
                    itemCarrinho[0].IdCarrinho = int.Parse(row["idcarrinho"].ToString());
                    itemCarrinho[0].IdUsuario = int.Parse(row["idusuario"].ToString());
                    itemCarrinho[0].DataAdicao = DateTime.ParseExact(row["dt_adicao"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
                    itemCarrinho[0].CodPass = int.Parse(row["codpass"].ToString());
                    itemCarrinho[0].Titulo = "Passagem para " + row["cidade"].ToString() ?? "";
                    dataAux = DateTime.ParseExact(row["datasaida"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
                    itemCarrinho[0].Data = "      Data " + dataAux.ToString("dd/MM/yyyy") ?? "";
                    itemCarrinho[0].Saida = "      Saída " + row["hor_sai"].ToString() ?? "";
                    itemCarrinho[0].Chegada = "      Chegada " + row["hor_che"].ToString() ?? "";
                    itemCarrinho[0].CaminhoImg = row["caminho_img"].ToString() ?? "";
                    itemCarrinho[0].Quantidade = row["qtd_item"].ToString() ?? "";
                    itemCarrinho[0].IdaVolta = "      Somente ida";
                    if (row["valor"].ToString() != "")
                        itemCarrinho[0].Valor = double.Parse(row["valor"].ToString());
                    else
                        itemCarrinho[0].Valor = 0;
                    itemCarrinho[0].ValorInformativo = "R$" + row["valor"].ToString() + ",99" ?? "";

                    flpItens.Controls.Add(itemCarrinho[0]);
                }
                //Atualiza o Totalizador no final
                AtualizaTotalizador();
            }

        }
        #endregion

        #region Método para atualizar o totalizador
        public void AtualizaTotalizador()
        {
            //Inicialização
            double valorAux = 0;
            txtSubTotal.Text = "";
            txtTotalResumo.Text = "";
            txtTotalCarrinho.Text = "";

            //Varre os controles do Flow Panel
            foreach (Control controle in flpItens.Controls)
            {
                if(controle is ModeloItemNoCarrinho)
                {
                    valorAux += (controle as ModeloItemNoCarrinho).ValorItem;
                }
            }
            if(valorAux > 0)
            {
                txtSubTotal.Text = "R$ " + valorAux.ToString().Replace(".", ",");
                txtTotalResumo.Text = "R$ " + valorAux.ToString().Replace(".", ",");
                txtTotalCarrinho.Text = "R$ " + valorAux.ToString().Replace(".", ",");
            }
            else
            {
                txtSubTotal.Text = "R$ 0,00";
                txtTotalResumo.Text = "R$ 0,00";
                txtTotalCarrinho.Text = "R$ 0,00";
            }

        }
        #endregion

        #region Compra Finalizada
        public void CompraFinalizada()
        {
            //Gera o título


            //Limpar o carrinho (excluir tudo)


            //Chama a tela de compra finalizada
            FrmTelaCompraEfetuada tela = new FrmTelaCompraEfetuada();
            tela.ShowDialog();

            //Por fim fecha essa tela
            this.Close();
        }
        #endregion
    }
}

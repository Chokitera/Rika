using Rika.controllers;
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
    public partial class FrmTelaInicialSemLogin : Form
    {
        private PassagemController passagemController;
        public FrmTelaInicialSemLogin()
        {
            InitializeComponent();

            passagemController = new PassagemController();

            CarregarPassagensIniciais(); //Carrega as passagens iniciais
            CarregarPassagensMaisPopulares(); //Carrega as passagens mais populares
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

        private void FrmTelaInicial_Paint(object sender, PaintEventArgs e)
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

        private void pnlCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Cabeçalho página
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    #endregion

    private void modeloBotao3_Click(object sender, EventArgs e)
        {
            FrmCarrinhoCompra form = new FrmCarrinhoCompra();
            form.ShowDialog();
        }

        #region Método para Carregar as Passagens Aéreas Inicial
        public void CarregarPassagensIniciais()
        {
            //Limpa o FlowPanel + inicialização
            DateTime dataAux;
            flpInicial.Controls.Clear();
            DataTable dataTable = new DataTable();

            //Chama o controlador e preenche o dataTable
            dataTable = passagemController.CarregarPassagensIniciais();

            if (dataTable != null && dataTable.Rows.Count > 0) //Verifica se conseguiu encontrar registros
            {
                controls.PassagensAerea[] passagensAerea = new controls.PassagensAerea[dataTable.Rows.Count]; //Recebe a quantidade de linhas da consulta (DataTable)

                foreach (DataRow row in dataTable.Rows) //Varre as linhas do DataTable (consulta)
                {
                    //Inicializa o controle
                    passagensAerea[0] = new controls.PassagensAerea();

                    //Atribui os registros da consulta no controle
                    passagensAerea[0].CodPassagem = int.Parse(row["passagem"].ToString());
                    passagensAerea[0].ImagemPassagem = Image.FromFile(row["caminho_img"].ToString()) ?? null;
                    dataAux = DateTime.ParseExact(row["datasaida"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
                    passagensAerea[0].DataViagem = dataAux.ToString("dd/MM/yyyy") ?? "";
                    passagensAerea[0].Destino = row["cidade"].ToString() ?? "";
                    passagensAerea[0].Idavolta = "Somente Ida" ?? "";
                    passagensAerea[0].Classe = "Classe " + row["classe"].ToString() ?? "";
                    passagensAerea[0].Valor = "R$" + row["valor"].ToString() + ",99" ?? "";
                    passagensAerea[0].DiretoEscala = row["dir_esc"].ToString() ?? "";

                    flpInicial.Controls.Add(passagensAerea[0]);
                }
            }

        }
        #endregion

        #region Método para Carregar as Passagens Aéreas Mais Populares
        public void CarregarPassagensMaisPopulares()
        {
            //Limpa o FlowPanel + inicialização
            DateTime dataAux;
            flpMaisPopulares.Controls.Clear();
            DataTable dataTable = new DataTable();

            //Chama o controlador  e preenche o dataTable
            dataTable = passagemController.CarregarPassagensPopulares();

            if (dataTable != null && dataTable.Rows.Count > 0) //Verifica se conseguiu encontrar registros
            {
                controls.PassagensAerea[] passagensAerea = new controls.PassagensAerea[dataTable.Rows.Count]; //Recebe a quantidade de linhas da consulta (DataTable)

                foreach (DataRow row in dataTable.Rows) //Varre as linhas do DataTable (consulta)
                {
                    //Inicializa o controle
                    passagensAerea[0] = new controls.PassagensAerea();

                    //Atribui os registros da consulta no controle
                    passagensAerea[0].CodPassagem = int.Parse(row["passagem"].ToString());
                    passagensAerea[0].ImagemPassagem = Image.FromFile(row["caminho_img"].ToString()) ?? null;
                    dataAux = DateTime.ParseExact(row["datasaida"].ToString().Replace(" 12:00:00 AM", ""), "MM/dd/yyyy", null);
                    passagensAerea[0].DataViagem = dataAux.ToString("dd/MM/yyyy") ?? "";
                    passagensAerea[0].Destino = row["cidade"].ToString() ?? "";
                    passagensAerea[0].Idavolta = "Somente Ida" ?? "";
                    passagensAerea[0].Classe = "Classe " + row["classe"].ToString() ?? "";
                    passagensAerea[0].Valor = "R$" + row["valor"].ToString() + ",99" ?? "";
                    passagensAerea[0].DiretoEscala = row["dir_esc"].ToString() ?? "";

                    flpMaisPopulares.Controls.Add(passagensAerea[0]);
                }
            }
        }
        #endregion
    }
}

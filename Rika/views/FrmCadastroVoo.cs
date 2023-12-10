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
using Rika.controllers;
using Rika.models;
using Rika.models.Comum;

namespace Rika.views
{
    public partial class FrmCadastroVoo : Form
    {
        private VooController vooController;
        private AeroportoController aeroportoController;
        private AviaoController aviaoController;
        public FrmCadastroVoo()
        {
            InitializeComponent();

            vooController = new VooController();
            aeroportoController = new AeroportoController();
            aviaoController = new AviaoController();
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

        private void FrmCadastroVoo_Paint(object sender, PaintEventArgs e)
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

        #region Evento/Ações dos Botões
        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Voo voo = new Voo();

            //Atribuições
            if (txtCodVoo.Text == "")
                voo.Id = 0;
            else
                voo.Id = int.Parse(txtCodVoo.Text);
            if (txtCodAeroportoDecolagem.Text == "")
                voo.Decolagem = 0;
            else
                voo.Decolagem = int.Parse(txtCodAeroportoDecolagem.Text);
            if(txtCodAeroportoDestino.Text == "")
                voo.Destino = 0;
            else
                voo.Destino = int.Parse(txtCodAeroportoDestino.Text);
            if (txtCodAviao.Text == "")
                voo.aviao.Id = 0;
            else
                voo.aviao.Id = int.Parse(txtCodAviao.Text);
            if (txtDuracao.Text == "  :")
                voo.Duracao = null;
            else
                voo.Duracao = txtDuracao.Text;
            if (txtHoraSaida.Text == "  :")
                voo.HorarioSaida = null;
            else
                voo.HorarioSaida = txtHoraSaida.Text;
            if (txtHoraChegada.Text == "  :")
                voo.HorarioChegada = null;
            else
                voo.HorarioChegada = txtHoraChegada.Text;

            //Valida as datas preenchidas pelo usuário
            string msg = "";
            bool dataValida = ValidarDatas(txtDataSaida.Text);
            if (dataValida)
                voo.DataSaida = DateTime.ParseExact(txtDataSaida.Text, "dd/MM/yyyy", null);
            else
                msg += "Data de Saída inválida! Por favor, insira uma data válida." + "\n";

            dataValida = ValidarDatas(txtDataChegada.Text);
            if (dataValida)
                voo.DataChegada = DateTime.ParseExact(txtDataChegada.Text, "dd/MM/yyyy", null);
            else
                msg += "Data de Chegada inválida! Por favor, insira uma data válida." + "\n";

            //Verifica se existe erros para informar
            if (msg != "")
                MessageBox.Show(msg, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //Chamada do Controlador
                bool isValid = vooController.Salvavoo(voo);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    LimpaMaskedBox();
                    txtCodVoo.Focus();
                }
            }
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodVoo.Text != "")
            {
                //Instancia do model
                Voo voo = new Voo
                {
                    //Atribuições
                    Id = int.Parse(txtCodVoo.Text)
                };

                //Chamada do Controlador
                bool isValid = vooController.Excluirvoo(voo.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    LimpaMaskedBox();
                    txtCodVoo.Focus();
                }
            }
        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha o objeto(TELA) inteira
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            //Fecha o objeto(TELA) inteira
            this.Close();
        }

        #endregion

        #region Evento Código Leave
        private void txtCodVoo_Leave(object sender, EventArgs e)
        {
            if (txtCodVoo.Text != "")
            {
                //Instancia do model
                Aeroporto aeroportoDecolagem = new Aeroporto();
                Aeroporto aeroportoDestino = new Aeroporto();
                Aviao aviao = new Aviao();
                Voo voo = new Voo
                {
                    //Atribuição
                    Id = int.Parse(txtCodVoo.Text),
                };

                //Consulta
                voo = vooController.ConsultavooPorId(voo.Id);

                //Atribuição da consulta
                if (voo.Destino != 0)
                {
                    txtCodVoo.Text = voo.Id.ToString();
                    txtCodAeroportoDecolagem.Text = voo.Decolagem.ToString();
                    txtCodAeroportoDestino.Text = voo.Destino.ToString();
                    txtDataSaida.Text = voo.DataSaida.ToString("dd/MM/yyyy");
                    txtDataChegada.Text = voo.DataChegada.ToString("dd/MM/yyyy");
                    txtDuracao.Text = voo.Duracao.ToString();
                    txtHoraSaida.Text = voo.HorarioSaida.ToString();
                    txtHoraChegada.Text = voo.HorarioChegada.ToString();
                    txtCodAviao.Text = voo.aviao.Id.ToString();

                    //Atribui o nome do Aeroporto Decolagem a partir do código presente no BD
                    if (txtCodAeroportoDecolagem.Text != "")
                    {
                        aeroportoDecolagem = aeroportoController.ConsultaAeroportoPorId(voo.Decolagem);

                        if (aeroportoDecolagem.Nome != "")
                            txtAeroportoDecolagem.Text = aeroportoDecolagem.Nome;
                    }

                    //Atribui o nome do Aeroporto Destino a partir do código presente no BD
                    if (txtCodAeroportoDestino.Text != "")
                    {
                        aeroportoDestino = aeroportoController.ConsultaAeroportoPorId(voo.Destino);

                        if (aeroportoDestino.Nome != "")
                            txtAeroportoDestino.Text = aeroportoDestino.Nome;
                    }

                    //Atribui o nome do Avião a partir do código presente no BD
                    if (txtCodAviao.Text != "")
                    {
                        aviao = aviaoController.ConsultaAviaoPorId(voo.aviao.Id);

                        if (aviao.Modelo != "")
                            txtAviao.Text = aviao.Modelo;
                    }
                }
                else
                {
                    new Helpers().LimparTela(this);
                    LimpaMaskedBox();
                    txtCodVoo.Focus();
                }
            }
            else
            {
                new Helpers().LimparTela(this);
                LimpaMaskedBox();
            }
        }

        #endregion

        #region Evento Aeroporto Decolagem Leave
        private void txtCodAeroportoDecolagem_Leave(object sender, EventArgs e)
        {
            if (txtCodAeroportoDecolagem.Text != "")
            {
                //Instancia do Model
                Aeroporto aeroporto = new Aeroporto
                {
                    Id = int.Parse(txtCodAeroportoDecolagem.Text)
                };

                //Chamada do Controlador
                aeroporto = aeroportoController.ConsultaAeroportoPorId(aeroporto.Id);

                //Atribuições da Consulta
                if (aeroporto.Nome != "")
                    txtAeroportoDecolagem.Text = aeroporto.Nome;
                else
                {
                    txtCodAeroportoDecolagem.Text = "";
                    txtAeroportoDecolagem.Text = "";
                    txtCodAeroportoDecolagem.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código do Aeroporto Decolagem não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAeroportoDecolagem.Text = "";
                txtCodAeroportoDecolagem.Focus();
            }
        }
        #endregion

        #region Evento Aeroporto Destino Leave
        private void txtCodAeroportoDestino_Leave(object sender, EventArgs e)
        {
            if (txtCodAeroportoDestino.Text != "")
            {
                //Instancia do Model
                Aeroporto aeroporto = new Aeroporto
                {
                    Id = int.Parse(txtCodAeroportoDestino.Text)
                };

                //Chamada do Controlador
                aeroporto = aeroportoController.ConsultaAeroportoPorId(aeroporto.Id);

                //Atribuições da Consulta
                if (aeroporto.Nome != "")
                    txtAeroportoDestino.Text = aeroporto.Nome;
                else
                {
                    txtCodAeroportoDestino.Text = "";
                    txtAeroportoDestino.Text = "";
                    txtCodAeroportoDestino.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código do Aeroporto Destino não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAeroportoDestino.Text = "";
                txtCodAeroportoDestino.Focus();
            }
        }
        #endregion

        #region Evento Avião Leave
        private void txtCodAviao_Leave(object sender, EventArgs e)
        {
            if (txtCodAviao.Text != "")
            {
                //Instancia do Model
                Aviao aviao = new Aviao
                {
                    Id = int.Parse(txtCodAviao.Text)
                };

                //Chamada do Controlador
                aviao = aviaoController.ConsultaAviaoPorId(aviao.Id);

                //Atribuições da Consulta
                if (aviao.Modelo != "")
                    txtAviao.Text = aviao.Modelo;
                else
                {
                    txtCodAviao.Text = "";
                    txtAviao.Text = "";
                    txtCodAviao.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código do Avião não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAviao.Text = "";
                txtCodAviao.Focus();
            }
        }
        #endregion

        #region Limpar MaskedBox
        public void LimpaMaskedBox()
        {
            txtDuracao.Text = "";
            txtHoraChegada.Text = "";
            txtHoraSaida.Text = "";
            txtDataSaida.Text = "";
            txtDataChegada.Text = "";
        }
        #endregion

        #region Validações
        private void txtCodVoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #region Metódo para Validar Datas
        public bool ValidarDatas(string data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data))
                {
                    if (DateTime.TryParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)) //Não tem uma saída, pois vai ser atribuido a partir da entrada do usuário
                    {
                        return true; //Conversão deu certo
                    }
                    else
                        return false; //Deu errado
                }
                else
                    return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        #endregion
        #endregion
    }
}

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
        public FrmCadastroVoo()
        {
            InitializeComponent();

            vooController = new VooController();
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
            voo.Decolagem = int.Parse(txtCodAeroportoDecolagem.Text);
            voo.Destino = int.Parse(txtCodAeroportoDestino.Text);
            voo.DataSaida = Convert.ToDateTime(txtDataSaida.Text);
            voo.DataChegada = Convert.ToDateTime(txtDataChegada.Text);
            voo.Duracao = Convert.ToDateTime(txtDuracao.Text);
            voo.HorarioSaida = Convert.ToDateTime(txtHoraSaida.Text);
            voo.HorarioChegada = Convert.ToDateTime(txtHoraChegada.Text);
            voo.aviao.Id = int.Parse(txtCodAviao.Text);

            //Chamada do Controlador
            bool isValid = vooController.Salvavoo(voo);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodVoo.Focus();
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
                Voo voo = new Voo
                {
                    //Atribuição
                    Id = int.Parse(txtCodVoo.Text),
                };

                //Consulta
                voo = vooController.ConsultavooPorId(voo.Id);

                //Atribuição da consulta
                if (voo.Decolagem != 0)
                {
                    txtCodVoo.Text = voo.Id.ToString();
                    txtCodAeroportoDecolagem.Text = voo.Decolagem.ToString();
                    txtCodAeroportoDestino.Text = voo.Destino.ToString();
                    txtDataSaida.Text = voo.DataSaida.ToString();
                    txtDataChegada.Text = voo.DataChegada.ToString();
                    txtDuracao.Text = voo.Duracao.ToString();
                    txtHoraSaida.Text = voo.HorarioSaida.ToString();
                    txtHoraChegada.Text = voo.HorarioChegada.ToString();
                    txtCodAviao.Text = voo.aviao.Id.ToString();
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodVoo.Focus();
                }
            }
        }
        #endregion


    }
}

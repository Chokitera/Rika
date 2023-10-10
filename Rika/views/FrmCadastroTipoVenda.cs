using Rika.controllers;
using Rika.models.Comum;
using Rika.models;
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
    public partial class FrmCadastroTipoVenda : Form
    {
        private TipoVendaController tipoVendaController;
        public FrmCadastroTipoVenda()
        {
            InitializeComponent();

            tipoVendaController = new TipoVendaController();
        }

        #region Cabeçalho / funções

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
        private void pnlArrastarFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Botões cabeçalho
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

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
        private void FrmCadastroTipoVenda_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        #endregion

        #region Botões formulário
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            TipoVenda tipovenda = new TipoVenda();

            //Atribuições
            if (txtCodigo.Text == "")
                tipovenda.Id = 0;
            else
                tipovenda.Id = int.Parse(txtCodigo.Text);
            tipovenda.Descricao = txtDescricao.Text;

            //Chamada do Controlador
            bool isValid = tipoVendaController.SalvatipoVenda(tipovenda);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodigo.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                //Instancia do model
                TipoVenda tipovenda = new TipoVenda
                {
                    //Atribuições
                    Id = int.Parse(txtCodigo.Text)
                };

                //Chamada do Controlador
                bool isValid = tipoVendaController.ExcluirtipoVenda(tipovenda.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtCodigo.Focus();
                }
            }
        }

        #endregion

        #region Evento Código Leave
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                //Instancia do model
                TipoVenda tipovenda = new TipoVenda
                {
                    //Atribuição
                    Id = int.Parse(txtCodigo.Text),
                };

                //Consulta
                tipovenda = tipoVendaController.ConsultatipoVendaPorId(tipovenda.Id);

                //Atribuição da consulta
                if (tipovenda.Nome != "")
                {
                    txtCodigo.Text = tipovenda.Id.ToString();
                    txtDescricao.Text = tipovenda.Descricao;
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodigo.Focus();
                }
            }
        }
        #endregion


    }
}

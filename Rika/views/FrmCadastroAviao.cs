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
using Rika.dao;
using Rika.models;
using Rika.models.Comum;

namespace Rika.views
{
    public partial class FrmCadastroAviao : Form
    {
        private AviaoController aviaoController;
        private CompAereaController compAereaController;

        public FrmCadastroAviao()
        {
            InitializeComponent();

            aviaoController = new AviaoController();
            compAereaController = new CompAereaController();
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
        private void FrmCadastroAviao_Paint(object sender, PaintEventArgs e)
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Aviao aviao = new Aviao();

            //Atribuições
            if (txtCodAviao.Text == "")
                aviao.Id = 0;
            else
                aviao.Id = int.Parse(txtCodAviao.Text);
            if (txtCodCompAerea.Text == "")
                aviao.comp.Id = 0;
            else
                aviao.comp.Id = int.Parse(txtCodCompAerea.Text);
            if (txtQtdAcentos.Text == "")
                aviao.Qtd_Acento = 0;
            else
                aviao.Qtd_Acento = int.Parse(txtQtdAcentos.Text);
            aviao.Modelo = txtModelAviao.Text;

            //Chamada do Controlador
            bool isValid = aviaoController.Salvaaviao(aviao);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodAviao.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodAviao.Text != "")
            {
                //Instancia do model
                Aviao aviao = new Aviao
                {
                    //Atribuições
                    Id = int.Parse(txtCodAviao.Text)
                };

                //Chamada do Controlador
                bool isValid = aviaoController.Excluiraviao(aviao.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtCodAviao.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        private void txtCodAviao_Leave(object sender, EventArgs e)
        {
            if (txtCodAviao.Text != "")
            {
                //Instancia do model
                Aviao aviao = new Aviao
                {
                    //Atribuição
                    Id = int.Parse(txtCodAviao.Text),
                };

                //Consulta
                aviao = aviaoController.ConsultaAviaoPorId(aviao.Id);

                //Atribuição da consulta
                if (aviao.Modelo != "")
                {
                    txtCodAviao.Text = aviao.Id.ToString();
                    txtModelAviao.Text = aviao.Modelo;
                    txtCodCompAerea.Text = aviao.comp.Id.ToString();
                    txtQtdAcentos.Text = aviao.Qtd_Acento.ToString();
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodAviao.Focus();
                }
            }
        }

        #endregion

        #region Evento Companhia Aérea Leave
        private void txtCodCompAerea_Leave(object sender, EventArgs e)
        {
            if (txtCodCompAerea.Text != "")
            {
                //Instancia do Model
                CompanhiaAerea companhiaAerea = new CompanhiaAerea
                {
                    Id = int.Parse(txtCodCompAerea.Text)
                };

                //Chamada do Controlador
                companhiaAerea = compAereaController.ConsultaCompanhiaPorId(companhiaAerea.Id);

                //Atribuições da Consulta
                if (companhiaAerea.Nome != "")
                    txtCompAerea.Text = companhiaAerea.Nome;
                else
                {
                    txtCompAerea.Text = "";
                    txtCodCompAerea.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código da Companhia Aérea não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCompAerea.Text = "";
                txtCodCompAerea.Focus();
            }
        }
        #endregion

        #region Validações
        private void txtCodAviao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodCompAerea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtdAcentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

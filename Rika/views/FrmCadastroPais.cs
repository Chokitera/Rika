using Rika.controllers;
using Rika.dao;
using Rika.models;
using Rika.models.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCadastroPais : Form
    {
        private PaisController paisController;
        public FrmCadastroPais()
        {
            InitializeComponent();

            paisController = new PaisController();
        }

        #region Ajustes da Borda
        //Campos para alterar a borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(255, 255, 255);

        private GraphicsPath CriaBordaFormulario(Rectangle rect, float radius)
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

        private void AjustaBordaFormulario(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = CriaBordaFormulario(form.ClientRectangle, radius))
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

        private void FrmCadastroPais_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            AjustaBordaFormulario(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        #region Evento/Ações dos Botões
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdPais.Text != "")
            {
                //Instancia do model
                Pais pais = new Pais
                {
                    //Atribuições
                    Id = int.Parse(txtIdPais.Text)
                };

                //Chamada do Controlador
                bool isValid = paisController.ExcluirPais(pais.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtIdPais.Focus();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Pais pais = new Pais();

            //Atribuições
            if (txtIdPais.Text == "")
                pais.Id = 0;
            else
                pais.Id = int.Parse(txtIdPais.Text);
            pais.Nome = txtNomePais.Text;
            pais.Sigla = txtSiglaPais.Text;

            //Chamada do Controlador
            bool isValid = paisController.SalvaPais(pais);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtIdPais.Focus();
            }
        }
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        #region Evento Código Leave
        private void txtIdPais_Leave(object sender, EventArgs e)
        {
            if (txtIdPais.Text != "")
            {
                //Instancia do model
                Pais pais = new Pais
                {
                    //Atribuição
                    Id = int.Parse(txtIdPais.Text),
                };

                //Consulta
                pais = paisController.ConsultaPaisPorId(pais.Id);

                //Atribuição da consulta
                if (pais.Nome != "")
                {
                    txtIdPais.Text = pais.Id.ToString();
                    txtNomePais.Text = pais.Nome;
                    txtSiglaPais.Text = pais.Sigla;
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtIdPais.Focus();
                }
            }
            else
                new Helpers().LimparTela(this);
        }
        #endregion

        #region Eventos
        private void txtIdPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion

    }
}

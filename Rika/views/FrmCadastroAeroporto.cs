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
    public partial class FrmCadastroAeroporto : Form
    {
        private AeroportoController aeroportoController;
        private EnderecoController enderecoController;
        public FrmCadastroAeroporto()
        {
            InitializeComponent();

            aeroportoController = new AeroportoController();
            enderecoController = new EnderecoController();
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
        private void FrmCadastroAeroporto_Paint(object sender, PaintEventArgs e)
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
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do model
            Aeroporto aeroporto = new Aeroporto();

            //Atribuições
            if (txtCodAeroporto.Text == "")
                aeroporto.Id = 0;
            else
                aeroporto.Id = int.Parse(txtCodAeroporto.Text);
            if (txtCodEndereco.Text == "")
                aeroporto.endereco.Id = 0;
            else
                aeroporto.endereco.Id = int.Parse(txtCodEndereco.Text);
            aeroporto.Nome = txtNome.Text;
            aeroporto.Descricao = txtDescricao.Text;

            //Chamada do Controlador
            bool isValid = aeroportoController.SalvaAeroporto(aeroporto);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                txtCodAeroporto.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodAeroporto.Text != "")
            {
                //Instancia do model
                Aeroporto aeroporto = new Aeroporto
                {
                    //Atribuições
                    Id = int.Parse(txtCodAeroporto.Text)
                };

                //Chamada do Controlador
                bool isValid = aeroportoController.ExcluirAeroporto(aeroporto.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    txtCodAeroporto.Focus();
                }
            }
        }

        #endregion

        #region Evento Código Leave

        private void txtCodAeroporto_Leave(object sender, EventArgs e)
        {
            if (txtCodAeroporto.Text != "")
            {
                //Instancia do model
                Endereco endereco = new Endereco();
                Aeroporto aeroporto = new Aeroporto
                {
                    //Atribuição
                    Id = int.Parse(txtCodAeroporto.Text),
                };

                //Consulta
                aeroporto = aeroportoController.ConsultaAeroportoPorId(aeroporto.Id);

                //Atribuição da consulta
                if (aeroporto.Nome != "")
                {
                    txtCodAeroporto.Text = aeroporto.Id.ToString();
                    txtNome.Text = aeroporto.Nome;
                    txtCodEndereco.Text = aeroporto.endereco.Id.ToString();
                    txtDescricao.Text = aeroporto.Descricao;

                    if (txtCodEndereco.Text != "")
                    {
                        //Atribui o nome do Aeroporto a partir do código presente no BD
                        endereco = enderecoController.ConsultaEnderecoPorId(aeroporto.endereco.Id);

                        if (endereco.Cidade != "")
                            txtEndereco.Text = endereco.Cidade;
                    }
                }
                else
                {
                    new Helpers().LimparTela(this);
                    txtCodAeroporto.Focus();
                }
            }
            else
                new Helpers().LimparTela(this);
        }


        #endregion

        #region Evento Endereço Leave
        private void txtCodEndereco_Leave(object sender, EventArgs e)
        {
            if (txtCodEndereco.Text != "")
            {
                //Instancia do Model
                Endereco endereco = new Endereco
                {
                    Id = int.Parse(txtCodEndereco.Text)
                };

                //Chamada do Controlador
                endereco = enderecoController.ConsultaEnderecoPorId(endereco.Id);

                //Atribuições da Consulta
                if (endereco.Cidade != "")
                    txtEndereco.Text = endereco.Cidade;
                else
                {
                    txtCodAeroporto.Text = "";
                    txtEndereco.Text = "";
                    txtCodEndereco.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código do Endereço não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Text = "";
                txtCodEndereco.Focus();
            }
        }
        #endregion

        #region Validações
        private void txtCodAeroporto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Tratado
            }
        }

        private void txtCodEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Tratado
            }
        }
        #endregion
    }
}
using Org.BouncyCastle.Asn1.Cmp;
using Rika.controllers;
using Rika.models;
using Rika.models.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCadastroEndereco : Form
    {
        private EnderecoController enderecoController;
        private PaisController paisController;
        public FrmCadastroEndereco()
        {
            InitializeComponent();

            enderecoController = new EnderecoController();
            paisController = new PaisController();
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

        private void FrmCadastroEndereco_Paint(object sender, PaintEventArgs e)
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

        private void pnlArrastarFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Ajustes nos botões superiores da tela
        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Evento/Ações dos Botões
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodEndereco.Text != "")
            {
                //Instancia do Model
                Endereco endereco = new Endereco
                {
                    Id = int.Parse(txtCodEndereco.Text)
                };

                //Chamado do Controlador
                bool isValid = enderecoController.ExcluirEndereco(endereco.Id);

                //Se realizou o processo limpa a tela
                if (isValid)
                {
                    new Helpers().LimparTela(this);
                    LimpaMaskedBox();
                    txtCodEndereco.Focus();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instancia do Model
            Endereco endereco = new Endereco();

            //Atribuições
            if (txtCodEndereco.Text == "")
                endereco.Id = 0;
            else
                endereco.Id = int.Parse(txtCodEndereco.Text);
            if (txtCep.Text == "     -")//Retira a Mascara para a validação
                endereco.CEP = null;
            else
                endereco.CEP = txtCep.Text;
            if (txtNumero.Text == "")
                endereco.NumeroCasa = 0;
            else
                endereco.NumeroCasa = int.Parse(txtNumero.Text);
            if (txtCodPais.Text == "")
                endereco.pais.Id = 0;
            else
                endereco.pais.Id = int.Parse(txtCodPais.Text);
            endereco.Estado = txtEstado.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Complemento = txtComplemento.Text;

            //Chamada do Controlador
            bool isValid = enderecoController.SalvaEndereco(endereco);

            //Se realizou o processo limpa a tela
            if (isValid)
            {
                new Helpers().LimparTela(this);
                LimpaMaskedBox();
                txtCodEndereco.Focus();
            }
        }

        private void ptbConsultaCEP_Click(object sender, EventArgs e)
        {
            DataSet dados = new DataSet();

            //Atribuições
            string cep = txtCep.Text;
            string url = "https://viacep.com.br/ws/" + cep + "/xml/";

            //Consulta
            dados = enderecoController.ConsultaCEPAPI(url);

            //Atribuições do retorno
            if (dados != null) //Consulta deu certa
            {
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtLogradouro.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento Código Leave
        private void txtCodEndereco_Leave(object sender, EventArgs e)
        {
            if (txtCodEndereco.Text != "")
            {
                //Instancia dos Models
                Pais pais = new Pais();
                Endereco endereco = new Endereco
                {
                    Id = int.Parse(txtCodEndereco.Text)
                };

                //Chamada do Controlador
                endereco = enderecoController.ConsultaEnderecoPorId(endereco.Id);

                //Atribuição da Consulta
                if (endereco.Cidade != "")
                {
                    txtCodEndereco.Text = endereco.Id.ToString();
                    txtCep.Text = endereco.CEP;
                    txtCodPais.Text = endereco.pais.Id.ToString();
                    txtEstado.Text = endereco.Estado;
                    txtCidade.Text = endereco.Cidade;
                    txtLogradouro.Text = endereco.Logradouro;
                    txtComplemento.Text = endereco.Complemento;
                    if (endereco.NumeroCasa == 0)
                        txtNumero.Text = "";
                    else
                        txtNumero.Text = endereco.NumeroCasa.ToString();

                    //Atribui o nome do país a partir do código presente no BD
                    if(txtCodPais.Text != "")
                    {
                        pais = paisController.ConsultaPaisPorId(endereco.pais.Id);

                        if (pais.Nome != "")
                            txtPais.Text = pais.Nome;
                    }
                }
                else
                {
                    new Helpers().LimparTela(this);
                    LimpaMaskedBox();
                    txtCodEndereco.Focus();
                }
            }
            else
            {
                new Helpers().LimparTela(this);
                LimpaMaskedBox();
            }
        }
        #endregion

        #region Evento País Leave
        private void txtCodPais_Leave(object sender, EventArgs e)
        {
            if(txtCodPais.Text != "")
            {
                //Instancia do Model
                Pais pais = new Pais
                {
                    Id = int.Parse(txtCodPais.Text)
                };

                //Chamada do Controlador
                pais = paisController.ConsultaPaisPorId(pais.Id);

                //Atribuição da Consulta
                if (pais.Nome != "")
                    txtPais.Text = pais.Nome;
                else
                {
                    txtCodPais.Text = "";
                    txtPais.Text = "";
                    txtCodPais.Focus();
                }
            }
            else
            {
                MessageBox.Show("O Código do País não pode ser vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPais.Text = "";
                txtCodPais.Focus();
            }
        }
        #endregion

        #region Validações
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Tratado
            }
        }

        private void txtCodEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Tratado
            }
        }

        private void txtCodPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Limpar MaskedBox
        public void LimpaMaskedBox()
        {
            txtCep.Text = "";
        }
        #endregion
    }
}

    using Rika.dao;
using Rika.models;
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
        public FrmCadastroPais()
        {
            InitializeComponent();
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
        private void FrmCadastroPais_Paint(object sender, PaintEventArgs e)
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
        #region Efetuar cadastro país
        public void EfetuarCadastroPais()
        {
            //Instanciar o model e atribuir valores
            Pais pais = new Pais();

            pais.Nome = txtNomePais.Text;
            pais.Sigla = txtSiglaPais.Text;

            //Instanciar DAO
            PaisDAO dao = new PaisDAO();

            if (VerificaCampoVazio(pais))
            {
                bool cadastro = dao.EfetuarCadastroPais(pais);

                if (cadastro) //Cadastro feito
                {
                
                } 
            } 

        }
        #endregion

        #region Verificar campos vazios

        public bool VerificaCampoVazio(Pais pais)
        {
            if (pais.Nome == null || pais.Nome == "")
            {
                MessageBox.Show("Necessário preencher o campo Nome!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomePais.Focus();
                return false;
            }
            if (pais.Sigla == "")
            {
                MessageBox.Show("Necessário preencher o campo Sigla!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiglaPais.Focus();
                return false;
            }
            //if (pais.Id == null)
            //{
            //    MessageBox.Show("Necessário preencher o campo!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNomePais.Focus();
            //    return false;
            //}
            return true;
        }

        #endregion

        #region Excluir país da tabela

        public void ExcluirPais()
        {
            //Instanciar o model e atribuir os valores
            Pais pais = new Pais();

            PaisDAO dao = new PaisDAO();

            bool exclusao = dao.ExcluirPais(pais);

            if (exclusao) 
            {

            }   
        }

        #endregion

        #region



        #endregion

        #region Ações dos botões
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EfetuarCadastroPais();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdPais.TextNew != "")
            {
                ExcluirPais();
            }
            else
                MessageBox.Show("O campo Código não pode estar vazio!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
  
    }
}

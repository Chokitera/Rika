﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using Rika.models;

namespace Rika.views
{
    public partial class FrmCadastroPassagem : Form
    {
        private string caminhoOriginal = ""; //Utilizado na Imagem da Passagem
        private string caminhoNovo = ""; //Utilizado na Imagem da Passagem
        public FrmCadastroPassagem()
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

        private void FrmTelaAdministrativa_Paint(object sender, PaintEventArgs e)
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

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlArrastarFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void FrmTelaAdministrativa_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instânciando a clase Passagem
           /* Passagem passagem = new Passagem();
            passagem.Id = int.Parse(txtCodPassagem.Text);
            passagem.Nome_Voo.Id = int.Parse(txtVoo.Text);*/
        }

        private void lblVoo_Click(object sender, EventArgs e)
        {

        }

        #region Le a imagem e salva na aplicação
        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog(); //Cria a abertura do arquivo
            openFile.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png"; //Extensões permitidas
            openFile.Multiselect = false; //Seleciona somente 1 arquivo
            string nomeArquivo = "";
            string pastaDestino = @"C:\projetos-csharp\RIKA\Rika\fotos\";


            if (openFile.ShowDialog() == DialogResult.OK) //Se confirmou o arquivo
            {
                caminhoOriginal = openFile.FileName; //Caminho
                nomeArquivo = openFile.SafeFileName; //Nome do Arquivo
                caminhoNovo = pastaDestino + nomeArquivo; //Novo caminho com o nome do arquivo
                txtImagem.Text = nomeArquivo;
            }
            else
                return;

            //Utilizado no momento como teste para verificar a cópia, depois vai para o evento confirmar
            GravaImagem();
        }
        #endregion

        #region Copia a imagem para o destino e grava no banco
        public void GravaImagem()
        {
            //Verifica se já existe algum arquivo com esse nome na pasta
            if (File.Exists(caminhoNovo))
            {
                MessageBox.Show("Já existe um arquivo com esse mesmo nome!\n\nEscolha outro nome de arquivo.", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Grava o novo arquivo em um novo caminho - SÓ VAI COPIAR E SALVAR NO BANCO DEPOIS DE CLICAR EM "CONFIRMAR"... DEPOIS RETIRAR DO EVENTO btnAbrirPasta_Click
            System.IO.File.Copy(caminhoOriginal, caminhoNovo, false);

            //Verifica se o arquivo foi salvo e mostra o nome no textbox
            if (File.Exists(caminhoNovo))
            {
                //Salva o caminho da imagem no banco
                //Fazer aqui a chamada do método
            }
            else
                MessageBox.Show("Arquivo não copiado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Visualizar a imagem
        private void btnVisualizarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtImagem.Text != "") //Se existir imagem ele exibe
                {
                    if (File.Exists(caminhoNovo))
                    {
                        using (var frm = new FrmExibirImagemPassagem(caminhoNovo))//Exibe o formulário com a imagem do caminho novo
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        using (var frm = new FrmExibirImagemPassagem(caminhoOriginal))//Exibe o formulário com a imagem do caminho antigo
                        {
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arquivo não encontrado!\n\nVerifique se o mesmo foi excluído.", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        #endregion
    }
}

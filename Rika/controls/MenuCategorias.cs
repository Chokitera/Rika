using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.controls
{
    public partial class MenuCategorias : UserControl
    {

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

        private void FormRegionAndBorder(UserControl form, float radius, Graphics graph, Color borderColor, float borderSize)
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

        private void MenuCategorias_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);

            int borderWidth = 1; //Tamanho da borda

            //Desenha sombra nas laterais e na parte inferior do controle
            using (var shadowBrush = new SolidBrush(Color.WhiteSmoke))
            {
                // Sombra nas laterais
                e.Graphics.FillRectangle(shadowBrush, 0, borderWidth, borderWidth, this.Height - borderWidth);
                e.Graphics.FillRectangle(shadowBrush, this.Width - borderWidth, borderWidth, borderWidth, this.Height - borderWidth);

                // Sombra na parte inferior
                e.Graphics.FillRectangle(shadowBrush, borderWidth, this.Height - borderWidth, this.Width - 2 * borderWidth, borderWidth);
            }
        }
        #endregion

        public MenuCategorias()
        {
            InitializeComponent();

            //this.Paint += MenuCategorias_Paint;
        }

        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; lblTitulo.Text = value; }
        }

        private string _informacao;

        public string Informacao
        {
            get { return _informacao; }
            set { _informacao = value; txtInformacao.Text = value; }
        }

        private Image _imagem;

        public Image Imagem
        {
            get { return _imagem; }
            set { _imagem = value; ptbImagem.Image = value; }
        }

        //Define a cor do fundo ao mouse entrar na categoria
        private void MenuCategorias_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            txtInformacao.BackColor = Color.WhiteSmoke;
        }

        //Define a cor do fundo ao mouse sair da categoria
        private void MenuCategorias_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            txtInformacao.BackColor = Color.White;
        }
    }
}

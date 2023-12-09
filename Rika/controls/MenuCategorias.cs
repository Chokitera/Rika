using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
        }
        #endregion

        public MenuCategorias()
        {
            InitializeComponent();
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
    }
}

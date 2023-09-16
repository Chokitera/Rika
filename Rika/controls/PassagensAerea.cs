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
    public partial class PassagensAerea : UserControl
    {

        #region Ajustes da Borda
        //Campos para alterar a borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

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

        private void PassagensAerea_Paint(object sender, PaintEventArgs e)
        {
            //  FormRegionAndBorder(this borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        public PassagensAerea()
        {
            InitializeComponent();
        }

        private void PassagensAerea_Load(object sender, EventArgs e)
        {
            //Rojo Forte
            txtValor.ForeColor = Color.FromArgb(16, 0, 79); 
            txtDestino.ForeColor = Color.FromArgb(16, 0, 79);
            //Cinza
            txtClasse.ForeColor = Color.FromArgb(158, 158, 158);
            txtDataViagem.ForeColor = Color.FromArgb(158, 158, 158);
            txtDiretoEscala.ForeColor = Color.FromArgb(158, 158, 158);
            txtIdaVolta.ForeColor = Color.FromArgb(158, 158, 158);
            lblPrecoFinal.ForeColor = Color.FromArgb(158, 158, 158);

        }

        private Image _imagemPassagem; 

        public Image imagemPassagem
        {
            get { return _imagemPassagem; }
            set { _imagemPassagem = value; imgPassagem.Image = value;}
        }

        private string _dataViagem;

        public string dataViagem
        {
            get { return _dataViagem; }
            set { _dataViagem = value; txtDataViagem.Text = value; }
        }

        private string _destino;

        public string destino
        {
            get { return _destino; }
            set { _destino = value; txtDestino.Text = value; }
        }

        private string _idaVolta;

        public string idavolta
        {
            get { return _idaVolta; }
            set { _idaVolta = value; txtIdaVolta.Text = value; }
        }

        private string _classe;

        public string classe
        {
            get { return _classe; }
            set { _classe = value; txtClasse.Text = value; }
        }


        private string _valor;

        public string valor
        {
            get { return _valor; }
            set { _valor = value; txtValor.Text = value; }
        }

        private string _diretoEscala;

        public string diretoEscala
        {
            get { return _diretoEscala; }
            set { _diretoEscala = value; txtDiretoEscala.Text = value; }
        }


        private void modeloBotao1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

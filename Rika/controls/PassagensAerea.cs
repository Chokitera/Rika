using Rika.controllers;
using Rika.models;
using Rika.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.controls
{
    public partial class PassagensAerea : UserControl
    {
        private Usuario usuario = new Usuario();
        private CarrinhoCompraController carrinhoController;
        Bitmap shadowBmp = null;

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

        //#region Ajuste da Borda na Data Cinza
        ////Campos para alterar a borda
        //private int borderRadiusData = 20;
        //private int borderSizeData = 2;
        //private Color borderColorData = Color.FromArgb(255, 255, 255);

        //private GraphicsPath GetRoundedPathData(Rectangle rect, float radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    float curveSize = radius * 2F;
        //    path.StartFigure();
        //    path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        //    path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        //    path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        //    path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        //    path.CloseFigure();
        //    return path;
        //}

        //private void FormRegionAndBorderData(UserControl form, float radius, Graphics graph, Color borderColor, float borderSize)
        //{

        //    using (GraphicsPath roundPath = GetRoundedPathData(form.ClientRectangle, radius))
        //    using (Pen penBorder = new Pen(borderColor, borderSize))
        //    using (Matrix transform = new Matrix())
        //    {
        //        graph.SmoothingMode = SmoothingMode.AntiAlias;
        //        form.Region = new Region(roundPath);
        //        if (borderSize >= 1)
        //        {
        //            Rectangle rect = form.ClientRectangle;
        //            float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
        //            float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
        //            transform.Scale(scaleX, scaleY);
        //            transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
        //            graph.Transform = transform;
        //            graph.DrawPath(penBorder, roundPath);
        //        }
        //    }

        //}

        private void txtDataViagem_Paint(object sender, PaintEventArgs e)
        {
            //FormRegionAndBorderData(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        //#endregion

        private void PassagensAerea_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
            //PassagensAerea.Paint += dropShadow();
            //dropShadow(sender, e);

            //if (shadowBmp == null || shadowBmp.Size != this.Size)
            //{
            //    shadowBmp?.Dispose();
            //    shadowBmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            //}
            //using (GraphicsPath gp = new GraphicsPath())
            //{
            //    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
            //    DrawShadowSmooth(gp, 100, 60, shadowBmp);
            //}
            //e.Graphics.DrawImage(shadowBmp, new Point(0, 0));
        }
        #endregion

        #region Ajustes da Sombra
        //private const int SombraFormulario = 0x00020000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle = SombraFormulario; //Sombra do Formulário
        //        return cp;
        //    }
        //}

        //private void dropShadow(object sender, PaintEventArgs e)
        //{
        //    Panel panel = (Panel)sender;
        //    Color[] shadow = new Color[3];
        //    shadow[0] = Color.FromArgb(181, 181, 181);
        //    shadow[1] = Color.FromArgb(195, 195, 195);
        //    shadow[2] = Color.FromArgb(211, 211, 211);
        //    Pen pen = new Pen(shadow[0]);
        //    using (pen)
        //    {
        //        foreach (Panel p in panel.Controls.OfType<Panel>())
        //        {
        //            Point pt = p.Location;
        //            pt.Y += p.Height;
        //            for (var sp = 0; sp < 3; sp++)
        //            {
        //                pen.Color = shadow[sp];
        //                e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
        //                pt.Y++;
        //            }
        //        }
        //    }
        //}

        //private static void DrawShadowSmooth(GraphicsPath gp, int intensity, int radius, Bitmap dest)
        //{
        //    using (Graphics g = Graphics.FromImage(dest))
        //    {
        //        g.Clear(Color.Transparent);
        //        g.CompositingMode = CompositingMode.SourceCopy;
        //        double alpha = 0;
        //        double astep = 0;
        //        double astepstep = (double)intensity / radius / (radius / 2D);
        //        for (int thickness = radius; thickness > 0; thickness--)
        //        {
        //            using (Pen p = new Pen(Color.FromArgb((int)alpha, 0, 0, 0), thickness))
        //            {
        //                p.LineJoin = LineJoin.Round;
        //                g.DrawPath(p, gp);
        //            }
        //            alpha += astep;
        //            astep += astepstep;
        //        }
        //    }
        //}
        #endregion

        public PassagensAerea(Usuario usuario)
        {
            InitializeComponent();

            carrinhoController = new CarrinhoCompraController();
            this.usuario = usuario;
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

        public Image ImagemPassagem
        {
            get { return _imagemPassagem; }
            set { _imagemPassagem = value; imgPassagem.Image = value;}
        }

        private string _dataViagem;

        

        public string DataViagem
        {
            get { return _dataViagem; }
            set { _dataViagem = value; txtDataViagem.Text = value; }
        }

        private int _codPassagem;

        public int CodPassagem
        {
            get { return _codPassagem; }
            set { _codPassagem = value; }
        }


        private string _destino;

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; txtDestino.Text = value; }
        }

        private string _idaVolta;

        public string Idavolta
        {
            get { return _idaVolta; }
            set { _idaVolta = value; txtIdaVolta.Text = value; }
        }

        private string _classe;

        public string Classe
        {
            get { return _classe; }
            set { _classe = value; txtClasse.Text = value; }
        }


        private string _valor;

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; txtValor.Text = value; }
        }

        private string _diretoEscala;

        public string DiretoEscala
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

        private void ptbConfirmar_Click(object sender, EventArgs e)
        {
            //Preenche o model
            CarrinhoCompra carrinhoCompra = new CarrinhoCompra();
            carrinhoCompra.Id = 0; //Inclusão do item
            carrinhoCompra.passagem.Id = _codPassagem;
            carrinhoCompra.Dt_Adicao = DateTime.Today;
            carrinhoCompra.Quantidade = 1;
            carrinhoCompra.usuario.Id = 1; //Ainda não feito o gravamento do usuário no sistema ou regedit

            //Salva os itens no carrinho de compras
            carrinhoController.SalvaCarrinhoCompra(carrinhoCompra);

            //Mostra o carrinho de compras
            FrmCarrinhoCompra tela = new FrmCarrinhoCompra(usuario);
            tela.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.views
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        #region Link para Entrar no sistema
        private void linkEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).ColocarFormNoPainel(new FrmLogin());
            }
        }
        #endregion

        #region Métodos para ajustes nas TextBox
        public void AjusteTextBoxEnter()
        {

        }

        public void AjusteTextBoxLeave()
        {

        }
        #endregion
    }
}

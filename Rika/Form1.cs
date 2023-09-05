using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Ajustes da Parte Superior do Formulário
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            LoginDAO dao = new LoginDAO();

            bool login = dao.EfetuarLogin(usuario);

            if (login)
            {
                //Chamaria a tela iniciall
            }
        }

        private void txtUsuario__TextChanged(object sender, EventArgs e)
        {

        }
    }
}

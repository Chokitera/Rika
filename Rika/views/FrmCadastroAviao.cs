﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rika.dao;
using Rika.models;

namespace Rika.views
{
    public partial class FrmCadastroAviao : Form
    {
        public FrmCadastroAviao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastroAviao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cadastro de Avião

        public void CadastroAviao() {
            //Instancia do Model
            Aviao aviao = new Aviao();
            aviao.Qtd_Acento = int.Parse(txtQtdAcentos.TextNew);
            aviao.Modelo = txtModelAviao.TextNew;
            aviao.comp.Id = int.Parse(txtCodCompAerea.TextNew);

            if (VerificaCampoBranco(aviao))
            {
                //Instancia do DAO
                AviaoDAO aviaoDAO = new AviaoDAO();
                aviaoDAO.CadastrarAviao(aviao);
            }

        }
        #endregion

        #region Verificar campos em branco
        public bool VerificaCampoBranco(Aviao aviao)
        {
            if (aviao.comp.Id == 0)
            {
                MessageBox.Show("Necessário preencher o campo Companhia Aerea!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompAerea.Focus();
                return false;
            }

            if (aviao.Modelo == "" || aviao.Modelo == null)
            {
                MessageBox.Show("Necessário preencher o campo Modelo!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelAviao.Focus();
                return false;
            }

            if (aviao.Qtd_Acento == 0)
            {
                MessageBox.Show("Necessário preencher o campo Quantidade de Acentos!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdAcentos.Focus();
                return false;
            }

            return true;
        }
        #endregion

    }
}

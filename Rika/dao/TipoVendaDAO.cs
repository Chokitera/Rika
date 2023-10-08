﻿using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.dao
{
    public class TipoVendaDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public TipoVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de tipo de venda
        public bool EfetuarCadastro(TipoVenda tipoVenda)
        {
            try
            {
                string sql = @"insert into TIPO_VENDA (descricao) 
                               values (@descricao);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", tipoVenda.Descricao);

                //Consultar último registro
                string sql2 = @"select IDTIPO_VENDA from TIPO_VENDA order by IDTIPO_VENDA desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                tipoVenda.Id = reader.GetInt32(0);
                MessageBox.Show("Tipo de Venda " + tipoVenda.Id + " - " + tipoVenda.Descricao + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return false;
            }
        }
        #endregion
    }
}

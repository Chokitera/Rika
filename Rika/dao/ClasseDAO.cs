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
    public class ClasseDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public ClasseDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de classe
        public bool EfetuarCadastro(Classe classe)
        {
            try
            {
                string sql = @"insert into CLASSE (nome, descricao) 
                               values (@nome, @descricao);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", classe.Nome);
                executacmd.Parameters.AddWithValue("@descricao", classe.Descricao);

                //Consultar registro
                string sql2 = @"select IDCLASSE from CLASSE order by IDCLASSE desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                classe.Id = reader.GetInt32(0);
                MessageBox.Show("Classe " + classe.Id + " - " + classe.Nome + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

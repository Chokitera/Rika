﻿using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.dao
{
    public class SituacaoDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public SituacaoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de situação
        public bool EfetuarCadastro(Situacao situacao)
        {
            try
            {
                string sql = @"insert into situacao (descricao) 
                               values (@descricao);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", situacao.Descricao);

                //Consultar último registro
                string sql2 = @"select idsituacao from situacao order by idsituacao desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                situacao.Id = reader.GetInt32(0);
                MessageBox.Show("Situação " + situacao.Id + " - " + situacao.Descricao + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de situação
        public bool ExcluirSituacao(Situacao situacao)
        {
            try
            {
                string sql = @"delete from SITUACAO where IDSITUACAO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", situacao.Id);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Mensagem que aparou o registro
                MessageBox.Show("O cadastro foi apagado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para editar situacao
        public bool EfetuarEdicao(Situacao situacao)
        {
            try
            {
                string sql = @"update SITUACAO set nome=@nome, descricao=@descricao
                               where IDSITUACAO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", situacao.Id);
                executacmd.Parameters.AddWithValue("@descricao", situacao.Descricao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Situação " + situacao.Id + " - " + situacao.Descricao + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Situação
        public Situacao ConsultarSituacaoPorId(Situacao situacao)
        {
            try
            {
                //Sql
                string sql = @"select * from SITUACAO where IDSITUACAO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", situacao.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    situacao.Descricao = "";
                    MessageBox.Show("Situação não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    situacao.Descricao = reader[1].ToString();
                }

                conexao.Close();

                return situacao;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return situacao;
            }
        }
        #endregion

        #region Método para consultar a situação e preencher a DataTable
        public DataTable ConsultarSituacao(Situacao situacao)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select * from situacao where descricao like @descricao";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", situacao.Descricao);

                //Abre a conexao e executa Sql
                conexao.Open();

                //Preenche o DataTable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(dt);

                conexao.Close();

                return dt; //Retorna a DT
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return null;
            }
        }

        #endregion
    }
}

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
    public class TituloDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public TituloDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de título
        public bool EfetuarCadastro(Titulo titulo)
        {
            try
            {
                string sql = @"insert into TITULO (IDTIPO_VENDA, VALOR) 
                               values (@IDTIPO_VENDA, @VALOR);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", titulo.tipovenda.Id);
                executacmd.Parameters.AddWithValue("@descricao", titulo.Valor);

                //Consultar o último registro
                string sql2 = @"select IDTITULO from TITULO order by IDTITULO desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                titulo.Id = reader.GetInt32(0);
                MessageBox.Show("Título " + titulo.Id + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de título
        public bool ExcluirTitulo(Titulo titulo)
        {
            try
            {
                string sql = @"delete from TITULO where IDTITULO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", titulo.Id);

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

        #region Método para editar Titulos
        public bool EfetuarEdicao(Titulo titulo)
        {
            try
            {
                string sql = @"update TITULO set idpassagem=@idpassagem, idtipo_venda=@idtipo_venda, valor=@valor
                               where IDTITULO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", titulo.Id);
                executacmd.Parameters.AddWithValue("@idpassagem", titulo.passagem.Id);
                executacmd.Parameters.AddWithValue("@idtipo_venda", titulo.tipovenda.Id);
                executacmd.Parameters.AddWithValue("@valor", titulo.Valor);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Título " + titulo.Id + " - " + titulo.Valor + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específico Titulo
        public Titulo ConsultarCompanhiaPorId(Titulo titulo)
        {
            try
            {
                //Sql
                string sql = @"select * from TITULO where IDTITULO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", titulo.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    titulo.Valor = 0;
                    MessageBox.Show("Título não encontrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    titulo.passagem.Id = reader.GetInt32(1);
                    titulo.tipovenda.Id = reader.GetInt32(2);
                    titulo.Valor = reader.GetDouble(3);
                }

                conexao.Close();

                return titulo;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return titulo;
            }
        }
        #endregion
    }
}

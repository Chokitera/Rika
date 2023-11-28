using MySql.Data.MySqlClient;
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
    public class PaisDAO
    {
        private MySqlConnection conexao;
        public PaisDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de país

        public bool EfetuarCadastroPais(Pais pais)
        {
            try
            {
                string sql = @"insert into pais (nome, sigla)
                               values (@nome, @sigla);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", pais.Nome);
                executacmd.Parameters.AddWithValue("@sigla", pais.Sigla);

                //Consultar último país
                string sql2 = @"select idpais from pais order by idpais desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                pais.Id = reader.GetInt32(0);
                MessageBox.Show("País " + pais.Id + " - " + pais.Nome + " (" + pais.Sigla + ") " + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de país
        public bool ExcluirPais(Pais pais)
        {
            try
            {
                string sql = @"delete from pais where idpais = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", pais.Id);

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

        #region Método para editar País
        public bool EfetuarEdicao(Pais pais)
        {
            try
            {
                string sql = @"update PAIS set nome=@nome, sigla=@sigla
                               where IDPAIS = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", pais.Id);
                executacmd.Parameters.AddWithValue("@nome", pais.Nome) ;
                executacmd.Parameters.AddWithValue("@descricao", pais.Sigla);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("País " + pais.Id + " - " + pais.Nome + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Pais
        public Pais ConsultarPaisPorId(Pais pais)
        {
            try
            {
                //Sql
                string sql = @"select * from PAIS where IDPAIS = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", pais.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    pais.Nome = "";
                    MessageBox.Show("País não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pais.Nome = reader[1].ToString();
                    pais.Sigla = reader[2].ToString();
                }

                conexao.Close();

                return pais;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return pais;
            }
        }
        #endregion

        #region Método para consultar paises e preencher a DataTable
        public DataTable ConsultarPaises(Pais pais)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select * from pais where nome like @nome";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", pais.Nome);

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

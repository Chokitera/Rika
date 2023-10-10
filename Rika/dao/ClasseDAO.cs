using MySql.Data.MySqlClient;
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

        #region Método para exclusão de classe
        public bool ExcluirClasse(Classe classe)
        {
            try
            {
                string sql = @"delete from CLASSE where IDCLASSE = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", classe.Id);

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

        #region Método para editar Classe
        public bool EfetuarEdicao(Classe classe)
        {
            try
            {
                string sql = @"update CLASSE set nome=@nome, descricao=@descricao
                               where IDCLASSE = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", classe.Id);
                executacmd.Parameters.AddWithValue("@nome", classe.Nome);
                executacmd.Parameters.AddWithValue("@descricao", classe.Descricao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Classe " + classe.Id + " - " + classe.Nome + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Classe
        public Classe ConsultarClassePorId(Classe classe)
        {
            try
            {
                //Sql
                string sql = @"select * from CLASSE where IDCLASSE = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", classe.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    classe.Nome = "";
                    MessageBox.Show("Classe não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    classe.Nome = reader[1].ToString();
                    classe.Descricao = reader[2].ToString();
                }

                conexao.Close();

                return classe;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return classe;
            }
        }
        #endregion
    }
}

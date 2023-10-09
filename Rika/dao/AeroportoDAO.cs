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
    public class AeroportoDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public AeroportoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de aeroporto
        public bool EfetuarCadastro(Aeroporto aeroporto)
        {
            try
            {
                string sql = @"insert into AEROPORTO (nome, descricao, endereco) 
                               values (@nome, @descricao, @endereco);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", aeroporto.Nome);
                executacmd.Parameters.AddWithValue("@descricao", aeroporto.Descricao);
                executacmd.Parameters.AddWithValue("@endereco", aeroporto.endereco.Id);

                //Consultar o último registro
                string sql2 = @"select IDAEROPORTO from AEROPORTO order by IDAEROPORTO desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                aeroporto.Id = reader.GetInt32(0);
                MessageBox.Show("Aeroporto " + aeroporto.Id + " - " + aeroporto.Nome + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de aeroporto
        public bool ExcluirAeroporto(Aeroporto aeroporto)
        {
            try
            {
                string sql = @"delete from AEROPORTO where IDAEROPORTO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", aeroporto.Id);

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

        #region Método para editar Aeroporto
        public bool EfetuarEdicao(Aeroporto aeroporto)
        {
            try
            {
                string sql = @"update AEROPORTO set nome=@nome, descricao=@descricao, inscricao=@inscricao, endereco=@endereco
                               where AEROPORTO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", aeroporto.Id);
                executacmd.Parameters.AddWithValue("@endereco", aeroporto.endereco);
                executacmd.Parameters.AddWithValue("@nome", aeroporto.Nome);
                executacmd.Parameters.AddWithValue("@descricao", aeroporto.Descricao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Aeroporto " + aeroporto.Id + " - " + aeroporto.Nome + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Companhia Aérea
        public CompanhiaAerea ConsultarCompanhiaPorId(CompanhiaAerea companhiaAerea)
        {
            try
            {
                //Sql
                string sql = @"select * from COMP_AEREA where IDCOMP_AEREA = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", companhiaAerea.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    companhiaAerea.Nome = "";
                    MessageBox.Show("Companhia Aérea não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    companhiaAerea.Nome = reader[1].ToString();
                    companhiaAerea.Inscricao = reader[2].ToString();
                    companhiaAerea.Descricao = reader[3].ToString();
                }

                conexao.Close();

                return companhiaAerea;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return companhiaAerea;
            }
        }
        #endregion
    }
}

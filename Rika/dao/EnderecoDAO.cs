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
    public class EnderecoDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public EnderecoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de endereço
        public bool EfetuarCadastro(Endereco endereco)
        {
            try
            {
                string sql = @"insert into ENDERECO (IDPAIS, CIDADE, ESTADO, CEP, LOGRADOURO, NUMERO, COMPLEMENTO) 
                               values (@IDPAIS, @CIDADE, @ESTADO, @CEP, @LOGRADOURO, @NUMERO, @COMPLEMENTO);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IDPAIS", endereco.pais.Id);
                executacmd.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
                executacmd.Parameters.AddWithValue("@ESTADO", endereco.Estado);
                executacmd.Parameters.AddWithValue("@CEP", endereco.CEP);
                executacmd.Parameters.AddWithValue("@LOGRADOURO", endereco.Logradouro);
                executacmd.Parameters.AddWithValue("@NUMERO", endereco.NumeroCasa);
                executacmd.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);

                //Consultar o último registro
                string sql2 = @"select IDENDERECO from ENDERECO order by IDENDERECO desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                endereco.Id = reader.GetInt32(0);
                MessageBox.Show("Endereço " + endereco.Id + " - " + endereco.Cidade + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de endereço
        public bool ExcluirEndereco(Endereco endereco)
        {
            try
            {
                string sql = @"delete from ENDERECO where IDENDERECO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", endereco.Id);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Mensagem que apagou o registro
                MessageBox.Show("O cadastro foi excluído com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para editar Endereço
        public bool EfetuarEdicao(Endereco endereco)
        {
            try
            {
                string sql = @"update ENDERECO set idpais=@idpais, cidade=@cidade, estado=@estado, cep=@cep, logradouro=@logradouro, numero=@numero, complemento=@complemento
                               where IDENDERECO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", endereco.Id);
                executacmd.Parameters.AddWithValue("@idpais", endereco.pais.Id);
                executacmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
                executacmd.Parameters.AddWithValue("@estado", endereco.Estado);
                executacmd.Parameters.AddWithValue("@cep", endereco.CEP);
                executacmd.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                executacmd.Parameters.AddWithValue("@numero", endereco.NumeroCasa);
                executacmd.Parameters.AddWithValue("@complemento", endereco.Complemento);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Endereço " + endereco.Id + " - " + endereco.Cidade + " atualizado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public Endereco ConsultarEnderecoPorId(Endereco endereco)
        {
            try
            {
                //Sql
                string sql = @"select * from ENDERECO where IDENDERECO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", endereco.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    endereco.Cidade = "";
                    MessageBox.Show("Endereço não encontrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    endereco.pais.Id = reader.GetInt32(1);
                    endereco.Cidade = reader[2].ToString();
                    endereco.Estado = reader[3].ToString();
                    endereco.CEP = reader[4].ToString();
                    endereco.Logradouro = reader[5].ToString();
                    endereco.NumeroCasa = reader.GetInt32(6);
                    endereco.Complemento = reader[7].ToString();
                }

                conexao.Close();

                return endereco;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return endereco;
            }
        }
        #endregion
    }
}

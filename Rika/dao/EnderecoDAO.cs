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
                MessageBox.Show("Endereço " + endereco.Id + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

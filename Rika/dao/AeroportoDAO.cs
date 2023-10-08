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
    }
}

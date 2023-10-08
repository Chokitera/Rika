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
    public class CompAereaDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public CompAereaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de companhia aérea
        public bool EfetuarCadastro(CompanhiaAerea companhiaAerea)
        {
            try
            {
                string sql = @"insert into COMP_AEREA (nome, descricao, inscricao) 
                               values (@nome, @descricao, @inscricao);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", companhiaAerea.Nome);
                executacmd.Parameters.AddWithValue("@descricao", companhiaAerea.Descricao);
                executacmd.Parameters.AddWithValue("@inscricao", companhiaAerea.Inscricao);

                //Consultar o último registro
                string sql2 = @"select IDCOMP_AEREA from COMP_AEREA order by IDCOMP_AEREA desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                companhiaAerea.Id = reader.GetInt32(0);
                MessageBox.Show("Companhia Aérea " + companhiaAerea.Id + " - " + companhiaAerea.Nome + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de Companhia Aérea
        public bool ExcluirCompAerea(CompanhiaAerea companhiaAerea)
        {
            try
            {
                string sql = @"delete from COMP_AEREA where IDCOMP_AEREA = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", companhiaAerea.Id);

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

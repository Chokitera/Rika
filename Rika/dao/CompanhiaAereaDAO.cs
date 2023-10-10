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
    public class CompanhiaAereaDAO
    {

        private MySqlConnection conexao;

        public CompanhiaAereaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Metodo para Cadastrar Companhia Aereas

        public bool efetuarCadastro(CompanhiaAerea compaerea) {
            try
            {
                string sql = @"insert into comp_aerea(nome, inscricao, descricao)
                                    values(@nome, @inscricao, @descricao)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", compaerea.Nome);
                executacmd.Parameters.AddWithValue("@inscricao", compaerea.Inscricao);
                executacmd.Parameters.AddWithValue("@descricao", compaerea.Descricao);

                //Consultar último usuário para consulta
                string sql2 = @"select idcomp_aerea from comp_aerea order by idcomp_aerea desc limit 1";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                compaerea.Id = reader.GetInt32(0);
                MessageBox.Show("Companhia Aerea " + compaerea.Id +" - "+  compaerea.Nome + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

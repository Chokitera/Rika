using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;

namespace Rika.dao
{
    public class AviaoDAO
    {
        private MySqlConnection conexao;
        public AviaoDAO(){
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Avião

        public bool CadastrarAviao(Aviao aviao)
        {
            try
            {
                string sql = @"insert into aviao (qtd_acentos, modelo)
                                    values (@qtd_acentos, @modelo);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd_acentos", aviao.Qtd_Acento);
                executacmd.Parameters.AddWithValue("@modelo", aviao.Modelo);
                //executacmd.Parameters.AddWithValue("@comp", aviao.comp.Id);
                //executacmd.Parameters.AddWithValue("@voo", aviao.voo.Id);

                //Consultar último usuário para consulta
                string sql2 = @"select idaviao from aviao order by idaviao desc limit 1";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                aviao.Id = reader.GetInt32(0);
                MessageBox.Show("Avião " + aviao.Id + " - " + aviao.Modelo +  " cadastrado com sucesso!  ",  "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

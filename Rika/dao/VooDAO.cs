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
    public class VooDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public VooDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de voo
        public bool EfetuarCadastro(Voo voo)
        {
            try
            {
                string sql = @"insert into VOO (IDAEROPORTO, IDAVIAO, DT_SAIDA, DT_CHEGADA, DURACAO, HORARIO_SAIDA, HORARIO_CHEGADA, DESTINO, DECOLAGEM) 
                               values (@IDAEROPORTO, @IDAVIAO, @DT_SAIDA, @DT_CHEGADA, @DURACAO, @HORARIO_SAIDA, @HORARIO_CHEGADA, @DESTINO, @DECOLAGEM);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IDAEROPORTO", voo.aeroporto.Id);
                executacmd.Parameters.AddWithValue("@IDAVIAO", voo.aviao.Id);
                executacmd.Parameters.AddWithValue("@DT_SAIDA", voo.DataSaida);
                executacmd.Parameters.AddWithValue("@DT_CHEGADA", voo.DataChegada);
                executacmd.Parameters.AddWithValue("@DURACAO", voo.Duracao);
                executacmd.Parameters.AddWithValue("@HORARIO_SAIDA", voo.HorarioSaida);
                executacmd.Parameters.AddWithValue("@HORARIO_CHEGADA", voo.HorarioChegada);
                executacmd.Parameters.AddWithValue("@DESTINO", voo.Destino);
                executacmd.Parameters.AddWithValue("@DECOLAGEM", voo.Decolagem);

                //Consultar o último registro
                string sql2 = @"select IDVOO from VOO order by IDVOO desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                voo.Id = reader.GetInt32(0);
                MessageBox.Show("Endereço " + voo.Id + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de voo
        public bool ExcluirVoo(Voo voo)
        {
            try
            {
                string sql = @"delete from VOO where IDVOO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", voo.Id);

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

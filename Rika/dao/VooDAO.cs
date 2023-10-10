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

        #region Método para editar voo 
        public bool EfetuarEdicao( Voo voo)
        {
            try
            {
                string sql = @"update VOO set IdAeropoto=@IdAeroporto, IdAviao=@IdAviao, Dt_Saida=@Dt_Saida, Dt_Chegada=@Dt_Chegada, Duracao=@Duracao, Horario_Saida=@Horario_Saida, 
                                              Horario_Chegada=@Horario_Chegada, Destino=@Destino, Decolagem=@Decolagem
                               where IDVOO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IdAeroporto", voo.aeroporto.Id);
                executacmd.Parameters.AddWithValue("@IdAviao", voo.aviao.Id);
                executacmd.Parameters.AddWithValue("@Dt_Saida", voo.DataSaida);
                executacmd.Parameters.AddWithValue("@Dt_Chegada", voo.DataChegada);
                executacmd.Parameters.AddWithValue("@Duracao", voo.Duracao);
                executacmd.Parameters.AddWithValue("@Horario_Saida", voo.HorarioSaida);
                executacmd.Parameters.AddWithValue("@Horario_Chegada", voo.HorarioChegada);
                executacmd.Parameters.AddWithValue("@Destino", voo.Destino);
                executacmd.Parameters.AddWithValue("@Decolagem", voo.Decolagem);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Voo " + voo.Id + " - " + voo.Destino + " atualizado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica voo 
        public Voo ConsultarCompanhiaPorId(Voo voo)
        {
            try
            {
                //Sql
                string sql = @"select * from VOO where IDVOO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", voo.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    voo.Destino = 0;
                    MessageBox.Show("Voo não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    voo.aeroporto.Id = reader.GetInt32(1);
                    voo.aviao.Id = reader.GetInt32(2);
                    voo.DataSaida = reader.GetDateTime(3);
                    voo.DataChegada = reader.GetDateTime(4);
                    voo.Duracao = reader.GetDateTime(5);
                    voo.HorarioSaida = reader.GetDateTime(6);
                    voo.HorarioChegada = reader.GetDateTime(7);
                    voo.Destino = reader.GetInt32(8);
                    voo.Decolagem = reader.GetInt32(9);
                }

                conexao.Close();

                return voo;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return voo;
            }
        }
        #endregion

    }
}

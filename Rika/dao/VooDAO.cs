using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Data;
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
                string destino = "";
                string sql = @"insert into VOO (IDAVIAO, DT_SAIDA, DT_CHEGADA, DURACAO, HORARIO_SAIDA, HORARIO_CHEGADA, DESTINO, DECOLAGEM) 
                               values (@IDAVIAO, @DT_SAIDA, @DT_CHEGADA, @DURACAO, @HORARIO_SAIDA, @HORARIO_CHEGADA, @DESTINO, @DECOLAGEM);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
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

                //Consulta o nome do Aeroporto Destino
                string sql3 = @"select NOME from AEROPORTO where IDAEROPORTO = @id";
                MySqlCommand executacmd3 = new MySqlCommand(sql3, conexao);
                executacmd3.Parameters.AddWithValue("@id", voo.Destino);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Id do Voo
                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                voo.Id = reader.GetInt32(0);

                //Restabelece a conexao
                conexao.Close();
                conexao.Open();

                //Nome do Destino
                MySqlDataReader reader1 = executacmd3.ExecuteReader();
                reader1.Read();
                destino = reader1.GetString(0);

                MessageBox.Show("Voo " + voo.Id + " - Destino: " + destino + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string destino = "";
                string sql = @"update VOO set IdAviao=@IdAviao, Dt_Saida=@Dt_Saida, Dt_Chegada=@Dt_Chegada, Duracao=@Duracao, Horario_Saida=@Horario_Saida, 
                                              Horario_Chegada=@Horario_Chegada, Destino=@Destino, Decolagem=@Decolagem
                               where IDVOO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", voo.Id);
                executacmd.Parameters.AddWithValue("@IdAviao", voo.aviao.Id);
                executacmd.Parameters.AddWithValue("@Dt_Saida", voo.DataSaida);
                executacmd.Parameters.AddWithValue("@Dt_Chegada", voo.DataChegada);
                executacmd.Parameters.AddWithValue("@Duracao", voo.Duracao);
                executacmd.Parameters.AddWithValue("@Horario_Saida", voo.HorarioSaida);
                executacmd.Parameters.AddWithValue("@Horario_Chegada", voo.HorarioChegada);
                executacmd.Parameters.AddWithValue("@Destino", voo.Destino);
                executacmd.Parameters.AddWithValue("@Decolagem", voo.Decolagem);

                //Consulta o nome do Aeroporto Destino
                string sql2 = @"select NOME from AEROPORTO where IDAEROPORTO = @id";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);
                executacmd2.Parameters.AddWithValue("@id", voo.Destino);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Restabelece a conexao
                conexao.Close();
                conexao.Open();

                //Nome do Destino
                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                destino = reader.GetString(0);

                MessageBox.Show("Voo " + voo.Id + " - Destino: " + destino + " atualizado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        #region Método para consultar específica voo 
        public Voo ConsultarVooPorId(Voo voo)
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
                    voo.Destino = reader.GetInt32(1);
                    voo.Decolagem = reader.GetInt32(2);
                    voo.aviao.Id = reader.GetInt32(3);
                    voo.DataSaida = reader.GetDateTime(4);
                    voo.DataChegada = reader.GetDateTime(5);
                    voo.Duracao = reader.GetString(6);
                    voo.HorarioSaida = reader.GetString(7);
                    voo.HorarioChegada = reader.GetString(8);
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

        #region Método para consultar voo e preencher a DataTable
        public DataTable ConsultarVoos(Voo voo)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select a.modelo, v.idvoo, v.dt_saida, v.dt_chegada, v.duracao, v.horario_saida, v.horario_chegada from aviao a 
                               inner join voo v on a.idaviao = v.idaviao
                               where a.modelo like @modelo;";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@modelo", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@idvoo", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@dt_saida", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@dt_chegada", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@duracao", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@horario_saida", voo.aviao.Modelo);
                executacmd.Parameters.AddWithValue("@horario_chegada", voo.aviao.Modelo);

                //Abre a conexao e executa Sql
                conexao.Open();

                //Preenche o DataTable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(dt);

                conexao.Close();

                return dt; //Retorna a DT
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return null;
            }
        }
        #endregion
    }
}

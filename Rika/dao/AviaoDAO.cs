using System;
using System.Collections.Generic;
using System.Data;
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
        //Conexao Banco
        private MySqlConnection conexao;
        public AviaoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para Cadastrar Avião

        public bool CadastrarAviao(Aviao aviao)
        {
            try
            {
                string sql = @"insert into aviao (qtd_acentos, modelo, IDCOMP_AEREA)
                                    values (@qtd_acentos, @modelo, @comp);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd_acentos", aviao.Qtd_Acento);
                executacmd.Parameters.AddWithValue("@modelo", aviao.Modelo);
                executacmd.Parameters.AddWithValue("@comp", aviao.comp.Id);

                //Consultar último registro
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

        #region Método para exclusão de Avião
        public bool ExcluirAviao(Aviao aviao)
        {
            try
            {
                string sql = @"delete from AVIAO where IDAVIAO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", aviao.Id);

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

        #region Método para editar Avião
        public bool EfetuarEdicao(Aviao aviao)
        {
            try
            {
                string sql = @"update AVIAO set modelo=@modelo, idComp_Aerea=@idComp_Aerea, Qtd_Acento=@Qtd_Acento
                               where AVIAO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", aviao.Id);
                executacmd.Parameters.AddWithValue("@modelo", aviao.Modelo);
                executacmd.Parameters.AddWithValue("@idComp_Aerea", aviao.comp.Id);
                executacmd.Parameters.AddWithValue("@Qtd_Acento", aviao.Qtd_Acento);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Avião " + aviao.Id + " - " + aviao.Modelo + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específico Avião 
        public Aviao ConsultarAviaoPorId(Aviao aviao)
        {
            try
            {
                //Sql
                string sql = @"select * from AVIAO where IDAVIAO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", aviao.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    aviao.Modelo = "";
                    MessageBox.Show("Modelo não encontrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    aviao.comp.Id = reader.GetInt32(1);
                    aviao.Modelo = reader[2].ToString();
                    aviao.Qtd_Acento = reader.GetInt32(3);
                }

                conexao.Close();

                return aviao;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return aviao;
            }
        }
        #endregion

        #region Consultar Aviao
        public DataTable ConsultarAviao(Aviao aviao)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select * from tipo_venda where nome like @nome";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", aviao.Nome);

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

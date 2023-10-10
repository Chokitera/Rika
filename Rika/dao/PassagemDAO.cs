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
    public class PassagemDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public PassagemDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de passagem
        public bool EfetuarCadastro(Passagem passagem)
        {
            try
            {
                string sql = @"insert into PASSAGEM (IDVOO, IDSITUACAO, IDCLASSE, COD_PASS, VALOR, DIRETO_ESCALA, CAMINHO_IMG) 
                               values (@IDVOO, @IDSITUACAO, @IDCLASSE, @COD_PASS, @VALOR, @DIRETO_ESCALA, @CAMINHO_IMG);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IDVOO", passagem.voo.Id);
                executacmd.Parameters.AddWithValue("@IDSITUACAO", passagem.situacao.Id);
                executacmd.Parameters.AddWithValue("@IDCLASSE", passagem.classe.Id);
                executacmd.Parameters.AddWithValue("@COD_PASS", passagem.Cod_Passagem);
                executacmd.Parameters.AddWithValue("@VALOR", passagem.Valor);
                executacmd.Parameters.AddWithValue("@DIRETO_ESCALA", passagem.Direto_Escala);
                executacmd.Parameters.AddWithValue("@CAMINHO_IMG", passagem.Caminho_Img);

                //Consultar o último registro
                string sql2 = @"select IDPASSAGEM from PASSAGEM order by IDPASSAGEM desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                passagem.Id = reader.GetInt32(0);
                MessageBox.Show("Passagem " + passagem.Id + " - " + passagem.Cod_Passagem + " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de passagem
        public bool ExcluirPassagem(Passagem passagem)
        {
            try
            {
                string sql = @"delete from PASSAGEM where IDPASSAGEM = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", passagem.Id);

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

        #region Método para editar passagem 
        public bool EfetuarEdicao(Passagem passagem)
        {
            try
            {
                string sql = @"update PASSAGEM set IdVoo=@IdVoo, IdSituacao=@IdSituacao, IdClasse=@IdClasse, Cod_Passagem=@Cod_Passagem, Direto_Escala=@Direto_Escala, Caminho_Img=@Caminho_Img
                               where IDPASSAGEM = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", passagem.Id);
                executacmd.Parameters.AddWithValue("@IdVoo", passagem.voo.Id);
                executacmd.Parameters.AddWithValue("@IdSituacao", passagem.situacao.Id);
                executacmd.Parameters.AddWithValue("@IdClasse", passagem.classe.Id);
                executacmd.Parameters.AddWithValue("@Cod_Passagem", passagem.Cod_Passagem);
                executacmd.Parameters.AddWithValue("@Direto_Escala", passagem.Direto_Escala);
                executacmd.Parameters.AddWithValue("@Caminho_Img", passagem.Caminho_Img);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show(" Passagem " + passagem.Id + " - " + passagem.Cod_Passagem + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Passagem
        public Passagem ConsultarPassagemPorId(Passagem passagem)
        {
            try
            {
                //Sql
                string sql = @"select * from PASSAGEM where IDPASAGEM = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", passagem.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    passagem.Cod_Passagem = "";
                    MessageBox.Show("Passagem não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    passagem.voo.Id = reader.GetInt32(1);
                    passagem.situacao.Id = reader.GetInt32(2);
                    passagem.classe.Id = reader.GetInt32(3);
                    passagem.Cod_Passagem = reader[4].ToString();
                    passagem.Valor = reader.GetInt32(5);
                    passagem.Direto_Escala = reader[6].ToString();
                    passagem.Caminho_Img = reader[7].ToString();
                }

                conexao.Close();

                return passagem;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return passagem;
            }
        }
        #endregion

    }
}

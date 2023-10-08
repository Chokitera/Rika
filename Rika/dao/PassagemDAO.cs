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
    }
}

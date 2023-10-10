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
    public class CarrinhoCompraDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public CarrinhoCompraDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de carrinho de compra
        public bool EfetuarCadastro(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                string sql = @"insert into CARRINHOCOMPRA (IDUSUARIO, IDPASSAGEM, DT_ADICAO) 
                               values (@IDUSUARIO, @IDPASSAGEM, @DT_ADICAO);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IDUSUARIO", carrinhoCompra.Usuario.Id);
                executacmd.Parameters.AddWithValue("@IDPASSAGEM", carrinhoCompra.passagem.Id);
                executacmd.Parameters.AddWithValue("@DT_ADICAO", carrinhoCompra.Dt_Adicao);

                //Consultar o último registro
                //string sql2 = @"select IDCOMP_AEREA from COMP_AEREA order by IDCOMP_AEREA desc limit 1;";
                //MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MySqlDataReader reader = executacmd2.ExecuteReader();
                //reader.Read();
                //carrinhoCompra.Id = reader.GetInt32(0);
                //MessageBox.Show("Item " + carrinhoCompra.Id + " - " + carrinhoCompra.Nome + " adicionado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de carrinho de compra
        public bool ExcluirCarrinho(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                string sql = @"delete from CARRINHOCOMPRA where IDCARRINHO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", carrinhoCompra.Id);

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

        #region Método para editar Carrinho de Compra
        public bool EfetuarEdicao(CarrinhoCompra carrinhocompra)
        {
            try
            {
                string sql = @"update CARRINHOCOMPRA set idusuario=@idusuario, idpassagem=@idpassagem, dt_adicao=@dt_adicao
                               where IDCARRINHO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", carrinhocompra.Id);
                executacmd.Parameters.AddWithValue("@idusuario", carrinhocompra.Usuario.Id);
                executacmd.Parameters.AddWithValue("@idpassagem", carrinhocompra.passagem.Id);
                executacmd.Parameters.AddWithValue("@dt_adicao", carrinhocompra.Dt_Adicao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Carrinho " + carrinhocompra.Id + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específico carrinho de compra
        public CarrinhoCompra ConsultarCompanhiaPorId(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                //Sql
                string sql = @"select * from CARRIHNOCOMPRA where IDCARRINHO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", carrinhoCompra.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    carrinhoCompra.Id = 0;
                    MessageBox.Show("Carrinho não encontrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    carrinhoCompra.Usuario.Id = reader.GetInt32(1);
                    carrinhoCompra.passagem.Id = reader.GetInt32(2);
                    carrinhoCompra.Dt_Adicao = reader.GetDateTime(3);
                }

                conexao.Close();

                return carrinhoCompra;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return carrinhoCompra;
            }
        }
        #endregion
    }
}

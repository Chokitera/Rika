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
                string sql = @"insert into CARRINHOCOMPRA (IDUSUARIO, IDPASSAGEM, DT_ADICAO, QUANTIDADE) 
                               values (@IDUSUARIO, @IDPASSAGEM, @DT_ADICAO, @QUANTIDADE);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@IDUSUARIO", carrinhoCompra.usuario.Id);
                executacmd.Parameters.AddWithValue("@QUANTIDADE", carrinhoCompra.Quantidade);
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
                //MessageBox.Show("O cadastro foi apagado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public bool EfetuarEdicao(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                string sql = @"update CARRINHOCOMPRA set idusuario=@idusuario, idpassagem=@idpassagem, dt_adicao=@dt_adicao, quantidade=@quantidade
                               where IDCARRINHO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", carrinhoCompra.Id);
                executacmd.Parameters.AddWithValue("@quantidade", carrinhoCompra.Quantidade);
                executacmd.Parameters.AddWithValue("@idusuario", carrinhoCompra.usuario.Id);
                executacmd.Parameters.AddWithValue("@idpassagem", carrinhoCompra.passagem.Id);
                executacmd.Parameters.AddWithValue("@dt_adicao", carrinhoCompra.Dt_Adicao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Carrinho " + carrinhoCompra.Id + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para editar a Quantidade do item no Carrinho de Compra
        public bool AtualizarQuantidadeCarrinhoCompra(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                string sql = @"update CARRINHOCOMPRA set quantidade=@quantidade
                               where IDCARRINHO = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", carrinhoCompra.Id);
                executacmd.Parameters.AddWithValue("@quantidade", carrinhoCompra.Quantidade);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Carrinho " + carrinhoCompra.Id + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public CarrinhoCompra ConsultarCarrinhoCompraPorId(CarrinhoCompra carrinhoCompra)
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
                    carrinhoCompra.usuario.Id = reader.GetInt32(1);
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

        #region Método para consultar o carrinho de compras
        public DataTable CarregarCarrinhoCompra()
        {
            try
            {
                //Inicialização
                DataTable dataTable = new DataTable();

                //Sql
                string sql = @"SELECT C.IDCARRINHO, C.IDUSUARIO, C.DT_ADICAO, C.IDPASSAGEM CODPASS, E.CIDADE CIDADE, V.DT_SAIDA DATASAIDA, V.HORARIO_SAIDA HOR_SAI,
                               V.HORARIO_CHEGADA HOR_CHE, P.VALOR VALOR, P.CAMINHO_IMG, C.QUANTIDADE QTD_ITEM
                               FROM ENDERECO E
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DESTINO = A.IDAEROPORTO)
                               INNER JOIN PASSAGEM P ON (P.IDVOO = V.IDVOO)
                               INNER JOIN CARRINHOCOMPRA C ON (C.IDPASSAGEM = P.IDPASSAGEM)"; //Colocar um order by e wherer usuario = usuario logado

                //Passa os paramentros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //Abre a conexão
                conexao.Open();

                //Executa o Sql e obtem o retorno
                MySqlDataReader reader = executacmd.ExecuteReader();

                reader.Read();
                dataTable.Load(reader);
                reader.Close();

                conexao.Close();

                //Retorna o resultado
                return dataTable;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}

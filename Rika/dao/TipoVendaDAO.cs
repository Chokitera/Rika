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
    public class TipoVendaDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public TipoVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de tipo de venda
        public bool EfetuarCadastro(TipoVenda tipoVenda)
        {
            try
            {
                string sql = @"insert into TIPO_VENDA (nome, descricao) 
                               values (@nome, @descricao);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", tipoVenda.Descricao);
                executacmd.Parameters.AddWithValue("@nome", tipoVenda.Nome); //RICHARD


                //Consultar último registro
                string sql2 = @"select IDTIPO_VENDA from TIPO_VENDA order by IDTIPO_VENDA desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                tipoVenda.Id = reader.GetInt32(0);
                MessageBox.Show("Tipo de Venda " + tipoVenda.Id + " - " + tipoVenda.Nome+ " cadastrada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para exclusão de Tipo de Venda
        public bool ExcluirTipoVenda(TipoVenda tipoVenda)
        {
            try
            {
                string sql = @"delete from TIPO_VENDA where IDTIPO_VENDA = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", tipoVenda.Id);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Mensagem que aparou o registro
                MessageBox.Show("O cadastro foi excluído com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para editar Tipo de Venda
        public bool EfetuarEdicao(TipoVenda tipovenda)
        {
            try
            {
                string sql = @"update TIPO_VENDA set nome=@nome, descricao=@descricao
                               where IDTIPO_VENDA = @id;";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", tipovenda.Id);
                executacmd.Parameters.AddWithValue("@descricao", tipovenda.Descricao);
                executacmd.Parameters.AddWithValue("@nome", tipovenda.Nome);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Tipo de Venda " + tipovenda.Id + " - " + tipovenda.Nome + " atualizada com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para consultar específica Tipo de Venda
        public TipoVenda ConsultarTipoVendaPorId(TipoVenda tipovenda)
        {
            try
            {
                //Sql
                string sql = @"select * from TIPO_VENDA where IDTIPO_VENDA = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", tipovenda.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    tipovenda.Descricao = "";
                    MessageBox.Show("Tipo de venda não encontrada!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tipovenda.Nome = reader[1].ToString();
                    tipovenda.Descricao = reader[2].ToString();
                }

                conexao.Close();

                return tipovenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return tipovenda;
            }
        }
        #endregion

        #region Método para consultar os tipos de vendas e preencher a DataTable
        public DataTable ConsultarTipoVendas(TipoVenda tipoVenda)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select * from tipo_venda where nome like @nome";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", tipoVenda.Nome);

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

        #region Consultar Tipo de Venda
        public DataTable ConsultarTipoVenda(TipoVenda tipoVenda)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select * from tipo_venda where nome like @nome";

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", tipoVenda.Nome);

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
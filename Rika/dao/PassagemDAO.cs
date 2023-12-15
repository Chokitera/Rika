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

                //Define o Código da Passagem (Identificação)
                passagem.Cod_Passagem = ConsultaAeroportoPassagem(passagem);

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
                string sql = @"update PASSAGEM set IdVoo=@IdVoo, IdSituacao=@IdSituacao, IdClasse=@IdClasse, COD_PASS=@Cod_Passagem, Direto_Escala=@Direto_Escala, Caminho_Img=@Caminho_Img
                               where IDPASSAGEM = @id;";

                //Define o Código da Passagem (Identificação)
                passagem.Cod_Passagem = ConsultaAeroportoPassagem(passagem);

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
                string sql = @"select * from PASSAGEM where IDPASSAGEM = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", passagem.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Le os dados
                if (!reader.Read())
                {
                    passagem.Direto_Escala = "";
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

        #region Método para Consultar os Aeroportos da Passagem
        public string ConsultaAeroportoPassagem(Passagem passagem)
        {
            try
            {
                //Sql
                string sql = @"SELECT DECOLAGEM.PAIS DECOLAGEM, DESTINO.PAIS DESTINO FROM(
                               SELECT PS.SIGLA AS PAIS, V.IDVOO VOO FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DECOLAGEM = A.IDAEROPORTO)
                               ) DECOLAGEM
                               JOIN (
                               SELECT PS.SIGLA AS PAIS, V.IDVOO VOO  FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DESTINO = A.IDAEROPORTO)
                               ) DESTINO ON (DECOLAGEM.VOO = DESTINO.VOO)
                               WHERE DESTINO.VOO = @id";

                //Definindo o comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", passagem.voo.Id);

                //Consultar o último registro (código da passagem)
                string sql2 = @"select IDPASSAGEM from PASSAGEM order by IDPASSAGEM desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa Comando e abre a conexao
                conexao.Open();

                MySqlDataReader reader2 = executacmd2.ExecuteReader();
                reader2.Read();
                if (reader2.GetInt32(0) > 0)
                    passagem.Id = reader2.GetInt32(0) + 1; // +1 pois é o próximo código a ser serializado
                else
                    passagem.Id = 1;

                //Finaliza a conexão e sessão
                reader2.Close();
                conexao.Close();

                //Abre novamente a conexão
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();
                reader.Read();

                //Monta o Código da Passagem ----> País Origem + Código Passagem + País Destino
                passagem.Cod_Passagem = reader.GetString(0);
                passagem.Cod_Passagem += passagem.Id.ToString();
                passagem.Cod_Passagem += reader.GetString(1);

                //Fecha conexão e sessão
                conexao.Close();

                return passagem.Cod_Passagem;
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

        #region Método para consultar passagens e preencher a DataTable
        public DataTable ConsultarPassagens(Passagem passagem)
        {
            try
            {
                //Criacao do DataTable
                DataTable dt = new DataTable();

                //Sql
                string sql = @"select idpassagem, cod_pass, valor, direto_escala

                               from passagem p
                               inner join situacao s
                               where idpassagem like @idpassagem";
                               

                //Atribuição de parametro
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idpassagem", passagem.Id);
                executacmd.Parameters.AddWithValue("@cod_pass", passagem.Cod_Passagem);
                executacmd.Parameters.AddWithValue("@valor", passagem.Valor);
                executacmd.Parameters.AddWithValue("@direto_escala", passagem.Direto_Escala);

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

        #region Método para consultar as passagens iniciais
        public DataTable CarregarPassagensIniciais()
        {
            try
            {
                //Inicialização
                DataTable dataTable = new DataTable();

                //Sql
                string sql = @"SELECT DESTINO.CODPASS PASSAGEM, DECOLAGEM.PAIS DECOLAGEM, DESTINO.PAIS DESTINO, DESTINO.PAISNOME, DESTINO.CIDADE, DESTINO.DATASAIDA, DESTINO.DIR_ESC,
                               DESTINO.CLASSE, DESTINO.VALOR, DESTINO.CAMINHO_IMG
                               FROM(
                               SELECT P.IDPASSAGEM CODPASS, PS.SIGLA AS PAIS FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DECOLAGEM = A.IDAEROPORTO)
                               INNER JOIN PASSAGEM P ON (P.IDVOO = V.IDVOO)
                               ) DECOLAGEM
                               JOIN (
                               SELECT P.IDPASSAGEM CODPASS, PS.SIGLA AS PAIS, PS.NOME PAISNOME, E.CIDADE CIDADE, V.DT_SAIDA DATASAIDA, P.DIRETO_ESCALA DIR_ESC,
                               C.NOME CLASSE, P.VALOR VALOR, P.CAMINHO_IMG
                               FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DESTINO = A.IDAEROPORTO)
                               INNER JOIN PASSAGEM P ON (P.IDVOO = V.IDVOO)
                               INNER JOIN CLASSE C ON (C.IDCLASSE = P.IDCLASSE)
                               ) DESTINO ON (DECOLAGEM.CODPASS = DESTINO.CODPASS)";

                //Passa os paramentros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //Abre a conexão
                conexao.Open();

                //Executa o Sql e obtem o retorno
                //MySqlDataReader reader = executacmd.ExecuteReader();

                //reader.Read();
                //dataTable.Load(reader);
                //reader.Close();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(dataTable);

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

        #region Método para consultar as passagens mais populares
        public DataTable CarregarPassagensPopulares()
        {
            try
            {
                //Inicialização
                DataTable dataTable = new DataTable();

                //Sql
                string sql = @"SELECT DESTINO.CODPASS PASSAGEM, DECOLAGEM.PAIS DECOLAGEM, DESTINO.PAIS DESTINO, DESTINO.PAISNOME, DESTINO.CIDADE, DESTINO.DATASAIDA, DESTINO.DIR_ESC,
                               DESTINO.CLASSE, DESTINO.VALOR, DESTINO.CAMINHO_IMG
                               FROM(
                               SELECT P.IDPASSAGEM CODPASS, PS.SIGLA AS PAIS FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DECOLAGEM = A.IDAEROPORTO)
                               INNER JOIN PASSAGEM P ON (P.IDVOO = V.IDVOO)
                               ) DECOLAGEM
                               JOIN (
                               SELECT P.IDPASSAGEM CODPASS, PS.SIGLA AS PAIS, PS.NOME PAISNOME, E.CIDADE CIDADE, V.DT_SAIDA DATASAIDA, P.DIRETO_ESCALA DIR_ESC,
                               C.NOME CLASSE, P.VALOR VALOR, P.CAMINHO_IMG
                               FROM PAIS PS
                               INNER JOIN ENDERECO E ON (E.IDPAIS = PS.IDPAIS)
                               INNER JOIN AEROPORTO A ON (A.IDENDERECO = E.IDENDERECO)
                               INNER JOIN VOO V ON (V.DESTINO = A.IDAEROPORTO)
                               INNER JOIN PASSAGEM P ON (P.IDVOO = V.IDVOO)
                               INNER JOIN CLASSE C ON (C.IDCLASSE = P.IDCLASSE)
                               ) DESTINO ON (DECOLAGEM.CODPASS = DESTINO.CODPASS)";

                //Passa os paramentros
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                //Abre a conexão
                conexao.Open();

                //Executa o Sql e obtem o retorno
                //MySqlDataReader reader = executacmd.ExecuteReader();

                //reader.Read();
                //dataTable.Load(reader);
                //reader.Close();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(dataTable);

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

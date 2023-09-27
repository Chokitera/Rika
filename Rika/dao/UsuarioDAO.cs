using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.dao
{
    public class UsuarioDAO
    {
        private MySqlConnection conexao;
        public UsuarioDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para efetuar o login
        public bool EfetuarLogin(Usuario usuario)
        {
            try
            {
                string sql = @"select * from usuarios where nome_usuario = @nome and senha = @senha";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("nome", usuario.NomeUsuario);
                executacmd.Parameters.AddWithValue("senha", usuario.Senha);

                conexao.Open();
                
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //Login foi realizado com sucesso
                    MessageBox.Show("Login realizado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorreta!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conexao.Close();
                    return false;
                }

                    
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return false;
            }
        }
        #endregion

        #region Método para cadastro de usuários
        public bool EfetuarCadastro(Usuario usuario)
        {
            try
            {
                string sql = @"insert into usuarios (nome, sobrenome, nome_usuario, senha, tipo) 
                               values (@nome, @sobrenome, @nome_usuario, @senha, @tipo);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", usuario.Nome);
                executacmd.Parameters.AddWithValue("@sobrenome", usuario.SobreNome);
                executacmd.Parameters.AddWithValue("@nome_usuario", usuario.NomeUsuario);
                executacmd.Parameters.AddWithValue("@senha", usuario.Senha);
                executacmd.Parameters.AddWithValue("@tipo", usuario.Tipo);

                //Consultar último usuário para consulta
                string sql2 = @"select id from usuarios order by id desc limit 1";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                usuario.Id = reader.GetInt32(0);
                MessageBox.Show("Usuário cadastrado com sucesso!\n\nCódigo do usuário: " + usuario.Id + " - " + usuario.NomeUsuario, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Método para verificar se ja possuí o nome de usuário cadastrado
        public bool ValidarNome(Usuario usuario) 
        {
            try
            {
                string sql = @"select from usuarios where nome_usuario = @nome";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", usuario.NomeUsuario);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //Login foi realizado com sucesso
                    MessageBox.Show("Login realizado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    return true;
                }
                else
                {
                    return false;
                }
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



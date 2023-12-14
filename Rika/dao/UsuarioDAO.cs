using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.dao
{
    public class UsuarioDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public UsuarioDAO() {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para efetuar o login
        public bool EfetuarLogin(Usuario usuario)
        {
            try
            {
                string sql = @"select * from usuarios where NOMEUSUARIO = @NOMEUSUARIO and senha = @senha";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("NOMEUSUARIO", usuario.NomeUsuario);
                executacmd.Parameters.AddWithValue("senha", usuario.Senha);

                conexao.Open();
                
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //Login foi realizado com sucesso
                    MessageBox.Show("Login realizado com sucesso! Bem vindo " + usuario.NomeUsuario + "!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql = @"insert into usuarios (nome, sobrenome, NOMEUSUARIO, senha, tipousuario) 
                               values (@nome, @sobrenome, @NOMEUSUARIO, @senha, @tipo);";

                //Atributos
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", usuario.Nome);
                executacmd.Parameters.AddWithValue("@sobrenome", usuario.SobreNome);
                executacmd.Parameters.AddWithValue("@NOMEUSUARIO", usuario.NomeUsuario);
                executacmd.Parameters.AddWithValue("@senha", usuario.Senha);
                executacmd.Parameters.AddWithValue("@tipo", usuario.Tipo);

                //Consultar último usuário
                string sql2 = @"select idusuario from usuarios order by idusuario desc limit 1;";
                MySqlCommand executacmd2 = new MySqlCommand(sql2, conexao);

                //Executa SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataReader reader = executacmd2.ExecuteReader();
                reader.Read();
                usuario.Id = reader.GetInt32(0);
                MessageBox.Show("Usuário " + usuario.NomeUsuario + " cadastrado com sucesso!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region Buscar usuário pelo ID

        public Usuario ConsultarUsuarioPorId(Usuario usuario)
        {
            try
            {
                //SQL
                string sql = @"select * from USUARIOS where IDUSUARIO = @id;";

                //Comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", usuario.Id);

                //Executa SQL
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                //Lê os dados
                if (!reader.Read()) 
                {
                    usuario.Nome = "";
                    MessageBox.Show("Usuário não encontrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    usuario.Nome = reader[1].ToString();
                    usuario.NomeUsuario = reader[2].ToString();
                    //usuario.Senha = reader[3].ToString();
                    //Tipo = reader[4];
                }

                conexao.Close();

                return usuario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return usuario;
            }
        }

        #endregion

        #region Método para verificar se ja possuí o nome de usuário cadastrado
        public bool ValidarNome(Usuario usuario) 
        {
            try
            {
                string sql = @"select NOMEUSUARIO from usuarios where NOMEUSUARIO = @NOMEUSUARIO";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@NOMEUSUARIO", usuario.NomeUsuario);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    MessageBox.Show("Usuário já cadastrado!", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    return true;
                }
                return false;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return false;
            }
        }
        #endregion

        #region Método para exclusão usuário
        public bool ExcluirUsuario(Usuario usuario)
        {
            try
            {
                string sql = @"delete from USUARIOS where IDUSUARIO = @id;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", usuario.Id);

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

        #region Método para verificar se o usuário é Administrador
        public Usuario ValidarTipoUsuario(Usuario usuario)
        {
            try
            {
                string sql = @"select TIPOUSUARIO, IDUSUARIO from usuarios where NOMEUSUARIO = @NOMEUSUARIO AND SENHA = @SENHA";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@NOMEUSUARIO", usuario.NomeUsuario);
                executacmd.Parameters.AddWithValue("@SENHA", usuario.Senha);

                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario.Tipo = reader.GetInt32(0);
                    usuario.Id = reader.GetInt32(1);
                }

                conexao.Close();
                return usuario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                return usuario;
            }
        }
        #endregion

    }
}



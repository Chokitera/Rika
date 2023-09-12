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
    public class LoginDAO
    {
        private MySqlConnection conexao;
        public LoginDAO() {
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
    }
}

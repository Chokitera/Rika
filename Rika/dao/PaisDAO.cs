using MySql.Data.MySqlClient;
using Rika.models;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.dao
{
    public class PaisDAO
    {
        private MySqlConnection conexao;
        public PaisDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastro de país

        public bool EfetuarCadastroPais(Pais pais)
        {
            return true;
        }

        #endregion  
    }
}

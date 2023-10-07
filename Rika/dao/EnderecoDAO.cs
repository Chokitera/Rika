using MySql.Data.MySqlClient;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.dao
{
    public class EnderecoDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public EnderecoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
    }
}

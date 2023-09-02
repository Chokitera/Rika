using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Solucao.conexao
{
    public class ConnectionFactory
    {
        //metodo p realizar a conexao

        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["rika"].ConnectionString;
            return new MySqlConnection(conexao);
        }

    }
}
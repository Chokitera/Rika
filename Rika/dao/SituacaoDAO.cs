using MySql.Data.MySqlClient;
using Solucao.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.dao
{
    public class SituacaoDAO
    {
        //Conexao Banco
        private MySqlConnection conexao;
        public SituacaoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
    }
}

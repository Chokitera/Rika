using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class EnderecoController
    {
        private Endereco endereco;
        private EnderecoDAO enderecoDAO;
        public EnderecoController()
        {
            endereco = new Endereco();
            enderecoDAO = new EnderecoDAO();
        }
    }
}

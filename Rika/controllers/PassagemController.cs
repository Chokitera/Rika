using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class PassagemController
    {
        private Passagem passagem;
        private PassagemDAO passagemDAO;
        public PassagemController()
        {
            passagem = new Passagem();
            passagemDAO = new PassagemDAO();
        }
    }
}

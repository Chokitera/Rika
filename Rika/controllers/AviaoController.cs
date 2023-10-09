using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class AviaoController
    {
        private Aviao aviao;
        private AviaoDAO aviaoDAO;
        public AviaoController()
        {
            aviao = new Aviao();
            aviaoDAO = new AviaoDAO();
        }
    }
}

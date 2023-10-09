using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class PaisController
    {
        private Pais pais;
        private PaisDAO paisDAO;
        public PaisController()
        {
            pais = new Pais();
            paisDAO = new PaisDAO();
        }
    }
}

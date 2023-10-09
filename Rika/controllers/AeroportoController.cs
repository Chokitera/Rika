using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class AeroportoController
    {
        private Aeroporto aeroporto;
        private AeroportoDAO aeroportoDAO;
        public AeroportoController()
        {
            aeroporto = new Aeroporto();
            aeroportoDAO = new AeroportoDAO();
        }
    }
}

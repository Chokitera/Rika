using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class VooController
    {
        private Voo voo;
        private VooDAO vooDAO;
        public VooController()
        {
            voo = new Voo();
            vooDAO = new VooDAO();
        }
    }
}

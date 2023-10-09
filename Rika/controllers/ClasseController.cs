using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class ClasseController
    {
        private Classe classe;
        private ClasseDAO classeDAO;
        public ClasseController()
        {
            classe = new Classe();
            classeDAO = new ClasseDAO();
        }
    }
}

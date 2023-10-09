using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class SituacaoController
    {
        private Situacao situacao;
        private SituacaoDAO situacaoDAO;
        public SituacaoController()
        {
            situacao = new Situacao();
            situacaoDAO = new SituacaoDAO();
        }
    }
}

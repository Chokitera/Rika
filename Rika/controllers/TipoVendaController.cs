using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class TipoVendaController
    {
        private TipoVenda tipoVenda;
        private TipoVendaDAO tipoVendaDAO;

        public TipoVendaController()
        {
            tipoVenda = new TipoVenda();
            tipoVendaDAO = new TipoVendaDAO();
        }
    }
}

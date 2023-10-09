using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class CarrinhoCompraController
    {
        private CarrinhoCompra carrinhoCompra;
        private CarrinhoCompraDAO carrinhoCompraDAO;
        public CarrinhoCompraController()
        {
            carrinhoCompra = new CarrinhoCompra();
            carrinhoCompraDAO = new CarrinhoCompraDAO();
        }
    }
}

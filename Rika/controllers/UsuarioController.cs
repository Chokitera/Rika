using Rika.dao;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.controllers
{
    public class UsuarioController
    {
        private Usuario usuario;
        private UsuarioDAO usuarioDAO;
        public UsuarioController()
        {
            usuario = new Usuario();
            usuarioDAO = new UsuarioDAO();
        }
    }
}

using Rika.dao;
using Rika.dto;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Salvar usuario
        public bool SalvaUsuario(Usuario model)
        {
            try
            {
                //Atribuição da entrada
                usuario = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(usuario);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (usuario.Id == 0)
                {
                    usuarioDAO.EfetuarCadastro(usuario);
                }
                else
                {
                    usuarioDAO.EfetuarEdicao(usuario);
                }

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Excluir usuario
        public bool Excluirusuario(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirUsuarioDTO dto = new ExcluirUsuarioDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                usuario.Id = dto.Id;

                //Executa o processo
                usuarioDAO.ExcluirUsuario(usuario);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta usuario por Id
        public Usuario ConsultausuarioPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaUsuarioDTO dto = new ConsultaUsuarioDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                usuario.Id = dto.Id;

                //Executa o processo
                usuario = usuarioDAO.ConsultarUsuarioPorId(usuario);

                return usuario;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return usuario; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da usuario
        public Usuario GetInfousuario()
        {
            return usuario;
        }
        #endregion
    }
}

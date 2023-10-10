using Rika.dao;
using Rika.dto;
using Rika.models;
using Rika.views;
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
                bool SalvaDados = false;
                usuario = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(usuario);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (usuario.Id == 0)
                {
                    SalvaDados = usuarioDAO.EfetuarCadastro(usuario);
                }
                else
                {
                    //usuarioDAO.EfetuarEdicao(usuario);
                }

                return SalvaDados; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Realizar Login
        public bool RealizarLogin(Usuario model) 
        {
            try
            {
                //Atribuição da entrada no DTO
                LoginUsuarioDTO loginUsuarioDTO = new LoginUsuarioDTO()
                {
                    NomeUsuario = model.NomeUsuario,
                    Senha = model.Senha
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(loginUsuarioDTO); //Verificar com o DTO!!!

                //Atribuição do DTO no DAO
                usuario.NomeUsuario = loginUsuarioDTO.NomeUsuario;
                usuario.Senha = loginUsuarioDTO.Senha;

                return usuarioDAO.EfetuarLogin(usuario); //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }

        }
        #endregion

        #region Validar Tipo Usuário + Chamar Tela Inicial
        public void ValidarTipoUsuario(Usuario model)
        {
            usuario = usuarioDAO.ValidarTipoUsuario(model);

            if (usuario.Tipo == 0) //Se ele é usuário normal
            {
                FrmTelaInicialLogado tela = new FrmTelaInicialLogado();

                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is FrmTelaPrincipal
                             select frm;

                if (qrForm != null && qrForm.Count() >= 0)
                {
                    ((FrmTelaPrincipal)qrForm.First()).FecharFormulario(tela);
                }
            }
            else //Se ele é ADM
            {
                FrmTelaAdministrativa tela = new FrmTelaAdministrativa();

                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is FrmTelaPrincipal
                             select frm;

                if (qrForm != null && qrForm.Count() >= 0)
                {
                    ((FrmTelaPrincipal)qrForm.First()).FecharFormulario(tela);
                }
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
                //usuario = usuarioDAO.ConsultarUsuarioPorId(usuario);

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

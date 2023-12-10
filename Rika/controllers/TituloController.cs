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
    public class TituloController
    {
        private Titulo titulo;
        private TituloDAO tituloDAO;
        public TituloController()
        {
            titulo = new Titulo();
            tituloDAO = new TituloDAO();
        }

        #region Salvar Título
        public bool SalvaTitulo(Titulo model)
        {
            try
            {
                //Atribuição da entrada
                titulo = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(titulo);

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

                if (isValid)
                {
                    //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                    if (titulo.Id == 0)
                    {
                        tituloDAO.EfetuarCadastro(titulo);
                    }
                    else
                    {
                        tituloDAO.EfetuarEdicao(titulo);
                    }
                }

                return isValid; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Excluir Título
        public bool ExcluirTitulo(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirTituloDTO dto = new ExcluirTituloDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                titulo.Id = dto.Id;

                //Executa o processo
                tituloDAO.ExcluirTitulo(titulo);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta Título por Id
        public Titulo ConsultaTituloPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaTituloDTO dto = new ConsultaTituloDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                titulo.Id = dto.Id;

                //Executa o processo
                titulo = tituloDAO.ConsultarTituloPorId(titulo);

                return titulo;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return titulo; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações do Título
        public Titulo GetInfoTitulo()
        {
            return titulo;
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Titulo model)
        {
            string msg = "";
            if (model.passagem.Id == 0)
                msg += "O campo Passagem não pode ser vazio!" + "\n";
            if (model.tipovenda.Id == 0)
                msg += "O campo Tipo de Venda não pode ser vazio!" + "\n";

            if (msg != string.Empty) //Se existe mensagem de erro
            {
                MessageBox.Show(msg, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true; //Passou por todas as validações
        }
        #endregion
    }
}

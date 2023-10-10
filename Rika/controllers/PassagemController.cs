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
    public class PassagemController
    {
        private Passagem passagem;
        private PassagemDAO passagemDAO;
        public PassagemController()
        {
            passagem = new Passagem();
            passagemDAO = new PassagemDAO();
        }

        #region Salvar passagem
        public bool Salvapassagem(Passagem model)
        {
            try
            {
                //Atribuição da entrada
                passagem = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(passagem);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (passagem.Id == 0)
                {
                    passagemDAO.EfetuarCadastro(passagem);
                }
                else
                {
                    passagemDAO.EfetuarEdicao(passagem);
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

        #region Excluir passagem
        public bool Excluirpassagem(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirPassagemDTO dto = new ExcluirPassagemDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                passagem.Id = dto.Id;

                //Executa o processo
                passagemDAO.ExcluirPassagem(passagem);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta passagem por Id
        public Passagem ConsultapassagemPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaPassagemDTO dto = new ConsultaPassagemDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                passagem.Id = dto.Id;

                //Executa o processo
                passagem = passagemDAO.ConsultarPassagemPorId(passagem);

                return passagem;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return passagem; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da passagem
        public Passagem GetInfopassagem()
        {
            return passagem;
        }
        #endregion
    }
}

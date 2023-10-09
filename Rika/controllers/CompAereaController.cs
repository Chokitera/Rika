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
    public class CompAereaController
    {
        private CompanhiaAerea companhiaAerea;
        private CompAereaDAO compAereaDAO;
        public CompAereaController()
        {
            companhiaAerea = new CompanhiaAerea();
            compAereaDAO = new CompAereaDAO();
        }

        #region Salvar Companhia
        public bool SalvaCompanhia(CompanhiaAerea model)
        {
            try
            {
                //Atribuição da entrada
                companhiaAerea = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(companhiaAerea);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if(companhiaAerea.Id == 0)
                {
                    compAereaDAO.EfetuarCadastro(companhiaAerea);
                }
                else
                {
                    compAereaDAO.EfetuarEdicao(companhiaAerea);
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

        #region Excluir Companhia
        public bool ExcluirCompanhia(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirCompanhiaAereaDTO dto = new ExcluirCompanhiaAereaDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                companhiaAerea.Id = dto.Id;

                //Executa o processo
                compAereaDAO.ExcluirCompAerea(companhiaAerea);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta Companhia por Id
        public CompanhiaAerea ConsultaCompanhiaPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaCompanhiaAereaDTO dto = new ConsultaCompanhiaAereaDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                companhiaAerea.Id = dto.Id;

                //Executa o processo
                companhiaAerea = compAereaDAO.ConsultarCompanhiaPorId(companhiaAerea);

                return companhiaAerea;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return companhiaAerea; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da companhia
        public CompanhiaAerea GetInfoCompanhia()
        {
            return companhiaAerea;
        }
        #endregion
    }
}

using Rika.dao;
using Rika.dto;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.controllers
{
    public class PaisController
    {
        private Pais pais;
        private PaisDAO paisDAO;
        public PaisController()
        {
            pais = new Pais();
            paisDAO = new PaisDAO();
        }

        #region Salvar pais
        public bool SalvaPais(Pais model)
        {
            try
            {
                //Atribuição da entrada
                pais = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(pais);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (pais.Id == 0)
                {
                    paisDAO.EfetuarCadastroPais(pais);
                }
                else
                {
                    paisDAO.EfetuarEdicao(pais);
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

        #region Excluir pais
        public bool ExcluirPais(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirPaisDTO dto = new ExcluirPaisDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                pais.Id = dto.Id;

                //Executa o processo
                paisDAO.ExcluirPais(pais);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta pais por Id
        public Pais ConsultaPaisPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaPaisDTO dto = new ConsultaPaisDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                pais.Id = dto.Id;

                //Executa o processo
                pais = paisDAO.ConsultarPaisPorId(pais);

                return pais;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return pais; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da pais
        public Pais GetInfopais()
        {
            return pais;
        }
        #endregion

        #region Consulta Pais (DataTable)
        public DataTable ConsultarPaises(Pais pais)
        {
            try
            {
                //Cria a DataTable
                DataTable paises = new DataTable();

                //Atribuicao da entrada
                this.pais = pais;

                //Consultar os Paises
                paises = paisDAO.ConsultarPaises(this.pais);

                return paises; //Retorna os paises - DataTable
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na consulta: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null; //Se não deu certo retorna nulo
            }
        }
        #endregion
    }
}

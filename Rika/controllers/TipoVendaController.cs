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
    public class TipoVendaController
    {
        private TipoVenda tipoVenda;
        private TipoVendaDAO tipoVendaDAO;

        public TipoVendaController()
        {
            tipoVenda = new TipoVenda();
            tipoVendaDAO = new TipoVendaDAO();
        }

        #region Salvar tipoVenda
        public bool SalvatipoVenda(TipoVenda model)
        {
            try
            {
                //Atribuição da entrada
                tipoVenda = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(tipoVenda);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (tipoVenda.Id == 0)
                {
                    tipoVendaDAO.EfetuarCadastro(tipoVenda);
                }
                else
                {
                    tipoVendaDAO.EfetuarEdicao(tipoVenda);
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

        #region Excluir tipoVenda
        public bool ExcluirtipoVenda(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirTipoVendaDTO dto = new ExcluirTipoVendaDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                tipoVenda.Id = dto.Id;

                //Executa o processo
                tipoVendaDAO.ExcluirTipoVenda(tipoVenda);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta tipoVenda por Id
        public TipoVenda ConsultatipoVendaPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaTipoVendaDTO dto = new ConsultaTipoVendaDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                tipoVenda.Id = dto.Id;

                //Executa o processo
                tipoVenda = tipoVendaDAO.ConsultarTipoVendaPorId(tipoVenda);

                return tipoVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return tipoVenda; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da tipoVenda
        public TipoVenda GetInfotipoVenda()
        {
            return tipoVenda;
        }
        #endregion

        #region Consulta Tipo de Venda (DataTable)
        public DataTable ConsultarTipoVendas(TipoVenda tipoVenda)
        {
            try
            {
                //Cria a DataTable
                DataTable tipoVendas = new DataTable();

                //Atribuicao da entrada
                this.tipoVenda = tipoVenda;

                //Consultar os Paises
                tipoVendas = tipoVendaDAO.ConsultarTipoVendas(this.tipoVenda);

                return tipoVendas; //Retorna os paises - DataTable
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

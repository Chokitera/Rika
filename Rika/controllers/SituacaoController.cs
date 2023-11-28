using Org.BouncyCastle.Math;
using Rika.dao;
using Rika.dto;
using Rika.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.controllers
{
    public class SituacaoController
    {
        private Situacao situacao;
        private SituacaoDAO situacaoDAO;
        public SituacaoController()
        {
            situacao = new Situacao();
            situacaoDAO = new SituacaoDAO();
        }

        #region Salvar situacao
        public bool Salvasituacao(Situacao model)
        {
            try
            {
                //Atribuição da entrada
                situacao = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(situacao);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (situacao.Id == 0)
                {
                    situacaoDAO.EfetuarCadastro(situacao);
                }
                else
                {
                    situacaoDAO.EfetuarEdicao(situacao);
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

        #region Excluir situacao
        public bool Excluirsituacao(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirSituacaoDTO dto = new ExcluirSituacaoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                situacao.Id = dto.Id;

                //Executa o processo
                situacaoDAO.ExcluirSituacao(situacao);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta situacao por Id
        public Situacao ConsultasituacaoPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaSituacaoDTO dto = new ConsultaSituacaoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                situacao.Id = dto.Id;

                //Executa o processo
                situacao = situacaoDAO.ConsultarSituacaoPorId(situacao);

                return situacao;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return situacao; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da situacao
        public Situacao GetInfosituacao()
        {
            return situacao;
        }
        #endregion

        #region Consulta situação (DataTable)
        public DataTable ConsultarSituacao(Situacao situacao)
        {
                //Criar a DataTable
                DataTable situacoes = new DataTable();

                //Atribuição da entrada
                this.situacao = situacao;

                //Consultar as situações
                situacoes = situacaoDAO.ConsultarSituacao(this.situacao);

                return situacoes; //Retorna a situação - DataTable
        }

        #endregion
    }
}

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
    public class VooController
    {
        private Voo voo;
        private VooDAO vooDAO;
        public VooController()
        {
            voo = new Voo();
            vooDAO = new VooDAO();
        }

        #region Salvar voo
        public bool Salvavoo(Voo model)
        {
            try
            {
                //Atribuição da entrada
                voo = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(voo);

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (voo.Id == 0)
                {
                    vooDAO.EfetuarCadastro(voo);
                }
                else
                {
                    vooDAO.EfetuarEdicao(voo);
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

        #region Excluir voo
        public bool Excluirvoo(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirVooDTO dto = new ExcluirVooDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                voo.Id = dto.Id;

                //Executa o processo
                vooDAO.ExcluirVoo(voo);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta voo por Id
        public Voo ConsultavooPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaVooDTO dto = new ConsultaVooDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                voo.Id = dto.Id;

                //Executa o processo
                voo = vooDAO.ConsultarVooPorId(voo);

                return voo;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return voo; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta Voo (DataTable)
        public DataTable ConsultarVoos(Voo voo)
        {
            try
            {
                //Cria a DataTable
                DataTable voos = new DataTable();

                //Atribuicao da entrada
                this.voo = voo;

                //Consultar os Paises
                voos = vooDAO.ConsultarVoos(this.voo);

                return voos; //Retorna os paises - DataTable
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na consulta: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null; //Se não deu certo retorna nulo
            }
        }
        #endregion

        #region Pegar informações da voo
        public Voo GetInfovoo()
        {
            return voo;
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Voo model)
        {
            string msg = "";
            if (model.Decolagem == 0)
                msg += "O campo Aeroporto Decolagem não pode ser vazio!" + "\n";
            if (model.Destino == 0)
                msg += "O campo Aeroporto Destino não pode ser vazio!" + "\n";
            if (model.aviao.Id == 0)
                msg += "O campo Avião não pode ser vazio!" + "\n";

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

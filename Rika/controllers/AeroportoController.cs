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
    public class AeroportoController
    {
        private Aeroporto aeroporto;
        private AeroportoDAO aeroportoDAO;
        public AeroportoController()
        {
            aeroporto = new Aeroporto();
            aeroportoDAO = new AeroportoDAO();
        }

        #region Salvar Aeroporto
        public bool SalvaAeroporto(Aeroporto model)
        {
            try
            {
                //Atribuição da entrada
                aeroporto = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(aeroporto);

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

                if (isValid)
                {
                    //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                    if (aeroporto.Id == 0)
                    {
                        aeroportoDAO.EfetuarCadastro(aeroporto);
                    }
                    else
                    {
                        aeroportoDAO.EfetuarEdicao(aeroporto);
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

        #region Excluir Aeroporto
        public bool ExcluirAeroporto(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirAeroportoDTO dto = new ExcluirAeroportoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                aeroporto.Id = dto.Id;

                //Executa o processo
                aeroportoDAO.ExcluirAeroporto(aeroporto);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta Aeroporto por Id
        public Aeroporto ConsultaAeroportoPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaAeroportoDTO dto = new ConsultaAeroportoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                aeroporto.Id = dto.Id;

                //Executa o processo
                aeroporto = aeroportoDAO.ConsultarAeroportoPorId(aeroporto);

                return aeroporto;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return aeroporto; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da Aeroporto
        public Aeroporto GetInfoAeroporto()
        {
            return aeroporto;
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Aeroporto model)
        {
            string msg = "";
            if (model.endereco.Id == 0)
                msg += "O campo Endereço não pode ser vazio!" + "\n";

            if(msg != string.Empty) //Se existe mensagem de erro
            {
                MessageBox.Show(msg, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true; //Passou por todas as validações
        }
        #endregion
    }
}

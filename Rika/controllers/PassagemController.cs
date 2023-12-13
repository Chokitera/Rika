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

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

                if (isValid)
                {
                    //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                    if (passagem.Id == 0)
                    {
                        passagemDAO.EfetuarCadastro(passagem);
                    }
                    else
                    {
                        passagemDAO.EfetuarEdicao(passagem);
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

        #region Consulta Passagem (DataTable)
        public DataTable ConsultarPassagens(Passagem passagem)
        {
            try
            {
                //Cria a DataTable
                DataTable passagens = new DataTable();

                //Atribuicao da entrada
                this.passagem = passagem;

                //Consultar os Paises
                passagens = passagemDAO.ConsultarPassagens(this.passagem);

                return passagens; //Retorna os paises - DataTable
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro na consulta: " + erro, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null; //Se não deu certo retorna nulo
            }
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Passagem model)
        {
            string msg = "";
            if (model.voo.Id == 0)
                msg += "O campo Voo não pode ser vazio!" + "\n";
            if (model.classe.Id == 0)
                msg += "O campo Classe não pode ser vazio!" + "\n";
            if (model.situacao.Id == null || model.situacao.Id == 0)
                msg += "O campo Situação não pode ser vazio!" + "\n";

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

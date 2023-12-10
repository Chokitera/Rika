﻿using Rika.dao;
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
    public class AviaoController
    {
        private Aviao aviao;
        private AviaoDAO aviaoDAO;
        public AviaoController()
        {
            aviao = new Aviao();
            aviaoDAO = new AviaoDAO();
        }

        #region Salvar aviao
        public bool Salvaaviao(Aviao model)
        {
            try
            {
                //Atribuição da entrada
                aviao = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(aviao);

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

                if (isValid)
                {
                    //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                    if (aviao.Id == 0)
                    {
                        aviaoDAO.CadastrarAviao(aviao);
                    }
                    else
                    {
                        aviaoDAO.EfetuarEdicao(aviao);
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

        #region Excluir aviao
        public bool Excluiraviao(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirAviaoDTO dto = new ExcluirAviaoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                aviao.Id = dto.Id;

                //Executa o processo
                aviaoDAO.ExcluirAviao(aviao);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta aviao por Id
        public Aviao ConsultaAviaoPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaAviaoDTO dto = new ConsultaAviaoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                aviao.Id = dto.Id;

                //Executa o processo
                aviao = aviaoDAO.ConsultarAviaoPorId(aviao);

                return aviao;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return aviao; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da aviao
        public Aviao GetInfoaviao()
        {
            return aviao;
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Aviao model)
        {
            string msg = "";
            if (model.comp.Id == 0)
                msg += "O campo Companhia Aérea não pode ser vazio!" + "\n";

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

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
    public class EnderecoController
    {
        private Endereco endereco;
        private EnderecoDAO enderecoDAO;
        public EnderecoController()
        {
            endereco = new Endereco();
            enderecoDAO = new EnderecoDAO();
        }

        #region Salvar endereco
        public bool Salvaendereco(Endereco model)
        {
            try
            {
                //Atribuição da entrada
                endereco = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(endereco);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (endereco.Id == 0)
                {
                    enderecoDAO.EfetuarCadastro(endereco);
                }
                else
                {
                    enderecoDAO.EfetuarEdicao(endereco);
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

        #region Excluir endereco
        public bool Excluirendereco(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirEnderecoDTO dto = new ExcluirEnderecoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                endereco.Id = dto.Id;

                //Executa o processo
                enderecoDAO.ExcluirEndereco(endereco);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta endereco por Id
        public Endereco ConsultaenderecoPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaEnderecoDTO dto = new ConsultaEnderecoDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                endereco.Id = dto.Id;

                //Executa o processo
                endereco = enderecoDAO.ConsultarEnderecoPorId(endereco);

                return endereco;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return endereco; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da endereco
        public Endereco GetInfoendereco()
        {
            return endereco;
        }
        #endregion
    }
}

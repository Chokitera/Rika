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
        public bool SalvaEndereco(Endereco model)
        {
            try
            {
                //Atribuição da entrada
                endereco = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(endereco);

                //Valida FK - Chave estrangeira
                bool isValid = ValidaCampos(model);

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
        public bool ExcluirEndereco(int? id)
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
        public Endereco ConsultaEnderecoPorId(int? id)
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

        #region Consulta CEP por API
        public DataSet ConsultaCEPAPI(string url)
        {
            try
            {
                //DataSet (Dados na Memória)
                DataSet consulta = new DataSet();

                //Consulta a Api a partir da rota e dados (CEP) disponibilizados
                consulta.ReadXml(url);

                //Retorna a consulta
                if (consulta.Tables[0].Columns.Count > 1)
                    return consulta;

                //Só cai aqui se não encontrou o endereço a partir do CEP preenchido
                MessageBox.Show("Endereço não encontrado, por favor digite o CEP manualmente.", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null; 
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite o CEP manualmente.", "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            
        }
        #endregion

        #region Pegar informações do Endereço
        public Endereco GetInfoEndereco()
        {
            return endereco;
        }
        #endregion

        #region Validações
        public bool ValidaCampos(Endereco model)
        {
            string msg = "";
            if (model.pais.Id == 0)
                msg += "O campo País não pode ser vazio!" + "\n";

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

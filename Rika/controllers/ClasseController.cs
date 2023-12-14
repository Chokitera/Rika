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
    public class ClasseController
    {
        private Classe classe;
        private ClasseDAO classeDAO;
        public ClasseController()
        {
            classe = new Classe();
            classeDAO = new ClasseDAO();
        }

        #region Salvar classe
        public bool SalvaClasse(Classe model)
        {
            try
            {
                //Atribuição da entrada
                classe = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(classe);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (classe.Id == 0)
                {
                    classeDAO.EfetuarCadastro(classe);
                }
                else
                {
                    classeDAO.EfetuarEdicao(classe);
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

        #region Excluir classe
        public bool ExcluirClasse(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirClasseDTO dto = new ExcluirClasseDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                classe.Id = dto.Id;

                //Executa o processo
                classeDAO.ExcluirClasse(classe);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta classe por Id
        public Classe ConsultaClassePorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaClasseDTO dto = new ConsultaClasseDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                classe.Id = dto.Id;

                //Executa o processo
                classe = classeDAO.ConsultarClassePorId(classe);

                return classe;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return classe; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Pegar informações da classe
        public Classe GetInfoclasse()
        {
            return classe;
        }
        #endregion

        #region Consulta Classe (DataTable)
        public DataTable ConsultarClasses(Classe classe)
        {
            try
            {
                //Cria a DataTable
                DataTable classes = new DataTable();

                //Atribuicao da entrada
                this.classe = classe;

                //Consultar os Paises
                classes = classeDAO.ConsultarClasses(this.classe);

                return classes; //Retorna os paises - DataTable
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

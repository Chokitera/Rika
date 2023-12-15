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
    public class CarrinhoCompraController
    {
        private CarrinhoCompra carrinhoCompra;
        private CarrinhoCompraDAO carrinhoCompraDAO;
        public CarrinhoCompraController()
        {
            carrinhoCompra = new CarrinhoCompra();
            carrinhoCompraDAO = new CarrinhoCompraDAO();
        }

        #region Salvar carrinhoCompra
        public bool SalvaCarrinhoCompra(CarrinhoCompra model)
        {
            try
            {
                //Atribuição da entrada
                carrinhoCompra = model;

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(carrinhoCompra);

                //Se for igual a 0 ele cadastra um novo, se for diferente ele atualiza
                if (carrinhoCompra.Id == 0)
                {
                    carrinhoCompraDAO.EfetuarCadastro(carrinhoCompra);
                }
                else
                {
                    carrinhoCompraDAO.EfetuarEdicao(carrinhoCompra);
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

        #region Excluir carrinhoCompra
        public bool ExcluirCarrinhoCompra(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ExcluirCarrinhoCompraDTO dto = new ExcluirCarrinhoCompraDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                carrinhoCompra.Id = dto.Id;

                //Executa o processo
                carrinhoCompraDAO.ExcluirCarrinho(carrinhoCompra);

                return true; //Se Ok retorna verdadeiro
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Consulta carrinhoCompra por Id
        public CarrinhoCompra ConsultaCarrinhoCompraPorId(int? id)
        {
            try
            {
                //Atribuição da entrada no DTO
                ConsultaCarrinhoCompraDTO dto = new ConsultaCarrinhoCompraDTO()
                {
                    Id = id
                };

                //Verifica se as informações estão preenchidas e OK
                new models.Comum.ValidacaoModel().Validacao(dto);

                //Atribuição do DTO no DAO
                carrinhoCompra.Id = dto.Id;

                //Executa o processo
                carrinhoCompra = carrinhoCompraDAO.ConsultarCarrinhoCompraPorId(carrinhoCompra);

                return carrinhoCompra;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "RIKA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return carrinhoCompra; //Se deu ruim retorna falso
            }
        }
        #endregion

        #region Método para atualizar a quantidade do item no carrinho de compra
        public void AtualizarQuantidadeCarrinhoCompra(CarrinhoCompra carrinhoCompra)
        {
            try
            {
                //Atualiza a quantidade do carrinho de compra
                carrinhoCompraDAO.AtualizarQuantidadeCarrinhoCompra(carrinhoCompra);
            }
            catch (Exception)
            {
                //Sem validação e execao no controller
            }
        }
        #endregion

        #region Método para consultar o carrinho de compra
        public DataTable CarregarCarrinhoCompra(CarrinhoCompra carrinhoCompra)
        {
            //Inicialização
            DataTable dataTable = new DataTable();

            //Chamada do DAO
            dataTable = carrinhoCompraDAO.CarregarCarrinhoCompra(carrinhoCompra);

            return dataTable;
        }
        #endregion

        #region Método para exclusão dos itens do carrinho de compra
        public void ExcluirItensCarrinho()
        {
            bool excluiu = carrinhoCompraDAO.ExcluirItensCarrinho();
        }
        #endregion

        #region Pegar informações do carrinho de compra
        public CarrinhoCompra GetInfocarrinhoCompra()
        {
            return carrinhoCompra;
        }
        #endregion
    }
}

using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryProduto
    {
         DaoProduto daoProduto;

        public RepositoryProduto()
        {
            daoProduto = new DaoProduto();
        }

        public string GetProdutos()
        {
            var dataJson = System.Text.Json.JsonSerializer
                .Serialize(daoProduto.GetProdutos());
            return dataJson;
        }

        public string GetProdutoById(int Id)
        {
            var dataJson = System.Text.Json.JsonSerializer
                .Serialize(daoProduto.GetProdutoById(Id));
            return dataJson;
        }

        public void CreateProduto(Produto produto)
        {
            try
            {
                daoProduto.CreateProduto(produto);
            }
            catch
            {

            }
        }

        public void UpdateProduto(Produto produto,int Id)
        {
            try
            {
                 daoProduto.UpdateProduto(produto,Id);
            }
            catch
            {

            }
        }
    }

}

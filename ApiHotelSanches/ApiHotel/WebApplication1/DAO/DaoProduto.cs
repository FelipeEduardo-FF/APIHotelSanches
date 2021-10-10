using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DaoProduto
    {
        List<Produto> ListaProdutos;
        Produto produto;

        public DaoProduto(){
            ListaProdutos = new List<Produto>();
            produto = new Produto();
        }


        public  void CreateProduto(Produto Newproduto )
        {
            var Context = new Db_HotelContext();
            Context.Add(Newproduto);
            Context.SaveChanges();
        }

        public void UpdateProduto(Produto Updateproduto,int ID)
        {
            var Context = new Db_HotelContext();
            var dbproduto = Context.Produtos.FirstOrDefault(
                Pd => Pd.IdProduto == Updateproduto.IdProduto);

            dbproduto.IdProduto = Updateproduto.IdProduto;
            dbproduto.DescricaoProduto = Updateproduto.DescricaoProduto;
            dbproduto.ValorCompra = Updateproduto.ValorCompra;
            dbproduto.ValorVenda = Updateproduto.ValorVenda;
            dbproduto.QuantidadeProduto = Updateproduto.QuantidadeProduto;
            dbproduto.IdCategoria = Updateproduto.IdCategoria;
            dbproduto.IdEstoque = Updateproduto.IdEstoque;
            dbproduto.Comercializavel = dbproduto.Comercializavel;

            Context.SaveChanges();
        }

        public List<Produto> GetProdutos()
        {
            var Context = new Db_HotelContext();
            ListaProdutos.AddRange( Context.
                Produtos.Where(Pd => Pd.IdProduto != 0).ToList());

            return ListaProdutos;   
        }

        public Produto GetProdutoById(int ID)
        {
            var Context = new Db_HotelContext();
            produto = Context.Produtos.FirstOrDefault(
                Pd => Pd.IdProduto == ID);

            return produto;
            
        }


}
}

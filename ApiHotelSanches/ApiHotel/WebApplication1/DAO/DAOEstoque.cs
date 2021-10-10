using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOEstoque
    {
        List<Estoque> estoques;
        Estoque estoque;

        public DAOEstoque(){
            estoques = new List<Estoque>();
            estoque = new Estoque();
        }

        public List<Estoque> GetEstoques()
        {
            var context = new Db_HotelContext();
            estoques.AddRange(context.Estoques.Where(Et=>Et.IdEstoque!=0).ToList());
            return estoques;
        }

        public Estoque GetEstoqueByID(int Id)
        {
            var context = new Db_HotelContext();
            estoque=context.Estoques.FirstOrDefault(Et => Et.IdEstoque ==Id);
            return estoque;
        }

        public void CreateEstoque(Estoque estoque)
        {
            var context = new Db_HotelContext();
            context.Estoques.Add(estoque);
            context.SaveChanges();
        }

        public void UpdateEstoque(Estoque estoque, int Id)
        {
            var context = new Db_HotelContext();
            var Dbestoque = context.Estoques.FirstOrDefault(Et => Et.IdEstoque == Id);
            Dbestoque.IdEstoque = estoque.IdEstoque;
            Dbestoque.Coluna = estoque.Coluna;
            Dbestoque.Linha = estoque.Linha;
            Dbestoque.DescricaoEstoque = estoque.DescricaoEstoque;

            context.SaveChanges();
        }

    }
}

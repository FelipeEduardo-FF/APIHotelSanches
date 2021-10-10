using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryEstoque
    {
        DAOEstoque daoestoque;
        public RepositoryEstoque()
        {
            daoestoque = new DAOEstoque();
        }

        public void UpdateEstoque(Estoque estoque, int Id)
        {
            daoestoque.UpdateEstoque(estoque, Id);
        }
        public void CreateEstoque(Estoque estoque)
        {
            daoestoque.CreateEstoque(estoque);
        }

        public string GetEstoqueById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoestoque.GetEstoqueByID(Id));
            return dataJson;
        }
        public string GetEstoque()
        {
            var dataJson = JsonSerializer.Serialize(daoestoque.GetEstoques());
            return dataJson;
        }
    }
}

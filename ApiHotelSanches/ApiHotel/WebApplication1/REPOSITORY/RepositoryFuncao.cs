using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryFuncao
    {
        DAOFuncao daoFuncao;
        public RepositoryFuncao()
        {
            daoFuncao = new DAOFuncao();
        }

        public void CreateFuncao(TbFuncao funcao)
        {
            daoFuncao.CreateFuncao(funcao);
        }

        public void UpdateFuncao(TbFuncao funcao, int Id)
        {
            daoFuncao.UpdateFuncao(funcao, Id);
        }
        public string GetFuncao()
        {
            var dataJson = JsonSerializer.Serialize(daoFuncao.GetFuncoes());
            return dataJson;
        }

        public string GetFuncaoById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoFuncao.GetFuncaobyID(Id));
            return dataJson;
        }
    }
}

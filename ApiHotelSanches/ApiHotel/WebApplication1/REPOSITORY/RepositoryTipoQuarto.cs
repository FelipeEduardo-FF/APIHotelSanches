using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryTipoQuarto
    {
        DaoTipoQuarto daoTipoQuarto;

        public RepositoryTipoQuarto()
        {
            daoTipoQuarto = new DaoTipoQuarto();
        }

        public void UpdateTipoQuarto(TipoQuarto tipoQuarto, int Id)
        {
            daoTipoQuarto.UpdateTipoQuarto(tipoQuarto, Id);
        }

        public void CreateTipoQuarto(TipoQuarto tipoQuarto)
        {
            daoTipoQuarto.CreateTipoQuarto(tipoQuarto);
        }

        public string GetTipoQuartosById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoTipoQuarto.GetTipoQuartoById(Id));
            return dataJson;
        }

        public string GetTipoQuartos()
        {
            var dataJson = JsonSerializer.Serialize(daoTipoQuarto.GetTipoQuartos());
            return dataJson;
        }

    }
}

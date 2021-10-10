using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class QuartoRepository
    {
        DaoQuarto daoQuarto;
        public QuartoRepository()
        {
            daoQuarto = new DaoQuarto();
        }

        public void CreateQuarto(Quarto quarto)
        {
            daoQuarto.CreateQuarto(quarto);
        }

        public void UpdateQuarto(Quarto quarto,int Id)
        {
            daoQuarto.UpdateQuarto(quarto, Id);
        }
        public string GetQuartos()
        {
            var dataJson = JsonSerializer.Serialize(daoQuarto.GetQuartos()) ;
            return dataJson;
        }

        public string GetQuartosById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoQuarto.GetQuartoById(Id));
            return dataJson;
        }
    }
}

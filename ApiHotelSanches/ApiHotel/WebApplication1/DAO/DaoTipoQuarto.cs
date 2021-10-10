using CodeFirstExistingDatabaseSample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DaoTipoQuarto
    {
        List<TipoQuarto> tipoQuartos;
        TipoQuarto tipoQuarto;

        public DaoTipoQuarto()
        {
            tipoQuartos = new List<TipoQuarto>();
        }

        public void UpdateTipoQuarto(TipoQuarto tipoQuarto,int Id)
        {
            var context = new Db_HotelContext();
            var db_Tipoquarto=context.TipoQuartos.FirstOrDefault(Tq => Tq.IdTipoQuarto == Id);
            db_Tipoquarto.DescricaoTipo = tipoQuarto.DescricaoTipo;
            context.SaveChanges();
        }

        public void CreateTipoQuarto(TipoQuarto tipoQuarto)
        {
            var context = new Db_HotelContext();
            context.TipoQuartos.Add(tipoQuarto);
            context.SaveChanges();
        }

        public TipoQuarto GetTipoQuartoById(int Id)
        {
            var context = new Db_HotelContext();
            tipoQuarto = context.TipoQuartos.FirstOrDefault(Tq => Tq.IdTipoQuarto == Id);
            return tipoQuarto;
        }

        public List<TipoQuarto> GetTipoQuartos()
        {
            var context = new Db_HotelContext();
            tipoQuartos.AddRange(context.TipoQuartos
                       .Where(Tq=>Tq.IdTipoQuarto !=0).ToList());

            return tipoQuartos;
        }
    }
}

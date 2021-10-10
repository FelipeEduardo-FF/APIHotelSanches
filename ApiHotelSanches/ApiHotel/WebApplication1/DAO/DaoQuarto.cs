using CodeFirstExistingDatabaseSample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DaoQuarto
    {
        List<Quarto> quartos;
        Quarto quarto;
        public DaoQuarto()
        {
            quartos = new List<Quarto>();
        }

        public void CreateQuarto(Quarto quarto)
        {
            var context = new Db_HotelContext();
            context.Quartos.Add(quarto);
            context.SaveChanges();
        }

        public void UpdateQuarto(Quarto quarto,int Id)
        {
            var context = new Db_HotelContext();
            var DbQuarto=context.Quartos.FirstOrDefault(qt => qt.NumeroQuarto == Id);

            DbQuarto.Andar = quarto.Andar;
            DbQuarto.DescricaoQuarto = quarto.DescricaoQuarto;
            DbQuarto.ValorDiaria = quarto.ValorDiaria;
            DbQuarto.IdTipoQuarto = quarto.IdTipoQuarto;

            context.SaveChanges();

    }

        public Quarto GetQuartoById(int Id)
        {
            var context = new Db_HotelContext();
            quarto= context.Quartos
                .Include(qt => qt.IdTipoQuartoNavigation)
                //.Include(qt => qt.Frigobars)
               // .Include(qt => qt.Reservas)
                .FirstOrDefault(qt => qt.NumeroQuarto == Id);
            return quarto;
        }
        public List<Quarto> GetQuartos()
        {
            var context = new Db_HotelContext();
            quartos.AddRange(context.Quartos
                .Include(qt => qt.IdTipoQuartoNavigation)
                .Where(qt=>qt.NumeroQuarto!=0));
            return quartos;

        }
    }
}

using CodeFirstExistingDatabaseSample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOFrigobar
    {
        Frigobar frigobar;
        List<Frigobar> ListaFrigobar;


        public  async Task<Boolean> UpdateFrigobar(Frigobar UpdateFrigobar,int Id)
        {
            try
            {
               var Context = new Db_HotelContext();
               var DbFrigobar= await Context.Frigobars.FirstOrDefaultAsync(Fb => Fb.IdFrigobar == Id);

                DbFrigobar.IdFrigobar = UpdateFrigobar.IdFrigobar;
                DbFrigobar.IdQuarto = UpdateFrigobar.IdQuarto;

                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean CreateFrigobar(Frigobar NewFrigobar)
        {
            try
            {
                var Context = new Db_HotelContext();
                Context.Frigobars.Add(NewFrigobar);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<List<Frigobar>> GetFrigobars()
        {
            var Context = new Db_HotelContext();
            ListaFrigobar = new List<Frigobar>();
            ListaFrigobar.AddRange( await Context.Frigobars
                .Include(Fb => Fb.IdQuartoNavigation)
                .Where(Frigobar => Frigobar.IdQuarto != 0).ToListAsync());

            return  ListaFrigobar;
        }

        public Frigobar GetFrigobarByIDQuarto(int Id)
        {
            var Context = new Db_HotelContext();
            frigobar = Context.Frigobars
                    .Include(Fb => Fb.IdQuartoNavigation)
                    .FirstOrDefault(Frigobar => Frigobar.IdQuarto==Id);

            return frigobar;
        }


    }
}

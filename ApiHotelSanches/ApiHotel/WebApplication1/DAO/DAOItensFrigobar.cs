using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOItensFrigobar
    {
        List<ItemFrigobar> itensFrigobar;

        public void CreateItensFrigobar(ItemFrigobar NewFrigobar)
        {
            try
            {
                var Context = new Db_HotelContext();
                Context.Add(NewFrigobar);

                Context.SaveChanges();
            }
            catch
            {

            }
        }

        public async Task<Boolean> UpdateItensFrigobar(int Id, ItemFrigobar UpdateFrigobar)
        {
            try
            {
                var Context = new Db_HotelContext();
                var ItemFrigobar = Context.ItemFrigobars.FirstOrDefault(IF => IF.IdProduto == Id);

                ItemFrigobar.IdProduto = UpdateFrigobar.IdProduto;
                ItemFrigobar.IdFrigobar = UpdateFrigobar.IdFrigobar;
                ItemFrigobar.Quantidade = UpdateFrigobar.Quantidade;

                await Context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<ItemFrigobar> GetItensFrigobarByFrigobar(int ID)
        {
            var Context = new Db_HotelContext();
            itensFrigobar = new List<ItemFrigobar>();
            itensFrigobar.AddRange(Context.ItemFrigobars
                          .Where(IF => IF.IdFrigobar == ID));

            return itensFrigobar;
        }

    }
}

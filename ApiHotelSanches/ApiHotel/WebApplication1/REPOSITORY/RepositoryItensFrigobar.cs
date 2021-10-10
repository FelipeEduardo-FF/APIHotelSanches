using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryItensFrigobar
    {
        DAOItensFrigobar DaoitensFrigobar;

        public RepositoryItensFrigobar(){
            DaoitensFrigobar = new DAOItensFrigobar();
        }

        public void CreateFrigobar(ItemFrigobar itemFrigobar)
        {
            try
            {
                DaoitensFrigobar.CreateItensFrigobar(itemFrigobar);
            }
            catch
            {

            }
        }

        public async Task UpdateFrigobar(ItemFrigobar itemFrigobar,int Id)
        {
            try
            {
                await DaoitensFrigobar.UpdateItensFrigobar(Id, itemFrigobar);
            }
            catch
            {

            }
        }

        public String GetFrigobarByID(int ID)
        {
            var dataJson = System.Text.Json.JsonSerializer.Serialize(DaoitensFrigobar
                .GetItensFrigobarByFrigobar(ID));
            return dataJson;
        }
    }
}

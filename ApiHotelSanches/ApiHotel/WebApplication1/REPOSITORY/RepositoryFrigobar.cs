using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryFrigobar
    {
        DAOFrigobar DaoFrigobar;
        public RepositoryFrigobar()
        {
            DaoFrigobar = new DAOFrigobar();
        }

        public Boolean CreateFrigobar(Frigobar frigobar)
        {
            try
            {
                DaoFrigobar.CreateFrigobar(frigobar);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean UpdateFrigobar(Frigobar frigobar, int Id)
        {
            try
            {
                DaoFrigobar.UpdateFrigobar(frigobar,Id);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public String GetFrigobarByID(int ID)
        {
            var dataJson = System.Text.Json.JsonSerializer.Serialize(DaoFrigobar
                .GetFrigobarByIDQuarto(ID));
            return dataJson;
        }

        public async Task<String> GetFrigobars()
        {
            var dataJson = System.Text.Json.JsonSerializer.Serialize( await DaoFrigobar
                .GetFrigobars());
            return dataJson;
        }


    }
}

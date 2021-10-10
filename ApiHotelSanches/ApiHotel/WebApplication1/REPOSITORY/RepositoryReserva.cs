using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHotel.REPOSITORY
{
    public class RepositoryReserva
    {
        DAOReserva daoreserva;
        public RepositoryReserva()
        {
            daoreserva = new DAOReserva();
        }

        public void UpdateReserva(Reserva reserva, int Id)
        {
            daoreserva.UpdateReserva(reserva, Id);
        }
        public void CreateReserva(Reserva reserva)
        {
            daoreserva.CreateReserva(reserva);
        }

        public string GetReservaById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daoreserva.GetReservaById(Id));
            return dataJson;
        }
        public string GetReserva()
        {
            var dataJson = JsonSerializer.Serialize(daoreserva.GetReservas());
            return dataJson;
        }

    }
}

using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOReserva
    {
        List<Reserva> reservas;
        Reserva reserva;

        public DAOReserva() {
            reservas = new List<Reserva>();
        }
        public List<Reserva> GetReservas()
        {
            var context = new Db_HotelContext();
            reservas.AddRange(context.Reservas.Where(Rs=>Rs.IdReserva!=0).ToList());
            return reservas;
        }

        public Reserva GetReservaById(int Id)
        {
            var context = new Db_HotelContext();
            reserva = context.Reservas.FirstOrDefault(Rs => Rs.IdReserva == Id);
            return reserva;
        }

        public void CreateReserva(Reserva reserva)
        {
            var context = new Db_HotelContext();
            context.Reservas.Add(reserva);
            context.SaveChanges();
        }

        public void UpdateReserva(Reserva reserva,int Id)
        {
            var context = new Db_HotelContext();
            var Dbreserva = context.Reservas.FirstOrDefault(Rs => Rs.IdReserva == Id);
            Dbreserva.IdPessoa = reserva.IdPessoa;
            Dbreserva.IdQuarto = reserva.IdQuarto;
            Dbreserva.NrAcompanhantes = reserva.NrAcompanhantes;
            Dbreserva.DtInicialReserva = reserva.DtInicialReserva;
            Dbreserva.DtFinalReserva = reserva.DtFinalReserva;
            Dbreserva.ValorPago = reserva.ValorPago;
            Dbreserva.ValorTotal = reserva.ValorTotal;
            Dbreserva.StatusReserva = reserva.StatusReserva;

            context.SaveChanges();
        }
    }
}

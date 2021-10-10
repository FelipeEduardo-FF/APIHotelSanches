using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public class CheckIn
    {
        public int IdCheckIn { get; set; }
        public DateTime DataHoraChekIn { get; set; }
        public int IdReserva { get; set; }

        public virtual Reserva Reserva{ get; set; }
    }
}

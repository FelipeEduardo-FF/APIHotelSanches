using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class CheckOut
    {
        public int IdCheckOut { get; set; }
        public DateTime DataHoraChekOut { get; set; }
        public int IdReserva { get; set; }
        public decimal ValorTotal { get; set; }

        public virtual Reserva Reserva{ get; set; }
    }
}

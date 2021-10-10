using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public class Reserva
    {
        public Reserva()
        {
            CheckIns = new HashSet<CheckIn>();
            CheckOuts = new HashSet<CheckOut>();
        }

        public int IdReserva { get; set; }
        public int IdPessoa { get; set; }
        public int IdQuarto { get; set; }
        public int NrAcompanhantes { get; set; }
        public DateTime DtInicialReserva { get; set; }
        public DateTime DtFinalReserva { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTotal { get; set; }
        public bool StatusReserva { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual Quarto Quarto { get; set; }
        public virtual ICollection<CheckIn> CheckIns { get; set; }
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
    }
}

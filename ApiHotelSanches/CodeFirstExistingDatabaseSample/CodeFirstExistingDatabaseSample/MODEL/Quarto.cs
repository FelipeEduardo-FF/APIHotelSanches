using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Quarto
    {
        public Quarto()
        {
            Frigobars = new HashSet<Frigobar>();
            Reservas = new HashSet<Reserva>();
        }

        public int NumeroQuarto { get; set; }
        public int Andar { get; set; }
        public string DescricaoQuarto { get; set; }
        public decimal ValorDiaria { get; set; }
        public int? IdTipoQuarto { get; set; }


        public virtual TipoQuarto IdTipoQuartoNavigation { get; set; }
        public virtual ICollection<Frigobar>? Frigobars { get; set; }
        public virtual ICollection<Reserva>? Reservas { get; set; }
    }
}

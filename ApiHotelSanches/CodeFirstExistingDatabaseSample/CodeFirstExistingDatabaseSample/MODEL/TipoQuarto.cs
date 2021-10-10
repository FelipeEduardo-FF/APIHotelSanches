using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public class TipoQuarto
    {
        public TipoQuarto()
        {
            Quartos = new HashSet<Quarto>();
        }

        public int IdTipoQuarto { get; set; }
        public string DescricaoTipo { get; set; }

        [JsonIgnore]
        public virtual ICollection<Quarto> Quartos { get; set; }
    }
}

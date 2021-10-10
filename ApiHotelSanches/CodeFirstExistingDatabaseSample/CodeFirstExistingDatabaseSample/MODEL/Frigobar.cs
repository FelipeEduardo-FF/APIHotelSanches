using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Frigobar
    {
        public int IdFrigobar { get; set; }
        public int IdQuarto { get; set; }

        [JsonIgnore]
        public virtual Quarto IdQuartoNavigation { get; set; }
    }
}

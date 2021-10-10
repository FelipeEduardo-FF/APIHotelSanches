using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPessoa { get; set; }
        public bool Vip { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Categoria
    {
        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdCategoria { get; set; }
        public string DescricaoCategoria { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}

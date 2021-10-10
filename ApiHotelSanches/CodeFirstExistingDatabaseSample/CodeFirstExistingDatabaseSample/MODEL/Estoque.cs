using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Estoque
    {
        public Estoque()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdEstoque { get; set; }
        public int Coluna { get; set; }
        public int Linha { get; set; }
        public string DescricaoEstoque { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}

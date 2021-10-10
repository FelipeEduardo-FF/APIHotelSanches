using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int QuantidadeProduto { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdEstoque { get; set; }
        public bool? Comercializavel { get; set; }

        public  Categoria? IdCategoriaNavigation { get; set; }
        public  Estoque? IdEstoqueNavigation { get; set; }
    }
}

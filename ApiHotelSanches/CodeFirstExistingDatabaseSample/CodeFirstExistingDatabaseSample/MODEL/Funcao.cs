using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public partial class TbFuncao
    {
        public TbFuncao()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        public int IdFuncao { get; set; }
        public string Funcao { get; set; }
        public string DescricaoFuncao { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}

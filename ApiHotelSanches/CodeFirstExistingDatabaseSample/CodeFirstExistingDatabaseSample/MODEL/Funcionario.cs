using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Funcionario
    {
        public int IdFuncionario { get; set; }
        public DateTime DataContratacao { get; set; }
        public int IdFuncao { get; set; }
        public decimal SalarioFuncionario { get; set; }
        public int IdPessoa { get; set; }

        public virtual TbFuncao Funcao { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}

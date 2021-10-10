using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public  class Pessoa
    {
        public Pessoa()
        {
            Clientes = new HashSet<Cliente>();
            Funcionarios = new HashSet<Funcionario>();
            Reservas = new HashSet<Reserva>();
        }


        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string CpfPessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EmailPessoa { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }
        public bool Situacao { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}

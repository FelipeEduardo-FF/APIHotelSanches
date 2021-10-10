using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DAO
{
    public class DAOPessoa
    {
        Pessoa pessoa;
        List<Pessoa> pessoas;
        public DAOPessoa()
        {
            pessoa = new Pessoa();
            pessoas = new List<Pessoa>();
        }

        public void CreatePessoa(Pessoa pessoa)
        {
            var context = new Db_HotelContext();
            context.Pessoas.Add(pessoa);
            context.SaveChanges();
        }

        public void UpdatePessoa(Pessoa pessoa, int Id)
        {
            var context = new Db_HotelContext();
            var Dbpessoa = context.Pessoas.FirstOrDefault(p => p.IdPessoa == Id);

            Dbpessoa.NomePessoa = pessoa.NomePessoa;
            Dbpessoa.CpfPessoa = pessoa.CpfPessoa;
            Dbpessoa.DataNascimento = pessoa.DataNascimento;
            Dbpessoa.EmailPessoa = pessoa.EmailPessoa;
            Dbpessoa.NivelAcesso = pessoa.NivelAcesso;
            Dbpessoa.Senha = pessoa.Senha;
            Dbpessoa.Situacao = pessoa.Situacao;

            context.SaveChanges();
        }

        public Pessoa getPessoaById(int Id)
        {
            var context = new Db_HotelContext();
            pessoa = context.Pessoas.FirstOrDefault(p=> p.IdPessoa == Id);

            return pessoa;
        }

        public List<Pessoa> GetPessoas()
        {
            var context = new Db_HotelContext();
            pessoas.AddRange(context.Pessoas
                    .Where(Ps => Ps.IdPessoa != 0).ToList());
            return pessoas;
        }

    }
}

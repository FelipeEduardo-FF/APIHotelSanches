using ApiHotel.DAO;
using CodeFirstExistingDatabaseSample;
using System;
using System.Collections.Generic;
using System.Text.Json;

#nullable disable

namespace ApiHotel
{
    public  class PessoaRepository
    {
        DAOPessoa daopessoa;
        public  PessoaRepository()
        {
            daopessoa = new DAOPessoa();
        }

        public void UpdatePessoa(Pessoa pessoa,int Id)
        {
            daopessoa.UpdatePessoa(pessoa, Id);
        }
        public void CreatePessoa(Pessoa pessoa)
        {
            daopessoa.CreatePessoa(pessoa);
        }

        public string GetPessoasById(int Id)
        {
            var dataJson = JsonSerializer.Serialize(daopessoa.getPessoaById(Id));
            return dataJson;
        }
        public string GetPessoas()
        {
            var dataJson = JsonSerializer.Serialize(daopessoa.GetPessoas());
            return dataJson;
        }

    }
}

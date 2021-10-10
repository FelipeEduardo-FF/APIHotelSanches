using CodeFirstExistingDatabaseSample;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        readonly PessoaRepository _pessoaRepository;
        public PessoaController()
        {
            _pessoaRepository = new PessoaRepository();
        }

        [HttpGet]
        public ActionResult<String> GetPessoas()
        {
            return Ok(_pessoaRepository.GetPessoas());
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetPessoaById(int Id)
        {
            return Ok(_pessoaRepository.GetPessoasById(Id));
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdatePessoas(int Id,Pessoa pessoa)
        {
            _pessoaRepository.UpdatePessoa(pessoa, Id);
            return Ok(_pessoaRepository.GetPessoas());
        }

        [HttpPost]
        public ActionResult<String> CreatePessoa(Pessoa pessoa)
        {
            _pessoaRepository.CreatePessoa(pessoa);
            return Ok(_pessoaRepository.GetPessoas());
        }


    }
}

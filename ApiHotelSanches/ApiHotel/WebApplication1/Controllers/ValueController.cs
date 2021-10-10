
using ApiHotel;
using ApiHotel.REPOSITORY;
using CodeFirstExistingDatabaseSample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ApiInserir.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController:ControllerBase
    {
        private readonly PessoaRepository _pessoaRepository;

        public ValueController()
        {
            _pessoaRepository = new PessoaRepository();
        }
  
        [HttpGet]
        public ActionResult<String> Get()
        {
            return _pessoaRepository.GetPessoas();
        }
        



    }
}

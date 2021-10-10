using ApiHotel.REPOSITORY;
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
    public class FuncionarioController : ControllerBase
    {
        readonly RepositoryFuncionario _reservaFuncionario;
        public FuncionarioController()
        {
            _reservaFuncionario = new RepositoryFuncionario();
        }

        [HttpGet]
        public ActionResult<String> GetFuncionario()
        {
            return Ok(_reservaFuncionario.GetFuncionario());
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetFuncionarioById(int Id)
        {
            return Ok(_reservaFuncionario.GetFuncionarioById(Id));
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateFuncionario(int Id, Funcionario funcionario)
        {
            _reservaFuncionario.UpdateFuncionario(funcionario, Id);
            return Ok(_reservaFuncionario.GetFuncionario());
        }

        [HttpPost]
        public ActionResult<String> CreateFuncionario(Funcionario funcionario)
        {
            _reservaFuncionario.CreateFuncionario(funcionario);
            return Ok(_reservaFuncionario.GetFuncionario());
        }
    }
}

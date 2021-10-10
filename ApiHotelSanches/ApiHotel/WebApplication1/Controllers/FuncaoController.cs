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
    public class FuncaoController : ControllerBase
    {
        readonly RepositoryFuncao _reservaFuncao;
        public FuncaoController()
        {
            _reservaFuncao = new RepositoryFuncao();
        }

        [HttpGet]
        public ActionResult<String> GetFuncao()
        {
            return Ok(_reservaFuncao.GetFuncao());
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetFuncaoById(int Id)
        {
            return Ok(_reservaFuncao.GetFuncaoById(Id));
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateFuncao(int Id, TbFuncao funcao)
        {
            _reservaFuncao.UpdateFuncao(funcao, Id);
            return Ok(_reservaFuncao.GetFuncao());
        }

        [HttpPost]
        public ActionResult<String> CreateFuncao(TbFuncao funcao)
        {
            _reservaFuncao.CreateFuncao(funcao);
            return Ok(_reservaFuncao.GetFuncao());
        }
    }
}

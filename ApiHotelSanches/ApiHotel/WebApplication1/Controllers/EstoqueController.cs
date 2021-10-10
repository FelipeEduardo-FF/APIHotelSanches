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
    public class EstoqueController : ControllerBase
    {
        readonly RepositoryEstoque _estoqueRepository;
        public EstoqueController()
        {
            _estoqueRepository = new RepositoryEstoque();
        }

        [HttpGet]
        public ActionResult<String> GetEstoque()
        {
            return Ok(_estoqueRepository.GetEstoque());
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetEstoqueById(int Id)
        {
            return Ok(_estoqueRepository.GetEstoqueById(Id));
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateEstoque(int Id, Estoque estoque)
        {
            _estoqueRepository.UpdateEstoque(estoque, Id);
            return Ok(_estoqueRepository.GetEstoque());
        }

        [HttpPost]
        public ActionResult<String> CreateEstoque(Estoque estoque)
        {
            _estoqueRepository.CreateEstoque(estoque);
            return Ok(_estoqueRepository.GetEstoque());
        }

    }
}

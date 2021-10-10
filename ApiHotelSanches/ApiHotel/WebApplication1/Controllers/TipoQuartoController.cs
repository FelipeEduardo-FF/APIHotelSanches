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
    public class TipoQuartoController : ControllerBase
    {
        readonly RepositoryTipoQuarto _repositoryTipoQuarto;

        public TipoQuartoController()
        {
            _repositoryTipoQuarto = new RepositoryTipoQuarto();
        }

        [HttpGet]
        public ActionResult<String> GetTipoQuartos()
        {
            return _repositoryTipoQuarto.GetTipoQuartos();
        }

        [HttpGet("{ID}")]
        public ActionResult<String> GetTipoQuartoById(int Id)
        {
            return _repositoryTipoQuarto.GetTipoQuartosById(Id);
        }

        [HttpPost]
        public ActionResult<String> CreateTipoQuarto(TipoQuarto tipoQuarto)
        {
            _repositoryTipoQuarto.CreateTipoQuarto(tipoQuarto); 
            return _repositoryTipoQuarto.GetTipoQuartos();
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateTipoQuarto(TipoQuarto tipoQuarto,int Id)
        {
            _repositoryTipoQuarto.UpdateTipoQuarto(tipoQuarto, Id);
            return _repositoryTipoQuarto.GetTipoQuartos();
        }

    }
}

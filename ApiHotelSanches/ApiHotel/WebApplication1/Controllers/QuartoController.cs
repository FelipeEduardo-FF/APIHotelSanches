using ApiHotel.REPOSITORY;
using CodeFirstExistingDatabaseSample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuartoController : ControllerBase
    {
        public readonly QuartoRepository quartoRepository;
        public QuartoController(){
            quartoRepository = new QuartoRepository();
        }

        [HttpGet]
        public ActionResult<String> GetQuarto()
        {
            return quartoRepository.GetQuartos();
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetQuartos(int Id)
        {
            return quartoRepository.GetQuartosById(Id);
        }

        [HttpPost]
        public ActionResult<String> CreateQuartos(Quarto quarto)
        {
            quartoRepository.CreateQuarto(quarto);
            return quartoRepository.GetQuartos();
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateQuarto(Quarto quarto,int ID)
        {
            quartoRepository.UpdateQuarto(quarto, ID);
            return quartoRepository.GetQuartos();
        }
    }
}

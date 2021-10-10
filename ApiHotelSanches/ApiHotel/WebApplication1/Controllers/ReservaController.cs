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
    public class ReservaController : ControllerBase
    {
        readonly RepositoryReserva _reservaRepository;
        public ReservaController()
        {
            _reservaRepository = new RepositoryReserva();
        }

        [HttpGet]
        public ActionResult<String> GetReserva()
        {
            return Ok(_reservaRepository.GetReserva());
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetReservaById(int Id)
        {
            return Ok(_reservaRepository.GetReservaById(Id));
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateReserva(int Id, Reserva reserva)
        {
            _reservaRepository.UpdateReserva(reserva, Id);
            return Ok(_reservaRepository.GetReserva());
        }

        [HttpPost]
        public ActionResult<String> CreateReserva(Reserva reserva)
        {
            _reservaRepository.CreateReserva(reserva);
            return Ok(_reservaRepository.GetReserva());
        }
    }
}

using ApiHotel.REPOSITORY;
using CodeFirstExistingDatabaseSample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FrigobarController : ControllerBase
    {
        private readonly RepositoryFrigobar _repostoryFrigobar;

        public FrigobarController()
        {
            _repostoryFrigobar = new RepositoryFrigobar();
        }

        [HttpGet]
        public async Task<string> GetFrigobar()
        {
            return await _repostoryFrigobar.GetFrigobars();
        }

        [HttpGet("{id}")]
        public ActionResult<String> GetFrigobarByID(int ID)
        {
            return _repostoryFrigobar.GetFrigobarByID(ID);
        }

        [HttpPost]
        public ActionResult<String> CreateFrigobar(Frigobar frigobar)
        {
            _repostoryFrigobar.CreateFrigobar(frigobar);
            return Ok(_repostoryFrigobar.GetFrigobars());
        }

        [HttpPut("{ID}")]
        public ActionResult<String> UpdateFrigobar(Frigobar frigobar,int Id)
        {
            _repostoryFrigobar.UpdateFrigobar(frigobar,Id);
            return Ok(_repostoryFrigobar.GetFrigobars());
        }


    }

}

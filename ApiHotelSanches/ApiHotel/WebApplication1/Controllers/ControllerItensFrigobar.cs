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
    public class ItensFrigobarController : ControllerBase
    {
        public readonly RepositoryItensFrigobar repositoryItensFrigobar;

        public ItensFrigobarController() {
            repositoryItensFrigobar = new RepositoryItensFrigobar();
        }

        [HttpGet("{id}")]
        public ActionResult<String> GetItensId(int Id)
        {
            return repositoryItensFrigobar.GetFrigobarByID(Id);
        }

        [HttpPost]
        public ActionResult<String> CreateItemFrigobar(ItemFrigobar itemFrigobar)
        {
            repositoryItensFrigobar.CreateFrigobar(itemFrigobar);
            return Ok();
        }

        [HttpPut("{Id}")]
        public ActionResult<String> UpdateItemFrigobar(ItemFrigobar itemFrigobar, int Id)
        {
            repositoryItensFrigobar.UpdateFrigobar(itemFrigobar, Id);
            return Ok();
        }

    }
}

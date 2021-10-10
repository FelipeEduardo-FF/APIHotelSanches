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
    public class ProdutoController : ControllerBase
    {
        readonly RepositoryProduto repositoryProduto;

        public ProdutoController() {
            repositoryProduto = new RepositoryProduto();
        }

        [HttpGet]
        public ActionResult<String> GetProdutos()
        {
            return repositoryProduto.GetProdutos();
        }

        [HttpGet("{Id}")]
        public ActionResult<String> GetProdutoByID(int Id)
        {
            return repositoryProduto.GetProdutoById(Id);
        }

        [HttpPost]
        public ActionResult<String> CreateProduto(Produto produto)
        {
            try
            {
                repositoryProduto.CreateProduto(produto);
                return Ok(repositoryProduto.GetProdutos());
            }
            catch
            {
                return Problem("Erro");
            }
        }

        [HttpPut("{Id}")]

        public ActionResult<String> UpdateProduto(Produto produto,int Id)
        {
            repositoryProduto.UpdateProduto(produto, Id);

            return Ok(repositoryProduto.GetProdutos());
        } 

    }
}

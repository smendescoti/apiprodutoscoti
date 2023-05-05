using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Ports;
using CentralDeProdutos.Application.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralDeProdutos.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoAppService? _produtoAppService;

        public ProdutosController(IProdutoAppService? produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProdutosQuery), 201)]
        public IActionResult Post(CreateProdutoCommand command)
        {
            return StatusCode(201, _produtoAppService.Add(command));
        }

        [HttpPut]
        [ProducesResponseType(typeof(ProdutosQuery), 200)]
        public IActionResult Put(UpdateProdutoCommand command)
        {
            return Ok(_produtoAppService.Update(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProdutosQuery), 200)]
        public IActionResult Delete(Guid? id)
        {
            var command = new DeleteProdutoCommand { Id = id };
            return Ok(_produtoAppService.Delete(command));
        }

        [Route("Categoria/{idCategoria}")]
        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutosQuery>), 200)]
        public IActionResult GetByCategoria(Guid? idCategoria)
        {
            return Ok(_produtoAppService.GetByCategoria(idCategoria));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutosQuery), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok(_produtoAppService.GetById(id));
        }
    }
}

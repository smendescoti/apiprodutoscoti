using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Ports;
using CentralDeProdutos.Application.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralDeProdutos.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaAppService? _categoriaAppService;

        public CategoriasController(ICategoriaAppService? categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CategoriasQuery), 201)]
        public IActionResult Post(CreateCategoriaCommand command)
        {
            return StatusCode(201, _categoriaAppService.Add(command));
        }

        [HttpPut]
        [ProducesResponseType(typeof(CategoriasQuery), 200)]
        public IActionResult Put(UpdateCategoriaCommand command)
        {
            return Ok(_categoriaAppService.Update(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(CategoriasQuery), 200)]
        public IActionResult Delete(Guid? id)
        {
            var command = new DeleteCategoriaCommand { Id = id };
            return Ok(_categoriaAppService.Delete(command));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CategoriasQuery>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_categoriaAppService.GetAll());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CategoriasQuery), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok(_categoriaAppService.GetById(id));
        }
    }
}

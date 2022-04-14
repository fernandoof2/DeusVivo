using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace DeusVivo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly IServiceCargo _service;

        public CargoController(IServiceCargo service)
        {
            _service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{name}")]
        [Authorize]
        public IActionResult Get(string name)
        {
            try
            {
                Expression<Func<CargoEO, bool>> filter = a => a.Nome.Contains(name.Trim());
                return Ok(_service.Get(filter, null, "CriacaoUsuario,AlteracaoUsuario"));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Add([FromBody] CargoEO cargo)
        {
            try
            {
                return Ok(_service.Add(cargo));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Authorize(Roles = "string")]
        public IActionResult Update([FromBody] CargoEO cargo)
        {
            try
            {
                _service.Update(cargo);

                return Ok("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {                
                _service.Delete(id);

                return Ok("Registro deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}

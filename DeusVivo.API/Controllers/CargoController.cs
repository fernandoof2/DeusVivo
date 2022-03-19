using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
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
        public IActionResult GetAll()
        {
            try
            {
                //return Ok(_service.GetAll());

                Expression<Func<Cargo, bool>> filter = a => a.Nome.Contains("t");
                return Ok(_service.Get(filter));
            }
            catch (Exception ex)
            {
                throw ;
            }
            
        }

        [HttpPost]
        public IActionResult Add([FromBody] Cargo cargo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok(_service.Add(cargo));
        }

        [HttpPut]
        public IActionResult ret()
        {
            return Ok("aaaaa");
        }

    }
}

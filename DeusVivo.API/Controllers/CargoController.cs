using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using Microsoft.AspNetCore.Mvc;

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
                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {
                throw ;
            }
            
        }

        [HttpPut]
        public IActionResult Add([FromBody] Cargo cargo)
        {
            return Ok(_service.Add(cargo));
        }

    }
}

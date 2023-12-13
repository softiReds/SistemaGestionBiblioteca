using Microsoft.AspNetCore.Mvc;
using SistemaGestionBibliotecaAPI.Services;

namespace SistemaGestionBibliotecaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _service;

        public AutorController(IAutorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
    }
}

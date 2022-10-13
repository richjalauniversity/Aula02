using Microsoft.AspNetCore.Mvc;

namespace Aula02.src.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HelloController : ControllerBase
    {

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne([FromRoute] string id)
        {
            return Ok($"The id sent was {id}");
        }
    }
}

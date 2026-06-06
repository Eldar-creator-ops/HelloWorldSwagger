using Microsoft.AspNetCore.Mvc;

namespace HelloWorldSwagger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            return Ok($"Hello, {name}!");
        }
    }
}

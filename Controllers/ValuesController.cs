using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Opak.Controllers
{

    [Route("api/Values/[action]")]
    [ApiController]
    public sealed class ValuesController : ControllerBase
    {
        [HttpGet("{x}/{y}/{name}")]
        public IActionResult Sa(int x, int y, string name)
        {
            return Ok(new { Message = (x + y) * 10 });
        }

        [HttpGet]
        public IActionResult CreateProduct(CreateProdouctDto request)
        {
            return StatusCode(200, new { Message = "Göksel" });
        }
    }

    public class CreateProdouctDto
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
    }
}




// put ve postta body taşınabilir gette taşınmaz

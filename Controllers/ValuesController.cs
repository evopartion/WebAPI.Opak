using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Opak.Controllers
{

    [Route("api/Values/[action]")]
    [ApiController]
    public sealed class ValuesController:ControllerBase
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok(new {Message="Göksel"});
        }

        [HttpGet]
        public IActionResult Hello2()
        {
            return StatusCode(200, new { Message = "Göksel" });
        }
    }
}

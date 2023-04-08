using Microsoft.AspNetCore.Mvc;

namespace ApiDog.Api.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        [HttpGet("DogGenerate")]
        public IActionResult GetDog()
        {
            return Ok("cachorro");
        }
    }
}

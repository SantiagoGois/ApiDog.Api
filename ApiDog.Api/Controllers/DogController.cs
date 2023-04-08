using ApiDog.Models;
using ApiDog.Services;
using Microsoft.AspNetCore.Mvc;
using RestEase;
using System.Threading.Tasks;

namespace ApiDog.Api.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogApi;
        public DogController()
        {
            _dogApi = RestClient.For<IDogService>("https://dog.ceo/api/");
        }

        [HttpGet("DogGenerate")]
        public async Task<ActionResult<DogResponse>> GetDog()
        {
            DogResponse response = await _dogApi.GetRandomDog();
            return Ok(response);
        }
    }
}

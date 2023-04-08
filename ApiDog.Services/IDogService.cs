using ApiDog.Models;
using RestEase;
using System.Threading.Tasks;


namespace ApiDog.Services
{
    public interface IDogService
    {
        [Get("breeds/image/random")]
        Task<DogResponse> GetRandomDog();
        
    }
}

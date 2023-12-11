using Microsoft.AspNetCore.Mvc;


namespace Pokemon_REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public string GetPokemons()
        {
            return "geting all pokemon";
        }

        [HttpGet("{id}")]
        public string GetPokemonById(int id)
        {
            return $"The pokemon by Id: {id}";
        }

        [HttpPost]
        public string AddPokemon()
        {
            return "Adding new pokemon";
        }

        [HttpPut("{id}")]
        public string UpdatePokemon(int id)
        {
            return $"pokemon is Updated: {id}";
        }

        [HttpDelete("{id}")]
        public string DeletePokemon(int id)
        {
            return $"This pokemon is deleted: {id}";
        }
    }
}

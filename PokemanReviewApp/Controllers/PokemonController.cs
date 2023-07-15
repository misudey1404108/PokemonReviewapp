using Microsoft.AspNetCore.Mvc;
using PokemanReviewApp.Interfaces;
using PokemanReviewApp.Models;

namespace PokemanReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        //private readonly IReviewRepository _reviewRepository;
        //private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository
            //IReviewRepository reviewRepository,
            //IMapper mapper
        )
        {
            _pokemonRepository = pokemonRepository;
            //_reviewRepository = reviewRepository;
            //_mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }


    }
}

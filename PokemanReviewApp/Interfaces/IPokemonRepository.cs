using PokemanReviewApp.Models;

namespace PokemanReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}

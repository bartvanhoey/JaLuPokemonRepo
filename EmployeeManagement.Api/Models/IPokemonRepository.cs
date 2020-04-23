using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;

namespace JaLuPokemon.Api.Models
{
    public interface IPokemonRepository
    {
        Task<IEnumerable<Pokemon>> GetPokemons();
        Task<Pokemon> GetPokemon(int pokemonId);
        Task<Pokemon> AddPokemon(Pokemon pokemon);
        Task<Pokemon> UpdatePokemon(Pokemon pokemon);
        void DeletePokemon(int pokemonId);
    }
}
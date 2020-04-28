using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;

namespace JaLuPokemon.API.Models
{
    public class PokemonController
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<IEnumerable<Pokemon>> GetSomePokemons()
        {
            return await _pokemonRepository.GetPokemons();

        }
    }
}
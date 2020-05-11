using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;

namespace JaLuPokemon.API.Models
{
    public interface IPokemonTypeRepository
    {
        Task<IEnumerable<PokemonType>> GetPokemonTypes();
        Task<PokemonType> GetPokemonType(int pokemonTypeId);
    }
}
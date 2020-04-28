using System.Collections.Generic;
using JaLuPokemon.Models;

namespace JaLuPokemon.API.Models
{
    public interface IPokemonTypeRepository
    {
        IEnumerable<PokemonType> GetPokemonTypes();
        PokemonType GetPokemonType(int pokemonTypeId);
    }
}
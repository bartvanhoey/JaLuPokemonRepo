using System.Collections.Generic;
using JaLuPokemon.Models;

namespace JaLuPokemon.Api.Models
{
    public interface IPokemonTypeRepository
    {
        IEnumerable<PokemonType> GetPokemonTypes();
        PokemonType GetPokemonType(int pokemonTypeId);
    }
}
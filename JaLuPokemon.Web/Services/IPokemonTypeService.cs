using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;

namespace JaLuPokemon.Web.Services
{
    public interface IPokemonTypeService
    {
         Task<IEnumerable<PokemonType>> GetPokemonTypes();
         Task<PokemonType> GetPokemonType(int id);
    }
}
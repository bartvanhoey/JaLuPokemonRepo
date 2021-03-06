using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;

namespace JaLuPokemon.Web.Services {
    public interface IPokemonService {
        Task<IEnumerable<Pokemon>> GetPokemons();
        Task<Pokemon> GetPokemon(int id);
        Task<Pokemon> UpdatePokemon(Pokemon pokemon);
    }
}
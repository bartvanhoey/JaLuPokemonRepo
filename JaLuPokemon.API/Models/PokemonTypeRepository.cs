using System.Collections.Generic;
using System.Linq;
using JaLuPokemon.Models;

namespace JaLuPokemon.API.Models
{
    public class PokemonTypeRepository : IPokemonTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public PokemonTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PokemonType GetPokemonType(int pokemonTypeId)
        {
            return _dbContext.PokemonTypes
                .FirstOrDefault(d => d.PokemonTypeId == pokemonTypeId);
        }

        public IEnumerable<PokemonType> GetPokemonTypes()
        {
            return _dbContext.PokemonTypes;
        }
    }
}

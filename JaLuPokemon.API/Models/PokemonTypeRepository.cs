using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace JaLuPokemon.API.Models
{
    public class PokemonTypeRepository : IPokemonTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public PokemonTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PokemonType> GetPokemonType(int pokemonTypeId)
        {
            return await _dbContext.PokemonTypes
                .FirstOrDefaultAsync(d => d.PokemonTypeId == pokemonTypeId);
        }

        public async Task<IEnumerable<PokemonType>> GetPokemonTypes()
        {
            return await _dbContext.PokemonTypes.ToListAsync();
        }
    }
}

﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace JaLuPokemon.API.Models
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly AppDbContext _dbContext;

        public PokemonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            return await _dbContext.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetPokemon(int pokemonId)
        {
            return await _dbContext.Pokemons
                .Include(p => p.TypeOne)
                .Include(p => p.TypeTwo)
                .FirstOrDefaultAsync(e => e.PokemonId == pokemonId);
        }

        public async Task<Pokemon> AddPokemon(Pokemon pokemon)
        {
            var result = await _dbContext.Pokemons.AddAsync(pokemon);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Pokemon> UpdatePokemon(Pokemon pokemon)
        {
            var result = await _dbContext.Pokemons
                .FirstOrDefaultAsync(e => e.PokemonId == pokemon.PokemonId);

            if (result != null)
            {
                result.Name = pokemon.Name;
                result.PhotoPath = pokemon.PhotoPath;
                result.TypeOneId = pokemon.TypeOneId;
                result.TypeTwoId = pokemon.TypeTwoId;
                result.Legendary = pokemon.Legendary;
                result.HP = pokemon.HP;
                result.Defense = pokemon.Defense;
                result.Attack = pokemon.Attack;
                result.SpeedAttack = pokemon.SpeedAttack;
                result.SpeedDefense = pokemon.SpeedDefense;
                result.PokemonNumber = pokemon.PokemonNumber;
                result.Generation = pokemon.Generation;

                await _dbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<Pokemon> DeletePokemon(int pokemonId)
        {
            var result = await _dbContext.Pokemons
                .FirstOrDefaultAsync(e => e.PokemonId == pokemonId);
            if (result != null)
            {
                _dbContext.Pokemons.Remove(result);
                await _dbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Pokemon> GetPokemonByName(string name)
        {
            return await _dbContext.Pokemons
                .FirstOrDefaultAsync(e => e.Name == name);
        }

        public async Task<IEnumerable<Pokemon>> Search(string name, bool? legendary)
        {
            IQueryable<Pokemon> query = _dbContext.Pokemons;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            if (legendary != null)
            {
                query = query.Where(e => e.Legendary == legendary);
            }

            return await query.ToListAsync();
        }
    }
}
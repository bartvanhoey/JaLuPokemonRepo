﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace JaLuPokemon.Api.Models
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

        public async void DeletePokemon(int pokemonId)
        {
            var result = await _dbContext.Pokemons
                .FirstOrDefaultAsync(e => e.PokemonId == pokemonId);
            if (result != null)
            {
                _dbContext.Pokemons.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
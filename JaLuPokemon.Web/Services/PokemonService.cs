using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient){        
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            return await _httpClient.GetJsonAsync<Pokemon>($"api/pokemons/{id}");
        }

        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            return await _httpClient.GetJsonAsync<Pokemon[]>("api/pokemons");
        }
    }
}
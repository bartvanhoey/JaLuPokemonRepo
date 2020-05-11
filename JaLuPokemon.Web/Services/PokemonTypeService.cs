using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Services
{
    public class PokemonTypeService : IPokemonTypeService
    {
        private readonly HttpClient _httpClient;

        public PokemonTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonType> GetPokemonType(int id)
        {
            return await _httpClient.GetJsonAsync<PokemonType>($"api/pokemontypes/{id}");
        }

        public async Task<IEnumerable<PokemonType>> GetPokemonTypes()
        {
            return await _httpClient.GetJsonAsync<PokemonType[]>("api/pokemontypes");
        }
    }
}
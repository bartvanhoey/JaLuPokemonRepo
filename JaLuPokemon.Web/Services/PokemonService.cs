using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient httpClient;

        public PokemonService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            return await httpClient.GetJsonAsync<Pokemon[]>("api/pokemons");
        }


    }
}
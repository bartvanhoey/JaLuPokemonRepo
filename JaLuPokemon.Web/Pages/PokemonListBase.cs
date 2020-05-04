using JaLuPokemon.Models;
using JaLuPokemon.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JaLuPokemon.Web.Pages
{
    public class PokemonListBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        public IEnumerable<Pokemon> Pokemons { get; set; }

        public bool ShowFooter { get; set; } = true;
        protected override async Task OnInitializedAsync()
        {
            Pokemons = (await PokemonService.GetPokemons()).ToList();
        }

        protected int SelectedPokemonsCount { get; set; }
        protected void PokemonSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedPokemonsCount++;
            }
            else
            {
                SelectedPokemonsCount--;
            }
        }
    }
}

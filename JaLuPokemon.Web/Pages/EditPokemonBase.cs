using System.Threading.Tasks;
using JaLuPokemon.Models;
using JaLuPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Pages
{
    public class EditPokemonBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        public Pokemon Pokemon { get; set; } = new Pokemon();

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }
    }
}
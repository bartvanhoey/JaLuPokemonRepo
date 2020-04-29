using System.Threading.Tasks;
using JaLuPokemon.Models;
using JaLuPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Pages
{

    public class PokemonDetailsBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Pokemon Pokemon { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }

    }

}
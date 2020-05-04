using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Pages
{
    public class DisplayPokemonBase : ComponentBase
    {
        [Parameter]
        public Pokemon Pokemon { get; set; } = new Pokemon();
        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
using System.Threading.Tasks;
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

        [Parameter]
        public EventCallback<bool> OnPokemonSelection {get; set;}
        protected async Task CheckBox_Changed(ChangeEventArgs e){
          await OnPokemonSelection.InvokeAsync((bool)e.Value);
        }
    }
}
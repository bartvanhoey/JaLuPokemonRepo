using System.Threading.Tasks;
using JaLuPokemon.Models;
using JaLuPokemon.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace JaLuPokemon.Web.Pages
{

    public class PokemonDetailsBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Pokemon Pokemon { get; set; }

        public string Coordinates { get; set; }

        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }

        // protected void Mouse_Move(MouseEventArgs e)
        // {
        //     Coordinates = $"X {e.ClientX} Y {e.ClientY}";
        // }

        protected void Button_Click(MouseEventArgs e)
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "hideFooter";
            }
            else
            {
                ButtonText = "Hide Footer";
                CssClass = null;
            }
        }

    }

}
using Microsoft.AspNetCore.Components;

namespace JaLuPokemon.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        public string Colour { get; set; } = "background-color:white";
        public string Name { get; set; } = "Tom";
        public string Gender { get; set; } = "Male";
    }
}
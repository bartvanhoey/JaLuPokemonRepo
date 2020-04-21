using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JaLuPokemon.Web.Pages
{
    public class PokemonListBase :  ComponentBase
    {
        public IEnumerable<Pokemon> Pokemons { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadPokemons);
        }

        private void LoadPokemons()
        {

            System.Threading.Thread.Sleep(3000);
            char[] seperators = { ',' };
            var sr = new StreamReader("pokemon.csv");
            var pokemonId = 1;
            string line;
            var pokemons = new List<Pokemon>();
           
            while ((line = sr.ReadLine()) != null)
            {
                var values = line.Split(seperators, StringSplitOptions.None);

                var pokemonNumber = int.Parse(values[0]);
                var name = values[1];
                var type1 = values[2];
                var type2 = values[3];
                var total = int.Parse(values[4]);
                var hP = int.Parse(values[5]);
                var attack = int.Parse(values[6]);
                var defense = int.Parse(values[7]);
                var speedAttack = int.Parse(values[8]);
                var speedDefense = int.Parse(values[9]);
                var speed = int.Parse(values[10]);
                var generation = int.Parse(values[11]);
                var legendary = bool.Parse(values[12]);
                var pokemon = new Pokemon(pokemonId, pokemonNumber, name, type1, type2, total, hP, attack, defense,
                    speedAttack, speedDefense, speed, generation, legendary);

                pokemons.Add(pokemon);
                pokemonId++;
            }

            Pokemons = pokemons;
        }



    }



}

using JaLuPokemon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JaLuPokemon.Web.Pages
{
    public class PokemonListBase :  ComponentBase
    {
        public IEnumerable<Pokemon> Pokemons { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadPokemons();
            return base.OnInitializedAsync();
        }

        private void LoadPokemons()
        {
            string[] values;
            char[] seperators = { ',' };
            StreamReader sr = new StreamReader("pokemon.csv");
            int pokemonId = 1;
            string line = sr.ReadLine();
            var pokemons = new List<Pokemon>();
            while ((line = sr.ReadLine()) != null)
            {
                values = line.Split(seperators, StringSplitOptions.None);

                int pokemonNumber = int.Parse(values[0]);
                string name = values[1];
                string type1 = values[2];
                string type2 = values[3];
                int total = int.Parse(values[4]);
                int hP = int.Parse(values[5]);
                int attack = int.Parse(values[6]);
                int defense = int.Parse(values[7]);
                int speedAttack = int.Parse(values[8]);
                int speedDefense = int.Parse(values[9]);
                int speed = int.Parse(values[10]);
                int generation = int.Parse(values[11]);
                bool legendary = bool.Parse(values[12]);


                var pokemon = new Pokemon(pokemonId, pokemonNumber, name, type1, type2, total, hP, attack, defense,
                    speedAttack, speedDefense, speed, generation, legendary);

                pokemons.Add(pokemon);
                pokemonId++;
            }

            Pokemons = pokemons;
        }



    }



}

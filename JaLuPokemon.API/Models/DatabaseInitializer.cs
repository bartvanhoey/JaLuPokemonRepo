using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JaLuPokemon.Models;

namespace JaLuPokemon.API.Models
{
    public static class DatabaseInitializer
    {
        public static void Initialize(this AppDbContext dbContext)
        {
            var pokemonTypesCount = dbContext.PokemonTypes.ToList().Count;

            if (pokemonTypesCount == 0)
            {
                dbContext.PokemonTypes.AddRange(PokemonUtil.PokemonTypes);
                dbContext.SaveChanges();
            }

            var pokemonsCount = dbContext.Pokemons.ToList().Count;
            if (pokemonsCount == 0)
            {
                char[] seperators = { ',' };
                var sr = new StreamReader("pokemon.csv");
                var lines = sr.ReadLine();
                var pokemons = new List<Pokemon>();
                while ((lines = sr.ReadLine()) != null)
                {
                    var line = lines.Split(seperators, StringSplitOptions.None);
                    var pokemonNumber = int.Parse(line[0]);
                    var name = line[1];
                    var type1 = PokemonUtil.GetPokemonTypeIdByValue(line[2]);
                    var type2 = PokemonUtil.GetPokemonTypeIdByValue(line[3]);
                    var total = int.Parse(line[4]);
                    var hP = int.Parse(line[5]);
                    var attack = int.Parse(line[6]);
                    var defense = int.Parse(line[7]);
                    var speedAttack = int.Parse(line[8]);
                    var speedDefense = int.Parse(line[9]);
                    var speed = int.Parse(line[10]);
                    var generation = int.Parse(line[11]);
                    var legendary = bool.Parse(line[12]);

                    var pokemon = new Pokemon(pokemonNumber, name, name.Trim().Replace(" ", "") + "@pragimtech.com",
                        Gender.Other, DateTime.Now, type1, type2, total, hP, attack, defense,
                        speedAttack, speedDefense, speed, generation, legendary);

                    pokemons.Add(pokemon);
                }

                dbContext.Pokemons.AddRange(pokemons);
                dbContext.SaveChanges();
            }
        }
    }
}

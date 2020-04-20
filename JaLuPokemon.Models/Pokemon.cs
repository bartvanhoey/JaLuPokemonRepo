﻿using System;

namespace JaLuPokemon.Models
{
    public class Pokemon
    {
        public Pokemon(int pokemonId, int pokemonNumber, string name, string type1, string type2, 
            int total, int hP, int attack, int defense, int speedAttack, int speedDefense, int speed, int generation, bool legendary)
        {
            PokemonId = pokemonId;
            PokemonNumber = pokemonNumber;
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpeedAttack = speedAttack;
            SpeedDefense = speedDefense;
            Speed = speed;
            Generation = generation;
            Legendary = legendary;
            PhotoPath = "images/" + name.ToLower() + ".png";
        }

        public int PokemonId { get; set; }
        public int PokemonNumber { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpeedAttack { get; set; }
        public int SpeedDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }
        public string PhotoPath { get; set; }




    }
}


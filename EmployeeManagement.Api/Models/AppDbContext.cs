using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace JaLuPokemon.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pokemon>().HasKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonType>().HasKey(p => p.PokemonTypeId);
        }
    }
}

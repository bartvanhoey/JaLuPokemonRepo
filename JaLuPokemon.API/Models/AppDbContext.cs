using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaLuPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace JaLuPokemon.API.Models
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
            modelBuilder.Entity<Pokemon>()
                         .HasOne<PokemonType>(p => p.TypeOne)
                         .WithMany()
                         .HasForeignKey(p => p.TypeOneId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pokemon>()
                .HasOne<PokemonType>(x => x.TypeTwo)
                .WithMany()
                .HasForeignKey(p => p.TypeTwoId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PokemonType>().HasKey(p => p.PokemonTypeId);
        }
    }
}

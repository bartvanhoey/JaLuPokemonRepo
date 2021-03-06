﻿// <auto-generated />
using JaLuPokemon.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JaLuPokemon.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200429054824_pokemonty-navigationproperty")]
    partial class pokemontynavigationproperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JaLuPokemon.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Generation")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<bool>("Legendary")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PokemonNumber")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("SpeedAttack")
                        .HasColumnType("int");

                    b.Property<int>("SpeedDefense")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("TypeOneId")
                        .HasColumnType("int");

                    b.Property<int>("TypeTwoId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId");

                    b.HasIndex("TypeOneId");

                    b.HasIndex("TypeTwoId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("JaLuPokemon.Models.PokemonType", b =>
                {
                    b.Property<int>("PokemonTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PokemonTypeNumber")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PokemonTypeId");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("JaLuPokemon.Models.Pokemon", b =>
                {
                    b.HasOne("JaLuPokemon.Models.PokemonType", "TypeOne")
                        .WithMany()
                        .HasForeignKey("TypeOneId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("JaLuPokemon.Models.PokemonType", "TypeTwo")
                        .WithMany()
                        .HasForeignKey("TypeTwoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

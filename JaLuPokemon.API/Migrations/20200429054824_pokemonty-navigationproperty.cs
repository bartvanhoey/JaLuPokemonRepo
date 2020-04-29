using Microsoft.EntityFrameworkCore.Migrations;

namespace JaLuPokemon.API.Migrations
{
    public partial class pokemontynavigationproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");
        }
    }
}

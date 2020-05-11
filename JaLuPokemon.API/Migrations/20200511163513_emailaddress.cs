using Microsoft.EntityFrameworkCore.Migrations;

namespace JaLuPokemon.API.Migrations
{
    public partial class emailaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pokemons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pokemons");
        }
    }
}

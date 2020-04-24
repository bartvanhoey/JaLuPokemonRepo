using System;
using System.Threading.Tasks;
using JaLuPokemon.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JaLuPokemon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly IPokemonRepository _repo;

        public PokemonsController(IPokemonRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult> GetPokemons()
        {
            try
            {
                return Ok(await _repo.GetPokemons());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
    }
}   
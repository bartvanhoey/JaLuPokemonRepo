using AutoMapper;
using JaLuPokemon.Models;

namespace JaLuPokemon.Web.Models
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile() {
            CreateMap<Pokemon, EditPokemonModel>()
            .ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));
            // CreateMap<EditPokemonModel, Pokemon>();
        }
        
    }
}
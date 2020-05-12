using AutoMapper;
using JaLuPokemon.Models;

namespace JaLuPokemon.Web.Models
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile() {
            CreateMap<Pokemon, EditPokemonModel>()
                .ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));
            CreateMap<EditPokemonModel, Pokemon>();
                // .ForSourceMember(d => d.TypeTwoId, opt => opt.DoNotValidate());
            //     .ForMember(d => d.TypeOneId, opt => opt.Ignore())
            //     .ForMember(d => d.TypeOneId, opt => opt.Ignore())
            //     .ForMember(d => d.TypeOne, opt => opt.Ignore())
            //     .ForMember(d => d.TypeTwo, opt => opt.Ignore());
        }
        
    }
}
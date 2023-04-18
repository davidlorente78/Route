using Application.Dto;
using AutoMapper;
using Traveller.Domain;

namespace Application.Profiles
{
    /// <summary>
    /// A good way to organize your mapping configurations is with profiles. 
    /// Create classes that inherit from Profile and put the configuration in the constructor.
    /// </summary>
    public class CountryProfile : Profile
    {

        /// <summary>
        /// https://docs.automapper.org/en/stable/Configuration.html
        /// </summary>
        /// <returns></returns>
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ShowInDynamicHome, act => act.MapFrom(src => src.ShowInDynamicHome))
                .ReverseMap();
        }
    }
}


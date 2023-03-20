using AutoMapper;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Profiles
{
    /// <summary>
    /// A good way to organize your mapping configurations is with profiles. Create classes that inherit from Profile and put the configuration in the constructor:
    /// </summary>
    public class DestinationProfile : Profile
    {

        /// <summary>
        /// https://docs.automapper.org/en/stable/Configuration.html
        /// </summary>
        /// <returns></returns>
        public DestinationProfile()
        {
            CreateMap<Destination, DestinationDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.DestinationCountry, act => act.MapFrom(src => src.DestinationCountry))
                .ReverseMap();
        }
    }
}


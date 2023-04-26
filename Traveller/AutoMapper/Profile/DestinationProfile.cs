using AutoMapper;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Profiles{
    
    public class DestinationProfile : Profile
    {        
        public DestinationProfile()
        {
            CreateMap<Destination, DestinationDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.DestinationCountry, act => act.MapFrom(src => src.Country))
                .ReverseMap();
        }
    }
}


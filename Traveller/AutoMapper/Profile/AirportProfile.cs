using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class AirportProfile : Profile
    {
        public AirportProfile()
        {
            CreateMap<Airport, AirportDto>()
                .ForMember(dest => dest.AirportCountryId, act => act.MapFrom(src => src.AirportCountry.Id))
                .ForMember(dest => dest.AirportTypeId, act => act.MapFrom(src => src.AirportType.Id))               
                .ReverseMap();
        }
    }
}


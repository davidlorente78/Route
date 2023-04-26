using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class AirportTypeProfile : Profile
    {
        public AirportTypeProfile()
        {
            CreateMap<AirportType, AirportTypeDto>()
                .ReverseMap();
        }
    }
}


using Application.Dto;
using AutoMapper;
using Domain.Transport.Aviation;

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


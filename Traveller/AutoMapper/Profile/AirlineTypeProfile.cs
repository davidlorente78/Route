using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class AirlineTypeProfile : Profile
    {
        public AirlineTypeProfile()
        {
            CreateMap<AirlineType, AirlineTypeDto>()
                .ReverseMap();
        }
    }
}


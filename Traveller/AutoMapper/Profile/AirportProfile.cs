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
                .ReverseMap();
        }
    }
}


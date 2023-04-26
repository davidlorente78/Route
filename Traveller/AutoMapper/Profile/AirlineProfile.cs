using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class AirlineProfile : Profile
    {
        public AirlineProfile()
        {
            CreateMap<Airline, AirlineDto>()                     
                .ReverseMap();
        }
    }
}


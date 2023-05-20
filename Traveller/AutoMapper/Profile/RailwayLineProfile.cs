using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class RailwayLineProfile : Profile
    {
        public RailwayLineProfile()
        {
            CreateMap<RailwayLine, RailwayLineDto>()
                .ReverseMap();
        }
    }
}


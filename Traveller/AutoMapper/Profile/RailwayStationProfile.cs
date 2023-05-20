using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class RailwayStationProfile : Profile
    {
        public RailwayStationProfile()
        {
            CreateMap<RailwayStation, RailwayStationDto>()
                .ReverseMap();
        }
    }
}


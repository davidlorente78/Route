using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Profiles
{

    public class RailwayBranchProfile : Profile
    {
        public RailwayBranchProfile()
        {
            CreateMap<RailwayBranch, RailwayBranchDto>()
                .ReverseMap();
        }
    }
}


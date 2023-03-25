using AutoMapper;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Profiles{
    
    public class DestinationTypeProfile : Profile
    {        
        public DestinationTypeProfile()
        {
            CreateMap<DestinationType, DestinationTypeDto>()
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ReverseMap();
        }
    }
}


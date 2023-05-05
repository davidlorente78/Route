using AutoMapper;
using Domain;
using Traveller.Application.Dto;

namespace Application.Profiles
{
    public class NationalityProfile : Profile
    {
        public NationalityProfile()
        {
            CreateMap<Nationality, NationalityDto>()
                .ReverseMap();
        }
    }
}


using AutoMapper;
using Domain;
using System.Collections.Generic;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Profiles
{

    public class VisaProfile : Profile
    {

        public VisaProfile()
        {
            CreateMap<Visa, VisaDto>()
                .ForMember(dest => dest.QualifyNationalitiesSummary, act => act.MapFrom(src => GetQualifiedNationalitiesSummary(src.QualifyNationalities)));

            CreateMap<VisaDto, Visa>();
        }

        private string GetQualifiedNationalitiesSummary(ICollection<Nationality> nationalities)
        {

            string qualifiedNationalitiesSummary = string.Empty;
            foreach (var nationality in nationalities)

            {
                qualifiedNationalitiesSummary = qualifiedNationalitiesSummary + " " + nationality.Description;

            }

            return qualifiedNationalitiesSummary;
        }
    }
}


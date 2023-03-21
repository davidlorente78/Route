using Application.Mapper.Generic;
using AutoMapper;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public class CountryMapper : GenericMapper<CountryDto, Country>, ICountryMapper
    {
        public CountryMapper(IMapper mapper) : base(mapper) { }

        public override Country CreateEntityFromDto(CountryDto dto)
        {
            Country entity = mapper.Map<Country>(dto);
            entity.Name = dto.Name;
            return entity;
        }

        public override Country UpdateEntityFromDto(CountryDto dto, Country entity)
        {
            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            return entity;
        }
    }
}

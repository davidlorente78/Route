using Application.Dto;
using Application.Mapper.Generic;
using AutoMapper;
using Domain.Utils;
using System;
using Traveller.Domain;

namespace Application.Mapper
{
    public class CountryMapper : GenericMapper<CountryDto, Country>, ICountryMapper
    {
        public CountryMapper(IMapper mapper) : base(mapper) { }

        public override Country CreateEntityFromDto(CountryDto dto)
        {
            ValidateDto(dto);

            Country entity = mapper.Map<Country>(dto);
            entity.SetName(dto.Name);
            //TO CHECK Aqui no hay SetCode ¿?
            return entity;
        }

        public override Country UpdateEntityFromDto(CountryDto dto, Country entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.SetName(dto.Name);
            entity.SetCode(dto.Code.Value);

            return entity;
        }

        private void ValidateDto(CountryDto dto)
        {
            Ensure.ArgumentNotNull(dto.Code, new ArgumentNullException(nameof(dto.Code)));
        }
    }
}

using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Aviation;
using Domain.Utils;
using System;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class AirportMapper : GenericMapper<AirportDto, Airport>, IAirportMapper
    {
        public AirportMapper(IMapper mapper) : base(mapper) { }

        public override Airport CreateEntityFromDto(AirportDto dto)
        {
            ValidateDto(dto);

            Airport entity = mapper.Map<Airport>(dto);
            entity.Name = dto.Name;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.AirportCountryId = dto.AirportCountryId;
            entity.AirportTypeId = dto.AirportTypeId; 

            return entity;
        }

        public override Airport UpdateEntityFromDto(AirportDto dto, Airport entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.AirportCountryId = dto.AirportCountryId;
            entity.AirportTypeId = dto.AirportTypeId;

            return entity;
        }

        private void ValidateDto(AirportDto dto)
        {
        }
    }
}

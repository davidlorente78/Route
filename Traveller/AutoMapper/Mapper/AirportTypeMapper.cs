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

            return entity;
        }

        public override Airport UpdateEntityFromDto(AirportDto dto, Airport entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.AirportCountryID = dto.AirportCountryID;
            //entity.AirportType = dto.AirportType; //TO CHECK

            return entity;
        }

        private void ValidateDto(AirportDto dto)
        {
            Ensure.ArgumentNotNull(dto.AirportCountryID, new ArgumentNullException(nameof(dto.AirportCountryID)));
        }
    }
}

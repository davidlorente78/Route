using Application.Mapper.Generic;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using Domain.Utils;
using System;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class AirportMapper : GenericMapper<AirportDto, Airport>, IAirportMapper
    {
        private IAirportTypeRepository airportTypeRepository;
        public AirportMapper(
            IMapper mapper,
            IAirportTypeRepository airportTypeRepository) 
            : base(mapper)
        {
            this.airportTypeRepository = airportTypeRepository;
        }

        public override Airport CreateEntityFromDto(AirportDto dto)
        {
            ValidateDto(dto);
            var airportType = airportTypeRepository.GetById(dto.AirportTypeId);

            Airport entity = mapper.Map<Airport>(dto);
            entity
                .SetName(dto.Name)
                .SetAirportType(airportType)
                .SetIATACode(dto.IATACode);

            entity.UpdateDescription(dto.Description);
            entity.AirportCountryId = dto.AirportCountryId;

            return entity;
        }

        public override Airport UpdateEntityFromDto(AirportDto dto, Airport entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.SetName(dto.Name);
            entity.UpdateDescription(dto.Description);
            entity.AirportCountryId = dto.AirportCountryId;

            var airportType = airportTypeRepository.GetById(dto.AirportTypeId);
            entity.SetAirportType(airportType);

            return entity;
        }

        private void ValidateDto(AirportDto dto)
        {
            Ensure.ArgumentNotNull(dto.Name, new ArgumentNullException(nameof(dto.Name)));
            Ensure.ArgumentNotNull(dto.IATACode, new ArgumentNullException(nameof(dto.IATACode)));
            Ensure.ArgumentNotNull(dto.AirportTypeId, new ArgumentNullException(nameof(dto.AirportTypeId)));
        }
    }
}

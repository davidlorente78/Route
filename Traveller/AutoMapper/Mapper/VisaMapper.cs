using Application.Mapper.Generic;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using Domain.Utils;
using System;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public class VisaMapper : GenericMapper<VisaDto, Visa>, IVisaMapper
    {
        private IAirportTypeRepository airportTypeRepository;
        public VisaMapper(
            IMapper mapper,
            IAirportTypeRepository airportTypeRepository) 
            : base(mapper)
        {
            this.airportTypeRepository = airportTypeRepository;
        }

        public override Visa CreateEntityFromDto(VisaDto dto)
        {
            ValidateDto(dto);
            //var airportType = airportTypeRepository.GetById(dto.QualifyNationalities);

            Visa entity = mapper.Map<Visa>(dto);
          

            return entity;
        }

        public override Visa UpdateEntityFromDto(VisaDto dto, Visa entity)
        {
            ValidateDto(dto);

          
            return entity;
        }

        private void ValidateDto(VisaDto dto)
        {
            Ensure.ArgumentNotNull(dto.Name, new ArgumentNullException(nameof(dto.Name)));
            Ensure.ArgumentNotNull(dto.Duration, new ArgumentNullException(nameof(dto.Duration)));
            Ensure.ArgumentNotNull(dto.CountryId, new ArgumentNullException(nameof(dto.CountryId)));
        }
    }
}

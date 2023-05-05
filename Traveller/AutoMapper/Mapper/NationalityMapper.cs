using Application.Mapper.Generic;
using AutoMapper;
using Domain;
using Domain.Utils;
using System;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class NationalityMapper : GenericMapper<NationalityDto, Nationality>, INationalityMapper
    {
        public NationalityMapper(IMapper mapper) : base(mapper)
        {
        }

        public override Nationality CreateEntityFromDto(NationalityDto dto)
        {
            ValidateDto(dto);

            Nationality entity = mapper.Map<Nationality>(dto);

            return entity;
        }

        public override Nationality UpdateEntityFromDto(NationalityDto dto, Nationality entity)
        {
            ValidateDto(dto);

            return entity;
        }

        private void ValidateDto(NationalityDto dto)
        {
            Ensure.ArgumentNotNull(dto.Code, new ArgumentNullException(nameof(dto.Code)));
            Ensure.ArgumentNotNull(dto.Description, new ArgumentNullException(nameof(dto.Description)));
        }
    }
}

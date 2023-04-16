using Application.Mapper.Generic;
using AutoMapper;
using Domain.Utils;
using System;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public class DestinationMapper : GenericMapper<DestinationDto, Destination>, IDestinationMapper
    {
        public DestinationMapper(IMapper mapper) : base(mapper) { }

        public override Destination CreateEntityFromDto(DestinationDto dto)
        {
            ValidateDto(dto);

            Destination entity = mapper.Map<Destination>(dto);
            entity.Name = dto.Name;

            return entity;
        }

        public override Destination UpdateEntityFromDto(DestinationDto dto, Destination entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Picture = dto.Picture;
            entity.Description = dto.Description;
            entity.DestinationCountryID = dto.DestinationCountryID;

            return entity;
        }

        private void ValidateDto(DestinationDto dto)
        {
            Ensure.ArgumentNotNull(dto.DestinationCountryID, new ArgumentNullException(nameof(dto.DestinationCountryID)));
        }
    }
}

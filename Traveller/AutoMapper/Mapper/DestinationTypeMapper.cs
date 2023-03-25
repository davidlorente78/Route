using Application.Mapper.Generic;
using AutoMapper;
using Domain.Utils;
using System;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public class DestinationTypeMapper : GenericMapper<DestinationTypeDto, DestinationType>, IDestinationTypeMapper
    {
        public DestinationTypeMapper(IMapper mapper) : base(mapper) { }

        public override DestinationType CreateEntityFromDto(DestinationTypeDto dto)
        {
            ValidateDto(dto);

            DestinationType entity = mapper.Map<DestinationType>(dto);
            entity.Description = dto.Description;

            return entity;
        }

        public override DestinationType UpdateEntityFromDto(DestinationTypeDto dto, DestinationType entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Description = dto.Description;
            ///YPU ARE HERE
            //entity.Destinations = dto.Destinations

            return entity;
        }

        private void ValidateDto(DestinationTypeDto dto)
        {
            Ensure.ArgumentNotNull(dto.Id, new ArgumentNullException(nameof(dto.Id)));
            Ensure.ArgumentNotNull(dto.Description, new ArgumentNullException(nameof(dto.Description)));

        }
    }
}

﻿using Application.Mapper.Generic;
using AutoMapper;
using Domain.Repositories;
using Domain.Utils;
using System;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Application.Mapper
{
    public class DestinationMapper : GenericMapper<DestinationDto, Destination>, IDestinationMapper
    {
        private readonly IDestinationTypeRepository _destinationTypeRepository;
        public DestinationMapper(IMapper mapper,
            IDestinationTypeRepository destinationTypeRepository) : base(mapper)
        {
            _destinationTypeRepository = destinationTypeRepository;
        }

        public override Destination CreateEntityFromDto(DestinationDto dto)
        {
            ValidateDto(dto);

            var destinationType = _destinationTypeRepository.Select(item => item.Id == dto.DestinationTypeID).FirstOrDefault(); ;

            Destination entity = mapper.Map<Destination>(dto);
            entity.Name = dto.Name;
            entity.DestinationTypes.Add(destinationType);

            return entity;
        }

        public override Destination UpdateEntityFromDto(DestinationDto dto, Destination entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Picture = dto.Picture;
            entity.Description = dto.Description;
            entity.CountryId = dto.CountryID;

            return entity;
        }

        private void ValidateDto(DestinationDto dto)
        {
            Ensure.ArgumentNotNull(dto.CountryID, new ArgumentNullException(nameof(dto.CountryID)));
        }
    }
}

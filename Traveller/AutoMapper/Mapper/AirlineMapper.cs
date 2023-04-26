using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class AirlineMapper : GenericMapper<AirlineDto, Airline>, IAirlineMapper
    {
        public AirlineMapper(IMapper mapper) : base(mapper) { }

        public override Airline CreateEntityFromDto(AirlineDto dto)
        {
            ValidateDto(dto);

            Airline entity = mapper.Map<Airline>(dto);
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.AirlineTypeID = dto.AirlineTypeID;
            entity.Picture = dto.Picture;

            return entity;
        }

        public override Airline UpdateEntityFromDto(AirlineDto dto, Airline entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.AirlineTypeID = dto.AirlineTypeID;
            entity.Picture = dto.Picture;

            return entity;
        }

        private void ValidateDto(AirlineDto dto)
        {
        }
    }
}

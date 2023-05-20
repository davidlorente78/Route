using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class RailwayStationMapper : GenericMapper<RailwayStationDto, RailwayStation>, IRailwayStationMapper
    {
        public RailwayStationMapper(IMapper mapper) : base(mapper) { }

        public override RailwayStation CreateEntityFromDto(RailwayStationDto dto)
        {
            ValidateDto(dto);

            RailwayStation entity = mapper.Map<RailwayStation>(dto);
            entity.Name = dto.Name;


            return entity;
        }

        public override RailwayStation UpdateEntityFromDto(RailwayStationDto dto, RailwayStation entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;

            return entity;
        }

        private void ValidateDto(RailwayStationDto dto)
        {
        }
    }
}

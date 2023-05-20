using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Railway;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class RailwayLineMapper : GenericMapper<RailwayLineDto, RailwayLine>, IRailwayLineMapper
    {
        public RailwayLineMapper(IMapper mapper) : base(mapper) { }

        public override RailwayLine CreateEntityFromDto(RailwayLineDto dto)
        {
            ValidateDto(dto);

            RailwayLine entity = mapper.Map<RailwayLine>(dto);
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.Description = dto.Description;
            entity.LineType = dto.LineType;
            entity.CountryID = dto.CountryID;

            return entity;
        }

        public override RailwayLine UpdateEntityFromDto(RailwayLineDto dto, RailwayLine entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.LineType = dto.LineType;
            entity.CountryID = dto.CountryID;

            return entity;
        }

        private void ValidateDto(RailwayLineDto dto)
        {
        }
    }
}

using Application.Dto;
using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class AirportTypeMapper : GenericMapper<AirportTypeDto, AirportType>, IAirportTypeMapper
    {
        public AirportTypeMapper(IMapper mapper) : base(mapper) { }

        public override AirportType CreateEntityFromDto(AirportTypeDto dto)
        {
            ValidateDto(dto);

            AirportType entity = mapper.Map<AirportType>(dto);
            entity.Description = dto.Description;
            
            return entity;
        }

        public override AirportType UpdateEntityFromDto(AirportTypeDto dto, AirportType entity)
        {
            ValidateDto(dto);

            entity.Id = dto.Id;
            entity.Description = dto.Description;
            entity.Code = dto.Code;

            return entity;
        }

        private void ValidateDto(AirportTypeDto dto)
        {
        }
    }
}

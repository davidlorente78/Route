using Application.Mapper.Generic;
using AutoMapper;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public class AirlineTypeMapper : GenericMapper<AirlineTypeDto, AirlineType>, IAirlineTypeMapper
    {
        public AirlineTypeMapper(IMapper mapper) : base(mapper) { }
    }
}

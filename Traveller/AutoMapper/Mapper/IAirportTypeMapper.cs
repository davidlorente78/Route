using Application.Dto;
using Application.Mapper.Generic;
using Domain.Transport.Aviation;
using Traveller.Domain;

namespace Application.Mapper
{
    public interface IAirportTypeMapper : IGenericMapper<AirportTypeDto, AirportType>
    {
    }
}

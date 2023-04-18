using Application.Mapper.Generic;
using Domain.Transport.Aviation;
using Traveller.Application.Dto;

namespace Application.Mapper
{
    public interface IAirportMapper : IGenericMapper<AirportDto, Airport>
    {
    }
}

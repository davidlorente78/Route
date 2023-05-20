using Domain.Transport.Railway;
using DomainServices.Generic;
using Traveller.Application.Dto;

namespace Traveller.DomainServices
{
    public interface IRailwayStationService : IGenericService<RailwayStationDto, RailwayStation>
    {
    }
}
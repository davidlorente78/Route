using Domain.Transport.Aviation;
using DomainServices.Generic;
using Traveller.Application.Dto;

namespace Traveller.DomainServices
{
    public interface IAirlineService : IGenericService<AirlineDto, Airline>
    {
    }
}
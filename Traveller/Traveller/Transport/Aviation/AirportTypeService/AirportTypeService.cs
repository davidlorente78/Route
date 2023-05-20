using Application.Dto;
using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace DomainServices.DestinationService
{
    public class AirportTypeService : GenericService<AirportTypeDto, AirportType>, IAirportTypeService
    {
        public AirportTypeService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IAirportTypeMapper airportTypeMapper,
            IGenericRepository<AirportType> airportTypeRepository,
            IAirportTypeRepository specificAirportTypeRepository)
            : base(unitOfWork, mapper, airportTypeMapper, airportTypeRepository)
        {
        }
    }
}

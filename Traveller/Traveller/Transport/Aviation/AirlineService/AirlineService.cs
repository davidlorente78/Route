using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace DomainServices.AirlineService
{
    public class AirlineService : GenericService<AirlineDto, Airline>, IAirlineService
    {
        IAirlineRepository specificAirlineRepository;

        public AirlineService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IAirlineMapper airlineMapper,
            IGenericRepository<Airline> airlineRepository,
            IAirlineRepository specificAirlineRepository)
            : base(unitOfWork, mapper, airlineMapper, airlineRepository)
        {
            this.specificAirlineRepository = specificAirlineRepository;
        }
    }
}

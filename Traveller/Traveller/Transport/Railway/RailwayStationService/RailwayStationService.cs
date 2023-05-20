using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Railway;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class RailwayStationService : GenericService<RailwayStationDto, RailwayStation>, IRailwayStationService
    {
        IRailwayStationRepository specificRailwayStationRepository;

        public RailwayStationService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IRailwayStationMapper railwayStationMapper,
            IGenericRepository<RailwayStation> railwayStationRepository,
            IRailwayStationRepository specificRailwayStationRepository)
            : base(unitOfWork, mapper, railwayStationMapper, railwayStationRepository)
        {
            this.specificRailwayStationRepository = specificRailwayStationRepository;
        }
    }
}

using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class RailwayLineService : GenericService<RailwayLineDto, RailwayLine>, IRailwayLineService
    {
        IRailwayLineRepository specificRailwayLineRepository;

        public RailwayLineService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IRailwayLineMapper railwayLineMapper,
            IGenericRepository<RailwayLine> railwayLineRepository,
            IRailwayLineRepository specificRailwayLineRepository)
            : base(unitOfWork, mapper, railwayLineMapper, railwayLineRepository)
        {
            this.specificRailwayLineRepository = specificRailwayLineRepository;
        }
    }
}

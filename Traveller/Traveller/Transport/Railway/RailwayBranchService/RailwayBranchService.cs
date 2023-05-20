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
    public class RailwayBranchService : GenericService<RailwayBranchDto, RailwayBranch>, IRailwayBranchService
    {
        IRailwayBranchRepository specificRailwayBranchRepository;

        public RailwayBranchService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IRailwayBranchMapper railwayBranchMapper,
            IGenericRepository<RailwayBranch> railwayBranchRepository,
            IRailwayBranchRepository specificRailwayBranchRepository)
            : base(unitOfWork, mapper, railwayBranchMapper, railwayBranchRepository)
        {
            this.specificRailwayBranchRepository = specificRailwayBranchRepository;
        }
    }
}

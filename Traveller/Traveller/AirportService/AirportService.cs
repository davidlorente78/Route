using Application.Dto;
using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using Domain.Transport.Aviation;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class AirportService : GenericService<AirportDto, Airport>, IAirportService
    {
        IAirportRepository specificAirportRepository;

        public AirportService(
            IUnitOfWork unitOfWork, 
            IMapper mapper,
            IAirportMapper airportMapper, 
            IGenericRepository<Airport> airportRepository,
            IAirportRepository specificAirportRepository) 
            : base(unitOfWork, mapper, airportMapper,  airportRepository)
        {
            this.specificAirportRepository = specificAirportRepository;
        }

    }
}

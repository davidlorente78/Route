using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class CountryService : GenericService<CountryDto, Country>, ICountryService
    {
        ICountryRepository specificCountryRepository;

        public CountryService(
            IUnitOfWork unitOfWork, 
            IMapper mapper,
            ICountryMapper coutryMapper, 
            IGenericRepository<Country> countryRepository, 
            ICountryRepository specificCountryRepository) 
            : base(unitOfWork, mapper, coutryMapper,  countryRepository)
        {
            this.specificCountryRepository = specificCountryRepository;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = specificCountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }
    }
}

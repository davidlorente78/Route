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
            : base(unitOfWork, mapper, coutryMapper, countryRepository)
        {
            this.specificCountryRepository = specificCountryRepository;
        }

        public Country GetByCodeIncludingRanges(char CountryCode)
        {
            var country = specificCountryRepository.GetByCodeIncludingRanges(CountryCode);

            return country;
        }

        public Country GetByCode(char CountryCode)
        {
            var country = specificCountryRepository.GetByCode(CountryCode);

            return country;
        }
    }
}

using Application.Mapper;
using AutoMapper;
using Domain.Repositories;
using DomainServices.Generic;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace DomainServices.CountryService
{
    public class CountryService : GenericService<CountryDto, Country>, ICountryService
    {
        ICountryRepository specificCountryRepository;
        public CountryService(IUnitOfWork unitOfWork, ICountryMapper coutryMapper, IMapper mapper, IGenericRepository<Country> countryRepository, ICountryRepository specificCountryRepository) : base(unitOfWork, coutryMapper, mapper, countryRepository)
        {
            this.specificCountryRepository = specificCountryRepository;
        }

        public ICollection<CountryDto> GetCountriesOrderedByName()
        {
            var countries = specificCountryRepository.GetCountriesOrderedByName().ToList();


            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = specificCountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }
    }
}

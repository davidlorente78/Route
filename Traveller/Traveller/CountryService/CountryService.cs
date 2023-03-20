using AutoMapper;
using Domain.Repositories;
using RouteDataManager.Repositories;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class CountryService : GenericService<CountryDto, Country>, ICountryService
    {
        public CountryService(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Country> countryRepository) : base(unitOfWork, mapper, countryRepository)
        {
        }

        public ICollection<CountryDto> GetCountriesOrderedByName()
        {
            var countries = unitOfWork.CountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = unitOfWork.CountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }
    }
}

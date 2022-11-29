using AutoMapper;
using RouteDataManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.Domain;

namespace Traveller.DomainServices
{
    public class CountryService : ICountryService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;

        }

        public bool CountryExists(int id)
        {
            return (unitOfWork.ICountryRepository?.Find(e => e.CountryID == id)).Count() != 0;
        }

        public ICollection<CountryDto> GetAllCountries()
        {
            var countries = unitOfWork.ICountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public CountryDto GetCountryByID(int ID)
        {
            var country = unitOfWork.ICountryRepository.GetCountryByID(ID).FirstOrDefault();
            CountryDto countryDto = mapper.Map<CountryDto>(country);

            return countryDto;
        }

        public ICollection<CountryDto> GetCountries()
        {
            var countries = unitOfWork.ICountryRepository.GetCountriesOrderedByName().ToList();

            List<CountryDto> countriesDto = mapper.Map<List<CountryDto>>(countries);

            return countriesDto;
        }

        public Country GetCountryIncludingRangesByCountryCode(char CountryCode)
        {
            var country = unitOfWork.ICountryRepository.GetCountryIncludingRangesByCode(CountryCode);

            return country;
        }

        public int AddCountry(CountryDto countryDto)
        {
            var country = CreateEntityFromDto(countryDto);
            unitOfWork.ICountryRepository.Add(country);

            return unitOfWork.SaveChanges();
        }

        public int RemoveCountry(int id)
        {
            var country = GetCountryEntityByID(id);
            unitOfWork.ICountryRepository.Remove(country);
            return unitOfWork.SaveChanges();
        }

        public int UpdateCountry(CountryDto countryDto)
        {
            var country = GetCountryEntityByID(countryDto.CountryID);

            country = UpdateEntityFromDto(countryDto, country);
            unitOfWork.ICountryRepository.Update(country);

            return unitOfWork.SaveChanges();
        }

        private Country GetCountryEntityByID(int id)
        {
            var country = unitOfWork.ICountryRepository.GetCountryByID(id).FirstOrDefault();

            return country;
        }

        private Country CreateEntityFromDto(CountryDto countryDto)
        {
            Country country = mapper.Map<Country>(countryDto);
            return country;
        }

        private Country UpdateEntityFromDto(CountryDto countryDto, Country country)
        {
            country.Code = countryDto.Code;
            country.Name = countryDto.Name;
            return country;
        }

    }
}

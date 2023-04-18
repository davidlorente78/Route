using Application.Dto;
using Application.Mapper.Generic;
using Traveller.Domain;

namespace Application.Mapper
{
    public interface ICountryMapper : IGenericMapper<CountryDto, Country>
    {
    }
}

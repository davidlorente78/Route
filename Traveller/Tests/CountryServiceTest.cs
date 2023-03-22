using DomainServices.Generic;
using NUnit.Framework;
using System.Linq;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace Traveller.Tests.DomainServices
{
    public class CountryServiceTest
    {
        private ICountryService countryService;

        //public CountryServiceTest() { }

        //CHECK TODO DI in Unit Test
        public CountryServiceTest(ICountryService countryService)
        {

            this.countryService = countryService;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetByID()
        {
            var result = countryService.GetByID(1);

            Assert.AreEqual(result.Name, "Laos");
        }

        [Test]
        public void Exists()
        {
            var country = countryService.GetByID(1);
            countryService.Remove(country.Id);

            bool result = countryService.Exists(1);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Add()
        {
            CountryDto dto = new CountryDto() { Code = 'K' , Name = "Test" , ShowInDynamicHome = true};
            countryService.Add(dto);

            var result = countryService.GetAll().FirstOrDefault(item=> item.Code == dto.Code);
            Assert.AreEqual(result.Name, dto.Name);
        }
    }
}
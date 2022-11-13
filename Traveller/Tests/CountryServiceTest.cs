using NUnit.Framework;
using Traveller.DomainServices;

namespace Traveller.Tests.DomainServices
{
    public class CountryServiceTest
    {
        private ICountryService countryService;

        public CountryServiceTest() { }

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
        public void Test1()
        {
            var result = countryService.GetCountry(1);

            Assert.AreEqual(result.Name, "Laos");
        }

        [Test]
        public void Test2()
        {
            var country = countryService.GetCountryByID(1);
            countryService.RemoveCountry(country);

            bool result = countryService.CountryExists(1);

            Assert.AreEqual(false, result);
        }
    }
}
using Application.Dto;
using Microsoft.Extensions.DependencyInjection;
using Traveller.DomainServices;

namespace Test
{
    [TestClass]
    public class CountryServiceTest
    {
        private ServiceProvider serviceProvider;
        private ICountryService countryService;

        [TestInitialize]
        public void TestInitialize()
        {
            // Configurar las dependencias necesarias para las pruebas
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            this.serviceProvider = services.BuildServiceProvider();
            this.countryService = serviceProvider.GetRequiredService<ICountryService>();
        }
        public CountryServiceTest() { }

  
        [TestMethod]
        public void GetByID()
        {
            var result = countryService.GetByID(1);

            Assert.AreEqual(result.Name, "Laos");
        }

        [TestMethod]
        public void Exists()
        {
            var country = countryService.GetByID(1);
            countryService.Remove(country.Id);

            bool result = countryService.Exists(1);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Add()
        {
            CountryDto dto = new CountryDto() { Code = 'K', Name = "Test", ShowInDynamicHome = true };
            countryService.Add(dto);

            var result = countryService.GetAll().FirstOrDefault(item => item.Code == dto.Code);
            Assert.AreEqual(result.Name, dto.Name);
        }

    }
}
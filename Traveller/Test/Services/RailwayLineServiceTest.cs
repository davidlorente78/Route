using Application.Dto;
using Microsoft.Extensions.DependencyInjection;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace Test.Services
{
    [TestClass]
    public class RailwayLineServiceTest
    {
        private ServiceProvider serviceProvider;
        private ICountryService countryService;
        private IRailwayLineService railwayLineService;


        [TestInitialize]
        public void TestInitialize()
        {
            // Configurar las dependencias necesarias para las pruebas
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();
            countryService = serviceProvider.GetRequiredService<ICountryService>();
            railwayLineService = serviceProvider.GetRequiredService<IRailwayLineService>();
        }

        public RailwayLineServiceTest() { }


     

        [TestMethod]
        public void Remove()
        {
            var railwayLineDto = railwayLineService.GetById(1);
            railwayLineService.Remove(railwayLineDto.Id);

            bool result = railwayLineService.Exists(1);

            Assert.AreEqual(false, result);
        }

     
    }
}
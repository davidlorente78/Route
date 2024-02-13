using Microsoft.Extensions.DependencyInjection;
using Traveller.DomainServices;

namespace Test.Services
{
    [TestClass]
    public class BorderCrossingServiceTest
    {
        private ServiceProvider serviceProvider;
        private IBorderCrossingService borderCrossingService;
        private ICountryService countryService;

        //Este constructor es necesario para la inyeccion de dependencias
        public BorderCrossingServiceTest() { }

        [TestInitialize]
        public void TestInitialize()
        {
            // Configurar las dependencias necesarias para las pruebas
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();

            borderCrossingService = serviceProvider.GetRequiredService<IBorderCrossingService>();
            countryService = serviceProvider.GetRequiredService<ICountryService>();
        }

        [TestMethod]
        public void TestFrontierService()
        {
            var Laos = countryService.GetById(1);
            var Thailand = countryService.GetById(3);

            //Access Laos from Thailand
            var frontiersAB = borderCrossingService.GetBorderCrossingsByOriginAndFinalCountryCode(Laos.Id, Thailand.Id);
            var frontiersBA = borderCrossingService.GetBorderCrossingsByOriginAndFinalCountryCode(Thailand.Id, Laos.Id);

            //NongKhai e Internacional
            //var frontier_airport = frontierService.FrontierstoAccesDestinationFromOriginIncludingAirports('L', 'T');
            Assert.AreEqual(true, frontiersAB.Count == 4);
            Assert.IsTrue(frontiersAB.Any(item => item.Name.Contains("Frienship Bridge I")));
            Assert.IsTrue(frontiersBA.Any(item => item.Name.Contains("Frienship Bridge II")));

            Assert.IsTrue(frontiersAB.Count == frontiersBA.Count);
        }
    }
}
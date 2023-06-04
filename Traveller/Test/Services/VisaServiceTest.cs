using Data.Nationalities;
using Microsoft.Extensions.DependencyInjection;
using Traveller.DomainServices;

namespace Test.Services
{
    [TestClass]
    public class VisaServiceTest
    {
        private ServiceProvider serviceProvider;
        private IVisaService visaService;
        private ICountryService countryService;

        //Este constructor es necesario para la inyeccion de dependencias
        public VisaServiceTest() { }


        [TestInitialize]
        public void TestInitialize()
        {
            // Configurar las dependencias necesarias para las pruebas
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();

            visaService = serviceProvider.GetRequiredService<IVisaService>();
            countryService = serviceProvider.GetRequiredService<ICountryService>();
        }

        [TestMethod]
        public void MaxStay_WhenCountryLaosAndNationalityES_Returns30()
        {
            var Laos = countryService.GetById(1);

            var maxStayDays = visaService.GetMaxStay(Laos.Code, Nationalities.ES.Code);

            Assert.IsTrue(maxStayDays == 30);
        }

        [TestMethod]
        public void MaxStay_WhenCountryMalaysiaAndNationalityES_Returns90()
        {
            var Malaysia = countryService.GetById(4);

            var maxStayDays = visaService.GetMaxStay(Malaysia.Code, "ES");

            Assert.IsTrue(maxStayDays == 90);
        }

        [TestMethod]
        public void MaxStay_WhenCountryHasVisasButNotForNationality_Returns_0()
        {
            var Malaysia = countryService.GetById(4);

            var maxStayDays = visaService.GetMaxStay(Malaysia.Code, "XX");

            Assert.IsTrue(maxStayDays == 0);
        }             
    }
}
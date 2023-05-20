using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RouteDataManager.Controllers;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace Test.Controllers
{
    [TestClass]
    public class CountriesControllerTest
    {
        private ServiceProvider serviceProvider;
        private ICountryService countryService;
        private IPublishEndpoint publishEndpoint;

        [TestInitialize]
        public void TestInitialize()
        {
            // Configurar las dependencias necesarias para las pruebas
            var services = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();
            countryService = serviceProvider.GetRequiredService<ICountryService>();
            publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();
        }
        public CountriesControllerTest() { }


        [TestMethod]
        public void PostAction_Should_Receive_Json_Data()
        {
            //Arrange

            var countryDto = new CountryDto
            {
                Code = 'X',
                Name = "Test",
                ShowInDynamicHome = false,
                ShowInDynamicHomeOrder = 0

            };

            var controller = new CountriesController(countryService, publishEndpoint);

            //Act
            var result = controller.Create(countryDto);
            var country = countryService.GetByCodeIncludingRanges(countryDto.Code);
            var redirectToActionResult = result as RedirectToActionResult;
            var see = result as ObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
            Assert.IsTrue(country.Name == countryDto.Name);
            Assert.IsTrue(redirectToActionResult.ActionName == "Index");
        }
    }

}
using Application.Dto.Authorization;
using DomainServices.Authorization;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RouteDataManager.Controllers;
using Traveller.DomainServices;

namespace Test.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        private ServiceProvider serviceProvider;
        private ICountryService countryService;
        private IPublishEndpoint publishEndpoint;
        private IAuthManager authManager;
        private ILogger<AccountController> logger;

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
            logger = serviceProvider.GetRequiredService<ILogger<AccountController>>();
            authManager = serviceProvider.GetRequiredService<IAuthManager>();
        }

        public AccountControllerTest() { }


        [TestMethod]
        public void Login_WhenUserIsAuthorized_ShouldReturnValidToken()
        {
            //Arrange
            var loginDto = new LoginDto
            {
                Email = "admin@localhost.com",
                Password = "P@ssword1"
            };

            var controller = new AccountController(authManager, logger);

            //Act
            var result = controller.Login(loginDto);

            //AuthResponseDto authResponseDto= (AuthResponseDto) result ;
            ////Assert
            //Assert.IsTrue(authResponseDto.Token != null);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Traveller.DomainServices;


//using RouteDataManager.Repositories; Solved
namespace RouteDataManager.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountryService  countryService;

        //TODO
        //InvalidOperationException: Unable to resolve service for type 'Traveller.RouteService.CountryService' while attempting to activate 'RouteDataManager.Controllers.CountryController'.
        //Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetService(IServiceProvider sp, Type type, Type requiredBy, bool isDefaultParameterRequired)
        
        /// <summary>
        /// Here are injecting only the IUnitOfWork object. This way, you can completely avoid writing lines and lines of injections to your controllers.
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// 
        public CountriesController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public IActionResult Index()
        {
            ICollection<Traveller.Domain.Country>? countries = countryService.GetAllCountries();
            return View(countries);
            //return Ok(countries);
            //return View();

        }

      
    }

  
}

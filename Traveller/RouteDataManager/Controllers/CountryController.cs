using Microsoft.AspNetCore.Mvc;
using RouteDataManager.ViewModels;
using Traveller.DomainServices;


//using RouteDataManager.Repositories; Solved
namespace RouteDataManager.Controllers
{
    /// <summary>
    /// Los nombres de los controlodores empiezan por el nombre en singular de la entidad
    /// </summary>
    public class CountryController : Controller
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
        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public IActionResult Index(int? id)
        {
            var viewModel = new CountryIndexData();

            //TODO Mapeo entre entidades de dominio y entidades del modelo de la vista

            ICollection<Traveller.Domain.Country>? countries = countryService.GetAllCountries();

            viewModel.Countries = countries;                

            if (id != null)
            {
                ViewBag.CountryId = id.Value;

                var selectedCountryDestinations = countries.Single(c => c.CountryID == id.Value).Destinations;
                var selectedCountryFrontiers = countries.Single(c => c.CountryID == id.Value).Frontiers;
                viewModel.Destinations = selectedCountryDestinations;
                viewModel.Frontiers = selectedCountryFrontiers;
            }
            return View(viewModel);
            //return View(countries);
         

        }

      
    }

  
}

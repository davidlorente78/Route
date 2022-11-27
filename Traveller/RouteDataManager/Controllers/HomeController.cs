using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using System.Diagnostics;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICountryService countryService;
        private readonly ApplicationContext _context;

       

        public HomeController(ApplicationContext context,ICountryService countryService,ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
            this.countryService = countryService;
        }

        public IActionResult Index()
        {
            DynamicIndexViewModel dynamicIndexData = new DynamicIndexViewModel();

            var countriesOrderedByShowInDynamicHomeOrder = _context.Countries.Where(c => c.ShowInDynamicHome == true).Include(c => c.Destinations).Include(c => c.Airports).OrderBy(c=>c.ShowInDynamicHomeOrder);

            foreach (Country country in countriesOrderedByShowInDynamicHomeOrder) { 
            
                dynamicIndexData.CountryNames.Add(country.Name);
                dynamicIndexData.DestinationCountryCount.Add(country.Destinations.Count);

                //TODO Operator control null
                if (country.Airports != null)
                {
                    dynamicIndexData.DestinationAirportsCount.Add(country.Airports.Count);
                }
                else
                    dynamicIndexData.DestinationAirportsCount.Add(0);

            }
            return View(dynamicIndexData);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
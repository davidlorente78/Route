using Data.EntityTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Traveller.Domain;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace RouteDataManager.Controllers
{
    public class RoundRoutesController : Controller
    {
        private readonly ApplicationContext _context;

        private List<char> route = new List<char> { };

        private IVisaService visaService;

        private IRouteService routeService;

        public RoundRoutesController(ApplicationContext context, IVisaService visaService, IRouteService routeService, ICountryService countryService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;
            //this.countryService = countryService;
        }

        public async Task<IActionResult> Index(RoundRouteIndexViewModel roundItineraryIndexViewModel)
        {
            return ProcessItinerary(ref roundItineraryIndexViewModel);
        }

        private IActionResult ProcessItinerary(ref RoundRouteIndexViewModel roundItineraryIndexViewModel)
        {
           

            var ProposedRoutes = new List<List<char>>();

            var itineraryMonthsList = _context.Months.ToList();

            var countries = _context.Countries
               .Include(x => x.Ranges)
               .ThenInclude(r => r.RangeType)
               .Where(x => x.Ranges.Count != 0).ToList();

            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            AddRules(countries, 1, routeService.ruleContainer.Vector);

            var ProposedRoutesFirstSemester = routeService.proposedRoutes(6);

            routeService.ruleContainer.ResetRules();

            AddRules(countries, 1 + 6, routeService.ruleContainer.Vector);

            var ProposedRoutesSecondSemester = routeService.proposedRoutes(itineraryMonthsList.Count - 6);

            routeService.ruleContainer.ResetRules();

            AddRules(countries, 1, routeService.ruleContainer.Vector);

            foreach (var firstSemesterRoute in ProposedRoutesFirstSemester)
            {
                foreach (var secondSemesterRoute in ProposedRoutesSecondSemester)
                {
                    List<char> anualRouteToValidate = new List<char>();
                    anualRouteToValidate.AddRange(firstSemesterRoute);
                    anualRouteToValidate.AddRange(secondSemesterRoute);

                    var result = routeService.BrokenRules(anualRouteToValidate);

                    if (result.Count == 0)
                    {
                        ProposedRoutes.Add(anualRouteToValidate);
                    }
                }
            }

            if (ProposedRoutes.Count == 0)
            {
                throw new Exception("Fracas");
            }

            //Route Showing Index Range Control //TODO Showing 0 of 39 found deberia estar indexado desde 1
            if (roundItineraryIndexViewModel.ShowingIndex < 0) roundItineraryIndexViewModel.ShowingIndex = ProposedRoutes.Count - 1;
            if (roundItineraryIndexViewModel.ShowingIndex > ProposedRoutes.Count - 1) roundItineraryIndexViewModel.ShowingIndex = 0;

            var showingRoute = ProposedRoutes[roundItineraryIndexViewModel.ShowingIndex];

            route = showingRoute;

            //Route To Presentation
            roundItineraryIndexViewModel.RoutesFoundCount = ProposedRoutes.Count;

            for (var i = 0; i < itineraryMonthsList.Count; i++)
            {
                roundItineraryIndexViewModel.FilterCountry.Add(countries.FirstOrDefault(x => x.Code == route[i]));
            }

            List<Country> filterCountries = ViewModelContriesToList(roundItineraryIndexViewModel);

            int indexMonth = 1;
            roundItineraryIndexViewModel.Months = itineraryMonthsList;

            foreach (var country in filterCountries.Where(c => c != null))
            {
                var seasonRange = _context.Ranges
                    .Where(d => d.CountryID == country.Id && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
                    .Include(f => f.EntityDescription_ByMonth)
                    .ThenInclude(x => x.Items).FirstOrDefault();

                if (seasonRange != null)
                {
                    var Month = itineraryMonthsList[indexMonth - 1].Name; //Esto es la Key del diccionario que se va a consultar

                    ICollection<Domain.EntityFrameworkDictionary.DictionaryItem<string, string>>? MonsoonDictionary =
                            seasonRange.EntityDescription_ByMonth.Items;

                    var Description =
                        MonsoonDictionary
                            .Where(x => x.Key == itineraryMonthsList[indexMonth - 1].Name).FirstOrDefault()
                            .Value;

                    roundItineraryIndexViewModel.CountryReport.Add(Description);
                }
                else
                {
                    roundItineraryIndexViewModel.CountryReport = new List<string>();
                }

                indexMonth++;

                if (indexMonth > 12) indexMonth = 1;

            }

            return View("Index", roundItineraryIndexViewModel);
        }

        public async Task<IActionResult> Previous(int ShowingIndex)
        {
            RoundRouteIndexViewModel roundItineraryIndexViewModel = new RoundRouteIndexViewModel();

            roundItineraryIndexViewModel.ShowingIndex = ShowingIndex - 1;

            return ProcessItinerary(ref roundItineraryIndexViewModel);
        }

        public async Task<IActionResult> Next(int ShowingIndex)
        {
            RoundRouteIndexViewModel roundItineraryIndexViewModel = new RoundRouteIndexViewModel();

            roundItineraryIndexViewModel.ShowingIndex = ShowingIndex + 1;

            return ProcessItinerary(ref roundItineraryIndexViewModel);
        }


        private void AddRules(List<Country> countries, int startRouteMonth, List<char> vector)
        {
            var MaxStay = new Dictionary<char, int>();

            routeService.ruleContainer.AddRule(
                       new EachStayMustBeLessThanXMonth('M', 3)); 

            //routeService.ruleContainer.AddRule(
            //            new TotalStayinYearMustBeLessThanXMonth('M', 3));

            foreach (Country country in countries)
            {
                if (vector.Contains(country.Code))
                {                   
                        var MaxStayDays = visaService.GetMaxStay(country.Code, "ES");
                        var MaxStayMonth = MaxStayDays / 30;
                        MaxStay.Add(country.Code, visaService.GetMaxStay(country.Code, "ES"));

                        routeService.ruleContainer.AddRule(
                            new EachStayMustBeLessThanXMonth(country.Code, MaxStayMonth));

                    routeService.ruleContainer.AddRule(
                      new EachStayMustBeLessThanXMonth(country.Code, 6));
                    // "Holders of normal passports of the following countries are granted visa-free travel to Thailand for a period of up to 30 days. The exemption is granted at most twice in a calendar year when entering over land or via a sea border but there is no limitation when entering by air. For Malaysians entering by land border, there is no limitation in issuing the 30-day visa exemption stamp.",

                    if (country.Code == 'T' || country.Code == 'M')
                    {
                        routeService.ruleContainer.AddRule(
                           new AnualEntriesMustBeLessThanX(country.Code, 2));
                    }
                    else
                    {
                        routeService.ruleContainer.AddRule(
                            new AnualEntriesMustBeLessThanX(country.Code, 1));
                    }

                    //Warning Code
                    var monsoonEvaluatorRange = _context.Ranges
                            .Where(r => r.RangeType.Code == RangeTypes.MonsoonEvaluatorRangeType.Code && r.Country.Code == country.Code)
                            .Include(f => f.EntityEvaluator_ByMonth)
                                .ThenInclude(x => x.Items)
                            .FirstOrDefault();

                    var strict = true;

                    if (monsoonEvaluatorRange != null)
                    {
                        routeService.ruleContainer.AddRule(
                            new MustConsiderWeather(
                                monsoonEvaluatorRange.EntityEvaluator_ByMonth,
                                country.Code,
                                startRouteMonth,
                                strict));
                    }
                }
            }
        }

        private static List<Country> ViewModelContriesToList(RoundRouteIndexViewModel roundItineraryIndexViewModel)
        {

            List<Country> filterCountries = new List<Country>();

            foreach (var country in roundItineraryIndexViewModel.FilterCountry)
            {
                filterCountries.Add(country);
            }

            return filterCountries;
        }
    }
}


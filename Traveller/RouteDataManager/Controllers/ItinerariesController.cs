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
    public class ItinerariesController : Controller
    {
        private readonly ApplicationContext _context;

        private List<char> route = new List<char> { };

        private IVisaService visaService;

        private IRouteService routeService;

        public ItinerariesController(ApplicationContext context, IVisaService visaService, IRouteService routeService, ICountryService countryService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;
            //this.countryService = countryService;
        }

        public async Task<IActionResult> Index(ItineraryIndexViewModel itineraryIndexViewModel)
        {
            return ProcessItinerary(ref itineraryIndexViewModel);
        }

        private IActionResult ProcessItinerary(ref ItineraryIndexViewModel itineraryIndexViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges)
                .ThenInclude(r => r.RangeType).Where(x => x.Ranges.Count != 0).ToList();

            var StartMonth = itineraryIndexViewModel.FilterStartMonth.MonthID;
            var EndMonth = itineraryIndexViewModel.FilterEndMonth.MonthID;

            List<Domain.Ranges.Month>? completeMonthsList = _context.Months.ToList();

            var itineraryMonthsList = CreateMonthList(StartMonth, EndMonth, completeMonthsList);

            int itineraryMonthsCount = itineraryMonthsList.Count;

            if (itineraryMonthsCount > 6)
            {
                return PartialView(CreateEmptyView(StartMonth, EndMonth, "Too long to calculate."));
            }

            //Inicializacion Vector
            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            //Inicializacion Reglas
            AddRules(countries, StartMonth, routeService.ruleContainer.Vector);

            var ProposedRoutes = routeService.proposedRoutes(itineraryMonthsCount);

            if (ProposedRoutes.Count == 0)
            {
                return PartialView(CreateEmptyView(StartMonth, EndMonth, "We can not find any itinerary that acomplish all the rules"));
            }

            //Route Showing Index Range Control //TODO Showing 0 of 39 found deberia estar indexado desde 1
            if (itineraryIndexViewModel.ShowingIndex < 0) itineraryIndexViewModel.ShowingIndex = ProposedRoutes.Count - 1;
            if (itineraryIndexViewModel.ShowingIndex > ProposedRoutes.Count - 1) itineraryIndexViewModel.ShowingIndex = 0;
            var showingRoute = ProposedRoutes[itineraryIndexViewModel.ShowingIndex];
            route = showingRoute;

            var brokenRules = routeService.BrokenRules(this.route);

            itineraryIndexViewModel.RulesReport = brokenRules;
            itineraryIndexViewModel.RoutesFoundCount = ProposedRoutes.Count;

            for (var i = 0; i < itineraryMonthsCount; i++)
            {
                itineraryIndexViewModel.FilterCountry.Add(countries.FirstOrDefault(x => x.Code == route[i]));
            }

            //Montar lista de filterCountry

            List<Country> filterCountries = ViewModelContriesToList(itineraryIndexViewModel);

            itineraryIndexViewModel.ItineraryMonths = itineraryMonthsCount;
            itineraryIndexViewModel.ShowingIndex = itineraryIndexViewModel.ShowingIndex;

            SelectList selectListStartMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryIndexViewModel.FilterStartMonth.MonthID);
            itineraryIndexViewModel.SelectListStartMonth = selectListStartMonth;

            SelectList selectListEndMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryIndexViewModel.FilterEndMonth.MonthID);
            itineraryIndexViewModel.SelectListEndMonth = selectListEndMonth;

            var countriesWithRanges = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();

            int indexMonth = StartMonth;
            itineraryIndexViewModel.Months = itineraryMonthsList;

            foreach (var country in filterCountries.Where(c => c != null))
            {
                var seasonRange = _context.Ranges
                .Where(d => d.CountryID == country.Id && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
                    .Include(f => f.EntityDescription_ByMonth)
                         .ThenInclude(x => x.Items).FirstOrDefault();

                if (seasonRange != null)
                {
                    var Month = completeMonthsList[indexMonth - 1].Name; //Esto es la Key del diccionario que se va a consultar

                    ICollection<Domain.EntityFrameworkDictionary.DictionaryItem<string, string>>? MonsoonDictionary =
                            seasonRange.EntityDescription_ByMonth.Items;

                    var Description = MonsoonDictionary
                        .Where(x => x.Key == completeMonthsList[indexMonth - 1].Name).FirstOrDefault()
                        .Value;

                    itineraryIndexViewModel.CountryReport.Add(Description);
                }
                else
                {
                    itineraryIndexViewModel.CountryReport = new List<string>();
                }

                indexMonth++;

                if (indexMonth > 12) indexMonth = 1;

            }

            return View("Index", itineraryIndexViewModel);
        }

        public async Task<IActionResult> Previous(int ShowingIndex, int StartMonth, int EndMonth)
        {
            ItineraryIndexViewModel itineraryIndexViewModel = new ItineraryIndexViewModel();
            itineraryIndexViewModel.FilterStartMonth.MonthID = StartMonth;
            itineraryIndexViewModel.FilterEndMonth.MonthID = EndMonth;
            itineraryIndexViewModel.ShowingIndex = ShowingIndex - 1;

            return ProcessItinerary(ref itineraryIndexViewModel);
        }

        public async Task<IActionResult> Next(int ShowingIndex, int StartMonth, int EndMonth)
        {
            ItineraryIndexViewModel itineraryIndexViewModel = new ItineraryIndexViewModel();
            itineraryIndexViewModel.FilterStartMonth.MonthID = StartMonth;
            itineraryIndexViewModel.FilterEndMonth.MonthID = EndMonth;
            itineraryIndexViewModel.ShowingIndex = ShowingIndex + 1;

            return ProcessItinerary(ref itineraryIndexViewModel);
        }

        private List<Domain.Ranges.Month> CreateMonthList(int startMonth, int endMonth, List<Domain.Ranges.Month> completeMonthsList)
        {
            var monthsList = new List<Domain.Ranges.Month>();
            var YearChange = (endMonth < startMonth) ? true : false;

            if (!YearChange)
            {
                for (int x = startMonth; x < endMonth + 1; x++)
                {
                    //La lista de meses esta indexada desde 0
                    monthsList.Add(completeMonthsList.ElementAt(x - 1));
                }
            }
            else
            {
                for (int x = startMonth; x < 12 + 1; x++)
                {
                    monthsList.Add(completeMonthsList.ElementAt(x - 1));
                }

                for (int x = 1; x < endMonth + 1; x++)
                {
                    monthsList.Add(completeMonthsList.ElementAt(x - 1));
                }
            }

            return monthsList;
        }

        private void AddRules(List<Country> countries, int startRouteMonth, List<char> vector)
        {
            //TODO INPUT PARAM NATIONALITY
            var MaxStayMalaysia = visaService.GetMaxStay('M', "ES");
            var MaxStayThailand = visaService.GetMaxStay('T', "ES");

            var MaxStay = new Dictionary<char, int>();

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
                        new AnualEntriesMustBeLessThanX(country.Code, 2));

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

        private static List<Country> ViewModelContriesToList(ItineraryIndexViewModel itineraryIndexViewModel)
        {

            List<Country> filterCountries = new List<Country>();

            foreach (var country in itineraryIndexViewModel.FilterCountry)
            {
                filterCountries.Add(country);
            }

            return filterCountries;
        }

        private ItineraryIndexViewModel CreateEmptyView(int StartMonth, int EndMonth, string message)
        {
            List<Domain.Ranges.Month>? completeMonthsList = _context.Months.ToList();
            var itineraryIndexViewModel = new ItineraryIndexViewModel();
            itineraryIndexViewModel.RulesReport = new List<string> { message };
            itineraryIndexViewModel.ItineraryMonths = -1;
            SelectList selectListStartMonthReload = new SelectList(completeMonthsList, "MonthID", "Name", StartMonth);
            itineraryIndexViewModel.SelectListStartMonth = selectListStartMonthReload;

            SelectList selectListEndMonthReload = new SelectList(completeMonthsList, "MonthID", "Name", EndMonth);
            itineraryIndexViewModel.SelectListEndMonth = selectListEndMonthReload;

            return itineraryIndexViewModel;
        }
    }
}

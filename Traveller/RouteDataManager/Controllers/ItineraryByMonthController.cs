using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Domain.Ranges;
using Traveller.Domain;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RouteService.Rules;
using Data.EntityTypes;

namespace RouteDataManager.Controllers
{
    public class ItineraryByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        // private ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();

        private List<char> route = new List<char> { };

        private IVisaService visaService;

        private IRouteService routeService;


        public ItineraryByMonthController(ApplicationContext context, IVisaService visaService, IRouteService routeService, ICountryService countryService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;
            //this.countryService = countryService;
        }

        public async Task<IActionResult> Index(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            return ProcessItinerary(ref itineraryByMonthIndexViewModel);
        }

        private IActionResult ProcessItinerary(ref ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges)
                .ThenInclude(r => r.RangeType).Where(x => x.Ranges.Count != 0).ToList();


            var StartMonth = itineraryByMonthIndexViewModel.FilterStartMonth.MonthID; 
            var EndMonth = itineraryByMonthIndexViewModel.FilterEndMonth.MonthID;   

            List<Domain.Ranges.Month>? completeMonthsList = _context.Months.ToList();

            var itineraryMonthsList = CreateMonthList(StartMonth, EndMonth, completeMonthsList);

            //int itineraryMonthsCount = Math.Abs(EndMonth - StartMonth + 1);
            int itineraryMonthsCount = itineraryMonthsList.Count;

            if (itineraryMonthsCount > 6)
            {
               return PartialView(CreateEmptyView(StartMonth, EndMonth, "Too long to calculate."));
            }

            //Inicializacion Vector
            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            //routeService.ruleContainer.Vector = new List<char>() { 'T', 'L', 'V' };

            //Inicializacion Reglas
            AddRules(countries, StartMonth, routeService.ruleContainer.Vector);

            var ProposedRoutes = routeService.proposedRoutes(itineraryMonthsCount);

            if (ProposedRoutes.Count == 0)
            {
                return PartialView(CreateEmptyView(StartMonth, EndMonth, "We can not find any itinerary that acomplish all the rules"));
            }

            //Route Showing Index Range Control //TODO Showing 0 of 39 found deberia estar indexado desde 1
            if (itineraryByMonthIndexViewModel.ShowingIndex < 0) itineraryByMonthIndexViewModel.ShowingIndex = ProposedRoutes.Count - 1;
            if (itineraryByMonthIndexViewModel.ShowingIndex > ProposedRoutes.Count - 1) itineraryByMonthIndexViewModel.ShowingIndex = 0;
            var showingRoute = ProposedRoutes[itineraryByMonthIndexViewModel.ShowingIndex];
            route = showingRoute;

            var brokenRules = routeService.BrokenRules(this.route);

            itineraryByMonthIndexViewModel.RulesReport = brokenRules;
            itineraryByMonthIndexViewModel.RoutesFoundCount = ProposedRoutes.Count;

            if (itineraryMonthsCount > 0) itineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.Code == route[0]).FirstOrDefault();
            if (itineraryMonthsCount > 1) itineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.Code == route[1]).FirstOrDefault();
            if (itineraryMonthsCount > 2) itineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.Code == route[2]).FirstOrDefault();
            if (itineraryMonthsCount > 3) itineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.Code == route[3]).FirstOrDefault();
            if (itineraryMonthsCount > 4) itineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.Code == route[4]).FirstOrDefault();
            if (itineraryMonthsCount > 5) itineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.Code == route[5]).FirstOrDefault();
            if (itineraryMonthsCount > 6) itineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.Code == route[6]).FirstOrDefault();
            if (itineraryMonthsCount > 7) itineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.Code == route[7]).FirstOrDefault();
            if (itineraryMonthsCount > 8) itineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.Code == route[8]).FirstOrDefault();
            if (itineraryMonthsCount > 9) itineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.Code == route[9]).FirstOrDefault();
            if (itineraryMonthsCount > 10) itineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.Code == route[10]).FirstOrDefault();
            if (itineraryMonthsCount > 11) itineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.Code == route[11]).FirstOrDefault();

            //Montar lista de filterCountry

            List<Country> filterCountries = ViewModelContriesToList(itineraryByMonthIndexViewModel);

            itineraryByMonthIndexViewModel.ItineraryMonths = itineraryMonthsCount;
            itineraryByMonthIndexViewModel.ShowingIndex = itineraryByMonthIndexViewModel.ShowingIndex;

            SelectList selectListStartMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryByMonthIndexViewModel.FilterStartMonth.MonthID);
            itineraryByMonthIndexViewModel.SelectListStartMonth = selectListStartMonth;

            SelectList selectListEndMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryByMonthIndexViewModel.FilterEndMonth.MonthID);
            itineraryByMonthIndexViewModel.SelectListEndMonth = selectListEndMonth;

            var countriesWithRanges = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();

            int indexMonth = StartMonth;
            itineraryByMonthIndexViewModel.Months = itineraryMonthsList;

            foreach (var country in filterCountries.Where(c=>c != null))
            {
                   var seasonRange = _context.Ranges
                   .Where(d => d.CountryID == country.CountryID && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
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

                        itineraryByMonthIndexViewModel.CountryReport.Add(Description);
                    }
                    else
                    {
                        itineraryByMonthIndexViewModel.CountryReport = new List<string>();
                    }

                    indexMonth++;

                    if (indexMonth > 12) indexMonth = 1; 
                
            }

            return View("Index", itineraryByMonthIndexViewModel);
        }

        public async Task<IActionResult> Previous(int ShowingIndex, int StartMonth, int EndMonth)
        {
            ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();
            itineraryByMonthIndexViewModel.FilterStartMonth.MonthID = StartMonth;
            itineraryByMonthIndexViewModel.FilterEndMonth.MonthID = EndMonth;
            itineraryByMonthIndexViewModel.ShowingIndex = ShowingIndex - 1;

            return ProcessItinerary(ref itineraryByMonthIndexViewModel);
        }

        public async Task<IActionResult> Next(int ShowingIndex, int StartMonth, int EndMonth)
        {
            ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();
            itineraryByMonthIndexViewModel.FilterStartMonth.MonthID = StartMonth;
            itineraryByMonthIndexViewModel.FilterEndMonth.MonthID = EndMonth;
            itineraryByMonthIndexViewModel.ShowingIndex = ShowingIndex + 1;

            return ProcessItinerary(ref itineraryByMonthIndexViewModel);
        }

        private List<Domain.Ranges.Month>  CreateMonthList (int startMonth, int endMonth, List<Domain.Ranges.Month> completeMonthsList)
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

        private static List<Country> ViewModelContriesToList(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            List<Country> filterCountries = new List<Country>();
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry1);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry2);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry3);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry4);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry5);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry6);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry7);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry8);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry9);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry10);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry11);
            filterCountries.Add(itineraryByMonthIndexViewModel.FilterCountry12);
            return filterCountries;
        }    

        private ItineraryByMonthIndexViewModel CreateEmptyView(int StartMonth, int EndMonth ,string message)
        {
            List<Domain.Ranges.Month>? completeMonthsList = _context.Months.ToList();
            var itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();
            itineraryByMonthIndexViewModel.RulesReport = new List<string> { message };
            itineraryByMonthIndexViewModel.ItineraryMonths = -1;
            SelectList selectListStartMonthReload = new SelectList(completeMonthsList, "MonthID", "Name", StartMonth);
            itineraryByMonthIndexViewModel.SelectListStartMonth = selectListStartMonthReload;

            SelectList selectListEndMonthReload = new SelectList(completeMonthsList, "MonthID", "Name", EndMonth);
            itineraryByMonthIndexViewModel.SelectListEndMonth = selectListEndMonthReload;

            return itineraryByMonthIndexViewModel;
        }
    }
}

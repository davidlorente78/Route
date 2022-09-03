using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using StaticData;
using Traveller.Domain;
using Traveller.DomainServices;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace RouteDataManager.Controllers
{
    public class ItineraryByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        private ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();

        private List<char> route = new List<char> { };

        private IVisaService visaService;

        private IRouteService routeService;

        private ICountryService countryService;

        private int ShowingIndex = 0;


        public ItineraryByMonthController(ApplicationContext context, IVisaService visaService, IRouteService routeService, ICountryService countryService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;
            this.countryService = countryService;
        }

        public async Task<IActionResult> Index(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges)
                .ThenInclude(r => r.RangeType).Where(x => x.Ranges.Count != 0).ToList();

            List<Domain.Ranges.Month>? completeMonthsList = _context.Months.ToList();

            //Ajustar lista de meses a los datos introducidos por el usuario en el filtro de entrado y a la duracion del itinerary
            var StartMonth = itineraryByMonthIndexViewModel.FilterStartMonth.MonthID; //October
            var EndMonth = itineraryByMonthIndexViewModel.FilterEndMonth.MonthID; //December

            var monthsList = new List<Domain.Ranges.Month>();
            for (int x = StartMonth; x < EndMonth + 1; x++)
            {
                monthsList.Add(completeMonthsList.ElementAt(x - 1)); //Sin embargo la lista esta indexada desde 0
            }


            int ItineraryMonths = EndMonth - StartMonth + 1;

            if (ItineraryMonths > 6)
            {

                itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();
                itineraryByMonthIndexViewModel.RulesReport = new List<string> { "Too long to calculate" };
                itineraryByMonthIndexViewModel.ItineraryMonths = -1;

                return PartialView(itineraryByMonthIndexViewModel);

            }
            //Inicializacion Vector
            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            routeService.ruleContainer.Vector = new List<char>() { 'T', 'L', 'V' };

            //Inicializacion Reglas
            AddRules(countries, StartMonth, routeService.ruleContainer.Vector);

            var ProposedRoutes = routeService.proposedRoutes(ItineraryMonths);

            //Para cada Proposed Route

            if (ProposedRoutes.Count == 0)
            {

                itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();
                itineraryByMonthIndexViewModel.RulesReport = new List<string> { "We can not find any itinerary that acomplish all the rules" };
                itineraryByMonthIndexViewModel.ItineraryMonths = -1;
                return PartialView(itineraryByMonthIndexViewModel);

            }

            var InitialProposedRoute = ProposedRoutes[itineraryByMonthIndexViewModel.ShowingIndex];
            route = InitialProposedRoute;

            var brokenRules = routeService.BrokenRules(this.route);

            itineraryByMonthIndexViewModel.RulesReport = brokenRules;
            itineraryByMonthIndexViewModel.RoutesFoundCount = ProposedRoutes.Count;

            if (ItineraryMonths > 0) itineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.Code == route[0]).FirstOrDefault();
            if (ItineraryMonths > 1) itineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.Code == route[1]).FirstOrDefault();
            if (ItineraryMonths > 2) itineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.Code == route[2]).FirstOrDefault();
            if (ItineraryMonths > 3) itineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.Code == route[3]).FirstOrDefault();
            if (ItineraryMonths > 4) itineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.Code == route[4]).FirstOrDefault();
            if (ItineraryMonths > 5) itineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.Code == route[5]).FirstOrDefault();
            if (ItineraryMonths > 6) itineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.Code == route[6]).FirstOrDefault();
            if (ItineraryMonths > 7) itineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.Code == route[7]).FirstOrDefault();
            if (ItineraryMonths > 8) itineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.Code == route[8]).FirstOrDefault();
            if (ItineraryMonths > 9) itineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.Code == route[9]).FirstOrDefault();
            if (ItineraryMonths > 10) itineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.Code == route[10]).FirstOrDefault();
            if (ItineraryMonths > 11) itineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.Code == route[11]).FirstOrDefault();

            //Montar lista de filterCountry

            List<Country> filterCountries = ViewModelContriesToList(itineraryByMonthIndexViewModel);

            itineraryByMonthIndexViewModel = DataToViewModel(itineraryByMonthIndexViewModel, monthsList, completeMonthsList, filterCountries, ItineraryMonths, StartMonth);
            return PartialView(itineraryByMonthIndexViewModel);
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

                    routeService.ruleContainer.AddRule(new EachStayMustBeLessThanXMonth(country.Code, MaxStayMonth));
                    routeService.ruleContainer.AddRule(new AnualEntriesMustBeLessThanX(country.Code, 2));

                    //Warning Code
                    var monsoonEvaluatorRange = _context.Ranges
                        .Where(r => r.RangeType.Code == RangeTypes.MonsoonEvaluatorRangeType.Code && r.Country.Code == country.Code)
                        .Include(f => f.EntityEvaluator_ByMonth).ThenInclude(x => x.Items)
                        .FirstOrDefault();

                    //TODO Verificar que añade las reglas para el mes correcto
                    if (monsoonEvaluatorRange != null)
                    {
                        routeService.ruleContainer.AddRule(new MustConsiderWeather(monsoonEvaluatorRange.EntityEvaluator_ByMonth, country.Code, startRouteMonth));
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

        private ItineraryByMonthIndexViewModel DataToViewModel(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel, List<Domain.Ranges.Month> monthsList, List<Domain.Ranges.Month> completeMonthsList, List<Country> filterCountries, int ItineraryMonths, int StartMonth)
        {
            itineraryByMonthIndexViewModel.ItineraryMonths = ItineraryMonths;

            SelectList selectListStartMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryByMonthIndexViewModel.FilterStartMonth.MonthID);
            itineraryByMonthIndexViewModel.SelectListStartMonth = selectListStartMonth;

            SelectList selectListEndMonth = new SelectList(completeMonthsList, "MonthID", "Name", itineraryByMonthIndexViewModel.FilterEndMonth.MonthID);
            itineraryByMonthIndexViewModel.SelectListEndMonth = selectListEndMonth;

            var countriesWithRanges = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();

            int indexMonth = 0;
            itineraryByMonthIndexViewModel.Months = monthsList;

            foreach (var country in filterCountries)
            {
                var seasonRange = _context.Ranges
               .Where(d => d.CountryID == country.CountryID && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
               .Include(f => f.EntityDescription_ByMonth).ThenInclude(x => x.Items).FirstOrDefault();

                if (seasonRange != null)
                {
                    var Month = completeMonthsList[StartMonth - 1].Name; //Esto es la Key del diccionario que se va a consultar
                    ICollection<Domain.EntityFrameworkDictionary.DictionaryItem<string, string>>? MonsoonDictionary = seasonRange.EntityDescription_ByMonth.Items;
                    var Description = MonsoonDictionary.Where(x => x.Key == completeMonthsList[indexMonth].Name).FirstOrDefault().Value;
                    itineraryByMonthIndexViewModel.CountryReport.Add(Description);
                }
                else
                {
                    itineraryByMonthIndexViewModel.CountryReport = new List<string>();
                }

                indexMonth++;
            }

            return itineraryByMonthIndexViewModel;
        }

      
    }
}

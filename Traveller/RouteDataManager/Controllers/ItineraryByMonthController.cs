using Domain.Ranges;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using StaticData;
using Traveller.Domain;
using Traveller.DomainServices;
using Traveller.RouteService;

namespace RouteDataManager.Controllers
{
    public class ItineraryByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        private ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel = new ItineraryByMonthIndexViewModel();

        private List<char> route = new List<char> { 'T', 'L', 'V', 'C', 'M', 'M', 'M', 'T', 'T', 'V', 'L', 'T' };

        private IVisaService visaService;

        private IRouteService routeService;

        public ItineraryByMonthController(ApplicationContext context, IVisaService visaService, IRouteService routeService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;

        }

        public async Task<IActionResult> Index(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.Include(x=>x.Ranges).Where(x=>x.Ranges != null).ToList();
            var monthsList = _context.Months.ToList();

            var MaxStay = new Dictionary <char, int>();
            foreach (Country country in countries)
            {
                MaxStay.Add(country.Code, visaService.GetMaxStay(country.Code, "ES"));
            }

            var MaxStayMalaysia = visaService.GetMaxStay('M',"ES");
            var MaxStayThailand = visaService.GetMaxStay('T',"ES");

            var incumple = routeService.BrokenRules(this.route);

            itineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.Code == route[0]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.Code == route[1]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.Code == route[2]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.Code == route[3]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.Code == route[4]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.Code == route[5]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.Code == route[6]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.Code == route[7]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.Code == route[8]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.Code == route[9]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.Code == route[10]).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.Code == route[11]).FirstOrDefault();

            //Montar lista de filterCountry

            List<Country> filterCountries = ViewModelContriesToList(itineraryByMonthIndexViewModel);

            itineraryByMonthIndexViewModel = DataToViewModel(itineraryByMonthIndexViewModel, monthsList, filterCountries);
            return PartialView(itineraryByMonthIndexViewModel);
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

        public async Task<IActionResult> Reload(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.ToList();
            var monthsList = _context.Months.ToList();

            var route = new List<char> {

                itineraryByMonthIndexViewModel.FilterCountry1.Code,
                itineraryByMonthIndexViewModel.FilterCountry2.Code,
                itineraryByMonthIndexViewModel.FilterCountry3.Code,
                itineraryByMonthIndexViewModel.FilterCountry4.Code,
                itineraryByMonthIndexViewModel.FilterCountry5.Code,
                itineraryByMonthIndexViewModel.FilterCountry6.Code,
                itineraryByMonthIndexViewModel.FilterCountry7.Code,
                itineraryByMonthIndexViewModel.FilterCountry8.Code,
                itineraryByMonthIndexViewModel.FilterCountry9.Code,
                itineraryByMonthIndexViewModel.FilterCountry10.Code,
                itineraryByMonthIndexViewModel.FilterCountry11.Code,
                itineraryByMonthIndexViewModel.FilterCountry12.Code
            };

            var incumple = routeService.BrokenRules(route);

            itineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry1.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry2.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry3.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry4.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry5.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry6.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry7.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry8.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry9.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry10.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry11.CountryID).FirstOrDefault();
            itineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry12.CountryID).FirstOrDefault();

            List<Country> filterCountries = ViewModelContriesToList(itineraryByMonthIndexViewModel);
            itineraryByMonthIndexViewModel = DataToViewModel(itineraryByMonthIndexViewModel, monthsList, filterCountries);

            
            return PartialView("Index", itineraryByMonthIndexViewModel);
        }

        private ItineraryByMonthIndexViewModel DataToViewModel(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel, List<Month> monthsList, List<Country> filterCountries)
        {

            SelectList selectListCountries1 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry1.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries1 = selectListCountries1;

            SelectList selectListCountries2 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry2.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries2 = selectListCountries2;

            SelectList selectListCountries3 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry3.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries3 = selectListCountries3;

            SelectList selectListCountries4 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry4.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries4 = selectListCountries4;

            SelectList selectListCountries5 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry5.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries5 = selectListCountries5;

            SelectList selectListCountries6 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry6.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries6 = selectListCountries6;

            SelectList selectListCountries7 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry7.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries7 = selectListCountries7;

            SelectList selectListCountries8 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry8.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries8 = selectListCountries8;

            SelectList selectListCountries9 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry9.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries9 = selectListCountries9;

            SelectList selectListCountries10 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry10.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries10 = selectListCountries10;

            SelectList selectListCountries11 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry11.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries11 = selectListCountries11;

            SelectList selectListCountries12 = new SelectList(_context.Countries, "CountryID", "Name", itineraryByMonthIndexViewModel.FilterCountry12.CountryID);
            itineraryByMonthIndexViewModel.SelectListCountries12 = selectListCountries12;

            int indexMonth = 0;
            itineraryByMonthIndexViewModel.Months = monthsList;
            foreach (var country in filterCountries)
            {

                var seasonRange = _context.Ranges
               .Where(d => d.CountryID == country.CountryID && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
               .Include(f => f.EntityDescription_ByMonth).ThenInclude(x => x.Dictionary).FirstOrDefault();

                if (seasonRange != null)
                {

                    var Month = monthsList[0].Name; //Esto es la Key del diccionario que se va a consultar
                    ICollection<Domain.EntityFrameworkDictionary.DictionaryItem<string>>? MonsoonDictionary = seasonRange.EntityDescription_ByMonth.Dictionary;
                    var Description = MonsoonDictionary.Where(x => x.DictionaryKey == monthsList[indexMonth].Name).FirstOrDefault().DictionaryValue;
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

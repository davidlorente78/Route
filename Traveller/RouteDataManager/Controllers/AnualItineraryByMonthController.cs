﻿using Data.EntityTypes;
using Domain.EntityFrameworkDictionary;
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
    public class AnualItineraryByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        private AnualItineraryByMonthIndexViewModel anualItineraryByMonthIndexViewModel = new AnualItineraryByMonthIndexViewModel();

        private List<char> route = new List<char> { 'M', 'L', 'V', 'N', 'V', 'M', 'M', 'M', 'T', 'C', 'L', 'T' };

        private IVisaService visaService;

        private IRouteService routeService;

        private ICountryService countryService;


        public AnualItineraryByMonthController(ApplicationContext context, IVisaService visaService, IRouteService routeService, ICountryService countryService)
        {
            _context = context;
            this.visaService = visaService;
            this.routeService = routeService;
            this.countryService = countryService;
        }

        public async Task<IActionResult> Index(AnualItineraryByMonthIndexViewModel anualItineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges)

                .ThenInclude(r => r.RangeType).Where(x => x.Ranges.Count != 0).ToList();
            var monthsList = _context.Months.ToList();

            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            AddRules(countries);

            var brokenRules = routeService.BrokenRules(this.route);
            anualItineraryByMonthIndexViewModel.RulesReport = brokenRules;

            anualItineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.Code == route[0]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.Code == route[1]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.Code == route[2]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.Code == route[3]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.Code == route[4]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.Code == route[5]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.Code == route[6]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.Code == route[7]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.Code == route[8]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.Code == route[9]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.Code == route[10]).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.Code == route[11]).FirstOrDefault();

            //Montar lista de filterCountry

            List<Country> filterCountries = ViewModelContriesToList(anualItineraryByMonthIndexViewModel);

            anualItineraryByMonthIndexViewModel = DataToViewModel(anualItineraryByMonthIndexViewModel, monthsList, filterCountries);
            return PartialView(anualItineraryByMonthIndexViewModel);
        }

        private void AddRules(List<Country> countries)
        {
            //TODO INPUT PARAM NATIONALITY
            var MaxStayMalaysia = visaService.GetMaxStay('M', "ES");
            var MaxStayThailand = visaService.GetMaxStay('T', "ES");

            var MaxStay = new Dictionary<char, int>();

            foreach (Country country in countries)
            {
                var MaxStayDays = visaService.GetMaxStay(country.Code, "ES");
                var MaxStayMonth = MaxStayDays / 30;
                MaxStay.Add(country.Code, visaService.GetMaxStay(country.Code, "ES"));

                routeService.ruleContainer.AddRule(new EachStayMustBeLessThanXMonth(country.Code, MaxStayMonth));
                routeService.ruleContainer.AddRule(new AnualEntriesMustBeLessThanX(country.Code, 1)); //Numero de entradas anuales limitadas a 

                //var countryWithRanges = countryService.GetCountryRangesByCode(country.Code);

                //Warning Code
                var monsoonEvaluatorRange = _context.Ranges
                    .Where(r => r.RangeType.Code == RangeTypes.MonsoonEvaluatorRangeType.Code && r.Country.Code == country.Code)
                    .Include(f => f.EntityEvaluator_ByMonth).ThenInclude(x => x.Items)
                    .FirstOrDefault();

                var startRouteMonth = 1;
                var strict = true;
                if (monsoonEvaluatorRange != null)
                {
                    routeService.ruleContainer.AddRule(new MustConsiderWeather(monsoonEvaluatorRange.EntityEvaluator_ByMonth, country.Code, startRouteMonth, strict));
                }

            }
        }

        private static List<Country> ViewModelContriesToList(AnualItineraryByMonthIndexViewModel anualItineraryByMonthIndexViewModel)
        {
            List<Country> filterCountries =
            [
                anualItineraryByMonthIndexViewModel.FilterCountry1,
                anualItineraryByMonthIndexViewModel.FilterCountry2,
                anualItineraryByMonthIndexViewModel.FilterCountry3,
                anualItineraryByMonthIndexViewModel.FilterCountry4,
                anualItineraryByMonthIndexViewModel.FilterCountry5,
                anualItineraryByMonthIndexViewModel.FilterCountry6,
                anualItineraryByMonthIndexViewModel.FilterCountry7,
                anualItineraryByMonthIndexViewModel.FilterCountry8,
                anualItineraryByMonthIndexViewModel.FilterCountry9,
                anualItineraryByMonthIndexViewModel.FilterCountry10,
                anualItineraryByMonthIndexViewModel.FilterCountry11,
                anualItineraryByMonthIndexViewModel.FilterCountry12,
            ];
            return filterCountries;
        }

        public async Task<IActionResult> Reload(AnualItineraryByMonthIndexViewModel anualItineraryByMonthIndexViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();
            var monthsList = _context.Months.ToList();

            routeService.ruleContainer.Vector = countries.Select(c => c.Code).Distinct().ToList();

            AddRules(countries);

            //Recover from ID
            anualItineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry1.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry2.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry3.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry4.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry5.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry6.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry7.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry8.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry9.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry10.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry11.Id).FirstOrDefault();
            anualItineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.Id == anualItineraryByMonthIndexViewModel.FilterCountry12.Id).FirstOrDefault();


            var route = new List<char> {

                anualItineraryByMonthIndexViewModel.FilterCountry1.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry2.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry3.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry4.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry5.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry6.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry7.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry8.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry9.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry10.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry11.Code,
                anualItineraryByMonthIndexViewModel.FilterCountry12.Code
            };

            var brokenRules = routeService.BrokenRules(route);
            anualItineraryByMonthIndexViewModel.RulesReport = brokenRules;


            List<Country> filterCountries = ViewModelContriesToList(anualItineraryByMonthIndexViewModel);
            anualItineraryByMonthIndexViewModel = DataToViewModel(anualItineraryByMonthIndexViewModel, monthsList, filterCountries);


            return PartialView("Index", anualItineraryByMonthIndexViewModel);
        }

        private AnualItineraryByMonthIndexViewModel DataToViewModel(AnualItineraryByMonthIndexViewModel anulItineraryByMonthIndexViewModel, List<Domain.Ranges.Month> monthsList, List<Country> filterCountries)
        {

            var countriesWithRanges = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();

            SelectList selectListCountries1 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry1.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries1 = selectListCountries1;

            SelectList selectListCountries2 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry2.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries2 = selectListCountries2;

            SelectList selectListCountries3 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry3.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries3 = selectListCountries3;

            SelectList selectListCountries4 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry4.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries4 = selectListCountries4;

            SelectList selectListCountries5 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry5.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries5 = selectListCountries5;

            SelectList selectListCountries6 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry6.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries6 = selectListCountries6;

            SelectList selectListCountries7 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry7.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries7 = selectListCountries7;

            SelectList selectListCountries8 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry8.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries8 = selectListCountries8;

            SelectList selectListCountries9 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry9.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries9 = selectListCountries9;

            SelectList selectListCountries10 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry10.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries10 = selectListCountries10;

            SelectList selectListCountries11 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry11.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries11 = selectListCountries11;

            SelectList selectListCountries12 = new SelectList(countriesWithRanges, "CountryID", "Name", anulItineraryByMonthIndexViewModel.FilterCountry12.Id);
            anulItineraryByMonthIndexViewModel.SelectListCountries12 = selectListCountries12;

            int indexMonth = 0;
            anulItineraryByMonthIndexViewModel.Months = monthsList;

            foreach (var country in filterCountries)
            {

                var seasonRange = _context.Ranges
               .Where(d => d.CountryID == country.Id && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
               .Include(f => f.EntityDescription_ByMonth).ThenInclude(x => x.Items).FirstOrDefault();

                if (seasonRange != null)
                {

                    var Month = monthsList[0].Name; //Esto es la Key del diccionario que se va a consultar
                    ICollection<DictionaryItem<string, string>>? MonsoonDictionary = seasonRange.EntityDescription_ByMonth.Items;
                    var Description = MonsoonDictionary.Where(x => x.Key == monthsList[indexMonth].Name).FirstOrDefault().Value;
                    anulItineraryByMonthIndexViewModel.CountryReport.Add(Description);

                }
                else
                {
                    anulItineraryByMonthIndexViewModel.CountryReport = new List<string>();
                }

                indexMonth++;


            }

            return anulItineraryByMonthIndexViewModel;
        }

        //TODO
        //public void Save(ItineraryByMonthIndexViewModel itineraryByMonthIndexViewModel)
        //{
        //    var countries = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();
        //    //Recover from ID
        //    itineraryByMonthIndexViewModel.FilterCountry1 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry1.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry2 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry2.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry3 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry3.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry4 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry4.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry5 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry5.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry6 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry6.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry7 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry7.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry8 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry8.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry9 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry9.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry10 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry10.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry11 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry11.CountryID).FirstOrDefault();
        //    itineraryByMonthIndexViewModel.FilterCountry12 = countries.Where(x => x.CountryID == itineraryByMonthIndexViewModel.FilterCountry12.CountryID).FirstOrDefault();

        //    string countryCodeChars =

        //        itineraryByMonthIndexViewModel.FilterCountry1.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry2.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry3.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry4.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry5.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry6.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry7.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry8.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry9.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry10.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry11.Code.ToString() +
        //        itineraryByMonthIndexViewModel.FilterCountry12.Code.ToString();

        //    var route = new Traveller.Domain.Route { CountryCodeChars = countryCodeChars };

        //    _context.Routes.Add(route);
        //    _context.SaveChanges();

        //    this.Reload(itineraryByMonthIndexViewModel);
        //}
    }
}

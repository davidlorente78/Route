using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class TourismSeasonsByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        public TourismSeasonsByMonthController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(SeasonIndexByMonthViewModel seasonIndexByMonthViewModel)
        {
            var countries = _context.Countries.ToList();
            var seasonRange = _context.Ranges
                 .Where(d => d.RangeType == "SeasonRange")
                 .Include(f => f.entityFrameworkDictionaryMonthEntityDescriptionKey)
                 .ThenInclude(f => f.Dictionary)                
                 .Include(f => f.entityFrameworkDictionaryEntityDescriptions)
                 .ThenInclude(f => f.Dictionary);


            var month = _context.Months.Where(x => x.MonthID == seasonIndexByMonthViewModel.FilterMonth.MonthID).FirstOrDefault();
            seasonIndexByMonthViewModel.FilterMonth = month;

            
            foreach (var country in countries) 
            {               
                    var Season = seasonRange.Where(x => x.CountryID == country.CountryID).Select(x => x.entityFrameworkDictionaryMonthEntityDescriptionKey.Dictionary.Where(d => d.DictionaryKey == seasonIndexByMonthViewModel.FilterMonth.Name).FirstOrDefault());

                    if (Season.Count() != 0) {
                        var SeasonDictionary = Season.ToDictionary(x => x.DictionaryKey, x => x.DictionaryValue);

                        string StringSeasonChar = SeasonDictionary.GetValueOrDefault(seasonIndexByMonthViewModel.FilterMonth.Name);

                        char SeasonChar = StringSeasonChar.ToCharArray()[0];


                        var SeasonDescriptions = seasonRange.Where(x => x.CountryID == country.CountryID).Select(x => x.entityFrameworkDictionaryEntityDescriptions).FirstOrDefault();

                        var SeasonDescriptionsDictionary = SeasonDescriptions.Dictionary.ToDictionary(x => x.DictionaryKey, x => x.DictionaryValue);


                        var SeasonDescription = SeasonDescriptionsDictionary.GetValueOrDefault(SeasonChar);

                        seasonIndexByMonthViewModel.Country_SeasonDescription.Add(country.Name, SeasonDescription);
                    }
              
            }

            SelectList selectListMonth = new SelectList(_context.Months, "MonthID", "Name", seasonIndexByMonthViewModel.FilterMonth.MonthID);


            seasonIndexByMonthViewModel.SelectListMonth= selectListMonth;
            return PartialView(seasonIndexByMonthViewModel);
        }


    }
}

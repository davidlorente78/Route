using Domain.Ranges;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class SeasonsController : Controller
    {
        private readonly ApplicationContext _context;

        public SeasonsController(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(SeasonIndexViewModel seasonIndexViewModel)
        {
            var seasonRange = _context.Ranges
                 .Where(d => d.CountryID == seasonIndexViewModel.FilterCountry.CountryID)
                 .Include(f => f.entityFrameworkDictionaryMonthSeason).ThenInclude(x => x.Dictionary)
                 .Include(f => f.entityFrameworkDictionarySeasonsDescriptions).ThenInclude(x => x.Dictionary).FirstOrDefault();
            
            //Para cada mes
            foreach (var item in seasonRange.entityFrameworkDictionaryMonthSeason.Dictionary)
            {
                var Month = item.DictionaryKey;
                var SeasonDescription = seasonRange.entityFrameworkDictionarySeasonsDescriptions.Dictionary.Where(x => (x.DictionaryKey).ToString() == item.DictionaryValue).Select(x => x.DictionaryValue).First();
                seasonIndexViewModel.Month_SeasonDescription.Add(Month, SeasonDescription);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", seasonIndexViewModel.FilterCountry.CountryID);

            seasonIndexViewModel.SelectListCountries = selectListCountries;
            return PartialView(seasonIndexViewModel);
        }


    }
}

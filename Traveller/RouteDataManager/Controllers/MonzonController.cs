using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class MonzonController : Controller
    {
        private readonly ApplicationContext _context;

        public MonzonController(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(Month_EntityByCountryIndexViewModel month_EntityByCountryIndexViewModel)
        {
            var seasonRange = _context.Ranges
                 .Where(d => d.CountryID == month_EntityByCountryIndexViewModel.FilterCountry.CountryID && d.RangeType == "MonzonRange")
                 .Include(f => f.entityFrameworkDictionaryMonthEntityDescriptionKey).ThenInclude(x => x.Dictionary).FirstOrDefault();

            if (seasonRange != null)
            {
                //Para cada mes
                foreach (var item in seasonRange.entityFrameworkDictionaryMonthEntityDescriptionKey.Dictionary)
                {
                    var Month = item.DictionaryKey;
                    var Description = item.DictionaryValue;
                    month_EntityByCountryIndexViewModel.Month_EntityDescription.Add(Month, Description);
                }
            }
            else {
                month_EntityByCountryIndexViewModel.Month_EntityDescription = new Dictionary<string, string>();
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", month_EntityByCountryIndexViewModel.FilterCountry.CountryID);

            month_EntityByCountryIndexViewModel.SelectListCountries = selectListCountries;
            return PartialView(month_EntityByCountryIndexViewModel);
        }

    }
}
